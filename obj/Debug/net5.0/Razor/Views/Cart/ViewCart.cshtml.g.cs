#pragma checksum "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58eec3851329aaa3d5f767654fd5b9164103ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ViewCart), @"mvc.1.0.view", @"/Views/Cart/ViewCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58eec3851329aaa3d5f767654fd5b9164103ee7", @"/Views/Cart/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7485d7853701f4d5bdcf45a7a56ea3d627efbc50", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/viewcart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/viewcart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartEmptyMessage_Emoji"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/CryingFaceEmoji.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart_CryingFaceEmoji"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
  
    ViewData["Title"] = "View Cart";
    List<CartItem> cartItems = (List<CartItem>)ViewData["cart"];
    var userCartAmt = ViewData["userCartAmt"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58eec3851329aaa3d5f767654fd5b9164103ee76322", async() => {
                WriteLiteral("\n        <script data-require=\"jquery@3.1.1\" data-semver=\"3.1.1\" src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js\"></script>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e58eec3851329aaa3d5f767654fd5b9164103ee76738", async() => {
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
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58eec3851329aaa3d5f767654fd5b9164103ee77918", async() => {
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
                WriteLiteral("\n    ");
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
            WriteLiteral("\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58eec3851329aaa3d5f767654fd5b9164103ee79727", async() => {
                WriteLiteral("\n        <p id=\"cartTop\" style=\"color:white;\">S</p>\n\n\n");
#nullable restore
#line 18 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
         if (cartItems.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"cartEmptyDiv\">\n            <h3 id=\"cartEmptyMessage\" style=\"text-align:center; padding: 20px;\">Your cart is empty!</h3>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e58eec3851329aaa3d5f767654fd5b9164103ee710480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n");
#nullable restore
#line 24 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table id=""cartTable"">
            <colgroup>
                <col class=""cart_Table_15"" />
                <col class=""cart_Table_40"" />
                <col class=""cart_Table_15"" />
                <col class=""cart_Table_20"" />
                <col class=""cart_Table_10"" />
            </colgroup>

            <tr>
                <th>Item</th>
                <th>Details</th>
                <th>Quantity</th>
                <th>Subtotal</th>
                <th>Remove from Cart</th>
            </tr>

");
#nullable restore
#line 44 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
             foreach (var cartitem in cartItems)
            {
                var placeholder = "subtotal" + @cartitem.Product.ProductID;
                var placeholder2 = "unitprice" + @cartitem.Product.ProductID;
                var placeholder3 = "cartitem" + @cartitem.Product.ProductID;
                var placeholder4 = "remove" + @cartitem.Product.ProductID;
                var rawSubtotal = @cartitem.Product.UnitPrice * @cartitem.Quantity;
                var initSubtotal = Math.Round(rawSubtotal,2).ToString("#,0.00");

                

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr");
                BeginWriteAttribute("id", " id=", 1937, "", 1954, 1);
#nullable restore
#line 53 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1941, placeholder3, 1941, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"itemRow\">\n                    <td>\n                        <img");
                BeginWriteAttribute("src", " src=\"", 2025, "\"", 2059, 2);
                WriteAttributeValue("", 2031, "/img/", 2031, 5, true);
#nullable restore
#line 55 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2036, cartitem.Product.Image, 2036, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </td>\n                    <td>\n                        <b>");
#nullable restore
#line 58 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
                      Write(cartitem.Product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b><br>\n                        ");
#nullable restore
#line 59 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
                   Write(cartitem.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br><br />\n                        <span");
                BeginWriteAttribute("id", " id=", 2271, "", 2288, 1);
#nullable restore
#line 60 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2275, placeholder2, 2275, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"unitprice\">$");
#nullable restore
#line 60 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
                                                             Write(cartitem.Product.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    </td>\n                    <td>\n                        <div>\n                            <input");
                BeginWriteAttribute("id", " id=", 2458, "", 2489, 1);
#nullable restore
#line 64 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2462, cartitem.Product.ProductID, 2462, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" step=\"1\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 2520, "\"", 2526, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 2543, "\"", 2569, 1);
#nullable restore
#line 64 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2551, cartitem.Quantity, 2551, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"qty\" class=\"cart_QuantityBox\" size=\"4\"");
                BeginWriteAttribute("pattern", " pattern=\"", 2616, "\"", 2626, 0);
                EndWriteAttribute();
                BeginWriteAttribute("inputmode", " inputmode=\"", 2627, "\"", 2639, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        </div>\n                    </td>\n                    <td");
                BeginWriteAttribute("id", " id=", 2722, "", 2738, 1);
#nullable restore
#line 67 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2726, placeholder, 2726, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"subtotals\">\n                        $");
#nullable restore
#line 68 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
                    Write(initSubtotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        <a");
                BeginWriteAttribute("id", " id=\"", 2874, "\"", 2892, 1);
#nullable restore
#line 71 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 2879, placeholder4, 2879, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"cartItem\"><img src=\"/img/RemoveFromCartIcon.png\" class=\"cart_RemoveIcon\"></a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 74 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </table>\n");
                WriteLiteral("        <hr id=\"lineDivider\" />\n");
                WriteLiteral("        <div id=\"totalPriceBottom\" style=\"text-align:right; font-size:22px; font-weight:bold;\">Total: $");
#nullable restore
#line 80 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
                                                                                                  Write(userCartAmt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n        <input type=\"submit\" value=\"Checkout &#x2192\" class=\"cart_CheckoutButton\" id=\"checkoutButton\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3316, "\"", 3394, 2);
#nullable restore
#line 81 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 3326, "window.location.href='" + @Url.Action("CheckOut", "Cart") + "'", 3326, 67, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3393, ";", 3393, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 82 "C:\Users\T450\Desktop\Projects\CATeam5-master (1) (1)\CATeam5-master\CATeam5Solution\Views\Cart\ViewCart.cshtml"
 
     }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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