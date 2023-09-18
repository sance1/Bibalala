using Bibalala.Data;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibalala.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent PortalText(
            this IHtmlHelper htmlHelper, IRepositories repository,
            string key,
            string language)
        {
            if (htmlHelper == null)
            {
                throw new ArgumentNullException(nameof(htmlHelper));
            }
            return new HtmlString(repository.GetPortalText(key, language));

        }


    }
}
