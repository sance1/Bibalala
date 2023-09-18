using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibalala.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using User.Bibalala.Models;

namespace Bibalala.Data
{
    public interface IRepositories
    {
        Task<PreRegisterInformation> AddPreRegisterInformation(PreRegisterInformation obj, Geolocation Geolocation, string applicationName);
        Task<string> GetPreRegisterInformation(PreRegisterInformation obj, string applicationName);
        Task<PreRegisterInformation> AddUpdatePreRegisterInformation(PreRegisterInformation obj, Geolocation geolocation, string applicationName);
        List<CountryList> GetCountryList(string[] obj);
        string GetPortalText(string key, string language = "en");

    }
}
