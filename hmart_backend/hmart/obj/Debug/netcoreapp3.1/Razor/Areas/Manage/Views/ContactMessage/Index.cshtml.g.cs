#pragma checksum "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7e2490402744cd8a08620902bc0d411c5e10e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_ContactMessage_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/ContactMessage/Index.cshtml")]
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
#line 1 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\_ViewImports.cshtml"
using hmart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\_ViewImports.cshtml"
using hmart.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\_ViewImports.cshtml"
using hmart.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\_ViewImports.cshtml"
using hmart.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7e2490402744cd8a08620902bc0d411c5e10e8", @"/Areas/Manage/Views/ContactMessage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c48d25850841ffa4564cd48f5c86faf2d5c3400", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_ContactMessage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div id=""page-inner"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-action"">
                        Contact Messages Table
                    </div>
                    <div class=""card-content"">
                        <div class=""table-responsive"">
                            <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                                <thead>
                                    <tr>
                                        <th>First Name</th>
                                        <th>Last Name</th>
                                        <th>E-mail</th>
                                        <th style=""width:85px"">CreateAt</th>
                                        <th>Subject</th>
                                        <th>Message</th>
                                        <th>Button</th>
               ");
            WriteLiteral("                     </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 29 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 32 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 33 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                                           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 34 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 35 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                                           Write(item.CreateAt.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 36 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 37 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                       Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7e2490402744cd8a08620902bc0d411c5e10e88658", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 40 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\ContactMessage\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591