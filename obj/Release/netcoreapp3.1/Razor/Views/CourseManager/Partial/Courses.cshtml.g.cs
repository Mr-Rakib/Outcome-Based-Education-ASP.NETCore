#pragma checksum "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "070dfdc38b9d9272e293a8c4c4deb61e17a791cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseManager_Partial_Courses), @"mvc.1.0.view", @"/Views/CourseManager/Partial/Courses.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.Models.View_Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.BLL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "R:\University Period\Research\Bitbucket\obetools\Views\_ViewImports.cshtml"
using MoreLinq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"070dfdc38b9d9272e293a8c4c4deb61e17a791cd", @"/Views/CourseManager/Partial/Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de566846af86ce063b9bf726c0b790922d0238c", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseManager_Partial_Courses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
  
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<hr class=""c-hr-gray"" />
<div class="" row pb-2 pt-1"">
    <div class=""text-left col-md-6"">
        <h5 class=""font-weight-light""><i class=""fas fa-list p-1""></i>Courses</h5>
    </div>
</div>

<div class=""card mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered display MultipleDataTable"" id=""dataTable_User"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr class=""custom-table-user text-center"">
                        <th class=""text-left"">Sl No.</th>
                        <th colspan=""1"">");
#nullable restore
#line 20 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 21 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 22 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 23 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Descriptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>Action</th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 29 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 32 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                        Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descriptions));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td class=""text-center"" style=""font-size: .75em"">
                            <a class=""p-1""><i class=""far fa-edit text-info""></i></a>
                            <a class=""p-1""><i class=""far fa-eye text-secondery""></i></a>
                            <!--
                                 <a class=""p-1"" onclick=""return confirm('Are you sure you want to delete?')"" asp-action=""DeleteMission"" asp-controller=""Academy"" asp-route-id=""");
#nullable restore
#line 41 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                                                                                                                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"far fa-trash-alt text-danger\"></i></a>\r\n                            -->\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "R:\University Period\Research\Bitbucket\obetools\Views\CourseManager\Partial\Courses.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591