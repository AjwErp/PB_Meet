#pragma checksum "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88b7cfa092ed2fc9a290c955c22eebc0b8abda73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRM_Views_HrmSupportGuide_HrmLawBook), @"mvc.1.0.view", @"/Areas/HRM/Views/HrmSupportGuide/HrmLawBook.cshtml")]
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
#line 1 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\_ViewImports.cshtml"
using AJWManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b7cfa092ed2fc9a290c955c22eebc0b8abda73", @"/Areas/HRM/Views/HrmSupportGuide/HrmLawBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f307faba2f459ec4b01c5ef0965c9ff6ff9eef1", @"/Areas/HRM/Views/_ViewImports.cshtml")]
    public class Areas_HRM_Views_HrmSupportGuide_HrmLawBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AJWManagementPortal.Models.LawBook>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HrmLawBookList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Hrm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HrmSupportGuide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-md fas fa-step-backward"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Back To List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
  
    ViewData["Title"] = "ProductionLawBook";
    Layout = "~/Views/Shared/_LayoutHrm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b7cfa092ed2fc9a290c955c22eebc0b8abda736346", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b7cfa092ed2fc9a290c955c22eebc0b8abda736608", async() => {
                    WriteLiteral(@"
        <div class=""container-fluid backgroundWhiteBorder10Padding ProductionLUBook"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""portlet light"">
                    <div class=""portlet-body"">
                        <div class=""table-responsive"">
");
                    WriteLiteral(@"                            <br />
                            <div class=""titleLaw"" style=""direction:ltr"">
                                <input type=""text"" class=""form-control"" id=""title"" name=""title"" style=""height:50px;width:320px;border:hidden;font:message-box""");
                    BeginWriteAttribute("value", " value=\"", 1562, "\"", 1603, 4);
#nullable restore
#line 31 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
WriteAttributeValue("", 1570, ViewBag.dept, 1570, 13, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 1583, "Department", 1584, 11, true);
                    WriteAttributeValue(" ", 1594, "Law", 1595, 4, true);
                    WriteAttributeValue(" ", 1598, "Book", 1599, 5, true);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\r\n\r\n");
                    WriteLiteral("                            </div>\r\n");
                    WriteLiteral("                            <table style=\"width:100%\" id=\"tbllawbook\" class=\"display nowrap table table-bordered table-hover table-condensed table-sm SubH\">\r\n                                <thead>\r\n                                    <tr");
                    BeginWriteAttribute("class", " class=\"", 2318, "\"", 2326, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        <th>");
#nullable restore
#line 42 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                       Write(localizer["ID#"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 43 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                       Write(localizer["Law's Description"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 44 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                       Write(localizer["Edit Number"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 45 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                       Write(localizer["Page Number"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 46 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                       Write(localizer["Previous Edit Number"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 47 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                       Write(localizer["Previous Page Number"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 51 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <tr>\r\n                                            <td> <span class=\"en\">");
#nullable restore
#line 54 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span> </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 56 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.lawDescription));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </td>\r\n                                            <td><input type=\"text\"");
                    BeginWriteAttribute("id", " id=\"", 3465, "\"", 3470, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3492, "\"", 3546, 1);
#nullable restore
#line 58 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
WriteAttributeValue("", 3500, Html.DisplayFor(modelItem => item.editNumber), 3500, 46, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n                                            <td><input type=\"text\"");
                    BeginWriteAttribute("id", " id=\"", 3623, "\"", 3628, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3650, "\"", 3704, 1);
#nullable restore
#line 59 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
WriteAttributeValue("", 3658, Html.DisplayFor(modelItem => item.pageNumber), 3658, 46, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n                                            <td><input type=\"text\"");
                    BeginWriteAttribute("id", " id=\"", 3781, "\"", 3786, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3808, "\"", 3870, 1);
#nullable restore
#line 60 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
WriteAttributeValue("", 3816, Html.DisplayFor(modelItem => item.previousEditNumber), 3816, 54, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n                                            <td><input type=\"text\"");
                    BeginWriteAttribute("id", " id=\"", 3947, "\"", 3952, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3974, "\"", 4036, 1);
#nullable restore
#line 61 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
WriteAttributeValue("", 3982, Html.DisplayFor(modelItem => item.previousPageNumber), 3982, 54, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 64 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <td> <span class=""en""> <button type=""button"" id=""btnAdd"" value=""Add"" class=""btn btn-primary btn-sm form-control"">");
#nullable restore
#line 69 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                                                                                                                                    Write(localizer["Add"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />");
#nullable restore
#line 69 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                                                                                                                                                           Write(localizer["Row"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</button></span> </td>
                                        <td>
                                            <textarea type=""text"" class=""form-control"" id=""txtDesc"" name=""txtDesc""></textarea>
                                        </td>
                                        <td><input type=""text"" id=""txtEditNumber"" name=""txtEditNumber"" class=""form-control"" /></td>
                                        <td><input type=""text"" id=""txtPageNumber"" name=""txtPageNumber"" class=""form-control"" /></td>
                                        <td><input type=""text"" id=""txtPreviousEditNumber"" name=""txtPreviousEditNumber"" class=""form-control"" /></td>
                                        <td><input type=""text"" id=""txtPreviousPageNumber"" name=""txtPreviousPageNumber"" class=""form-control"" /></td>
                                    </tr>
                                    <tr>
                                        <td scope=""row"" colspan=""13"" class=""actionbtn"">
                                         ");
                    WriteLiteral("   ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b7cfa092ed2fc9a290c955c22eebc0b8abda7317306", async() => {
#nullable restore
#line 80 "D:\Project Copy\AJWManagementPortal\Areas\HRM\Views\HrmSupportGuide\HrmLawBook.cshtml"
                                                                                                                                                                                                             Write(localizer["Back To List"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"


                                        </td>
                                    </tr>

                                </tfoot>

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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
            WriteLiteral("\r\n\r\n<!-- back to top button-->\r\n<a id=\"button\"></a>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // DataTables with Add Row Functionality
        $(""body"").on(""click"", ""#btnAdd"", function () {


            //Reference the Name and Country TextBoxes.
            var txtDesc = $(""#txtDesc"");
            var txtEditNumber = $(""#txtEditNumber"");
            var txtPageNumber = $(""#txtPageNumber"");
            var txtPreviousEditNumber = $(""#txtPreviousEditNumber"");
            var txtPreviousPageNumber = $(""#txtPreviousPageNumber"");


            //Get the reference of the Table's TBODY element.
            var tBody = $(""#tbllawbook > TBODY"")[0];

            //Add Row.
            var row = tBody.insertRow(-1);

            var cell = $(row.insertCell(-1));
            //Add Button cell.
            var btnRemove = $(""<input />"");
            btnRemove.attr(""type"", ""button"");
            btnRemove.attr(""onclick"", ""Remove(this);"");
            btnRemove.val(""Remove"");
            cell.append(btnRemove);

            cell = $(row.insertCell(-1));
          ");
                WriteLiteral(@"  cell.append(txtDesc.val());


            cell = $(row.insertCell(-1));
            var btn2 = $(""<input />"");
            btn2.attr(""type"", ""text"");
            btn2.val(txtEditNumber.val());
            cell.append(btn2);

            //Add Country cell.
            cell = $(row.insertCell(-1));
            var btn3 = $(""<input />"");
            btn3.attr(""type"", ""text"");
            btn3.val(txtPageNumber.val());
            cell.append(btn3);

            cell = $(row.insertCell(-1));
            var btn4 = $(""<input />"");
            btn4.attr(""type"", ""text"");
            btn4.val(txtPreviousEditNumber.val());
            cell.append(btn4);

            cell = $(row.insertCell(-1));
            var btn5 = $(""<input />"");
            btn5.attr(""type"", ""text"");
            btn5.val(txtPreviousPageNumber.val());
            cell.append(btn5);


            //Clear the TextBoxes.
            txtDesc.val("""");
            txtEditNumber.val("""");
            txtPageNumber.val(""""");
                WriteLiteral(@");
            txtPreviousEditNumber.val("""");
            txtPreviousPageNumber.val("""");

        });

        function Remove(button) {
            //Determine the reference of the Row using the Button.
            var row = $(button).closest(""TR"");
            var name = $(""TD"", row).eq(0).html();
            if (confirm(""Do you want to delete: "" + name)) {
                //Get the reference of the Table.
                var table = $(""#tbllawbook"")[0];

                //Delete the Table row using it's Index.
                table.deleteRow(row[0].rowIndex);
            }
        };

        $(""body"").on(""click"", ""#btnSave"", function () {

            //Loop through the Table rows and build a JSON array.
            var lawbookArray = new Array();
            $(""#tbllawbook TBODY TR"").each(function () {
                var row = $(this);
                var lawbook = {};
                lawbook.lawDescription = row.find(""TD"").eq(1).text();
                lawbook.editNumber = ro");
                WriteLiteral(@"w.find(""input[type='text']"").eq(0).val();
                lawbook.pageNumber = row.find(""input[type='text']"").eq(1).val();
                lawbook.previousEditNumber = row.find(""input[type='text']"").eq(2).val();
                lawbook.previousPageNumber = row.find(""input[type='text']"").eq(3).val();

                lawbookArray.push(lawbook);
            });
            alert(lawbookArray);
            //Get
            var Title = $('#title').val();
            var Dept = $('#id').val();

            //Send the JSON array to Controller using AJAX.
            $.ajax({
                type: ""POST"",
                url: ""/Dgm/DgmSupportGuide/InsertLawBooks"",
                data: { data: lawbookArray, Title: Title, Dept: Dept },
                success: function (r) {
                    alert(r + "" record(s) inserted."");
                    window.location.replace(""/Dgm/DgmSupportGuide/DgmLawBookList"");
                }
            });
        });



    </script>


    <script>");
                WriteLiteral(@"
        //---------JS for Back To Top Button On Each Page------------------Start-------
        var btn = $('#button');

        $(window).scroll(function () {
            if ($(window).scrollTop() > 300) {
                btn.addClass('show');
            } else {
                btn.removeClass('show');
            }
        });

        btn.on('click', function (e) {
            e.preventDefault();
            $('html, body').animate({ scrollTop: 0 }, '300');
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .ProductionLUBook {
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

    /*page print css----*/
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AJWManagementPortal.Models.LawBook>> Html { get; private set; }
    }
}
#pragma warning restore 1591
