#pragma checksum "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0f46c9fc6adb465947615faa631d04ad4b0195b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Academy_Partial_Missions), @"mvc.1.0.view", @"/Views/Academy/Partial/Missions.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\_ViewImports.cshtml"
using OBETools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\_ViewImports.cshtml"
using OBETools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0f46c9fc6adb465947615faa631d04ad4b0195b", @"/Views/Academy/Partial/Missions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0ebc7ea8b16518cbd83662429109cf5217ca59", @"/Views/_ViewImports.cshtml")]
    public class Views_Academy_Partial_Missions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mission>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card mb-4"">
    <div class=""card-header""><i class=""fas fa-table mr-1""></i>Users</div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>");
#nullable restore
#line 10 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 11 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 12 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>Action</th>\r\n                    </tr>\r\n                </thead>\r\n                <tfoot>\r\n                    <tr>\r\n                        <th>");
#nullable restore
#line 18 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 19 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 20 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>Action</th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
#nullable restore
#line 25 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 28 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                ");
#nullable restore
#line 32 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                           Write(Html.ActionLink("", "Edit", new { id = item.Id }, new { @class = "fas fa-edit text-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                                ");
#nullable restore
#line 33 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                           Write(Html.ActionLink("", "Details", new { id = item.Id }, new { @class = "fas fa-eye text-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  &nbsp;\r\n                                ");
#nullable restore
#line 34 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                           Write(Html.ActionLink("", "Delete", new { id = item.Id }, new { onClick = "return confirm('Are you sure to delete ?')", @class = "fas fa-trash-alt text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 37 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Partial\Missions.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mission>> Html { get; private set; }
    }
}
#pragma warning restore 1591