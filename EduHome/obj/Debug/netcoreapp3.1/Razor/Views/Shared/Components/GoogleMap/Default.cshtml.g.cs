#pragma checksum "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\GoogleMap\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "556b105ca06c9a448c410436ef9d7e63542b7a19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GoogleMap_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GoogleMap/Default.cshtml")]
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
#nullable restore
#line 2 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Teacher;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"556b105ca06c9a448c410436ef9d7e63542b7a19", @"/Views/Shared/Components/GoogleMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34368b282ede7774e2c9d8b3f3ab41e24d6411c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GoogleMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"map-area\">\r\n    <!-- google-map-area start -->\r\n    <div class=\"google-map-area\">\r\n        <iframe");
            BeginWriteAttribute("src", " src=\"", 147, "\"", 208, 1);
#nullable restore
#line 6 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\GoogleMap\Default.cshtml"
WriteAttributeValue("", 153, Model.FirstOrDefault(t => t.Key == "ContactMap").Value, 153, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"1480\" height=\"450\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 253, "\"", 271, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
