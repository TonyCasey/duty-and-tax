using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace dt.HsCode.Model.HsCode
{
    [Table("SubCategories", Schema = "HsCode")]
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }
        [Required]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
