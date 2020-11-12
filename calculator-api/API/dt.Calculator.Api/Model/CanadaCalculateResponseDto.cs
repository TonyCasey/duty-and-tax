using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dt.Calculator.Api.Model
{
    /// <summary>
    /// A response specifically for Canadian calcultions
    /// that includes Provincial Tax
    /// </summary>
    public class CanadaCalculateResponseDto : CalculateResponseDto
    {
        /// <summary>
        /// Provincial tax amount
        /// </summary>
        [JsonProperty(Order = 25)]
        public decimal Pst { get; set; }

        /// <summary>
        /// The pst rate that is used
        /// </summary>
        [JsonProperty(Order = 26)]
        public decimal PstRate { get; set; }
    }
}
