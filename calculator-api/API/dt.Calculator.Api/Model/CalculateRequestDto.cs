using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using dt.Calculator.Api.Infratstructure.Validation;
using FluentValidation.Attributes;

namespace dt.Calculator.Api.Model
{
    /// <summary>
    /// Calculate request
    /// </summary>
    [Validator(typeof (CalculatorRequestValidator))]
    public class CalculateRequestDto
    {
        /// <summary>
        /// Two letter countryIso
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string ShippingFromCountryIso { get; set; }

        /// <summary>
        /// Two letter countryIso
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string ShippingToCountryIso { get; set; }

        /// <summary>
        /// The total cost of merchandise
        /// </summary>
        [Required, Range(0, int.MaxValue)]
        public decimal MerchandiseTotal { get; set; }

        /// <summary>
        /// The total cost of shipping
        /// </summary>
        [Required]
        public decimal ShippingTotal { get; set; }

        /// <summary>
        /// The total cost of insurance
        /// </summary>
        public decimal? InsuranceTotal { get; set; }

        /// <summary>
        /// For standard rate override
        /// </summary>
        public decimal? DutyRate { get; set; }

        /// <summary>
        /// For standard rate override
        /// </summary>
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// For canada
        /// </summary>
        [MaxLength(2)]
        public string CanadianProvinceCode { get; set; }
    }
}
