#pragma checksum "C:\Users\Abdurrahman\source\repos\GroceryStore\GroceryStore\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8420515b07f2479e01bb1ae87db1d44c20b2ba69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Abdurrahman\source\repos\GroceryStore\GroceryStore\Views\_ViewImports.cshtml"
using GroceryStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\GroceryStore\GroceryStore\Views\_ViewImports.cshtml"
using GroceryStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8420515b07f2479e01bb1ae87db1d44c20b2ba69", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd50d0179ac9bea7de6074dacf685930840d048", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GroceryStore.Models.Users>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdurrahman\source\repos\GroceryStore\GroceryStore\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""text-primary text-center"">User Create Page</h1>
<hr />
<div class=""container"">
    <table>
        <tr>
            <th>Name</th>
            <th>Last Name</th>
            <th>Phone</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Provice</th>
            <th>District</th>
            <th>Home Number</th>
            <th>Tazkira Number</th>
            <th>Photo</th>
            <th>Password</th>
        </tr>
");
#nullable restore
#line 22 "C:\Users\Abdurrahman\source\repos\GroceryStore\GroceryStore\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GroceryStore.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
