#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Reports\View_VatSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c114801d4240fba8137937247afda0ca80b6608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_View_VatSummary), @"mvc.1.0.view", @"/Views/Reports/View_VatSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/View_VatSummary.cshtml", typeof(AspNetCore.Views_Reports_View_VatSummary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c114801d4240fba8137937247afda0ca80b6608", @"/Views/Reports/View_VatSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_View_VatSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.jqGrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Reports\View_VatSummary.cshtml"
  
    ViewData["Title"] = "Customer Summary";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(97, 514, true);
            WriteLiteral(@"
<script src=""//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
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
            BeginContext(611, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c114801d4240fba8137937247afda0ca80b66085793", async() => {
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
            BeginContext(657, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(659, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c114801d4240fba8137937247afda0ca80b66086970", async() => {
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
            BeginContext(708, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(918, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c114801d4240fba8137937247afda0ca80b66088147", async() => {
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
            BeginContext(970, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(972, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c114801d4240fba8137937247afda0ca80b66089399", async() => {
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
            BeginContext(1024, 7214, true);
            WriteLiteral(@"
<style>
    .ui-jqgrid tr.myMarking td {
        font-weight: bolder;
        font-size: 14px;
    }
</style>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-2"">
                    Customer Name <br />
                    <select id=""serCustomer"" name=""serCustomer"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Supplier Name <br />
                    <select id=""serSupplier"" name=""serSupplier"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !im");
            WriteLiteral(@"portant; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-customersummary"" style=""color:black !important"" class=""table table-dark""></table>
                <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-customersummary').jqGrid({
        url: '/Report/GetVatInfo',
        datatype: 'json',
        colNames: ['Id', 'TRN#', 'Invoiceno', 'type', 'Total', 'VAT', 'customer', 'date', 'Oreder Created'],
        colModel: [
            { name: 'id', index: 'Id', editable: false, width: 100, key: true, hidden: true },
            { name: 'code', index: 'code', editable: false, width: 150 },
            { name: 'invoiceno', index: 'invoiceno', editable: false, width: 150 },
     ");
            WriteLiteral(@"       { name: 'type', index: 'type', editable: false, width: 150 },
            {
                name: 'count', index: 'count', editable: false, width: 150
            },
            { name: 'amount', index: 'amount', editable: false, width: 150, formatter: 'number' },
            { name: 'customer', index: 'customer', editable: false, width: 150 },
            { name: 'date', index: 'date', editable: false, width: 150, formatter: 'date', formatoptions: { srcformat: 'Y/m/d', newformat: 'd-M-Y' } },
            { name: 'created', index: 'created', editable: false, width: 150 }
        ],

        jsonReader: {
            root: ""rows"",
            page: ""page"",
            total: ""total"",
            records: ""records"",
            repeatitems: false,
            id: ""0""
        },
        rowattr: function (rd) {
            if (rd.id === 0) {
                debugger
                return { ""class"": ""myMarking"" };
            }
        },
        rowNum: 250,
        rowList: [250");
            WriteLiteral(@", 500, 1000],
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
        emptyrecords: 'No records',
        footerrow: true,
        userDataOnFooter: true,
        grouping: true,
        gridComplete: function () {
            var $grid = $('#list-customersummary');
            $grid.jqGrid('footerData', 'set', {
                name: ""Total""
            });
            var colSum = $grid.jqGrid('getCol', 'count', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                total: colSum
            });
        },

        caption: 'Item wise Summary'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: true });
    $.ajax({
        url: '/Company");
            WriteLiteral(@"/GetSupplier',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serSupplier').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].supplierName + '</option>';
            }
            $('#serSupplier').append(divstring);
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
            $('#serCustomer').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].customerName + '</option>';
            }
            $('#serCustomer').append(divstring");
            WriteLiteral(@");
        },
        error: function () {
            console.log('err')
        }
    });
    jQuery(""#btnSearch"").click(function () {

        var CustomerId = $(""#serCustomer"").val();
        var SuplierId = $(""#serSupplier"").val();
        jQuery(""#list-customersummary"").jqGrid('setGridParam',
            { url: ""/Report/GetVatInfo?CustomerId="" + CustomerId + ""&SuplierId="" + SuplierId, page: 1 })
            .trigger(""reloadGrid"");
    });
    $(""#btnExport"").on(""click"", function () {
        createExcelFromGrid(""list-customersummary"", ""customersummary"")
    })
    function createExcelFromGrid(gridID, filename) {
        var grid = $('#' + gridID);
        var rowIDList = grid.getDataIDs();
        var row = grid.getRowData(rowIDList[0]);
        var colNames = [];
        var i = 0;
        var html = '<table border=""1px""><tr>';
        for (var cName in row) {
            if (cName == ""id"") {
            }
            else {
                colNames[i++] = cName;
          ");
            WriteLiteral(@"      html += '<th>' + cName + '</th>';

            }// Capture Column Names
        }
        html += '</tr>';
        for (var j = 0; j < rowIDList.length; j++) {
            row = grid.getRowData(rowIDList[j]); // Get Each Row
            html += '<tr>';
            for (var i = 0; i < colNames.length; i++) {
                html += '<td bgcolor=""#D0D3D4 "">' + row[colNames[i]] + '</td>'; // Create a CSV delimited with ;
            }
            html += '</tr>';
        }
        html += '</table>';

        var a = document.createElement('a');
        a.id = 'ExcelDL';
        a.href = 'data:application/vnd.ms-excel,' + escape(html);
        a.download = filename ? filename + "".xls"" : 'DataList.xls';
        document.body.appendChild(a);
        a.click(); // Downloads the excel document
        document.getElementById('ExcelDL').remove();
        //var wnd = window.open("""", """", ""_blank"");
        //wnd.document.write(html);
    }
    $(document).ready(function () {
        jQue");
            WriteLiteral("ry(\'.select2\').select2()\r\n    });\r\n</script>\r\n");
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
