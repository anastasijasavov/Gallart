#pragma checksum "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e1d496bf895ec12fd55f6b171217265262a6a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Create), @"mvc.1.0.view", @"/Views/Users/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e1d496bf895ec12fd55f6b171217265262a6a2", @"/Views/Users/Create.cshtml")]
    public class Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gallart.ViewModels.Users.CreateVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/signup.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/ballerinas.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
  
    ViewData["Title"] = "Sign up";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e1d496bf895ec12fd55f6b171217265262a6a24233", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9e1d496bf895ec12fd55f6b171217265262a6a24560", async() => {
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
                WriteLiteral("\r\n    <title>Sign up</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e1d496bf895ec12fd55f6b171217265262a6a26472", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9e1d496bf895ec12fd55f6b171217265262a6a26734", async() => {
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
                WriteLiteral("\r\n    <div class=\"sign-up\">\r\n\r\n        <div class=\"title\">Sign up</div>\r\n        <form action=\"/Users/Create\" method=\"post\">\r\n\r\n            <div>\r\n                <div>");
#nullable restore
#line 22 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                Write(Html.TextBoxFor(m => m.FirstName, new { placeholder = "First name...", @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <span class=\"redtext\">");
#nullable restore
#line 23 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                                 Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n                <div>");
#nullable restore
#line 26 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                Write(Html.TextBoxFor(m => m.LastName, new { placeholder = "Last name...", @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <span class=\"redtext\">");
#nullable restore
#line 27 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                                 Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n                <div>");
#nullable restore
#line 30 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                Write(Html.TextBoxFor(m => m.Email, new { placeholder = "Email...", @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <span class=\"redtext\">");
#nullable restore
#line 31 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                                 Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n                <div>");
#nullable restore
#line 34 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                Write(Html.TextBoxFor(m => m.Username, new { placeholder = "Username...", @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <span class=\"redtext\">");
#nullable restore
#line 35 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                                 Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n                <div>");
#nullable restore
#line 38 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                Write(Html.PasswordFor(m => m.Password, new { placeholder = "Password...", @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <span class=\"redtext\">");
#nullable restore
#line 39 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                                 Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n            <div> <span class=\"redtext\">");
#nullable restore
#line 41 "C:\Users\Anastasija\source\repos\Gallart1.0\Gallart1.0\Views\Users\Create.cshtml"
                                   Write(Html.ValidationMessage("CreateUserFailed"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n            <div>\r\n                \r\n                <input type=\"submit\" value=\"Create\" class=\"button\"   />\r\n\r\n                <a class=\"back\" href=\"/Home/Index\">Back</a>\r\n            </div>\r\n        </form>\r\n\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gallart.ViewModels.Users.CreateVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
