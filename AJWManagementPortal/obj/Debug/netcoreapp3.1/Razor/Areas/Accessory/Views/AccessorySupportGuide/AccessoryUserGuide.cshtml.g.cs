#pragma checksum "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e634ab6cc0c4f40c90bd4dc4768114e407f8b49a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accessory_Views_AccessorySupportGuide_AccessoryUserGuide), @"mvc.1.0.view", @"/Areas/Accessory/Views/AccessorySupportGuide/AccessoryUserGuide.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e634ab6cc0c4f40c90bd4dc4768114e407f8b49a", @"/Areas/Accessory/Views/AccessorySupportGuide/AccessoryUserGuide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Accessory/Views/_ViewImports.cshtml")]
    public class Areas_Accessory_Views_AccessorySupportGuide_AccessoryUserGuide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
  
    ViewData["Title"] = "AccessoryUserGuide";
    Layout = "~/Views/Shared/_LayoutAccessory.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e634ab6cc0c4f40c90bd4dc4768114e407f8b49a4434", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e634ab6cc0c4f40c90bd4dc4768114e407f8b49a4696", async() => {
                    WriteLiteral(@"
        <div class=""container-fluid backgroundWhiteBorder10Padding AccessoryLUBook"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""portlet light"">
                    <div class=""portlet-body"">
                        <div class=""table-responsive"">
                            <div class=""titleLaw"">
                                <span class=""font-weight-bold"">");
#nullable restore
#line 25 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                                          Write(localizer["ACCESSORY DEPARTMENT SYSTEM USER GUIDE"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</span>
                            </div>
                            <br />
                            <div class=""PrintP"">
                                <button class=""btn btn-theme btn-print"" onclick=""myFunction()""> Print <i class=""fa fa-print"" aria-hidden=""true""></i></button>
                            </div>
                            <table class=""table table-bordered table-hover table-condensed table-sm SubH"">
                                <thead>
                                    <tr");
                    BeginWriteAttribute("class", " class=\"", 1599, "\"", 1607, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        <th>");
#nullable restore
#line 34 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th colspan=\"8\">");
#nullable restore
#line 35 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                                   Write(localizer["Action's Description"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th colspan=\"4\">");
#nullable restore
#line 36 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                                   Write(localizer["Function"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td> <span class=""en"">1</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 43 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["The Accounts Department is the industry's most important and autonomous department that is directly accountable to the C.E.O"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">2</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 51 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["The details of all (internal and external) transactions of the industry are with the Accounts Department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">3</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 59 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["There are two accounts used for expenses in the industry which have cash in them, one is industry account and the other is petty cash account"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">4</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 66 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["Petty Cash Account has a monthly balance of Rs. 15000 / - which has to be used for the whole month. This account is mostly used for daily expenses like tea, biscuits, ice and petrol"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">5</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 73 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["All the expenses of the industry will be borne from the industry account and the amount will be transferred from the main account (bank account of the industry) to the internal account of the industry"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">6</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 80 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["The voucher for issuing cash for any purchases made from the industry account will be first uploaded by the C.E.O"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">7</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 87 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["It is the responsibility of the Account Manager to arrange and secure the debit, credit voucher of Industry Account and Petty Cash Account"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">8</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 94 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["The salaries of all employees will be checked in their personal accounts. Salary amount will be required to be entered in the register of internal account of the industry, final pay slip will be made by the account office, general manager and C.E.O will check"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">9</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 101 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["All checks will be approved through Debit Voucher. Approval will be given by C.E.O. The check book will be in the account office"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">10</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 108 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["Debit voucher for expenditure from Main Account, Industry Internal Account, Petty Cash Account and Credit Voucher for refill will be used which will be approved by C.E.O"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">11</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 115 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["After completion of purchasing, all bills, cash vouchers and item orders have to be cleared by C.E.O"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">12</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 122 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["In case the C.E.O is busy or not present in the industry, the Account Manager will affix the Stamp of Telephone Approval on the Cash Voucher"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">13</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 130 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["It is the responsibility of the account manager to daily close and file the cash voucher, demand, purchase order and bill"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">14</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 138 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["Daily closing of account department is mandatory. It is also important to check the Daily C.E.O"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">15</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 146 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["Any income of any kind in the industry will first be deposited in the mandatory bank and then used, there will be credit in the main account register, credit voucher will also be made"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">16</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 154 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["Anyone who takes an advance from the work industry will get his first advance voucher, which will also include his previous advance, installment and salary. Advance will be given after uploading the voucher from C.E.O. There will be entry in advance ledger"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">17</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 162 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["If cash is included with the gate pass and service order then there will be a photocopy of the gate pass and service order, the original bill, gate pass and service order will be closed by the account manager in daily closing and the photocopy will be put in his file by the concerned department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">18</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 170 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["If cash is not included with the gate pass and service order, then the gate department and service order will be placed in the file only by the concerned department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">19</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 178 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["If you want to get the money back by returning the purchased product, it will become a gate pass, all the details will come on the gate pass, the product will be out of the industry at the gate pass and will be returned to the market Will come This amount has to be deposited in the bank's industry account on the same day to get the bank slip and this bank slip has to be credited in the register of Kerman account attached with the gate pass. The concerned department will attach a photocopy of the gate pass in its file"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">20</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 186 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["The Accounts Department will be responsible for any errors in the cash voucher or bill order. Which can be fined"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">21</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 194 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["If the material purchased from the suppliers with whom the account is to be made, then the entry of the bill must also be made in the ledger of the suppliers"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">22</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 202 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["Internal ledgers will be used for transactions within the industry, such as the sales income from the sales office will first go into the internal ledger and then go to the bank"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">23</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 210 "C:\Users\HP\source\repos\PB\AJWManagementPortal\Areas\Accessory\Views\AccessorySupportGuide\AccessoryUserGuide.cshtml"
                                       Write(localizer["The Account Manager will check the monthly and annual report with the C.E.O"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">24 </span> </td>
                                        <td colspan=""8"">
                                        </td>
                                        <td colspan=""4""></td>

                                    </tr>

                                </tbody>
                            </table>
                        </div>
                    </div>
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .AccessoryLUBook {
        text-align: right;
        text-align: justify;
        direction: rtl;
    }

    .titleLaw {
        text-align: left;
        font-weight: bold;
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
        margin-top: -50px;
    }

    /*page print css----*/
</style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
