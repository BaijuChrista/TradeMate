#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Company\View_DeptListLoad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a2c0746ad31d0724612d95d76c4c345babeabc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_View_DeptListLoad), @"mvc.1.0.view", @"/Views/Company/View_DeptListLoad.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/View_DeptListLoad.cshtml", typeof(AspNetCore.Views_Company_View_DeptListLoad))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2c0746ad31d0724612d95d76c4c345babeabc1", @"/Views/Company/View_DeptListLoad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_View_DeptListLoad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\Projects\RouteMapper\SC.Web\Views\Company\View_DeptListLoad.cshtml"
  
    ViewData["Title"] = "Department List";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 461, true);
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
            BeginContext(557, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a2c0746ad31d0724612d95d76c4c345babeabc15755", async() => {
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
            BeginContext(603, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(605, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a2c0746ad31d0724612d95d76c4c345babeabc16932", async() => {
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
            BeginContext(654, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(864, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a2c0746ad31d0724612d95d76c4c345babeabc18109", async() => {
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
            BeginContext(916, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(918, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a2c0746ad31d0724612d95d76c4c345babeabc19361", async() => {
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
            BeginContext(970, 1268, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <div class=""col-md-3"">
                    Code <br /><input type=""text"" class=""form-control""  id=""serCode"" />
                </div>
                <div class=""col-md-3"">
                     Name <br /><input type=""text"" class=""form-control""  id=""serName"" />
                </div>
                <div class=""col-md-3"">
                    Category <br />
                    <select id=""serCategory"" name=""status"" class=""form-control select2"" data-toggle=""tooltip"" data-trigger=""hover"" data-placement=""top"" data-title=""Designation""></select>
                </div>
                <div class=""col-md-3"">
                    <br />
                    <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px !important; padding: 3px 10px;"" id=""btnExport"">Export</button>
                    <button type=""button"" class=""btn bt");
            WriteLiteral("n-primary pull-right\" style=\"margin-right: 5px !important; padding: 3px 10px;\" id=\"btnSearch\">Search</button>\r\n                    <button type=\"button\" class=\"btn btn-primary pull-right\" style=\"margin-right: 5px !important; padding: 3px 10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2238, "\"", 2303, 3);
            WriteAttributeValue("", 2248, "location.href=\'", 2248, 15, true);
#line 43 "E:\Projects\RouteMapper\SC.Web\Views\Company\View_DeptListLoad.cshtml"
WriteAttributeValue("", 2263, Url.Action("NewDepartment", "Company"), 2263, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 2302, "\'", 2302, 1, true);
            EndWriteAttribute();
            BeginContext(2304, 4736, true);
            WriteLiteral(@">New</button>
                </div>
            </div>
            <div class=""box-body"">
                <table id=""list-Department"" style=""color:black !important"" class=""table table-dark""></table>
                <div id=""pager""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#list-Department').jqGrid({
        url: '/Company/GetDepartment',
		datatype: 'json',
        colNames: ['Id', 'Code', 'Name', 'Category', 'Modify'],
		colModel: [
			{
				name: 'id', index: 'Id', editable: false, width: 100, key: true,hidden: true },
            { name: 'code', index: 'code', editable: true, width: 240, editrules: { required: true } },
            { name: 'name', index: 'name', editable: true, width: 240, editrules: { required: true } },
            { name: 'departmentGroup.name', index: 'departmentGroup.name', editable: true, width: 240, editrules: { required: true } },
            { name: 'modify', width: 60, formatter: addEditLink }
		],
		jsonReader: {
			root:");
            WriteLiteral(@" ""rows"",
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
		caption: 'List of Department'
    }).navGrid('#pager', { edit: false, add: false, del: false, search: false, refresh: false, closeAfterSearch: true  });
    $.ajax({

        url: '/Company/GetDepartmentCategory',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            var divstring = '';
            $('#serCategory').empty();
            for (var i = 0; i < data.rows.length; i++) {
                divstring += '<op");
            WriteLiteral(@"tion Value=""' + data.rows[i].id + '"">' + data.rows[i].name + '</option>';
            }
            $('#serCategory').append(divstring);
        },
        error: function () {
            console.log('err')
        }
    });
	jQuery(""#btnSearch"").click(function () {
        var serCode = $(""#serCode"").val();
        var serName = $(""#serName"").val();
        var serCategory = $(""#serCategory"").val();
        jQuery(""#list-Department"").jqGrid('setGridParam',
            { url: ""/Company/SearchDepartment?serCode="" + serCode + '&serName=' + serName + '&serCategory=' + serCategory, page: 1 })
            .trigger(""reloadGrid"");

    });
    function addEditLink(cellvalue, options, rowObject) {
        var Id = rowObject.id;
        return '<a href=""/Company/NewDepartment?id=' + Id + '""  class=""fa fas fa-edit""></a>';
    }
    $(""#btnExport"").on(""click"", function () {
        createExcelFromGrid(""list-Department"", ""Department"")
    })
    var createExcelFromGrid = function (gridID, filenam");
            WriteLiteral(@"e) {
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
            row = grid.getRowData(rowIDList[j]); // Get Each Row
            html += '<tr>';
            for (var i = 0; i < colNames.length; i++) {
                h");
            WriteLiteral(@"tml += '<td bgcolor=""#D0D3D4 "">' + row[colNames[i]] + '</td>'; // Create a CSV delimited with ;
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
