#pragma checksum "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ccef9690ba79574426d3456caa4fc0d0b3885c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalFooter), @"mvc.1.0.view", @"/Views/Shared/_ModalFooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ModalFooter.cshtml", typeof(AspNetCore.Views_Shared__ModalFooter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ccef9690ba79574426d3456caa4fc0d0b3885c3", @"/Views/Shared/_ModalFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86707d637f73b1a5445f52dedcf135eefb48467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModalFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SC.Web.Models.ModalFooter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 60, true);
            WriteLiteral("\n<div class=\"modal-footer\">\n    <button data-dismiss=\"modal\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 93, "\"", 119, 1);
#line 4 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml"
WriteAttributeValue("", 98, Model.CancelButtonID, 98, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(120, 39, true);
            WriteLiteral(" class=\"btn btn-default\" type=\"button\">");
            EndContext();
            BeginContext(160, 22, false);
#line 4 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml"
                                                                                             Write(Model.CancelButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(182, 10, true);
            WriteLiteral("</button>\n");
            EndContext();
#line 5 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml"
     if (!Model.OnlyCancelButton)
    {

#line default
#line hidden
            BeginContext(232, 39, true);
            WriteLiteral("        <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 271, "\"", 297, 1);
#line 7 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml"
WriteAttributeValue("", 276, Model.SubmitButtonID, 276, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 43, true);
            WriteLiteral(" type=\"submit\">            \n               ");
            EndContext();
            BeginContext(342, 22, false);
#line 8 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml"
          Write(Model.SubmitButtonText);

#line default
#line hidden
            EndContext();
            BeginContext(364, 10, true);
            WriteLiteral("</button>\n");
            EndContext();
#line 9 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_ModalFooter.cshtml"
    }

#line default
#line hidden
            BeginContext(380, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SC.Web.Models.ModalFooter> Html { get; private set; }
    }
}
#pragma warning restore 1591
