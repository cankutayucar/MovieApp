#pragma checksum "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10a834077445e3f15a3dea311c1cfdb8c4858ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
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
#line 1 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\_ViewImports.cshtml"
using MovieApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\_ViewImports.cshtml"
using MovieApp.WebUI.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a834077445e3f15a3dea311c1cfdb8c4858ddf", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea91d54d0500cd8830edc6a39eaf79da445406d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 5 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\_menu.cshtml"
     foreach (var liste in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 7 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\_menu.cshtml"
                                                              Write(liste.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 8 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\_menu.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Genre>> Html { get; private set; }
    }
}
#pragma warning restore 1591
