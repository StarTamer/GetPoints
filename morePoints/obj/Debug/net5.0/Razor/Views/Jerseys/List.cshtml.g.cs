#pragma checksum "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\Jerseys\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d989d5b1d8a411307ab607bc549e13495d44aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jerseys_List), @"mvc.1.0.view", @"/Views/Jerseys/List.cshtml")]
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
#line 1 "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\_ViewImports.cshtml"
using morePoints.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\Jerseys\List.cshtml"
using morePoints.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d989d5b1d8a411307ab607bc549e13495d44aa4", @"/Views/Jerseys/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c40ab1a6003f933c77306fd1e0716ef5f082e1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Jerseys_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Все Джерси</h1>\r\n<h3>");
#nullable restore
#line 4 "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\Jerseys\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 6 "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\Jerseys\List.cshtml"
      
        foreach (Jersey jersey in Model.allJerseys)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\Jerseys\List.cshtml"
       Write(Html.Partial("AllJerseys", jersey));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\EmKa\source\repos\morePoints\morePoints\Views\Jerseys\List.cshtml"
                                               ;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
