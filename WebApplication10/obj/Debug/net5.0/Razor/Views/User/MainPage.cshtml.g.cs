#pragma checksum "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "944f794e38c9fb74d1fd2262c8f1a02baaaf4e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MainPage), @"mvc.1.0.view", @"/Views/User/MainPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944f794e38c9fb74d1fd2262c8f1a02baaaf4e59", @"/Views/User/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication10.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Age</th>\r\n            <th>UserName</th>\r\n            <th>Password</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml"
         foreach (WebApplication10.Models.User s in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml"
           Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml"
           Write(s.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml"
           Write(s.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml"
           Write(s.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\HP\source\repos\WebApplication10\WebApplication10\Views\User\MainPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication10.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
