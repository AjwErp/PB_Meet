#pragma checksum "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f5154c3c047deaab417ec4eb367a7a8e803fa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminPdfReport_AdminPdfReports), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminPdfReport/AdminPdfReports.cshtml")]
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
#line 1 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f5154c3c047deaab417ec4eb367a7a8e803fa2", @"/Areas/Admin/Views/AdminPdfReport/AdminPdfReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminPdfReport_AdminPdfReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileUploadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminPdfReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AjwLawBookPdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFileFromDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFileFromDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
  
    ViewData["Title"] = "AdminPdfReports";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f5154c3c047deaab417ec4eb367a7a8e803fa27841", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            <div class=\"header col-sm-12\">\r\n                <a class=\"logo font-weight-bold\">");
#nullable restore
#line 19 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                            Write(Localizer["Admin PDF Reports List"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </div>\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f5154c3c047deaab417ec4eb367a7a8e803fa28664", async() => {
                    WriteLiteral("\r\n\r\n            <hr />\r\n            <div class=\"col-sm-12 Createbtn\">\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f5154c3c047deaab417ec4eb367a7a8e803fa29023", async() => {
                        WriteLiteral("<i class=\"fas fa-plus\"> ");
#nullable restore
#line 26 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                                                                                                                                        Write(Localizer["Create New Ajw Law Book Pdf File"]);

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
                    WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div class=\"col-sm-12 text-center\">\r\n                <a class=\"titleAccountofficeReport\" scope=\"col\" colspan=\"10\">");
#nullable restore
#line 30 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                                                        Write(Localizer["Ajw Law Book Pdf Report List"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 33 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
             if (Model.FilesOnDatabase.Count == 0)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <p><b>System Note :No Law Book File Exist....</b></p>\r\n");
#nullable restore
#line 36 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("        <table class=\"table table-bordered\" id=\"DMBLBook\">\r\n            <thead>\r\n   \r\n            <tr class=\"Subhdr SubH\">\r\n                <th>");
#nullable restore
#line 43 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
               Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 44 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
               Write(Localizer["Created On"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 45 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
               Write(Localizer["File Type"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 46 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
               Write(Localizer["Department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 47 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
               Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 48 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
               Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n            </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 52 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                 foreach (var file in Model.FilesOnDatabase)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    <tr class=""SubH"">
                        <td class=""actionbtn"">
                            <div class=""btn-group"">
                                <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    ");
#nullable restore
#line 58 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                               Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </button>\r\n                                <div class=\"dropdown-menu\">\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f5154c3c047deaab417ec4eb367a7a8e803fa215493", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 61 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
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
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f5154c3c047deaab417ec4eb367a7a8e803fa217705", async() => {
                        WriteLiteral("<i class=\"fas fa-trash-alt\"></i> ");
#nullable restore
#line 62 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                                                                                                                                                                                       Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                                                                                                                                     WriteLiteral(file.Id);

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
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f5154c3c047deaab417ec4eb367a7a8e803fa221154", async() => {
                        WriteLiteral("<i class=\"fas fa-file-download\"></i> ");
#nullable restore
#line 63 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                                                                                                                                                                                             Write(Localizer["Download"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                                                                                                                                                       WriteLiteral(file.Id);

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
                    WriteLiteral("\r\n");
                    WriteLiteral("                                </div>\r\n                            </div>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 68 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                       Write(file.CreatedOn);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                       Write(file.FileType);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 70 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                       Write(file.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 71 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                       Write(file.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 72 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                       Write(file.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                </tbody>\r\n        </table>\r\n");
#nullable restore
#line 77 "E:\PB_Meet\AJWManagementPortal\Areas\Admin\Views\AdminPdfReport\AdminPdfReports.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n<!-- back to top button-->\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"    <script>
        $(document).ready(function () {
            $('#DMBLBook').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //---------
        $(document).ready(function () {
            $('#DPReport').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //---------
        $(document).ready(function () {
            $('#MPReport').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //---------
        $(document).ready(function () {
            $('#YPReport').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //-----------
        $(document).ready(function () {
            $('#APReport').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
                //------------
    </script>

");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    /* Css for Heading on every Sheet of ccount office----*/
    .header {
        overflow: hidden;
        padding: 10px 10px;
        font-size: 40px;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }
    /*//--CSS For Create button & Action Button of Each Page------start---------*/
    .Createbtn {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: large;
        text-align: right;
    }

    .SubH {
        text-align: center;
        font-family: 'Jameel Noori Nastaleeq';
        font-size: medium;
    }

    .actionbtn {
        width: 150px;
        text-align: center;
    }

    /*----Accounts All Daily Accounts Reportss--css--Start-------*/
    .AccountofficeReport {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: x-large;
    }

    .titleAccountofficeReport {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: xx-large;
        font-weight: bold;
    }

    .AccountReport {");
            WriteLiteral(@"
        text-align: center;
        background-color: dimgrey;
        color: white;
    }

    .TitleExp {
        color: white;
        background-color: slategray;
        font-size: xx-large;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }

    .thhead {
        height: 45px;
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

    /*---these clases is for Background------- */
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
        ");
            WriteLiteral(@"margin-bottom: 30px;
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

    body {
        font-family: 'Jameel Noori Nastaleeq';
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileUploadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
