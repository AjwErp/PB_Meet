<<<<<<< HEAD
#pragma checksum "E:\PB_Meet\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
=======
#pragma checksum "D:\New Project\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StatusMessage), @"mvc.1.0.view", @"/Views/Shared/_StatusMessage.cshtml")]
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
#line 1 "E:\PB_Meet\AJWManagementPortal\Views\_ViewImports.cshtml"
=======
#line 1 "D:\New Project\AJWManagementPortal\Views\_ViewImports.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\PB_Meet\AJWManagementPortal\Views\_ViewImports.cshtml"
=======
#line 2 "D:\New Project\AJWManagementPortal\Views\_ViewImports.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "E:\PB_Meet\AJWManagementPortal\Views\_ViewImports.cshtml"
=======
#line 3 "D:\New Project\AJWManagementPortal\Views\_ViewImports.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
using AJWManagementPortal.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Views/Shared/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca1cf73f85fb554859ed575c76e3b0fa7621723", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "E:\PB_Meet\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
=======
#line 3 "D:\New Project\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
<<<<<<< HEAD
#line 6 "E:\PB_Meet\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
=======
#line 6 "D:\New Project\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 8 "E:\PB_Meet\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
=======
#line 8 "D:\New Project\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "E:\PB_Meet\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
=======
#line 10 "D:\New Project\AJWManagementPortal\Views\Shared\_StatusMessage.cshtml"
>>>>>>> ae21790d0e9159d95da49fe862e3bcab2ca27c1a
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
