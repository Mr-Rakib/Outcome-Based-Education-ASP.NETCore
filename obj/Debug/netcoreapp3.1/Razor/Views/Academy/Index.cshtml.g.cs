#pragma checksum "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d94d5bb7d0a8783760e363193a016d0d60758e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Academy_Index), @"mvc.1.0.view", @"/Views/Academy/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d94d5bb7d0a8783760e363193a016d0d60758e", @"/Views/Academy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0ebc7ea8b16518cbd83662429109cf5217ca59", @"/Views/_ViewImports.cshtml")]
    public class Views_Academy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OBETools.Models.Mission>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h1 class=\"mt-4 font-weight-normal\"><i class=\"fas fa-university p-1\"></i>&nbsp; Academy Management</h1>\r\n    <hr />\r\n\r\n    \r\n</div>\r\n\r\n\r\n<div>\r\n    ");
#nullable restore
#line 11 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Index.cshtml"
Write(Html.Partial("Notifications/_Notification"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <h1 class=\"font-weight-normal col-md-6\"><i class=\"fas fa-users\"></i>&nbsp;Users</h1>\r\n        <div class=\"text-right col-md-6 pt-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62d94d5bb7d0a8783760e363193a016d0d60758e5262", async() => {
                WriteLiteral("<i class=\"fas fa-user-plus\"></i>&nbsp;Create User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <hr class=""c-hr-green"" />

    <ul class=""nav nav-tabs mb-1"" id=""myTab"" role=""tablist"">


        <li class=""nav-item"">
            <a class=""nav-link active"" id=""users-tab"" data-toggle=""tab"" href=""#user"" role=""tab"" aria-controls=""user"" aria-selected=""true"">Users</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""vets-tab"" data-toggle=""tab"" href=""#vet"" role=""tab"" aria-controls=""vet"" aria-selected=""false"">Employee</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link "" id=""admin-tab"" data-toggle=""tab"" href=""#admin"" role=""tab"" aria-controls=""admin"" aria-selected=""false"">Admin</a>
        </li>
    </ul>
    <div class=""tab-content"" id=""myTabContent"">

        <div class=""tab-pane fade show active"" id=""user"" role=""tabpanel"" aria-labelledby=""user-tab"">
            ");
#nullable restore
#line 36 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Index.cshtml"
       Write(Html.Partial("Partial/Missions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"tab-pane fade\" id=\"vet\" role=\"tabpanel\" aria-labelledby=\"vet-tab\">\r\n            ");
#nullable restore
#line 39 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Index.cshtml"
       Write(Html.Partial("Partial/Missions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"tab-pane fade \" id=\"admin\" role=\"tabpanel\" aria-labelledby=\"admin-tab\">\r\n            ");
#nullable restore
#line 43 "E:\RAKIB\Documents\Personal\Research\Software\obetools\OBETools\Views\Academy\Index.cshtml"
       Write(Html.Partial("Partial/Missions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>


<!--Profile Modal-->
<div class=""modal fade"" id=""view-profile-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modal-default"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered modal-"" role=""document"" id=""viewprofilemodal"">

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OBETools.Models.Mission>> Html { get; private set; }
    }
}
#pragma warning restore 1591
