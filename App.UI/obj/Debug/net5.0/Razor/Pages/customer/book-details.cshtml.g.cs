#pragma checksum "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86c1ca52343b9b5aaf209371a1e664966e2d59f"
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
#line 2 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
using SharedTenant.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:int:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86c1ca52343b9b5aaf209371a1e664966e2d59f", @"/Pages/customer/book-details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    public class Pages_customer_book_details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
  
    ViewBag.Title = Model.BookDetails.Name.ToUpper() + " Book Details";
    Layout = "/Pages/Shared/CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/CustomerCssFiles/cbookdesc.css\">\r\n<link rel=\"stylesheet\" href=\"/limonte-sweetalert2/sweetalert2.css\">\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 567, "\"", 596, 1);
#nullable restore
#line 16 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 575, Model.BookDetails.Id, 575, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\'bookId\'>\r\n\r\n<section class=\"bookdesc\">\r\n\r\n    <div class=\"container \">\r\n        <div class=\"row\">\r\n\r\n            <div class=\" col-md-4 coverbook\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 770, "\"", 804, 1);
#nullable restore
#line 24 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 776, Model.BookDetails.PhotoPath, 776, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 805, "\"", 811, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n\r\n            <div class=\" col-md-8 content\">\r\n\r\n                <h1 class=\"bookname\"> ");
#nullable restore
#line 30 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                 Write(Model.BookDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 34 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                 if (Model.BookDetails.Price.ToString("####").Equals(Model.BookDetails.BookPriceAfterDiscount))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"price\">$");
#nullable restore
#line 36 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                   Write(Model.BookDetails.Price.ToString("####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 37 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"price\">$");
#nullable restore
#line 40 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                   Write(Model.BookDetails.BookPriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$");
#nullable restore
#line 40 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                                                                    Write(Model.BookDetails.Price.ToString("####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 41 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
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
#line 59 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                   Write(Model.BookDetails.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"butns\">\r\n");
#nullable restore
#line 72 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
             if (SignInManager.IsSignedIn(User))
            {




#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" class=\"btnt cart-btn\" id=\"btn\">add to cart</a>\r\n");
#nullable restore
#line 79 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                 if (Model.wishid == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"icon\" id=\"btnwish\"><i class=\"fa-regular fa-heart-circle-plus\"></i>   Add to your watchlist</a>\r\n");
#nullable restore
#line 82 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2533, "\"", 2566, 2);
            WriteAttributeValue("", 2540, "/my/wishlist/", 2540, 13, true);
#nullable restore
#line 85 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 2553, Model.wishid, 2553, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"btnwishREMOVE\" class=\"icon\"><i class=\"fa-regular fa-heart-circle-minus\"></i>   Remove From your watchlist</a>\r\n");
#nullable restore
#line 86 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" class=\"btnt cart-btn\" id=\"btn2\">add to cart</a>\r\n                <a href=\"#\" class=\"icon\" id=\"btnwish2\"><i class=\"fa-regular fa-heart-circle-plus\"></i>   Add to watchlist</a>\r\n");
#nullable restore
#line 94 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
             if (!string.IsNullOrEmpty(Model.BookDetails.AduioUrl))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <audio controls>\r\n\r\n                    <source");
            BeginWriteAttribute("src", " src=\"", 3122, "\"", 3168, 2);
            WriteAttributeValue("", 3128, "/audio/books/", 3128, 13, true);
#nullable restore
#line 100 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 3141, Model.BookDetails.AduioUrl, 3141, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n\r\n                </audio>\r\n");
#nullable restore
#line 103 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n<section class=\"aboutauthor\">\r\n\r\n    <div class=\"about\">\r\n        <h1 class=\"heading\"> <span>About Author</span> </h1>\r\n    </div>\r\n\r\n    <div class=\"cont\">\r\n        <a class=\"card\"");
            BeginWriteAttribute("href", " href=\"", 3486, "\"", 3552, 4);
            WriteAttributeValue("", 3493, "/", 3493, 1, true);
#nullable restore
#line 130 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 3494, Global.UrlName, 3494, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3509, "/author-details/", 3509, 16, true);
#nullable restore
#line 130 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 3525, Model.BookDetails.AuthorId, 3525, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"row\">\r\n                <div class=\"icon-container\">\r\n                    <div class=\"loading-icon\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3709, "\"", 3749, 1);
#nullable restore
#line 134 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 3715, Model.BookDetails.AuthorPhotoPath, 3715, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3750, "\"", 3756, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"description\">\r\n                    <div class=\"name\">");
#nullable restore
#line 138 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
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
");
#nullable restore
#line 154 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
         if (SignInManager.IsSignedIn(User))
        {
            if (Model.recommenedBooksManger.CustomerRegisterFavouriteCategories(UserManager.GetUserId(User)))
            {
                if (Model.recomendedBooks.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 161 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                         foreach (var item in Model.recomendedBooks)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide box\">\r\n                                <div class=\"icons\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4759, "\"", 4801, 2);
            WriteAttributeValue("", 4766, "/exchange/book-details/", 4766, 23, true);
#nullable restore
#line 166 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 4789, item.BookId, 4789, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n                                </div>\r\n                                <div class=\"image\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4962, "\"", 5004, 2);
            WriteAttributeValue("", 4969, "/exchange/book-details/", 4969, 23, true);
#nullable restore
#line 169 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 4992, item.BookId, 4992, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 5052, "\"", 5088, 2);
            WriteAttributeValue("", 5058, "/photos/books/", 5058, 14, true);
#nullable restore
#line 170 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 5072, item.Book.Photo, 5072, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5089, "\"", 5095, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"content\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5274, "\"", 5316, 2);
            WriteAttributeValue("", 5281, "/exchange/book-details/", 5281, 23, true);
#nullable restore
#line 174 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 5304, item.BookId, 5304, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                        <h3>");
#nullable restore
#line 176 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                       Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5468, "\"", 5510, 2);
            WriteAttributeValue("", 5475, "/exchange/book-details/", 5475, 23, true);
#nullable restore
#line 178 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 5498, item.BookId, 5498, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\" style=\" width: -webkit-fill-available;\">DETAILS</a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 181 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"swiper-button-next\"></div>\r\n                    <div class=\"swiper-button-prev\"></div>\r\n");
#nullable restore
#line 185 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <center>\r\n                     <h1 style=\"font-size: xxx-large; color: #114766\">Books Not Available Yet</h1>\r\n                     <h2>Please Wait Until We Recieve New Books</h2>\r\n\r\n                 </center>\r\n");
#nullable restore
#line 193 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <center>\r\n                    <h1 style=\"font-size: xxx-large; color: #114766\">Help Us Serve You Better</h1>\r\n                    <h2>Register Your Favourite Categories</h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 6395, "\"", 6471, 2);
            WriteAttributeValue("", 6402, "/Account/Register/recommended-categories/", 6402, 41, true);
#nullable restore
#line 200 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 6443, UserManager.GetUserId(User), 6443, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btnt\">Register Favourite Categories</a>\r\n\r\n                </center>\r\n");
#nullable restore
#line 203 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
            }

        }


        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <center>
                <h1 style=""font-size: xxx-large; color: #114766"">No Recommended Books For You</h1>
                <h2>Please login to get recommended books</h2>
                <a href=""/account/login"" class=""btnt"">Login</a>

            </center>
");
#nullable restore
#line 216 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n<!-- similar section starts  -->\r\n<section class=\"Trend\" id=\"Trend\">\r\n\r\n    <h1 class=\"heading\"> <span>Most Selling Books</span> </h1>\r\n\r\n    <div class=\"swiper Trend-slider\">\r\n\r\n        <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 231 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
             foreach (var item in Model.MostSellingBooks)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide box\">\r\n                    <div class=\"icons\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7334, "\"", 7379, 4);
            WriteAttributeValue("", 7341, "/", 7341, 1, true);
