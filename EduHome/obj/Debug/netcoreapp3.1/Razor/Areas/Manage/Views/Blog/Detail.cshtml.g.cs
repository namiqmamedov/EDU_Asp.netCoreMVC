#pragma checksum "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b451009f81646f58b7488a790c2b0f849c76dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Blog_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/Blog/Detail.cshtml")]
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
#line 2 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Teachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.Areas.Manage.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b451009f81646f58b7488a790c2b0f849c76dc", @"/Areas/Manage/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f978b689e005bbe36f1e075d2c186e006831a464", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"blog-details-area pt-150 pb-140\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-8\">\n                <div class=\"blog-details\">\n                    <div class=\"blog-details-img\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a7b451009f81646f58b7488a790c2b0f849c76dc5751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 297, "~/assets/img/blog/", 297, 18, true);
#nullable restore
#line 9 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 315, Model.Image, 315, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"blog-details-content\">\n                        <h2>");
#nullable restore
#line 12 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p>By ");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                                         Write(Model.Date.ToString("MMMe d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /  <i class=\"fa fa-comments-o\"></i> 1</p>\n");
#nullable restore
#line 14 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                         foreach (BlogDescription description in Model.BlogDescriptions)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 16 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
          Write(description.SimpleDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"quote\">");
#nullable restore
#line 17 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                                        Write(description.QuoteDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 17 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    
              
                    <div class=""single-blog-widget"">
                        <h3>tags</h3>
                        <div class=""single-tag"">
");
#nullable restore
#line 28 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                             foreach (BlogTag tags in Model.BlogTags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"blog-details.html\" class=\"mr-10 mb-10\">");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                                                           Write(tags.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Areas\Manage\Views\Blog\Detail.cshtml"
                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591