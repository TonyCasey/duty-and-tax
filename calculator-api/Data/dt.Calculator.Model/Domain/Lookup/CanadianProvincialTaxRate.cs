using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dt.Calculator.Model.Domain.Lookup
{
    [Table("CanadianProvincialTaxRates", Schema = "Lookup")]
    public class CanadianProvincialTaxRate
    {
        public int CanadianProvincialTaxRateId { get; set; }

        [Required]
        [StringLength(2)]
        public string StateCode { get; set; }

        public string StateName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal HstRate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal GstRate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PstRate { get; set; }


    }
}
