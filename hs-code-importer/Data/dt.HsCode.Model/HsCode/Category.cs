using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace dt.HsCode.Model.HsCode
{
    [Table("Categories", Schema = "HsCode")]
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int ChapterId { get; set; }
        [Required]
        [ForeignKey("ChapterId")]
        public Chapter Chapter { get; set; }
    }
}
