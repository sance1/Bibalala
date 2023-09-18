using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibalala.Models
{
    //[Table("Geolocation")]
    public class Geolocation
    {  
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public string ISP { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string RegionName { get; set; }
        public string Zip { get; set; }
        public string ASN { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }
   
    }
}
