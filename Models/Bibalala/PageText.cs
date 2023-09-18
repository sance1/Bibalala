using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibalala.Models.Bibalala
{
    [Table("PageText")]
    public class PageText
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Text { get; set; }
        public string LanguageCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

    }
}
