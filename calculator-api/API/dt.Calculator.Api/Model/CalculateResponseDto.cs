using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dt.Calculator.Model.Common;
using Newtonsoft.Json;

namespace dt.Calculator.Api.Model
{
    /// <summary>
    /// Calculated values response
    /// </summary>
    public class CalculateResponseDto
    {
        /// <summary>
        /// The method used to calculate duty
        /// CIF Cost of merchandise including Insurance & Freight 
        /// FOB Freight/Free on board, merchandise cost only
        /// </summary>
        [JsonProperty(Order = 1)]
        public Enumerations.CalculationMethodEnum DutyCalculationMethod { get; set; }

        /// <summary>
        /// The amount of Duty due in the landed local currency
        /// </summary>
        [JsonProperty(Order = 2)]
        public decimal? Duty { get; set; }

        /// <summary>
        /// The duty threshold before duties are applied
        /// </summary>
        [JsonProperty(Order = 3)]
        public decimal? DutyThreshold { get; set; }
        
        /// <summary>
        /// The rate that was used to calculate the duty
        /// </summary>
        [JsonProperty(Order = 4)]
        public decimal? DutyRate { get; set; }

        /// <summary>
        /// The minimum duty payable
        /// </summary>
        [JsonProperty(Order = 5)]
        public decimal? DutyMinimum { get; set; }

        /// <summary>
        /// The maximum duty payable
        /// </summary>
        [JsonProperty(Order = 6)]
        public decimal? DutyMaximum { get; set; }

        /// <summary>
        /// The method used to calculate tax
        /// CIF Cost of merchandise including Insurance & Freight 
        /// FOB Freight/Free on board, merchandise cost only
        /// </summary>
        [JsonProperty(Order = 7)]
        public Enumerations.CalculationMethodEnum TaxCalculationMethod { get; set; }

        /// <summary>
        /// The amount of Tax/Gst due in the landed local currency
        /// </summary>
        [JsonProperty(Order = 8)]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The rate that was used to calculate the tax
        /// </summary>
        [JsonProperty(Order = 9)]
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// The tax threshold before taxes are applied
        /// </summary>
        [JsonProperty(Order = 10)]
        public decimal? TaxThreshold { get; set; }

        /// <summary>
        /// The amount of Fees due in the landed local currency
        /// </summary>
        [JsonProperty(Order = 11)]
        public decimal? Fees { get; set; }

        /// <summary>
        /// The rate that fees are calculated
        /// </summary>
        [JsonProperty(Order = 12)]
        public decimal? FeeRate { get; set; }

        /// <summary>
        /// The threshold before fees are applicable
        /// </summary>
        [JsonProperty(Order = 13)]
        public decimal? FeeThreshold { get; set; }
        
        /// <summary>
        /// Other taxes
        /// </summary>
        [JsonProperty(Order = 14)]
        public decimal? OtherTaxes { get; set; }

        /// <summary>
        /// The threshold before other taxes are applicable
        /// </summary>
        [JsonProperty(Order = 15)]
        public decimal? OtherTaxesThreshold { get; set; }

        /// <summary>
        /// The rate at which other taxes are calculated
        /// </summary>
        [JsonProperty(Order = 16)]
        public decimal? OtherTaxesRate { get; set; }


    }
}
