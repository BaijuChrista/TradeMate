#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Purchase\View_SupplierPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d81fde8af7614f23561b7a10ee4e0bf3879d109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_View_SupplierPayment), @"mvc.1.0.view", @"/Views/Purchase/View_SupplierPayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchase/View_SupplierPayment.cshtml", typeof(AspNetCore.Views_Purchase_View_SupplierPayment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d81fde8af7614f23561b7a10ee4e0bf3879d109", @"/Views/Purchase/View_SupplierPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_View_SupplierPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Purchase\View_SupplierPayment.cshtml"
  
    ViewData["Title"] = "Supplier Payment";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(97, 514, true);
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
            BeginContext(611, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d81fde8af7614f23561b7a10ee4e0bf3879d1097304", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d81fde8af7614f23561b7a10ee4e0bf3879d1098481", async() => {
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
            BeginContext(710, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d81fde8af7614f23561b7a10ee4e0bf3879d1099658", async() => {
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
            BeginContext(772, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(774, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d81fde8af7614f23561b7a10ee4e0bf3879d10910910", async() => {
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
            BeginContext(837, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(839, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d81fde8af7614f23561b7a10ee4e0bf3879d10912163", async() => {
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
            BeginContext(904, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(906, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d81fde8af7614f23561b7a10ee4e0bf3879d10913416", async() => {
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
            BeginContext(958, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(960, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d81fde8af7614f23561b7a10ee4e0bf3879d10914669", async() => {
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
            BeginContext(1012, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1014, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d81fde8af7614f23561b7a10ee4e0bf3879d10915924", async() => {
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
            BeginContext(1063, 14394, true);
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
                <div class=""col-md-2"">
                    Supplier City <br />
                    <select id=""serCity"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement");
            WriteLiteral(@"=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Supplier Category <br />
                    <select id=""serCategory"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    Supplier Group <br />
                    <select id=""serGroup"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-3"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSavePayment"">Pay</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" ");
            WriteLiteral(@"id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                </div>
                <div class=""col-md-2"">
                    Cash In Hand <br /><input type=""text"" class=""form-control"" id=""cashinhand"" disabled=""disabled"" />
                </div>
            </div>
            <div class=""x_content"">
                <table id=""list-supplierpay"" style=""color:black !important"" class=""table table-dark""></table>
            </div>
            <div id=""pager""></div>
        </div>
    </div>
</div>
<script>
   
    $('#list-supplierpay').jqGrid({
        url: '/Report/GetSupplierSOA',
        datatype: 'json',
        colNames: ['Id', 'Date', 'Ref No', 'Invoice#', 'Supplier', 'Details', 'Total', 'Due Days', 'Balance', 'Amount Paying','Print'],
        colModel: [
            { name: 'id', index: 'id', editable: false, width: 100, key: true, hid");
            WriteLiteral(@"den: true },
            { name: 'orderdate', index: 'orderdate', width: 120, editable: false, formatter: 'date', formatoptions: { srcformat: 'Y/m/d', newformat: 'd-M-Y' } },
            { name: 'refno', index: 'refno', width: 200, editable: false, },
            { name: 'invoiceno', index: 'invoiceno', width: 200, editable: false, },
            { name: 'supplierName', index: 'supplierName', editable: false, width: 200 },
            { name: 'details', index: 'details', editable: false, width: 250 },
            { name: 'total', index: 'total', width: 250, editable: false, align: ""right"", sorttype: ""float"", formatter: ""number"" },
            { name: 'due', index: 'due', editable: false, width: 250, },
            { name: 'balance', index: 'balance', width: 250, align: ""right"", editable: false, sorttype: ""float"", formatter: ""number"" },
            { name: 'amount', index: 'amount', width: 250, align: ""right"", editoptions: { defaultValue: '0' }, editable: true, sorttype: ""float"", formatter: ""number"" }");
            WriteLiteral(@",
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
        subGrid: false,
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
        onSelectRow: function (id) {
            jQuery('#list-supplierpay').jqGrid('editRow', id, true);

        },
        rowNum: 250,
        rowList: [250, 500, 1000],
        pager: '#pager',
        sortname: 'code',
        sortorder: 'asc',
        //multiselect: true,
  ");
            WriteLiteral(@"      viewrecords: true,
        height: '100%',
        width: '100%',
        sortorder: 'asc',
        loadonce: false,
        autowidth: true,
        shrinkToFit: true,
        scrollOffset: 0,
        emptyrecords: 'No records',
        grouping: true,
        caption: 'List of Supplier Statements'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: false },
    );
    jQuery('.datepicker').datepicker({
        dateFormat: 'dd/mm/yy'
    })
    function addamount(cellvalue, options, rowObject) {
        return rowObject.balance;
    }
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
    ");
            WriteLiteral(@"jQuery(""#btnSearch"").click(function () {
        var serfromdate = $(""#serfromdate"").val();
        var sertodate = $(""#sertodate"").val();
        var serRefNo = $(""#serRefNo"").val();
        jQuery(""#list-supplierpay"").jqGrid('setGridParam',
            {
                url: ""/EndUser/SearchSalesOrders?serfromdate="" + serfromdate + '&sertodate=' + sertodate + '&serRefNo=' + serRefNo
                , page: 1
            })
            .trigger(""reloadGrid"");
    });
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""/Purchase/NewOrder?id=' + Id + '""  class=""fa fas fa-edit""></a>';
    }
    $.ajax({

        url: '/Company/GetSupplierCategory',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serCategory').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option");
            WriteLiteral(@" Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serCategory').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
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

    function printInvoice(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""javascript:Print(' + Id + '); ""  class=""fa fas fa-print""></a>';
    }
    function Print(Id) {
        var wnd = window.open(""about:blank"", """", ""_blank"");
        $.ajax({
            url: ""/Purchase/GetPurchaseOrderDetails?PurchaseOrderId="" + Id,
            type: 'GET',
            success: function (response) {
                debugger;
                var html = '<!DOCTYPE html><html ");
            WriteLiteral(@"lang = ""en""><head><meta charset=""utf-8""><title>Example 1</title><link rel=""stylesheet"" href=""/css/Invoicestyle.css"" media=""all"" /></head><body>';
                var formatted = $.datepicker.formatDate(""M d, yy"", new Date(response.rows[0].purchase.orderdate));
                html += '<header class=""clearfix""><h1>Purchase Invoice</h1><div id=""company"" class=""clearfix""><div>' + response.rows[0].purchase.refno + '</div><div>' + response.rows[0].purchase.invoiceno + '</div><div>' + formatted + '</div><div><br /></div><div></div></div>';
                var total = 0;
                html += '<div id=""project""><div>' + response.rows[0].purchase.supplier.supplierName + '</div><div>' + response.rows[0].purchase.supplier.supplierAddress + '</div><div>' + response.rows[0].purchase.supplier.zipcode + ',' + response.rows[0].purchase.supplier.city.name + '</div><div>' + response.rows[0].purchase.supplier.license + '</div><div>' + response.rows[0].purchase.supplier.taxNo + '</div><div>' + response.rows[0].purchase.su");
            WriteLiteral(@"pplier.supportMail + ',' + response.rows[0].purchase.supplier.supportNo + '</div>';
                //html += '</header><main><table><thead><tr><th class=""service"">SERVICE</th><th class=""desc"">DESCRIPTION</th><th>PRICE</th><th>QTY</th><th>TOTAL</th></tr></thead><tbody>';
                html += '</header><main><table><thead><tr><th class=""desc"">ItemName</th><th>PRICE</th><th>QTY</th><th>TOTAL</th></tr></thead><tbody>';
                for (var i = 0; i < response.rows.length; i++) {
                    html += '<tr><td class=""desc"">' + response.rows[i].itemMaster.itemName + '</td><td class=""unit"">' + response.rows[i].amount + '</td><td class=""qty"">' + response.rows[i].qty + '</td><td class=""total"">' + response.rows[i].amount * response.rows[i].qty + '</td></tr>';
                    //divstring += '<option Value=""' + items[i].id + '"">' + items[i].name + '</option>';
                    total += response.rows[i].amount * response.rows[i].qty;
                }
                //html += '<tr><td class=""");
            WriteLiteral(@"service"">Development</td><td class=""desc"">Developing a Content Management System-based Website</td><td class=""unit"">$40.00</td><td class=""qty"">80</td><td class=""total"">$3,200.00</td></tr>';
                html += '<tr><tr><td colspan=""3"" class=""grand total"">GRAND TOTAL</td><td class=""grand total"">' + total + '</td></tr>';
                html += '</tbody></table><div id=""notices""><div>NOTICE:</div><div class=""notice"">A finance charge of 1.5% will be made on unpaid balances after 30 days.</div></div></main>';
                html += '<footer>Invoice was created on a computer and is valid without the signature and seal.</footer></body></html>';
                wnd.document.write(html);
            },
            error: function (xhr) {
                alert(""Something went wrong, please try again"");
            }
        });

    }
    $.ajax({

        url: '/Company/GetSupplierGroup',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring");
            WriteLiteral(@" = '<option Value=""0"">SelectAll</option>';
            $('#serGroup').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serGroup').append(divstring);
        },
        error: function () {
            console.log('err')
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
    $(document).ready(function () {
        jQuery('.select");
            WriteLiteral(@"2').select2()
    });

    $(document).on(""click"", ""#btnSavePayment"", function () {
        debugger;
        var purchasepaiddetails = [];
        var gridID = ""list-supplierpay"";
        var grid = $('#' + gridID);
        var rowIDList = grid.getDataIDs();
        var row = grid.getRowData(rowIDList[0]);
        var amount = 0;
        debugger;
        for (var j = 0; j < rowIDList.length; j++) {
            row = grid.getRowData(rowIDList[j]); // Get Each Row
            if (row.amount > 0) {
                amount += parseFloat(row.amount);
                purchasepaiddetails.push({
                    PurchaseOrderId: row.id,
                    amount: row.amount
                });
            }
        }
        var cashinhand = $('#cashinhand').val();
        if (amount > cashinhand) {
            toastr.error(""Not enough cash in hand"");
            return false;
        }
        debugger;
        $.ajax({
            url: ""/Purchase/Savepurchasepaiddetail"",
         ");
            WriteLiteral(@"   type: 'POST',
            data: { purchasepaiddetails: purchasepaiddetails },
            success: function (response) {
                for (var i = 0; i < response.vouchers.length; i++)
                    toastr.success(response.vouchers[i]);
                jQuery(""#list-supplierpay"").jqGrid('setGridParam',
                    {
                        url: ""/Report/GetSupplierSOA""
                        , page: 1
                    })
                    .trigger(""reloadGrid"");
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
            },
            error: function (xhr) {
                alert(""Something went wrong, please try agai");
            WriteLiteral("n\");\r\n            }\r\n        });\r\n\r\n\r\n    });\r\n</script>\r\n");
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
