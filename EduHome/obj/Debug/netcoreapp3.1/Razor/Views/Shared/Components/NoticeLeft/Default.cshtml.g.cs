#pragma checksum "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\Shared\Components\NoticeLeft\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96365c9bafe3d037bddc36c086e1ab6257aec950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NoticeLeft_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NoticeLeft/Default.cshtml")]
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
#line 3 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Teachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96365c9bafe3d037bddc36c086e1ab6257aec950", @"/Views/Shared/Components/NoticeLeft/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b04fc6e0db0b37c888935c91349ec5053d94ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NoticeLeft_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NoticeLeft>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\n                <div class=\"notice-left\">\n\n                    <h3>NOTICE BOARD</h3>\n");
#nullable restore
#line 11 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\Shared\Components\NoticeLeft\Default.cshtml"
                     foreach (NoticeLeft notice in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div id=\"notice-left1\" class=\"single-notice-left \">\n                            <h4>");
#nullable restore
#line 14 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\Shared\Components\NoticeLeft\Default.cshtml"
                           Write(notice.Date.ToString("d, MMMe yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <p>");
#nullable restore
#line 15 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\Shared\Components\NoticeLeft\Default.cshtml"
                          Write(notice.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n");
#nullable restore
#line 17 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Views\Shared\Components\NoticeLeft\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n\n\n           ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NoticeLeft>> Html { get; private set; }
    }
}
#pragma warning restore 1591
