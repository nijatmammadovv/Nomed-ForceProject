#pragma checksum "C:\Users\hp\source\repos\Nomed Force Project\Nomed Force Project\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9e7cecf19cdeac6c317ae7a2aba8ff949e2f67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\Nomed Force Project\Nomed Force Project\Views\_ViewImports.cshtml"
using Nomed_Force_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\Nomed Force Project\Nomed Force Project\Views\_ViewImports.cshtml"
using Nomed_Force_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9e7cecf19cdeac6c317ae7a2aba8ff949e2f67", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c5b37a1b5158ca7a5e1e0736f42e30f58136be", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc9e7cecf19cdeac6c317ae7a2aba8ff949e2f673321", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
            crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
    <title>Nomad Force</title>
    <link rel=""stylesheet"" href=""assets/css/style.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc9e7cecf19cdeac6c317ae7a2aba8ff949e2f675232", async() => {
                WriteLiteral(@"
    <div class=""hero"">
        <div class=""hero-image""
             style=""background-image: url(assets/images/Web_150DPI-20190927_10th_Floor_Conference_Room_2_v1-1120x630.jpg);"">
            <div class=""text-center hero-text"">
                <h1>Nomad Force</h1>
                <p>create a great video for your website</p>
            </div>
        </div>
    </div>
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""container-fluid"">
            <a class=""navbar-brand"" href=""#"">Nomad Force</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNav""
                    aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
        </div>
        <div class=""container"">
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav"">
                    <li ");
                WriteLiteral(@"class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">
                            Home <i class=""bi bi-arrow-up-right-circle-fill""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link icon"" href=""#"">
                            Our Studio <i class=""bi bi-arrow-up-right-circle-fill""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link icon"" href=""#"">Portfolio <i class=""bi bi-arrow-up-right-circle-fill""></i></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link icon"" href=""#"">
                            News & Events <i class=""bi bi-arrow-up-right-circle-fill""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link icon");
                WriteLiteral("\" href=\"#\">\r\n                            Contact Us <i class=\"bi bi-arrow-up-right-circle-fill\"></i>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    ");
#nullable restore
#line 68 "C:\Users\hp\source\repos\Nomed Force Project\Nomed Force Project\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer class=""bg-dark text-center text-white"">
        <!-- Grid container -->
        <div class=""container p-4 pb-0"">
            <!-- Section: Social media -->
            <section class=""mb-4"">
                <!-- Facebook -->
                <a class=""btn btn-primary btn-floating m-1""
                   style=""background-color: #3b5998;""
                   href=""#!""
                   role=""button"">
                    <i class=""bi bi-facebook""></i>
                </a>

                <!-- Twitter -->
                <a class=""btn btn-primary btn-floating m-1""
                   style=""background-color: #55acee;""
                   href=""#!""
                   role=""button"">
                    <i class=""bi bi-twitter""></i>
                </a>

                <!-- Google -->
                <a class=""btn btn-primary btn-floating m-1""
                   style=""background-color: #dd4b39;""
                   href=""#!""
                   role=""button"">
                  ");
                WriteLiteral(@"  <i class=""bi bi-google""></i>
                </a>

                <!-- Instagram -->
                <a class=""btn btn-primary btn-floating m-1""
                   style=""background-color: #ac2bac;""
                   href=""#!""
                   role=""button"">
                    <i class=""bi bi-instagram""></i>
                </a>

                <!-- Linkedin -->
                <a class=""btn btn-primary btn-floating m-1""
                   style=""background-color: #0082ca;""
                   href=""#!""
                   role=""button"">
                    <i class=""bi bi-linkedin""></i>
                </a>
                <!-- Github -->
                <a class=""btn btn-primary btn-floating m-1""
                   style=""background-color: #333333;""
                   href=""#!""
                   role=""button"">
                    <i class=""bi bi-github""></i>
                </a>
            </section>
            <!-- Section: Social media -->
        </div>
        <!-- G");
                WriteLiteral(@"rid container -->
        <!-- Copyright -->
        <div class=""text-center p-3"" style=""background-color: rgba(0, 0, 0, 0.2);"">
            Copyright © Nomad Force 2021
            <a class=""text-white"" href=""https://mdbootstrap.com/"" style=""text-decoration: none;"">Design: TemplateMo</a>
        </div>
        <!-- Copyright -->
    </footer>
    <script src=""assets/js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
