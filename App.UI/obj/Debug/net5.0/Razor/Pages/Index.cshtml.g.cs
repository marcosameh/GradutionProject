#pragma checksum "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd6da4911d64ee3bb4ab36e460c683f79f38271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.UI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 3 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd6da4911d64ee3bb4ab36e460c683f79f38271", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5408dbb286367fae40b808725e1448beaf2f408", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        private global::Korzh.EasyQuery.AspNetCore.HighlightSelectedTextTagHelper __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .btnt {
        margin-top: 2rem;
        display: inline-block;
        padding: 0.9rem 9rem;
        border-radius: 5.5rem;
        color: #fff;
        background: var(--blue);
        font-size: 1.7rem;
        cursor: pointer;
        font-weight: 500;
    }

        .btnt:hover {
            background: var(--dark-color);
        }
</style>
<!-- reviews section starts  -->
<!-- reviews section starts  -->
<section class=""reviews"" id=""reviews"">

    <h1 class=""heading""> <span>publishing Bookstores</span> </h1>

    <div class=""swiper reviews-slider"">
        <div class=""swiper-wrapper"">
");
#nullable restore
#line 32 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
             if (Model.Bookstores.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
                 foreach (var store in Model.Bookstores)
                {
                   


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide box\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 952, "\"", 979, 2);
#nullable restore
#line 39 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
WriteAttributeValue("", 959, store.UrlName, 959, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 973, "/index", 973, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1015, "\"", 1050, 2);
            WriteAttributeValue("", 1021, "/Photos/librarian/", 1021, 18, true);
#nullable restore
#line 40 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
WriteAttributeValue("", 1039, store.Logo, 1039, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1051, "\"", 1057, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("eq-highlight-text", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd6da4911d64ee3bb4ab36e460c683f79f382715296", async() => {
            }
            );
            __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper = CreateTagHelper<global::Korzh.EasyQuery.AspNetCore.HighlightSelectedTextTagHelper>();
            __tagHelperExecutionContext.Add(__Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
                                              WriteLiteral(store.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
                                                                 WriteLiteral(Model.SearchValue);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Text = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("text", __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Text, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                            <p> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("eq-highlight-text", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd6da4911d64ee3bb4ab36e460c683f79f382717638", async() => {
            }
            );
            __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper = CreateTagHelper<global::Korzh.EasyQuery.AspNetCore.HighlightSelectedTextTagHelper>();
            __tagHelperExecutionContext.Add(__Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
                                              WriteLiteral(store.Address);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
                                                                    WriteLiteral(Model.SearchValue);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Text = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("text", __Korzh_EasyQuery_AspNetCore_HighlightSelectedTextTagHelper.Text, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
                            <div class=""stars"">
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star-half-alt""></i>
                            </div>
                        </a>

                        <a");
            BeginWriteAttribute("href", " href=\"", 1768, "\"", 1795, 2);
#nullable restore
#line 52 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
WriteAttributeValue("", 1775, store.UrlName, 1775, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1789, "/index", 1789, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btnt\">VISIT</a>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 55 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>No Related BookStores</h2>\r\n");
#nullable restore
#line 61 "D:\Clients\GraduationProject\Code\App.UI\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n        </div>\r\n    </section>\r\n\r\n\r\n    <!-- reviews section ends -->\r\n    <!-- reviews section ends -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.defaultModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.defaultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.defaultModel>)PageContext?.ViewData;
        public App.UI.Pages.defaultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
