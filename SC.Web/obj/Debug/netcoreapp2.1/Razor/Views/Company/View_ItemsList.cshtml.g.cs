#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Company\View_ItemsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b554c26e306fa48cef269f147723e7c10fac870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_View_ItemsList), @"mvc.1.0.view", @"/Views/Company/View_ItemsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/View_ItemsList.cshtml", typeof(AspNetCore.Views_Company_View_ItemsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b554c26e306fa48cef269f147723e7c10fac870", @"/Views/Company/View_ItemsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_View_ItemsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Company\View_ItemsList.cshtml"
  
    ViewData["Title"] = "Item List";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(90, 512, true);
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
            BeginContext(602, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b554c26e306fa48cef269f147723e7c10fac8705776", async() => {
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
            BeginContext(648, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(650, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b554c26e306fa48cef269f147723e7c10fac8706953", async() => {
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
            BeginContext(699, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(909, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b554c26e306fa48cef269f147723e7c10fac8708130", async() => {
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
            BeginContext(961, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(963, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b554c26e306fa48cef269f147723e7c10fac8709382", async() => {
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
            BeginContext(1015, 1514, true);
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
            BeginWriteAttribute("onclick", " onclick=\"", 2529, "\"", 2588, 3);
            WriteAttributeValue("", 2539, "location.href=\'", 2539, 15, true);
#line 45 "E:\Projects\RouteMapper\SC.Web\Views\Company\View_ItemsList.cshtml"
WriteAttributeValue("", 2554, Url.Action("NewItem", "Company"), 2554, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 2587, "\'", 2587, 1, true);
            EndWriteAttribute();
            BeginContext(2589, 8856, true);
            WriteLiteral(@">New</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-item"" style=""color:black !important"" class=""table table-dark""></table>
                <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-item').jqGrid({
        url: '/Company/GetAllItemMaster',
        datatype: 'json',
        colNames: ['Id', 'ItemCode', 'Name', 'ItemCategory', 'Brand', 'Price', 'Tax', 'Description', 'Quantity', 'ROL','Status', 'Modify', 'Active/InActive'],
        colModel: [
            {
                name: 'id', index: 'id', editable: false, width: 100, key: true, hidden: true
            },
            { name: 'itemCode', index: 'itemCode', editable: true, width: 100, editrules: { required: true } },
            { name: 'itemName', index: 'itemName', editable: true, width: 200 },
            { name: 'itemCategory.categoryName', index: 'itemCategory.categoryName', editable: false, width: 120 },
");
            WriteLiteral(@"            { name: 'itemBrand.brnadname', index: 'itemBrand.brnadname', editable: false, width: 120 },
            { name: 'price', index: 'price', editable: true, width: 100 },
            { name: 'taxMaster.taxName', index: 'taxName', editable: false, width: 100 },
            { name: 'description', index: 'description', editable: true, width: 200 },
            { name: 'qty', index: 'qty', editable: true, width: 100 },
            { name: 'rol', index: 'rol', editable: true, width: 100 },
            { name: 'statusColumn', width: 60, formatter: addstatus },
            { name: 'customColumns', width: 60, formatter: addEditLink },
            { name: 'deleteColumns', width: 60, formatter: addDeleteLink }

        ],
        jsonReader: {
            root: ""rows"",
            page: ""page"",
            total: ""total"",
            records: ""records"",
            repeatitems: false,
            id: ""0""
        },
    rownumbers: true,
        rowNum: 250,
        rowList: [250, 500, 1000]");
            WriteLiteral(@",
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
        caption: 'List of Items'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: false });
    $.ajax({

        url: '/Company/GetCategory',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">Select All</option>';
            $('#serCategory').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].categoryName + '</option>';
            }
            $('#serCategory').append(divstring);
        },
      ");
            WriteLiteral(@"  error: function () {
            console.log('err')
        }
    });
    $.ajax({

        url: '/Company/GetItemBrand',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '<option Value=""0"">Select All</option>';
            $('#serBrand').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].brnadname + '</option>';
            }
            $('#serBrand').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
    jQuery(""#btnSearch"").click(function () {
        debugger;
        var serCode = $(""#serCode"").val();
        var serName = $(""#serName"").val();
        var serCategory = $(""#serCategory"").val();
        var serBrand = $(""#serBrand"").val();
        jQuery(""#list-item"").jqGrid('setGridParam',
            { url: ""/Company/SearchItem?serCode="" + serCode + '&serNam");
            WriteLiteral(@"e=' + serName + '&serCategory=' + serCategory + '&serBrand=' + serBrand, page: 1 })
            .trigger(""reloadGrid"");
        
        //$.ajax({
        //    url: ""https://testinforapi.ntravel.ae/api/currency"",
        //    method: ""POST"",
        //    dataType: ""json"",
        //    crossDomain: true,
        //    contentType: ""application/json; charset=utf-8"",
        //    data: JSON.stringify({ request_date:""2020-07-01T12:17:33.814Z""}),
        //    cache: false,
        //    beforeSend: function (xhr) {
        //        /* Authorization header */
        //        xhr.setRequestHeader(""Authorization"", ""bearer ansuMJN50Ijxx4wy3j9w_7tgud8sdOZNrbXxC7lUrGga80U7KyUfnOJh0zqsvTY7BD0EWfBUSB2R1GNf2tKjxOeJ60v3rEjccFU62SP_dB-ct4_PPNa7lb9QMzPxw-RTq51a5eZ1h_SmTehImSziyhup4XQlJNckXGnQFW9rl5RyB_bqLPj7IelPFcKePmP58lgEDMMHpnzvLpkXSauAKZEDQ9UmQDXWAqwgJDfjZ9OUADuZmSxfvN9gEU_ouoqXoGwVO_0mwH_0AQR77SR6Jmk9q8p_k-s_IayRMAj0-oUdTwOL3r1uIqljM50Fvv01RnyfkHhtOALs5Nc0JnkLSXnJF_9PkyyWYQg69U5kSZJaPT9ysOsp2RbuSio");
            WriteLiteral(@"9DToNdBzxOI_d8IalyXj7jcnjaUYwLkSfNGG0UZi9HUIAEyBa9fAlkjFALo1xKNIynM0OPWrM0-zgjTLgpxLsBQQ2UY1kh5mfdlY76FlS4nfBumHOCeK65QGCfOBRt8MktCb731eQOOlMFfS14-OJVBQ8ZUKUuvP8bN6mwO7jsjKyl7Y"");
        //        //xhr.setRequestHeader(""X-Mobile"", ""false"");
        //    },
        //    success: function (data) {
        //        debugger;
        //    },
        //    error: function (jqXHR, textStatus, errorThrown) {
        //        debugger;
        //    }
        //});

    });
   
    function addstatus(cellvalue, options, rowObject) {
        if (rowObject.status == null)
            return '';
        switch (rowObject.status) {
            case 1: return 'Active';
            case 2: return 'In Active';
        }
    }
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""/Company/NewItem?id=' + Id + '""  class=""fa fas fa-edit""></a>';
    }
    function addDeleteLink(cellvalue, options, rowObject) {
        var Id = rowObject.");
            WriteLiteral(@"id;
        if (rowObject.status == 1) {
            return '<a href=""javascript:deleteItem(' + Id + ');"" style=""color:red""  class=""fa fas fa-trash""></a>';
        }
        return '<a href=""javascript:deleteItem(' + Id + ');"" style=""color:green""  class=""fa fas fa-check-circle""></a>';
    }
    $(""#btnExport"").on(""click"", function () {
        createExcelFromGrid(""list-item"", ""Item"")
    })
    var createExcelFromGrid = function (gridID, filename) {
        var grid = $('#' + gridID);
        var rowIDList = grid.getDataIDs();
        var row = grid.getRowData(rowIDList[0]);
        var colNames = [];
        var i = 0;
        var html = '<table border=""1px""><tr>';
        for (var cName in row) {
            if (cName == ""id"" || cName == ""modify"") {
            }
            else {
                colNames[i++] = cName;
                switch (cName) {
                    case ""name"": html += '<th>Name</th>';
                        break;
                    case ""smallunit"": html +");
            WriteLiteral(@"= '<th>Unit</th>';
                        break;
                    case ""roe"": html += '<th>ROE</th>';
                        break;
                }
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
    }
    function deleteItem");
            WriteLiteral(@"(id) {
        if (confirm(""Are you sure want to Delete Item"")) {
            $.ajax({
                url: '/Company/DeleteItem',
                type: 'POST',
                dataType: 'json',
                data: { Id: id },
                async: false,
                success: function (data) {
                    alert(data);
                    window.location.href ='/Company/ItemsListLoad'
                },
                error: function () {
                    console.log('err')
                }
            });
        }
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