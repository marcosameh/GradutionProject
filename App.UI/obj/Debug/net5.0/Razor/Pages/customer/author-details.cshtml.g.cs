#pragma checksum "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129366ad17a226d3ca9e65e86fe71defea9ea8e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.customer.Pages_customer_author_details), @"mvc.1.0.razor-page", @"/Pages/customer/author-details.cshtml")]
namespace App.UI.Pages.customer
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
#line 1 "D:\1- Project\GradutionProject\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:int:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129366ad17a226d3ca9e65e86fe71defea9ea8e8", @"/Pages/customer/author-details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60516fbdfe7ed4ccf842a382feccb1bbdfe10843", @"/Pages/_ViewImports.cshtml")]
    public class Pages_customer_author_details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CustomerCssFiles/cauthordesc.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
  
    ViewBag.Title = "author-Details page";
    Layout = "/Pages/Shared/CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "129366ad17a226d3ca9e65e86fe71defea9ea8e84224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section class=\"bookdesc\">\r\n\r\n    <div class=\"container \">\r\n        <div class=\"row\">\r\n\r\n            <div class=\" col-md-4 coverauthor\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 440, "\"", 469, 1);
#nullable restore
#line 15 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
WriteAttributeValue("", 446, Model.author.PhotoPath, 446, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 470, "\"", 476, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"shadow-box\"></div>\r\n            </div>\r\n\r\n\r\n            <div class=\" col-md-8 content\">\r\n\r\n                <h1 class=\"authorname\"> ");
#nullable restore
#line 22 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                                   Write(Model.author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>


                <div class=""stars"">
                    <span class=""rate""> Rate of author : </span>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star-half-alt""></i>
                </div>



                <div class=""about"">

                    <h2> About author </h2>
                    <p class=""description"">
                        ");
#nullable restore
#line 40 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                   Write(Model.author.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>

                </div>



            </div>


        </div>

        <div class=""butns"">
            <a href=""#"" class=""icon""><i class=""fa-regular fa-heart-circle-plus""></i>   Add to watchlist</a>
        </div>





    </div>

</section>
<section class=""similar"" id=""similar"">

    <h1 class=""heading""> <span> Author's books </span> </h1>

    <div class=""swiper similar-slider"">

        <div class=""swiper-wrapper"">
");
#nullable restore
#line 70 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
             foreach (var book in Model.AuthorBooks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide box\">\r\n                    <div class=\"icons\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1889, "\"", 1934, 4);
            WriteAttributeValue("", 1896, "/", 1896, 1, true);
#nullable restore
#line 74 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
WriteAttributeValue("", 1897, Global.UrlName, 1897, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1912, "/book-details/", 1912, 14, true);
#nullable restore
#line 74 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
WriteAttributeValue("", 1926, book.Id, 1926, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n\r\n                    </div>\r\n                    <div class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2063, "\"", 2084, 1);
#nullable restore
#line 78 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
WriteAttributeValue("", 2069, book.PhotoPath, 2069, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2085, "\"", 2091, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        <h3>");
#nullable restore
#line 81 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                       Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 82 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                         if (book.Price == book.BookPriceAfterDiscount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"price\">$");
#nullable restore
#line 83 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                                        Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 84 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"price\">$");
#nullable restore
#line 86 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                                     Write(book.BookPriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$");
#nullable restore
#line 86 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                                                                         Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>");
#nullable restore
#line 86 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                        <a href=\"#\" class=\"btnt\">add to cart</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 99 "D:\1- Project\GradutionProject\App.UI\Pages\customer\author-details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"swiper-button-next\"></div>\r\n        <div class=\"swiper-button-prev\"></div>\r\n\r\n    </div>\r\n\r\n</section>\r\n<!-- similar section ends -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.customer.author_detailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.author_detailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.author_detailsModel>)PageContext?.ViewData;
        public App.UI.Pages.customer.author_detailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
