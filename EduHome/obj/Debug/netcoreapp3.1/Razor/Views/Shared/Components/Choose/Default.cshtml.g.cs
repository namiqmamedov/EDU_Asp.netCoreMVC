#pragma checksum "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f680ab1e8aa41c040634538487d9876b819ed03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Choose_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Choose/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f680ab1e8aa41c040634538487d9876b819ed03", @"/Views/Shared/Components/Choose/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66624e04f43eb03c8d776333081e4e884c674b39", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Choose_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Choose>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml"
 foreach (Choose choose in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"choose-area pb-85 pt-77\"");
            BeginWriteAttribute("style", " style=\"", 114, "\"", 166, 4);
            WriteAttributeValue("", 122, "background-image:", 122, 17, true);
            WriteAttributeValue(" ", 139, "url(", 140, 5, true);
#nullable restore
#line 6 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml"
WriteAttributeValue("", 144, choose.BackgroundImg, 144, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 165, ")", 165, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4\">\r\n                    <div class=\"choose-content text-left\">\r\n                        <h2>");
#nullable restore
#line 11 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml"
                       Write(choose.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 12 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml"
                      Write(choose.MainDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"choose-option\">");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml"
                                            Write(choose.SubDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a class=\"default-btn\" href=\"course-details.html\">view courses</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 20 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Shared\Components\Choose\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Choose>> Html { get; private set; }
    }
}
#pragma warning restore 1591
