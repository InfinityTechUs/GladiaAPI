#pragma checksum "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0d955a03660d3e5cd52c712c6d44f3b409de2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Create), @"mvc.1.0.view", @"/Views/Address/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0d955a03660d3e5cd52c712c6d44f3b409de2e", @"/Views/Address/Create.cshtml")]
    public class Views_Address_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Api_gladia.Models.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Address</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""address_cep"" class=""control-label""></label>
                <input asp-for=""address_cep"" class=""form-control"" />
                <span asp-validation-for=""address_cep"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""address_uf"" class=""control-label""></label>
                <input asp-for=""address_uf"" class=""form-control"" />
                <span asp-validation-for=""address_uf"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""address_city"" class=""control-label""></label>
                <input asp-for=""address_city"" class=""form-control"" />
                <span asp-validation-for=""address_ci");
            WriteLiteral(@"ty"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""address_district"" class=""control-label""></label>
                <input asp-for=""address_district"" class=""form-control"" />
                <span asp-validation-for=""address_district"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""address_public_place"" class=""control-label""></label>
                <input asp-for=""address_public_place"" class=""form-control"" />
                <span asp-validation-for=""address_public_place"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""address_complement"" class=""control-label""></label>
                <input asp-for=""address_complement"" class=""form-control"" />
                <span asp-validation-for=""address_complement"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
   ");
            WriteLiteral(@"             <label asp-for=""fk_user_id"" class=""control-label""></label>
                <input asp-for=""fk_user_id"" class=""form-control"" />
                <span asp-validation-for=""fk_user_id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\Escola\TCC\TCC\Api_gladia\Api_gladia\Views\Address\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
