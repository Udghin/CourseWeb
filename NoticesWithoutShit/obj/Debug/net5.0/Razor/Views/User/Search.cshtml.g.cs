#pragma checksum "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88fc87f3c25b969ca2a055d2152d823baa5076c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Search), @"mvc.1.0.view", @"/Views/User/Search.cshtml")]
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
#line 1 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\_ViewImports.cshtml"
using NoticeWithoutShit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\_ViewImports.cshtml"
using NoticeWithoutShit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
using Services.Abstractions.Dto.Notice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88fc87f3c25b969ca2a055d2152d823baa5076c", @"/Views/User/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed974128daa048c289edefab2233829937c1c327", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoticeAndCatsDto>
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
#nullable restore
#line 4 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""main-frame"">
        <div class=""page-name"">
            <br />
            <h1 style=""text-align: center;"">Панель управления заметками!</h1>
            <p style=""text-align:center;"">
                UserID: <span class=""userid"" id=""userid"">");
#nullable restore
#line 13 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                                                    Write(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>&nbsp;
                <a id=""copy-id"" class=""copy-id"" href=""#""><img height=""20"" src=""https://img2.freepng.ru/20180712/guv/kisspng-computer-icons-symbol-copying-cut-copy-and-paste-version-5b47e79ec6ab20.0376768415314390068138.jpg"" /></a>
            </p>
            <div style=""text-align:center; display: flex; justify-content: space-around;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88fc87f3c25b969ca2a055d2152d823baa5076c5293", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                     if (Model.Sort == "sortByDeadline")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input hidden type=\"text\" name=\"action\" value=\"sortByDeadlineOpposite\">\r\n");
#nullable restore
#line 21 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input hidden type=\"text\" name=\"action\" value=\"sortByDeadline\">\r\n");
#nullable restore
#line 25 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input hidden type=\"text\" name=\"Search\"");
                BeginWriteAttribute("value", " value=\"", 1237, "\"", 1258, 1);
#nullable restore
#line 26 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
WriteAttributeValue("", 1245, Model.Search, 1245, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button type=\"submit\" class=\"btn btn-light\">\r\n                        Сортировать по Дедлайну\r\n                    </button>\r\n                ");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88fc87f3c25b969ca2a055d2152d823baa5076c8431", async() => {
                WriteLiteral("\r\n                    <div style=\"display: flex;\">\r\n\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Search...\" aria-label=\"Username\" name=\"Search\"");
                BeginWriteAttribute("value", " value=\"", 1676, "\"", 1697, 1);
#nullable restore
#line 34 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
WriteAttributeValue("", 1684, Model.Search, 1684, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"">
                        <span class=""input-group-text"" id=""basic-addon1"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search"" viewBox=""0 0 16 16"">
                                <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                            </svg>
                        </span>
                    </div>
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88fc87f3c25b969ca2a055d2152d823baa5076c11166", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                     if (Model.Sort == "sortByDate")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input hidden type=\"text\" name=\"action\" value=\"sortByDateOpposite\">\r\n");
#nullable restore
#line 46 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input hidden type=\"text\" name=\"action\" value=\"sortByDate\">\r\n");
#nullable restore
#line 50 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input hidden type=\"text\" name=\"Search\"");
                BeginWriteAttribute("value", " value=\"", 2793, "\"", 2814, 1);
#nullable restore
#line 51 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
WriteAttributeValue("", 2801, Model.Search, 2801, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button type=\"submit\" class=\"btn btn-light\">\r\n                        Сортировать по Дате\r\n                    </button>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n        </div>\r\n        <div>\r\n\r\n");
#nullable restore
#line 61 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
             if (Model.Notices.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\r\n");
#nullable restore
#line 64 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                     if (Model.Sort == "sortByDate")
                        Model.Notices = Model.Notices.OrderByDescending(n => n.CreatedAt).ToList();
                    else if (Model.Sort == "sortByDateOpposite")
                        Model.Notices = Model.Notices.OrderBy(n => n.CreatedAt).ToList();
                    else if (Model.Sort == "sortByDeadline")
                        Model.Notices = Model.Notices.OrderBy(n => n.Deadline).ToList();
                    else if (Model.Sort == "sortByDeadlineOpposite")
                        Model.Notices.OrderByDescending(n => n.Deadline).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                     foreach (var not in Model.Notices)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <p style=\"font-weight: bold; text-align: center;\">");
#nullable restore
#line 76 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                                                                         Write(not.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"font-weight: 200; text-align: justify; padding-right:40px; \">");
#nullable restore
#line 77 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                                                                                              Write(not.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"text-align: center;\">Категория: <b>");
#nullable restore
#line 78 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                                                                    Write(not.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> || Создано: ");
#nullable restore
#line 78 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                                                                                                  Write(not.CreatedAt.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" || Дэдлайн: ");
#nullable restore
#line 78 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                                                                                                                                           Write(not.Deadline.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </li>\r\n");
#nullable restore
#line 80 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 82 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <br />
                <p style=""text-align: center;""><h2 style=""text-align: center;"">Без х$*и! Ничего такого нема..</h2></p>
                <br />
                <p style=""text-align: center;""><img width=""550"" height=""460"" src=""https://vsvarke.com/content/themes/default/images/no_results.png"" /></p>
");
#nullable restore
#line 89 "C:\Users\student\Desktop\Hryhoriev\Course\NoticesWithoutShit\Views\User\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
            WriteLiteral(@"
<script>
    var btn = document.querySelector(""#delcat-btn2"").onclick = delcat;
    document.getElementById(""delcat-btn"").onclick = delcat;
    function delcat() {
        alert(""delcat"");
    }
    function delcat2(msg) {
        alert(btn.name);
    }
</script>

<script type=""text/javascript"">
    document.getElementById(""copy-id"").addEventListener(""click"", function () {
        copyToClipboard(document.getElementById(""userid""));
    });



    function copyToClipboard(elem) {
        // create hidden text element, if it doesn't already exist
        var targetId = ""_hiddenCopyText_"";
        var isInput = elem.tagName === ""INPUT"" || elem.tagName === ""TEXTAREA"";
        var origSelectionStart, origSelectionEnd;
        if (isInput) {
            // can just use the original source element for the selection and copy
            target = elem;
            origSelectionStart = elem.selectionStart;
            origSelectionEnd = elem.selectionEnd;
        } else {
            // m");
            WriteLiteral(@"ust use a temporary form element for the selection and copy
            target = document.getElementById(targetId);
            if (!target) {
                var target = document.createElement(""textarea"");
                target.style.position = ""absolute"";
                target.style.left = ""-9999px"";
                target.style.top = ""0"";
                target.id = targetId;
                document.body.appendChild(target);
            }
            target.textContent = elem.textContent;
        }
        // select the content
        var currentFocus = document.activeElement;
        target.focus();
        target.setSelectionRange(0, target.value.length);

        // copy the selection
        var succeed;
        try {
            succeed = document.execCommand(""copy"");
        } catch (e) {
            succeed = false;
        }
        // restore original focus
        if (currentFocus && typeof currentFocus.focus === ""function"") {
            currentFocus.focus();
    ");
            WriteLiteral(@"    }

        if (isInput) {
            // restore prior selection
            elem.setSelectionRange(origSelectionStart, origSelectionEnd);
        } else {
            // clear temporary content
            target.textContent = """";
        }
        return succeed;
    }
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
