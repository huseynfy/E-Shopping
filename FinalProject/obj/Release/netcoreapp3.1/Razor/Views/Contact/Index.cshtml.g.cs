#pragma checksum "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ced57a8d7127153ab0979b9a5bc222ea18b432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ced57a8d7127153ab0979b9a5bc222ea18b432", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d414041b85203ae56e00103cd60960b2a2e0ae1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger list-unstyled ml-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var message = ViewBag.SuccessMsg;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section>
    <div class=""container-fluid"">
        <div class=""row contactusrow"">
            <div class=""col-lg-6 col-md-12 col-sm-12"">
                <div>
                    <p class=""contactusheader"">Contact us</p>
                </div>
                <div class=""d-flex"">
                    <i class=""fas fa-home contactusicons""></i>
                    <p class=""contactuscolumns"">address</p>
                </div>
                <p class=""contactusdetails""> ");
#nullable restore
#line 17 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                        Write(Model.Contacts.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <div class=\"d-flex\">\r\n                    <i class=\"fas fa-phone-alt contactusicons\"></i>\r\n                    <p class=\"contactuscolumns\">phone</p>\r\n                </div>\r\n                <p class=\"contactusdetails\"> ");
#nullable restore
#line 23 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                        Write(Model.Contacts.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"d-flex\">\r\n                    <i class=\"fas fa-at contactusicons\"></i>\r\n                    <p class=\"contactuscolumns\">email</p>\r\n                </div>\r\n                <p class=\"contactusdetails\"> ");
#nullable restore
#line 28 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                        Write(Model.Contacts.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""col-lg-6 col-md-12 col-sm-12"">

                <div>
                    <p class=""contactusheader"">Send your message to us</p>
                </div>
                <div class=""row"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24ced57a8d7127153ab0979b9a5bc222ea18b4326348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 36 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24ced57a8d7127153ab0979b9a5bc222ea18b4327995", async() => {
                WriteLiteral(@"
                    <div>
                        <input type=""text"" name=""CustomerName"" class=""inputsincontactus"" placeholder=""Your name (required)*"">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""CustomerName"" data-valmsg-replace=""true""></span>
                    </div>
                    <div>
                        <input type=""email"" name=""CustomerEmail"" class=""inputsincontactus"" placeholder=""Your email (required)*"">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""CustomerEmail"" data-valmsg-replace=""true""></span>
                    </div>
                    <div>
                        <input type=""text"" name=""Subject"" class=""inputsincontactus"" placeholder=""Subject*"">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""Subject"" data-valmsg-replace=""true""></span>
                    </div>
                    <div>
                        <textarea name=""Post"" cl");
                WriteLiteral(@"ass=""inputsincontactus"" placeholder=""Post*""></textarea>
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""Post"" data-valmsg-replace=""true""></span>
                    </div>
                    <button type=""submit"" id=""btnsend"">Send</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    var message = ");
#nullable restore
#line 64 "C:\Users\Code\Desktop\C#\FinalProject\FinalProject\Views\Contact\Index.cshtml"
             Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    if(message){\r\n        alert(message);\r\n    }\r\n    </script>\r\n");
            }
            );
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
