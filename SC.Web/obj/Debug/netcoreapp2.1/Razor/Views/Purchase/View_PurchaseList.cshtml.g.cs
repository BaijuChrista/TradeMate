#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Purchase\View_PurchaseList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec5d679b9a63ecc8b980341ee91d0f738fc5111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_View_PurchaseList), @"mvc.1.0.view", @"/Views/Purchase/View_PurchaseList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchase/View_PurchaseList.cshtml", typeof(AspNetCore.Views_Purchase_View_PurchaseList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec5d679b9a63ecc8b980341ee91d0f738fc5111", @"/Views/Purchase/View_PurchaseList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_View_PurchaseList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.jqGrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid-bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid-bootstrap4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid-bootstrap-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ui.jqgrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Purchase\View_PurchaseList.cshtml"
  
    ViewData["Title"] = "Purchases List";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(95, 514, true);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec5d679b9a63ecc8b980341ee91d0f738fc51117278", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec5d679b9a63ecc8b980341ee91d0f738fc51118455", async() => {
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
            BeginContext(708, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec5d679b9a63ecc8b980341ee91d0f738fc51119632", async() => {
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
            BeginContext(770, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(772, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec5d679b9a63ecc8b980341ee91d0f738fc511110884", async() => {
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
            BeginContext(835, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(837, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec5d679b9a63ecc8b980341ee91d0f738fc511112137", async() => {
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
            BeginContext(902, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(904, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec5d679b9a63ecc8b980341ee91d0f738fc511113390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(956, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(958, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec5d679b9a63ecc8b980341ee91d0f738fc511114643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1012, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ec5d679b9a63ecc8b980341ee91d0f738fc511115898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1061, 1289, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-1"">
                    From Date <br /><input type=""text"" class=""form-control datepicker"" id=""serfromdate"" />
                </div>
                <div class=""col-md-1"">
                    To Date<br /> <input type=""text"" class=""form-control datepicker"" id=""sertodate"" />
                </div>
                <div class=""col-md-2"">
                    Reference No <br /><input type=""text"" class=""form-control"" id=""serRefNo"" />
                </div>
                <div class=""col-md-2"">
                    Invoice No <br /><input type=""text"" class=""form-control"" id=""serInvNo"" />
                </div>
                <div class=""col-md-3"">
                    Supplier<br />
                    <select id=""serSupplier"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""");
            WriteLiteral(@"top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-3"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2350, "\"", 2411, 3);
            WriteAttributeValue("", 2360, "location.href=\'", 2360, 15, true);
#line 50 "E:\Projects\RouteMapper\SC.Web\Views\Purchase\View_PurchaseList.cshtml"
WriteAttributeValue("", 2375, Url.Action("NewOrder", "Purchase"), 2375, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 2410, "\'", 2410, 1, true);
            EndWriteAttribute();
            BeginContext(2412, 15656, true);
            WriteLiteral(@">New</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                </div>
                <div class=""col-md-2"">
                    Cash In Hand <br /><input type=""text"" class=""form-control"" id=""cashinhand"" disabled=""disabled"" />
                </div>
            </div>
            <div class=""x_content"">
                <table id=""list-purchase"" style=""color:black !important"" class=""table table-dark""></table>
            </div>
            <div id=""pager""></div>
        </div>
    </div>
</div>
<script>
    $('#list-purchase').jqGrid({
        url: '/Purchase/GetPurchaseOrder',
        datatype: 'json',
        colNames: ['Id', 'SupplierInvoice#', 'Invoice No', 'Date', 'Supplier', 'Details', 'Total',");
            WriteLiteral(@" 'Due Amount', 'Process', 'Modify', 'delete', 'Print'],
        colModel: [
            { name: 'id', index: 'id', width: 200, hidden: true },
            { name: 'refno', index: 'refno', width: 200, sorttype: ""date"" },
            { name: 'invoiceno', index: 'invoiceno', width: 200, sorttype: ""date"" },
            { name: 'orderdate', index: 'orderdate', width: 120, formatter: 'date', formatoptions: { srcformat: 'Y/m/d', newformat: 'd-M-Y' } },
            { name: 'supplier.supplierName', index: 'supplier.supplierName', width: 200 },
            { name: 'details', index: 'details', width: 150 },
            {
                name: 'total', index: 'total', width: 150, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum""
            },  
            {
                name: 'balance', index: 'balance', width: 100, formatter: 'number',
                summaryTpl: ""Total : {0}  "",
                summaryType: ""sum"" },
            { name: 'process', ");
            WriteLiteral(@"width: 60, formatter: processInvoice },
            { name: 'modify', width: 60, formatter: addEditLink },
            { name: 'delete', width: 60, formatter: addDeleteLink },
            { name: 'print', width: 60, formatter: printInvoice }
        ],
        jsonReader: {
            root: ""rows"",
            page: ""page"",
            total: ""totalPages"",
            records: ""records"",
            repeatitems: false,
            id: ""0""
        },
        subGrid: true,
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
        emptyrecords: 'No records',
        subGridRowExpanded: function (subgrid_id, row_id) {
            debugger;
            var subgrid_table_id,");
            WriteLiteral(@" pager_id;
            subgrid_table_id = subgrid_id + ""_t"";
            pager_id = ""p_"" + subgrid_table_id;
            $(""#"" + subgrid_id).html(""<table id='"" + subgrid_table_id + ""' class='scroll'></table><div id='"" + pager_id + ""' class='scroll'></div>"");
            jQuery(""#"" + subgrid_table_id).jqGrid({
                url: ""/Purchase/GetPurchaseOrderDetails?q=2&PurchaseOrderId="" + row_id,
                datatype: 'json',
                colNames: ['Id', 'Sales Id', 'Item', 'Qty', 'Amount', 'Total'],
                colModel: [
                    { name: 'id', index: 'Id', editable: false, width: 100, key: true, hidden: true },
                    { name: 'purchaseOrderId', index: 'purchaseOrderId', editable: false, width: 100, hidden: true },
                    { name: ""itemMaster.itemName"", index: ""itemMaster.itemName"", width: 100 },
                    {
                        name: ""qty"", index: ""qty"", width: 100, formatter: 'number',
                        summaryTpl: ""Total : {0");
            WriteLiteral(@"}  ""
                    },
                    {
                        name: ""amount"", index: ""amount"", width: 100, formatter: 'number'
                    },
                    {
                        name: ""Total"", index: ""Total"", width: 100, formatter: getTotal
                    }


                ],
                jsonReader: {
                    root: ""rows"",
                    page: ""page"",
                    total: ""totalPages"",
                    records: ""records"",
                    repeatitems: false,
                    id: ""0""
                },
                //  pager: pager_id,
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
 ");
            WriteLiteral(@"               autowidth: true,
                shrinkToFit: true,
                scrollOffset: 0,
                emptyrecords: 'No records',
                autoencode: true,
                gridview: true,
                grouping: true,
                groupingView: {
                    groupField: [""purchaseOrderId""],
                    groupColumnShow: [false],
                    groupText: [""<b></b>""],
                    groupOrder: [""asc""],
                    groupSummary: [true],
                    groupCollapse: false

                },
                idPrefix: subgrid_table_id + ""_""
            });
            jQuery(""#"" + subgrid_table_id).jqGrid('navGrid', ""#"" + pager_id, { edit: false, add: false, del: false })
        },
        subGridRowColapsed: function (subgrid_id, row_id) {
        },
        rowNum: 250,
        rowList: [250, 500, 1000],
        pager: '#pager',
        sortname: 'code',
        sortorder: 'asc',
        //multiselect: true,
        ");
            WriteLiteral(@"viewrecords: true,
        height: '100%',
        width: '100%',
        sortorder: 'asc',
        loadonce: false,
        autowidth: true,
        shrinkToFit: true,
        scrollOffset: 0,
        emptyrecords: 'No records',
        grouping: true,
        footerrow: true,
        userDataOnFooter: true,
        grouping: true,
        gridComplete: function () {
            var $grid = $('#list-purchase');
            $grid.jqGrid('footerData', 'set', {
                name: ""Total""
            });
            var colSum = $grid.jqGrid('getCol', 'total', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                total: colSum
            });
            var colSum1 = $grid.jqGrid('getCol', 'balance', false, 'sum');
            $grid.jqGrid('footerData', 'set', {
                balance: colSum1
            });
        },
        caption: 'List of Purchases'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, close");
            WriteLiteral(@"AfterSearch: false },
    );
    jQuery('.datepicker').datepicker({
        dateFormat: 'dd/mm/yy'
    })
    function addstatus(cellvalue, options, rowObject) {
        if (rowObject.status == null)
            return '';
        switch (rowObject.status) {
            case 1: return 'New Order';
            case 2: return 'Order Processed';
            case 3: return 'Order Picked Up';
            case 4: return 'Delivered';
            case 5: return 'Cancelled';
        }
    }
    function getTotal(cellvalue, options, rowObject) {
        return (Math.round((rowObject.amount * rowObject.qty) * 100) / 100)

    }
    function getSum(cellvalue, options, rowObject) {
        debugger;
        var sum = 0;
        if (cellvalue == """")
            return (Math.round((rowObject.amount * rowObject.qty) * 100) / 100);
        sum = parseFloat(cellvalue);
        return sum + (Math.round((rowObject.amount * rowObject.qty) * 100) / 100);

    }
    jQuery(""#btnSearch"").click(function (");
            WriteLiteral(@") {
        var serfromdate = $(""#serfromdate"").val();
        var sertodate = $(""#sertodate"").val();
        var serRefNo = $(""#serRefNo"").val();
        var serInvNo = $(""#serInvNo"").val();
        var serSupplier = $(""#serSupplier"").val();
        jQuery(""#list-purchase"").jqGrid('setGridParam',
            {
                url: ""/Purchase/SearchPurchase?serfromdate="" + serfromdate + '&sertodate=' + sertodate + '&serRefNo=' + serRefNo + '&serInvNo=' + serInvNo + '&serSupplier=' + serSupplier
                , page: 1
            })
            .trigger(""reloadGrid"");
    });
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        if (rowObject.status == 1) {
            return '<a href=""/Purchase/NewOrder?id=' + Id + '""  class=""fa fas fa-edit""></a>';
        }
        else
            return '';
    }
    function addDeleteLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        if (rowObject.status == 1) {
            ret");
            WriteLiteral(@"urn '<a href=""javascript:RemovePurchaseOrder(' + Id + '); ""  class=""fa fas fa-trash""></a>';
        }
        else
            return '';
    }
    function RemovePurchaseOrder(Id) {
        if (confirm(""Are you sure want to delete"")) {
            $.ajax({

                url: '/Purchase/RemovePurchaseOrder',
                type: 'POST',
                dataType: 'json',
                data: { Id: Id },
                success: function () {
                    jQuery(""#list-purchase"").jqGrid('setGridParam',
                        {
                            url: '/Purchase/GetPurchaseOrder', page: 1
                        })
                        .trigger(""reloadGrid"");
                },
                error: function () {
                    console.log('err')
                }
            });
        }
    }
    function printInvoice(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""javascript:Print(' + Id + '); ""  class=""fa fas");
            WriteLiteral(@" fa-print""></a>';
    }
    function processInvoice(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        if (rowObject.status == 1) {
            return '<a href=""javascript:ProcessInvoice(' + Id + ');"" style=""color:green"" class=""fa fas fa-check-circle""></a>';
        }
        else
            return '';
    }
    function ProcessInvoice(Id) {
        if (confirm(""Are you sure want to Process"")) {
            
            $.ajax({
                url: ""/Purchase/ProcessPurchase"",
                type: 'POST',
                data: { Id },
                success: function (response) {
                    if (response != ""Success"") {
                        toastr.error(response.message);
                        return false;
                    }
                    else
                        toastr.success(response);
                    location.reload();
                },
                error: function (xhr) {
                    alert(""Something went wrong");
            WriteLiteral(@", please try again"");
                }
            });
        }
    }
    function Print(Id) {
        var wnd = window.open(""about:blank"", """", ""_blank"");
        $.ajax({
            url: ""/Purchase/GetPurchaseOrderDetails?PurchaseOrderId="" + Id,
            type: 'GET',
            success: function (response) {
                debugger;
                var html = '<!DOCTYPE html><html lang = ""en""><head><meta charset=""utf-8""><title>Example 1</title><link rel=""stylesheet"" href=""/css/Invoicestyle.css"" media=""all"" /></head><body>';
                var formatted = $.datepicker.formatDate(""M d, yy"", new Date(response.rows[0].purchase.orderdate));
                html += '<header class=""clearfix""><h1>Purchase Invoice</h1><div id=""company"" class=""clearfix""><div>' + response.rows[0].purchase.refno + '</div><div>' + response.rows[0].purchase.invoiceno + '</div><div>' + formatted + '</div><div><br /></div><div></div></div>';
                var total = 0;
                html += '<div id=""project""><");
            WriteLiteral(@"div>' + response.rows[0].purchase.supplier.supplierName + '</div><div>' + response.rows[0].purchase.supplier.supplierAddress + '</div><div>' + response.rows[0].purchase.supplier.zipcode + ',' + response.rows[0].purchase.supplier.city.name + '</div><div>' + response.rows[0].purchase.supplier.license + '</div><div>' + response.rows[0].purchase.supplier.taxNo + '</div><div>' + response.rows[0].purchase.supplier.supportMail + ',' + response.rows[0].purchase.supplier.supportNo + '</div>';
                //html += '</header><main><table><thead><tr><th class=""service"">SERVICE</th><th class=""desc"">DESCRIPTION</th><th>PRICE</th><th>QTY</th><th>TOTAL</th></tr></thead><tbody>';
                html += '</header><main><table><thead><tr><th class=""desc"">ItemName</th><th class=""desc"">Description</th><th>PRICE</th><th>QTY</th><th>TOTAL</th></tr></thead><tbody>';
                for (var i = 0; i < response.rows.length; i++) {
                    html += '<tr><td class=""desc"">' + response.rows[i].itemMaster.itemName + '");
            WriteLiteral(@"</td><td class=""desc"">' + response.rows[i].comments + '</td><td class=""unit"">' + response.rows[i].amount + '</td><td class=""qty"">' + response.rows[i].qty + '</td><td class=""total"">' + response.rows[i].amount * response.rows[i].qty + '</td></tr>';
                    //divstring += '<option Value=""' + items[i].id + '"">' + items[i].name + '</option>';
                    total += response.rows[i].amount * response.rows[i].qty;
                }
                //html += '<tr><td class=""service"">Development</td><td class=""desc"">Developing a Content Management System-based Website</td><td class=""unit"">$40.00</td><td class=""qty"">80</td><td class=""total"">$3,200.00</td></tr>';
                html += '<tr><tr><td colspan=""3"" class=""grand total"">GRAND TOTAL</td><td class=""grand total"">' + total + '</td></tr>';
                html += '</tbody></table><div id=""notices""><div>NOTICE:</div><div class=""notice"">A finance charge of 1.5% will be made on unpaid balances after 30 days.</div></div></main>';
             ");
            WriteLiteral(@"   html += '<footer>Invoice was created on a computer and is valid without the signature and seal.</footer></body></html>';
                wnd.document.write(html);
            },
            error: function (xhr) {
                alert(""Something went wrong, please try again"");
            }
        });

    }
    $(document).ready(function () {
        jQuery('.select2').select2();
        $.ajax({

            url: '/Report/GetCashInHand',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                $('#cashinhand').val(data);
            },
            error: function () {
                console.log('err')
            }
        });
    });
    $.ajax({

        url: '/Company/GetSupplier',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serSupplier').empty();
            for (var i = 0; i < data.rows.length");
            WriteLiteral(@"; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].supplierName + '</option>';
            }
            $('#serSupplier').append(divstring);
        },
        error: function () {
            console.log('err')
        }
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
