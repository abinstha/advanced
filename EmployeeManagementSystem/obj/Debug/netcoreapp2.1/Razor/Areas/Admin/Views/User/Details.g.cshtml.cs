#pragma checksum "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918466b1609b6043e98dc4ec3d3223f2bd06b384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918466b1609b6043e98dc4ec3d3223f2bd06b384", @"/Areas/Admin/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9c1ed79b0744bb0d188d44d4017a3e21523219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Title", async() => {
                BeginContext(44, 24, true);
                WriteLiteral("\r\n    Employee Details\r\n");
                EndContext();
            }
            );
#line 5 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
  
    var photoPath = "~/dist/img/user/" + (Model.user.PhotoPath ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(161, 108, true);
            WriteLiteral("<div class=\"box\">\r\n    <div class=\"box-header\">\r\n        <h3 class=\"box-title\" style=\"padding-bottom:20px\"> ");
            EndContext();
            BeginContext(270, 15, false);
#line 10 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
                                                      Write(Model.user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(285, 29, true);
            WriteLiteral(" Details</h3><br />\r\n        ");
            EndContext();
            BeginContext(314, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d099e118774b4aef84c5c6d09e623025", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 11 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
      WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(376, 187, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"box-body\">\r\n        <table class=\"table table-borderless\">\r\n            <tr>\r\n                <td>Name</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(564, 15, false);
#line 18 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(579, 129, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Department</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(709, 26, false);
#line 23 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(735, 130, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Designation</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(866, 28, false);
#line 28 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Designation.Title);

#line default
#line hidden
            EndContext();
            BeginContext(894, 132, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Date of Birth</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1027, 14, false);
#line 33 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Dob);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 125, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Gender</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1167, 17, false);
#line 38 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 132, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Email Address</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1317, 16, false);
#line 43 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 133, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Contact Number</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1467, 17, false);
#line 48 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(1484, 126, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Address</td>\r\n                <td>:</td>\r\n                <td>");
            EndContext();
            BeginContext(1611, 18, false);
#line 53 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
               Write(Model.user.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1629, 108, true);
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </table>\r\n    </div>\r\n    <div class=\"box-footer text-center\">\r\n        ");
            EndContext();
            BeginContext(1737, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d0ba5e00f04231b8447518fd5a2d03", async() => {
                BeginContext(1805, 103, true);
                WriteLiteral("\r\n            <i class=\"fa fa-arrow-circle-left\" style=\"padding-right: 5px;\"></i>Back to List\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1912, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1922, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6a712dd568240149279607ec9446cab", async() => {
                BeginContext(2019, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
                                                     WriteLiteral(Model.user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2027, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2037, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352ee4de84124a578dd2b4f113a8179f", async() => {
                BeginContext(2135, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\User\Details.cshtml"
                                                       WriteLiteral(Model.user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2145, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
