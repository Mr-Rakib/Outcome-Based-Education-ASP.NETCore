#pragma checksum "E:\Bitbucket\obetools\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3385a1e221bffccfdb0e57bf3a770bd8e27fa5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3385a1e221bffccfdb0e57bf3a770bd8e27fa5ce", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de566846af86ce063b9bf726c0b790922d0238c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <div class=\"pt-2\">\r\n        ");
#nullable restore
#line 4 "E:\Bitbucket\obetools\Views\User\Index.cshtml"
   Write(Html.Partial("Notifications/_Notification"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n   \r\n    <hr class=\"c-hr-gray\" />\r\n\r\n    <div class=\"pt-2\">\r\n        ");
#nullable restore
#line 10 "E:\Bitbucket\obetools\Views\User\Index.cshtml"
   Write(Html.Partial("Partial/_Cards"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

    <ul class=""nav nav-tabs mb-1"" id=""myTab"" role=""tablist"">


        <li class=""nav-item"">
            <a class=""nav-link active"" id=""users-tab"" data-toggle=""tab"" href=""#user"" role=""tab"" aria-controls=""user"" aria-selected=""true"">Students</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""vets-tab"" data-toggle=""tab"" href=""#vet"" role=""tab"" aria-controls=""vet"" aria-selected=""false"">Staffs</a>
        </li>
    </ul>

    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""user"" role=""tabpanel"" aria-labelledby=""user-tab"">
            ");
#nullable restore
#line 26 "E:\Bitbucket\obetools\Views\User\Index.cshtml"
       Write(Html.Partial("Partial/Students", Model.Students));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"tab-pane fade\" id=\"vet\" role=\"tabpanel\" aria-labelledby=\"vet-tab\">\r\n            ");
#nullable restore
#line 29 "E:\Bitbucket\obetools\Views\User\Index.cshtml"
       Write(Html.Partial("Partial/Staffs", Model.Staffs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
