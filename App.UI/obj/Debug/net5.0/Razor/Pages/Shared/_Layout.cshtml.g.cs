#pragma checksum "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e1e3bbfb18139940f7d8404de8c96a9def7177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
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
#line 1 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
using SharedTenant.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e1e3bbfb18139940f7d8404de8c96a9def7177", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-returnUrl", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e1e3bbfb18139940f7d8404de8c96a9def71776479", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 13 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

    <link rel=""stylesheet"" href=""https://unpkg.com/swiper@7/swiper-bundle.min.css"" />

    <!-- font awesome cdn link  -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"">
    <!-- logo icon  -->
    <link rel=""shortcut icon "" type=""image/png"" href=""/image/Logo.png"">
    <!-- custom css file link  -->
    <link rel=""stylesheet"" href=""/css/CustomerCssFiles/chome.css"">
    <!-- custom css file link  -->
    <link href=""/css/CustomerCssFiles/bootstrap.css"" rel=""stylesheet"" />
    <link href=""/css/CustomerCssFiles/bootstrap.min (1).css"" rel=""stylesheet"" />
    <!-- <link rel=""stylesheet"" href=""css/bootstrap.css"">
    <link rel=""stylesheet"" href=""css/bootstrap.min (1).css"">
    <link rel=""stylesheet"" href=""css/_bootswatch.scss"">
    <link rel=""stylesheet"" href=""css/_variables.scss""> -->
    <!--fontawesome link -->
    <script src=""https://kit.fontawesome.com/70ea18d072.js"" crossorigin=""anonymous""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e1e3bbfb18139940f7d8404de8c96a9def71778916", async() => {
                WriteLiteral(@"
    <style>
        a:link {
            text-decoration: none;
        }
    </style>


    <!-- header section starts  -->

    <header class=""header"">

        <div class=""header-1"">

            <a href=""#"" class=""logo""> <i class=""fas fa-book""></i> Ktabi </a>
            <!-- <a href=""#register"" class=""F1"">Register</a>
            <a href=""#login"" class=""F1"">Login</a> -->
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e1e3bbfb18139940f7d8404de8c96a9def71779598", async() => {
                    WriteLiteral(@"
                <input type=""text"" name=""SearchValue"" placeholder=""Search by BookStore Name  Or Address "" id=""search-box"">
                <button type=""submit"" class=""search-button"">
                    <span class=""button-icon""><i class=""fas fa-search""></i></span>
                </button>

                <!-- <label for=""search-box"" class=""fas fa-search""></label> -->
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <a href=\"/Account/Register/librarian\" class=\"register-library\">Register your own library </a>\r\n            <div class=\"icons\">\r\n                <div id=\"search-btn\" class=\"fas fa-search\"></div>\r\n\r\n");
#nullable restore
#line 63 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e1e3bbfb18139940f7d8404de8c96a9def717712340", async() => {
                    WriteLiteral(@"
                        <a href=""/upload/book"" class=""fa-solid fa-file-arrow-up""></a>

                        <a href=""/my/wishlist"" class=""fas fa-heart""></a>

                        <button type=""submit"" style=""background-color:white""><div id=""logout-btn"" class=""fa-solid fa-right-from-bracket""></div>   </button>

                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e1e3bbfb18139940f7d8404de8c96a9def717715311", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 78 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>

        <div class=""header-2"">
            <nav class=""navbar"" style=""width:56%"">


                <ul>

                    <li><a href=""/exchange/books"">Books To Exchange</a></li>
                    <li><a href=""/index"">Bookstores</a></li>



");
#nullable restore
#line 94 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li><a href=\"/my/recommended-books\">Recommended-Books </a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 3835, "\"", 3920, 3);
                WriteAttributeValue("", 3842, "/Account/Register/intersts/", 3842, 27, true);
#nullable restore
#line 97 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 3869, UserManager.GetUserId(User), 3869, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3897, "?handler=ResetIntersets", 3897, 23, true);
                EndWriteAttribute();
                WriteLiteral(">Update-my-intrests </a></li>\r\n");
#nullable restore
#line 98 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </ul>




            </nav>
        </div>

    </header>

    <!-- header section ends -->
    <!-- bottom navbar  -->


    <nav class=""bottom-navbar"">
        <a href=""home.html"" class=""fas fa-home""></a>
        <a href=""#featured"" class=""fas fa-list""></a>
        <a href=""#arrivals"" class=""fas fa-tags""></a>
        <a href=""section.html""><i class=""fa-solid fa-section""></i></a>
        <a href=""author.html""><i class=""fa-solid fa-feather-pointed""></i></a>
        <a href=""book.html""><i class=""fa-solid fa-book""></i></a>

    </nav>


    ");
#nullable restore
#line 127 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- footer section starts  -->

    <section class=""footer"">

        <div class=""box-container"">

            <div class=""box"">
                <h3>our locations</h3>
                <a href=""#""> <i class=""fas fa-map-marker-alt""></i> Cairo </a>
                <a href=""#""> <i class=""fas fa-map-marker-alt""></i> Giza </a>
                <a href=""#""> <i class=""fas fa-map-marker-alt""></i> Alex </a>
                <a href=""#""> <i class=""fas fa-map-marker-alt""></i> Tanta </a>
                <a href=""#""> <i class=""fas fa-map-marker-alt""></i> Sharm El Sheikh</a>
                <a href=""#""> <i class=""fas fa-map-marker-alt""></i> Hurghada </a>
            </div>

            <div class=""box"">
                <h3>quick links</h3>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> home </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> featured </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> arrivals </a>
                <a href=""#""> <i c");
                WriteLiteral(@"lass=""fas fa-arrow-right""></i> sections </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> authors </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> books </a>
            </div>



            <div class=""box"">
                <h3>contact info</h3>
                <a href=""#""> <i class=""fas fa-phone""></i> +123-456-7890 </a>
                <a href=""#""> <i class=""fas fa-phone""></i> +111-222-3333 </a>
                <a href=""#""> <i class=""fas fa-envelope""></i> ktabi@gmail.com </a>
                <img src=""/assets/images/worldmap.png"" class=""map""");
                BeginWriteAttribute("alt", " alt=\"", 6206, "\"", 6212, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>

        </div>

        <div class=""share"">
            <a href=""#"" class=""fab fa-facebook-f""></a>
            <a href=""#"" class=""fab fa-twitter""></a>
            <a href=""#"" class=""fab fa-instagram""></a>
            <a href=""#"" class=""fab fa-linkedin""></a>
            <a href=""#"" class=""fab fa-pinterest""></a>
        </div>

        <div class=""credit""> Created by  <span>FCAIH Team</span> ");
#nullable restore
#line 174 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
                                                            Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("| all rights reserved! </div>\r\n\r\n    </section>\r\n\r\n    <!-- footer section ends -->\r\n    <!-- loader  -->\r\n");
                WriteLiteral("\r\n\r\n    <script src=\"https://unpkg.com/swiper@7/swiper-bundle.min.js\"></script>\r\n\r\n\r\n    <script src=\"/js/CustomerJsFiles/shome.js\"></script>\r\n\r\n    ");
#nullable restore
#line 190 "D:\1- Project\New folder\GradutionProject\App.UI\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
