#pragma checksum "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0a116abda9721d637743d62cb58a05fcae2a6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SampleCategory_Index), @"mvc.1.0.view", @"/Views/SampleCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0a116abda9721d637743d62cb58a05fcae2a6e", @"/Views/SampleCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3a97f428720c03fb0cf14a92136d5bae694cb9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SampleCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SampleCategorySearchView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ConfirmDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/pagination.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
  
    ViewData["Title"] = "Sample Categories";

    ViewData["SampleCategoryActive"] = "active";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc0a116abda9721d637743d62cb58a05fcae2a6e5106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- start page title -->
 
<!-- end page title -->

<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body p-2 p-md-3"">

                <div class=""text-center float-md-right"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 467, "\"", 492, 1);
#nullable restore
#line 21 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
WriteAttributeValue("", 474, Url.Action("Add"), 474, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary btn-icon-text"">
                        <i class=""mdi mdi-plus-circle-outline""></i>
                        Add Category
                    </a>
                </div>

                <div class=""row justify-content-md-start justify-content-center"">

                    <div class=""p-1 pl-0"">
                        ");
#nullable restore
#line 30 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
                   Write(Html.EditorFor(model => model.KeyW, new { htmlAttributes = new { @class = "form-control", placeholder = "Search", id = "txtKeyW", autofocus = "autofocus", onkeyup = "SearchStart()" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.KeyW, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                </div>

                <div id=""divLoad"" class=""d-flex justify-content-center mt-2 position-absolute w-100"">
                    <div id=""spnLoad"" class=""spinner-border "" role=""status""></div>
                </div>

                <div id=""divRecords"" class=""m-0 p-0 mt-2""></div>

                <input type=""hidden"" id=""txtRecordCount""");
            BeginWriteAttribute("value", " value=\"", 1544, "\"", 1570, 1);
#nullable restore
#line 42 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
WriteAttributeValue("", 1552, Model.RecordCount, 1552, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" id=\"txtPageSize\"");
            BeginWriteAttribute("value", " value=\"", 1629, "\"", 1652, 1);
#nullable restore
#line 43 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
WriteAttributeValue("", 1637, Model.PageSize, 1637, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 50 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
Write(await Html.PartialAsync("_Pagination", Model.PaginationList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    //");
#nullable restore
#line 53 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
         await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0a116abda9721d637743d62cb58a05fcae2a6e10449", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 56 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script title=""Main"">

        var Page = 1;
        var PageURL = '/SampleCategory/_MainList';

        $(document).ready(function () {

            LoadPage(1);
        });

        function GetData(pageNo) {
            var KeyW = $(""#txtKeyW"").val();
            Page = pageNo;
            var PageSize = $(""#txtPageSize"").val();

            var data = {
                KeyW: KeyW,
                Page: Page,
                PageSize: PageSize
            };

            return data;
        }


    </script>


    <script title=""Search"">

        function SearchStart() {
            // Declare variables
            var input, filter, table, tr, td, i, txtValue;
            input = document.getElementById(""txtKeyW"");
            filter = input.value.toUpperCase();
            table = document.getElementById(""tblBody"");
            tr = table.getElementsByTagName(""tr"");

            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagNa");
                WriteLiteral(@"me(""td"")[0];
                td1 = tr[i].getElementsByTagName(""td"")[1];

                if (td) {
                    txtValue = td.textContent || td.innerText;
                    txtValue = txtValue + ' ' + td1.textContent || td1.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = """";
                    } else {
                        tr[i].style.display = ""none"";
                    }
                }
            }
        }

        $(""#txtKeyW"").on(""keydown"",function search(e) {
            if(e.keyCode == 13) {
                Search();
            }
        });

        function Search() {

            var KeyW = $(""#txtKeyW"").val();

            var url = '");
#nullable restore
#line 122 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Final Project\Final Project\PROJECT\MainWeb\Views\SampleCategory\Index.cshtml"
                  Write(Url.Action("Index", "SampleCategory"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            var ParamPart = ""&"";
            ParamPart = ParamPart + ((KeyW != """") ? '&KeyW=' + KeyW : '');

            ParamPart = ParamPart.replace(""&&"", """");

            window.location.href = url + '?' + ParamPart;
            event.preventDefault();
        };

    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleCategorySearchView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
