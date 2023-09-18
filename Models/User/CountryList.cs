using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace User.Bibalala.Models
{
    [Table("CountryList")]
    public class CountryList
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public bool IsActive { get; set; }
    }
}
