#pragma checksum "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2bb843b1cc845f29ea1ef91f355d461ba727b44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Modal.cshtml", typeof(AspNetCore.Views_Shared__Modal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2bb843b1cc845f29ea1ef91f355d461ba727b44", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86707d637f73b1a5445f52dedcf135eefb48467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SC.Web.Models.BootstrapModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 24, true);
            WriteLiteral("\n<div aria-hidden=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 60, "\"", 98, 1);
#line 3 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 78, Model.AreaLabeledId, 78, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(99, 28, true);
            WriteLiteral(" role=\"dialog\" tabindex=\"-1\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 127, "\"", 141, 1);
#line 3 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 132, Model.ID, 132, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(142, 29, true);
            WriteLiteral(" class=\"modal fade\">\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 171, "\"", 213, 2);
            WriteAttributeValue("", 179, "modal-dialog", 179, 12, true);
#line 4 "D:\Shopping Cart\ShoppingCartApp\OAA.Web\Views\Shared\_Modal.cshtml"
WriteAttributeValue(" ", 191, Model.ModalSizeClass, 192, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(214, 83, true);
            WriteLiteral(">\n        <div class=\"modal-content\">          \n        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SC.Web.Models.BootstrapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
