#pragma checksum "E:\Projects\RouteMapper\SC.Web\Views\Delivery\View_RouteMaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f8404bcffcc6b68130bafd2604523a2a960fe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_View_RouteMaps), @"mvc.1.0.view", @"/Views/Delivery/View_RouteMaps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Delivery/View_RouteMaps.cshtml", typeof(AspNetCore.Views_Delivery_View_RouteMaps))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f8404bcffcc6b68130bafd2604523a2a960fe2", @"/Views/Delivery/View_RouteMaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4354c903c7f5a89f7bed2350beb2f082f3087a", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_View_RouteMaps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SC.Data.Customer>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\RouteMapper\SC.Web\Views\Delivery\View_RouteMaps.cshtml"
  
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(77, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(102, 875, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f8404bcffcc6b68130bafd2604523a2a960fe25545", async() => {
                BeginContext(108, 862, true);
                WriteLiteral(@"
    <title>Simple Map</title>
    <style>
        /* Always set the map height explicitly to define the size of the div
        * element that contains the map. */
        #map {
            height: 500px;
            width: 500px;
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
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(977, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(979, 11827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f8404bcffcc6b68130bafd2604523a2a960fe27589", async() => {
                BeginContext(985, 699, true);
                WriteLiteral(@"
    <div id=""map""></div>
    <input id=""Mapsubmit"" type=""button"" value=""GetNavigation"">
    <div id=""directions-panel""></div>
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
                BeginContext(1684, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f8404bcffcc6b68130bafd2604523a2a960fe28685", async() => {
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
                BeginContext(1730, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1736, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f8404bcffcc6b68130bafd2604523a2a960fe29940", async() => {
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
                BeginContext(1785, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2007, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2011, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73f8404bcffcc6b68130bafd2604523a2a960fe211307", async() => {
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
                BeginContext(2063, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2069, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73f8404bcffcc6b68130bafd2604523a2a960fe212642", async() => {
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
                BeginContext(2121, 10678, true);
                WriteLiteral(@"
    <script>
        //var map;
        //function initMap() {
        //    map = new google.maps.Map(document.getElementById('map'), {
        //        center: { lat: 24.4644789, lng: 54.3651206 },
        //        zoom: 14
        //    });
        //    var geocoder = new google.maps.Geocoder();

        //    document.getElementById('submit').addEventListener('click', function () {
        //        geocodeAddress(geocoder, map);
        //    });
        //}

        function initMap() {
            var mapOptions = {
                zoom: 14,
                center: { lat: 24.4644789, lng: 54.3651206 },
                mapTypeId: 'roadmap'
            };
            var startlat = 0;
            var startlon = 0;


            var map = new google.maps.Map(document.getElementById('map'), mapOptions);
            var directionsService = new google.maps.DirectionsService;
            //var directionsRenderer = new google.maps.DirectionsRenderer;
            var directionsRe");
                WriteLiteral(@"nderer = new google.maps.DirectionsRenderer({
                suppressMarkers: true
            });
            infoWindow = new google.maps.InfoWindow;
            directionsRenderer.setMap(map);


            var waypts = [];

            $.ajax({
                url: ""/Delivery/GetLoctions"",
                type: 'GET',
                sync: false,
                success: function (response) {
                    if (navigator.geolocation) {
                        navigator.geolocation.getCurrentPosition(function (position) {
                            var goldStar = {
                                //path: 'M 125,5 155,90 245,90 175,145 200,230 125,180 50,230 75,145 5,90 95,90 z',
                                fillColor: 'yellow',
                                fillOpacity: 0.8,
                                scale: 1,
                                strokeColor: 'gold',
                                strokeWeight: 14
                            };
                        ");
                WriteLiteral(@"    var pos = {
                                lat: position.coords.latitude,
                                lng: position.coords.longitude
                            };
                            startlat = position.coords.latitude;
                            startlon = position.coords.longitude;
                            map.setCenter(pos);

                            debugger;
                            for (i = 0; i < response.length; i++) {
                                response[i][""distance""] = calculateDistance(startlat, startlon, response[i][""lat""], response[i][""lon""], ""K"");
                            }

                            response.sort(function (a, b) {
                                return a.distance - b.distance;
                            });
                            var pos = {
                                lat: startlat,
                                lng: startlon
                            };
                            waypts.push({
         ");
                WriteLiteral(@"                       location: pos,
                                stopover: true
                            });
                            var marker = new google.maps.Marker({
                                position: pos,
                                map: map,
                                title: ""Start"",
                                icon: image,
                                label: {
                                    text: ""Start"",
                                    color: '#222222',
                                    fontSize: '12px'
                                }
                            });
                            var mapdir = startlat + ','+startlon;
                            var s = 1;
                            for (var i = 0; i < response.length; i++) {
                                debugger;
                                var image = 'data:image/svg+xml,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20width%3D%2238%22%20height%3D%22");
                WriteLiteral(@"38%22%20viewBox%3D%220%200%2038%2038%22%3E%3Cpath%20fill%3D%22%23808080%22%20stroke%3D%22%23ccc%22%20stroke-width%3D%22.5%22%20d%3D%22M34.305%2016.234c0%208.83-15.148%2019.158-15.148%2019.158S3.507%2025.065%203.507%2016.1c0-8.505%206.894-14.304%2015.4-14.304%208.504%200%2015.398%205.933%2015.398%2014.438z%22%2F%3E%3Ctext%20transform%3D%22translate%2819%2018.5%29%22%20fill%3D%22%23fff%22%20style%3D%22font-family%3A%20Arial%2C%20sans-serif%3Bfont-weight%3Abold%3Btext-align%3Acenter%3B%22%20font-size%3D%2212%22%20text-anchor%3D%22middle%22%3E' + s + '%3C%2Ftext%3E%3C%2Fsvg%3E';
                                var goldenGatePosition = { lat: parseFloat(response[i].lat), lng: parseFloat(response[i].lon) };
                                var marker = new google.maps.Marker({
                                    position: goldenGatePosition,
                                    map: map,
                                    title: response[i].add,
                                    icon: image,
               ");
                WriteLiteral(@"                     label: {
                                        text: response[i].add,
                                        color: ""black"",
                                        fontSize: ""18px"",
                                        fontWeight: ""bold""
                                    }
                                });
                                waypts.push({
                                    location: goldenGatePosition,
                                    stopover: true
                                });
                                s = s + 1;
                                mapdir += '/' + parseFloat(response[i].lat) + ',' + parseFloat(response[i].lon);
                            }
                            document.getElementById('Mapsubmit').addEventListener('click', function () {
                                window.open(
                                    'https://www.google.co.in/maps/dir/' + mapdir,
                                    '_blank' // <");
                WriteLiteral(@"- This is what makes it open in a new window.
                                );
                                //window.location.href = ;
                            });
                            directionsService.route({
                                origin: waypts[0].location,
                                destination: waypts[waypts.length - 1].location,
                                waypoints: waypts,
                                optimizeWaypoints: true,
                                travelMode: 'DRIVING'
                            }, function (response, status) {
                                if (status === 'OK') {
                                    directionsRenderer.setDirections(response);
                                    var route = response.routes[0];
                                    var summaryPanel = document.getElementById('directions-panel');
                                    summaryPanel.innerHTML = '';
                                    // For each ro");
                WriteLiteral(@"ute, display summary information.
                                    for (var i = 0; i < route.legs.length; i++) {
                                        var routeSegment = i + 1;
                                        summaryPanel.innerHTML += '<b>Route Segment: ' + routeSegment +
                                            '</b><br>';
                                        summaryPanel.innerHTML += route.legs[i].start_address + ' to ';
                                        summaryPanel.innerHTML += route.legs[i].end_address + '<br>';
                                        summaryPanel.innerHTML += route.legs[i].distance.text + '<br><br>';
                                    }
                                } else {
                                    window.alert('Directions request failed due to ' + status);
                                }
                            });
                        }, function () {
                            handleLocationError(true, infoWindow, map.ge");
                WriteLiteral(@"tCenter());
                            });

                    } else {
                        // Browser doesn't support Geolocation
                        handleLocationError(false, infoWindow, map.getCenter());
                    }


                },
                error: function (xhr) {
                    alert(""Something went wrong, please try again"");
                }
            });

        }





        function handleLocationError(browserHasGeolocation, infoWindow, pos) {
            infoWindow.setPosition(pos);
            infoWindow.setContent(browserHasGeolocation ?
                'Error: The Geolocation service failed.' :
                'Error: Your browser doesn\'t support geolocation.');
            infoWindow.open(map);
        }





        //function geocodeAddress(geocoder, resultsMap) {
        //    var address = document.getElementById('address').value;
        //    geocoder.geocode({ 'address': address }, function (results, status) {
");
                WriteLiteral(@"        //        if (status === 'OK') {
        //            debugger;
        //            resultsMap.setCenter(results[0].geometry.location);
        //            var marker = new google.maps.Marker({
        //                map: resultsMap,
        //                position: results[0].geometry.location,
        //                zoom: 14
        //            });
        //        } else {
        //            alert('Geocode was not successful for the following reason: ' + status);
        //        }
        //    });
        //}



        function calculateDistance(lat1, lon1, lat2, lon2, unit) {
            var radlat1 = Math.PI * lat1 / 180
            var radlat2 = Math.PI * lat2 / 180
            var radlon1 = Math.PI * lon1 / 180
            var radlon2 = Math.PI * lon2 / 180
            var theta = lon1 - lon2
            var radtheta = Math.PI * theta / 180
            var dist = Math.sin(radlat1) * Math.sin(radlat2) + Math.cos(radlat1) * Math.cos(radlat2) * Math.c");
                WriteLiteral(@"os(radtheta);
            dist = Math.acos(dist)
            dist = dist * 180 / Math.PI
            dist = dist * 60 * 1.1515
            if (unit == ""K"") { dist = dist * 1.609344 }
            if (unit == ""N"") { dist = dist * 0.8684 }
            return dist
        }

    </script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBZ_WzHFJGtNughETwVqmHBvnl-wKZmFnk&callback=initMap"" async defer></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12806, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SC.Data.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
