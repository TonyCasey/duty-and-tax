using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using dt.HsCode.Model.Common;
using dt.HsCode.Model.Lookup;

namespace dt.HsCode.Model.HsCode
{
    [Table("Codes", Schema = "HsCode")]
    public class HsCode : BaseEntity
    {
        public long HsCodeId { get; set; }

        public int RegionId { get; set; }
        
        [StringLength(2)]
        public string CountryIso { get; set; }

        [ForeignKey("CountryIso")]
        public Country Country { get; set; }

        public int Year { get; set; }

        /// <summary>
        /// Corresponds to HS code in col (5) - 2 for HS chapter, 4 for HS heading, and 6 for HS subheading.
        /// </summary>
        public int CodeLevel { get; set; }

        [StringLength(10)]
        public string Version { get; set; }

        /// <summary>
        /// Standard HS chapter (2-digit), heading (4-digit) and  subheading (6-digit) code based on the  indicated nomenclature.
        /// </summary>
        public int Code { get; set; }

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
        [Column(TypeName = "decimal(18,2)")]
        public decimal? NumberOfAvDuties { get; set; }

        /// <summary>
        /// Minimum Ad valorem duty in the HS code.
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal? MinimumAvDuty { get; set; }

        /// <summary>
        /// Minimum Ad valorem duty in the HS code.
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal? MaximumAvDuty { get; set; }

        /// <summary>
        /// Percentage of applied duty free  national tariff lines in the HS code.
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DutyFreeTlPercent { get; set; }

        /// <summary>
        /// Number of national tariff lines in the HS code with non- Ad valorem duty.
        /// </summary>
        public int NumberOfNonAvDuty { get; set; }

        /// <summary>
        /// All non-Ad valorem duties in the HS subheading.
        /// </summary>
        [StringLength(500)]
        public string ListOfNonAvDuties { get; set; }

        /// <summary>
        /// Standard HS code descriptions for chapter and heading codes  and  the self-contained description based on Eurostat's RAMON metadata server for HS subheading codes.
        /// </summary>
        public string Description { get; set; }
    }
}
