#pragma checksum "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Reports\View_AgedReceivables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d8d8d39cc57959cf24e45a740f2e29a5857c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_View_AgedReceivables), @"mvc.1.0.view", @"/Views/Reports/View_AgedReceivables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/View_AgedReceivables.cshtml", typeof(AspNetCore.Views_Reports_View_AgedReceivables))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97d8d8d39cc57959cf24e45a740f2e29a5857c02", @"/Views/Reports/View_AgedReceivables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_View_AgedReceivables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Reports\View_AgedReceivables.cshtml"
  
    ViewData["Title"] = "Aged Receivables";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(97, 512, true);
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
            BeginContext(609, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "878cbc56d5ce484db5ae41fbe51b7e48", async() => {
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
            BeginContext(655, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(657, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb769814a98c47fb8b1deb2c0c61c501", async() => {
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
            BeginContext(706, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(916, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "659f9c06d969400fb3f08fec13f586ad", async() => {
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
            BeginContext(968, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(970, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc093da132ad476c9d0c21a3e73db668", async() => {
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
            BeginContext(1022, 9197, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-2"">
                    Customer Code <br /><input type=""text"" class=""form-control""  id=""serCode"" />
                </div>
                <div class=""col-md-2"">
                    Customer Name <br />
                    <select id=""serName"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Customer City <br />
                    <select id=""serCity"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Customer Category <br />
                    <select id=""serCategory"" name=""status"" ");
            WriteLiteral(@"class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Customer Group <br />
                    <select id=""serGroup"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-agedreceivables"" style=""color:black !important"" class=""table table-da");
            WriteLiteral(@"rk""></table>
                <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-agedreceivables').jqGrid({
        url: '/Report/GetAgedRecievables',
        datatype: 'json',
        colNames: ['Id', 'Code', 'Name', 'Total Amount', '1-30 Days', '31-60 Days', '61-90 Days', '90-120 Days', '120+ Days'],
        colModel: [
            { name: 'id', index: 'Id', editable: false, width: 100, key: true, hidden: true },
            { name: 'customerCode', index: 'customerCode', editable: false, width: 150 },
            { name: 'customerName', index: 'customerName', editable: false, width: 150 },
            {
                name: ""total"", index: ""total"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },            
            {
                name: ""first"", index: ""first"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                s");
            WriteLiteral(@"ummaryType: ""sum""
            },            
            {
                name: ""second"", index: ""second"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },           
            {
                name: ""third"", index: ""third"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },            
            {
                name: ""fourth"", index: ""fourth"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },
            {
                name: ""fifth"", index: ""fifth"", width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            }            
        ],
        jsonReader: {
            root: ""rows"",
            page: ""page"",
            total: ""total"",
            records: ""records"",
            ");
            WriteLiteral(@"repeatitems: false,
            id: ""0""
        },
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
        footerrow: true,
        userDataOnFooter: true,
        grouping: true,
        gridComplete: function () {
            var $grid = $('#list-agedreceivables');
            $grid.jqGrid('footerData', 'set', {
                name: ""Total""
            });
            var colSum = $grid.jqGrid('getCol', 'total', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                total: colSum
            });
            var colSum2 = $grid.jqGrid('getCol', 'first', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                first: colSu");
            WriteLiteral(@"m2
            });
            var colSum3 = $grid.jqGrid('getCol', 'second', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                second: colSum3
            });
            var colSum4 = $grid.jqGrid('getCol', 'third', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                third: colSum4
            });
            var colSum5 = $grid.jqGrid('getCol', 'fourth', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                fourth: colSum5
            });
            var colSum6 = $grid.jqGrid('getCol', 'fifth', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                fifth: colSum6
            });
        },
        emptyrecords: 'No records',
        caption: 'List of Aged Receivables'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: true });
    $.ajax({
        url: '/Company/GetCustomerCategory',
        type: 'GET',
        data");
            WriteLiteral(@"Type: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serCategory').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serCategory').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
    $.ajax({

        url: '/Company/GetCustomerGroup',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serGroup').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serGroup').append(divstring);
        },
        error: function () {
            console");
            WriteLiteral(@".log('err')
        }
    });
    $.ajax({

        url: '/Company/GetCity',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serCity').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serCity').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
    $.ajax({

        url: '/Company/GetCustomer',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serName').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].customerName + '</option>';
            ");
            WriteLiteral(@"}
            $('#serName').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
    jQuery(""#btnSearch"").click(function () {
        var serCode = $(""#serCode"").val();
        var serName = $(""#serName"").val();
        var serCity = $(""#serCity"").val();
        var serCategory = $(""#serCategory"").val();
        var serGroup = $(""#serGroup"").val();
        jQuery(""#list-agedreceivables"").jqGrid('setGridParam',
            { url: ""/Report/SearchAgedReceivables?serCode="" + serCode + '&serName=' + serName + '&serCity=' + serCity + '&serCategory=' + serCategory + '&serGroup=' + serGroup, page: 1 })
            .trigger(""reloadGrid"");
    });
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""/Company/NewSupplier?id=' + Id + '""  class=""fa fas fa-edit""></a>';
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