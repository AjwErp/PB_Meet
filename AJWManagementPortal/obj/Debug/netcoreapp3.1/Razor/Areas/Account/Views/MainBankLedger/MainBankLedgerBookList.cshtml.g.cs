#pragma checksum "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa11ce248754645a622cd989894d1ae06432ab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_MainBankLedger_MainBankLedgerBookList), @"mvc.1.0.view", @"/Areas/Account/Views/MainBankLedger/MainBankLedgerBookList.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa11ce248754645a622cd989894d1ae06432ab1", @"/Areas/Account/Views/MainBankLedger/MainBankLedgerBookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Account/Views/_ViewImports.cshtml")]
    public class Areas_Account_Views_MainBankLedger_MainBankLedgerBookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AJWManagementPortal.Models.ViewModels.MainBankLedgerBookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MainBankLedger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MonthlyMainBankLedgerBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewMonthlyMainBankLedgerBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-hide", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearlyMainBankLedgerBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewYearlyMainBankLedgerBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tabled col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
  
    ViewData["Title"] = "MainBankLedgerBookList";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa11ce248754645a622cd989894d1ae06432ab17776", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            <div class=\"header col-sm-12\">\r\n                <br />\r\n                <a class=\"logo font-weight-bold font-weight-bolder\">");
#nullable restore
#line 15 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                               Write(Localizer["Main Bank Ledger Book Reports List"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </div>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa11ce248754645a622cd989894d1ae06432ab18689", async() => {
                    WriteLiteral("\r\n                <hr />\r\n                <div class=\"col-sm-12 Createbtn\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa11ce248754645a622cd989894d1ae06432ab19056", async() => {
                        WriteLiteral("<i class=\"fas fa-plus\"> ");
#nullable restore
#line 21 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                                                                                                                          Write(Localizer["Create New Monthly Main Bank Account Ledger"]);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</i> ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"col-sm-12 text-center\">\r\n                    <a class=\"titleAccountofficeReport\" scope=\"col\" colspan=\"10\">");
#nullable restore
#line 25 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                            Write(Localizer["Monthly Main Bank Account Ledger-Account Office"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                </div>\r\n                <br />\r\n                <table class=\"table table-bordered\" id=\"MMBLBook\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr SubH\">\r\n                            <th>");
#nullable restore
#line 31 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 32 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            <th>");
#nullable restore
#line 33 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 34 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                         foreach (var item in Model.MonthlyMainBankLedgerBook)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\" scope=\"col\">");
#nullable restore
#line 41 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                               Write(item.MainBankDailyCashId);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>
                                <td class=""actionbtn"">
                                    <div class=""btn-group"">
                                        <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            ");
#nullable restore
#line 45 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                       Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </button>\r\n                                        <div class=\"dropdown-menu\">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa11ce248754645a622cd989894d1ae06432ab115410", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 48 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                                                                                                                                                                                   Write(Localizer["View"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                                                                  WriteLiteral(item.MainBankDailyCashDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hide", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hide"] = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"text-center\" scope=\"col\">");
#nullable restore
#line 52 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                               Write(item.MainBankDailyCashDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                                <td class=\"text-center\" scope=\"col\">Monthly Main Bank Ledger report</td>\r\n                            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n                <hr />\r\n                <div class=\"col-sm-12 Createbtn\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa11ce248754645a622cd989894d1ae06432ab120216", async() => {
                        WriteLiteral("<i class=\"fas fa-plus\"> ");
#nullable restore
#line 61 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                                                                                                                         Write(Localizer["Create New Yearly Main Bank Account Ledger"]);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</i> ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"col-sm-12 text-center\">\r\n                    <a class=\"titleAccountofficeReport\" scope=\"col\" colspan=\"10\">");
#nullable restore
#line 65 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                            Write(Localizer["Yearly Main Bank Account Ledger-Account Office"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                </div>\r\n                <br />\r\n                <table class=\"table table-bordered\" id=\"YMBLBook\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr SubH\">\r\n                            <th>");
#nullable restore
#line 71 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 72 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            <th>");
#nullable restore
#line 73 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 74 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                           Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
#nullable restore
#line 79 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                         foreach (var item in Model.YearlyMainBankLedgerBook)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\" scope=\"col\">");
#nullable restore
#line 82 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                               Write(item.MainBankDailyCashId);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>
                                <td class=""actionbtn"">
                                    <div class=""btn-group"">
                                        <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            ");
#nullable restore
#line 86 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                       Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </button>\r\n                                        <div class=\"dropdown-menu\">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa11ce248754645a622cd989894d1ae06432ab126571", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 89 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                                                                                                                                                                                  Write(Localizer["View"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                                                                                 WriteLiteral(item.MainBankDailyCashDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hide", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hide"] = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"text-center\" scope=\"col\">");
#nullable restore
#line 93 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                                                               Write(item.MainBankDailyCashDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                                <td class=\"text-center\" scope=\"col\">Yearly Main Bank Ledger report</td>\r\n                            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\HP\source\repos\11-5-2022\PB_Meet\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MainBankLedgerBookList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
            WriteLiteral("\r\n<a id=\"button\"></a>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#DMBLBook').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });

        $(document).ready(function () {
            $('#MMBLBook').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });

        $(document).ready(function () {
            $('#YMBLBook').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<style>
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
    /*//--CSS For Create button & Action Button of Each Page------start---------*/
    .Createbtn {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: large;
        text-align: right;
    }

    .actionbtn {
        width: 150px;
        text-align: center");
            WriteLiteral(@";
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
    .Ba");
            WriteLiteral(@"ckToList {
        width: 150px;
    }

    .textarea {
        height: 60px;
    }
    /*Mostly USes Css Classes userprofile/footer/backtolist/table/backtotopbtn/smallheading/subh/print --for Accounts Department- start*/
    .Title {
        font-size: xx-large;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
        color: black;
    }
    /*  Css for Sub Heading of table----*/
    .Subhdr {
        color: white;
        text-align: center;
        background-color: slategrey;
    }
    /*  Css for Small Content Of Accounts----*/
    .smallfontHeading {
        font-size: medium;
    }
    /* Css for Table Body on each page in Accounts----*/
    .tabbody {
        text-align: center;
        color: black;
    }
    /* Css for Heading on every Sheet of ccount office----*/
    .header {
        overflow: hidden;
        padding: 10px 10px;
        font-size: 40px;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }
</");
            WriteLiteral("style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AJWManagementPortal.Models.ViewModels.MainBankLedgerBookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
