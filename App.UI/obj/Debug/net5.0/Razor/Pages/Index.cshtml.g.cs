#pragma checksum "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ec27d9d2710e840b25f605868f499918665d50"
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
#line 1 "D:\1- Project\final\GradutionProject\App.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"
using App.UI.Configurations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ec27d9d2710e840b25f605868f499918665d50", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60516fbdfe7ed4ccf842a382feccb1bbdfe10843", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- reviews section starts  -->


<!-- reviews section starts  -->

<section class=""reviews"" id=""reviews"">

    <h1 class=""heading""> <span>publishing Bookstores</span> </h1>

    <div class=""swiper reviews-slider"">

        <div class=""swiper-wrapper center"">


");
#nullable restore
#line 19 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"
             foreach (var store in Model.Bookstores)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 442, "\"", 469, 2);
#nullable restore
#line 23 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"
WriteAttributeValue("", 449, store.UrlName, 449, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 463, "/index", 463, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 526, "\"", 548, 1);
#nullable restore
#line 24 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"
WriteAttributeValue("", 534, store.UrlName, 534, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"swiper-slide box\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 634, "\"", 669, 2);
            WriteAttributeValue("", 640, "/Photos/librarian/", 640, 18, true);
#nullable restore
#line 26 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"
WriteAttributeValue("", 658, store.Logo, 658, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 670, "\"", 676, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h3>");
#nullable restore
#line 27 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"
                       Write(store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>Support our site by proving large amount of books</p>
                        <div class=""stars"">
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star-half-alt""></i>
                        </div>
                    </div>
                </a>
");
#nullable restore
#line 39 "D:\1- Project\final\GradutionProject\App.UI\Pages\Index.cshtml"

             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- reviews section ends -->\r\n<!-- reviews section ends -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ec27d9d2710e840b25f605868f499918665d506586", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".link"").click(function () {
             
                var UrlName = ($(this).children(""input"").val());
               
                $.ajax({
                 
                    url: ""?handler=SetUrl"",
                    data: { UrlName: UrlName }
                });


            })
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.UI.Pages.defaultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.defaultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<App.UI.Pages.defaultModel>)PageContext?.ViewData;
        public App.UI.Pages.defaultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
