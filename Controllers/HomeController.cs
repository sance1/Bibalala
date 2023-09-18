using Bibalala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bibalala.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using Z.EntityFramework.Plus;

namespace Bibalala.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            var language = _config["Settings:DefaultLanguage"];
            var lang2 = "";

            HttpContext.Request.Cookies.TryGetValue(CookieRequestCultureProvider.DefaultCookieName, out lang2);
            if (!string.IsNullOrEmpty(lang2))
            {
                language = lang2;
            }

            ViewData["Language"] = language;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName, culture,
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            CultureInfo.CurrentCulture = new CultureInfo(culture);

            return LocalRedirect(returnUrl);
        }
        public string ClearText()
        {
            QueryCacheManager.ExpireAll();
            return "ok";
        }

    }
}
