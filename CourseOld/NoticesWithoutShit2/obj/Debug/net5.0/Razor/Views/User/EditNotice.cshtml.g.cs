#pragma checksum "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87870e60d3f2e1ad3d19bc236130304368c11c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditNotice), @"mvc.1.0.view", @"/Views/User/EditNotice.cshtml")]
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
#line 1 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\_ViewImports.cshtml"
using NoticeWithoutShit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\_ViewImports.cshtml"
using NoticeWithoutShit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
using Services.Abstractions.Dto.Notice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87870e60d3f2e1ad3d19bc236130304368c11c9f", @"/Views/User/EditNotice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed974128daa048c289edefab2233829937c1c327", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditNotice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoticeAndCatsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 style=\"text-align: center;\">Добавить заметку</h1>\r\n");
#nullable restore
#line 4 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
  
    string date = @Model.Notices[0].Deadline.GetDateTimeFormats()[21].Substring(0, 10);

    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87870e60d3f2e1ad3d19bc236130304368c11c9f4618", async() => {
                WriteLiteral("\r\n            <div class=\"mb-3\">\r\n                <label for=\"firstNameInput\" class=\"form-label\">Название:</label>\r\n                <input type=\"text\" name=\"name\" class=\"form-control\" id=\"nameInput\"");
                BeginWriteAttribute("value", " value=\"", 502, "\"", 532, 1);
#nullable restore
#line 11 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
WriteAttributeValue("", 510, Model.Notices[0].Name, 510, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"text\" name=\"id\" hidden class=\"form-control\" id=\"nameInput\"");
                BeginWriteAttribute("value", " value=\"", 623, "\"", 651, 1);
#nullable restore
#line 12 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
WriteAttributeValue("", 631, Model.Notices[0].Id, 631, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"lastNameInput\" class=\"form-label\">Текст:</label>\r\n                <textarea type=\"text\" rows=\"10\" name=\"text\" class=\"form-control\" id=\"genreInput\">");
#nullable restore
#line 16 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                                                                                            Write(Model.Notices[0].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
            </div>
            <div class=""add-down-line"">
                <div>
                    <label for=""deadline"" class=""form-label"">Крайний срок выполнения:</label>
                    <input type=""date"" name=""deadline"" id=""deadline""");
                BeginWriteAttribute("value", " value=\"", 1164, "\"", 1177, 1);
#nullable restore
#line 21 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
WriteAttributeValue("", 1172, date, 1172, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div>\r\n                    <label for=\"lastNameInput\" class=\"form-label\">Категория:</label>\r\n                    <select name=\"category\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87870e60d3f2e1ad3d19bc236130304368c11c9f7387", async() => {
                    WriteLiteral("Выберите категорию");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                         foreach (var cat in Model.Categories)
                        {
                            if (@cat.Name == @Model.Notices[0].Category)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87870e60d3f2e1ad3d19bc236130304368c11c9f9482", async() => {
#nullable restore
#line 31 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                                                              Write(cat.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                                   WriteLiteral(cat.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87870e60d3f2e1ad3d19bc236130304368c11c9f12015", async() => {
#nullable restore
#line 35 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                                                     Write(cat.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                                   WriteLiteral(cat.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n");
#nullable restore
#line 41 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                     if (@Model.Notices[0].IsPublic)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\" id=\"isPublic\" name=\"ispublic\" value=\"true\" checked>\r\n");
#nullable restore
#line 44 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\" id=\"isPublic\" name=\"ispublic\" value=\"true\">\r\n");
#nullable restore
#line 48 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label for=\"isPublic\">(доступно всем)</label>\r\n                </div>\r\n                <div>\r\n");
#nullable restore
#line 53 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                     if (@Model.Notices[0].IsFinished)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\" id=\"IsFinished\" name=\"isfinished\" value=\"true\" checked>\r\n");
#nullable restore
#line 56 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"checkbox\" id=\"IsFinished\" name=\"isfinished\" value=\"true\">\r\n");
#nullable restore
#line 60 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label for=""IsFinished"">Выполнено</label>
                </div>
                <div>
                    <label for=""lastNameInput"" class=""form-label"">Цвет:</label>
                    <input type=""color"" name=""color"" id=""countPagesInput""");
                BeginWriteAttribute("value", " value=\"", 3152, "\"", 3183, 1);
#nullable restore
#line 66 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\EditNotice.cshtml"
WriteAttributeValue("", 3160, Model.Notices[0].Color, 3160, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button class=\"btn btn-primary\">Сохранить изменения</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoticeAndCatsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
