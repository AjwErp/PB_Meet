#pragma checksum "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c80a86b8cfe76e0f0a06e0ad0856885c6e7015aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_MonthlyInternalAccountLedger_MonthlyInternalAccountLedgerBookView), @"mvc.1.0.view", @"/Areas/Account/Views/MonthlyInternalAccountLedger/MonthlyInternalAccountLedgerBookView.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80a86b8cfe76e0f0a06e0ad0856885c6e7015aa", @"/Areas/Account/Views/MonthlyInternalAccountLedger/MonthlyInternalAccountLedgerBookView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Account/Views/_ViewImports.cshtml")]
    public class Areas_Account_Views_MonthlyInternalAccountLedger_MonthlyInternalAccountLedgerBookView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AJWManagementPortal.Models.MonthlyInternalAccountLedgerBook>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InternalAccountLedgerBookList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InternalAccountLedgers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
  
    ViewData["Title"] = "MonthlyInternalAccountLedgerBook";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";
    string ledgerId = @ViewBag.LedgerId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80a86b8cfe76e0f0a06e0ad0856885c6e7015aa7915", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80a86b8cfe76e0f0a06e0ad0856885c6e7015aa8286", async() => {
                    WriteLiteral("\r\n                <div class=\"BackToList\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80a86b8cfe76e0f0a06e0ad0856885c6e7015aa8618", async() => {
                        WriteLiteral("<i class=\"fas fa-backward\"></i> ");
#nullable restore
#line 17 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                                                                                                                                                                                  Write(Localizer["Back to List"]);

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
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                </div>
                <div class=""PrintP"">
                    <button class=""btn btn-theme btn-print"" onclick=""myFunction()""> Print <i class=""fa fa-print"" aria-hidden=""true""></i></button>
                </div>
                <div class=""table-responsive table-wrapper"">

                    <table class=""table table-striped table-hover table-bordered table-sm SubH"" id=""tblcustomers"">
                        <thead>
                            <tr>
                                <th colspan=""22"">");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c80a86b8cfe76e0f0a06e0ad0856885c6e7015aa11562", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"titleAccountofficeReport\" colspan=\"22\">");
#nullable restore
#line 30 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                                             Write(ViewBag.HeaderText);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n\r\n                            <tr><th colspan=\"22\" style=\"height:50px;\"></th></tr>\r\n\r\n                            <tr>\r\n                                <th class=\"text-left\" colspan=\"3\" id=\"date\"><span");
                    BeginWriteAttribute("class", " class=\"", 1782, "\"", 1790, 0);
                    EndWriteAttribute();
                    WriteLiteral("> ");
#nullable restore
#line 36 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                                                       Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(": </span> </th>\r\n                                <th colspan=\"16\" class=\"Title\">");
#nullable restore
#line 37 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                          Write(Localizer["Monthly "]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                                                Write(ViewBag.HeaderText);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"3\"></th>\r\n                            </tr>\r\n                            <tr><th colspan=\"22\"></th></tr>\r\n");
                    WriteLiteral("                            <tr>\r\n                                <th colspan=\"2\">");
#nullable restore
#line 49 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["Balance"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"2\">");
#nullable restore
#line 50 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["Credit(Rs)"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"2\">");
#nullable restore
#line 51 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["Debit(Rs)"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"2\">");
#nullable restore
#line 52 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["Check-No"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"6\">");
#nullable restore
#line 53 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"4\">");
#nullable restore
#line 54 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"2\">");
#nullable restore
#line 55 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 59 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 62 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.Balance);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 63 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.Credit);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 64 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.Devit);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 65 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.PreOrderCheckNo);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"6\">");
#nullable restore
#line 66 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"4\">");
#nullable restore
#line 67 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.DailyCashDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 68 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                               Write(item.DailyCashId);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 70 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr id=""total"">
                                <th colspan=""2"" id=""t""></th>
                                <th colspan=""2"" id=""t1""></th>
                                <th colspan=""2"" id=""t2""></th>
                                <th colspan=""2"" id=""t3""></th>
                                <th colspan=""2"" id=""t4""></th>
                                <th colspan=""12"" id=""t5"">");
#nullable restore
#line 79 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                    Write(Localizer["Total"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" : </th>\r\n                            </tr>\r\n\r\n");
                    WriteLiteral("                            <tr>\r\n                                <td colspan=\"22\"></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th colspan=\"22\">");
#nullable restore
#line 87 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                            Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\" colspan=\"7\">");
#nullable restore
#line 90 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                                       Write(Localizer["Account Manager"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"8\">");
#nullable restore
#line 91 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["D.G.M"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"7\">");
#nullable restore
#line 92 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                           Write(Localizer["G.M"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"7\">\r\n                                    ");
#nullable restore
#line 96 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                               Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n");
                    WriteLiteral("                                    <p>");
#nullable restore
#line 98 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                  Write(Model.FirstOrDefault().AMSignature);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                    ");
#nullable restore
#line 99 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                               Write(Localizer["Remarks"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <p>");
#nullable restore
#line 100 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                  Write(Model.FirstOrDefault().AMRemark);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                </td>\r\n                                <td colspan=\"8\">\r\n                                    ");
#nullable restore
#line 103 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                               Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <p>");
#nullable restore
#line 104 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                  Write(Model.FirstOrDefault().DGMSignature);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                    ");
#nullable restore
#line 105 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                               Write(Localizer["Remarks"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <p>");
#nullable restore
#line 106 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                  Write(Model.FirstOrDefault().DGMRemark);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                </td>\r\n                                <td colspan=\"7\">\r\n                                    ");
#nullable restore
#line 109 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                               Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <p>");
#nullable restore
#line 110 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                  Write(Model.FirstOrDefault().GMSignature);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                    ");
#nullable restore
#line 111 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                               Write(Localizer["Remarks"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <p>");
#nullable restore
#line 112 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MonthlyInternalAccountLedger\MonthlyInternalAccountLedgerBookView.cshtml"
                                  Write(Model.FirstOrDefault().GMRemark);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n                            \r\n                        </tfoot>\r\n                    </table>\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
            WriteLiteral("\r\n\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""body"").ready(function () {
            const monthNames = [""January"", ""February"", ""March"", ""April"", ""May"", ""June"",
                ""July"", ""August"", ""September"", ""October"", ""November"", ""December""
            ];
            const date = new Date();
            $(""#date"").text(monthNames[date.getMonth()].concat(""-"", date.getFullYear()));

            var credit = 0, debit = 0;
            $(""#tblcustomers TBODY TR"").each(function () {
                var row = $(this);

                credit += parseInt(row.find(""TD"").eq(2).text());
                debit += parseInt(row.find(""TD"").eq(3).text());
            });

            $(""#total #t2"").append(credit);
            $(""#total #t3"").append(debit);
            $(""#total #t5"").append(credit - debit);
        });


        var total = 0;
        $(""#paidAmount"").keyup(function () {
            total = 0;
            var paidAmount = $(""#paidAmount"").val();

            if (paidAmount != null && paidAmount != """"");
                WriteLiteral(@" && paidAmount != 0) {
                $(""#tblcustomers TBODY TR"").each(function () {
                    var row = $(this);

                    if (total == 0) {
                        total = Number(paidAmount);
                    }

                    const credit = row.find(""TD"").eq(2).text();
                    if (credit != 0) {
                        total = total + Number(credit);
                        row.find(""TD"").eq(1).text(total);
                    }
                    const devit = row.find(""TD"").eq(3).text();
                    if (devit != 0) {
                        total = total - Number(devit);
                        row.find(""TD"").eq(1).text(total);
                    }
                });
            }
        });

        $(""body"").on(""click"", ""#btnMonthlyInternalAccountLedgerSave"", function () {

            var monthlyInternalAccountLedgerList = new Array();
            $(""#tblcustomers TBODY TR"").each(function () {
                var AMSignatu");
                WriteLiteral(@"re = $(""#AMSignature"");///
                var AMRemark = $(""#AMRemark"");///
                var DGMSignature = $(""#DGMSignature"");///
                var DGMRemark = $(""#DGMRemark"");///
                var GMSignature = $(""#GMSignature"");///
                var GMRemark = $(""#GMRemark"");///
                var row = $(this);
                var monthlyInternalAccountLedgerBook = {};

                monthlyInternalAccountLedgerBook.AMSignature = AMSignature.val();///
                monthlyInternalAccountLedgerBook.AMRemark = AMRemark.val();///
                monthlyInternalAccountLedgerBook.DGMSignature = DGMSignature.val();///
                monthlyInternalAccountLedgerBook.DGMRemark = DGMRemark.val();///
                monthlyInternalAccountLedgerBook.GMSignature = GMSignature.val();///
                monthlyInternalAccountLedgerBook.GMRemark = GMRemark.val();///

                monthlyInternalAccountLedgerBook.Balance = row.find(""TD"").eq(1).text().trim();
                monthlyInte");
                WriteLiteral(@"rnalAccountLedgerBook.Credit = row.find(""TD"").eq(2).text();
                monthlyInternalAccountLedgerBook.Devit = row.find(""TD"").eq(3).text();
                monthlyInternalAccountLedgerBook.PreOrderCheckNo = row.find(""TD"").eq(4).text();
                monthlyInternalAccountLedgerBook.Description = row.find(""TD"").eq(5).text();
                monthlyInternalAccountLedgerBook.DailyCashDate = row.find(""TD"").eq(6).text();
                monthlyInternalAccountLedgerBook.DailyCashId = row.find(""TD"").eq(7).text();
                monthlyInternalAccountLedgerBook.CreatedDate = new Date();

                monthlyInternalAccountLedgerList.push(monthlyInternalAccountLedgerBook);
            });

            //Send the JSON array to Controller using AJAX.
            $.ajax({
                type: ""POST"",
                url: ""/Account/MonthlyInternalAccountLedger/InsertMonthlyInternalAccountLedgerBook"",
                data: { data: monthlyInternalAccountLedgerList },
                success: fun");
                WriteLiteral(@"ction (data) {

                    if (data === 1) {
                        alert(""Data save & update successfully!"");
                        window.location.replace(""/Account/InternalAccountLedgers/InternalAccountLedgerBookList"");
                    }
                    else if (data === 2) {
                        alert(""Data didn't save & update successfully!!"");
                        window.location.replace(""/Account/InternalAccountLedgers/InternalAccountLedgerBookList"");
                    }
                }
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
    .ta");
            WriteLiteral(@"ble {
        border-collapse: collapse;
        border-spacing: 0;
        border: 1px solid #ddd;
        table-layout: fixed;
        width: 100%
    }
    /*  Css for small Size of Content----*/
    .SubH {
        text-align: center;
        font-family: 'Jameel Noori Nastaleeq';
        font-size: medium;
    }
    /*page print css----*/
    .btn-theme {
        background: #08818c;
        color: #fff;
    }

    .btn {
        font-family: arial;
    }

    .btn-print {
        padding: 10px 24px;
        font-size: 16px;
        line-height: 1.33;
        vertical-align: middle;
        float: left;
    }

    .PrintP {
        margin-left: 985px;
        position: absolute;
        margin-top: -45px;
    }
    /*  Css for BackToList Button----*/
    .BackToList {
        width: 150px;
    }

    .textarea {
        height: 60px;
    }
    /*Mostly USes Css Classes userprofile/footer/backtolist/table/backtotopbtn/smallheading/subh/print --for Accounts Depar");
            WriteLiteral("tment- start*/\r\n    .Title {\r\n        font-size: xx-large;\r\n        font-family: \'Jameel Noori Nastaleeq\';\r\n        text-align: center;\r\n        color: black;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AJWManagementPortal.Models.MonthlyInternalAccountLedgerBook>> Html { get; private set; }
    }
}
#pragma warning restore 1591