#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Reports\View_CustomerSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6597b3201206bf4407e6314aff628b352a39db3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_View_CustomerSummary), @"mvc.1.0.view", @"/Views/Reports/View_CustomerSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/View_CustomerSummary.cshtml", typeof(AspNetCore.Views_Reports_View_CustomerSummary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6597b3201206bf4407e6314aff628b352a39db3f", @"/Views/Reports/View_CustomerSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_View_CustomerSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Reports\View_CustomerSummary.cshtml"
  
    ViewData["Title"] = "Customer Summary";
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6597b3201206bf4407e6314aff628b352a39db3f5831", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6597b3201206bf4407e6314aff628b352a39db3f7008", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6597b3201206bf4407e6314aff628b352a39db3f8185", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6597b3201206bf4407e6314aff628b352a39db3f9437", async() => {
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
            BeginContext(1022, 6626, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-2"">
                    Customer Name <br />
                    <select id=""serName"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Department""></select>
                </div>
                <div class=""col-md-2"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-customersummary"" style=""color:black !important"" class=""table table-dark""></table>
 ");
            WriteLiteral(@"               <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-customersummary').jqGrid({
        url: '/Report/GetCustomerInfo',
        datatype: 'json',
        colNames: ['Id', 'Code', 'Name', 'address', 'number', 'Credit Limit', 'Credit days', 'Day', 'assignedTo', 'Balance', 'Status'],
        colModel: [
            { name: 'id', index: 'Id', editable: false, width: 100, key: true, hidden: true },
            { name: 'code', index: 'code', editable: false, width: 150 },
            { name: 'name', index: 'name', editable: false, width: 150 },
            { name: 'address', index: 'address', editable: false, width: 150 },
            { name: 'number', index: 'number', editable: false, width: 150 },
            { name: 'creditlimit', index: 'creditlimit', editable: false, width: 150 },
            { name: 'creditdays', index: 'creditdays', editable: false, width: 150 },
            { name: 'assignedDay', index: 'assignedDay', editable: fal");
            WriteLiteral(@"se, width: 150 },
            { name: 'assignedTo', index: 'assignedTo', editable: false, width: 150 },
            { name: 'balance', index: 'balance', editable: false, width: 150 },
            { name: 'status', index: 'status', editable: false, width: 150 }
        ],
        jsonReader: {
            root: ""rows"",
            page: ""page"",
            total: ""total"",
            records: ""records"",
            repeatitems: false,
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
        emptyrecords: 'No records',
        footerrow: true,
        userDataOnFooter: true,
        grouping: true,

        caption: 'List of Customer Summar");
            WriteLiteral(@"y'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: true });
    $.ajax({
        url: '/Company/GetCustomer',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">SelectAll</option>';
            $('#serName').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].customerName + '</option>';
            }
            $('#serName').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });

    $.ajax({
        type: ""GET"",
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        url: '/Report/GetCustomerAlertList',
        success: function (response) {
            debugger;
            for (var i = 0; i < response.alert.length; i++) {
                debugger;
     ");
            WriteLiteral(@"           toastr.error('Customer Name:' + response.alert[i].customerName+ '<br />Zip:' + response.alert[i].zipcode);

                //$(document).Toasts('create', {
                //    class: 'bg-danger',
                //    title: response.alert[i].customerName,
                //    subtitle: 'Due',
                //    body: 'You have a Due for this customer'
                //});
                //$('.' + response[i]).show();
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            //window.open('/NotFound/NotFound');

        }
    });
    jQuery(""#btnSearch"").click(function () {

        var serName = $(""#serName"").val();
        jQuery(""#list-customersummary"").jqGrid('setGridParam',
            { url: ""/Report/GetCustomerInfo?CustomerId="" + serName, page: 1 })
            .trigger(""reloadGrid"");
    });
    $(""#btnExport"").on(""click"", function () {
        createExcelFromGrid(""list-customersummary"", ""customersummary"")
    })
    fu");
            WriteLiteral(@"nction createExcelFromGrid(gridID, filename) {
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
                html += '<th>' + cName + '</th>';

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
        a.id = 'E");
            WriteLiteral(@"xcelDL';
        a.href = 'data:application/vnd.ms-excel,' + escape(html);
        a.download = filename ? filename + "".xls"" : 'DataList.xls';
        document.body.appendChild(a);
        a.click(); // Downloads the excel document
        document.getElementById('ExcelDL').remove();
        //var wnd = window.open("""", """", ""_blank"");
        //wnd.document.write(html);
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
