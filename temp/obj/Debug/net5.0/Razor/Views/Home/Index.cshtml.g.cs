#pragma checksum "C:\Users\cfranks\Postman\temp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "188ffc6eb07068c23b6ac0685cf05a979909c401"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\cfranks\Postman\temp\Views\_ViewImports.cshtml"
using temp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cfranks\Postman\temp\Views\_ViewImports.cshtml"
using temp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cfranks\Postman\temp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"188ffc6eb07068c23b6ac0685cf05a979909c401", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b719919c0b512bd236922e8ba85aaa87c95bb448", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmbeddedCheckoutFormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\cfranks\Postman\temp\Views\Home\Index.cshtml"
  
    string HOSTEDFIELDTOKENID =
            "eyJhbGciOiJIUzI1NiJ9.eyJwYXlsb2FkIjp7ImNvbW1vbkp3dFBheWxvYWQiOnsiaWQiOiIxMjUyNTc3NjY1MTQzNDQ5Mzc4MTM1MzciLCJkYXRlQ3JlYXRlZCI6MTYyNzI4ODE1NzIxMH0sIm1lcmNoYW50SWQiOjkxMzIwOSwic2VudHJ5Ijp7Im1lcmNoYW50IjpmYWxzZSwiYXBwcyI6W119fX0.Ie-lWweAceEYBhMKA1TsSgxI1yBFFbatr-tBA266Qyg._";
    string firstname = "Someone";
    string lastname = "JustExample";
    string amount = "10";
    string currency = "EUR";

    ShopperData shopperData = new ShopperData(firstname, lastname);
    var jsonData = new EmbeddedCheckoutFormModel(HOSTEDFIELDTOKENID, amount, currency, shopperData);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n<button onclick=\"openEmbeddedCheckout()\">check out</button>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\cfranks\Postman\temp\Views\Home\Index.cshtml"
           
    void SetUpBS()
    {
        Console.WriteLine("Set up got triggered");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmbeddedCheckoutFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
