#pragma checksum "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ea7ab6c9e0568870876963e7d82da7c4e34070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_AccountReportPdf_AuditReportPdf), @"mvc.1.0.view", @"/Areas/Account/Views/AccountReportPdf/AuditReportPdf.cshtml")]
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
#line 1 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ea7ab6c9e0568870876963e7d82da7c4e34070", @"/Areas/Account/Views/AccountReportPdf/AuditReportPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Account/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Account_Views_AccountReportPdf_AuditReportPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AccountsPdfReports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountReportPdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm fas fa-step-backward"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Back To List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
  
    ViewData["Title"] = "AuditReportPdf";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ea7ab6c9e0568870876963e7d82da7c4e340706701", async() => {
                WriteLiteral("\r\n    <div class=\"container backgroundWhiteBorder10Padding\">\r\n        <div style=\"direction:rtl\" class=\"row text-right text-justify\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ea7ab6c9e0568870876963e7d82da7c4e340707114", async() => {
                    WriteLiteral(@"
                <div class=""portlet light"">
                    <br />
                    <div class=""portlet-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered table-hover table-condensed"">
                                <thead>
                                    <tr class=""bg-secondary text-white"">
                                        <th class=""text-center"" style=""font-size:xx-large"" colspan=""6"">");
#nullable restore
#line 27 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                                                                                  Write(localizer["Upload Audit Accounts Pdf Reports"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td colspan=""6"" class=""text-center"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control text-left """);
                    BeginWriteAttribute("placeholder", " placeholder=\"", 1809, "\"", 1874, 1);
#nullable restore
#line 34 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
WriteAttributeValue("", 1823, localizer["Enter File Name i.e   DailyReport.pdf"], 1823, 51, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text Signrow"" id=""basic-addon2"">");
#nullable restore
#line 36 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                                                                                        Write(localizer["File Name"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"  </span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""6"" class=""text-center"">

                                            <div class=""input-group "">
                                                <input type=""text"" class=""form-control text-left""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 2658, "\"", 2718, 1);
#nullable restore
#line 45 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
WriteAttributeValue("", 2672, localizer["Enter File Type i.e Daily Report"], 2672, 46, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text Signrow"" id=""basic-addon2"">");
#nullable restore
#line 47 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                                                                                        Write(localizer["File Type"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" </span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <th colspan=""6"" class=""Title"">
                                            <a>");
#nullable restore
#line 54 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                          Write(localizer["Select Pdf File"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"  </a>
                                        </th>
                                    </tr>
                                    <tr>
                                        <td colspan=""6"">
                                            <div class=""input-group "">
                                                <div class=""input-group-append"">
                                                    <input type=""file"" class=""form-control-file form-control-sm""");
                    BeginWriteAttribute("id", " id=\"", 3864, "\"", 3869, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""6"" class=""text-center"">

                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control text-left """);
                    BeginWriteAttribute("placeholder", " placeholder=\"", 4362, "\"", 4437, 2);
#nullable restore
#line 70 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
WriteAttributeValue("", 4376, localizer["Enter File Path i.e"], 4376, 33, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("  ", 4409, "C\\:Reports\\DailyReport.pdf", 4411, 28, true);
                    EndWriteAttribute();
                    WriteLiteral(@" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text Signrow"" id=""basic-addon2"">");
#nullable restore
#line 72 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                                                                                        Write(localizer["File Path"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"  </span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""6"" class=""text-center"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control text-left""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 5218, "\"", 5272, 1);
#nullable restore
#line 80 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
WriteAttributeValue("", 5232, localizer["Enter File Size i.e 400 KB"], 5232, 40, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text Signrow"" id=""basic-addon2"">");
#nullable restore
#line 82 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                                                                                        Write(localizer["File Size"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"  </span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""6"" class=""text-lg-center"">
                                            <input type=""button"" class=""btn btn-primary btn-sm fas fa-save""");
                    BeginWriteAttribute("value", " value=\"", 5995, "\"", 6026, 1);
#nullable restore
#line 89 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
WriteAttributeValue("", 6003, localizer["Save File"], 6003, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ea7ab6c9e0568870876963e7d82da7c4e3407017383", async() => {
#nullable restore
#line 90 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\AccountReportPdf\AuditReportPdf.cshtml"
                                                                                                                                                                                                                      Write(localizer["Back To List"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
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
    /*  Css for Table of Each in Accounts----*/
    .table {
        border-collapse: collapse;
        border-spacing: 0;
        border: 1px solid #ddd;
        table-layout: fixed;
        width: 100%
    }
    /*  Css for Signature Title on Each Sheet In Accounts----*/
    .Signrow {
        text-align: center;
        font-size: ");
            WriteLiteral(@"x-large;
        font-family: 'Jameel Noori Nastaleeq';
        background-color: slategrey;
        color: white;
    }
    /*---Css for Title-----*/
    .Title {
        font-size: xx-large;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
        color: black;
    }
    body {
        font-family: 'Jameel Noori Nastaleeq';
    }
</style>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
