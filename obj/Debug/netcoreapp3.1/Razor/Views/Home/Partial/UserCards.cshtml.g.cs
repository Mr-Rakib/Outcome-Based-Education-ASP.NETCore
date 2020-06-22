#pragma checksum "E:\Bitbucket\obetools\Views\Home\Partial\UserCards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1960af150028e33feb3c532b727b73ff7655336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partial_UserCards), @"mvc.1.0.view", @"/Views/Home/Partial/UserCards.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.Models.View_Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.BLL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using OBETools.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Bitbucket\obetools\Views\_ViewImports.cshtml"
using MoreLinq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1960af150028e33feb3c532b727b73ff7655336", @"/Views/Home/Partial/UserCards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de566846af86ce063b9bf726c0b790922d0238c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partial_UserCards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Bitbucket\obetools\Views\Home\Partial\UserCards.cshtml"
  
    StaffService StaffService = new StaffService();
    StudentService StudentService = new StudentService();
    CourseRegistrationService courseRegistrationService = new CourseRegistrationService();

    var Users = StaffService.FindAll(User.Identity.Name);
    int Staffs = Users.Count;
    int Students = StudentService.FindAll(User.Identity.Name).Count;
    int Admins = Users.FindAll(st => st.Login.Role.ToLower() == Roles.Admin.ToString().ToLower()).Count;
    int RegisterStudent = courseRegistrationService.FindAll(User.Identity.Name).DistinctBy(reg => reg.StudentId).ToList().Count;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-3  col-md-6"">
        <div class=""card custom-card-d mb-4 "">
            <div class=""card-body d-flex align-items-center justify-content-between"">
                <H3 class=""font-weight-light""> <i class=""fas fa-user-shield""></i>&nbsp; ADMIN</H3>
                <H1 class=""font-weight-normal"">
                    ");
#nullable restore
#line 20 "E:\Bitbucket\obetools\Views\Home\Partial\UserCards.cshtml"
               Write(Admins);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </H1>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card custom-card-d mb-4"">
            <div class=""card-body d-flex align-items-center justify-content-between"">
                <H3 class=""font-weight-light""><i class=""fas fa-chalkboard-teacher""></i>&nbsp; STAFF</H3>
                <H1 class=""font-weight-normal"">
                    ");
#nullable restore
#line 30 "E:\Bitbucket\obetools\Views\Home\Partial\UserCards.cshtml"
               Write(Staffs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </H1>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card custom-card-d mb-4"">
            <div class=""card-body d-flex align-items-center justify-content-between"">
                <H3 class=""font-weight-light""><i class=""fas fa-user-graduate""></i>&nbsp; STUDENT</H3>
                <H1 class=""font-weight-normal"">
                    ");
#nullable restore
#line 40 "E:\Bitbucket\obetools\Views\Home\Partial\UserCards.cshtml"
               Write(Students);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </H1>
            </div>
        </div>
    </div>

    <div class=""col-xl-3 col-md-6"">
        <div class=""card custom-card-d mb-4"">
            <div class=""card-body d-flex align-items-center justify-content-between"">
                <H3 class=""font-weight-light""><i class=""fas fa-user-friends""></i>&nbsp; REGISTER STUDENT</H3>
                <H1 class=""font-weight-normal"">
                    ");
#nullable restore
#line 51 "E:\Bitbucket\obetools\Views\Home\Partial\UserCards.cshtml"
               Write(RegisterStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </H1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
