#pragma checksum "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f8619ecc6c217cc3f0a3c2cde80ec04bc2dd21d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\_ViewImports.cshtml"
using View;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\_ViewImports.cshtml"
using View.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f8619ecc6c217cc3f0a3c2cde80ec04bc2dd21d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3816675dba29992f78477f9960cc4a6fdd149fec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>ViewBag ile geldi</h3>\r\n\r\n<ul>\r\n");
#nullable restore
#line 18 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml"
      
        foreach (var item in ViewBag.products as List<View.Models.Product>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 21 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h3>ViewData ile geldi</h3>\r\n<ul>\r\n");
#nullable restore
#line 28 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml"
      
        foreach (var item in (List<View.Models.Product>)ViewData["products"] )
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 31 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "D:\DERSLER\GencayYildiz\Asp.Net Core 5.0\View\View\Views\Product\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
