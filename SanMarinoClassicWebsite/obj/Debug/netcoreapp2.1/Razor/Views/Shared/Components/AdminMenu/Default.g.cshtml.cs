#pragma checksum "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1050c8ecaebe37a90b4b822363460c94f89251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AdminMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AdminMenu_Default))]
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
#line 1 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\_ViewImports.cshtml"
using SanMarinoClassicWebsite.Models;

#line default
#line hidden
#line 2 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\_ViewImports.cshtml"
using SanMarinoClassicWebsite.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
#line 4 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
using SanMarinoClassicWebsite.Auth;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1050c8ecaebe37a90b4b822363460c94f89251", @"/Views/Shared/Components/AdminMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a769198bd06e0ac67e6a8837f71f2a46c27f1cd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SanMarinoClassicWebsite.Components.AdminMenuItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(309, 27, true);
            WriteLiteral("\r\n<li class=\"active\">\r\n    ");
            EndContext();
            BeginContext(336, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c95b9b72f247159f5b3f06f56fbb0d", async() => {
                BeginContext(422, 47, false);
#line 12 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
                          Write(UserManager.GetUserAsync(User).Result.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(469, 1, true);
                WriteLiteral("!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(474, 12, true);
            WriteLiteral("\r\n    <ul>\r\n");
            EndContext();
#line 14 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
         foreach (var menuItem in Model)
        {

#line default
#line hidden
            BeginContext(539, 58, true);
            WriteLiteral("            <li class=\"animsition-link\">\r\n                ");
            EndContext();
            BeginContext(597, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7582dc146b2492aa326b47f40ddb954", async() => {
                BeginContext(657, 21, false);
#line 17 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
                                                                      Write(menuItem.DisplayValue);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
                                         WriteLiteral(menuItem.ActionValue);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(682, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 19 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Shared\Components\AdminMenu\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(714, 16, true);
            WriteLiteral("    </ul>\r\n</li>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SanMarinoClassicWebsite.Components.AdminMenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
