#pragma checksum "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a7142383bafe7a1619002279928629744efdcbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Index.cshtml")]
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
#line 1 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\_ViewImports.cshtml"
using HexaStoreECom.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\_ViewImports.cshtml"
using HexaStoreECom.Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\_ViewImports.cshtml"
using HexaStoreECom.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7142383bafe7a1619002279928629744efdcbf", @"/Areas/Customer/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b3d0356c84cb584474d87f5ee117a5bf703c4a", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "plus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "minus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Summary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7142383bafe7a1619002279928629744efdcbf8960", async() => {
                WriteLiteral(@"
    <br />
    <div class=""container"">
        <div class=""card"">
            <div class=""card-header bg-dark text-light ml-0"">
                <div class=""row"">
                    <div class=""col-6  pt-2"">
                        <i class=""fas fa-shopping-cart""></i> &nbsp;
                        ");
#nullable restore
#line 15 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                   Write(localizer["Shopping Cart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-6 text-end\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7142383bafe7a1619002279928629744efdcbf9929", async() => {
#nullable restore
#line 18 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                                                        Write(localizer["Continue Shopping"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 24 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                 if (Model.CartsList.Count() < 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h4>");
#nullable restore
#line 26 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                   Write(localizer["There is no Items in Your Cart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 27 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                     foreach (var item in Model.CartsList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"d-none d-lg-block col-lg-1 text-center py-2\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a7142383bafe7a1619002279928629744efdcbf13465", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1305, "~/", 1305, 2, true);
#nullable restore
#line 34 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1307, item.Product.Img, 1307, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-12 col-lg-6 pt-md-3\">\r\n                                <h5><strong>");
#nullable restore
#line 37 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h5>\r\n                                <p><small>");
#nullable restore
#line 38 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                     Write(Html.Raw(item.Product.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</small></p>
                            </div>
                            <div class=""col-12  col-lg-5 text-center row"">
                                <div class=""col-4 text-md-right pt-4"">
                                    <h6>
                                        <strong>
                                            ");
#nullable restore
#line 44 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                       Write(item.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            <span class=\"text-muted\">&nbsp;x&nbsp;</span>");
#nullable restore
#line 45 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                    Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </strong>
                                    </h6>
                                </div>
                                <div class=""col-6 col-sm-4 col-lg-6 pt-2"">
                                    <div class=""w-75 btn-group"" role=""group"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7142383bafe7a1619002279928629744efdcbf17433", async() => {
                    WriteLiteral("\r\n                                            <i class=\"bi bi-plus-square\"></i>\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" &nbsp;\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7142383bafe7a1619002279928629744efdcbf20008", async() => {
                    WriteLiteral("\r\n                                            <i class=\"bi bi-dash-square\"></i>\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n\r\n                                </div>\r\n                                <div class=\"col-2 col-sm-4 col-lg-2 text-right pt-2\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7142383bafe7a1619002279928629744efdcbf22756", async() => {
                    WriteLiteral("\r\n                                        <i class=\"bi bi-trash-fill\"></i>\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cartId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 68 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-12 col-md-6 offset-md-6 col-lg-4 offset-lg-8 pr-4"">
                            <ul class=""list-group"">
                                <li class=""list-group-item d-flex justify-content-between bg-light"">
                                    <span class=""text-dark""> ");
#nullable restore
#line 73 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                        Write(localizer["Total"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (USD)</span>\r\n                                    <strong class=\"text-dark\">");
#nullable restore
#line 74 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                         Write(Model.OrderHeader.TotalPrice.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 79 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 83 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
             if (Model.CartsList.Count() != 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card-footer\">\r\n\r\n                    <div class=\"card-footer row\">\r\n\r\n                        <div class=\"col-sm-12 col-lg-4 col-md-6 offset-lg-8 offset-md-6 \">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7142383bafe7a1619002279928629744efdcbf27709", async() => {
#nullable restore
#line 90 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
                                                                                    Write(localizer["Summary"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 96 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Customer\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
