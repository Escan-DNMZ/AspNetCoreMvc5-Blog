#pragma checksum "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcbec5f407f200a77dbefa6bd40e2ec512055ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentListByBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentListByBlog/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcbec5f407f200a77dbefa6bd40e2ec512055ff", @"/Views/Shared/Components/CommentListByBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155bedd31a00e884a93f6e3409a4601fe1e6becc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CommentListByBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"comment-top\">\r\n");
#nullable restore
#line 3 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>\r\n            Comments\r\n        </h4>\r\n");
#nullable restore
#line 8 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>\r\n            be the first to comment\r\n        </h5>\r\n");
#nullable restore
#line 14 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media\">\r\n            <img src=\"/web/images/t1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 372, "\"", 378, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\">");
#nullable restore
#line 20 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
                            Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 >");
#nullable restore
#line 21 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
                Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                \r\n                <p>\r\n                    ");
#nullable restore
#line 24 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
               Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Shared\Components\CommentListByBlog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
