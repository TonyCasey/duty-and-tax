using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dt.HsCode.Api.Model
{
    /// <summary>
    /// A HsCode Post/Put request dto
    /// </summary>
    public class HsCodeRequestDto
    {
        
        /// <summary>
        /// Country/Region
        /// </summary>
        [Required]
        public string Country { get; set; }
        
        /// <summary>
        /// Hs Code issue year
        /// </summary>
        [Required]
        public int Year { get; set; }

        /// <summary>
        /// Corresponds to HS code in col (5) - 2 for HS chapter, 4 for HS heading, and 6 for HS subheading.
        /// </summary>
        [Required]
        public int CodeLevel { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [Required]
        public string Version { get; set; }

        /// <summary>
        /// Standard HS chapter (2-digit), heading (4-digit) and subheading (6-digit) code based on the  indicated nomenclature.
        /// </summary>
        [Required]
        public string HsCode { get; set; }

        /// <summary>
        /// Number of subheadings in the HS code for the specified standard HS version.
        /// </summary>
        public int NumberOfSubHeadings { get; set; }

        /// <summary>
        /// Number of tariff lines in the national nomenclature within the HS code.
        /// </summary>
        public int NumberOfTl { get; set; }

        /// <summary>
        /// Minimum Ad valorem duty in the HS code.
        /// </summary>
        public decimal? NumberOfAvDuties { get; set; }

        /// <summary>
        /// Average of all Ad valorem duties in the HS code. No Ad valorem equivalents for non-AV duties are included.
        /// </summary>
        public decimal? AverageOfAvDuties { get; set; }

        /// <summary>
        /// Minimum Ad valorem duty in the HS code.
        /// </summary>
        public decimal? MinimumAvDuty { get; set; }

        /// <summary>
        /// Minimum Ad valorem duty in the HS code.
        /// </summary>
        public decimal? MaximumAvDuty { get; set; }

        /// <summary>
        /// Percentage of applied duty free  national tariff lines in the HS code.
        /// </summary>
        public decimal? DutyFreeTlPercent { get; set; }

        /// <summary>
        /// Number of national tariff lines in the HS code with non- Ad valorem duty.
        /// </summary>
        public int NumberOfNonAvDuty { get; set; }

        /// <summary>
        /// All non-Ad valorem duties in the HS subheading.
        /// </summary>
        public string ListOfNonAvDuties { get; set; }

        /// <summary>
        /// Standard HS code descriptions for chapter and heading codes  and  the self-contained description based on Eurostat's RAMON metadata server for HS subheading codes.
        /// </summary>
        /// Percentage of app
        [Required]
        public string Description { get; set; }
    }
}
