#pragma checksum "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0a9aae3c1c052ddfbc13b19d127f1a10ba6a60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\_ViewImports.cshtml"
using OxyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\_ViewImports.cshtml"
using OxyWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0a9aae3c1c052ddfbc13b19d127f1a10ba6a60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1083ec83a523b5769e737ebc5f0b2f10fdd7d201", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OxyWeb.ViewModels.VLogin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bg_auth_2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 vh-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit: cover; object-position: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "login";
    Layout = "~/Views/Shared/_LayoutIndex.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex\">\r\n    <div class=\"col-12 col-sm-4 d-none d-sm-block\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c0a9aae3c1c052ddfbc13b19d127f1a10ba6a604433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
    <div class=""col-12 col-sm-8"">
        <section class=""vh-100"">
            <div class=""container-fluid h-100"">
                <div class=""row align-items-center h-100"">
                    <div class=""col-12"">
                        <div class=""row"">
");
#nullable restore
#line 16 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
                             using (Html.BeginForm("Index", "Home", FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-12 col-sm-8 offset-sm-2 col-lg-6 offset-lg-3"">
                                    <div class=""form-group mb-3"">
                                        <label for=""Email"">Email</label>
                                        ");
#nullable restore
#line 21 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.user, new { @class = "form-control", @type = "email", placeholder = "Enter your email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group mb-3\">\r\n                                        <label for=\"Pass\">Password</label>\r\n                                        ");
#nullable restore
#line 25 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.pass, new { @class = "form-control", @type = "password", placeholder = "Enter your password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                    <div class=""form-group mb-3"">
                                        <button type=""submit"" id=""Signin"" class=""btn btn-info text-white"" style=""width:100%""> <i class=""me-3 bi bi-door-open""></i>Sign-in</button>
                                    </div>
                                </div>
");
#nullable restore
#line 31 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"liveAlertPlaceholder\"></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        if ((\'");
#nullable restore
#line 42 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
         Write(Model.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').toUpperCase() == \'TRUE\') {\r\n            alert(\'");
#nullable restore
#line 43 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Home\Index.cshtml"
              Write(Model.Mensaje);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
        }

        function alert(message) {
            $(""#liveAlertPlaceholder"").html('<div class=""alert alert-danger alert-dismissible"" role=""alert"">' + message + '<button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button></div>');            
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OxyWeb.ViewModels.VLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591