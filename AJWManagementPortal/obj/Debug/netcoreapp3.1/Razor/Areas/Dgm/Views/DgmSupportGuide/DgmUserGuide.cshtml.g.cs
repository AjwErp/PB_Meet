#pragma checksum "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b03bd7e37e09fa2ba4e9386e3558cc402157999b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dgm_Views_DgmSupportGuide_DgmUserGuide), @"mvc.1.0.view", @"/Areas/Dgm/Views/DgmSupportGuide/DgmUserGuide.cshtml")]
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
#line 1 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03bd7e37e09fa2ba4e9386e3558cc402157999b", @"/Areas/Dgm/Views/DgmSupportGuide/DgmUserGuide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Dgm/Views/_ViewImports.cshtml")]
    public class Areas_Dgm_Views_DgmSupportGuide_DgmUserGuide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
  
    ViewData["Title"] = "DgmUserGuide";
    Layout = "~/Views/Shared/_LayoutDgm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b03bd7e37e09fa2ba4e9386e3558cc402157999b4244", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b03bd7e37e09fa2ba4e9386e3558cc402157999b4506", async() => {
                    WriteLiteral(@"
        <div class=""container-fluid backgroundWhiteBorder10Padding AccountLUBook"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""portlet light"">
                    <div class=""portlet-body"">
                        <div class=""table-responsive"">
                            <div class=""titleLaw"">
                                <span");
                    BeginWriteAttribute("class", " class=\"", 1059, "\"", 1067, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 25 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                          Write(localizer["D.G.M DEPARTMENT SYSTEM USER GUIDE"]);

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
                    BeginWriteAttribute("class", " class=\"", 1631, "\"", 1639, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        <th>");
#nullable restore
#line 34 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th colspan=\"8\">");
#nullable restore
#line 35 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                                   Write(localizer["Action's Description"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th colspan=\"4\">");
#nullable restore
#line 36 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                                   Write(localizer["Function"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td> <span class=""en"">01</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 43 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["The D.G Manager input assign email addrss,select related Department and input assign password then system display D.G.M Dashboard"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Login Page</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">02</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 51 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["The D.G Manager on dashboard view all important key values like Today Opening balance etc"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">D.G.M Dashboard</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">03</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 59 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is a search-bar on the top of the dashboard page, by this D.G manager search any query related to the D.G.M department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">D.G.M Search-Bar</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">04</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 66 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is selector of language at the top right by this D.G manager change current page language, as you want"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Language Translator</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">05</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 73 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is notification panel at the top right by this D.G manager check all activity's notification"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Notification Panel</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">06</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 80 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is user profile section at the top right by this D.G manager logout from system or check profile information"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Profile</td>
                                    </tr>

                                    <tr>
                                        <td> <span class=""en"">07</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 88 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is X sign at the top left by this D.G manager change the screen view(big/small)"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">X</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">08</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 95 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is book sign at the top right side by this D.G manager view updated notice"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Notice Board</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">09</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 102 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 1st option in sidebar ':Dashboard:' by this D.G manager go to D.G.M Dashboard Page  "]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/Dashboard</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">10</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 109 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 2nd dropdown option in sidebar ':D.G.M Support Guide:' by this D.G manager select D.G.M User Guide for D.G.M department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/D.G.M Support Guide</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">11</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 116 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 2nd dropdown option in sidebar ':D.G.M Law Book List:' by this D.G manager check all laws about D.G.M department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/D.G.M Law Book</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">12</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 124 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 3rd option in sidebar ':D.G.M All Daily Plan(Management/Technical Staff Work Plan):' by this D.G manager can create Daily Plans and perform all necessory operation on daily plans"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/All Daily Plan</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">13</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 132 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 4th option in sidebar ':D.G.M Notice Board List:' by this D.G manager can check all notices which created by H.R.M "]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/Notice Board List</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">14</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 140 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 5th dropdown option in sidebar ':Ajw Law Book List:' by this D.G manager can check all law books and perform which created by admin"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/Ajw Law Book List</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">15</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 148 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 6th option in sidebar ':D.G.M Office Reports:' by this D.G manager create Daily/Monthly/Yearly Reports for C.E.O and perform all necessory operations"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/D.G.M Office Reports</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">16</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 156 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 7th option in sidebar ':All Departments Reports:' by this D.G manager can check all department reports which send by related department and perform all necessory operations"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/All Departments Reports</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">17</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 164 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 8th option in sidebar ':D.G.M Reports Repository:' by this D.G manager view all success reports which sending by G.M Department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/D.G.M Reports Repository</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">18</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 172 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 9th option in sidebar ':D.G.M Error Report List:' by this D.G manager check all error reports which send by D.G.M office and perform all necessory operations"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/D.G.M Error Reports</td>

                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">19</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 180 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 10th option in sidebar ':D.G.M PDF Report:' by this D.G manager select all downloaded reports and upload on D.G.M D.M.S department"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/D.G.M PDF Report: D.M.S</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">20</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 187 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 11th option in sidebar ':All Department Dashboard:' by this D.G manager can check all departments activities"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/All Department Dashboard</td>
                                    </tr>
                                    <tr>
                                        <td> <span class=""en"">21</span> </td>
                                        <td colspan=""8"">
                                            ");
#nullable restore
#line 194 "D:\FinalProject\AJWManagementPortal\Areas\Dgm\Views\DgmSupportGuide\DgmUserGuide.cshtml"
                                       Write(localizer["There is 12th option in sidebar ':All Department D.M.S:' by  this D.G manager can check all departments D.M.S activities"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        </td>
                                        <td colspan=""4"">Sidebar/All Department D.M.S</td>
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
            WriteLiteral("\r\n\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n<!-- back to top button-->\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    body {
        font-family: 'Jameel Noori Nastaleeq';
    }

    .AccountLUBook {
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

    .background");
            WriteLiteral(@"WhiteBorder {
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
