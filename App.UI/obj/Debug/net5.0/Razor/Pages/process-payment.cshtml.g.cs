#pragma checksum "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb7478db4d2242b8fe4d316ea3ee82359067f90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.Pages_process_payment), @"mvc.1.0.razor-page", @"/Pages/process-payment.cshtml")]
namespace App.UI.Pages
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
#line 2 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
using SharedTenant.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb7478db4d2242b8fe4d316ea3ee82359067f90", @"/Pages/process-payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_process_payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/icon/font-awesome/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"/css/CustomerCssFiles/bootstrap.css\" rel=\"stylesheet\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bdb7478db4d2242b8fe4d316ea3ee82359067f904655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link href=""/css/pages/print_style.min.css"" rel=""stylesheet"" />
<div class=""receipt-page"">
    <div class=""container"">
        <h1 class=""initial-title text-center mb-3 pb-1"">
            <svg width=""64"" height=""64"" class=""mb-3 d-block m-auto"">
                <use xlink:href=""/image/svg/master.svg#check""></use>
            </svg>
            Thank you this is details of your Order
        </h1>
        <p class=""text-center"">You will receive your order in 2-3  business days .</p>

        <div class=""receipt-content"">
            <h2>Order Confirmation</h2>
            <div class=""row"">
");
            WriteLiteral("                <div class=\"col-lg-5\">\r\n                    <span><b>Booking Number:</b>");
#nullable restore
#line 28 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                                           Write(Model.CallBackData.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span><b>Booking Date:</b>");
#nullable restore
#line 29 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                                         Write(Model.CreatedAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <span><b>Name:");
#nullable restore
#line 33 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                             Write(Model.user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                    <span><b>Phone:</b>");
#nullable restore
#line 34 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                                  Write(Model.user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span><b>Email:</b>");
#nullable restore
#line 35 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                                  Write(Model.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span><b>Address:</b>");
#nullable restore
#line 36 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                                    Write(Model.user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n            <h2>Books Purchased</h2>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">Book Name</th>\r\n");
            WriteLiteral("                        <th scope=\"col\">Price</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n");
#nullable restore
#line 51 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                     foreach (var item in Model.cart.CartList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 54 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                           Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                           Write(item.BookPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 57 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <tr class=\"total-row\">\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td>Total</td>\r\n                        <td><b>");
#nullable restore
#line 65 "D:\Clients\GraduationProject\Code\App.UI\Pages\process-payment.cshtml"
                          Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b> EGP</td>
                    </tr>
                </tbody>
            </table>
            <hr class=""mt-5"" />
            <h2 class=""mt-5 mb-4"">Contact Info</h2>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <span href=""tel:+01225115538""><b>Telephone:</b>01225115538</span>
                    <span href=""mailto: info@ktabi.com""><b>Email:</b>info@ktabi.com""</span>
                </div>
                <div class=""col-lg-6"">
                    <span><b>Address:</b>666 street</span>
                </div>
                <div class=""col-12 text-center mt-5"">
                    <button type=""button"" class=""initial-btn"" onclick=""window.print()""><i class=""fa-solid fa-print me-2""></i>Print</button>
                </div>
            </div>
        </div>
    </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.process_paymentModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.process_paymentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.process_paymentModel>)PageContext?.ViewData;
        public App.UI.Pages.process_paymentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
