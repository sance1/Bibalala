#pragma checksum "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c02d7b6287bd940f1f5ce04e93c199e819200d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\_ViewImports.cshtml"
using Bibalala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\_ViewImports.cshtml"
using Bibalala.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
using Bibalala.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
using Bibalala.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c02d7b6287bd940f1f5ce04e93c199e819200d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4de6db6c069fc17b3c24df1c7ccf4ae46945cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""callWe"" class=""section"">
    <div class=""callWe-wrap"">
        <div class=""img-left"">
            <img src=""img/call-img_left.png"" />
        </div>
        <div class=""formInfo"">
            <div class=""formInfo_card"">
                <h2>");
#nullable restore
#line 16 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
               Write(Html.PortalText(Repositories, "ContactUs", "id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>\r\n                    ");
#nullable restore
#line 18 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
               Write(Html.PortalText(Repositories, "GetTheLatestInformation", "id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <h3>");
#nullable restore
#line 20 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
               Write(Html.PortalText(Repositories, "EnterMessage", "id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"formcard_wrap\">\r\n                    <p>\r\n                        <input id=\"name\" type=\"text\" class=\"ipt_form\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 796, "\"", 857, 1);
#nullable restore
#line 23 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
WriteAttributeValue("", 810, Html.PortalText(Repositories,"YourName", "id"), 810, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" min=""6"" maxlength=""25"" onblur=""onBlurName()"" onfocus=""onFocusName()"" autocomplete=""off"" required />
                        <span id=""notifName""></span>
                    </p>
                    <p>
                        <input id=""email"" type=""email"" class=""ipt_form""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1136, "\"", 1198, 1);
#nullable restore
#line 27 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
WriteAttributeValue("", 1150, Html.PortalText(Repositories,"YourEMail", "id"), 1150, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onblur=""onBlurEmail()"" onfocus=""onFocusEmail()"" autocomplete=""off"" />
                        <!-- <input id=""email"" type=""email"" class=""ipt_form"" placeholder=""E-mail Anda"" /> -->
                        <span id=""notifEmail""></span>
                    </p>
                    <p>
                        <span class=""codeArea"">
                            +<input type=""number"" id=""codePhoneChange"" onblur=""onBlurPhoneCode()"" onfocus=""onFocusPhoneCode()""");
            BeginWriteAttribute("value", " value=\"", 1663, "\"", 1671, 0);
            EndWriteAttribute();
            WriteLiteral(@" onKeyPress=""if(this.value.length==3) return false;"" style=""width:30px;border:none;"">
                            <select id=""codePhone"" onchange=""changePhoneInOption(this.value)"" style=""width:20px""></select>
                        </span>
                        <input id=""telp"" type=""text"" class=""ipt_form""");
            BeginWriteAttribute("value", " value=\"", 1985, "\"", 1993, 0);
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1994, "\"", 2062, 1);
#nullable restore
#line 36 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
WriteAttributeValue("", 2008, Html.PortalText(Repositories,"YourPhoneNumber", "id"), 2008, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onblur=""onBlurPhone()"" onfocus=""onFocusPhone()"" onkeypress=""validate(event)"" autocomplete=""off"" />
                        <span id=""notifPhoneCode""></span>
                        <span id=""notifPhone""></span>
                        <!-- End Part Now -->
                    </p>
                    <p>
                        <textarea id=""message""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2422, "\"", 2486, 1);
#nullable restore
#line 42 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
WriteAttributeValue("", 2436, Html.PortalText(Repositories,"YourMessage", "id"), 2436, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" maxlength=\"255\" autocomplete=\"off\"></textarea>\r\n                    </p>\r\n                    <p>\r\n                        <button type=\"button\" onclick=\"ValidasiAddData()\">");
#nullable restore
#line 45 "D:\8 Elements New\Projek\Bibalala\Bibalala\Views\Home\Index.cshtml"
                                                                     Write(Html.PortalText(Repositories, "SendMessage", "id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </p>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"img-right\">\r\n            <img src=\"img/call-img_right.png\" />\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRepositories Repositories { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
