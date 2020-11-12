using System;
using System.Linq;
using AutoMapper;
using dt.Calculator.Api.Model;
using dt.Calculator.Database;
using dt.Calculator.Model.Common;
using dt.Calculator.Model.Domain.Calculator;
using Microsoft.EntityFrameworkCore;

namespace dt.Calculator.Api.Services
{
    /// <summary>
    /// Calculator service
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        private readonly DtDbContext _dbContext;
        private readonly IMapper _mapper;
        private Calculator.Model.Domain.Calculator.Calculator _calculator;
        private CalculatorSetting _calculatorSetting;

        private decimal _duty = 0M;
        private decimal _tax = 0M;
        private decimal _fees = 0M;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        public CalculatorService(DtDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        /// <summary>
        /// Calculate
        /// </summary>
        /// <param name="requestDto"></param>
        /// <returns></returns>
        public CalculateResponseDto Calculate(CalculateRequestDto requestDto)
        {
            CalculateResponseDto response;

            _calculator = GetCalculator(requestDto.ShippingToCountryIso);
            _calculatorSetting = _calculator.CalculatorSetting;

            // DutyRate override
            if (requestDto.DutyRate != null && requestDto.DutyRate > 0)
                _calculatorSetting.DutyRate = requestDto.DutyRate.GetValueOrDefault();

            // TaxRate override
            if (requestDto.TaxRate != null && requestDto.TaxRate > 0)
                _calculatorSetting.TaxRate = requestDto.TaxRate.GetValueOrDefault();

            // intra region? Don't charge duty
            if (_dbContext.Countries.FirstOrDefault(x => x.Iso == requestDto.ShippingFromCountryIso)?.RegionId ==
                _dbContext.Countries.FirstOrDefault(x => x.Iso == requestDto.ShippingToCountryIso)?.RegionId)
                _calculatorSetting.DutyApplicable = false;

            if (_calculator.CalculatorSetting.DutyApplicable)
                _duty = CalculateDuty(_calculatorSetting, requestDto.MerchandiseTotal, requestDto.ShippingTotal,
                    requestDto.InsuranceTotal.GetValueOrDefault());

            if (_calculatorSetting.FeesApplicable)
                _fees = CalculateFees(_calculatorSetting, requestDto.MerchandiseTotal);

            if (_calculatorSetting.TaxApplicable)
                _tax = CalculateTax(_calculatorSetting, requestDto.MerchandiseTotal, requestDto.ShippingTotal,
                    requestDto.InsuranceTotal.GetValueOrDefault(), _duty, _fees);

            


            // For Canada
            if (requestDto.ShippingToCountryIso.ToUpper() == Enumerations.CountryEnum.CA.ToString())
            {

                return _mapper.Map(_calculatorSetting, new CanadaCalculateResponseDto()
                {
                    Duty = _duty,
                    Tax = CalculateCanadianTax(requestDto.CanadianProvinceCode, requestDto.MerchandiseTotal, _duty,
                        Enumerations.CanadianTaxTypeEnum.Gst),
                    Pst = CalculateCanadianTax(requestDto.CanadianProvinceCode, requestDto.MerchandiseTotal, _duty,
                        Enumerations.CanadianTaxTypeEnum.Pst),
                    PstRate = GetCanadianPstRate(requestDto.CanadianProvinceCode)
                });
            }
            
            // Standard response
            return _mapper.Map(_calculatorSetting, new CalculateResponseDto()
            {
                Duty = _duty,
                Tax = _tax,
                Fees = _fees
            });
            

        }


        private Calculator.Model.Domain.Calculator.Calculator GetCalculator(string countrIso)
        {
            return _dbContext
                .Calculators
                .Include(x => x.CalculatorSetting)
                .AsNoTracking()
                .FirstOrDefault(x => x.CountryIso == countrIso);
        }

        /// <summary>
        /// Calculate the duty
        /// </summary>
        /// <param name="calculatorSetting"></param>
        /// <param name="merchandise"></param>
        /// <param name="shipping"></param>
        /// <param name="insurance"></param>
        /// <returns></returns>
        public decimal CalculateDuty(CalculatorSetting calculatorSetting, decimal merchandise, decimal shipping,
            decimal insurance)
        {
            decimal duty = 0;
            decimal total = merchandise;

            if (calculatorSetting.DutyCalculationMethod == Enumerations.CalculationMethodEnum.Cif)
            {
                // includes shipping and insurance
                total = merchandise + shipping + insurance;
            }

            if (total > calculatorSetting.DutyThreshold)
            {
                duty = total * calculatorSetting.DutyRate;
            }

            if (duty < calculatorSetting.MinimumDutyPayable)
                duty = calculatorSetting.MinimumDutyPayable;

            if (calculatorSetting.MaximumDutyPayable > 0 && duty > calculatorSetting.MaximumDutyPayable)
                duty = calculatorSetting.MaximumDutyPayable;

            return duty;
        }

        /// <summary>
        /// Calculate the fees
        /// </summary>
        /// <param name="calculatorSetting"></param>
        /// <param name="merchandise"></param>
        /// <returns></returns>
        public decimal CalculateFees(CalculatorSetting calculatorSetting, decimal merchandise)
        {
            if (calculatorSetting.Fee > 0)
                return calculatorSetting.Fee;

            if (calculatorSetting.FeeRate > 0)
            {
                // TODO: Possible fee CIF or other combination

                return merchandise * calculatorSetting.FeeRate;
            }

            return 0M;
        }

        /// <summary>
        /// Calculate the tax due
        /// </summary>
        /// <param name="calculatorSetting"></param>
        /// <param name="merchandise"></param>
        /// <param name="shipping"></param>
        /// <param name="insurance"></param>
        /// <param name="duty"></param>
        /// <param name="fees"></param>
        /// <returns></returns>
        public decimal CalculateTax(CalculatorSetting calculatorSetting, decimal merchandise, decimal shipping,
            decimal insurance, decimal duty, decimal fees)
        {
            decimal tax = 0m;
            decimal total = merchandise;

            if (calculatorSetting.TaxCalculationMethod == Enumerations.CalculationMethodEnum.Cif)
            {
                total = merchandise + shipping + insurance;
            }

            if (calculatorSetting.TaxIncludesDuty)
                total += duty;

            if (calculatorSetting.TaxIncludesFees)
                total += fees;

            tax = total * calculatorSetting.TaxRate;

            if (tax < calculatorSetting.MinimumTaxPayable)
                tax = calculatorSetting.MinimumTaxPayable;

            if (calculatorSetting.MaximumTaxPayable > 0 && tax > calculatorSetting.MaximumTaxPayable)
                tax = calculatorSetting.MaximumTaxPayable;

            return tax;
        }

        /// <summary>
        /// Specifically for Canada
        /// </summary>
        /// <param name="stateCode"></param>
        /// <param name="merchandise"></param>
        /// <param name="duty"></param>
        /// <param name="canadianTaxType"></param>
        /// <returns></returns>
        public decimal CalculateCanadianTax(string stateCode, decimal merchandise, decimal duty,
            Enumerations.CanadianTaxTypeEnum canadianTaxType)
        {
            var canadianProvincialTaxRate =
                _dbContext.CanadianProvincialTaxRates.FirstOrDefault(x => x.StateCode.ToUpper() == stateCode.ToUpper());

            if (canadianProvincialTaxRate != null)
            {
                switch (canadianTaxType)
                {
                    case Enumerations.CanadianTaxTypeEnum.Gst:

                        decimal rate = canadianProvincialTaxRate?.GstRate > 0
                            ? canadianProvincialTaxRate.GstRate
                            : canadianProvincialTaxRate.HstRate;
                        return (merchandise + duty) * rate;

                    case Enumerations.CanadianTaxTypeEnum.Pst:

                        return (merchandise + duty) * canadianProvincialTaxRate.PstRate;

                    default:
                        return 0;
                }
            }

            return 0;
        }

        private decimal GetCanadianPstRate(string stateCode){

            var canadianProvincialTaxRate =
                _dbContext.CanadianProvincialTaxRates.FirstOrDefault(x => x.StateCode.ToUpper() == stateCode.ToUpper());

            return canadianProvincialTaxRate.PstRate;
        }
    }

    


