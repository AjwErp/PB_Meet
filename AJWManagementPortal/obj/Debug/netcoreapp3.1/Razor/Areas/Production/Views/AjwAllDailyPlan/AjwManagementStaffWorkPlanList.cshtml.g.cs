#pragma checksum "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Production_Views_AjwAllDailyPlan_AjwManagementStaffWorkPlanList), @"mvc.1.0.view", @"/Areas/Production/Views/AjwAllDailyPlan/AjwManagementStaffWorkPlanList.cshtml")]
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
#line 1 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd174dba58fffd6f9fc52cc34e8591b4a6452ca", @"/Areas/Production/Views/AjwAllDailyPlan/AjwManagementStaffWorkPlanList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Production/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Production_Views_AjwAllDailyPlan_AjwManagementStaffWorkPlanList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ManagementStaffWorkPlan>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AjwAllDailyPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AjwManagementStaffWorkPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAjwManagementStaffWorkPlanMP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAjwManagementStaffWorkPlanMP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendToGmOfficeMP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("myFunction()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tabled col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
  
    ViewData["Title"] = "AjwManagementStaffWorkPlanList";
    Layout = "~/Views/Shared/_LayoutProduction.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca9395", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid backgroundWhiteBorder10Padding\">\r\n        <div class=\"row\">\r\n            <div class=\"header col-sm-12\">\r\n                <br />\r\n                <a class=\"logo font-weight-bold font-weight-bolder\">");
#nullable restore
#line 19 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                               Write(Localizer["AJW MANAGEMENT STAFF WORKING PLAN FILE LIST"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </div>\r\n");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca10386", async() => {
                    WriteLiteral("\r\n                <hr />\r\n                <div class=\"col-sm-12 Createbtn\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca10754", async() => {
                        WriteLiteral("<i class=\"fas fa-plus\"> ");
#nullable restore
#line 25 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                                               Write(Localizer["Create New Management Work Plan"]);

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
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
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
                    WriteLiteral("\r\n                </div>\r\n                <br />\r\n\r\n                <table class=\"table table-bordered\" id=\"DMBLBook\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr SubH\">\r\n                            <th>");
#nullable restore
#line 32 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                           Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </th>\r\n                            <th>");
#nullable restore
#line 33 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                           Write(Localizer["Date"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 34 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                           Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 35 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n\r\n");
#nullable restore
#line 42 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                            <tr class=""SubH "">
                                <td class=""actionbtn"">
                                    <div class=""btn-group"">
                                        <button class=""btn btn-primary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            ");
#nullable restore
#line 48 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                       Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </button>\r\n                                        <div class=\"dropdown-menu\">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca16346", async() => {
                        WriteLiteral("<i class=\"fas fa-list-alt\"></i> ");
#nullable restore
#line 51 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
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
                    WriteLiteral("\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca18652", async() => {
                        WriteLiteral("<i class=\"fas fa-edit\"></i> ");
#nullable restore
#line 52 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                                                                                                Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-date", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                                               WriteLiteral(item.MPDate);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca22325", async() => {
                        WriteLiteral("<i class=\"fas fa-trash-alt\"></i> ");
#nullable restore
#line 53 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                                                                                                       Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-date", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                                                 WriteLiteral(item.MPDate);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    WriteLiteral("                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd174dba58fffd6f9fc52cc34e8591b4a6452ca26053", async() => {
                        WriteLiteral("<i class=\"fas fa-send\"></i> ");
#nullable restore
#line 55 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                                                                                                       Write(Localizer["Send To G.M Offcie"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-date", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                                                                                                                                               WriteLiteral(item.MPDate);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 60 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                               Write(item.MPDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    ");
#nullable restore
#line 61 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                               Write(ViewBag.Date);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" = ");
#nullable restore
#line 61 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                                               Write(item.MPDate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </td>\r\n                                <td>Ajw Management Staff Work Plan</td>\r\n                                <td>");
#nullable restore
#line 64 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n");
                    WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 68 "E:\Projects\Freelancing Projects\Saqib (Pakistan)\10-05-2022\PB_Meet\AJWManagementPortal\Areas\Production\Views\AjwAllDailyPlan\AjwManagementStaffWorkPlanList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n");
                    WriteLiteral("            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
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
            WriteLiteral("\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //------JS for Pagination and Datatables for Accounts All Main Bank Ledger Book---Start----
        $(document).ready(function () {
            $('#DMBLBook').DataTable({
                ""sPaginationType"": ""full_numbers""
            });
        });
        //--------
        function myFunction() {
            alert(""Management Staff Work Plan Sheet Send to G.M Office...!"");
        }
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
    /* Css for Heading on every Sheet of ccount office----*/
    .header {
        overflow: hidden;
        padding: 10px 10px;
        font-size: 40px;
        font-family: 'Jameel Noori Nastaleeq';
        text-align: center;
    }
    /*//--CSS For Create button & Action");
            WriteLiteral(@" Button of Each Page------start---------*/
    .Createbtn {
        font-family: 'Jameel Noori Nastaleeq';
        font-size: large;
        text-align: right;
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
    .table {
        border-collapse: collapse;
        border-spacing: 0;
        border: 1px solid #ddd;
        table-layout: fixed;
        width: 100%
    }
    /*  Css for Small Content Of Accounts----*/
    .smallfontHeading {
        font-size: medium;
    }

    .Subhdr {
        color: white;
        text-align: center;
        background-color: slategrey;
    }
    /* Css for Table Body on each page in Accounts----*/
    .tabbody {
        text-align: center;
        color: black;
    }
    /*  Css for small Size of Content----*/
    .S");
            WriteLiteral("ubH {\r\n        text-align: center;\r\n        font-family: \'Jameel Noori Nastaleeq\';\r\n        font-size: medium;\r\n    }\r\n</style>\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer Localizer { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ManagementStaffWorkPlan>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
