#pragma checksum "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67754e7bca849e7f8e13b8b379def95f8859046a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\_ViewImports.cshtml"
using RedditStockResearcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\_ViewImports.cshtml"
using RedditStockResearcher.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67754e7bca849e7f8e13b8b379def95f8859046a", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01086bb23249ea500d4ab8ef99666ff1cb9e32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Enter a Ticker: </h1>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67754e7bca849e7f8e13b8b379def95f8859046a4510", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"form-group d-flex justify-content-center col-md-8 mx-auto\">\r\n                <input id=\"searchInput\" class=\"form-control w-25\"");
                BeginWriteAttribute("placeholder", " placeholder=", 390, "", 466, 1);
#nullable restore
#line 14 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 403, ViewData["Searched"] != null ? ViewData["Searched"] : "TSLA", 403, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       maxlength=\"6\" pattern=\"[a-zA-Z]+\" type=\"text\" name=\"ticker\" />\r\n                <button type=\"submit\" class=\"btn btn-dark button-round ml-1\">Search</button>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
     if ((bool)ViewData["InvalidTicker"] != true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n            Please enter a valid ticker :)\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
    }
    else
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 32 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
      Write(ViewData["Searched"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
         if (ViewData["SubredditPosts"] != null)
        {
            var subcount = 0;
            Dictionary<string, string> subredditImages = (Dictionary<string, string>)ViewData["SubredditImages"];
            Dictionary<string, string> subredditColors = (Dictionary<string, string>)ViewData["SubredditColors"];
            Dictionary<Reddit.Controllers.Post, Tuple<string, string>> postsTimePassedStrings = (Dictionary<Reddit.Controllers.Post, Tuple<string, string>>)ViewData["PostsTimePassedStrings"];


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"accordion\" id=\"stockAccordion\">\r\n");
#nullable restore
#line 42 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                 foreach (var item in (Dictionary<string, List<Reddit.Controllers.Post>>)ViewData["SubredditPosts"])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mb-3\">\r\n                        <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 1833, "\"", 1856, 2);
            WriteAttributeValue("", 1838, "heading", 1838, 7, true);
#nullable restore
#line 45 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 1845, subcount, 1845, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h5 class=\"mb-0 btn-group d-flex\"");
            BeginWriteAttribute("style", " style=\"", 1921, "\"", 1973, 2);
            WriteAttributeValue("", 1929, "background-color:", 1929, 17, true);
#nullable restore
#line 46 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue(" ", 1946, subredditColors[item.Key], 1947, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <button class=\"btn btn-link w-100 p-3\" type=\"button\" aria-expanded=\"false\" data-toggle=\"collapse\"\r\n                                        data-target=\"#collapse");
#nullable restore
#line 48 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                                          Write(subcount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2182, "\"", 2217, 2);
            WriteAttributeValue("", 2198, "collapse", 2198, 8, true);
#nullable restore
#line 48 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 2206, subcount, 2206, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none\">\r\n\r\n                                    <h3 class=\"text-center\" style=\"color: white\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2380, "\"", 2425, 1);
#nullable restore
#line 51 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 2386, Url.Content(subredditImages[item.Key]), 2386, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"32\" height=\"32\" />\r\n                                        ");
#nullable restore
#line 52 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                    Write("r/"+ @item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2558, "\"", 2603, 1);
#nullable restore
#line 53 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 2564, Url.Content(subredditImages[item.Key]), 2564, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"32\" height=\"32\" />\r\n                                    </h3>\r\n\r\n                                </button>\r\n                            </h5>\r\n                            <div");
            BeginWriteAttribute("id", " id=\"", 2787, "\"", 2811, 2);
            WriteAttributeValue("", 2792, "collapse", 2792, 8, true);
#nullable restore
#line 58 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 2800, subcount, 2800, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2829, "\"", 2865, 2);
            WriteAttributeValue("", 2847, "heading", 2847, 7, true);
#nullable restore
#line 58 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
WriteAttributeValue("", 2854, subcount, 2854, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#stockAccordion\">\r\n");
#nullable restore
#line 59 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                 foreach (Reddit.Controllers.Post post in item.Value)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""card-body"">

                                    <div class=""d-flex justify-content-between p-3 mb-2 bg-dark"">
                                        <div class=""p-2 invisible "" >
                                            <p class=""text-right"">random text to push</p>
                                            <p class=""text-right font-italic text-muted"">random text to push</p>
                                        </div>
                                        <div class=""p-2 align-self-center flex-fill"" >
                                            <h5 class=""text-white justify-content-center text-center"">
                                                ");
#nullable restore
#line 70 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                           Write(post.Listing.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </h5>
                                        </div>

                                        <div class=""p-2 ml-auto align-self-center"" >
                                            <p class=""text-right"" style=""color: lightgray"">");
#nullable restore
#line 75 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                                                                      Write(postsTimePassedStrings[post].Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <p class=\"text-right font-italic text-muted\">");
#nullable restore
#line 76 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                                                                    Write(postsTimePassedStrings[post].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    \r\n                                    ");
#nullable restore
#line 80 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                               Write(Html.Raw(post.Listing.SelfTextHTML));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 82 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 86 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
                    subcount++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 89 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Home\Search.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591