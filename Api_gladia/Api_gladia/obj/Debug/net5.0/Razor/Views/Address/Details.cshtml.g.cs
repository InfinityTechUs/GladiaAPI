#pragma checksum "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6cc9ab3ad29720f6a3290aa5ed1e4e86c1ba00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Details), @"mvc.1.0.view", @"/Views/Address/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6cc9ab3ad29720f6a3290aa5ed1e4e86c1ba00", @"/Views/Address/Details.cshtml")]
    public class Views_Address_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Api_gladia.Models.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Address</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address_cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.address_cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address_uf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.address_uf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address_city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.address_city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address_district));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.address_district));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address_public_place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.address_public_place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address_complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.address_complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fk_user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
       Write(Html.DisplayFor(model => model.fk_user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1773, "\"", 1805, 1);
#nullable restore
#line 58 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Details.cshtml"
WriteAttributeValue("", 1788, Model.address_id, 1788, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Api_gladia.Models.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
