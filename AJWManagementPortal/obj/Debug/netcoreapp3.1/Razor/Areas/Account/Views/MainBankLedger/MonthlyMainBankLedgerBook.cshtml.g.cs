#pragma checksum "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d910a78ce38e7335c8c3f4d42fe3948b4128710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_MainBankLedger_MonthlyMainBankLedgerBook), @"mvc.1.0.view", @"/Areas/Account/Views/MainBankLedger/MonthlyMainBankLedgerBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d910a78ce38e7335c8c3f4d42fe3948b4128710", @"/Areas/Account/Views/MainBankLedger/MonthlyMainBankLedgerBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Account/Views/_ViewImports.cshtml")]
    public class Areas_Account_Views_MainBankLedger_MonthlyMainBankLedgerBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AJWManagementPortal.Models.MeezanBankIEReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MainBankLedgerBookList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MainBankLedger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
  
    ViewData["Title"] = "DailyMainBankLedgerBook";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
  
    aDailyCash teswp = new aDailyCash();
    DateTime today = DateTime.Today;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d910a78ce38e7335c8c3f4d42fe3948b41287108000", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d910a78ce38e7335c8c3f4d42fe3948b41287108371", async() => {
                    WriteLiteral("\r\n                <div class=\"BackToList\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d910a78ce38e7335c8c3f4d42fe3948b41287108703", async() => {
                        WriteLiteral("<i class=\"fas fa-backward\"></i> ");
#nullable restore
#line 20 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
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
                <div class=""table-responsive-lg"">
                    <table class=""table table-bordered table-hover table-striped table-responsive-sm SubH"" id=""tblcustomers"">
                        <thead>
                            <tr class=""text-center"">
                                <th colspan=""29"">");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d910a78ce38e7335c8c3f4d42fe3948b412871011627", async() => {
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
                    WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"titleAccountofficeReport\" colspan=\"29\">");
#nullable restore
#line 32 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                                             Write(Localizer["Monthly Meezan Bank(Main Bank Account Ledger Book)-Account Office"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"text-left\" colspan=\"29\" id=\"date\"><span");
                    BeginWriteAttribute("class", " class=\"", 1773, "\"", 1781, 0);
                    EndWriteAttribute();
                    WriteLiteral("> ");
#nullable restore
#line 35 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                                                        Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(": </span> </th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"text-center\" colspan=\"2\">");
#nullable restore
#line 38 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                               Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th class=\"text-center\" colspan=\"4\">");
#nullable restore
#line 39 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                               Write(Localizer["Balance"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th class=\"text-center\" colspan=\"4\">");
#nullable restore
#line 40 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                               Write(Localizer["Credit"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th class=\"text-center\" colspan=\"4\">");
#nullable restore
#line 41 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                               Write(Localizer["Debit"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th class=\"text-center\" colspan=\"3\">");
#nullable restore
#line 42 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                               Write(Localizer["O-Online"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br>");
#nullable restore
#line 42 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                                                         Write(Localizer["D-Slip"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br>");
#nullable restore
#line 42 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                                                                                 Write(Localizer["Checq No"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th class=\"text-center\" scope=\"col\" colspan=\"6\">");
#nullable restore
#line 43 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                                           Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th class=\"text-center\" colspan=\"6\">");
#nullable restore
#line 44 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                               Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 51 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"4\">\r\n                                        ");
#nullable restore
#line 53 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                   Write(item.Balance);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </td>\r\n                                    <td colspan=\"4\">");
#nullable restore
#line 55 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                               Write(item.Cradit);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"4\">");
#nullable restore
#line 56 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                               Write(item.Debit);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"3\">");
#nullable restore
#line 57 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                               Write(item.CDO);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\r\n                                    <td colspan=\"6\">");
#nullable restore
#line 59 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"6\">");
#nullable restore
#line 60 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                               Write(item.ValueDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 62 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr id=""total"">
                                <th colspan=""2"" id=""t""></th>
                                <th colspan=""4"" id=""t1""></th>
                                <th colspan=""4"" id=""t2""></th>
                                <th colspan=""4"" id=""t3""></th>
                                <th colspan=""3"" id=""t4""></th>
                                <th colspan=""12"" id=""t5"">");
#nullable restore
#line 71 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                    Write(Localizer["Total"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" : </th>\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"29\"></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th colspan=\"29\">");
#nullable restore
#line 77 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                            Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\" colspan=\"10\">");
#nullable restore
#line 80 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                                        Write(Localizer["Account Manager"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"9\">");
#nullable restore
#line 81 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                           Write(Localizer["D.G.M"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                <th colspan=\"10\">");
#nullable restore
#line 82 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                                            Write(Localizer["G.M"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"10\">\r\n                                    ");
#nullable restore
#line 86 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                               Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <input type=\"text\" id=\"txtpmsign\" name=\"txtpmsign\"");
                    BeginWriteAttribute("value", " value=\"", 4862, "\"", 4889, 1);
#nullable restore
#line 87 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
WriteAttributeValue("", 4870, teswp.SignPManager, 4870, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" />\r\n                                    ");
#nullable restore
#line 88 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
                               Write(Localizer["Remarks"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                    <input type=\"text\" id=\"txtpmremarks\" name=\"txtpmremarks\"");
                    BeginWriteAttribute("value", " value=\"", 5068, "\"", 5098, 1);
#nullable restore
#line 89 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
WriteAttributeValue("", 5076, teswp.PManagerRemarks, 5076, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" />\r\n                                </td>\r\n                                <td colspan=\"9\">\r\n                                    <input hidden type=\"text\" id=\"txtgmsign\" name=\"txtgmsign\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 5328, "\"", 5349, 1);
#nullable restore
#line 92 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
WriteAttributeValue("", 5336, teswp.SignGM, 5336, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                    <input hidden type=\"text\" id=\"txtgmremarks\" name=\"txtgmremarks\"");
                    BeginWriteAttribute("value", " value=\"", 5454, "\"", 5478, 1);
#nullable restore
#line 93 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
WriteAttributeValue("", 5462, teswp.GMRemarks, 5462, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" />\r\n                                </td>\r\n                                <td colspan=\"10\">\r\n                                    <input hidden type=\"text\" id=\"txtceosign\" name=\"txtceosign\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 5711, "\"", 5733, 1);
#nullable restore
#line 96 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
WriteAttributeValue("", 5719, teswp.SignCeo, 5719, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                    <input hidden type=\"text\" id=\"txtceoremarks\" name=\"txtceoremarks\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 5861, "\"", 5886, 1);
#nullable restore
#line 97 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\MainBankLedger\MonthlyMainBankLedgerBook.cshtml"
WriteAttributeValue("", 5869, teswp.CeoRemarks, 5869, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                </td>
                            </tr>
                            <tr>
                                <td scope=""row"" colspan=""29"" class=""actionbtn"">
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-primary btn-sm btn-block form-control"" id=""btnMonthlyMainBankLedgerSave"" value=""Save""><i class=""fas fa-save""></i> Save</button>
                                    </div>
                                </td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            ");
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
                WriteLiteral("\r\n            <br />\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n<a id=\"button\"></a>\r\n\r\n");
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

        $(""body"").on(""click"", ""#btnMonthlyMainBankLedgerSave"", function () {

            var monthlyMainBankLedgerBookList = new Array();
            $(""#tblcustomers TBODY TR"").each(function () {
    ");
                WriteLiteral(@"            var txtpmsign = $(""#txtpmsign"");///
                var txtpmremarks = $(""#txtpmremarks"");///
                var txtgmsign = $(""#txtgmsign"");///
                var txtgmremarks = $(""#txtgmremarks"");///
                var txtceosign = $(""#txtceosign"");///
                var txtceoremarks = $(""#txtceoremarks"");///
                var row = $(this);
                var monthlyMainBankLedgerBook = {};

                monthlyMainBankLedgerBook.SignPManager = txtpmsign.val();///
                monthlyMainBankLedgerBook.PManagerRemarks = txtpmremarks.val();///
                monthlyMainBankLedgerBook.SignGM = txtgmsign.val();///
                monthlyMainBankLedgerBook.GMRemarks = txtgmremarks.val();///
                monthlyMainBankLedgerBook.SignCeo = txtceosign.val();///
                monthlyMainBankLedgerBook.CeoRemarks = txtceoremarks.val();///

                monthlyMainBankLedgerBook.MainBankDailyCashId = row.find(""TD"").eq(0).text();
                monthlyMainBankLedg");
                WriteLiteral(@"erBook.Balance = row.find(""TD"").eq(1).text().trim();
                monthlyMainBankLedgerBook.Credit = row.find(""TD"").eq(2).text();
                monthlyMainBankLedgerBook.Devit = row.find(""TD"").eq(3).text();
                monthlyMainBankLedgerBook.CDO = row.find(""TD"").eq(4).text();
                monthlyMainBankLedgerBook.Description = row.find(""TD"").eq(5).text();
                monthlyMainBankLedgerBook.DailyCashDate = row.find(""TD"").eq(6).text();
                monthlyMainBankLedgerBook.CreatedDate = new Date();

                monthlyMainBankLedgerBookList.push(monthlyMainBankLedgerBook);
            });

            $.ajax({
                type: ""POST"",
                url: ""/Account/MainBankLedger/InsertMonthlyGeneralLedgerBook"",
                data: { data: monthlyMainBankLedgerBookList },
                success: function (data) {

                    if (data === 1) {
                        alert(""Data save & update successfully!"");
                        window.locati");
                WriteLiteral(@"on.replace(""/Account/MainBankLedger/MainBankLedgerBookList"");
                    }
                    else if (data === 2) {
                        alert(""Data didn't save & update successfully!!"");
                        window.location.replace(""/Account/MainBankLedger/MainBankLedgerBookList"");
                    }
                }
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
    .");
            WriteLiteral(@"table {
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
    /*Mostly USes Css Classes userprofile/footer/backtolist/table/backtotopbtn/smallheading/subh/print --for Accounts Dep");
            WriteLiteral("artment- start*/\r\n    .Title {\r\n        font-size: xx-large;\r\n        font-family: \'Jameel Noori Nastaleeq\';\r\n        text-align: center;\r\n        color: black;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AJWManagementPortal.Models.MeezanBankIEReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
