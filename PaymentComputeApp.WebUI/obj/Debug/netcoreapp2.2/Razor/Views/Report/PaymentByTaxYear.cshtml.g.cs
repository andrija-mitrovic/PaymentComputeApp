#pragma checksum "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993843816f4dc6c6f4d8fd1bc56091767a832ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_PaymentByTaxYear), @"mvc.1.0.view", @"/Views/Report/PaymentByTaxYear.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/PaymentByTaxYear.cshtml", typeof(AspNetCore.Views_Report_PaymentByTaxYear))]
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
#line 1 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\_ViewImports.cshtml"
using PaymentComputeApp.WebUI;

#line default
#line hidden
#line 2 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\_ViewImports.cshtml"
using PaymentComputeApp.WebUI.Models;

#line default
#line hidden
#line 3 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\_ViewImports.cshtml"
using PaymentComputeApp.Core.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993843816f4dc6c6f4d8fd1bc56091767a832ce0", @"/Views/Report/PaymentByTaxYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693bc087f324f5845a8ff13143aa10a57e79e1c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_PaymentByTaxYear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<PaymentIndexViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentByTaxYear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("example2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-dt-idx", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
  
    ViewData["Title"] = "PaymentByTaxYear";

#line default
#line hidden
            BeginContext(95, 301, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""col-md-12 grid-margin stretch-card pt-2"">
        <div class=""card"">
            <div class=""card-body"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(396, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993843816f4dc6c6f4d8fd1bc56091767a832ce06448", async() => {
                BeginContext(440, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(448, 174, true);
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">Payment report</li>\r\n                    </ol>\r\n                </nav><br /><br />\r\n\r\n\r\n");
            EndContext();
#line 19 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
            BeginContext(684, 330, true);
            WriteLiteral(@"                    <div class=""form-row"">
                        <div class=""form-group col-md-1 font-weight-bold pt-1"">
                            <label>Tax Year: </label>
                        </div>
                        <div class=""form-group col-md-3 font-italic font-weight-bolder"">
                            ");
            EndContext();
            BeginContext(1015, 62, false);
#line 26 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                       Write(Html.TextBox("taxYear", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 273, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-3 font-italic font-weight-bolder"">
                            <input type=""submit"" class=""btn btn-info"" value=""Search"" />
                        </div>
                    </div>
");
            EndContext();
#line 32 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                }

#line default
#line hidden
            BeginContext(1369, 30, true);
            WriteLiteral("\r\n                <hr />\r\n\r\n\r\n");
            EndContext();
#line 37 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                 if (Model != null && Model.Count() > 0)
                {

#line default
#line hidden
            BeginContext(1476, 1906, true);
            WriteLiteral(@"                    <div class=""dataTables_wrapper dt-bootstrap4"">
                        <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
                            <div class=""col-sm-12"">
                                <table class=""table table-bordered table-hover dataTable"" role=""grid"">
                                    <thead>
                                        <tr role=""row"">
                                            <th rowspan=""1"" colspan=""1"">
                                                Employee
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Payment Date
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Month
                                            </th>
     ");
            WriteLiteral(@"                                       <th rowspan=""1"" colspan=""1"">
                                                Tax Year
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Total Earnings
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Total Deductions
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Net Payment
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 69 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(3495, 125, true);
            WriteLiteral("                                            <tr role=\"row\" class=\"odd\">\r\n                                                <td>");
            EndContext();
            BeginContext(3621, 13, false);
#line 72 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3634, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3694, 35, false);
#line 73 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3729, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3789, 13, false);
#line 74 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.PayMonth);

#line default
#line hidden
            EndContext();
            BeginContext(3802, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3862, 9, false);
#line 75 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3871, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3931, 32, false);
#line 76 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.TotalEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3963, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4023, 33, false);
#line 77 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.TotalDeduction.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(4056, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4116, 29, false);
#line 78 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                               Write(item.NetPayment.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4145, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 80 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4246, 190, true);
            WriteLiteral("\r\n\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
            EndContext();
#line 89 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"



                    var disabledPrevious = Model.CurrentPage > 1 ? "" : "disabled";
                    var disabledNext = Model.CurrentPage < Model.TotalPages ? "" : "disabled";




#line default
#line hidden
            BeginContext(4629, 72, true);
            WriteLiteral("                    <ul class=\"pagination\">\r\n                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4701, "\"", 4761, 4);
            WriteAttributeValue("", 4709, "paginate_button", 4709, 15, true);
            WriteAttributeValue(" ", 4724, "page-item", 4725, 10, true);
            WriteAttributeValue(" ", 4734, "previous", 4735, 9, true);
#line 98 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
WriteAttributeValue(" ", 4743, disabledPrevious, 4744, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4762, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(4793, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993843816f4dc6c6f4d8fd1bc56091767a832ce017603", async() => {
                BeginContext(5027, 8, true);
                WriteLiteral("Previous");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-taxYear", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                      WriteLiteral(ViewData["taxYear"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taxYear"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-taxYear", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taxYear"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 101 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                          WriteLiteral(Model.CurrentPage-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5039, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 104 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                         for (int i = 1; i <= Model.TotalPages; i++)
                        {
                            var disabledButton = (i != Model.CurrentPage) ? "" : "disabled";

#line default
#line hidden
            BeginContext(5263, 31, true);
            WriteLiteral("                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5294, "\"", 5343, 3);
            WriteAttributeValue("", 5302, "paginate_button", 5302, 15, true);
            WriteAttributeValue(" ", 5317, "page-item", 5318, 10, true);
#line 107 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
WriteAttributeValue(" ", 5327, disabledButton, 5328, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5344, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(5379, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993843816f4dc6c6f4d8fd1bc56091767a832ce021922", async() => {
                BeginContext(5624, 1, false);
#line 110 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                                                                                                                Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-taxYear", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                          WriteLiteral(ViewData["taxYear"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taxYear"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-taxYear", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taxYear"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 110 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                             WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5629, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 112 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                        }

#line default
#line hidden
            BeginContext(5693, 31, true);
            WriteLiteral("\r\n\r\n                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5724, "\"", 5776, 4);
            WriteAttributeValue("", 5732, "paginate_button", 5732, 15, true);
            WriteAttributeValue(" ", 5747, "page-item", 5748, 10, true);
            WriteAttributeValue(" ", 5757, "next", 5758, 5, true);
#line 115 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
WriteAttributeValue(" ", 5762, disabledNext, 5763, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5777, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(5808, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993843816f4dc6c6f4d8fd1bc56091767a832ce026631", async() => {
                BeginContext(6042, 4, true);
                WriteLiteral("Next");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-taxYear", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 117 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                      WriteLiteral(ViewData["taxYear"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taxYear"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-taxYear", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taxYear"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 118 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                                          WriteLiteral(Model.CurrentPage+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6050, 60, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n");
            EndContext();
#line 122 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTaxYear.cshtml"
                }

#line default
#line hidden
            BeginContext(6129, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<PaymentIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
