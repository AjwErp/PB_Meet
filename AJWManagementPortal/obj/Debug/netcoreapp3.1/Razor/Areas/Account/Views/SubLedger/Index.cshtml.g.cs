#pragma checksum "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b68a97531a0bb69f80a439a9a00242b11cbe709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_SubLedger_Index), @"mvc.1.0.view", @"/Areas/Account/Views/SubLedger/Index.cshtml")]
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
#line 1 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b68a97531a0bb69f80a439a9a00242b11cbe709", @"/Areas/Account/Views/SubLedger/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Account/Views/_ViewImports.cshtml")]
    public class Areas_Account_Views_SubLedger_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SubLedger>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartialSubLedger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartialSubLedger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"border backgroundWhite\">\r\n    <div class=\"row\">\r\n");
            WriteLiteral("<div class=\"col-12 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b68a97531a0bb69f80a439a9a00242b11cbe7094296", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-12 text-center\">\r\n        <h2 class=\"text-info\">Accounts Sub Ledger List</h2>\r\n    </div>\r\n");
            WriteLiteral("</div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 35 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Ledger.LedgerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Ledger.LedgerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b68a97531a0bb69f80a439a9a00242b11cbe7097832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 58 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 61 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 63 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No Sub Category exists...</p>\r\n");
#nullable restore
#line 67 "D:\FinalProject\AJWManagementPortal\Areas\Account\Views\SubLedger\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<style>\r\n</style>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SubLedger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
