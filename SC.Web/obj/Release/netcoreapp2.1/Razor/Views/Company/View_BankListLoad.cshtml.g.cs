#pragma checksum "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Company\View_BankListLoad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce7d983e3574c9cac8186dea9680e18f9519ca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_View_BankListLoad), @"mvc.1.0.view", @"/Views/Company/View_BankListLoad.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/View_BankListLoad.cshtml", typeof(AspNetCore.Views_Company_View_BankListLoad))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bce7d983e3574c9cac8186dea9680e18f9519ca9", @"/Views/Company/View_BankListLoad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_View_BankListLoad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Company\View_BankListLoad.cshtml"
  
    ViewData["Title"] = "Bank List";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(90, 589, true);
            WriteLiteral(@"<script src=""//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""//ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/jquery-ui.min.js""></script>
<script type=""text/javascript"" language=""javascript"" src=""//cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js""></script>
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
            BeginContext(679, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1017ee688a4523a93df8ff65c09e02", async() => {
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
            BeginContext(725, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(727, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50d62eadee3c4e7ca828e653fd894860", async() => {
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
            BeginContext(776, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(986, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6be2a22d683f4e61bf95c5b1f1e7c5f5", async() => {
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
            BeginContext(1038, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1040, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7b30cd3e1f54f3291f07229e1a5d822", async() => {
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
            BeginContext(1092, 1420, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-2"">
                    Code <br /><input type=""text"" class=""form-control""  id=""serCode"" />
                </div>
                <div class=""col-md-2"">
                    Account No <br /><input type=""text"" class=""form-control""  id=""serAccount"" />
                </div>
                <div class=""col-md-2"">
                    Bank <br /><input type=""text"" class=""form-control""  id=""serBank"" />
                </div>
                <div class=""col-md-2"">
                    Currency <br /><select id=""serCurrency"" name=""status"" class=""form-contro select2l"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Bank""></select>
                </div>
                <div class=""col-md-2"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margi");
            WriteLiteral(@"n-right: 5px !important; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnSearch"">Search</button>                    
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2512, "\"", 2571, 3);
            WriteAttributeValue("", 2522, "location.href=\'", 2522, 15, true);
#line 46 "C:\Working\WorkFromHome\RouteMapper\SC.Web\Views\Company\View_BankListLoad.cshtml"
WriteAttributeValue("", 2537, Url.Action("NewBank", "Company"), 2537, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 2570, "\'", 2570, 1, true);
            EndWriteAttribute();
            BeginContext(2572, 4887, true);
            WriteLiteral(@">New</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-Bank"" style=""color:black !important"" class=""table table-dark""></table>
                <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-Bank').jqGrid({
        url: '/Company/GetBank',
		datatype: 'json',
        colNames: ['Id', 'Code','Ac No','Name','Currency','Modify'],
		colModel: [
			{
				name: 'id', index: 'Id', editable: false, width: 100, key: true,hidden: true },
            { name: 'code', index: 'code', editable: true, width: 240, editrules: { required: true } },
            { name: 'accno', index: 'accno', editable: true, width: 240, editrules: { required: true } },
            { name: 'bankname', index: 'bankname', editable: true, width: 240, editrules: { required: true } },
            { name: 'currency.name', index: 'currency.name', editable: true, width: 240, editrules: { required: true } },
          ");
            WriteLiteral(@"  { name: 'modify', width: 60, formatter: addEditLink }
            
		],
		jsonReader: {
			root: ""rows"",
			page: ""page"",
			total: ""total"",
			records: ""records"",
			repeatitems: false,
			id: ""0""  },
        rowNum: 250,
        rownumbers: true,
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
		caption: 'List of Banks'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: true  });
    $.ajax({

        url: '/Company/GetCurrency',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '';
            $('#serCurrency').empty();");
            WriteLiteral(@"
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<option Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serCurrency').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
	jQuery(""#btnSearch"").click(function () {
        var serCode = $(""#serCode"").val();
        var serAccount = $(""#serAccount"").val();
        var serBank = $(""#serBank"").val();
        var serCurrency = $(""#serCurrency"").val();
        jQuery(""#list-Bank"").jqGrid('setGridParam',
            { url: ""/Company/SearchBank?serCode="" + serCode + '&serAccount=' + serAccount + '&serBank=' + serBank + '&serCurrency=' + serCurrency, page: 1 })
            .trigger(""reloadGrid"");
    });
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""/Company/NewBank?id=' + Id + '""  class=""fa fas fa-edit""></a>';
    }
    $(""#btnExport"")");
            WriteLiteral(@".on(""click"", function () {
        createExcelFromGrid(""list-Bank"", ""Bank"")
    })
    var createExcelFromGrid = function (gridID, filename)
    {
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
                    case ""smallunit"": html += '<th>Unit</th>';
                        break;
                    case ""roe"": html += '<th>ROE</th>';
                        break;
                }
            }// Capture Column Names
        }
        html += '</tr>';
        for (var j = 0; j < rowIDList.length; j++) {
            row = grid.");
            WriteLiteral(@"getRowData(rowIDList[j]); // Get Each Row
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
