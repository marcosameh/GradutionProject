#pragma checksum "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd21394dee76a80490660550a80667a87b23fe52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.customer.Partials.Pages_customer_Partials__AuthorCardPartial), @"mvc.1.0.view", @"/Pages/customer/Partials/_AuthorCardPartial.cshtml")]
namespace App.UI.Pages.customer.Partials
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
#line 1 "D:\Clients\GraduationProject\Code\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
using App.Librarian.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd21394dee76a80490660550a80667a87b23fe52", @"/Pages/customer/Partials/_AuthorCardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_customer_Partials__AuthorCardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorsVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-lg-3 col-md-6\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 121, "\"", 169, 4);
            WriteAttributeValue("", 128, "/", 128, 1, true);
#nullable restore
#line 5 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
WriteAttributeValue("", 129, Global.UrlName, 129, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 144, "/author-details/", 144, 16, true);
#nullable restore
#line 5 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
WriteAttributeValue("", 160, Model.Id, 160, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card\" style=\"max-height:330px !important;overflow:hidden !important \">\r\n\r\n            <div class=\"card-body\" >\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 325, "\"", 347, 1);
#nullable restore
#line 9 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
WriteAttributeValue("", 331, Model.PhotoPath, 331, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 348, "\"", 354, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle w-50 mb-3\">\r\n                <h3>");
#nullable restore
#line 10 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h5>Writer</h5>\r\n                <p>\r\n                    ");
#nullable restore
#line 13 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
               Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <div class=""d-flex flex-row justify-content-center"">

                    <div class=""card-stats"">
                        <div class=""stat"">
                            <div class=""value""><sup></sup></div>
                            <div class=""type""></div>
                        </div>
                        <div class=""stat"">
                            <div class=""value"">");
#nullable restore
#line 23 "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\Partials\_AuthorCardPartial.cshtml"
                                          Write(Model.NumberOfBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            <div class=""type"">book</div>
                        </div>
                        <div class=""stat"">
                            <div class=""value""></div>
                            <div class=""type""></div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </a>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
