#pragma checksum "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb12bc9699128c2db2cf8addee3af95ed835f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logged_Explore), @"mvc.1.0.view", @"/Views/Logged/Explore.cshtml")]
namespace AspNetCore
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
#line 3 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
using Gallart.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb12bc9699128c2db2cf8addee3af95ed835f0a", @"/Views/Logged/Explore.cshtml")]
    public class Views_Logged_Explore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gallart.ViewModels.Logged.ExploreVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/explore.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/masonry.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
  
    ViewData["Title"] = "Explore";
    Layout = "~/Views/Shared/_LoggedLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb12bc9699128c2db2cf8addee3af95ed835f0a4423", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3eb12bc9699128c2db2cf8addee3af95ed835f0a4685", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb12bc9699128c2db2cf8addee3af95ed835f0a5863", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/masonry-layout@4.2.2/dist/masonry.pkgd.min.js"" integrity=""sha384-GNFwBvfVxBkLMJpYMOABq3c+d3KnQxudP/mGPkzpZSTYykLBNsZEnG2D9G/X/+7D"" crossorigin=""anonymous"" async></script>
    <link href=""C:\Users\Anastasija\.nuget\packages\bootstrap\4.6.0\contentFiles\any\any\wwwroot\css\bootstrap-grid.css"" rel=""stylesheet"" />
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb12bc9699128c2db2cf8addee3af95ed835f0a8043", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n        <div class=\"grid\">\r\n            <div class=\"grid-sizer\"></div>\r\n");
#nullable restore
#line 22 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
             foreach (Painting item in @Model.Paintings)
            {
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"grid-item\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 989, "\"", 1022, 2);
                WriteAttributeValue("", 996, "/List/Painting?id=", 996, 18, true);
#nullable restore
#line 26 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
WriteAttributeValue("", 1014, item.Id, 1014, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1054, "\"", 1088, 2);
                WriteAttributeValue("", 1060, "../..", 1060, 5, true);
#nullable restore
#line 27 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
WriteAttributeValue("", 1065, item.Path.Substring(9), 1065, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </a>\r\n                    <h2>");
#nullable restore
#line 29 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <h2>");
#nullable restore
#line 30 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                   Write(item.Artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
                WriteLiteral("\r\n                    <div class=\"dropdown\">\r\n                        <button class=\"dropbtn\">Add to list</button>\r\n                        <div class=\"dropdown-content\">\r\n");
#nullable restore
#line 36 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                             if (Model.ListOfLists != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                                 foreach (List list in Model.ListOfLists)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 1688, "\"", 1750, 4);
                WriteAttributeValue("", 1695, "/List/AddToThisList?paintingId=", 1695, 31, true);
#nullable restore
#line 40 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
WriteAttributeValue("", 1726, item.Id, 1726, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1734, "&listId=", 1734, 8, true);
#nullable restore
#line 40 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
WriteAttributeValue("", 1742, list.Id, 1742, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 40 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                                                                                                  Write(list.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 42 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                                                                                                                          
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>

                    </div>
                    <div class=""makenewlist"">
                        <form method=""post"" action=""/List/MakeNewList"">
                            <div class=""makenew"">
                                ");
#nullable restore
#line 52 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
                           Write(Html.TextBoxFor(u => u.List.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"submitbtn\">\r\n                                <input type=\"submit\" value=\"Make new list\" action=\"/List/MakeNewList\"> ");
                WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                        </form>\r\n                    </div>\r\n                   \r\n\r\n         </div>\r\n");
#nullable restore
#line 64 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Logged\Explore.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gallart.ViewModels.Logged.ExploreVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