#nullable restore
#line 236 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7342, Global.UrlName, 7342, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7357, "/book-details/", 7357, 14, true);
#nullable restore
#line 236 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7371, item.Id, 7371, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n                    </div>\r\n                    <div class=\"image\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7504, "\"", 7549, 4);
            WriteAttributeValue("", 7511, "/", 7511, 1, true);
#nullable restore
#line 239 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7512, Global.UrlName, 7512, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7527, "/book-details/", 7527, 14, true);
#nullable restore
#line 239 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7541, item.Id, 7541, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 7585, "\"", 7606, 1);
#nullable restore
#line 240 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7591, item.PhotoPath, 7591, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7607, "\"", 7613, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"content\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7744, "\"", 7789, 4);
            WriteAttributeValue("", 7751, "/", 7751, 1, true);
#nullable restore
#line 244 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7752, Global.UrlName, 7752, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7767, "/book-details/", 7767, 14, true);
#nullable restore
#line 244 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 7781, item.Id, 7781, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <h3>");
#nullable restore
#line 246 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"price\">$");
#nullable restore
#line 247 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                           Write(item.BookPriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>$");
#nullable restore
#line 247 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                                                                               Write(item.Price.ToString("####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8027, "\"", 8072, 4);
            WriteAttributeValue("", 8034, "/", 8034, 1, true);
