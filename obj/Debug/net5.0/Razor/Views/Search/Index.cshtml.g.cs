#pragma checksum "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172055c13d62e0573537418029261564a90bf269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\_ViewImports.cshtml"
using CATeam5Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\_ViewImports.cshtml"
using CATeam5Solution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172055c13d62e0573537418029261564a90bf269", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7485d7853701f4d5bdcf45a7a56ea3d627efbc50", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    List<Products> allProducts = (List<Products>)ViewData["allProducts"];
    string searchStr = (string)ViewData["searchStr"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172055c13d62e0573537418029261564a90bf2694747", async() => {
                WriteLiteral("\n        <b>Search Products:</b> <input name=\"searchStr\"");
                BeginWriteAttribute("value", " value=\"", 300, "\"", 318, 1);
#nullable restore
#line 12 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
WriteAttributeValue("", 308, searchStr, 308, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:75%\" />\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("    <p></p>\n");
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row mx-auto\">\n");
#nullable restore
#line 20 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
          foreach (Products products in allProducts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-10 p-10\" style=\"width: 18rem; margin: 0.5rem;\">\n                    <img class=\"card-img-top mx-auto\" style=\"width: 150px;height: 150px; margin: 1rem\"");
            BeginWriteAttribute("src", " src=\"", 675, "\"", 701, 2);
            WriteAttributeValue("", 681, "/img/", 681, 5, true);
#nullable restore
#line 23 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
WriteAttributeValue("", 686, products.Image, 686, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image TBF\">\n\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title text-center\">");
#nullable restore
#line 26 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
                                                      Write(products.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text text-center\">");
#nullable restore
#line 27 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
                                                    Write(products.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text text-center\" style=\"font-weight:bold\">$");
#nullable restore
#line 28 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
                                                                              Write(products.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text text-center\"");
            BeginWriteAttribute("id", " id=\"", 1105, "\"", 1129, 1);
#nullable restore
#line 29 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
WriteAttributeValue("", 1110, products.ProductID, 1110, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\n                    </div>\n\n                    <div class=\"card-text text-center\">\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1246, "\"", 1287, 3);
            WriteAttributeValue("", 1256, "addToCart(", 1256, 10, true);
#nullable restore
#line 33 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
WriteAttributeValue("", 1266, products.ProductID, 1266, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1285, ");", 1285, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"color:white; background-color:royalblue; border-color:royalblue;\">Add to Cart</a>\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1428, "\"", 1474, 3);
            WriteAttributeValue("", 1438, "removeFromCart(", 1438, 15, true);
#nullable restore
#line 34 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
WriteAttributeValue("", 1453, products.ProductID, 1453, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1472, ");", 1472, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"color: white; background-color:dimgrey; border-color:dimgrey; margin: 1rem;\">Remove from Cart</a>\n                    </div>\n\n                </div>\n");
#nullable restore
#line 38 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Search\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
