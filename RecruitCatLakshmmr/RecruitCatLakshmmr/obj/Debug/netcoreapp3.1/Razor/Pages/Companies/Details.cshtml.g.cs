#pragma checksum "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324f4c6eb4997aa573f4f1cff7a8996ffd4f6863"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecruitCatLakshmmr.Pages.Companies.Pages_Companies_Details), @"mvc.1.0.razor-page", @"/Pages/Companies/Details.cshtml")]
namespace RecruitCatLakshmmr.Pages.Companies
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
#line 1 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/_ViewImports.cshtml"
using RecruitCatLakshmmr;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"324f4c6eb4997aa573f4f1cff7a8996ffd4f6863", @"/Pages/Companies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190f12ceca0b7342568c6d20460c437642f3d774", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Companies_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Candidates/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
  
    ViewData["Title"] = "Company Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Company : ");
#nullable restore
#line 8 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
         Write(Html.DisplayFor(model => model.Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyLocaton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyLocaton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyEmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyEmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.MinSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 47 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
        Write(Html.DisplayFor(model => model.Company.MinSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.MaxSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 53 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
        Write(Html.DisplayFor(model => model.Company.MaxSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.IsPositionAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 65 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
             if (Model.Company.IsPositionAvailable)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Yes</span>\r\n");
#nullable restore
#line 68 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No</span>\r\n");
#nullable restore
#line 73 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyIndustry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyIndustry.IndustryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.JobPositionTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.JobPositionTitle.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
#nullable restore
#line 95 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
     if (Model.Company.Candidates != null && Model.Company.Candidates.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h5>Candidates:</h5>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Candidate Name</th>
                    <th>Experience</th>
                    <th class=""text-right"">Target Salary</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 107 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                 foreach (var candidate in Model.Company.Candidates)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 110 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                       Write(candidate.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 111 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                       Write(candidate.YearsOfExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\">");
#nullable restore
#line 112 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                                          Write(candidate.TargetSalary.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "324f4c6eb4997aa573f4f1cff7a8996ffd4f686315494", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                                                                WriteLiteral(candidate.CandidateId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 115 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 118 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "324f4c6eb4997aa573f4f1cff7a8996ffd4f686318235", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "/Users/madhuri/Documents/GitHub/IS7012/RecruitCatLakshmmr/RecruitCatLakshmmr/Pages/Companies/Details.cshtml"
                           WriteLiteral(Model.Company.CompanyId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "324f4c6eb4997aa573f4f1cff7a8996ffd4f686320389", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecruitCatLakshmmr.Pages.Companies.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecruitCatLakshmmr.Pages.Companies.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecruitCatLakshmmr.Pages.Companies.DetailsModel>)PageContext?.ViewData;
        public RecruitCatLakshmmr.Pages.Companies.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
