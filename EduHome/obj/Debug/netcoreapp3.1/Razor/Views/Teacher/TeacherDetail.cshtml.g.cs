#pragma checksum "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b54200688ceebc1479f7b34a368ede7260313d0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherDetail), @"mvc.1.0.view", @"/Views/Teacher/TeacherDetail.cshtml")]
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
using EduHome.ViewModels.Teachers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54200688ceebc1479f7b34a368ede7260313d0f", @"/Views/Teacher/TeacherDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f6990fbfb6ec75cfe3765432b8f2b28ce7ee4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_TeacherDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
Write(await Component.InvokeAsync("Header", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"teacher-details-area pt-150 pb-60\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-5 col-sm-5 col-xs-12\">\n                \n            <div class=\"teacher-details-img\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b54200688ceebc1479f7b34a368ede7260313d0f5061", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 329, "~/assets/img/teacher/", 329, 21, true);
#nullable restore
#line 11 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
AddHtmlAttributeValue("", 350, Model.Image, 350, 12, false);

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
            WriteLiteral("\n            </div>\n   \n            </div>\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\n                <div class=\"teacher-details-content ml-50\">\n                    <h2>");
#nullable restore
#line 17 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                   Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h5>");
#nullable restore
#line 18 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                   Write(Model.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <h4>about me</h4>\n                    <p>");
#nullable restore
#line 20 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li><span>degree: </span>");
#nullable restore
#line 22 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>experience: </span>");
#nullable restore
#line 23 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                                Write(Model.Experince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>hobbies: </span>");
#nullable restore
#line 24 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                             Write(string.Join(", ", Model.TeacherHobbies.Select(h => h.Hobby.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>faculty: </span>");
#nullable restore
#line 25 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 34 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span>make a call : </span>");
#nullable restore
#line 35 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                             Write(Model.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span>skype : </span> ");
#nullable restore
#line 36 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                        Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <ul>
                        <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                        <li><a href=""https://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pinterest""></i></a></li>
                        <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                        <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 51 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                         foreach (TeacherSkill skill in Model.TeacherSkills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-4\">\n                                <div class=\"skill-bar-item\">\n                                    <span>");
#nullable restore
#line 55 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                     Write(skill.Skill.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    <div class=\"progress\">\n                                        <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 2709, "\"", 2739, 3);
            WriteAttributeValue("", 2717, "width:", 2717, 6, true);
#nullable restore
#line 57 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 2723, skill.Progress, 2723, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2738, "%", 2738, 1, true);
            EndWriteAttribute();
            WriteLiteral(" visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;\" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                            <span class=\"text-top\">");
#nullable restore
#line 58 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                                                              Write(skill.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 63 "C:\Users\ACER\source\repos\C#\EduHome\EduHome\Views\Teacher\TeacherDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
