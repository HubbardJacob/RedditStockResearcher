#pragma checksum "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a67a3da432e460f02282e91200b48fe9544bc459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search__FilterPartial), @"mvc.1.0.view", @"/Views/Search/_FilterPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67a3da432e460f02282e91200b48fe9544bc459", @"/Views/Search/_FilterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01086bb23249ea500d4ab8ef99666ff1cb9e32", @"/Views/_ViewImports.cshtml")]
    public class Views_Search__FilterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-2 d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/upvote-trans.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("upvoteimg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("24"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("24"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/commentimg.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("commentimg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<script>

    $(""button[id*='delete']"").click(function (event) {
        var subToRem = this.parentElement.id;

        if (confirm(""Remove "" + subToRem + ""?"")) {
            var ticker = $(""#tickerHeader"").text();
            doRemoveSubreddit(subToRem, ticker);
            $(""#"" + subToRem + ""Card"").remove();
        }
    })

    function doRemoveSubreddit(subToRem, ticker) {

        $.ajax({
            method: ""GET"",
            url: ""/Search/RemoveSubreddit"",
            data: {
                ""remSub"": subToRem,
                ""ticker"": ticker
            }
        });
    }


</script>

");
#nullable restore
#line 32 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
 if (Model.PostDict != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"accordion\" id=\"stockAccordion\">\r\n");
#nullable restore
#line 35 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
         foreach (var item in Model.PostDict)
        {
            var subName = (@item.Key);


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3\"");
            BeginWriteAttribute("id", " id=\"", 1083, "\"", 1102, 2);
#nullable restore
#line 39 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 1088, subName, 1088, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1098, "Card", 1098, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 1148, "\"", 1169, 2);
#nullable restore
#line 41 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 1153, subName, 1153, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1163, "Header", 1163, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 1201, "\"", 1216, 1);
#nullable restore
#line 44 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 1206, subName, 1206, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"position-relative mb-0 d-flex\"");
            BeginWriteAttribute("style", " style=\"", 1255, "\"", 1313, 2);
            WriteAttributeValue("", 1263, "background-color:", 1263, 17, true);
#nullable restore
#line 44 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue(" ", 1280, Model.SubredditColors[item.Key], 1281, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        <button class=\"btn btn-link w-100 p-3\" type=\"button\" aria-expanded=\"false\" data-toggle=\"collapse\"\r\n                                data-target=\"#");
#nullable restore
#line 47 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                          Write(subName);

#line default
#line hidden
#nullable disable
            WriteLiteral("Collapse\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1507, "\"", 1541, 2);
#nullable restore
#line 47 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 1523, subName, 1523, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1533, "Collapse", 1533, 8, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none\">\r\n                            <h3 class=\"text-center\" style=\"color: white\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1686, "\"", 1737, 1);
#nullable restore
#line 49 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 1692, Url.Content(Model.SubredditImages[item.Key]), 1692, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"32\" height=\"32\" />\r\n                                ");
#nullable restore
#line 50 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                            Write("r/" + @item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1855, "\"", 1906, 1);
#nullable restore
#line 51 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 1861, Url.Content(Model.SubredditImages[item.Key]), 1861, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"32\" height=\"32\" />\r\n                            </h3>\r\n                        </button>\r\n\r\n                        <button");
            BeginWriteAttribute("id", " id=\"", 2038, "\"", 2059, 2);
            WriteAttributeValue("", 2043, "delete", 2043, 6, true);
#nullable restore
#line 55 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 2049, subName, 2049, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" style=\"position: absolute; top:0; right:0; transform: translate(30%, -20%);\">\r\n                            X\r\n                        </button>\r\n\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 2304, "\"", 2327, 2);
#nullable restore
#line 67 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 2309, subName, 2309, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2319, "Collapse", 2319, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2345, "\"", 2379, 2);
#nullable restore
#line 67 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 2363, subName, 2363, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2373, "Header", 2373, 6, true);
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#stockAccordion\">\r\n");
#nullable restore
#line 68 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                         foreach (Reddit.Controllers.Post post in item.Value)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""card-body"">

                                <div class=""d-flex justify-content-between p-3 mb-2 bg-dark"">
                                    <div class=""p-2 mr-auto ml-0 pr-lg-4 pl-0 align-self-center"">
                                        <div class=""p-2 pl-0 w-100"">
                                            <p class=""d-inline p-1 pr-md-1 text-white"">");
#nullable restore
#line 75 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                                                                  Write(post.UpVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a67a3da432e460f02282e91200b48fe9544bc45914190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"p-2 pl-0 w-100\">\r\n                                            <p class=\"d-inline p-1 pr-md-1 text-white\">");
#nullable restore
#line 79 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                                                                  Write(post.Listing.NumComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a67a3da432e460f02282e91200b48fe9544bc45916153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"p-2 ml-lg-5 align-self-center\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3664, "\"", 3718, 2);
            WriteAttributeValue("", 3671, "https://www.reddit.com", 3671, 22, true);
#nullable restore
#line 84 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 3693, post.Listing.Permalink, 3693, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h5 class=\"text-white justify-content-center text-center\">\r\n                                                ");
#nullable restore
#line 86 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                           Write(post.Listing.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </h5>
                                        </a>
                                    </div>

                                    <div class=""p-2 ml-auto align-self-center"">
                                        <p class=""text-right"" style=""color: lightgray"">");
#nullable restore
#line 92 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                                                                  Write(Model.PostsTimePassedStrings[post].Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-right font-italic text-muted\">");
#nullable restore
#line 93 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                                                                Write(Model.PostsTimePassedStrings[post].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                ");
#nullable restore
#line 97 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                           Write(Html.Raw(post.Listing.SelfTextHTML));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                 if (@post.Listing.IsRedditMediaDomain)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"img-fluid w-50 h-50 modal-open\"");
            BeginWriteAttribute("src", " src=\"", 4730, "\"", 4755, 1);
#nullable restore
#line 101 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
WriteAttributeValue("", 4736, post.Listing.URL, 4736, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post image\" />\r\n");
#nullable restore
#line 102 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 105 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 109 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 112 "C:\Users\Jacob\source\repos\RedditStockResearcher\RedditStockResearcher\Views\Search\_FilterPartial.cshtml"


}

#line default
#line hidden
#nullable disable
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