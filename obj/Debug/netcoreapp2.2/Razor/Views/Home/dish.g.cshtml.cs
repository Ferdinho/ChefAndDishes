#pragma checksum "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c34255b82a54129d4aadc2ed2e9ebe2232706f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dish), @"mvc.1.0.view", @"/Views/Home/dish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/dish.cshtml", typeof(AspNetCore.Views_Home_dish))]
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
#line 1 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c34255b82a54129d4aadc2ed2e9ebe2232706f", @"/Views/Home/dish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 497, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>
<a href = ""dishes/new"">Add a Dish</a>

<div class=""text-center"">
    <a href=""/"">Chefs </a> |
    <a href=""dishes"">Dishes</a>
</div>
<h2>Yum, take a look at our tasty dishes!</h2>
<table class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col"">Chef</th>
      <th scope=""col"">Tastiness</th>
      <th scope=""col"">Calories</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 23 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
       foreach(var dish in Model){

#line default
#line hidden
            BeginContext(552, 26, true);
            WriteLiteral("    <tr>    \r\n        <td>");
            EndContext();
            BeginContext(579, 9, false);
#line 25 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
       Write(dish.name);

#line default
#line hidden
            EndContext();
            BeginContext(588, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(608, 22, false);
#line 26 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
       Write(dish.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(630, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(632, 21, false);
#line 26 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
                               Write(dish.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(653, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(673, 14, false);
#line 27 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
       Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(687, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(707, 13, false);
#line 28 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
       Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(720, 28, true);
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n");
            EndContext();
#line 31 "C:\Users\ferdi\Downloads\CodingDojo\C#\ONETOMANY\ChefsNDishes\Views\Home\dish.cshtml"
      }

#line default
#line hidden
            BeginContext(757, 26, true);
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591