#pragma checksum "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\ContactForm\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399cc0550c481ba14bfbd14a7cd001aa7ff2e29e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactForm_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactForm/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399cc0550c481ba14bfbd14a7cd001aa7ff2e29e", @"/Views/Shared/Components/ContactForm/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e6e6666438ecf2b981716193689aa0d6237c07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContactForm_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactForm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\ContactForm\Default.cshtml"
 foreach (ContactForm form in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"reply-area\">\n        <h3>");
#nullable restore
#line 7 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\ContactForm\Default.cshtml"
       Write(form.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 8 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\ContactForm\Default.cshtml"
      Write(form.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399cc0550c481ba14bfbd14a7cd001aa7ff2e29e7274", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-12"">
                    <p>Name</p>
                    <input type=""text"" name=""name"" id=""name"">
                </div>
                <div class=""col-md-12"">
                    <p>Email</p>
                    <input type=""text"" name=""email"" id=""email"">
                </div>
                <div class=""col-md-12"">
                    <p>Subject</p>
                    <input type=""text"" name=""subject"" id=""subject"">
                    <p>Massage</p>
                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                </div>
            </div>
            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message</span></a>
            <p class=""form-messege""></p>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 30 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-446ea6c022dd5739076e7fd012526e1d4f0a2793\EduHome\Views\Shared\Components\ContactForm\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactForm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
