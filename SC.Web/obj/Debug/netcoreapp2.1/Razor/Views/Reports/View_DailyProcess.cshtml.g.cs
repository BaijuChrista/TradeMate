#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Reports\View_DailyProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d0054731c4ffbb16683ba2b5bf25d34b51ac11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_View_DailyProcess), @"mvc.1.0.view", @"/Views/Reports/View_DailyProcess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/View_DailyProcess.cshtml", typeof(AspNetCore.Views_Reports_View_DailyProcess))]
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\_ViewImports.cshtml"
using SC.Web;

#line default
#line hidden
#line 2 "E:\Projects\RouteMapper\SC.Web\Views\_ViewImports.cshtml"
using SC.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d0054731c4ffbb16683ba2b5bf25d34b51ac11", @"/Views/Reports/View_DailyProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_View_DailyProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.jqGrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Reports\View_DailyProcess.cshtml"
  
    ViewData["Title"] = "No Stock Items";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(95, 512, true);
            WriteLiteral(@"<script src=""//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""//ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/jquery-ui.min.js""></script>
<script type=""text/javascript"">
    jQuery.browser = {};
    (function () {
        jQuery.browser.msie = false;
        jQuery.browser.version = 0;
        if (navigator.userAgent.match(/MSIE ([0-9]+)\./)) {
            jQuery.browser.msie = true;
            jQuery.browser.version = RegExp.$1;
        }
    })();
</script>
");
            EndContext();
            BeginContext(607, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d0054731c4ffbb16683ba2b5bf25d34b51ac116160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(653, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(655, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d0054731c4ffbb16683ba2b5bf25d34b51ac117337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(704, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(706, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d0054731c4ffbb16683ba2b5bf25d34b51ac118514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(758, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(760, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d0054731c4ffbb16683ba2b5bf25d34b51ac119766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(814, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d0054731c4ffbb16683ba2b5bf25d34b51ac1111018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(863, 5309, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-2"">
                    From Date <br /><input type=""text"" class=""form-control datepicker"" id=""serfromdate"" />
                </div>
                <div class=""col-md-2"">
                    To Date<br /> <input type=""text"" class=""form-control datepicker"" id=""sertodate"" />
                </div>

                <div class=""col-md-3"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                </div>

            </div>
            <div class=""x_content"">
            </div>
        </div>
    </div>
</div>
<script>
    jQuery('.datepicker').datepicker({
        dateFormat: 'dd/mm/yy'
    })
    $.ajax({

        url: '/Report/getDailyProcess',
        type: 'GET',
 ");
            WriteLiteral(@"       dataType: 'json',
        success: function (data) {
            $('.x_content').empty();
            var divstring = '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>CashInHand</p><h3>' + data.cashInHand + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Sales</p><h3>' + data.sales + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Purchase</p><h3>' + data.purchase + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>recipt</p><h3>' + data.recipt + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>payables</p><h3>' + data.payables + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-");
            WriteLiteral(@"box bg-info""><div class=""inner""><p>SalesPaid</p><h3>' + data.custpay + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>PurchasePaid</p><h3>' + data.suplpay + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Profit</p><h3>' + ((data.sales) - (data.purchase)) + '</h3></div></div></div>';
            divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Cash</p><h3>' + ((data.recipt + data.custpay) - (data.payables + data.suplpay)) + '</h3></div></div></div>'
            //divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Total</p><h3>' + ((data.sales + data.recipt+) - (data.sales)) + '</h3></div></div></div>';

            $('.x_content').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
  ");
            WriteLiteral(@"  jQuery(""#btnSearch"").click(function () {
        var serfromdate = $(""#serfromdate"").val();
        var sertodate = $(""#sertodate"").val();
        $.ajax({

            url: '/Report/getDailyProcess',
            type: 'GET',
            data: { serfrom: serfromdate, serto: sertodate },
            dataType: 'json',
            success: function (data) {
                $('.x_content').empty();
                var divstring = '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>CashInHand</p><h3>' + data.cashInHand + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Sales</p><h3>' + data.sales + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Purchase</p><h3>' + data.purchase + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info");
            WriteLiteral(@"""><div class=""inner""><p>recipt</p><h3>' + data.recipt + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>payables</p><h3>' + data.payables + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>SalesPaid</p><h3>' + data.custpay + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>PurchasePaid</p><h3>' + data.suplpay + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Profit</p><h3>' + ((data.sales) - (data.purchase)) + '</h3></div></div></div>';
                divstring += '<div class=""col-lg-3 col-6""><div class=""small-box bg-info""><div class=""inner""><p>Cash</p><h3>' + ((data.recipt + data.custpay) - (data.payables + data.suplpay)) + '</h3></div></div></div>';");
            WriteLiteral("\n\r\n                $(\'.x_content\').append(divstring);\r\n            },\r\n            error: function () {\r\n                console.log(\'err\')\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
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
