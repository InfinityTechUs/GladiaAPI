#pragma checksum "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b9cbef57879976b5b7425ed3cd8861d3c65604"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Delete), @"mvc.1.0.view", @"/Views/Address/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b9cbef57879976b5b7425ed3cd8861d3c65604", @"/Views/Address/Delete.cshtml")]
    public class Views_Address_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Api_gladia.Models.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Address</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.address_cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.address_cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.address_uf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.address_uf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.address_city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.address_city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.address_district));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.address_district));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.address_public_place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.address_public_place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.address_complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.address_complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.fk_user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Delete.cshtml"
       Write(Html.DisplayFor(model => model.fk_user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""address_id"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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