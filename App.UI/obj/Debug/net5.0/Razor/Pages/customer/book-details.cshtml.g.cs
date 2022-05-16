#pragma checksum "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc901811e2fbe430b58b04c45ef8d917f5e53f07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.customer.Pages_customer_book_details), @"mvc.1.0.razor-page", @"/Pages/customer/book-details.cshtml")]
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
#line 1 "D:\1- Project\final\GradutionProject\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:int:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc901811e2fbe430b58b04c45ef8d917f5e53f07", @"/Pages/customer/book-details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60516fbdfe7ed4ccf842a382feccb1bbdfe10843", @"/Pages/_ViewImports.cshtml")]
    public class Pages_customer_book_details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
  
    ViewBag.Title = Model.BookDetails.Name + " Book Details";
    Layout = "/Pages/Shared/CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/CustomerCssFiles/cbookdesc.css\">\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 316, "\"", 345, 1);
#nullable restore
#line 10 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 324, Model.BookDetails.Id, 324, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\'bookId\'>\r\n<section class=\"bookdesc\">\r\n\r\n    <div class=\"container \">\r\n        <div class=\"row\">\r\n\r\n            <div class=\" col-md-4 coverbook\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 517, "\"", 551, 1);
#nullable restore
#line 17 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 523, Model.BookDetails.PhotoPath, 523, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 552, "\"", 558, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n\r\n            <div class=\" col-md-8 content\">\r\n\r\n                <h1 class=\"bookname\"> ");
#nullable restore
#line 23 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                 Write(Model.BookDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                 if (Model.BookDetails.Price == Model.BookDetails.BookPriceAfterDiscount)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"price\">$");
#nullable restore
#line 28 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                Write(Model.BookDetails.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 29 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"price\">$");
#nullable restore
#line 31 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                             Write(Model.BookDetails.BookPriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$");
#nullable restore
#line 31 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                                                              Write(Model.BookDetails.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>");
#nullable restore
#line 31 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""stars"">
                    <span class=""rate""> Rate of book : </span>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star-half-alt""></i>
                </div>



                <div class=""about"">

                    <h2> About book </h2>
                    <p class=""description"">
                        ");
#nullable restore
#line 49 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                   Write(Model.BookDetails.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>

                </div>



            </div>


        </div>

        <div class=""butns"">
            <a href=""#"" class=""btnt cart-btn"" id=""btn"">add to cart</a>
            <a href=""#"" class=""btnt"">Read Sample</a>
            <a href=""#"" class=""icon""><i class=""fa-regular fa-heart-circle-plus""></i>   Add to watchlist</a>







        </div>






    </div>

</section>

<section class=""aboutauthor"">

    <div class=""about"">
        <h1 class=""heading""> <span>About Author</span> </h1>
    </div>

    <div class=""cont"">
        <a class=""card""");
            BeginWriteAttribute("href", " href=\"", 2211, "\"", 2277, 4);
            WriteAttributeValue("", 2218, "/", 2218, 1, true);
#nullable restore
#line 90 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 2219, Global.UrlName, 2219, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2234, "/author-details/", 2234, 16, true);
#nullable restore
#line 90 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 2250, Model.BookDetails.AuthorId, 2250, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"row\">\r\n                <div class=\"icon-container\">\r\n                    <div class=\"loading-icon\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2434, "\"", 2474, 1);
#nullable restore
#line 94 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 2440, Model.BookDetails.AuthorPhotoPath, 2440, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2475, "\"", 2481, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"description\">\r\n                    <div class=\"name\">");
#nullable restore
#line 98 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                 Write(Model.BookDetails.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

                </div>
            </div>

        </a>
    </div>

</section>

<!-- Recommended section starts  -->
<section class=""Trend"" id=""Trend"">

    <h1 class=""heading""> <span>Recommended For You</span> </h1>

    <div class=""swiper Trend-slider"">

        <div class=""swiper-wrapper"">
");
#nullable restore
#line 116 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
             foreach (var book in Model.recomendedBooks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide box\">\r\n                    <div class=\"icons\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3155, "\"", 3206, 2);
            WriteAttributeValue("", 3162, "/customer/exchange-book-details/", 3162, 32, true);
#nullable restore
#line 120 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 3194, book.BookId, 3194, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n\r\n                    </div>\r\n                    <div class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3335, "\"", 3371, 2);
            WriteAttributeValue("", 3341, "/photos/books/", 3341, 14, true);
#nullable restore
#line 124 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 3355, book.Book.Photo, 3355, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3372, "\"", 3378, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        <h3>");
#nullable restore
#line 127 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                       Write(book.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <a href=\"#\" class=\"btnt\">add to cart</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 131 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




        </div>

        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>

    </div>

</section>


<!-- similar section starts  -->
<section class=""Trend"" id=""Trend"">

    <h1 class=""heading""> <span>Most Selling Books</span> </h1>

    <div class=""swiper Trend-slider"">

        <div class=""swiper-wrapper"">
");
#nullable restore
#line 155 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
             foreach (var Book in Model.MostSellingBooks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide box\">\r\n                    <div class=\"icons\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4198, "\"", 4243, 4);
            WriteAttributeValue("", 4205, "/", 4205, 1, true);
#nullable restore
#line 159 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 4206, Global.UrlName, 4206, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4221, "/book-details/", 4221, 14, true);
#nullable restore
#line 159 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 4235, Book.Id, 4235, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n\r\n                    </div>\r\n                    <div class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4372, "\"", 4393, 1);
#nullable restore
#line 163 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 4378, Book.PhotoPath, 4378, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4394, "\"", 4400, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        <h3>");
#nullable restore
#line 166 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                       Write(Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 167 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                         if (Book.Price == Book.BookPriceAfterDiscount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"price\">$");
#nullable restore
#line 168 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                        Write(Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 169 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"price\">$");
#nullable restore
#line 171 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                     Write(Book.BookPriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$");
#nullable restore
#line 171 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                                                         Write(Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>");
#nullable restore
#line 171 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" class=\"btnt\">add to cart</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 175 "D:\1- Project\final\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




        </div>

        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>

    </div>

</section>


<!-- similar section ends -->



<script>
    $(function () {
        $(""#btn"").click(function () {
            var Id = $('#bookId').val();
            $.ajax({

                url: '?handler=AddToCart',
                data: { Id: Id },


            });
        });
    });
</script>
<!-- Trend section ends -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.customer.book_detailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.book_detailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.book_detailsModel>)PageContext?.ViewData;
        public App.UI.Pages.customer.book_detailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
