#pragma checksum "C:\Users\Eugenio Gallea\GitHub\dotnet\NorthwindWeb\Pages\Suppliers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d73766270b68b6611c8bda099267d3224bf0c44a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Suppliers), @"mvc.1.0.razor-page", @"/Pages/Suppliers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d73766270b68b6611c8bda099267d3224bf0c44a", @"/Pages/Suppliers.cshtml")]
    public class Pages_Suppliers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <h1 class=\"display-2\">Suppliers</h1>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-inverse\">\r\n            <tr><th>Company Name</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 10 "C:\Users\Eugenio Gallea\GitHub\dotnet\NorthwindWeb\Pages\Suppliers.cshtml"
         foreach(string name in Model.Suppliers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 12 "C:\Users\Eugenio Gallea\GitHub\dotnet\NorthwindWeb\Pages\Suppliers.cshtml"
               Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 13 "C:\Users\Eugenio Gallea\GitHub\dotnet\NorthwindWeb\Pages\Suppliers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindWeb.Pages.SuppliersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.SuppliersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.SuppliersModel>)PageContext?.ViewData;
        public NorthwindWeb.Pages.SuppliersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
