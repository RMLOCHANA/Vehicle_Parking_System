#pragma checksum "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43715a37b0da59cd1e570508b692bba702c13e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CustomerBooking_Views_Home_Index), @"mvc.1.0.view", @"/Areas/CustomerBooking/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\_ViewImports.cshtml"
using MainWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\_ViewImports.cshtml"
using MainWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\_ViewImports.cshtml"
using HRIS.Sample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\_ViewImports.cshtml"
using HRIS.Account.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43715a37b0da59cd1e570508b692bba702c13e03", @"/Areas/CustomerBooking/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3a97f428720c03fb0cf14a92136d5bae694cb9", @"/Areas/CustomerBooking/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_CustomerBooking_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<V_Number_Temp>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Booking";

    ViewData["DashboardActive"] = "active";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- start page title -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"page-title-box\">\r\n            <h4 class=\"page-title\">");
#nullable restore
#line 14 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- end page title -->\r\n");
#nullable restore
#line 19 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 31 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(model => model.ReturnURL, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 33 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.ReturnURL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ReturnURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row d-none\">\r\n                        ");
#nullable restore
#line 39 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(model => model.Id, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 41 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Id, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group row\">\r\n                        ");
#nullable restore
#line 47 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(model => model.V_Number, htmlAttributes: new { @class = "col-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-8\">\r\n                            ");
#nullable restore
#line 49 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.V_Number, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.V_Number, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>


                    <div class=""form-group row"">
                        <label class = ""col-4 col-form-label"">Booking time</label>
                        <div class=""col-8"">
                            ");
#nullable restore
#line 58 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(model => model.In_Time,   new { htmlAttributes = new { id = "xbasic-datepicker", @class = "form-control flatpickr-input active" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 59 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.In_Time, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

 

 

                    <div class=""form-group row"">
                        <div class=""col-4"">
                        </div>
                        <div class=""col-8"">
                            <button type=""submit"" class=""btn btn-primary mr-2"">Book Now</button>
                            &nbsp;
                            
                        </div>
                    </div>


                </div>
            </div>
        </div>

        <div class=""col-md-8 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">

                    <h4> Booking Details</h4>

                    <div id=""divRecords"" class=""m-0 p-0 mt-2"">
                        <div class=""table-responsive"">
                            <table class=""table table-centered table-nowrap table-striped"">
                                <thead>
                                    <tr>
           ");
            WriteLiteral("                             <th class=\"d-none\">");
#nullable restore
#line 93 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 94 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.V_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 95 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.In_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 96 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Out_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 97 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                       
                                    </tr>
                                </thead>
                                <tbody id=""tblBody"">
                                    
                                        <tr id="" "">
                                            <td class=""d-none"">");
            WriteLiteral(@"</td>
                                            <td>NP 2345</td>
                                            <td>30 March 2023 1.45 pm</td>
                                            <td>-</td>
                                            <td><span class=""badge badge-info"">Pending</span></td>
                                            
                                        </tr>

                                        <tr id="" "">
                                            <td class=""d-none"">");
            WriteLiteral(@"</td>
                                            <td>NP 2345</td>
                                            <td>02 March 2023 1.45 pm</td>
                                            <td> - </td>
                                            <td><span class=""badge badge-warning"">Slot Not Available</span></td>

                                        </tr>

                                        <tr id="" "">
                                            <td class=""d-none"">");
            WriteLiteral(@"</td>
                                            <td>NP 4345</td>
                                            <td>10 March 2023 6.45 pm</td>
                                        <td>10 March 2023 9.45 pm</td>
                                            <td><span class=""badge badge-success"">Completed</span></td>

                                        </tr>
                                    <tr id="" "">
                                        <td class=""d-none"">");
            WriteLiteral(@"</td>
                                        <td>NP 2345</td>
                                        <td>3 March 2023 3.45 pm</td>
                                        <td>03 March 2023 6.45 pm</td>
                                        <td><span class=""badge badge-success"">Completed</span></td>

                                    </tr>
                                    <tr id="" "">
                                        <td class=""d-none"">");
            WriteLiteral(@"</td>
                                        <td>NP 2345</td>
                                        <td>5 March 2023 12.45 am</td>
                                        <td>05 March 2023 2.45 pm</td>
                                        <td><span class=""badge badge-success"">Completed</span></td>

                                    </tr>

                                </tbody>
                            </table>
                        </div>



                    </div>



           


                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 163 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 166 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Areas\CustomerBooking\Views\Home\Index.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43715a37b0da59cd1e570508b692bba702c13e0318879", async() => {
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
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DropDown.ISampleDDL SampleDDL { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<V_Number_Temp> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
