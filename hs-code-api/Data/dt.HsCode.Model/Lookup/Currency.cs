using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dt.HsCode.Model.Lookup
{
    [Table("Currency", Schema = "Lookup")]
    public class Currency : BaseEntity
    {
        [Required]
        [StringLength(3)]
        [Key]
        public string Iso { get; set; }
        public bool Active { get; set; }
        public string CurrencyNumericCode { get; set; }
        public DateTime NonNullableDate { get; set; }
        public string Symbol { get; set; }
        public string CurrencyName { get; set; }
        public int Exponent { get; set; }
        public bool? SymbolAfterPrice { get; set; }
    }
}
