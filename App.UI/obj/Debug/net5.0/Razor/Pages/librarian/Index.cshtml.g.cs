#pragma checksum "D:\Clients\GraduationProject\Code\App.UI\Pages\librarian\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57a5a7785604c1b7beba9731a37b8ed17ff194ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.librarian.Pages_librarian_Index), @"mvc.1.0.razor-page", @"/Pages/librarian/Index.cshtml")]
namespace App.UI.Pages.librarian
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a5a7785604c1b7beba9731a37b8ed17ff194ef", @"/Pages/librarian/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60516fbdfe7ed4ccf842a382feccb1bbdfe10843", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_librarian_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Clients\GraduationProject\Code\App.UI\Pages\librarian\Index.cshtml"
  
    Layout = "/Pages/Shared/LibrarianLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-4 col-md-4"">
        <div class=""card"">
            <a href=""/books/list"">
                <div class=""card-block"">
                    <div class=""row align-items-center"">
                        <div class=""col-8"">
                            <h4 class=""text-c-red"">Books</h4>
                            <h6 class=""text-muted m-b-0"">Show All Books</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <i class=""fa fa-dollar f-28""></i>

                        </div>
                    </div>
                </div>
                <div class=""card-footer bg-c-red"">
                    <div class=""row align-items-center"">
                        <div class=""col-9"">
                            <p class=""text-white m-b-0""></p>
                        </div>
                        <div class=""col-3 text-right"">

                        </div>
                    </div>
              ");
            WriteLiteral(@"  </div>
            </a>
        </div>
    </div>



    <div class=""col-xl-4 col-md-4"">
        <div class=""card"">
            <a href=""/book-category/list"">
                <div class=""card-block"">
                    <div class=""row align-items-center"">
                        <div class=""col-8"">
                            <h4 class=""text-c-blue"">Book Categories</h4>
                            <h6 class=""text-muted m-b-0"">All Book Categories Details</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <i class=""fa fa-file-text-o f-28""></i>
                        </div>
                    </div>
                </div>
                <div class=""card-footer bg-c-blue"">
                    <div class=""row align-items-center"">
                        <div class=""col-9"">
                            <p class=""text-white m-b-0""></p>
                        </div>
                        <div class=""col-3 text-right""");
            WriteLiteral(@">

                        </div>
                    </div>
                </div>
            </a>
        </div>

    </div>
    <div class=""col-xl-4 col-md-4"">
        <div class=""card"">
            <a href=""/author/list"">
                <div class=""card-block"">
                    <div class=""row align-items-center"">
                        <div class=""col-8"">
                            <h4 class=""text-c-green"">Authors</h4>
                            <h6 class=""text-muted m-b-0"">Show All Authors</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <i class=""fa fa-youtube f-28""></i>
                        </div>
                    </div>
                </div>
                <div class=""card-footer bg-c-green"">
                    <div class=""row align-items-center"">
                        <div class=""col-9"">
                            <p class=""text-white m-b-0""></p>
                        </div>
      ");
            WriteLiteral("                  <div class=\"col-3 text-right\">\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.librarian.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.librarian.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.librarian.IndexModel>)PageContext?.ViewData;
        public App.UI.Pages.librarian.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
