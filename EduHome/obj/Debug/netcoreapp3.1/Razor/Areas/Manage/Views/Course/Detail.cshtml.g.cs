#pragma checksum "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f18b4e3849fedba8794c7e475b0f959f74deb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/Course/Detail.cshtml")]
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
#line 2 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Teachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\_ViewImports.cshtml"
using EduHome.Areas.Manage.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f18b4e3849fedba8794c7e475b0f959f74deb8", @"/Areas/Manage/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95ed8d868bedcf6eb39b7e7a635b31e192ffb40", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div style=""margin-left: -5rem;"" class=""courses-details"">
                    <div class=""courses-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85f18b4e3849fedba8794c7e475b0f959f74deb86122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 346, "~/assets/img/course/", 346, 20, true);
#nullable restore
#line 10 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 366, Model.Image, 366, 12, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"course-details-content\">\n                        <h2>");
#nullable restore
#line 13 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p>");
#nullable restore
#line 14 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                      Write(Model.TitleDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                               \n                                <h3>ABOUT COURSE</h3>\n                                <p>");
#nullable restore
#line 17 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                              Write(Model.AboutDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            \n                         \n                                <h3>HOW TO APPLY</h3>\n                                <p>");
#nullable restore
#line 21 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                              Write(Model.ApplyDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            \n                                <h3>CERTIFICATION</h3>\n                                <p class=\"margin\">");
#nullable restore
#line 24 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                             Write(Model.CertificationDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>");
#nullable restore
#line 25 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                              Write(Model.LastDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>                  
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div style=""width: 984px; margin-top: 1rem; margin-left: 3rem;"" id=""right-dtl"" class=""right-dtl"">
                    <div class=""course-details-right"">
                        <h3>COURSE FEATURES</h3>
                        <ul>
                            <li>starts <span>");
#nullable restore
#line 34 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                        Write(Model.CourseStarts.ToString("d, MMMe yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            <li>duration <span>");
#nullable restore
#line 35 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                          Write(Model.CourseDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            <li>class duration <span>");
#nullable restore
#line 36 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                                Write(Model.CourseClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            <li>skill level <span>");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                             Write(Model.CourseSkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            <li>language <span>");
#nullable restore
#line 38 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                          Write(Model.CourseLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            <li>students <span>");
#nullable restore
#line 39 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                          Write(Model.CourseStudents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            <li>assesments <span>");
#nullable restore
#line 40 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                            Write(Model.CourseAssesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                        </ul>\n                        <h3 class=\"red\">course fee ");
#nullable restore
#line 42 "C:\Users\ACER\Desktop\EDU_Asp.netCoreMVC-master\EduHome\Areas\Manage\Views\Course\Detail.cshtml"
                                              Write(Model.FEE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    </div>\n                </div>\n            </div>\n        </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
