#pragma checksum "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed9f74882045fe083c92adb511818734d304c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
using Services.Abstractions.Dto.Notice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed9f74882045fe083c92adb511818734d304c50", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed974128daa048c289edefab2233829937c1c327", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NoticeDto>>
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
#nullable restore
#line 3 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Первая страница";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""main-frame"">
    <div class=""index-page"">
        <div class=""news-block"">
            <div style=""text-align: center;display:flex; justify-content: space-around;"">
                <div style=""width: 400px; background-color: white; border-bottom-left-radius: 15px; border-bottom-right-radius: 15px; "">
                    <br />
                    <p style=""text-align: center; font-weight: bold;"">
                        Супер новости Супер сервиса
                    </p>

                </div>
            </div>

            <br />
            <div class=""news"">
                <p style=""font-weight: bold; text-align: center"">Опубликована версия сервиса 0.87</p>
                <hr />
                <p style=""text-align: justify;"">
                    В этой версии приложения намного улучшен интерфейс. Налажена производительность, которая соответсвует нормам наступившего 2022го года.
                    Наша команда разработчиков ежечасно трудится над улучшнением отзывчивос");
            WriteLiteral(@"ти и удобоства вашего, всем любимого сервиса - ""Супер сервис заметок без х$*и""
                </p>
                <p style=""text-align: right"">Дата: 02.01.2022</p>
            </div>
            <div class=""news"">
                <p style=""font-weight: bold; text-align: center"">Были сложности с работой сервиса</p>
                <hr />
                <p style=""text-align: justify;"">
                    В связи с имеющимися проблемами после обучения азам, так сказать, программирования в среде ASP.Net Core было выяснено, что наш единественный специалист не в состоянии сходу взять
                    и сделать требуемое для курсовой работы приложение!
                </p>
                <p style=""text-align: justify;"">
                    Посидев и понервничав, день другой... было проштудированно куча выполненных в своё время ДЗ, которые показали, что цель применения тех или иных приемов и технологий - абсолютно не ясна
                    а ответов на кучу вопросов просто нет, так как многие а");
            WriteLiteral(@"спекты в принципе не обсуждались и не раскрывались.
                </p>
                <p>Наш специалист, попытался вникнуть в:</p>
                <ul>
                    <li>Принципы работы с БД</li>
                    <li>Onion архитектуру</li>
                    <li>Взаимодействие модель-представление</li>
                    <li>Api</li>
                </ul>
                <p style=""text-align: right"">Дата: 31.12.2021</p>
            </div>
            <div class=""news"">
                <p style=""font-weight: bold; text-align: center"">Мы наконец-то запустились!</p>
                <hr />
                <p style=""text-align: center""><img src=""https://anisola-mebel.ru/u/2015/07/11.jpg"" /></p>
                <p style=""text-align: right"">Дата: 29.12.2021</p>
            </div>
            <div></div>
        </div>
        <div class=""last-publics"">
            <br />
            <p style=""text-align: center; font-weight: bold"">Последние публичные заметки</p>
            <hr />");
            WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
             if (Model.Count > 0)
            {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
             foreach (var not in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"public-notice\">\r\n");
#nullable restore
#line 70 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                     if (not.Text.Length > 67)
                    {
                        string text = not.Text.Substring(0, 67) + "...";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"text-align:center;font-weight: 600;\">");
#nullable restore
#line 73 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                                  Write(not.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 73 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                                                Write(text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                                                          

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"text-align:center;font-weight: 600;\">");
#nullable restore
#line 78 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                                  Write(not.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 78 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                                                Write(not.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3877, "\"", 3945, 5);
            WriteAttributeValue("", 3887, "document.getElementById(\'", 3887, 25, true);
#nullable restore
#line 80 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
WriteAttributeValue("", 3912, not.Id, 3912, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3919, "\').submit();", 3919, 12, true);
            WriteAttributeValue(" ", 3931, "return", 3932, 7, true);
            WriteAttributeValue(" ", 3938, "false;", 3939, 7, true);
            EndWriteAttribute();
            WriteLiteral("> подробнее...</a>\r\n                    <br />\r\n                    <p style=\"text-align:right;\">Автор: ");
#nullable restore
#line 82 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
                                                   Write(not.UserOwner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed9f74882045fe083c92adb511818734d304c5011505", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" hidden name=\"id\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4235, "\"", 4250, 1);
#nullable restore
#line 84 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
WriteAttributeValue("", 4243, not.Id, 4243, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 83 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4114, not.Id, 4114, 7, false);

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
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 87 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\STEP\Курсовая WEB\V2\Course\NoticesWithoutShit\Views\Home\Index.cshtml"
             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n   \r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebHostEnvironment env { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NoticeDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
