#pragma checksum "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b64120bb05e15620fe35d3437eb75a7ce8d68237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Gm_Views_GmAllDepatLawBook_GmAllDepatLawBook), @"mvc.1.0.view", @"/Areas/Gm/Views/GmAllDepatLawBook/GmAllDepatLawBook.cshtml")]
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
#line 1 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b64120bb05e15620fe35d3437eb75a7ce8d68237", @"/Areas/Gm/Views/GmAllDepatLawBook/GmAllDepatLawBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Gm/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Gm_Views_GmAllDepatLawBook_GmAllDepatLawBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AJWManagementPortal.Models.LawBook>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
  
    ViewData["Title"] = "GmAllDepatLawBook";
    Layout = "~/Views/Shared/_LayoutGm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b64120bb05e15620fe35d3437eb75a7ce8d682375824", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            <div class=\"header col-sm-12\">\r\n                <a class=\"logo font-weight-bold\">");
#nullable restore
#line 17 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                            Write(Localizer["All Department Laws Book List"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </div>\r\n            <br />\r\n");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b64120bb05e15620fe35d3437eb75a7ce8d682376740", async() => {
                    WriteLiteral("\r\n                <hr />\r\n");
                    WriteLiteral("                <br />\r\n                <table class=\"table table-bordered\" id=\"MAReport\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr SubH\">\r\n                            <th>");
#nullable restore
#line 33 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                           Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            <th>");
#nullable restore
#line 34 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 35 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                           Write(Localizer["Department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 36 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                           Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 37 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 41 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                          
                            foreach (LawBook b in ViewBag.GmAllDepatLawBook)
                            {


#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                <tr class=""tabbody SubH"">
                                    <td class=""actionbtn"">
                                        <div class=""btn-group"">
                                            <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                ");
#nullable restore
#line 49 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                           Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </button>\r\n                                            <div class=\"dropdown-menu\">\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b64120bb05e15620fe35d3437eb75a7ce8d6823710532", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 52 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
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
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b64120bb05e15620fe35d3437eb75a7ce8d6823712827", async() => {
                        WriteLiteral("<i class=\"fas fa-download\"></i> ");
#nullable restore
#line 53 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                                                                                                                                       Write(Localizer["Download"]);

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
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 57 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                   Write(b.Date);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 58 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                   Write(b.department);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                   Write(b.title);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                                    <td>");
#nullable restore
#line 60 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                                   Write(b.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 62 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Gm\Views\GmAllDepatLawBook\GmAllDepatLawBook.cshtml"
                            } 

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n");
                    WriteLiteral("\r\n            ");
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
            WriteLiteral("\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n<!-- back to top button-->\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //-----------JS For Accounts Monthly /Yearly Reports--------------Start---------
        $(document).ready(function () {
            $('#MAReport').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //----------
        $(document).ready(function () {
            $('#YAReport').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    body {
        font-family: 'Jameel Noori Nastaleeq';
    }
    /*-----these clases is for Background  Account Office----*/
    .search-background {
        background: url('../Image/dust_scratches.png');
    }

    .backgroundWhite {
        background-color: white;
        padding: 30px;
        border-radius: 10px;
        margin-bottom: 30px;
    }

    .backgroundWhiteBorder {
        background-color: white;
        padding: 30px;
        border-radius: 10px;
        margin-bottom: 30px;
        border: 1px solid #ddd;
    }

    .backgroundWhiteBorder10Padding {
        background-color: white;
        padding: 10px;
        border-radius: 10px;
        border: 1px solid #ddd;
    }
    /* Css for Heading on every Sheet of ccount office----*/
    .header {
        overflow: hidden;
        padding: 10px 10px;
        font-size: 40px;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }
    /*  Css for Small Content Of Account");
            WriteLiteral(@"s----*/
    .smallfontHeading {
        font-size: medium;
    }
    /*//--CSS For Create button & Action Button of Each Page------start---------*/
    .Createbtn {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: large;
        text-align: right;
    }

    .actionbtn {
        width: 150px;
        text-align: center;
    }

    .titleAccountofficeReport {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: xx-large;
        font-weight: bold;
    }
    /*  Css for Table of Each in Accounts----*/
    .table {
        border-collapse: collapse;
        border-spacing: 0;
        border: 1px solid #ddd;
        table-layout: fixed;
        width: 100%
    }

    .Subhdr {
        color: white;
        text-align: center;
        background-color: slategrey;
    }
    /*  Css for small Size of Content----*/
    .SubH {
        text-align: center;
        font-family: 'Jameel Noori Nastaleeq';
        font-size: medium;
    }
    /* Css for");
            WriteLiteral(" Table Body on each page in Accounts----*/\r\n    .tabbody {\r\n        text-align: center;\r\n        color: black;\r\n    }\r\n</style>\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AJWManagementPortal.Models.LawBook>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
