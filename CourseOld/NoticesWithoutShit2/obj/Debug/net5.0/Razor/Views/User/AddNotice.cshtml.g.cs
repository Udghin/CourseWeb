#pragma checksum "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a316d5ae573535feaae28d22a3607bc885c4559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AddNotice), @"mvc.1.0.view", @"/Views/User/AddNotice.cshtml")]
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
#line 1 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml"
using Services.Abstractions.Dto.Notice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a316d5ae573535feaae28d22a3607bc885c4559", @"/Views/User/AddNotice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed974128daa048c289edefab2233829937c1c327", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AddNotice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoticeAndCatsDto>
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
            WriteLiteral("<h1 style=\"text-align: center;\">Добавить заметку</h1>\r\n\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a316d5ae573535feaae28d22a3607bc885c45594321", async() => {
                WriteLiteral(@"
        <div class=""mb-3"">
            <label for=""firstNameInput"" class=""form-label"">Название:</label>
            <input type=""text"" name=""name"" class=""form-control"" id=""nameInput"" placeholder=""Введите имя заметки..."">
        </div>
        <div class=""mb-3"">
            <label for=""lastNameInput"" class=""form-label"">Текст:</label>
");
                WriteLiteral(@"            <textarea type=""text"" rows=""10"" name=""text"" class=""form-control"" id=""genreInput"" placeholder=""Введите текст заметки..."" onclick=""_SetDisabled_()""></textarea>
        </div>


        <div class=""add-down-line"">
            <div>
                <label for=""lastNameInput"" class=""form-label"">Крайний срок выполнения:</label>
");
                WriteLiteral(@"                <input type=""date"" name=""deadline"" id=""deadline"" required>
                <span class=""validity""></span>
            </div>

            <div>
                <label for=""lastNameInput"" class=""form-label"">Категория:</label>
                <select name=""category"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a316d5ae573535feaae28d22a3607bc885c45595700", async() => {
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
#line 30 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml"
                     foreach (var cat in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a316d5ae573535feaae28d22a3607bc885c45597673", async() => {
#nullable restore
#line 32 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml"
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
#line 32 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml"
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
#line 33 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div>
                <input type=""checkbox"" id=""isPublic"" name=""ispublic"" value=""true"">
                <label for=""isPublic"">(доступно всем)</label>
            </div>
            <div>
                <label for=""lastNameInput"" class=""form-label"">Цвет:</label>
                <input type=""color"" name=""color"" id=""countPagesInput"">
            </div>
        </div>


        <button id=""add-btn"" class=""btn btn-primary"">Добавить</button>
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
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<script>\r\n            $(\'#submit\').click(function(evt) {\r\n              evt.preventDefault();\r\n\r\n              var payload = $(\'form\').serialize();\r\n\r\n              $.ajax({\r\n                url: \'");
#nullable restore
#line 76 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\User\AddNotice.cshtml"
                 Write(Url.Action("Create", "Buses"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                 type: 'POST',
                 data: payload,
                 success: function (result) {
                     alert(""Norm"");
                 },
                 error: function (error) {
                     alert(""Errr"");
                 }
              });
            });
</script>");
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
