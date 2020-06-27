#pragma checksum "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99cbcdaf8fbbc745852911c9bce5c211b314f602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicEvaluation_Partial_Details), @"mvc.1.0.view", @"/Views/AcademicEvaluation/Partial/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.Models.View_Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.BLL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using OBETools.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Bitbucket\Research\obetools\Views\_ViewImports.cshtml"
using MoreLinq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99cbcdaf8fbbc745852911c9bce5c211b314f602", @"/Views/AcademicEvaluation/Partial/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de566846af86ce063b9bf726c0b790922d0238c", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicEvaluation_Partial_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AcademicEvaluationLists>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
  
    int count = 1;
    float total = 0;
    Model.Assessments.ForEach(ex => total += ex.Marks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""pt-2"">
        <div>
            <h4 class=""font-weight-normal text-center"">EVALUATION DETAILS</h4>
        </div>
        <hr class=""c-hr-gray"" />
        <div class="" container"">
            <div class="" row pb-2 pt-1 "">
                <div class="" form-group text-left col-md-6"">
                    <h5 class=""font-weight-light""><i class=""fab fa-artstation""></i>&nbsp;");
#nullable restore
#line 16 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                                                                    Write(Model.Course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                </div>\r\n                <div class=\" form-group text-right col-md-6\">\r\n                    <h5 class=\"font-weight-light\"><i class=\"fas fa-hourglass-half\"></i>&nbsp;SEMESTER: ");
#nullable restore
#line 19 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                                                                                  Write(Model.SemesterId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                </div>
            </div>

            <div class=""card mb-4 container-fluid"">
                <div class=""card-body"">
                     <div class=""pb-2"">
                         <h6 class=""font-weight-normal text-center border-bottom pb-2"">ASSESSMENTS</h6>
                     </div>
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr class=""custom-table-user-1 text-center"">
                                    <th class=""text-left"">Sl No.</th>
                                    <th>Assessment Name</th>
                                    <th>Marks</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 39 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                 foreach (var item in Model.Assessments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 42 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                    Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
#nullable restore
#line 44 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assessment.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
#nullable restore
#line 47 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Marks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 50 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"text-center\">\r\n                                <td><strong>-</strong></td>\r\n                                <td><strong>TOTAL</strong></td>\r\n                                <td class=\"text-center\"><strong>");
#nullable restore
#line 54 "E:\Bitbucket\Research\obetools\Views\AcademicEvaluation\Partial\Details.cshtml"
                                                           Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                            </tr>\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcademicEvaluationLists> Html { get; private set; }
    }
}
#pragma warning restore 1591