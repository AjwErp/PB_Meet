#pragma checksum "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a351448f08e308b26b5e8319d4445afef5a3fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dms_Views_Dms_DmsDashboard), @"mvc.1.0.view", @"/Areas/Dms/Views/Dms/DmsDashboard.cshtml")]
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
#line 1 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a351448f08e308b26b5e8319d4445afef5a3fa", @"/Areas/Dms/Views/Dms/DmsDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Dms/Views/_ViewImports.cshtml")]
    public class Areas_Dms_Views_Dms_DmsDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DmsDashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
  
    ViewData["Title"] = "DMSDashboard";
    Layout = "~/Views/Shared/_LayoutDms.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-sm-6\">\r\n            <div class=\"card-box bg-blue\">\r\n                <div class=\"inner\">\r\n                    <h3> ");
#nullable restore
#line 20 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                    Write(Model.length.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-book\"></i> </h3>\r\n                    <p> ");
#nullable restore
#line 21 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Total Law Books"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-book-reader"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>

        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-green"">
                <div class=""inner"">
                    <h3>  ");
#nullable restore
#line 32 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                     Write(Model.Hrmlength.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                    <p> ");
#nullable restore
#line 33 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Total Notice Report"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-orange"">
                <div class=""inner"">
                    <h3> ");
#nullable restore
#line 43 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                    Write(Model.Accountslength.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                    <p> ");
#nullable restore
#line 44 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Total Accounts Reports"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-red"">
                <div class=""inner"">
                    <h3> ");
#nullable restore
#line 54 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                    Write(Model.Productionlength.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                    <p> ");
#nullable restore
#line 55 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Total Technical Staff Plan Report"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money""></i>
                </div>
            </div>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-blue"">
                <div class=""inner"">
                    <h3> 134367577 </h3>
                    <p> ");
#nullable restore
#line 70 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Today Opening Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>

        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-green"">
                <div class=""inner"">
                    <h3> ₹1858388358 </h3>
                    <p> ");
#nullable restore
#line 82 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Meezan-Bank Current Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-orange"">
                <div class=""inner"">
                    <h3> 583838464 </h3>
                    <p> ");
#nullable restore
#line 93 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Punjab-Bank Current Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-red"">
                <div class=""inner"">
                    <h3> 7283838383 </h3>
                    <p> ");
#nullable restore
#line 104 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Total Bank Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money""></i>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-blue"">
                <div class=""inner"">
                    <h3> 134367577 </h3>
                    <p> ");
#nullable restore
#line 118 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Total Accounts Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>

        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-green"">
                <div class=""inner"">
                    <h3> ₹1858388358 </h3>
                    <p> ");
#nullable restore
#line 130 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Internal Account Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-orange"">
                <div class=""inner"">
                    <h3> 583838464 </h3>
                    <p> ");
#nullable restore
#line 141 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Petty Account Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-red"">
                <div class=""inner"">
                    <h3> 7283838383 </h3>
                    <p> ");
#nullable restore
#line 152 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Supplier Credit Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money""></i>
                </div>
            </div>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-blue"">
                <div class=""inner"">
                    <h3> 134367577 </h3>
                    <p> ");
#nullable restore
#line 167 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Suplier Debit Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>

        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-green"">
                <div class=""inner"">
                    <h3> ₹1858388358 </h3>
                    <p> ");
#nullable restore
#line 179 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Today Meezan Bank Income"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-orange"">
                <div class=""inner"">
                    <h3> 583838464 </h3>
                    <p> ");
#nullable restore
#line 190 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Today Punjab Bank Income"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-money"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-sm-6"">
            <div class=""card-box bg-red"">
                <div class=""inner"">
                    <h3> 7283838383 </h3>
                    <p> ");
#nullable restore
#line 201 "D:\New Project\AJWManagementPortal\Areas\Dms\Views\Dms\DmsDashboard.cshtml"
                   Write(Localizer["Supplier -- Balance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n                <div class=\"icon\">\r\n                    <i class=\"fa fa-money\"></i>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .card-box {
        position: relative;
        color: #fff;
        padding: 20px 10px 40px;
        margin: 12px 0px;
    }

        .card-box:hover {
            text-decoration: none;
            color: #f1f1f1;
        }

            .card-box:hover .icon i {
                font-size: 100px;
                transition: 1s;
                -webkit-transition: 1s;
            }

        .card-box .inner {
            padding: 5px 10px 0 10px;
        }

        .card-box h3 {
            font-size: 27px;
            font-weight: bold;
            margin: 0 0 8px 0;
            white-space: nowrap;
            padding: 0;
            text-align: left;
        }

        .card-box p {
            font-size: 15px;
            color: white;
            font-weight: bold;
        }

        .card-box .icon {
            position: absolute;
            top: auto;
            bottom: 5px;
            right: 5px;
            z-index: 0;
            font-size");
            WriteLiteral(@": 72px;
            color: rgba(0, 0, 0, 0.15);
        }

        .card-box .card-box-footer {
            position: absolute;
            left: 0px;
            bottom: 0px;
            text-align: center;
            padding: 3px 0;
            color: rgba(255, 255, 255, 0.8);
            background: rgba(0, 0, 0, 0.1);
            width: 100%;
            text-decoration: none;
        }

        .card-box:hover .card-box-footer {
            background: rgba(0, 0, 0, 0.3);
        }

    .bg-blue {
        background-color: #00c0ef !important;
    }

    .bg-green {
        background-color: #00a65a !important;
    }

    .bg-orange {
        background-color: #f39c12 !important;
    }

    .bg-red {
        background-color: #d9534f !important;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DmsDashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
