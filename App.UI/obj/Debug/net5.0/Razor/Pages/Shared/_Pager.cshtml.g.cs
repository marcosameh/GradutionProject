#pragma checksum "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4ef15f73c5dc1a3a8a141e953df58c8d7d4628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.Shared.Pages_Shared__Pager), @"mvc.1.0.view", @"/Pages/Shared/_Pager.cshtml")]
namespace App.UI.Pages.Shared
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
#line 1 "D:\Clients\GradutionProject\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4ef15f73c5dc1a3a8a141e953df58c8d7d4628", @"/Pages/Shared/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.UI.Infrastructure.PagingData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
  
    var currentPath = ViewContext.HttpContext.Request.Path.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 9 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
         if (Model.HasPrevious)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 224, "\"", 279, 1);
#nullable restore
#line 12 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
WriteAttributeValue("", 231, $"{currentPath}?page={Model.CurrentPage - 1}", 231, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"prev\"> &lang; Prev </a></li>\r\n");
#nullable restore
#line 13 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
         for (var pageNumber = Model.FromPage; pageNumber <= Model.ToPage; pageNumber++)
        {

      

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 457, "\"", 526, 2);
            WriteAttributeValue("", 465, "pageNumber", 465, 10, true);
#nullable restore
#line 19 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
WriteAttributeValue(" ", 475, pageNumber == Model.CurrentPage ? "active" : "", 476, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 530, "\"", 574, 1);
#nullable restore
#line 19 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
WriteAttributeValue("", 537, $"{currentPath}?page={pageNumber}", 537, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
                                                                                                                                 Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 20 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
    if (Model.HasNext) { 
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 664, "\"", 719, 1);
#nullable restore
#line 25 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
WriteAttributeValue("", 671, $"{currentPath}?page={Model.CurrentPage + 1}", 671, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"next\"> &rang; Next </a></li>\r\n");
#nullable restore
#line 26 "D:\Clients\GradutionProject\App.UI\Pages\Shared\_Pager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    </ul>\r\n   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Infrastructure.PagingData> Html { get; private set; }
    }
}
#pragma warning restore 1591
