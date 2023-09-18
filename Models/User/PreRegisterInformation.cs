using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace User.Bibalala.Models
{
    [Table("PreRegisterInformation")]
    public class PreRegisterInformation
    {
        public int ID { get; set; }
        public string ApplicationName {get;set;}
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string MSISDN { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Isp { get; set; }
        public string Currency { get; set; }
        public string Zip { get; set; }
        public string ClientIP { get; set; }

        public bool IsEmailVerifier { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Message { get; set; }
    }
}
