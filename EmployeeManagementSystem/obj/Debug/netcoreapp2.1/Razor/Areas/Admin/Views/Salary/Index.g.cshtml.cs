#pragma checksum "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4409d80a8dc41bcbc02c8d2088d09c8325f03469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Salary_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Salary/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Salary/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Salary_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4409d80a8dc41bcbc02c8d2088d09c8325f03469", @"/Areas/Admin/Views/Salary/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9c1ed79b0744bb0d188d44d4017a3e21523219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Salary_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(39, 16, true);
                WriteLiteral("\r\n    Salaries\r\n");
                EndContext();
            }
            );
            BeginContext(58, 868, true);
            WriteLiteral(@"<h1 class=""h3 mb-2 text-gray-800"">Salaries</h1>
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">All Salaries</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Designation</th>
                        <th>Salary Amount</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Designation</th>
                        <th>Salary Amount</th>
                        <th>Action</th>
                    </tr>
                </tfoot>
                <tbody>
");
            EndContext();
#line 28 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml"
                     foreach (var item in Model.Salaries)
                    {

#line default
#line hidden
            BeginContext(1008, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1071, 44, false);
#line 31 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml"
                           Write(Html.DisplayFor(v => item.Designation.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1155, 39, false);
#line 32 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml"
                           Write(Html.DisplayFor(v => item.SalaryAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1267, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45bcfcaf045a412ea35027ef2111ab66", async() => {
                BeginContext(1360, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1368, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1402, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "225831f207a74831b61373e3636767ee", async() => {
                BeginContext(1496, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

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
            BeginContext(1506, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 38 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Salary\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1597, 103, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n                   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
