#pragma checksum "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Project Presentation\Final Folder\Final Project\Final Project New\PROJECT\MainWeb\Views\Shared\_ConfirmDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29935b6452efcdea25dfdf5de325a4df25dec010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ConfirmDelete), @"mvc.1.0.view", @"/Views/Shared/_ConfirmDelete.cshtml")]
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
#line 1 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Project Presentation\Final Folder\Final Project\Final Project New\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using MainWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Project Presentation\Final Folder\Final Project\Final Project New\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using MainWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Project Presentation\Final Folder\Final Project\Final Project New\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using HRIS.Sample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\ICBT Campus\Lecture Videos, Notes & Assignment\Final Project\My Project\Project Presentation\Final Folder\Final Project\Final Project New\PROJECT\MainWeb\Views\_ViewImports.cshtml"
using HRIS.Account.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29935b6452efcdea25dfdf5de325a4df25dec010", @"/Views/Shared/_ConfirmDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3a97f428720c03fb0cf14a92136d5bae694cb9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ConfirmDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""ConfirmDelete"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""bottomModalLabel"">Confirm Delete</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete this record?</p>

                <div id=""loaderDiv"" class=""progress"">
                    <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%"">

                    </div>
                </div>

                <div style=""text-align:center;display:none"" id=""successDiv"" class=""alert alert-success"">
                    <p id=""message"" name=""message"">Deleted successfully</p>
    ");
            WriteLiteral(@"            </div>

                <div style=""text-align:left;display:none"" id=""errorDiv"" class=""alert alert-danger"">
                    <p id=""errMessage"" name=""errMessage"">Error</p>
                </div>
            </div>
            <div class=""modal-footer"">

                <button type=""button"" class=""btn btn-primary"" disabled=""disabled"" id=""bDelete"" onclick=""DeleteRecord()"">Confirm</button>
                <button type=""button"" class=""btn btn-light"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->


</div>


<input type=""hidden"" id=""hiddenId"" />
<input type=""hidden"" id=""jsonURL"" />

<script>

    var ConfirmDelete = function (Id, jsonURL) {
        $(""#hiddenId"").val(Id);
        $(""#jsonURL"").val(jsonURL);

        $(""#loaderDiv"").hide();
        $(""#errorDiv"").hide();
        $(""#successDiv"").hide();
        $(""#bDelete"").removeAttr(""disabled"");
        $(""#ConfirmDelete"").modal('show')");
            WriteLiteral(@";
    }

    var DeleteRecord = function () {
        $(""#bDelete"").attr(""disabled"", true);
        $(""#loaderDiv"").show();

        var Id = $(""#hiddenId"").val();

        setTimeout(function () {
            $.ajax({

                type: ""POST"",
                url: $(""#jsonURL"").val(),
                data: { id: Id },
                success: function (result) {
                    if (result != null && result.success) {

                        $(""#loaderDiv"").hide();
                        $(""#successDiv"").show();

                        setTimeout(function () {

                            $(""#ConfirmDelete"").modal(""hide"");
                            $(""#row_"" + Id).addClass(""danger"");
                            $(""#row_"" + Id).fadeOut(1000, ""swing"");

                            try {
                                $(""#row_summary"").fadeOut(1000, ""swing"");
                            }
                            catch (err) { }


                            //$");
            WriteLiteral(@"(""#row_"" + Id).remove();
                        }, 1000);

                    } else {
                        ReportError(result.responseText);
                    }

                },
                error: function (result) {
                    ReportError(result.responseText);
                }
            })
        }, 500);


    }

    var ReportError = function (errMessage) {
        $(""#loaderDiv"").hide();
        $(""#successDiv"").hide();
        $(""#bDelete"").attr(""disabled"", true);
        $(""#errMessage"").html(errMessage);
        $(""#errorDiv"").show();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
