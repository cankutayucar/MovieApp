#pragma checksum "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fed5473fb7f035694d85139c4784dc27924ff11e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Genres_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Genres/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed5473fb7f035694d85139c4784dc27924ff11e", @"/Views/Shared/Components/Genres/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e84a54b9aaf664de0a5f63b6bf79179597764f32", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Genres_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    <a href=\"/movies/list\"");
            BeginWriteAttribute("class", " class=\"", 76, "\"", 166, 3);
            WriteAttributeValue("", 84, "list-group-item", 84, 15, true);
            WriteAttributeValue(" ", 99, "list-group-item-action", 100, 23, true);
#nullable restore
#line 5 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("  ", 122, ViewBag.SelectedGenre==null?"active":"", 124, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">T??m Filmler</a>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml"
     foreach (var liste in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 239, "\"", 273, 2);
            WriteAttributeValue("", 246, "/movies/list/", 246, 13, true);
#nullable restore
#line 9 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("", 259, liste.GenreId, 259, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 274, "\"", 383, 3);
            WriteAttributeValue("", 282, "list-group-item", 282, 15, true);
            WriteAttributeValue(" ", 297, "list-group-item-action", 298, 23, true);
#nullable restore
#line 9 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" ", 320, ViewBag.SelectedGenre==liste.GenreId.ToString()?"active":"", 321, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml"
                                                                                                                                                       Write(liste.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 10 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Shared\Components\Genres\Default.cshtml"
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
