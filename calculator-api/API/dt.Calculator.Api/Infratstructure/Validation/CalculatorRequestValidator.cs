using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dt.Calculator.Api.Model;
using FluentValidation;

namespace dt.Calculator.Api.Infratstructure.Validation
{
    /// <summary>
    // Validate the Calculator Request
    /// </summary>
    public class CalculatorRequestValidator  : AbstractValidator<CalculateRequestDto>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CalculatorRequestValidator()
        {
            RuleFor(m => m.MerchandiseTotal)
                .NotEmpty()
                .GreaterThan(1)
                .WithMessage("You must speicify the merchandise total");

            RuleFor(m => m.ShippingTotal)
                .NotEmpty()
                .GreaterThan(1)
                .WithMessage("You must speicify the shipping total");

            RuleFor(m => m.ShippingFromCountryIso)
                .NotEmpty()
                .WithMessage("ShippingFromCountryIso must be included");

            RuleFor(m => m.ShippingToCountryIso)
                .NotEmpty()
                .WithMessage("ShippingToCountryIso must be included");

            RuleFor(m => m.CanadianProvinceCode)
                .NotEmpty()
                .When(x => x.ShippingToCountryIso.ToUpper() == "CA")
                .WithMessage("CanadianProvinceCode must not be null when ShippingToCountryIso = CA ");
                
           
        }
    }
}
