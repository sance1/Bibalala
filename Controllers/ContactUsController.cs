using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibalala.Data;
using Bibalala.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;
using System.Net;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using User.Bibalala.Models;
// using Microsoft.AspNetCore.Mvc;

namespace Bibalala.Controllers
{
    [Produces("application/json")]
  
    public class ContactUsController : Controller
    {
        private readonly IRepositories _repository;
        private readonly IActionContextAccessor _accessor;

        public ContactUsController( 
            IRepositories repository, IActionContextAccessor accessor)
        {
            _repository = repository;
            _accessor = accessor;
        }
        public IActionResult Index()
        {   
            return View();
        }
        public async Task<IActionResult> SendMessage(PreRegisterInformation data, Geolocation Geolocation)
        {   
            var message = "Failed";
            var applicationName = "bibalala";
            var getDataObj = new PreRegisterInformation();
            var cekData = await _repository.GetPreRegisterInformation(data, applicationName);
            var messageSuccessIndo = "Terima kasih. Pesanmu telah terkirim.";
            //var messageSuccessEnglish = "Thank you. Your message has been submitted.";
            var messageErrorIndo = "Periksa kembali datamu dan ajukan kembali";
            var messageTitle = "";
            //var messageErrorEnglish = "Please check the data and try to submit again.";

            if (cekData == "DataNotFound")
            {
                Geolocation getDataGeolocation = await GetLocation(Geolocation);
                getDataObj = await _repository.AddPreRegisterInformation(data, getDataGeolocation, applicationName);
                if(getDataObj.ToString().Count() != 0) message = "Proses Add Data Success";
                message = messageSuccessIndo;
            }
            else if (cekData == "DataEmailFound")
            {
                messageTitle = "Kolom email salah, mohon ikuti format di bawah ini : ";
                message = "Email Found, Proses Add PreRegisterInformation Failed";
                message = messageErrorIndo;
            }
            else if (cekData == "DataMSISDNFound")
            {
                messageTitle = "Kolom telepon salah, mohon ikuti format di bawah ini : ";
                message = "MSISDN Found, Proses Add PreRegisterInformation Failed";
                message = messageErrorIndo;
            }
            else if (cekData == "DataFullNameFound")
            {
                messageTitle = "Kolom nama salah, mohon ikuti format di bawah ini : ";
                message = "Full Name Found, Proses Add PreRegisterInformation Failed";
                message = messageErrorIndo;
            }
            var getData = new { getDataObj, message, messageTitle };
            return Content(JsonConvert.SerializeObject(getData), "application/json");          
        }



        public async Task<Geolocation> GetLocation(Geolocation Geolocation)
        {
            //var ip = _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
            string ip = string.Empty;
            ip = HttpContext.Request.Headers["X-Forwarded-For"];
            if (!string.IsNullOrEmpty(HttpContext.Request.Headers["X-Forwarded-For"]))
            {
                ip = HttpContext.Request.Headers["X-Forwarded-For"];
            }
            else
            {
                ip = HttpContext.Request.HttpContext.Features.Get<IHttpConnectionFeature>().RemoteIpAddress
                    .ToString();
            }
            if (!string.IsNullOrEmpty(ip))
            {
                if (ip.Contains(","))
                {
                    var rawIp = ip.Split(",");
                    ip = rawIp[0];
                }
            }
            /* 
            string url = string.Format(
                 "http://pro.ip-api.com/json/{0}?key=xgLWzHqvscq2aG3", ip);

             string url = "http://pro.ip-api.com/json/103.10.79.255?key=xgLWzHqvscq2aG3"; */

            using (var client = new WebClient())
            {
                try
                {
                    /*string response = client.DownloadString(url);
                    var json = JObject.Parse(response);
                    Geolocation geolocation = new Geolocation();
                    geolocation.CountryCode = json.Get("countryCode");
                    geolocation.Country = json.Get("country");
                    geolocation.Region = json.Get("region");
                    geolocation.RegionName = json.Get("regionName");
                    geolocation.City = json.Get("city");
                    geolocation.ISP = json.Get("isp");
                    geolocation.Zip = json.Get("zip");
                    geolocation.IpAddress = ip?.ToString();*/

                    
                 
                    Geolocation geolocation = new Geolocation();
                    geolocation.CountryCode = "ID";
                    geolocation.Country = "Indonesia";
                    geolocation.Region = "JK";
                    geolocation.RegionName = "Jakarta";
                    geolocation.City = "Jakarta";
                    geolocation.ISP = "PT Cyberindo Aditama";
                    geolocation.Zip = "";
                    geolocation.IpAddress = "103.86.158.154";

                    geolocation.CreateDate = DateTime.Now;
                    
                    return geolocation;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
            
        }

        public async Task<IActionResult> AddUpdateInformationFunction(PreRegisterInformation obj, Geolocation Geolocation)
        {
            var applicationName = "bibalala";
            var data = await _repository.AddUpdatePreRegisterInformation(obj, Geolocation, applicationName);
            var getData = new { data };
            return Content(JsonConvert.SerializeObject(getData), "application/json");
        }

        public async Task<IActionResult> GetCountryList()
        {
            CountryList obj = new CountryList();
            var objArr = new []{ "ID", "KH", "LA", "MY", "MM", "PH", "SG", "TH", "VN", "IDN", "LAO", "MYS", "MMR", "PHL", "SGP", "THA", "VNM", "BN", "BRN" };
            var data = _repository.GetCountryList(objArr);
            var getData = new { data };
            return Content(JsonConvert.SerializeObject(getData), "application/json");

        }






    }
}