    /// <summary>
    /// Calculate service interface
    /// </summary>
    public interface ICalculatorService
    {
        CalculateResponseDto Calculate(CalculateRequestDto requestDto);

        /// <summary>
        /// Calculate Duty
        /// </summary>
        /// <param name="calculatorSetting"></param>
        /// <param name="merchandise"></param>
        /// <param name="shipping"></param>
        /// <param name="insurance"></param>
        /// <returns></returns>
        decimal CalculateDuty(CalculatorSetting calculatorSetting, decimal merchandise, decimal shipping,
            decimal insurance);

        /// <summary>
        /// Calculate fees
        /// </summary>
        /// <param name="calculatorSetting"></param>
        /// <param name="merchandise"></param>
        /// <returns></returns>
        decimal CalculateFees(CalculatorSetting calculatorSetting, decimal merchandise);

        /// <summary>
        /// Calculate taxes
        /// </summary>
        /// <param name="calculatorSetting"></param>
        /// <param name="merchandise"></param>
        /// <param name="shipping"></param>
        /// <param name="insurance"></param>
        /// <param name="duty"></param>
        /// <param name="fees"></param>
        /// <returns></returns>
        decimal CalculateTax(CalculatorSetting calculatorSetting, decimal merchandise, decimal shipping,
            decimal insurance, decimal duty, decimal fees);
    }
}