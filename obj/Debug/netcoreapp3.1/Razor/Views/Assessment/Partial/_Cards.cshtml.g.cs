#pragma checksum "E:\Bitbucket\Research\obetools\Views\Assessment\Partial\_Cards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7766dbdcbb61bd355474bc31263e0426f3caac47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assessment_Partial__Cards), @"mvc.1.0.view", @"/Views/Assessment/Partial/_Cards.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7766dbdcbb61bd355474bc31263e0426f3caac47", @"/Views/Assessment/Partial/_Cards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de566846af86ce063b9bf726c0b790922d0238c", @"/Views/_ViewImports.cshtml")]
    public class Views_Assessment_Partial__Cards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assessment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Bitbucket\Research\obetools\Views\Assessment\Partial\_Cards.cshtml"
  
    int Course = new CourseService().FindAll(User.Identity.Name).Count;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-xl-4 col-md-6"">
            <div class=""card custom-card-d mb-4"">
                <div class=""card-body d-flex align-items-center justify-content-between"">
                    <H3 class=""font-weight-light""> <i class=""fas fa-book-reader""></i>&nbsp; COURSE</H3>
                    <H1 class=""font-weight-normal"">
                        ");
#nullable restore
#line 11 "E:\Bitbucket\Research\obetools\Views\Assessment\Partial\_Cards.cshtml"
                   Write(Course);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </H1>
                </div>
            </div>
        </div>

        <div class=""col-xl-4 col-md-6"">
            <div class=""card card custom-card-d mb-4"">
                <div class=""card-body d-flex align-items-center justify-content-between"">
                    <H3 class=""font-weight-light""> <i class=""fas fa-tasks""></i>&nbsp; ASSESMENT</H3>
                    <H1 class=""font-weight-normal"">
                        ");
#nullable restore
#line 22 "E:\Bitbucket\Research\obetools\Views\Assessment\Partial\_Cards.cshtml"
                   Write(Model.ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </H1>
                </div>
            </div>
        </div>

        <div class=""col-xl-4 col-md-6"">
            <div class=""card card custom-card-d mb-4"">
                <div class=""card-body d-flex align-items-center justify-content-between"">
                    <H3 class=""font-weight-light""><i class=""fab fa-bity""></i>&nbsp; TYPE</H3>
                    <H1 class=""font-weight-normal"">
                        6
                    </H1>
                </div>
            </div>
        </div>
    </div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assessment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
