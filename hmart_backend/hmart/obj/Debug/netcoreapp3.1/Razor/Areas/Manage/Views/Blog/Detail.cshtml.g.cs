#pragma checksum "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e548e7ac191bbecc5b0d339f3bdcabef15ee51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Blog_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e548e7ac191bbecc5b0d339f3bdcabef15ee51d", @"/Areas/Manage/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c48d25850841ffa4564cd48f5c86faf2d5c3400", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div id=""page-inner"">
        <div class=""row d-flex j-c-sb a-i-c before_after-none"">
            <div class=""col-md-3"">
                <h1>Blog</h1>
            </div>
            <div class=""col-md-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e548e7ac191bbecc5b0d339f3bdcabef15ee51d5350", async() => {
                WriteLiteral("Back To Table");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-12"">
                        <div class=""card bg-orange"">
                            <div class=""card-content black-text"">
                                <span class=""card-title"">Title</span>
                                <p>
                                    ");
#nullable restore
#line 24 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-12"">
                        <div class=""card bg-red"">
                            <div class=""card-content black-text"">
                                <span class=""card-title"">Date</span>
                                <p>
                                    ");
#nullable restore
#line 34 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                               Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-12"">
                        <div class=""card bg-yellow"">
                            <div class=""card-content black-text"">
                                <span class=""card-title"">Author</span>
                                <p>
                                    ");
#nullable restore
#line 44 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                               Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6 col-md-12"">
                <div class=""card bg-light-green"">
                    <div class=""card-content black-text"">
                        <span class=""card-title"">Description</span>
                        <p>
                            ");
#nullable restore
#line 58 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                       Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12"">
                <div class=""card bg-light-blue"">
                    <div class=""card-content black-text"">
                        <span class=""card-title"">Tags</span>
");
#nullable restore
#line 67 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                          
                            var tags = "";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                         foreach (var item in Model.BlogTagBlogs)
                        {
                            if (item.Id != Model.BlogTagBlogs.LastOrDefault().Id)
                            {
                                tags += item.BlogTag.Name + ", ";
                            }
                            else
                            {
                                tags += item.BlogTag.Name;
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            ");
#nullable restore
#line 83 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                       Write(tags);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card bg-blue"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Blog Image</span>
                        <div class=""image"">
                            <img style=""width: 100%""");
            BeginWriteAttribute("src", " src=\"", 3799, "\"", 3832, 2);
            WriteAttributeValue("", 3805, "/uploads/blogs/", 3805, 15, true);
#nullable restore
#line 97 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 3820, Model.Image, 3820, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 3958, "\"", 4012, 2);
            WriteAttributeValue("", 3966, "col-md-4", 3966, 8, true);
#nullable restore
#line 102 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
WriteAttributeValue(" ", 3974, Model.TeaxtImage!=null?"":"d-none", 3975, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""card bg-violet"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Blog Text Image</span>
                        <div class=""image"">
                            <img style=""width: 100%""");
            BeginWriteAttribute("src", " src=\"", 4291, "\"", 4357, 2);
            WriteAttributeValue("", 4297, "/uploads/blogs/", 4297, 15, true);
#nullable restore
#line 107 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 4312, Model.TeaxtImage!=null?Model.TeaxtImage:"", 4312, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 col-md-12"">
                <div class=""card bg-green"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Text</span>
                        <p>
                            ");
#nullable restore
#line 119 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Blog\Detail.cshtml"
                       Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
