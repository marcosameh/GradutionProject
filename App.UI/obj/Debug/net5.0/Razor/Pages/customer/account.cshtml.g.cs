#pragma checksum "D:\Clients\GraduationProject\Code\App.UI\Pages\customer\account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d774b5f575908b7d0efccba5dadf4eb416e227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.customer.Pages_customer_account), @"mvc.1.0.razor-page", @"/Pages/customer/account.cshtml")]
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
#line 1 "D:\Clients\GraduationProject\Code\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d774b5f575908b7d0efccba5dadf4eb416e227", @"/Pages/customer/account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60516fbdfe7ed4ccf842a382feccb1bbdfe10843", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_customer_account : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>what is your favourite book category</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d774b5f575908b7d0efccba5dadf4eb416e2273531", async() => {
                WriteLiteral(@"
        <div class=""text-center"">
    <h2>fiction book genres: </h2><br />
    <h3>Fantasy</h3>
    <input type=""radio"" id=""FantasyReally dislike"" name=""Fantasy"" value=""0"">
    <label for=""FantasyReally dislike"">Really dislike</label>
    <input type=""radio"" id=""Fantasydislike"" name=""Fantasy"" value=""1"">
    <label for=""Fantasydislike"">Dislike</label>
    <input type=""radio"" id=""Fantasyneather like nor dislike"" name=""Fantasy"" value=""2"">
    <label for=""Fantasyneather like nor dislike"">Neather like nor dislike</label>
    <input type=""radio"" id=""Fantasylike"" name=""Fantasy"" value=""3"">
    <label for=""Fantasylike"">Like</label>
    <input type=""radio"" id=""FantasyReally like"" name=""Fantasy"" value=""4"">
    <label for=""FantasyReally like"">Really like</label><br>
    <br>


    <h3>Adveture</h3>
    <input type=""radio"" id=""AdvetureReally dislike"" name=""Adveture"" value=""0"">
    <label for=""AdvetureReally dislike"">Really dislike</label>
    <input type=""radio"" id=""Adveturedislike"" name=""Adveture"" va");
                WriteLiteral(@"lue=""1"">
    <label for=""Adveturedislike"">Dislike</label>
    <input type=""radio"" id=""Advetureneather like nor dislike"" name=""Adveture"" value=""2"">
    <label for=""Advetureneather like nor dislike"">Neather like nor dislike</label>
    <input type=""radio"" id=""Adveturelike"" name=""Adveture"" value=""3"">
    <label for=""Adveturelike"">Like</label>
    <input type=""radio"" id=""AdvetureReally like"" name=""Adveture"" value=""4"">
    <label for=""AdvetureReally like"">Really like</label><br>
    <br>

    <h3>Romance</h3>
    <input type=""radio"" id=""RomanceReally dislike"" name=""Romance"" value=""0"">
    <label for=""RomanceReally dislike"">Really dislike</label>
    <input type=""radio"" id=""Romancedislike"" name=""Romance"" value=""1"">
    <label for=""Romancedislike"">Dislike</label>
    <input type=""radio"" id=""Romanceneather like nor dislike"" name=""Romance"" value=""2"">
    <label for=""Romanceneather like nor dislike"">Neather like nor dislike</label>
    <input type=""radio"" id=""Romancelike"" name=""Romance"" value=""3"">
   ");
                WriteLiteral(@" <label for=""Romancelike"">Like</label>
    <input type=""radio"" id=""RomanceReally like"" name=""Romance"" value=""4"">
    <label for=""RomanceReally like"">Really like</label><br>
    <br>

    <h3>Mystery</h3>
    <input type=""radio"" id=""MysteryReally dislike"" name=""Mystery"" value=""0"">
    <label for=""MysteryReally dislike"">Really dislike</label>
    <input type=""radio"" id=""Mysterydislike"" name=""Mystery"" value=""1"">
    <label for=""Mysterydislike"">Dislike</label>
    <input type=""radio"" id=""Mysteryneather like nor dislike"" name=""Mystery"" value=""2"">
    <label for=""Mysteryneather like nor dislike"">Neather like nor dislike</label>
    <input type=""radio"" id=""Mysterylike"" name=""Mystery"" value=""3"">
    <label for=""Mysterylike"">Like</label>
    <input type=""radio"" id=""MysteryReally like"" name=""Mystery"" value=""4"">
    <label for=""MysteryReally like"">Really like</label><br>
    <br>

    <h3>Horror</h3>
    <input type=""radio"" id=""HorrorReally dislike"" name=""Horror"" value=""0"">
    <label for=""HorrorReal");
                WriteLiteral(@"ly dislike"">Really dislike</label>
    <input type=""radio"" id=""Horrordislike"" name=""Horror"" value=""1"">
    <label for=""Horrordislike"">Dislike</label>
    <input type=""radio"" id=""Horrorneather like nor dislike"" name=""Horror"" value=""2"">
    <label for=""Horrorneather like nor dislike"">Neather like nor dislike</label>
    <input type=""radio"" id=""Horrorlike"" name=""Horror"" value=""3"">
    <label for=""Horrorlike"">Like</label>
    <input type=""radio"" id=""HorrorReally like"" name=""Horror"" value=""4"">
    <label for=""HorrorReally like"">Really like</label><br>
    <br>

    <h3>Science Fiction</h3>
    <input type=""radio"" id=""ScienceReally dislike"" name=""Science"" value=""0"">
    <label for=""ScienceReally dislike"">Really dislike</label>
    <input type=""radio"" id=""Sciencedislike"" name=""Science"" value=""1"">
    <label for=""Sciencedislike"">Dislike</label>
    <input type=""radio"" id=""Scienceneather like nor dislike"" name=""Science"" value=""2"">
    <label for=""Scienceneather like nor dislike"">Neather like nor disli");
                WriteLiteral(@"ke</label>
    <input type=""radio"" id=""Sciencelike"" name=""Science"" value=""3"">
    <label for=""Sciencelike"">Like</label>
    <input type=""radio"" id=""ScienceReally like"" name=""Science"" value=""4"">
    <label for=""ScienceReally like"">Really like</label><br>
    <br>

    <h3>Children</h3>
    <input type=""radio"" id=""ChildrenReally dislike"" name=""Children"" value=""0"">
    <label for=""ChildrenReally dislike"">Really dislike</label>
    <input type=""radio"" id=""Childrendislike"" name=""Children"" value=""1"">
    <label for=""Childrendislike"">Dislike</label>
    <input type=""radio"" id=""Childrenneather like nor dislike"" name=""Children"" value=""2"">
    <label for=""Childrenneather like nor dislike"">Neather like nor dislike</label>
    <input type=""radio"" id=""Childrenlike"" name=""Children"" value=""3"">
    <label for=""Childrenlike"">Like</label>
    <input type=""radio"" id=""ChildrenReally like"" name=""Children"" value=""4"">
    <label for=""ChildrenReally like"">Really like</label><br>
    <br>
    <button type=""submit"">");
                WriteLiteral("submit</button>\r\n</div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.customer.accountModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.accountModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.customer.accountModel>)PageContext?.ViewData;
        public App.UI.Pages.customer.accountModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
