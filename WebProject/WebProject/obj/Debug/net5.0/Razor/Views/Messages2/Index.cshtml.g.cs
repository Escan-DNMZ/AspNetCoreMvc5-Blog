#pragma checksum "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda21147b15e3b5c7f0d57ea5bea1893104781d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages2_Index), @"mvc.1.0.view", @"/Views/Messages2/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda21147b15e3b5c7f0d57ea5bea1893104781d2", @"/Views/Messages2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155bedd31a00e884a93f6e3409a4601fe1e6becc", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Subject</th>\r\n        <th>Sender</th>\r\n        <th>Date</th>\r\n        <th>Open Message</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
           Write(item.SenderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
           Write(item.MessageDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 552, "\"", 600, 2);
            WriteAttributeValue("", 559, "/Messages2/MessageDetails/", 559, 26, true);
#nullable restore
#line 22 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
WriteAttributeValue("", 585, item.MessageId, 585, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Details</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\escan\source\repos\WebProject\WebProject\Views\Messages2\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />  \r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">New Message</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591