#pragma checksum "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e1cb674667bd278c467df6ee9a9f2136010b8ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_NoticeCard), @"mvc.1.0.view", @"/Views/User/NoticeCard.cshtml")]
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
#line 7 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
using Services.Abstractions.Dto.Notice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e1cb674667bd278c467df6ee9a9f2136010b8ee", @"/Views/User/NoticeCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed974128daa048c289edefab2233829937c1c327", @"/Views/_ViewImports.cshtml")]
    public class Views_User_NoticeCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoticeDto>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"notice\">\r\n    <p");
            BeginWriteAttribute("style", " style=\"", 220, "\"", 285, 5);
            WriteAttributeValue("", 228, "font-weight:", 228, 12, true);
            WriteAttributeValue(" ", 240, "bold;", 241, 6, true);
            WriteAttributeValue(" ", 246, "text-align:", 247, 12, true);
            WriteAttributeValue(" ", 258, "center;color:", 259, 14, true);
#nullable restore
#line 10 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue(" ", 272, Model.Color, 273, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n    <p");
            BeginWriteAttribute("style", " style=\"", 322, "\"", 349, 2);
            WriteAttributeValue("", 330, "color:", 330, 6, true);
#nullable restore
#line 12 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue(" ", 336, Model.Color, 337, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
                              Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\r\n    <p style=\"text-align: right\">Deadline: ");
#nullable restore
#line 13 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
                                      Write(Model.Deadline.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"card-buttons\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e1cb674667bd278c467df6ee9a9f2136010b8ee6162", async() => {
                WriteLiteral("\r\n            <input hidden type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 586, "\"", 603, 1);
#nullable restore
#line 16 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 594, Model.Id, 594, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 656, "\"", 675, 1);
#nullable restore
#line 17 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 664, Model.Name, 664, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"action\" value=\"finish\">\r\n");
#nullable restore
#line 19 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
             if (Model.Action == "archive")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-secondary\" disabled>Завершить</button>\r\n");
#nullable restore
#line 22 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-secondary\">Завершить</button>\r\n");
#nullable restore
#line 26 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
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
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e1cb674667bd278c467df6ee9a9f2136010b8ee9495", async() => {
                WriteLiteral("\r\n            <input hidden type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1148, "\"", 1165, 1);
#nullable restore
#line 31 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1156, Model.Id, 1156, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"category\"");
                BeginWriteAttribute("value", " value=\"", 1222, "\"", 1245, 1);
#nullable restore
#line 32 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1230, Model.Category, 1230, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1298, "\"", 1317, 1);
#nullable restore
#line 33 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1306, Model.Text, 1306, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1370, "\"", 1389, 1);
#nullable restore
#line 34 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1378, Model.Name, 1378, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"date\" name=\"deadline\"");
                BeginWriteAttribute("value", " value=\"", 1446, "\"", 1469, 1);
#nullable restore
#line 35 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1454, Model.Deadline, 1454, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"date\" name=\"isfinished\"");
                BeginWriteAttribute("value", " value=\"", 1528, "\"", 1553, 1);
#nullable restore
#line 36 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1536, Model.IsFinished, 1536, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"date\" name=\"isfinished\"");
                BeginWriteAttribute("value", " value=\"", 1612, "\"", 1635, 1);
#nullable restore
#line 37 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 1620, Model.IsPublic, 1620, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            <input hidden type=""text"" name=""action"" value=""edit"">
            <button class=""btn btn-secondary"">
                <img style=""height: 38px;"" src=""https://icon-library.com/images/edit-icon-images/edit-icon-images-26.jpg"" />
            </button>
        ");
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
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e1cb674667bd278c467df6ee9a9f2136010b8ee14368", async() => {
                WriteLiteral("\r\n            <input hidden type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2029, "\"", 2046, 1);
#nullable restore
#line 45 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 2037, Model.Id, 2037, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2099, "\"", 2118, 1);
#nullable restore
#line 46 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 2107, Model.Name, 2107, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2171, "\"", 2190, 1);
#nullable restore
#line 47 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 2179, Model.Text, 2179, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"Category\"");
                BeginWriteAttribute("value", " value=\"", 2247, "\"", 2270, 1);
#nullable restore
#line 48 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\NoticeCard.cshtml"
WriteAttributeValue("", 2255, Model.Category, 2255, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input hidden type=\"text\" name=\"action\" value=\"del\">\r\n            <button class=\"btn btn-secondary\">Удалить</button>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoticeDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
