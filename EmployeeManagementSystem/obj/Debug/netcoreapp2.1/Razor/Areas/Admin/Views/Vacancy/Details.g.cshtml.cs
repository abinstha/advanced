#pragma checksum "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7450f03cd030f73ddc338fcc75dde015f79d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Vacancy_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Vacancy/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Vacancy/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Vacancy_Details))]
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
#line 1 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.Models;

#line default
#line hidden
#line 2 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.ViewModels;

#line default
#line hidden
#line 3 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.ViewModels.DepartmentView;

#line default
#line hidden
#line 4 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.ViewModels.DesignationView;

#line default
#line hidden
#line 5 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.ViewModels.VacancyView;

#line default
#line hidden
#line 6 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.ViewModels.SalaryView;

#line default
#line hidden
#line 7 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.ViewModels.UserView;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7450f03cd030f73ddc338fcc75dde015f79d3f", @"/Areas/Admin/Views/Vacancy/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9c1ed79b0744bb0d188d44d4017a3e21523219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Vacancy_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VacancyDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vacancy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            DefineSection("Title", async() => {
                BeginContext(47, 23, true);
                WriteLiteral("\r\n    Vacancy Details\r\n");
                EndContext();
            }
            );
            BeginContext(73, 93, true);
            WriteLiteral("<div class=\"box\">\r\n    <div class=\"box-header\">\r\n        <h3 class=\"box-title\">Vacancy For : ");
            EndContext();
            BeginContext(167, 31, false);
#line 7 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
                                       Write(Model.Vacancy.Designation.Title);

#line default
#line hidden
            EndContext();
            BeginContext(198, 198, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"box-body\">\r\n        <table class=\"table table-borderless\">\r\n            <tr>\r\n                <td>Department</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(397, 29, false);
#line 14 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(426, 130, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Designation</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(557, 31, false);
#line 19 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.Designation.Title);

#line default
#line hidden
            EndContext();
            BeginContext(588, 122, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>HOD</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(711, 39, false);
#line 24 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.Department.DepartmentHead);

#line default
#line hidden
            EndContext();
            BeginContext(750, 137, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Department Contact</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(888, 32, false);
#line 29 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.Department.Contact);

#line default
#line hidden
            EndContext();
            BeginContext(920, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(924, 32, false);
#line 29 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
                                                   Write(Model.Vacancy.Department.Address);

#line default
#line hidden
            EndContext();
            BeginContext(956, 130, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Expiry Date</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1087, 24, false);
#line 34 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.ExpiryDate);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 134, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Job Description</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1246, 25, false);
#line 39 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 136, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Job Specification</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1408, 27, false);
#line 44 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
               Write(Model.Vacancy.Specification);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 106, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <div class=\"box-footer text-center\">\r\n        ");
            EndContext();
            BeginContext(1541, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c44fc99fe774ef8a327c2e509ecc062", async() => {
                BeginContext(1612, 103, true);
                WriteLiteral("\r\n            <i class=\"fa fa-arrow-circle-left\" style=\"padding-right: 5px;\"></i>Back to List\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1719, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1729, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc206796e3f344fe9f9ac9024190cabb", async() => {
                BeginContext(1832, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
                                                        WriteLiteral(Model.Vacancy.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1840, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1850, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f2a2063ed54b08b32bd80deee42498", async() => {
                BeginContext(1954, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Vacancy\Details.cshtml"
                                                          WriteLiteral(Model.Vacancy.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1964, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VacancyDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