#nullable restore
#line 249 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 8035, Global.UrlName, 8035, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8050, "/book-details/", 8050, 14, true);
#nullable restore
#line 249 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 8064, item.Id, 8064, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\" style=\" width: -webkit-fill-available;\">DETAILS</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 252 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"

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
<section class=""Trend"" id=""Trend"">

    <h1 class=""heading""> <span>Book from same category</span> </h1>

    <div class=""swiper Trend-slider"">
");
#nullable restore
#line 275 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
         if (Model.BooksBasedOnCategory.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"swiper-wrapper\">\r\n\r\n");
#nullable restore
#line 279 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                 foreach (var item in Model.BooksBasedOnCategory)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide box\">\r\n                        <div class=\"icons\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 8866, "\"", 8916, 4);
            WriteAttributeValue("", 8873, "/", 8873, 1, true);
#nullable restore
#line 284 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 8874, Global.UrlName, 8874, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8889, "/book-details/", 8889, 14, true);
#nullable restore
#line 284 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 8903, item.Book.Id, 8903, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n                        </div>\r\n                        <div class=\"image\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 9053, "\"", 9103, 4);
            WriteAttributeValue("", 9060, "/", 9060, 1, true);
#nullable restore
#line 287 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9061, Global.UrlName, 9061, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9076, "/book-details/", 9076, 14, true);
#nullable restore
#line 287 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9090, item.Book.Id, 9090, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 9143, "\"", 9179, 2);
            WriteAttributeValue("", 9149, "/Photos/Books/", 9149, 14, true);
#nullable restore
#line 288 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9163, item.Book.Photo, 9163, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9180, "\"", 9186, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"content\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 9333, "\"", 9383, 4);
            WriteAttributeValue("", 9340, "/", 9340, 1, true);
#nullable restore
#line 292 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9341, Global.UrlName, 9341, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9356, "/book-details/", 9356, 14, true);
#nullable restore
#line 292 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9370, item.Book.Id, 9370, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                <h3>");
#nullable restore
#line 294 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
                               Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 9511, "\"", 9561, 4);
            WriteAttributeValue("", 9518, "/", 9518, 1, true);
#nullable restore
#line 296 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9519, Global.UrlName, 9519, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9534, "/book-details/", 9534, 14, true);
#nullable restore
#line 296 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
WriteAttributeValue("", 9548, item.Book.Id, 9548, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\" style=\" width: -webkit-fill-available;\">DETAILS</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 299 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n");
            WriteLiteral("<div class=\"swiper-button-next\"></div>\r\n");
            WriteLiteral("<div class=\"swiper-button-prev\"></div>\r\n");
#nullable restore
#line 317 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"


        }
        else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <center>\r\n    <h1 style=\"font-size: xxx-large; color: #114766\">No Boos From This Category</h1>\r\n\r\n\r\n</center>");
#nullable restore
#line 324 "D:\1- Project\GradutionProject\App.UI\Pages\customer\book-details.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>

</section>


<script src=""/limonte-sweetalert2/sweetalert2.min.js""></script>
<script>

    $(function () {
        $(""#btn"").click(function () {
            var Id = $('#bookId').val();
            $.ajax({

                url: '?handler=AddToCart',
                data: { Id: Id },


            });
        });
        $(""#btn2"").click(function () {

            Swal.fire('You Must Login First')


        });
        $(""#btnwish"").click(function () {
            var Id = $('#bookId').val();
            $.ajax({

                url: '?handler=AddToWishlist',
                data: { Id: Id },


            });
            Swal.fire('Successfully Added to your wishlist')

        });
        $(""#btnwish2"").click(function () {

            Swal.fire('You Must Login First')


        });



    });
</script>
<!-- Trend section ends -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
