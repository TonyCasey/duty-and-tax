using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using dt.Calculator.Model.Common;
using dt.Calculator.Model.Domain.Lookup;
using dt.Model.Domain;

namespace dt.Calculator.Model.Domain.Calculator
{
    [Table("Settings", Schema = "Calculator")]
    public class CalculatorSetting : BaseEntity
    {
        public int CalculatorSettingId { get; set; }

        public string Name { get; set; }

        [StringLength(2)]
        public string CountryIso { get; set; }
        [ForeignKey("CountryIso")]
        public Country Country { get; set; }

        [StringLength(3)]
        public string CurrencyIso { get; set; }
        [ForeignKey("CurrencyIso")]
        public Currency Currency { get; set; }

        // DUTY
        public bool  DutyApplicable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DutyThreshold { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DutyThresholdForGifts { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal DutyRate { get; set; }
        
        public Enumerations.CalculationMethodEnum DutyCalculationMethod { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinimumDutyPayable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  MaximumDutyPayable { get; set; }

        public bool DutyRefundable { get; set; } = false;

        
        // TAX - VAT/GST

        public bool  TaxApplicable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  TaxThreshold { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  TaxThresholdForGifts { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxRate { get; set; }

        public Enumerations.CalculationMethodEnum  TaxCalculationMethod { get; set; }

        public bool  TaxIncludesDuty { get; set; }

        public bool  TaxIncludesFees { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  MinimumTaxPayable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  MaximumTaxPayable { get; set; }

        public bool TaxRefundable { get; set; } = false;

        // OTHER TAX

        public bool OtherTaxApplicable { get; set; } = false;

        [Column(TypeName = "decimal(18,2)")]
        public decimal  OtherTaxThreshold { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DefaultOtherTaxRate { get; set; }

        public Enumerations.CalculationMethodEnum  OtherTaxCalculationMethod { get; set; }

        public bool  OtherTaxIncludesDuty { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  MinimumOtherTaxPayable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  MaximumOtherTaxPayable { get; set; }

        public bool OtherTaxRefundable { get; set; } = false;

        // FEES
        
        public bool FeesApplicable { get; set; } = false;

        [Column(TypeName = "decimal(18,2)")]
        public decimal  FeeThreshold { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  Fee { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  FeeRate { get; set; }

        public bool FeeRefundable { get; set; } = false;

    }
}
