#pragma checksum "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e939b751e16b0c389300a01a5465b4509239f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.Shared.Pages_Shared_CustomerLayout), @"mvc.1.0.view", @"/Pages/Shared/CustomerLayout.cshtml")]
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
#line 1 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
using SharedTenant.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e939b751e16b0c389300a01a5465b4509239f8b", @"/Pages/Shared/CustomerLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_CustomerLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-returnUrl", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/customer/index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/sections", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/customer/authors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/worldmap.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("map"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomerJsFiles/shome.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b8742", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 12 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

    <link rel=""stylesheet"" href=""https://unpkg.com/swiper@7/swiper-bundle.min.css"" />

    <!-- font awesome cdn link  -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"">

    <!-- custom css file link  -->
    <link href=""/css/CustomerCssFiles/bootstrap.css"" rel=""stylesheet"" />
    <link href=""/css/CustomerCssFiles/bootstrap.min (1).css"" rel=""stylesheet"" />


    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/css/bootstrap-select.css"">

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"">

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!--fontawesome link -->
    <script src=""https://kit.fontawesome.com/70ea18d072.js"" crossorigin=""anonymous""></script>
    <!-- logo icon  -->
    <link rel=""shortcut icon "" type=""image/png"" href=""/image/Logo.png"">
    <!-- custom jquery  ");
                WriteLiteral("-->\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\" integrity=\"sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=\" crossorigin=\"anonymous\"></script>\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b11399", async() => {
                WriteLiteral(@"
    <style>
        a:link {
            text-decoration: none;
        }

    </style>


    <header class=""header"">

        <div class=""header-1"">

            <a href=""/index"" class=""logo""> <i class=""fas fa-book""></i> Ktabi </a>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b11927", async() => {
                    WriteLiteral(@"
                <input type=""text"" name=""SearchValue"" placeholder=""search here..."" id=""search-box"">
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
             if (!ViewData["Title"].Equals("librarian register"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<a href=\"/Account/Register/librarian\" class=\"register-library\">Register your own library </a>\r\n");
#nullable restore
#line 63 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"icons\">\r\n\r\n                <div id=\"search-btn\" class=\"fas fa-search\"></div>\r\n\r\n                <!-- <div id=\"login-btn\" class=\"fas fa-user\"></div> -->\r\n");
#nullable restore
#line 70 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b14996", async() => {
                    WriteLiteral("\r\n                        <a href=\"/upload/book\" class=\"fa-solid fa-file-arrow-up\"></a>\r\n                        <a href=\"/my/wishlist\" class=\"fas fa-heart\"></a>\r\n                        <a");
                    BeginWriteAttribute("href", " href=\"", 3171, "\"", 3199, 3);
                    WriteAttributeValue("", 3178, "/", 3178, 1, true);
#nullable restore
#line 76 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
WriteAttributeValue("", 3179, Global.UrlName, 3179, 15, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 3194, "/cart", 3194, 5, true);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"fas fa-shopping-cart cart\">  <span class=\"count\"> 10 </span> </a>\r\n                        <button type=\"submit\" style=\"background-color:white\"><div id=\"logout-btn\" class=\"fa-solid fa-right-from-bracket\"></div>   </button>\r\n\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 80 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b18612", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 84 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div class=\"header-2\">\r\n            <nav class=\"navbar\" style=\"width:62%\">\r\n");
#nullable restore
#line 90 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                 if (!string.IsNullOrEmpty(Global.UrlName))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <ul>\r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 3867, "\"", 3896, 3);
                WriteAttributeValue("", 3874, "/", 3874, 1, true);
#nullable restore
#line 93 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
WriteAttributeValue("", 3875, Global.UrlName, 3875, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3890, "/index", 3890, 6, true);
                EndWriteAttribute();
                WriteLiteral(">home</a></li>\r\n");
#nullable restore
#line 94 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li><a href=\"/my/recommended-books\">Recommended-Books </a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 4113, "\"", 4198, 3);
                WriteAttributeValue("", 4120, "/Account/Register/intersts/", 4120, 27, true);
#nullable restore
#line 97 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
WriteAttributeValue("", 4147, UserManager.GetUserId(User), 4147, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4175, "?handler=ResetIntersets", 4175, 23, true);
                EndWriteAttribute();
                WriteLiteral(">Update-my-intrests </a></li>\r\n");
#nullable restore
#line 98 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li><a");
                BeginWriteAttribute("href", " href=\"", 4279, "\"", 4308, 3);
                WriteAttributeValue("", 4286, "/", 4286, 1, true);
#nullable restore
#line 99 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
WriteAttributeValue("", 4287, Global.UrlName, 4287, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4302, "/books", 4302, 6, true);
                EndWriteAttribute();
                WriteLiteral(">books</a></li>                                           \r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 4395, "\"", 4426, 3);
                WriteAttributeValue("", 4402, "/", 4402, 1, true);
#nullable restore
#line 100 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
WriteAttributeValue("", 4403, Global.UrlName, 4403, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4418, "/section", 4418, 8, true);
                EndWriteAttribute();
                WriteLiteral(">sections</a></li>\r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 4473, "\"", 4504, 3);
                WriteAttributeValue("", 4480, "/", 4480, 1, true);
#nullable restore
#line 101 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
WriteAttributeValue("", 4481, Global.UrlName, 4481, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4496, "/authors", 4496, 8, true);
                EndWriteAttribute();
                WriteLiteral(">authors</a></li>\r\n\r\n                </ul>\r\n");
#nullable restore
#line 104 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <ul>\r\n                <li><a href=\"/index\">home</a></li>\r\n");
#nullable restore
#line 109 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li><a href=\"/index\">Recommended-Books</a></li>\r\n                    <li><a href=\"/index\">Update-my-intrests </a></li>\r\n");
#nullable restore
#line 113 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                    <a href=\"/index\">books</a>\r\n\r\n                </li>\r\n                <li><a href=\"/index\">sections</a></li>\r\n                <li><a href=\"/index\">authors</a></li>\r\n\r\n            </ul>\r\n");
#nullable restore
#line 123 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </nav>\r\n\r\n        </div>\r\n\r\n    </header>\r\n    <div>\r\n        ");
#nullable restore
#line 130 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>




    <!-- header section ends -->







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
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b26614", async() => {
                    WriteLiteral(" <i class=\"fas fa-arrow-right\"></i> home ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b27885", async() => {
                    WriteLiteral(" <i class=\"fas fa-arrow-right\"></i> featured ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b29160", async() => {
                    WriteLiteral(" <i class=\"fas fa-arrow-right\"></i> arrivals ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b30435", async() => {
                    WriteLiteral(" <i class=\"fas fa-arrow-right\"></i> sections ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b31710", async() => {
                    WriteLiteral(" <i class=\"fas fa-arrow-right\"></i> authors ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <a href=""#""> <i class=""fas fa-arrow-right""></i> books </a>
            </div>

            <div class=""box"">
                <h3>extra links</h3>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> account info </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> ordered items </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> privacy policy </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> payment method </a>
                <a href=""#""> <i class=""fas fa-arrow-right""></i> our serivces </a>
            </div>

            <div class=""box"">
                <h3>contact info</h3>
                <a href=""#""> <i class=""fas fa-phone""></i> +123-456-7890 </a>
                <a href=""#""> <i class=""fas fa-phone""></i> +111-222-3333 </a>
                <a href=""#""> <i class=""fas fa-envelope""></i> ktabi@gmail.com </a>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e939b751e16b0c389300a01a5465b4509239f8b33941", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>

        </div>

        <div class=""share"">
            <a href=""#"" class=""fab fa-facebook-f""></a>
            <a href=""#"" class=""fab fa-twitter""></a>
            <a href=""#"" class=""fab fa-instagram""></a>
            <a href=""#"" class=""fab fa-linkedin""></a>
            <a href=""#"" class=""fab fa-pinterest""></a>
        </div>

        <div class=""credit""> created by <span>KKMPAY Team</span> | all rights reserved! </div>

    </section>

    <!-- footer section ends -->
    <!-- loader  -->




    <script src=""https://unpkg.com/swiper@7/swiper-bundle.min.js""></script>

    <!-- custom js file link  -->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e939b751e16b0c389300a01a5465b4509239f8b35891", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.bundle.min.js\"></script>\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.13.1/js/bootstrap-select.min.js\"></script>\r\n    ");
#nullable restore
#line 212 "D:\Clients\GraduationProject\Code\App.UI\Pages\Shared\CustomerLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
