#pragma checksum "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35f500736e8a171d5250d30c0c72c3b8728060fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_V_Number_Tem__MainList), @"mvc.1.0.view", @"/Views/V_Number_Tem/_MainList.cshtml")]
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
#line 1 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using MainWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using MainWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using HRIS.Sample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using HRIS.Account.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35f500736e8a171d5250d30c0c72c3b8728060fa", @"/Views/V_Number_Tem/_MainList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3a97f428720c03fb0cf14a92136d5bae694cb9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_V_Number_Tem__MainList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HRIS.Sample.Models.V_Number_Temp>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive\">\r\n    <table class=\"table table-centered table-nowrap table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th class=\"d-none\">");
#nullable restore
#line 11 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                              Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 12 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.First().V_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Booking</th>\r\n                <th>");
#nullable restore
#line 14 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Slot));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 15 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.First().In_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Out_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n               \r\n                <th>");
#nullable restore
#line 18 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th style=\"width:70px;\">Action</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"tblBody\">\r\n");
#nullable restore
#line 23 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 950, "\"", 967, 2);
            WriteAttributeValue("", 955, "row_", 955, 4, true);
#nullable restore
#line 25 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
WriteAttributeValue("", 959, item.Id, 959, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td class=\"d-none\">");
#nullable restore
#line 26 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.V_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(item.In_Time.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n\r\n");
#nullable restore
#line 31 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                         if (item.Status != "SNA"&& item.Status != "C")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""btn-group"">
                                <button data-toggle=""modal"" data-target=""#exampleModal""   class=""btn btn-sm  btn-secondary btn-icon-text btn-edit-profile"" type=""button"" id=""dropdownMenuButton2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i data-feather=""edit"" class=""btn-icon-prepend""></i> Allocate Slot 
                                </button>
                               
                            </div>
");
#nullable restore
#line 39 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                             if (item.Status != "C")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong class=\"text-center\">ST002</strong>\r\n");
#nullable restore
#line 45 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong class=\"text-center\"> - </strong>\r\n");
#nullable restore
#line 50 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"


                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                <td>");
#nullable restore
#line 56 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.In_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Out_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n \r\n                    <td><span");
            BeginWriteAttribute("class", " class=\"", 2526, "\"", 2569, 3);
            WriteAttributeValue("", 2534, "badge", 2534, 5, true);
            WriteAttributeValue(" ", 2539, "badge-", 2540, 7, true);
#nullable restore
#line 59 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
WriteAttributeValue("", 2546, item.ActiveStatusClass, 2546, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
                                                                     Write(item.ActiveStatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2655, "\"", 2703, 1);
#nullable restore
#line 61 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
WriteAttributeValue("", 2662, Url.Action("Edit", new { id = item.Id }), 2662, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"table-icon text-primary\"><i class=\"mdi mdi-square-edit-outline\"></i></a>\r\n                        <a href=\"javascript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2839, "\"", 2898, 5);
            WriteAttributeValue("", 2849, "ConfirmDelete(\'", 2849, 15, true);
#nullable restore
#line 62 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
WriteAttributeValue("", 2864, item.Id, 2864, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2872, "\',\'", 2872, 3, true);
#nullable restore
#line 62 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
WriteAttributeValue("", 2875, Url.Action("Delete"), 2875, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2896, "\')", 2896, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"table-icon text-danger\"> <i class=\"mdi mdi-delete\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\V_Number_Tem\_MainList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HRIS.Sample.Models.V_Number_Temp>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
