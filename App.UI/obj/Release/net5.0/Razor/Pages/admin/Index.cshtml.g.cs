#pragma checksum "D:\1- Project\New folder\GradutionProject\App.UI\Pages\admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d14269b87b06d166b4c90ece9bef26e96ed483f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.admin.Pages_admin_Index), @"mvc.1.0.razor-page", @"/Pages/admin/Index.cshtml")]
namespace App.UI.Pages.admin
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
#line 1 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d14269b87b06d166b4c90ece9bef26e96ed483f", @"/Pages/admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    public class Pages_admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\admin\Index.cshtml"
  
    Layout = "/Pages/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    

    <div class=""col-xl-6 col-md-6"">
        <div class=""card"">
            <a href=""/Bookstores/list"">
                <div class=""card-block"">
                    <div class=""row align-items-center"">
                        <div class=""col-8"">
                            <h4 class=""text-c-blue"">BookStores</h4>
                            <h6 class=""text-muted m-b-0"">All BookStores Details</h6>
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
                        <div class=""col-3 text-right"">

                        </div>
           ");
            WriteLiteral(@"         </div>
                </div>
            </a>
        </div>

    </div>
    <div class=""col-xl-6 col-md-6"">
        <div class=""card"">
            <a href=""/books/waitingbooks"">
                <div class=""card-block"">
                    <div class=""row align-items-center"">
                        <div class=""col-8"">
                            <h4 class=""text-c-green"">Waiting Books</h4>
                            <h6 class=""text-muted m-b-0"">Show All WaitingBooks</h6>
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
                        <div class=""");
            WriteLiteral("col-3 text-right\">\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.Admin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.Admin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.Admin.IndexModel>)PageContext?.ViewData;
        public App.UI.Pages.Admin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
