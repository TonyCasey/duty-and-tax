using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using dt.Calculator.Model.Common;
using dt.Calculator.Model.Domain.Lookup;
using dt.Model.Domain;

namespace dt.Calculator.Model.Domain.Calculator
{
    [Table("Calculators", Schema = "Calculator")]
    public class Calculator
    {
        public int CalculatorId { get; set; }

        [StringLength(2)]
        public string CountryIso { get; set; }
        [ForeignKey("CountryIso")]
        public Country Country { get; set; }
        
        public int CalculatorSettingId { get; set; }
        [Required]
        [ForeignKey("CalculatorSettingId")]
        public CalculatorSetting CalculatorSetting { get; set; }
    }
}
