#pragma checksum "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Equipment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b5a19e88a78dde82999a879e70031ff95ac06c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipment_Details), @"mvc.1.0.view", @"/Views/Equipment/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Equipment/Details.cshtml", typeof(AspNetCore.Views_Equipment_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5a19e88a78dde82999a879e70031ff95ac06c2", @"/Views/Equipment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a769198bd06e0ac67e6a8837f71f2a46c27f1cd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Equipment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 35, true);
            WriteLiteral("\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 53, "\"", 91, 1);
#line 4 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Equipment\Details.cshtml"
WriteAttributeValue("", 59, Model.EquipmentShortDescription, 59, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 92, "\"", 122, 1);
#line 4 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Equipment\Details.cshtml"
WriteAttributeValue("", 98, Model.ImageThumbnailUrl, 98, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(123, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(190, 25, false);
#line 6 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Equipment\Details.cshtml"
                          Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(215, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(261, 31, false);
#line 8 "C:\Users\Jolina\Desktop\GitHubProjects\SanMarinoClassicWebApplication\SanMarinoClassicWebsite\Views\Equipment\Details.cshtml"
                   Write(Model.EquipmentShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(292, 139, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <p class=\"button\">\r\n            <a class=\"btn btn-primary\">Add to cart</a>\r\n        </p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Equipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
