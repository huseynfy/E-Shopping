#pragma checksum "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c748d6df500c63c6f7dbf2a9cb9460f5da99b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 2 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c748d6df500c63c6f7dbf2a9cb9460f5da99b6e", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d414041b85203ae56e00103cd60960b2a2e0ae1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("380px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
             foreach (Blog item in Model.Blogs.Take(1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-1\">\r\n                    <div class=\"blogimage\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c748d6df500c63c6f7dbf2a9cb9460f5da99b6e4453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 344, "~/img/", 344, 6, true);
#nullable restore
#line 12 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 350, item.Image, 350, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-5\">\r\n                    <p id=\"titleofblognews\">");
#nullable restore
#line 16 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"d-flex\">\r\n                        <p class=\"blogdetails\"><i class=\"far fa-clock blogicons\"></i> ");
#nullable restore
#line 18 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                 Write(item.DateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-user blogicons\"></i> ");
#nullable restore
#line 19 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                Write(item.Commentator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-comments blogicons\"></i> ");
#nullable restore
#line 20 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                    Write(item.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</p>\r\n                    </div>\r\n                    <div>\r\n                        <p id=\"bloginfo\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                       Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-lg-4 col-md-6 col-sm-12 mt-5"">
                <div>
                    <p class=""headinblogsidebar"">latest news</p>
                </div>
                <div class=""d-flex"">
                    <img src=""img/blogmini.jpg"" width=""100px"" height=""70px"">
                    <p class=""textoflatestnews"">how to protect ourselves from coronovirus?</p>
                </div>
                <div class=""d-flex"">
                    <img src=""img/blogmini.jpg"" width=""100px"" height=""70px"">
                    <p class=""textoflatestnews"">what is going on over crude oil?</p>
                </div>
                <div class=""d-flex mt-2"">
                    <img src=""img/blogmini.jpg"" width=""100px"" height=""70px"">
                    <p class=""textoflatestnews"">how to avoid financial crisis?</p>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 49 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
             foreach (Blog item in Model.Blogs.Skip(1).Take(1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-1\">\r\n                    <div class=\"blogimage\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c748d6df500c63c6f7dbf2a9cb9460f5da99b6e9808", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2369, "~/img/", 2369, 6, true);
#nullable restore
#line 53 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 2375, item.Image, 2375, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-5\">\r\n                    <p id=\"titleofblognews\">");
#nullable restore
#line 57 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"d-flex\">\r\n                        <p class=\"blogdetails\"><i class=\"far fa-clock blogicons\"></i> ");
#nullable restore
#line 59 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                 Write(item.DateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-user blogicons\"></i> ");
#nullable restore
#line 60 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                Write(item.Commentator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-comments blogicons\"></i> ");
#nullable restore
#line 61 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                    Write(item.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</p>\r\n                    </div>\r\n                    <div>\r\n                        <p id=\"bloginfo\">\r\n                            ");
#nullable restore
#line 65 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                       Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 69 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-4 col-md-6 col-sm-12 mt-5"">
                <div>
                    <p class=""headinblogsidebar"">text widget</p>
                </div>
                <div>
                    <p id=""blogtextwidget"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Hic praesentium ratione, ipsam quis nostrum quidem cumque animi explicabo aliquid soluta delectus eligendi minima corporis quisquam qui temporibus dolores laborum ullam! Lorem ipsum dolor sit, amet consectetur adipisicing elit. Natus quasi aut iste fuga sed eius est exercitationem ipsum, nostrum velit. Aperiam ad mollitia accusamus hic dicta sit veritatis cupiditate dolore.</p>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 80 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
             foreach (Blog item in Model.Blogs.Skip(2).Take(1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-1\">\r\n                    <div class=\"blogimage\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c748d6df500c63c6f7dbf2a9cb9460f5da99b6e14976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4231, "~/img/", 4231, 6, true);
#nullable restore
#line 84 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 4237, item.Image, 4237, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-5\">\r\n                    <p id=\"titleofblognews\">");
#nullable restore
#line 88 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"d-flex\">\r\n                        <p class=\"blogdetails\"><i class=\"far fa-clock blogicons\"></i> ");
#nullable restore
#line 90 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                 Write(item.DateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-user blogicons\"></i> ");
#nullable restore
#line 91 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                Write(item.Commentator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-comments blogicons\"></i> ");
#nullable restore
#line 92 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                    Write(item.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</p>\r\n                    </div>\r\n                    <div>\r\n                        <p id=\"bloginfo\">\r\n                            ");
#nullable restore
#line 96 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                       Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 100 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-4 col-md-6 col-sm-12 mt-5"">
                <div>
                    <p class=""headinblogsidebar"">tags widget</p>
                </div>
                <div class=""divtagwidgets"">
                    <a href=""#"" class=""blogtagwidget"">insurance</a>
                    <a href=""#"" class=""blogtagwidget"">tax plans</a>
                </div>
                <div class=""divtagwidgets"">
                    <a href=""#"" class=""blogtagwidget"">investments</a>
                    <a href=""#"" class=""blogtagwidget"">retirement plans</a>
                </div>

                <div class=""divtagwidgets"">
                    <a href=""#"" class=""blogtagwidget"">mutual funds</a>
                    <a href=""#"" class=""blogtagwidget"">business plans</a>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 121 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
             foreach (Blog item in Model.Blogs.Skip(3))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-1\">\r\n                    <div class=\"blogimage\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c748d6df500c63c6f7dbf2a9cb9460f5da99b6e20277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6195, "~/img/", 6195, 6, true);
#nullable restore
#line 125 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 6201, item.Image, 6201, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-12 mt-5 mr-5\">\r\n                    <p id=\"titleofblognews\">");
#nullable restore
#line 129 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"d-flex\">\r\n                        <p class=\"blogdetails\"><i class=\"far fa-clock blogicons\"></i> ");
#nullable restore
#line 131 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                 Write(item.DateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-user blogicons\"></i> ");
#nullable restore
#line 132 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                Write(item.Commentator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"blogdetails\"><i class=\"fas fa-comments blogicons\"></i> ");
#nullable restore
#line 133 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                                                                                    Write(item.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</p>\r\n                    </div>\r\n                    <div>\r\n                        <p id=\"bloginfo\">\r\n                            ");
#nullable restore
#line 137 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
                       Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 141 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
