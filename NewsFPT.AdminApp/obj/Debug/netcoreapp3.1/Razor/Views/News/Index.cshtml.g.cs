#pragma checksum "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed35ba67ce290ae00888db42095f43261ea8c90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\_ViewImports.cshtml"
using NewsFPT.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\_ViewImports.cshtml"
using NewsFPT.AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed35ba67ce290ae00888db42095f43261ea8c90", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1580056f37b1a5c74dcb9a753a7e2b16ffdd5f94", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BLL.ViewModel.NewsModels.NewsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>News management</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ed35ba67ce290ae00888db42095f43261ea8c903762", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    
        <thead>
            <tr>
                <th>
                    ID
                </th>
                <th>
                    Title
                </th>                
                <th>
                    Date Submitted
                </th>
                <th>
                    Channel ID
                </th>
                <th>
                    Link Image
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 37 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NewsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NewsTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>                  \r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DayOfPost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ChannelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LinkImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.NewsId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 57 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id=item.NewsId  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 58 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.NewsId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "F:\CN9\SWD\Hosts\NewsFPT.AdminApp\NewsFPT.AdminApp\Views\News\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BLL.ViewModel.NewsModels.NewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
