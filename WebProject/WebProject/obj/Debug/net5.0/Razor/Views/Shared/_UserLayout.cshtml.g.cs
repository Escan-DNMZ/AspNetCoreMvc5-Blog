#pragma checksum "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\_UserLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eef94b7a768d113dcb6222b25702e79cae501f46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserLayout), @"mvc.1.0.view", @"/Views/Shared/_UserLayout.cshtml")]
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
#line 1 "C:\Users\escan\source\repos\WebProject\WebProject\Views\_ViewImports.cshtml"
using WebProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\escan\source\repos\WebProject\WebProject\Views\_ViewImports.cshtml"
using WebProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\escan\source\repos\WebProject\WebProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eef94b7a768d113dcb6222b25702e79cae501f46", @"/Views/Shared/_UserLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155bedd31a00e884a93f6e3409a4601fe1e6becc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\_UserLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eef94b7a768d113dcb6222b25702e79cae501f463693", async() => {
                WriteLiteral(@"
    <title>Weblog a Blogging Category Bootstrap responsive WebTemplate | Blog3 :: w3layouts</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta charset=""utf-8"">
    <meta name=""keywords"" content=""Weblog a Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template,
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design"" />

    <script>
		addEventListener(""load"", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
    </script>
    <link href=""/web/css/bootstrap.css"" rel='stylesheet' type='text/css' />
    <link rel=""stylesheet"" href=""/web/css/single.css"">
    <link href=""/web/css/style.css"" rel='stylesheet' type='text/css' />
    <link href=""/web/css/fontawesome-all.css"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600");
                WriteLiteral(",600i,700,700i,800\"\r\n          rel=\"stylesheet\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eef94b7a768d113dcb6222b25702e79cae501f465801", async() => {
                WriteLiteral(@"
    <!--Header-->

    <header>
        <div class=""top-bar_sub_w3layouts container-fluid"">
            <div class=""row"">
                <div class=""col-md-4 logo text-left"">
                    <a class=""navbar-brand"" href=""index.html"">
                        <i class=""fab fa-linode""></i> Weblog
                    </a>
                </div>
              
                ");
#nullable restore
#line 46 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\_UserLayout.cshtml"
           Write(await Html.PartialAsync("Partial2"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                <div class=""col-md-4 log-icons text-right"">

                    <ul class=""social_list1 mt-3"">

                        <li>
                            <a href=""#"" class=""facebook1 mx-2"">
                                <i class=""fab fa-facebook-f""></i>

                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""twitter2"">
                                <i class=""fab fa-twitter""></i>

                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""dribble3 mx-2"">
                                <i class=""fab fa-dribbble""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""pin"">
                                <i class=""fab fa-pinterest-p""></i>
                            </a>
                        </li>
             ");
                WriteLiteral("       </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        ");
#nullable restore
#line 79 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\_UserLayout.cshtml"
   Write(await Html.PartialAsync("Partial1"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        
    </header>
    <!--//header-->
    <!--/banner-->
    <div class=""banner-inner"">
    </div>
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item"">
            <a href=""index.html"">Home</a>
        </li>
        <li class=""breadcrumb-item active"">Blog3</li>
    </ol>
    <!--//banner-->
    <!--/main-->
    ");
#nullable restore
#line 94 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\_UserLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--//main-->\r\n    <!--footer-->\r\n    ");
#nullable restore
#line 97 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\_UserLayout.cshtml"
Write(await Html.PartialAsync("Partial3"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!---->
    <!-- js -->
    <script src=""/web/js/jquery-2.2.3.min.js""></script>
    <!-- //js -->
    <!--/ start-smoth-scrolling -->
    <script src=""/web/js/move-top.js""></script>
    <script src=""/web/js/easing.js""></script>
    <script>
		jQuery(document).ready(function ($) {
			$("".scroll"").click(function (event) {
				event.preventDefault();
				$('html,body').animate({
					scrollTop: $(this.hash).offset().top
				}, 900);
			});
		});
    </script>
    <!--// end-smoth-scrolling -->

    <script>
		$(document).ready(function () {
			/*
									var defaults = {
							  			containerID: 'toTop', // fading element id
										containerHoverID: 'toTopHover', // fading element hover id
										scrollSpeed: 1200,
										easingType: 'linear'
							 		};
									*/

			$().UItoTop({
				easingType: 'easeOutQuart'
			});

		});
    </script>
    <a href=""#home"" class=""scroll"" id=""toTop"" style=""display: block;"">
        <span id=""toTopHover"" style=""opacity: 1;");
                WriteLiteral("\"> </span>\r\n    </a>\r\n\r\n    <!-- //Custom-JavaScript-File-Links -->\r\n    <script src=\"/web/js/bootstrap.js\"></script>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
