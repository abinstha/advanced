#pragma checksum "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4b09c885fc9dbdb9e03e530901864f2d132c7bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b09c885fc9dbdb9e03e530901864f2d132c7bf", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9c1ed79b0744bb0d188d44d4017a3e21523219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VacancyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\BTECH HND. in Computing\3rd semester\Net\EmployeeManagementSystem\EmployeeManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            DefineSection("Title", async() => {
                BeginContext(83, 22, true);
                WriteLiteral("\r\n    Create Vacancy\r\n");
                EndContext();
            }
            );
            BeginContext(108, 4852, true);
            WriteLiteral(@"    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <h1>
            Dashboard
            <small>Control panel</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li class=""active"">Dashboard</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class=""content"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-aqua"">
                    <div class=""inner"">
                        <h3>150</h3>

                        <p>New Orders</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-bag""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
                </d");
            WriteLiteral(@"iv>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-green"">
                    <div class=""inner"">
                        <h3>53<sup style=""font-size: 20px""></sup></h3>

                        <p>Vacancies</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-yellow"">
                    <div class=""inner"">
                        <h3>44</h3>

                        <p>Employees</p>
                    </div>
                    <div class=""icon"">
                    ");
            WriteLiteral(@"    <i class=""ion ion-person-add""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-red"">
                    <div class=""inner"">
                        <h3>65</h3>

                        <p>Leaves</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <section class=""col-lg-7 connectedSortable"">
");
            WriteLiteral(@"                <!-- Custom tabs (Charts with tabs)-->
                <div class=""nav-tabs-custom"">
                    <!-- Tabs within a box -->
                    <ul class=""nav nav-tabs pull-right"">
                        <li class=""active""><a href=""#revenue-chart"" data-toggle=""tab"">Area</a></li>
                        <li><a href=""#sales-chart"" data-toggle=""tab"">Donut</a></li>
                        <li class=""pull-left header""><i class=""fa fa-inbox""></i> Sales</li>
                    </ul>
                    <div class=""tab-content no-padding"">
                        <!-- Morris chart - Sales -->
                        <div class=""chart tab-pane active"" id=""revenue-chart"" style=""position: relative; height: 300px;""></div>
                        <div class=""chart tab-pane"" id=""sales-chart"" style=""position: relative; height: 300px;""></div>
                    </div>
                </div>
                <!-- /.nav-tabs-custom -->
                <!-- quick email widget -->
      ");
            WriteLiteral(@"          <div class=""box box-info"">
                    <div class=""box-header"">
                        <i class=""fa fa-envelope""></i>

                        <h3 class=""box-title"">Quick Email</h3>
                        <!-- tools box -->
                        <div class=""pull-right box-tools"">
                            <button type=""button"" class=""btn btn-info btn-sm"" data-widget=""remove"" data-toggle=""tooltip""
                                    title=""Remove"">
                                <i class=""fa fa-times""></i>
                            </button>
                        </div>
                        <!-- /. tools -->
                    </div>
                    <div class=""box-body"">
                        ");
            EndContext();
            BeginContext(4960, 791, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e1af95e57f40a6b92aa623b99876de", async() => {
                BeginContext(4991, 753, true);
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control"" name=""emailto"" placeholder=""Email to:"">
                            </div>
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" name=""subject"" placeholder=""Subject"">
                            </div>
                            <div>
                                <textarea class=""textarea"" placeholder=""Message""
                                          style=""width: 100%; height: 125px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;""></textarea>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5751, 5918, true);
            WriteLiteral(@"
                    </div>
                    <div class=""box-footer clearfix"">
                        <button type=""button"" class=""pull-right btn btn-default"" id=""sendEmail"">
                            Send
                            <i class=""fa fa-arrow-circle-right""></i>
                        </button>
                    </div>
                </div>

            </section>
            <!-- /.Left col -->
            <!-- right col (We are only adding the ID to make the widgets sortable)-->
            <section class=""col-lg-5 connectedSortable"">

                <!-- Map box -->
                <div class=""box box-solid bg-light-blue-gradient"">
                    <div class=""box-header"">
                        <!-- tools box -->
                        <div class=""pull-right box-tools"">
                            <button type=""button"" class=""btn btn-primary btn-sm daterange pull-right"" data-toggle=""tooltip""
                                    title=""Date range"">
         ");
            WriteLiteral(@"                       <i class=""fa fa-calendar""></i>
                            </button>
                            <button type=""button"" class=""btn btn-primary btn-sm pull-right"" data-widget=""collapse""
                                    data-toggle=""tooltip"" title=""Collapse"" style=""margin-right: 5px;"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                        <!-- /. tools -->

                        <i class=""fa fa-map-marker""></i>

                        <h3 class=""box-title"">
                            Visitors
                        </h3>
                    </div>
                    <div class=""box-body"">
                        <div id=""world-map"" style=""height: 250px; width: 100%;""></div>
                    </div>
                    <!-- /.box-body-->
                    <div class=""box-footer no-border"">
                        <div class=""row"">
                            <");
            WriteLiteral(@"div class=""col-xs-4 text-center"" style=""border-right: 1px solid #f4f4f4"">
                                <div id=""sparkline-1""></div>
                                <div class=""knob-label"">Visitors</div>
                            </div>
                            <!-- ./col -->
                            <div class=""col-xs-4 text-center"" style=""border-right: 1px solid #f4f4f4"">
                                <div id=""sparkline-2""></div>
                                <div class=""knob-label"">Online</div>
                            </div>
                            <!-- ./col -->
                            <div class=""col-xs-4 text-center"">
                                <div id=""sparkline-3""></div>
                                <div class=""knob-label"">Exists</div>
                            </div>
                            <!-- ./col -->
                        </div>
                        <!-- /.row -->
                    </div>
                </div>
                <!-");
            WriteLiteral(@"- /.box -->
                <!-- solid sales graph -->
                <div class=""box box-solid bg-teal-gradient"">
                    <div class=""box-header"">
                        <i class=""fa fa-th""></i>

                        <h3 class=""box-title"">Sales Graph</h3>

                        <div class=""box-tools pull-right"">
                            <button type=""button"" class=""btn bg-teal btn-sm"" data-widget=""collapse"">
                                <i class=""fa fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn bg-teal btn-sm"" data-widget=""remove"">
                                <i class=""fa fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""box-body border-radius-none"">
                        <div class=""chart"" id=""line-chart"" style=""height: 250px;""></div>
                    </div>
                    <!-- /.box-body --");
            WriteLiteral(@">
                    <div class=""box-footer no-border"">
                        <div class=""row"">
                            <div class=""col-xs-4 text-center"" style=""border-right: 1px solid #f4f4f4"">
                                <input type=""text"" class=""knob"" data-readonly=""true"" value=""20"" data-width=""60"" data-height=""60""
                                       data-fgColor=""#39CCCC"">

                                <div class=""knob-label"">Mail-Orders</div>
                            </div>
                            <!-- ./col -->
                            <div class=""col-xs-4 text-center"" style=""border-right: 1px solid #f4f4f4"">
                                <input type=""text"" class=""knob"" data-readonly=""true"" value=""50"" data-width=""60"" data-height=""60""
                                       data-fgColor=""#39CCCC"">

                                <div class=""knob-label"">Online</div>
                            </div>
                            <!-- ./col -->
                 ");
            WriteLiteral(@"           <div class=""col-xs-4 text-center"">
                                <input type=""text"" class=""knob"" data-readonly=""true"" value=""30"" data-width=""60"" data-height=""60""
                                       data-fgColor=""#39CCCC"">

                                <div class=""knob-label"">In-Store</div>
                            </div>
                            <!-- ./col -->
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- /.box-footer -->
                </div>
                <!-- /.box -->
                <!-- Calendar -->
                

            </section>
            <!-- right col -->
        </div>
        <!-- /.row (main row) -->

    </section>
    <!-- /.content -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VacancyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
