#pragma checksum "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\AboutVideo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f6ce50abcfa87a57b09a0b2b71daac7491f0c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutVideo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutVideo/Default.cshtml")]
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
#line 2 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Teachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Register;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6ce50abcfa87a57b09a0b2b71daac7491f0c7b", @"/Views/Shared/Components/AboutVideo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e6e6666438ecf2b981716193689aa0d6237c07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutVideo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutVideo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\AboutVideo\Default.cshtml"
 foreach (AboutVideo video in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"notice-video\">\n        <div class=\"video-icon video-hover\">\n            ");
#nullable restore
#line 7 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\AboutVideo\Default.cshtml"
       Write(Html.Raw(video.VideoPopup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 10 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\AboutVideo\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutVideo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
