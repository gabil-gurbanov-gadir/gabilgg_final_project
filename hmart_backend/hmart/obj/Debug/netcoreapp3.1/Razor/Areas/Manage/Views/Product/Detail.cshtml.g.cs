#pragma checksum "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e16f3b7437141cf6464cc26410632370c4dbaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/Manage/Views/Product/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e16f3b7437141cf6464cc26410632370c4dbaa", @"/Areas/Manage/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c48d25850841ffa4564cd48f5c86faf2d5c3400", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
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
#line 2 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div id=""page-inner"">
        <div class=""row d-flex j-c-sb a-i-c before_after-none"">
            <div class=""col-md-3"">
                <h1>Product</h1>
            </div>
            <div class=""col-md-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e16f3b7437141cf6464cc26410632370c4dbaa5374", async() => {
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
            <div class=""col-lg-6"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-12"">
                        <div class=""card bg-orange"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Name</span>
                                <p>
                                    ");
#nullable restore
#line 24 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-sm-12"">
                        <div class=""card bg-red"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Code</span>
                                <p>
                                    ");
#nullable restore
#line 34 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-5 col-sm-12"">
                        <div class=""card bg-yellow"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Dimensions</span>
                                <p>
                                    ");
#nullable restore
#line 44 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Dimensions);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-7 col-sm-12"">
                        <div class=""card bg-green"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Materials</span>
                                <p>
                                    ");
#nullable restore
#line 54 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Materials);

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
            <div class=""col-lg-6"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""card bg-purple"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Cost Price</span>
                                <p>
                                    ");
#nullable restore
#line 68 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.CostPrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""card bg-violet"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Price</span>
                                <p>
                                    ");
#nullable restore
#line 78 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Price.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-7"">
                        <div class=""card bg-light-blue"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Discount Percent</span>
                                <p>
                                    ");
#nullable restore
#line 88 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-5"">
                        <div class=""card bg-blue"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Weight</span>
                                <p>
                                    ");
#nullable restore
#line 98 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Weight);

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
            <div class=""col-lg-4 col-md-7"">
                <div class=""card bg-light-blue"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Other Info</span>
                        <p>
                            ");
#nullable restore
#line 112 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                       Write(Model.OtherInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-2 col-md-5\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 4999, "\"", 5050, 2);
            WriteAttributeValue("", 5007, "card", 5007, 4, true);
#nullable restore
#line 118 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
WriteAttributeValue(" ", 5011, Model.IsOnOffer?"bg-green":"bg-red", 5012, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-content white-text\">\r\n                        <span class=\"card-title\">Is On Offer</span>\r\n                        <p>\r\n                            ");
#nullable restore
#line 122 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                        Write(Model.IsOnOffer ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12"">
                <div class=""card bg-green"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Description</span>
                        <p>
                            ");
#nullable restore
#line 132 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                       Write(Model.Desc);

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
            <div class=""col-lg-6"">
                <div class=""card bg-yellow"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Tags</span>
");
#nullable restore
#line 143 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                          
                            var tags = "";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                         foreach (var item in Model.ProductTagProducts)
                        {
                            if (item.Id != Model.ProductTagProducts.LastOrDefault().Id)
                            {
                                tags += item.ProductTag.Name + ", ";
                            }
                            else
                            {
                                tags += item.ProductTag.Name;
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            ");
#nullable restore
#line 159 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                       Write(tags);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""card"">
                    <div class=""card-content"">
                        <span class=""card-title"">Colors: </span>
                        <p>
");
#nullable restore
#line 169 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                             foreach (var item in Model.ProductColors)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"color-name mr-1\"");
            BeginWriteAttribute("style", "\r\n                                      style=\"", 7166, "\"", 7247, 2);
            WriteAttributeValue("", 7213, "background-color:#", 7213, 18, true);
#nullable restore
#line 172 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
WriteAttributeValue("", 7231, item.Color.Code, 7231, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 172 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                                                                            Write(item.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 173 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row m-0"">
                    <div class=""col-md-3"">
                        <div class=""card orange"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Category: </span>
                                <p>
                                    ");
#nullable restore
#line 187 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""card red"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Brand: </span>
                                <p>
                                    ");
#nullable restore
#line 197 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""card bg-purple"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Count: </span>
                                <p>
                                    ");
#nullable restore
#line 207 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""card bg-violet"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Create At: </span>
                                <p>
                                    ");
#nullable restore
#line 217 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                               Write(Model.CreatedAt.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 226 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
              

                ProImage poster = Model?.ProImages.FirstOrDefault(x => x.PosterStatus == true);
                ProImage hoverPoster = Model?.ProImages.FirstOrDefault(x => x.PosterStatus == false);
                List<ProImage> images = Model?.ProImages.Where(x => x.PosterStatus == null).ToList();
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""card bg-blue"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Poster Image</span>
                        <div class=""image"">
                            <img style=""width: 100%""");
            BeginWriteAttribute("src", " src=\"", 10131, "\"", 10168, 2);
            WriteAttributeValue("", 10137, "/uploads/products/", 10137, 18, true);
#nullable restore
#line 237 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
WriteAttributeValue("", 10155, poster.Image, 10155, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card bg-light-blue"">
                    <div class=""card-content white-text"">
                        <span class=""card-title"">Poster Image</span>
                        <div class=""image"">
                            <img style=""width: 100%""");
            BeginWriteAttribute("src", " src=\"", 10590, "\"", 10632, 2);
            WriteAttributeValue("", 10596, "/uploads/products/", 10596, 18, true);
#nullable restore
#line 247 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
WriteAttributeValue("", 10614, hoverPoster.Image, 10614, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 254 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
             if (images != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 256 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                 foreach (var item in images)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-3"">
                        <div class=""card bg-light-green"">
                            <div class=""card-content white-text"">
                                <span class=""card-title"">Poster Image</span>
                                <div class=""image"">
                                    <img style=""width: 100%""");
            BeginWriteAttribute("src", " src=\"", 11261, "\"", 11296, 2);
            WriteAttributeValue("", 11267, "/uploads/products/", 11267, 18, true);
#nullable restore
#line 263 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
WriteAttributeValue("", 11285, item.Image, 11285, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 268 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 268 "D:\code\final_project\gabilgg_final_project\hmart_backend\hmart\Areas\Manage\Views\Product\Detail.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
