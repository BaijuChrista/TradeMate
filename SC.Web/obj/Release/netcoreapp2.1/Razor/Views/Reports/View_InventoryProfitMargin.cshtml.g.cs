#pragma checksum "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Reports\View_InventoryProfitMargin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d79b4c73cbf43a6366dc926d0ac28091831e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_View_InventoryProfitMargin), @"mvc.1.0.view", @"/Views/Reports/View_InventoryProfitMargin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/View_InventoryProfitMargin.cshtml", typeof(AspNetCore.Views_Reports_View_InventoryProfitMargin))]
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
#line 1 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\_ViewImports.cshtml"
using SC.Web;

#line default
#line hidden
#line 2 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\_ViewImports.cshtml"
using SC.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d79b4c73cbf43a6366dc926d0ac28091831e3c", @"/Views/Reports/View_InventoryProfitMargin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_View_InventoryProfitMargin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.jqGrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Reports\View_InventoryProfitMargin.cshtml"
  
    ViewData["Title"] = "Inventory Profit Margin";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(104, 461, true);
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
            BeginContext(565, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ac75e4efdc4fbe917148b52049c23b", async() => {
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
            BeginContext(611, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(613, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2e19f06fc3481686fa07fda40def3d", async() => {
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
            BeginContext(662, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(872, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cffd97a96834a1a9a2743de734df12d", async() => {
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
            BeginContext(924, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(926, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6e2e7c65f5a46ebb9cfd191d5f79395", async() => {
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
            BeginContext(978, 1514, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-2"">
                    Item Code <br /><input type=""text"" class=""form-control""  id=""serCode"" />
                </div>
                <div class=""col-md-2"">
                    Item Name <br /><input type=""text"" class=""form-control""  id=""serName"" />
                </div>
                <div class=""col-md-2"">
                    Category <br /><select id=""serCategory"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Brand <br /><select id=""serBrand"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
   ");
            WriteLiteral(@"                 <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2492, "\"", 2551, 3);
            WriteAttributeValue("", 2502, "location.href=\'", 2502, 15, true);
#line 45 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Reports\View_InventoryProfitMargin.cshtml"
WriteAttributeValue("", 2517, Url.Action("NewItem", "Company"), 2517, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 2550, "\'", 2550, 1, true);
            EndWriteAttribute();
            BeginContext(2552, 4958, true);
            WriteLiteral(@">New</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-inventorymargin"" style=""color:black !important"" class=""table table-dark""></table>
                <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-inventorymargin').jqGrid({
        url: '/Report/GetInventoryProfitMargin',
        datatype: 'json',
        colNames: ['Code', 'ItemName', 'Sales', 'Cost', 'Profit', 'Margin'],
        colModel: [
            { name: 'itemCode', index: 'itemCode', width: 200 },
            { name: 'itemName', index: 'itemName', width: 200 },            
            {
                name: ""amount"", index: ""amount"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },             
            {
                name: ""cost"", index: ""cost"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",");
            WriteLiteral(@"
                summaryType: ""sum""
            },            
            {
                name: ""profit"", index: ""profit"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },             
            {
                name: ""margin"", index: ""margin"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""average""
            } 
        ],
		jsonReader: {
			root: ""rows"",
			page: ""page"",
			total: ""total"",
			records: ""records"",
			repeatitems: false,
			id: ""0""  },
        rowNum: 250,
        rowList: [250, 500, 1000],
        pager: '#pager',
        sortname: 'code',
        sortorder: 'asc',
        //multiselect: true,
        viewrecords: true,
        height: '100%',
        width: '100%',
        sortorder: 'asc',
        loadonce: false,
        autowidth: true,
        shrinkToFit: true,
        scrollOffset: 0,
        footerrow: tru");
            WriteLiteral(@"e,
        userDataOnFooter: true,
        grouping: true,
        gridComplete: function () {
            var $grid = $('#list-inventorymargin');
            $grid.jqGrid('footerData', 'set', {
                name: ""Total""
            });
            var colSum = $grid.jqGrid('getCol', 'amount', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                amount: colSum
            });
            var colSum1 = $grid.jqGrid('getCol', 'cost', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                cost: colSum1
            });
            var colSum2 = $grid.jqGrid('getCol', 'profit', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                profit: colSum2
            });             
        },
        emptyrecords: 'No records',
        caption: 'List of Stock Items'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: false });
    $.ajax({

        url: '/Co");
            WriteLiteral(@"mpany/GetCategory',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serCategory').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].categoryName + '</option>';
            }
            $('#serCategory').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
    $.ajax({

        url: '/Company/GetItemBrand',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serBrand').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].brnadname + '</option>';
            }
            $('#serBrand').append(divstring)");
            WriteLiteral(@";
        },
        error: function () {
            console.log('err')
        }
    });
	jQuery(""#btnSearch"").click(function () {
        var serCode = $(""#serCode"").val();
        var serName = $(""#serName"").val();
        var serCategory = $(""#serCategory"").val();
        var serBrand = $(""#serBrand"").val();
        jQuery(""#list-item"").jqGrid('setGridParam',
            { url: ""/Company/SearchItem?serCode="" + serCode + '&serName=' + serName + '&serCategory=' + serCategory + '&serBrand=' + serBrand, page: 1 })
            .trigger(""reloadGrid"");
    });
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""/Company/NewItem?id=' + Id + '""  class=""fa fas fa-edit""></a>';
    }
    $(document).ready(function () {
        jQuery('.select2').select2()
    });
</script>
");
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
