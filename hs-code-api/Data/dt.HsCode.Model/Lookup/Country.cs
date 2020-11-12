using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dt.HsCode.Model.Common;

namespace dt.HsCode.Model.Lookup
{
    [Table("Countries", Schema = "Lookup")]
    public  class Country{
        
        [Key]
        [StringLength(2)]
        public string Iso { get; set; }

        public string CountryName { get; set; }
        
        public Enumerations.RegionEnum? RegionId { get; set; }

        public string CountryPrintableName { get; set; }

        public string Iso3 { get; set; }

        public short? NumCode { get; set; }

        public bool PostalCodeNeeded { get; set; }

        public string PrimaryLanguage { get; set; }

    }
}
