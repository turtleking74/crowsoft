#pragma checksum "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd80984f8dbac599487707795fbea65991dfc0e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrowsoftUser_Details), @"mvc.1.0.view", @"/Views/CrowsoftUser/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CrowsoftUser/Details.cshtml", typeof(AspNetCore.Views_CrowsoftUser_Details))]
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
#line 1 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\_ViewImports.cshtml"
using crowsoftmvc;

#line default
#line hidden
#line 2 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\_ViewImports.cshtml"
using crowsoftmvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd80984f8dbac599487707795fbea65991dfc0e7", @"/Views/CrowsoftUser/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a68abc9cc2c96b65f92498b0cbbd1865b22b1d", @"/Views/_ViewImports.cshtml")]
    public class Views_CrowsoftUser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crowsoftmvc.Areas.Identity.Data.CrowsoftUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(98, 135, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>CrowsoftUser</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(234, 44, false);
#line 14 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(278, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(342, 40, false);
#line 17 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(382, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(445, 41, false);
#line 20 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(486, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(550, 37, false);
#line 23 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(587, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(650, 47, false);
#line 26 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(697, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(761, 43, false);
#line 29 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(804, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(867, 46, false);
#line 32 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(913, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(977, 42, false);
#line 35 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1082, 50, false);
#line 38 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1196, 46, false);
#line 41 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1305, 53, false);
#line 44 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1422, 49, false);
#line 47 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1518, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd80984f8dbac599487707795fbea65991dfc0e79305", async() => {
                BeginContext(1564, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "f:\CrowSoft\CrowSoft\Projects\crowsoftmvc\Views\CrowsoftUser\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1572, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1580, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd80984f8dbac599487707795fbea65991dfc0e711622", async() => {
                BeginContext(1602, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1618, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crowsoftmvc.Areas.Identity.Data.CrowsoftUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
