#pragma checksum "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "960242b10be7fca4edca57efe09ca04a25d9555b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_List), @"mvc.1.0.view", @"/Views/Movies/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"960242b10be7fca4edca57efe09ca04a25d9555b", @"/Views/Movies/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0b1157f7f4c326ad95f8287b32ac2612e3c94d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieGenreViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1>Film Listesi</h1>\r\n<div id=\"filmler\">\r\n");
#nullable restore
#line 7 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
     if (Model.Movies.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
         foreach (var item in Model.Movies)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
       Write(await Html.PartialAsync("_movie", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
                                                    
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            Film Bulunamadı\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
 if (TempData["Message"] != null)
{
    

#line default
#line hidden
#nullable disable
            DefineSection("message", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
   Write(await Html.PartialAsync("_message", (string)TempData["Message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
#nullable restore
#line 29 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("menu", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
#nullable restore
#line 37 "C:\Users\CAN\Desktop\MovieMVC5\MovieApp\MovieApp.WebUI\Views\Movies\List.cshtml"
Write(await Component.InvokeAsync("Genres"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieGenreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
