using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace dt.HsCode.Model.HsCode
{
    [Table("Chapters", Schema = "HsCode")]
    public class Chapter
    {
        public int ChapterId { get; set; }

        public string Name { get; set; }
    }
}
