#pragma checksum "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b14f1c3cb6f7f0b3a5115ea712adf6cc6cbcb88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\_ViewImports.cshtml"
using SC.Web;

#line default
#line hidden
#line 2 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\_ViewImports.cshtml"
using SC.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b14f1c3cb6f7f0b3a5115ea712adf6cc6cbcb88", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86707d637f73b1a5445f52dedcf135eefb48467", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Home\About.cshtml"
  
	ViewData["Title"] = "About";
	Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(80, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(85, 17, false);
#line 5 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(114, 19, false);
#line 6 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 66, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
