#pragma checksum "C:\Users\A J W\source\repos\HAJ Updation\25-12-202111\26-01-2022\PB_Meet\AJWManagementPortal\Areas\Home\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45437a78aba4b58e815680abec7f5b0ed96dcd44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Home_Privacy), @"mvc.1.0.view", @"/Areas/Home/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\A J W\source\repos\HAJ Updation\25-12-202111\26-01-2022\PB_Meet\AJWManagementPortal\Areas\Home\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A J W\source\repos\HAJ Updation\25-12-202111\26-01-2022\PB_Meet\AJWManagementPortal\Areas\Home\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45437a78aba4b58e815680abec7f5b0ed96dcd44", @"/Areas/Home/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/Home/Views/_ViewImports.cshtml")]
    public class Areas_Home_Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\A J W\source\repos\HAJ Updation\25-12-202111\26-01-2022\PB_Meet\AJWManagementPortal\Areas\Home\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\A J W\source\repos\HAJ Updation\25-12-202111\26-01-2022\PB_Meet\AJWManagementPortal\Areas\Home\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n<button onclick=\"myFunction()\">Try it</button>\r\n\r\n<button id=\"btnsub\" class=\"btn btn-warning\">Submit</button>\r\n<br />\r\n<br />\r\n");
            WriteLiteral(@"<div id=""yoalert"" class=""alert alert-danger collapse"">
    <a id=""linkClose"" href=""#"" class=""close"">&times;</a>
    <strong>Error!</strong>There is a problem submitting your form

</div>
<div class=""container"" style=""padding-top:100px"">
    <input type=""text"" id=""Name"" placeholder=""Name"" class=""form-control"" />
    <input type=""text"" id=""Email"" placeholder=""Email"" class=""form-control"" />
    <input type=""text"" id=""Phone"" placeholder=""Phone"" class=""form-control"" />
    <button type=""button"" id=""submit"" class=""btn btn-primary"">Submit</button>
</div>
<script type=""text/javascript"">
    $(""#submit"").click(function () {
        alert(""Here Sweet alert but not sweet"");
    });
    //-----------------
    function myFunction() {
        alert(""I am an alert box!"");
    }
    //---------
    $(document).ready(function () {
        $('#btnsub').click(function () {
            $('#yoalert').show('fade');

            setTimeout(function () {
                $('#yoalert').hide('fade')
         ");
            WriteLiteral("   }, 2000)\r\n        });\r\n\r\n    $(\'#linkClose\').click(function () {\r\n        $(\'#yoalert\').hide(\'fade\')\r\n    });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
