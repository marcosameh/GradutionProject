#pragma checksum "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3345e632ccaa7a1631215e3cc75091413cc64601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.customer.Pages_customer_exchange_book_details), @"mvc.1.0.razor-page", @"/Pages/customer/exchange-book-details.cshtml")]
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
#line 2 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
using SharedTenant.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/exchange/book-details/{Id:int:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3345e632ccaa7a1631215e3cc75091413cc64601", @"/Pages/customer/exchange-book-details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60516fbdfe7ed4ccf842a382feccb1bbdfe10843", @"/Pages/_ViewImports.cshtml")]
    public class Pages_customer_exchange_book_details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
  
    ViewBag.Title = Model.BookDetails.Name.ToUpper() + " Book Details";
    Layout = "/Pages/Shared/CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/CustomerCssFiles/cbookdesc.css\">\r\n<link rel=\"stylesheet\" href=\"/limonte-sweetalert2/sweetalert2.css\">\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 597, "\"", 637, 1);
#nullable restore
#line 15 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 605, Model.BookDetails.ExchageBookId, 605, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\'bookId\'>\r\n<section class=\"bookdesc\">\r\n\r\n    <div class=\"container \">\r\n        <div class=\"row\">\r\n\r\n            <div class=\" col-md-4 coverbook\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 809, "\"", 843, 1);
#nullable restore
#line 22 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 815, Model.BookDetails.PhotoPath, 815, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 844, "\"", 850, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n\r\n            <div class=\" col-md-8 content\">\r\n\r\n                <h1 class=\"bookname\"> ");
#nullable restore
#line 28 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                                 Write(Model.BookDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>




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
#line 48 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                   Write(Model.BookDetails.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"butns\">\r\n");
#nullable restore
#line 61 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
             if (SignInManager.IsSignedIn(User))
            {




                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                 if (Model.wishid == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"icon\" id=\"btnwish\"><i class=\"fa-regular fa-heart-circle-plus\"></i>   Add to your watchlist</a>\r\n");
#nullable restore
#line 70 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2049, "\"", 2082, 2);
            WriteAttributeValue("", 2056, "/my/wishlist/", 2056, 13, true);
#nullable restore
#line 73 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 2069, Model.wishid, 2069, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"btnwishREMOVE\" class=\"icon\"><i class=\"fa-regular fa-heart-circle-minus\"></i>   Remove From your watchlist</a>\r\n");
#nullable restore
#line 74 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" class=\"icon\" id=\"btnwish2\"><i class=\"fa-regular fa-heart-circle-plus\"></i>   Add to watchlist</a>\r\n");
#nullable restore
#line 81 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
             if (!string.IsNullOrEmpty(Model.BookDetails.AduioUrl))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <audio controls>\r\n\r\n                    <source");
            BeginWriteAttribute("src", " src=\"", 2561, "\"", 2607, 2);
            WriteAttributeValue("", 2567, "/audio/books/", 2567, 13, true);
#nullable restore
#line 87 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 2580, Model.BookDetails.AduioUrl, 2580, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n\r\n                </audio>\r\n");
#nullable restore
#line 90 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"







        </div>






    </div>

</section>

<section class=""aboutauthor"">

    <div class=""about"">
        <h1 class=""heading""> <span>About Author</span> </h1>
    </div>

    <div class=""cont"">
        <a class=""card"">
            <div class=""row"">
                <div class=""icon-container"">
                    <div class=""loading-icon"">
                    </div>
                </div>
                <div class=""description"">
                    <div class=""name"">");
#nullable restore
#line 124 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
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
#line 140 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 143 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                 foreach (var item in Model.recomendedBooks)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide box\">\r\n                        <div class=\"icons\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3804, "\"", 3846, 2);
            WriteAttributeValue("", 3811, "/exchange/book-details/", 3811, 23, true);
#nullable restore
#line 148 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 3834, item.BookId, 3834, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-search\"></a>\r\n                        </div>\r\n                        <div class=\"image\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3983, "\"", 4025, 2);
            WriteAttributeValue("", 3990, "/exchange/book-details/", 3990, 23, true);
#nullable restore
#line 151 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 4013, item.BookId, 4013, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 4065, "\"", 4101, 2);
            WriteAttributeValue("", 4071, "/photos/books/", 4071, 14, true);
#nullable restore
#line 152 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 4085, item.Book.Photo, 4085, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4102, "\"", 4108, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"content\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4255, "\"", 4297, 2);
            WriteAttributeValue("", 4262, "/exchange/book-details/", 4262, 23, true);
#nullable restore
#line 156 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 4285, item.BookId, 4285, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                <h3>");
#nullable restore
#line 158 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
                               Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4425, "\"", 4467, 2);
            WriteAttributeValue("", 4432, "/exchange/book-details/", 4432, 23, true);
#nullable restore
#line 160 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
WriteAttributeValue("", 4455, item.BookId, 4455, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\" style=\" width: -webkit-fill-available;\">DETAILS</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 163 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"swiper-button-next\"></div>\r\n");
            WriteLiteral("            <div class=\"swiper-button-prev\"></div>\r\n");
#nullable restore
#line 181 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
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
#line 190 "D:\1- Project\GradutionProject\App.UI\Pages\customer\exchange-book-details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

</section>
<script src=""/limonte-sweetalert2/sweetalert2.min.js""></script>
<script>

    $(function () {
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
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.customer.exchange_book_detailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.exchange_book_detailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.exchange_book_detailsModel>)PageContext?.ViewData;
        public App.UI.Pages.customer.exchange_book_detailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
