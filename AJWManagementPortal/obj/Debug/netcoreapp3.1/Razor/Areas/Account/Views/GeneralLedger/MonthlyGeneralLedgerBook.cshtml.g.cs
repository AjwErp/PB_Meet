#pragma checksum "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd8927dbd37062ac824360941fed2cdc6d478a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_GeneralLedger_MonthlyGeneralLedgerBook), @"mvc.1.0.view", @"/Areas/Account/Views/GeneralLedger/MonthlyGeneralLedgerBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd8927dbd37062ac824360941fed2cdc6d478a76", @"/Areas/Account/Views/GeneralLedger/MonthlyGeneralLedgerBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Account/Views/_ViewImports.cshtml")]
    public class Areas_Account_Views_GeneralLedger_MonthlyGeneralLedgerBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AJWManagementPortal.Models.TransAndBank>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GeneralLedgerBookList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GeneralLedger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
  
    ViewData["Title"] = "MonthlyGeneralLedgerBook";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
  
    var Balance = 0.00;

    aDailyCash teswp = new aDailyCash();
    DateTime today = DateTime.Today;
    if (Model.date != null)
    {
        today = Model.date;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd8927dbd37062ac824360941fed2cdc6d478a768136", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd8927dbd37062ac824360941fed2cdc6d478a768542", async() => {
                    WriteLiteral("\r\n                <div class=\"BackToList\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd8927dbd37062ac824360941fed2cdc6d478a768874", async() => {
                        WriteLiteral("<i class=\"fas fa-backward\"></i> ");
#nullable restore
#line 33 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
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

                <table class=""table table-bordered table-hover table-striped table-responsive-sm SubH"" id=""tblcustomers"">
                    <thead>
                        <tr class=""text-center"">
                            <th colspan=""29"">");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd8927dbd37062ac824360941fed2cdc6d478a7611727", async() => {
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
                    WriteLiteral("</th>\r\n                        </tr>\r\n                        <tr>\r\n                            <th class=\"titleAccountofficeReport\" colspan=\"29\">");
#nullable restore
#line 45 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                                         Write(Localizer["Monthly General Ledger Report-Account Office"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                        </tr>\r\n                        <tr>\r\n                            <th class=\"text-left\" colspan=\"29\" id=\"date\"><span");
                    BeginWriteAttribute("class", " class=\"", 2211, "\"", 2219, 0);
                    EndWriteAttribute();
                    WriteLiteral("> ");
#nullable restore
#line 48 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                                                    Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(": </span> </th>\r\n                        </tr>\r\n                        <tr>\r\n                            <th class=\"text-center\" colspan=\"2\">");
#nullable restore
#line 51 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" colspan=\"3\">");
#nullable restore
#line 52 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                           Write(Localizer["Balance"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" colspan=\"3\">");
#nullable restore
#line 53 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                           Write(Localizer["Credit"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" colspan=\"3\">");
#nullable restore
#line 54 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                           Write(Localizer["Debit"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" colspan=\"2\">");
#nullable restore
#line 55 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                           Write(Localizer["P-Order"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br>");
#nullable restore
#line 55 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                                                    Write(Localizer["Checq-No"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" scope=\"col\" colspan=\"5\">");
#nullable restore
#line 56 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                                       Write(Localizer["Ledger Type"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" scope=\"col\" colspan=\"5\">");
#nullable restore
#line 57 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                                       Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th class=\"text-center\" colspan=\"6\">");
#nullable restore
#line 58 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 62 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                         foreach (var item in Model.aDailyCashes)
                        {
                            teswp.ValueDate = @item.ValueDate;
                            teswp.Remarks = @item.Remarks;
                            teswp.SignPManager = @item.SignPManager;
                            teswp.PManagerRemarks = @item.PManagerRemarks;
                            teswp.SignGM = item.SignGM;
                            teswp.GMRemarks = @item.GMRemarks;
                            teswp.SignCeo = @item.SignCeo;
                            teswp.CeoRemarks = @item.CeoRemarks;

                            if (item.clearedAmount != 0 || item.income != 0 /*item.ValueDate == today*/)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 76 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"3\">\r\n");
#nullable restore
#line 78 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                          
                                            Balance += item.income - item.clearedAmount;
                                        

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        ");
#nullable restore
#line 81 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                   Write(Balance);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </td>\r\n                                    <td colspan=\"3\">");
#nullable restore
#line 83 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                               Write(item.clearedAmount);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"3\">");
#nullable restore
#line 84 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                               Write(item.income);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"2\">");
#nullable restore
#line 85 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                               Write(item.pOrder);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"5\">\r\n");
                    WriteLiteral("                                        ");
#nullable restore
#line 88 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                   Write(Html.DropDownList("LedgerType", ViewBag.LedgerType as SelectList, new { @style = "text-align: center;width: 165px;height: 30px;font-size:medium" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n");
                    WriteLiteral("                                    </td>\r\n                                    <td colspan=\"5\">");
#nullable restore
#line 140 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td colspan=\"6\">");
#nullable restore
#line 141 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                               Write(item.ValueDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 143 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </tbody>
                    <tfoot>
                        <tr id=""total"">
                            <th colspan=""2"" id=""t""></th>
                            <th colspan=""3"" id=""t1""></th>
                            <th colspan=""3"" id=""t2""></th>
                            <th colspan=""3"" id=""t3""></th>
                            <th colspan=""2"" id=""t4""></th>
                            <th colspan=""16"" id=""t5"">");
#nullable restore
#line 153 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                Write(Localizer["Total"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" : </th>\r\n                        </tr>\r\n                        <tr>\r\n                            <td colspan=\"29\"></td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th colspan=\"29\">");
#nullable restore
#line 159 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                        Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\" colspan=\"10\">");
#nullable restore
#line 162 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                                    Write(Localizer["Account Manager"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th colspan=\"9\">");
#nullable restore
#line 163 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                       Write(Localizer["D.G.M"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th colspan=\"10\">");
#nullable restore
#line 164 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                                        Write(Localizer["G.M"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                        <tr>\r\n                            <td colspan=\"10\">\r\n                                ");
#nullable restore
#line 168 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                           Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                <input type=\"text\" id=\"txtpmsign\" name=\"txtpmsign\"");
                    BeginWriteAttribute("value", " value=\"", 11863, "\"", 11890, 1);
#nullable restore
#line 169 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
WriteAttributeValue("", 11871, teswp.SignPManager, 11871, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" />\r\n                                ");
#nullable restore
#line 170 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
                           Write(Localizer["Remarks"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(":\r\n                                <input type=\"text\" id=\"txtpmremarks\" name=\"txtpmremarks\"");
                    BeginWriteAttribute("value", " value=\"", 12061, "\"", 12091, 1);
#nullable restore
#line 171 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
WriteAttributeValue("", 12069, teswp.PManagerRemarks, 12069, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" />\r\n                            </td>\r\n                            <td colspan=\"9\">\r\n");
                    WriteLiteral("                                <input hidden type=\"text\" id=\"txtgmsign\" name=\"txtgmsign\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 12465, "\"", 12486, 1);
#nullable restore
#line 177 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
WriteAttributeValue("", 12473, teswp.SignGM, 12473, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
                    WriteLiteral("                                <input hidden type=\"text\" id=\"txtgmremarks\" name=\"txtgmremarks\"");
                    BeginWriteAttribute("value", " value=\"", 12647, "\"", 12671, 1);
#nullable restore
#line 179 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
WriteAttributeValue("", 12655, teswp.GMRemarks, 12655, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" />\r\n\r\n");
                    WriteLiteral("                            </td>\r\n                            <td colspan=\"10\">\r\n");
                    WriteLiteral("                                <input hidden type=\"text\" id=\"txtceosign\" name=\"txtceosign\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 13612, "\"", 13634, 1);
#nullable restore
#line 194 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
WriteAttributeValue("", 13620, teswp.SignCeo, 13620, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
                    WriteLiteral("                                <input hidden type=\"text\" id=\"txtceoremarks\" name=\"txtceoremarks\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 13818, "\"", 13843, 1);
#nullable restore
#line 196 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Account\Views\GeneralLedger\MonthlyGeneralLedgerBook.cshtml"
WriteAttributeValue("", 13826, teswp.CeoRemarks, 13826, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n");
                    WriteLiteral("                            </td>\r\n                        </tr>\r\n\r\n");
                    WriteLiteral("                        <tr>\r\n");
                    WriteLiteral(@"                            <td scope=""row"" colspan=""29"" class=""actionbtn"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-primary btn-sm btn-block form-control"" id=""btnManthlyLedgerSave"" value=""Save""><i class=""fas fa-save""></i> Save</button>
");
                    WriteLiteral("                                </div>\r\n                            </td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n            ");
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
            WriteLiteral("\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n");
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

        //$('#btnManthlyLedgerSave').click(function () {
        //    $('table tr').each(function () {
        //        var row = $(this);
        //        var text = $('table tr:eq(' + row + ') selec");
                WriteLiteral(@"t option:selected').eq(4).text();
        //        alert(text);

        //    });
        //});

        $(""body"").on(""click"", ""#btnManthlyLedgerSave"", function () {

            var monthlyGeneralLedgerBookList = new Array();
            $(""#tblcustomers TBODY TR"").each(function () {
                var txtpmsign = $(""#txtpmsign"");///
                var txtpmremarks = $(""#txtpmremarks"");///
                var txtgmsign = $(""#txtgmsign"");///
                var txtgmremarks = $(""#txtgmremarks"");///
                var txtceosign = $(""#txtceosign"");///
                var txtceoremarks = $(""#txtceoremarks"");///
                var row = $(this);
                var monthlyGeneralLedgerBook = {};

                monthlyGeneralLedgerBook.SignPManager = txtpmsign.val();///
                monthlyGeneralLedgerBook.PManagerRemarks = txtpmremarks.val();///
                monthlyGeneralLedgerBook.SignGM = txtgmsign.val();///
                monthlyGeneralLedgerBook.GMRemarks = txtgmremarks");
                WriteLiteral(@".val();///
                monthlyGeneralLedgerBook.SignCeo = txtceosign.val();///
                monthlyGeneralLedgerBook.CeoRemarks = txtceoremarks.val();///

                monthlyGeneralLedgerBook.DailyCashId = row.find(""TD"").eq(0).text();
                monthlyGeneralLedgerBook.Balance = row.find(""TD"").eq(1).text().trim();
                monthlyGeneralLedgerBook.Credit = row.find(""TD"").eq(2).text();
                monthlyGeneralLedgerBook.Devit = row.find(""TD"").eq(3).text();
                monthlyGeneralLedgerBook.PreOrderCheckNo = row.find(""TD"").eq(4).text();
                monthlyGeneralLedgerBook.LedgerType = row.find(""td:eq(5) select option:selected"").text();
                monthlyGeneralLedgerBook.Description = row.find(""TD"").eq(6).text();
                monthlyGeneralLedgerBook.DailyCashDate = row.find(""TD"").eq(7).text();
                monthlyGeneralLedgerBook.CreatedDate = new Date();

                monthlyGeneralLedgerBookList.push(monthlyGeneralLedgerBook);
          ");
                WriteLiteral(@"  });

            //Send the JSON array to Controller using AJAX.
            $.ajax({
                type: ""POST"",
                url: ""/Account/GeneralLedger/InsertMonthlyGeneralLedgerBook"",
                data: { data: monthlyGeneralLedgerBookList },
                success: function (data) {

                    if (data === 1) {
                        alert(""Data save & update successfully!"");
                        window.location.replace(""/Account/GeneralLedger/GeneralLedgerBookList"");
                    }
                    else if (data === 2) {
                        alert(""Data didn't save & update successfully!!"");
                        window.location.replace(""/Account/GeneralLedger/GeneralLedgerBookList"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AJWManagementPortal.Models.TransAndBank> Html { get; private set; }
    }
}
#pragma warning restore 1591
