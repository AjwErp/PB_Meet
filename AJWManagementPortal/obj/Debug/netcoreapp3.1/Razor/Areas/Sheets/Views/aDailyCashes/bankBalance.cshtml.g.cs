<<<<<<< HEAD
#pragma checksum "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6add1d3182d4f769da7e43d34d14850877d8d78"
=======
#pragma checksum "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6add1d3182d4f769da7e43d34d14850877d8d78"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Sheets_Views_aDailyCashes_bankBalance), @"mvc.1.0.view", @"/Areas/Sheets/Views/aDailyCashes/bankBalance.cshtml")]
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
<<<<<<< HEAD
#line 1 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\_ViewImports.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6add1d3182d4f769da7e43d34d14850877d8d78", @"/Areas/Sheets/Views/aDailyCashes/bankBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca5be9881ec0fab41b35a3fb151406f6fd5faf2", @"/Areas/Sheets/Views/_ViewImports.cshtml")]
    public class Areas_Sheets_Views_aDailyCashes_bankBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AJWManagementPortal.Models.TransAndBank>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 2 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 2 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
  
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    td {
        overflow: hidden;
    }
</style>

    <table id=""tblcustomers"" class=""display""  border=""1"" width=""100%"" style='table-layout:fixed' >
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Description
                </th>
                <th>
                    ValueDate
                </th>
                <th>
                    clearedAmount
                </th>
                <th>
                    paidAmount
                </th>
                <th>
                    lnClearedAmount
                </th>
                <th>
                    remainingGained
                </th>
                <th>
                    surplus
                </th>
                <th>
                    purchaser
                </th>
                <th>
                    income
                </th>
                <th></th>
            </tr>
       ");
            WriteLiteral(" </thead>\r\n        <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 49 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 49 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
             foreach (var item in Model.aDailyCashes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 53 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 53 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 56 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 56 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 59 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 59 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.ValueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 62 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 62 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.clearedAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 65 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 65 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.paidAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 68 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 68 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.lnClearedAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 71 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 71 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.remainingGained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 74 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 74 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.surplus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 77 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 77 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.purchaser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 80 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 80 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                   Write(Html.DisplayFor(modelItem => item.income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6add1d3182d4f769da7e43d34d14850877d8d789121", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6add1d3182d4f769da7e43d34d14850877d8d789569", async() => {
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 83 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 83 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6add1d3182d4f769da7e43d34d14850877d8d7811304", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6add1d3182d4f769da7e43d34d14850877d8d7811784", async() => {
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 84 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 84 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6add1d3182d4f769da7e43d34d14850877d8d7813494", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6add1d3182d4f769da7e43d34d14850877d8d7814006", async() => {
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 85 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 85 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td><input type=\"button\" value=\"Remove\" onclick=\"Remove(this)\" /></td>\r\n                </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 89 "E:\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
=======
#line 89 "C:\Users\shabahat.ali\source\repos\PB_Meet\AJWManagementPortal\Areas\Sheets\Views\aDailyCashes\bankBalance.cshtml"
>>>>>>> 93096072432d40920c8e9827977cd7a60e397997
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </tbody>
        <tfoot>
            <tr>
                <th><input type=""text"" id=""txtName"" /></th>
                <th><input type=""text"" id=""txtDesc"" /></th>
                <th><input type=""text"" id=""txtDate"" /></th>
                <th><input type=""text"" id=""clearedAmount"" /></th>
                <th><input type=""text"" id=""paidAmount"" /></th>
                <th><input type=""text"" id=""lnClearedAmount"" /></th>
                <th><input type=""text"" id=""remainingGained"" /></th>
                <th><input type=""text"" id=""surplus"" /></th>
                <th><input type=""text"" id=""purchaser"" /></th>
                <th><input type=""text"" id=""income"" /></th>
                <th><input type=""button"" id=""btnAdd"" value=""Add"" /></th>
            </tr>
        </tfoot>
    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AJWManagementPortal.Models.TransAndBank> Html { get; private set; }
    }
}
#pragma warning restore 1591
