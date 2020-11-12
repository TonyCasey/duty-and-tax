using System;
using System.Collections.Generic;
using System.Text;
using dt.Calculator.Model.Common;
using dt.Calculator.Model.Domain.Calculator;

namespace dt.Calculator.Database.Seed
{
    /*  See StandardCalculateRegionDutyAndTaxes
        and
        Select top 1 * From Calc.CountryDuty Where CountryIso = 'IE' Order by 1 DESC
        Select * From Calc.CountryVat Where CountryIso = 'IE' AND vatBandId = 1
        Select * From Calc.CalcSettings Where SettingType like 'IE%'
        or this https://www.importdutycalc.com/country-guides/Import-duty-taxes-when-importing-into-Andorra/
    */
    public static class CalculatorSettingsSeed
    {
        public static List<CalculatorSetting> GetCalculatorSettings()
        {
            List<CalculatorSetting> calculatorSettings = new List<CalculatorSetting>()
            {
                new CalculatorSetting()
                {
                    CalculatorSettingId = 1,
                    Name = "Default Calculator",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",
                    CurrencyIso = "USD",

                    DutyApplicable = false,

                    TaxApplicable = false,

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 2,
                    Name = "EU Calculator",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",
                    CurrencyIso = "EUR",

                    DutyApplicable = false,

                    TaxApplicable = false,

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 3,
                    Name = "UK Calculator",
                    CountryIso = Enumerations.CountryEnum.GB.ToString(),
                    CurrencyIso = "GBP",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 135.00M,
                    DutyRate = 0.05m,

                    TaxApplicable = true,
                    TaxCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    TaxThreshold = 15M,
                    TaxThresholdForGifts = 39M,
                    TaxIncludesDuty = true,
                    TaxRate = 0.20m

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 4,
                    Name = "Oz Calculator",
                    CountryIso = Enumerations.CountryEnum.AU.ToString(),
                    CurrencyIso = "AUD",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 1000.00M,
                    DutyRate = 0.1m, // 10% Max

                    TaxApplicable = true,
                    TaxThreshold = 0,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.10m,

                    FeesApplicable = true,
                    FeeThreshold = 1000,
                    Fee = 83

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 6,
                    Name = "Ireland Calculator",
                    CountryIso = Enumerations.CountryEnum.IE.ToString(),
                    CurrencyIso = "EUR",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 150,
                    DutyRate = 0.12m, 

                    TaxApplicable = true,
                    TaxThreshold = 22,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.23m,
                    MinimumTaxPayable = 6,

                    FeesApplicable = false,

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 7,
                    Name = "Canadian Calculator",
                    CountryIso = Enumerations.CountryEnum.CA.ToString(),
                    CurrencyIso = "CAD",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Fob,
                    DutyThreshold = 20,
                    DutyRate = 0.19m, 

                    TaxApplicable = true,
                    TaxThreshold = 20,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.113m,

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 8,
                    Name = "United Arab Emirates",
                    CountryIso = Enumerations.CountryEnum.CA.ToString(),
                    CurrencyIso = "AED",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 1000,
                    DutyRate = 0.0461m, 

                    TaxApplicable = false,

                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 9,
                    Name = "Bahrain Calculator",
                    CountryIso = Enumerations.CountryEnum.BH.ToString(),
                    CurrencyIso = "BHD",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 113,
                    DutyRate = 0.05m, 

                    TaxApplicable = false
                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 10,
                    Name = "Switzerland Calculator",
                    CountryIso = Enumerations.CountryEnum.CH.ToString(),
                    CurrencyIso = "CHF",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 113,
                    DutyRate = 0.16m, 

                    TaxApplicable = true,
                    TaxThreshold = 300,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.077m,
                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 11,
                    Name = "China Calculator",
                    CountryIso = Enumerations.CountryEnum.CN.ToString(),
                    CurrencyIso = "CNY",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 50,
                    DutyRate = 0.02m, 

                    TaxApplicable = true,
                    TaxThreshold = 50,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.17m,
                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 12,
                    Name = "Chile Calculator",
                    CountryIso = Enumerations.CountryEnum.CL.ToString(),
                    CurrencyIso = "CLP",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 30,
                    DutyRate = 0.06m, 

                    TaxApplicable = true,
                    TaxThreshold = 0,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.19m, 
                },
                new CalculatorSetting()
                {
                    CalculatorSettingId = 13,
                    Name = "Hong Kong Calculator",
                    CountryIso = Enumerations.CountryEnum.HK.ToString(),
                    CurrencyIso = "HKD",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 30,
                    DutyRate = 0.06m, 

                    TaxApplicable = true,
                    TaxThreshold = 0,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.19m, 
                },

                // EUROPE
                new CalculatorSetting()
                {
                    CalculatorSettingId = 14,
                    Name = "Andora Calculator",
                    CountryIso = Enumerations.CountryEnum.HK.ToString(),
                    CurrencyIso = "EUR",
                    CreationTime = DateTime.Now,
                    CreationUser = "Seed",

                    DutyApplicable = true,
                    DutyCalculationMethod = Enumerations.CalculationMethodEnum.Cif,
                    DutyThreshold = 30,
                    DutyRate = 0.06m, 

                    TaxApplicable = true,
                    TaxThreshold = 0,
                    TaxThresholdForGifts = 0,
                    TaxIncludesDuty = true,
                    TaxRate = 0.19m, 
                },
            };

            int index = 1;
            foreach (CalculatorSetting calculatorSetting in calculatorSettings)
            {
                calculatorSetting.CalculatorSettingId = index;
                ++index;
            }

            return calculatorSettings;
        }
    }
}
