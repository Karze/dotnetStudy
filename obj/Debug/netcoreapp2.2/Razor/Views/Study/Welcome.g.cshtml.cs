#pragma checksum "D:\WorkLab\csharpmvc\MvcMovie\Views\Study\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28ada1d6812938f1ced5eb83211f0cd47adb3ec7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Study_Welcome), @"mvc.1.0.view", @"/Views/Study/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Study/Welcome.cshtml", typeof(AspNetCore.Views_Study_Welcome))]
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
#line 1 "D:\WorkLab\csharpmvc\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "D:\WorkLab\csharpmvc\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ada1d6812938f1ced5eb83211f0cd47adb3ec7", @"/Views/Study/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Study_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\WorkLab\csharpmvc\MvcMovie\Views\Study\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome123";

#line default
#line hidden
            BeginContext(46, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(53, 17, false);
#line 5 "D:\WorkLab\csharpmvc\MvcMovie\Views\Study\Welcome.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(70, 95, true);
            WriteLiteral("</h2>\r\n\r\n<p>Welcome to our View Template!</p>\r\n<div class=\"alert alert-primary\" role=\"alert\">\r\n");
            EndContext();
            BeginContext(166, 19, false);
#line 9 "D:\WorkLab\csharpmvc\MvcMovie\Views\Study\Welcome.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 78, true);
            WriteLiteral("!\r\n</div>\r\n<div class=\"alert alert-secondary\" role=\"alert\">\r\nYour numtimes is ");
            EndContext();
            BeginContext(264, 20, false);
#line 12 "D:\WorkLab\csharpmvc\MvcMovie\Views\Study\Welcome.cshtml"
            Write(ViewData["NumTimes"]);

#line default
#line hidden
            EndContext();
            BeginContext(284, 288, true);
            WriteLiteral(@"!
</div>

<button class=""btn-group"" role=""group"" aria-label=""Basic example"">
  <button type=""button"" class=""btn btn-secondary"">Left</button>
  <button type=""button"" class=""btn btn-secondary"">Middle</button>
  <button type=""button"" class=""btn btn-secondary"">Right</button>
</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
