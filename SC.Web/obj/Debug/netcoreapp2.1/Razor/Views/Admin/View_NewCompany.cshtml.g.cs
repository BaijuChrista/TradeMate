#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d76ec557bcec516ecfcdbd965ecdecd41937d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_View_NewCompany), @"mvc.1.0.view", @"/Views/Admin/View_NewCompany.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/View_NewCompany.cshtml", typeof(AspNetCore.Views_Admin_View_NewCompany))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d76ec557bcec516ecfcdbd965ecdecd41937d2", @"/Views/Admin/View_NewCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_View_NewCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Company>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
  
    ViewData["Title"] = "New Company Registration";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(123, 512, true);
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
            BeginContext(635, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51d76ec557bcec516ecfcdbd965ecdecd41937d25885", async() => {
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
            BeginContext(681, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(683, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51d76ec557bcec516ecfcdbd965ecdecd41937d27062", async() => {
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
            BeginContext(732, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(942, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51d76ec557bcec516ecfcdbd965ecdecd41937d28239", async() => {
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
            BeginContext(994, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(996, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51d76ec557bcec516ecfcdbd965ecdecd41937d29491", async() => {
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
            BeginContext(1048, 783, true);
            WriteLiteral(@"
<style>
    #map {
        height: 350px;
        width: 350px;
        display: block;
    }
    /* Optional: Makes the sample page fill the window. */
    html, body {
        height: 100%;
        margin: 0;
        padding: 0;
    }

    #floating-panel {
        position: absolute;
        top: 10px;
        left: 25%;
        z-index: 5;
        background-color: #fff;
        padding: 5px;
        border: 1px solid #999;
        text-align: center;
        font-family: 'Roboto','sans-serif';
        line-height: 30px;
        padding-left: 10px;
    }
</style>
<!doctype html>
<html>
<div class=""row"">
    <!-- left column -->
    <div class=""col-md-12"">
        <!-- general form elements -->
        <div class=""box box-primary"">

");
            EndContext();
#line 62 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
             using (Html.BeginForm("CreateCompany", "Admin", FormMethod.Post,
     new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
            BeginContext(1971, 425, true);
            WriteLiteral(@"<div class=""box-header with-border"">
                    <h1 class=""box-title"">New Company Registration</h1>
                    <button type=""submit"" class=""btn btn-primary btn-flat pull-right"">Save</button>
                </div>
                <div class=""box-body"">
                    <div class=""form-group col-lg-6"">
                        <label for=""exampleInputEmail1"">Name</label>
                        ");
            EndContext();
            BeginContext(2397, 100, false);
#line 71 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.CompanyName, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 185, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-6\">\r\n                        <label for=\"exampleInputEmail1\">Short Name</label>\r\n                        ");
            EndContext();
            BeginContext(2683, 98, false);
#line 75 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.shortname, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2781, 191, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <label for=\"exampleInputEmail1\">Company Address</label>\r\n                        ");
            EndContext();
            BeginContext(2973, 103, false);
#line 79 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.CompanyAddress, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3076, 183, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-3\">\r\n                        <label for=\"exampleInputEmail1\">Zip Code</label>\r\n                        ");
            EndContext();
            BeginContext(3260, 96, false);
#line 83 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Zipcode, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(3356, 179, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-3\">\r\n                        <label for=\"exampleInputEmail1\">City</label>\r\n                        ");
            EndContext();
            BeginContext(3536, 305, false);
#line 87 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.DropDownListFor(x => x.CityId, new List<SelectListItem>{
      new SelectListItem {Text="Abu Dhabi",Value="2" },
      new SelectListItem {Text="Dubai",Value="2" },
      new SelectListItem {Text="Sharjah",Value="2" },
   },"Choose", new { style = "width:100%", @class = "form-control select2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3841, 181, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group col-lg-3\">\r\n                        <label for=\"exampleInputEmail1\">Mail</label>\r\n                        ");
            EndContext();
            BeginContext(4023, 100, false);
#line 96 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.SupportMail, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4123, 182, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <label for=\"exampleInputEmail1\">Number</label>\r\n                        ");
            EndContext();
            BeginContext(4306, 98, false);
#line 100 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.SupportNo, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4404, 183, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <label for=\"exampleInputEmail1\">License</label>\r\n                        ");
            EndContext();
            BeginContext(4588, 96, false);
#line 104 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.License, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4684, 185, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-3\">\r\n                        <label for=\"exampleInputEmail1\">Started In</label>\r\n                        ");
            EndContext();
            BeginContext(4870, 109, false);
#line 108 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.StartedIn, new { @class = "form-control datepicker", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(4979, 182, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <label for=\"exampleInputEmail1\">Tax No</label>\r\n                        ");
            EndContext();
            BeginContext(5162, 94, false);
#line 112 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.TaxNo, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5256, 185, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <label for=\"exampleInputEmail1\">Other Reg</label>\r\n                        ");
            EndContext();
            BeginContext(5442, 97, false);
#line 116 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Otherreg, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5539, 183, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <label for=\"exampleInputEmail1\">Details</label>\r\n                        ");
            EndContext();
            BeginContext(5723, 96, false);
#line 120 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Details, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(5819, 196, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        <div id=\"floating-panel\">\r\n                            <input id=\"address\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6015, "\"", 6023, 0);
            EndWriteAttribute();
            BeginContext(6024, 220, true);
            WriteLiteral(">\r\n                            <input id=\"Mapsubmit\" type=\"button\" value=\"GetCurrent\">\r\n                        </div>\r\n                        <div id=\"map\"></div>\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(6261, 33, false);
#line 131 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
           Write(Html.HiddenFor(Model => Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(6313, 40, false);
#line 132 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
           Write(Html.HiddenFor(Model => Model.Lattitude));

#line default
#line hidden
            EndContext();
            BeginContext(6372, 40, false);
#line 133 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
           Write(Html.HiddenFor(Model => Model.Longitude));

#line default
#line hidden
            EndContext();
#line 133 "E:\Projects\RouteMapper\SC.Web\Views\Admin\View_NewCompany.cshtml"
                                                         
            }

#line default
#line hidden
            BeginContext(6429, 45, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n</html>\r\n");
            EndContext();
            BeginContext(6528, 2684, true);
            WriteLiteral(@"<script>

    $(document).ready(function () {
        jQuery('.select2').select2()
    });
    jQuery('.datepicker').datepicker({
        dateFormat: 'dd/mm/yy'
    })

    var map, infoWindow;
    function initMap() {
        map = new google.maps.Map(document.getElementById('map'), {
            zoom: 14,
            center: { lat: 24.4644789, lng: 54.3651206 }
        });
        var geocoder = new google.maps.Geocoder();

        document.getElementById('Mapsubmit').addEventListener('click', function () {
            geocodeAddress(geocoder, map);
        });
        google.maps.event.addListener(map, 'click', function (event) {
            $(""#Lattitude"").val(event.latLng.lat());
            $(""#Longitude"").val(event.latLng.lng());
            geocoder.geocode({
                'latLng': event.latLng
            }, function (results, status) {
                if (status ==
                    google.maps.GeocoderStatus.OK) {
                    if (results[1]) {
             ");
            WriteLiteral(@"           $(""#CompanyAddress"").val(results[1].formatted_address);
                        alert(""Location Picked"");

                    } else {
                        alert('No results found');
                    }
                } else {
                    alert('Geocoder failed due to: ' + status);
                }
            });
        });
        infoWindow = new google.maps.InfoWindow;
        function geocodeAddress(geocoder, resultsMap) {
            debugger;
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    debugger;
                    $(""#Lattitude"").val(position.coords.latitude);
                    $(""#Longitude"").val(position.coords.longitude);
                    $(""#CompanyAddress"").val(position.formatted_address);
                    alert(""Location Picked"");

                });
            }
        }
    }

    function handleLocationError(browserHasGeolocation, in");
            WriteLiteral(@"foWindow, pos) {
        infoWindow.setPosition(pos);
        infoWindow.setContent(browserHasGeolocation ?
            'Error: The Geolocation service failed.' :
            'Error: Your browser doesn\'t support geolocation.');
        infoWindow.open(map);
    }


    function resizeChosen() {
        $("".chosen-container"").each(function () {
            $(this).attr('style', 'width: 100%');
            //$(this).attr('style', 'height: 200%');
        });
    }
</script>

<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBZ_WzHFJGtNughETwVqmHBvnl-wKZmFnk&callback=initMap"" async defer></script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
