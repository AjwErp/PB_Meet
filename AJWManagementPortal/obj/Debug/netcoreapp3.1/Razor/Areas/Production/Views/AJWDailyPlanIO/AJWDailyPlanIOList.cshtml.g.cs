#pragma checksum "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeda1ae04a936453ec29151095a69dd9fb01cef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Production_Views_AJWDailyPlanIO_AJWDailyPlanIOList), @"mvc.1.0.view", @"/Areas/Production/Views/AJWDailyPlanIO/AJWDailyPlanIOList.cshtml")]
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
#line 1 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeda1ae04a936453ec29151095a69dd9fb01cef5", @"/Areas/Production/Views/AJWDailyPlanIO/AJWDailyPlanIOList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Production/Views/_ViewImports.cshtml")]
    public class Areas_Production_Views_AJWDailyPlanIO_AJWDailyPlanIOList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AJWDailyPlanIO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AJWDailyPlanIO", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AJWDailyPlanIO", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartialAJWDPIO", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
  
    ViewData["Title"] = "AJWDailyPlanIOList";
    Layout = "~/Views/Shared/_LayoutProduction.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeda1ae04a936453ec29151095a69dd9fb01cef57138", async() => {
                WriteLiteral("\r\n    <div class=\"border backgroundWhiteBorder\">\r\n        <div class=\"row text-light\">\r\n            <div class=\"col-12 text-right\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeda1ae04a936453ec29151095a69dd9fb01cef57555", async() => {
                    WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp;");
#nullable restore
#line 20 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                                                                                                                                                          Write(Localizer["Create New Daily Plan"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aeda1ae04a936453ec29151095a69dd9fb01cef59904", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <h2 class=\"Title font-weight-bold\"> ");
#nullable restore
#line 28 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                                               Write(Localizer["Daily Plan-In/Out Sheet"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n\r\n        <br />\r\n        <div>\r\n");
#nullable restore
#line 34 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <table id=\"DailyPlan\" class=\"table table-striped border SubH\">\r\n                    <thead>\r\n                        <tr class=\"Subhdr\">\r\n                            <th>\r\n                                ");
#nullable restore
#line 40 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["ID#"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 43 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 46 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["Designation"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 49 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["DateTimeIn"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 52 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["DateTimeOut"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 55 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 58 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                           Write(Localizer["Signature"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th> </th>\r\n                            <th> ");
#nullable restore
#line 61 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                            Write(Localizer["Action"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
#nullable restore
#line 66 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 76 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.Designation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 79 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.DateTimeIn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 82 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.DateTimeOut));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 85 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 88 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                               Write(Html.DisplayFor(m => item.Signature));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aeda1ae04a936453ec29151095a69dd9fb01cef518579", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 91 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
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
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 94 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 97 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 100 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
              Write(Localizer["No Daily Plan Exists..."]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 101 "D:\Project Copy\AJWManagementPortal\Areas\Production\Views\AJWDailyPlanIO\AJWDailyPlanIOList.cshtml"
            }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n<br />\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#DailyPlan').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
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
         /*   body {
            font: 90%/1.45em ""Helvetica Neue"", HelveticaNeue, Verdana, Arial, Helvetica, sans-serif;
            margin: 0;
            padding: 0;
            color: #333;
            background-color: #fff;
        }*/
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
            ");
            WriteLiteral(@"border-radius: 10px;
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
            text-align: center;
        }

        .TitleHrmOfficeReport {
            font-family: 'Jameel Noori Nastaleeq';
            font-size: xx-large;
            font-weight: bold;
        }
        /*  Css for Table of Each in Accounts----*/
        .table {
            border-collapse: collapse;
            border-spacing: 0;
            border: 1px solid #ddd;
            /*        table-layout: fixed;
    */ width: 100%;
        }
        /*  Css for small Size of Content----*/
        .SubH {
            text-align: center;
            font-family: 'Jameel Noori Nastaleeq';
            font-size: medium;
        }
        /");
            WriteLiteral(@"*page print css----*/
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
        /*Mostly USes Css Classes userprofile/footer/backtolist/table/backtotopbtn/smallheading/subh/print --for Accounts Department- start*/

        /*  Css for Sub Heading of table----*/
        .Subhdr {
            color: white;
            text-align: center;
            background-color: slategrey;
        }


        /* Css for Heading ");
            WriteLiteral(@"on every Sheet of ccount office----*/
        .header {
            overflow: hidden;
            padding: 10px 10px;
            font-size: 40px;
            font-family: 'Jameel Noori Nastaleeq';
            text-align: center;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AJWDailyPlanIO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
