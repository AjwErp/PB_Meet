#pragma checksum "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a0b88d01da79da1534d768cb041e6b31b050b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Design_Views_DesignSupportGuide_DesignLawBookList), @"mvc.1.0.view", @"/Areas/Design/Views/DesignSupportGuide/DesignLawBookList.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a0b88d01da79da1534d768cb041e6b31b050b7", @"/Areas/Design/Views/DesignSupportGuide/DesignLawBookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Design/Views/_ViewImports.cshtml")]
    public class Areas_Design_Views_DesignSupportGuide_DesignLawBookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AJWManagementPortal.Models.LawBook>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DesignLawBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DesignSupportGuide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Design", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tabled col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
  
    ViewData["Title"] = "DesignLawBookList";
    Layout = "~/Views/Shared/_LayoutDesign.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a0b88d01da79da1534d768cb041e6b31b050b75890", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            <div class=\"header col-sm-12\">\r\n                <a class=\"logo font-weight-bold font-weight-bolder\">");
#nullable restore
#line 24 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                                               Write(Localizer["Design Department Law Book List"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </div>\r\n");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a0b88d01da79da1534d768cb041e6b31b050b76803", async() => {
                    WriteLiteral("\r\n                <hr />\r\n");
                    WriteLiteral("                <div class=\"col-sm-12 text-center\">\r\n                    <a class=\"TitleProductionOfficeReport\" colspan=\"10\">");
#nullable restore
#line 34 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                                                   Write(Localizer["Design Department Law Book List"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                </div>\r\n                <br />\r\n                <table class=\"table table-bordered SubH\" id=\"CEOLBook\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr SubH\">\r\n                            <th>");
#nullable restore
#line 40 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                           Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            <th>");
#nullable restore
#line 41 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            <th>");
#nullable restore
#line 42 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                           Write(Localizer["Department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 43 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                           Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 44 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
#nullable restore
#line 50 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                            <tr class=""tabbody SubH"">
                                <td class=""actionbtn"">
                                    <div class=""btn-group"">
                                        <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            ");
#nullable restore
#line 56 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                       Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </button>\r\n                                        <div class=\"dropdown-menu\">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a0b88d01da79da1534d768cb041e6b31b050b710898", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 59 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                                                                                                                                                                                                                                                           Write(Localizer["View"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                                                                                                                                        WriteLiteral(item.department);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                                                                                                                                                                           WriteLiteral(item.title);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                                                                                                                                                                                                                        WriteLiteral(item.Date);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 67 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                               Write(item.department);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                               Write(item.title);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Design\Views\DesignSupportGuide\DesignLawBookList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n");
                    WriteLiteral("            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //This JS Code For this Page Pagination
        $(document).ready(function () {
            $('#CEOLBook').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //---------JS for Back To Top Button On Each Page------------------Start-------
        var btn = $('#button');

        $(window).scroll(function () {
            if ($(window).scrollTop() > 300) {
                btn.addClass('show');
            } else {
                btn.removeClass('show');
            }
        });

        btn.on('click', function (e) {
            e.preventDefault();
            $('html, body').animate({ scrollTop: 0 }, '300');
        });
                        //---------JS for Back To Top Button On Each Page------------------ended-------

    </script>

");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .header {
        overflow: hidden;
        padding: 10px 10px;
        font-size: 40px;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }

    .TitleProductionOfficeReport {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: xx-large;
        font-weight: bold;
    }

    body {
        font-family: 'Jameel Noori Nastaleeq';
    }

    body {
        font: 90%/1.45em ""Helvetica Neue"", HelveticaNeue, Verdana, Arial, Helvetica, sans-serif;
        margin: 0;
        padding: 0;
        color: #333;
        background-color: #fff;
    }

    .Createbtn {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: large;
        text-align: right;
    }

    .actionbtn {
        width: 150px;
        text-align: center;
    }

    .SubH {
        text-align: center;
        font-family: 'Jameel Noori Nastaleeq';
        font-size: medium;
    }

    /*    .titleAccountofficeReport {
        font-family: '");
            WriteLiteral(@"Jameel Noori Nastaleeq';
        font-size: xx-large;
        font-weight: bold;
    }*/

    .Subhdr {
        color: white;
        text-align: center;
        background-color: slategrey;
    }

    .tabbody {
        text-align: center;
        color: black;
    }

    .lang_btn {
        font-family: ""ProximaNova"";
        color: #fff;
        font-size: 15px;
        text-transform: uppercase;
        text-decoration: none !important;
        background-color: #C82333;
        text-transform: uppercase;
        margin-top: 1.7%;
        text-decoration: none !important;
        width: 65px;
        text-align: center;
        height: 39px;
        border: solid 1px #C82333;
    }
</style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AJWManagementPortal.Models.LawBook>> Html { get; private set; }
    }
}
#pragma warning restore 1591
