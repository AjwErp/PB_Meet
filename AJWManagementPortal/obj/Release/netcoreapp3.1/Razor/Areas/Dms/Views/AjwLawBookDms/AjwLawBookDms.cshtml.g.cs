#pragma checksum "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbda686413aeab2511a92b28a39419e797bb2c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dms_Views_AjwLawBookDms_AjwLawBookDms), @"mvc.1.0.view", @"/Areas/Dms/Views/AjwLawBookDms/AjwLawBookDms.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbda686413aeab2511a92b28a39419e797bb2c19", @"/Areas/Dms/Views/AjwLawBookDms/AjwLawBookDms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Dms/Views/_ViewImports.cshtml")]
    public class Areas_Dms_Views_AjwLawBookDms_AjwLawBookDms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileUploadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Dms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AjwLawBookDms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFileFromDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFileFromDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tabled col-sm-12 formDgmofficeReport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
  
    ViewData["Title"] = "AccountsPdfReports";
    Layout = "~/Views/Shared/_LayoutDms.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda686413aeab2511a92b28a39419e797bb2c196938", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder \">\r\n        <div class=\"row\">\r\n            <div class=\"header col-sm-12\">\r\n\r\n                <a class=\"logo font-weight-bold font-weight-bolder\">");
#nullable restore
#line 22 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                                                               Write(Localizer["AJW LAW BOOK D.M.S LIST"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </div>\r\n\r\n");
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda686413aeab2511a92b28a39419e797bb2c197825", async() => {
                    WriteLiteral("\r\n\r\n");
                    WriteLiteral("                <hr />\r\n");
                    WriteLiteral("                <br />\r\n");
#nullable restore
#line 39 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                    if (Model.FilesOnDatabaseDms.Count == 0)
                   {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <caption>No File Exist....</caption>\r\n");
#nullable restore
#line 42 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                   }
                   else
                   {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <table class=\"table table-bordered\" id=\"AJwLawBookDms\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr\">\r\n                            <th>");
#nullable restore
#line 48 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(Localizer["Actions"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 49 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(Localizer["Created On"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 50 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(Localizer["File Type"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 51 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(Localizer["Department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 52 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 53 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                         foreach (var file in Model.FilesOnDatabaseDms)
                        { 

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        <tr class=""SubH"">
                            <td class=""actionbtn"">
                                <div class=""btn-group"">
                                    <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        ");
#nullable restore
#line 63 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                                   Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </button>\r\n                                    <div class=\"dropdown-menu\">\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda686413aeab2511a92b28a39419e797bb2c1912231", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 66 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
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
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda686413aeab2511a92b28a39419e797bb2c1914467", async() => {
                        WriteLiteral("<i class=\"fas fa-trash-alt\"></i> ");
#nullable restore
#line 67 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                                                                                                                                                                                                       Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
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
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbda686413aeab2511a92b28a39419e797bb2c1917954", async() => {
                        WriteLiteral("<i class=\"fas fa-download\"></i> ");
#nullable restore
#line 68 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                                                                                                                                                                                                        Write(Localizer["Download"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
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
                    WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(file.CreatedOn);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(file.FileType);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 74 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(file.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 75 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(file.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("  <i class=\"fas fa-file-pdf\"></i> </td>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                           Write(file.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 81 "C:\Users\HP\source\repos\PB_Meet\AJWManagementPortal\Areas\Dms\Views\AjwLawBookDms\AjwLawBookDms.cshtml"
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
            WriteLiteral("\r\n<a id=\"button\"></a>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n\r\n        $(document).ready(function () {\r\n            $(\'#AJwLawBookDms\').DataTable({\r\n                \"sPaginationType\": \"full_numbers\"\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .TitleDgmOfficeReport {
        color: white;
        font-size: xx-large;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
        font-weight: bold;
    }


    .table {
        border-collapse: collapse;
        border-spacing: 0;
        border: 1px solid #ddd;
        table-layout: fixed;
        width: 100%
    }

    .DgmLUBook {
        text-align: right;
        text-align: justify;
        direction: rtl;
    }

    .titleLaw {
        text-align: left;
        font-weight: bold;
    }

    .titleDgmRepositoryReport {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: xx-large;
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
        float: lef");
            WriteLiteral(@"t;
    }

    .PrintP {
        margin-left: 985px;
        position: absolute;
        margin-top: -50px;
    }

    /*page print css----*/

    .header {
        overflow: hidden;
        padding: 10px 10px;
        font-size: 40px;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }

    body {
        font-family: 'Jameel Noori Nastaleeq';
    }

    body {
        font: 90%/1.45em ""Helvetica Neue"", HelveticaNeue, Verdana, Arial, Helvetica, sans-serif;
        margin: 0;
        padding: 0;
        color: #333;
        background-color: #fff;
    }

    .Createbtn {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: large;
        text-align: right;
    }

    .actionbtn {
        width: 150px;
        text-align: center;
    }

    .SubH {
        text-align: center;
        font-family: 'Jameel Noori Nastaleeq';
        font-size: medium;
    }

    .Subhdr {
        color: white;
        text-align: center;
 ");
            WriteLiteral("       background-color: slategrey;\r\n    }\r\n\r\n    .tabbody {\r\n        text-align: center;\r\n        color: black;\r\n    }\r\n</style>\r\n");
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
