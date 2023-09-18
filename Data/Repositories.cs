using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibalala.Models;
using Bibalala.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http.Features;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using User.Bibalala.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Z.EntityFramework.Plus;
using Microsoft.AspNetCore.Html;

namespace Bibalala.Data
{
    public class Repositories : IRepositories
    {
        /// public PortalSession session;
        private readonly IConfiguration _config;
        private readonly DataContext _context;
        private readonly UserDataContext _userContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        /* private readonly _8eShowtimeDataContext _context8Showtime;*/
        //  private readonly object _httpContextAccessor;
        /*    public Repositories(
                _8eShowtimeDataContext contextObj)
            {
                _context8Showtime = contextObj;
            }*/
        public Repositories(
            DataContext context,
            UserDataContext userDataContext,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _config = configuration;
            _context = context;
            _userContext = userDataContext;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<PreRegisterInformation> AddUpdatePreRegisterInformation(PreRegisterInformation obj,Geolocation Geolocation,string applicationName) 
        {
            var data = await _userContext.PreRegisterInformations.FirstOrDefaultAsync(x => x.ID == obj.ID);
            data.ApplicationName = applicationName;
            data.FullName = obj.FullName;
            data.Gender = "";
            data.Email = obj.Email;
            data.MSISDN = obj.MSISDN;
            data.CountryCode = Geolocation.CountryCode;
            data.Country = Geolocation.Country;
            data.Region = Geolocation.Region;
            data.RegionName = Geolocation.RegionName;
            data.City = Geolocation.City;
            data.District = "";
            data.Isp = Geolocation.ISP;
            data.Currency = "";
            data.Zip = Geolocation.Zip;
            data.ClientIP = Geolocation.IpAddress;
            data.IsEmailVerifier = false;
            data.CreatedDate = DateTime.Now;
            data.Message = obj.Message;

            _userContext.PreRegisterInformations.Add(data);
            await _context.SaveChangesAsync();
            return data;


        }
        public async Task<PreRegisterInformation> AddPreRegisterInformation(PreRegisterInformation obj, Geolocation Geolocation,string ApplicationName)
        {            
            var data = new PreRegisterInformation();
            data.ApplicationName = ApplicationName;            
            data.FullName = obj.FullName;
            data.Gender = "";
            data.Email = obj.Email;
            data.MSISDN = obj.MSISDN;
            data.CountryCode = Geolocation.CountryCode;
            data.Country = Geolocation.Country;
            data.Region = Geolocation.Region;
            data.RegionName = Geolocation.RegionName;
            data.City = Geolocation.City;
            data.District = "";
            data.Isp = Geolocation.ISP;
            data.Currency = "";
            data.Zip = Geolocation.Zip;
            data.ClientIP = Geolocation.IpAddress;
            data.IsEmailVerifier = false;
            data.CreatedDate = DateTime.Now;
            data.Message = obj.Message;

            _userContext.PreRegisterInformations.Add(data);
           await _context.SaveChangesAsync();
           return data;

        }
        public async Task<string> GetPreRegisterInformation(PreRegisterInformation obj, string applicationName)
        {
            var message = "DataExists";
            var cekEmail = await _userContext.PreRegisterInformations
                .Where(x=> x.Email == obj.Email && x.ApplicationName == applicationName)                
                .CountAsync();
            var cekMSISDN = await _userContext.PreRegisterInformations
                .Where(x => x.MSISDN == obj.MSISDN && x.ApplicationName == applicationName)
                .CountAsync();
            var cekFullName = await _userContext.PreRegisterInformations
                .Where(x => x.FullName == obj.FullName && x.ApplicationName == applicationName)
                .CountAsync();
            if (cekEmail == 0 && cekMSISDN == 0 && cekFullName == 0)
            {
                message = "DataNotFound";
            }
            else if (cekEmail > 0)
            {
                message = "DataEmailFound";
            }
            else if (cekMSISDN > 0) 
            {
                message = "DataMSISDNFound";   
            }
            else if (cekFullName > 0)
            {
                message = "DataFullNameFound";
            }

            return message;
        }

        public List<CountryList> GetCountryList(string[] obj)
        {            
            var data = _userContext.CountryList
            .Where(x => obj.Contains(x.Code))          
            .OrderBy(x => x.PhoneCode.Length)
            .ToList();
            
            return data;
        }


        public string GetPortalText(string key, string language)
        {
           
                _httpContextAccessor.HttpContext.Request.Cookies.TryGetValue(
                    CookieRequestCultureProvider.DefaultCookieName,
                    out language);
            

            var list = _context.PageTexts.FromCache().ToList();
            string defaultLanguage = _config["Settings:DefaultLanguage"];
            var text =
                list.Where(t => t.Key == key)
                    .OrderBy(t => t.LanguageCode != language)
                    .ThenBy(t => t.LanguageCode != defaultLanguage)
                    .FirstOrDefault();

            return text != null ? text.Text : "";

        }


    }
}
