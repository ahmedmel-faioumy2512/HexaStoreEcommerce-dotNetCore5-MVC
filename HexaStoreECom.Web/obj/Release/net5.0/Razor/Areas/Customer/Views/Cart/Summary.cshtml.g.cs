#pragma checksum "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61898ba09c59f4a616c7d09d03fde2c25914208d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Summary), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
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
#line 1 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using HexaStoreECom.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using HexaStoreECom.Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using HexaStoreECom.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61898ba09c59f4a616c7d09d03fde2c25914208d", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b3d0356c84cb584474d87f5ee117a5bf703c4a", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/summary.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("className", new global::Microsoft.AspNetCore.Html.HtmlString("snippet-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d7032", async() => {
                WriteLiteral(@"
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <title>Snippet - BBBootstrap</title>
    <link href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css' rel='stylesheet'>
    <link href='https://use.fontawesome.com/releases/v5.7.2/css/all.css' rel='stylesheet'>
    <script type='text/javascript' src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61898ba09c59f4a616c7d09d03fde2c25914208d7753", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d9635", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"wrapper\">\r\n        <div class=\"h5 large\">");
#nullable restore
#line 24 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                         Write(localizer["Billing Address"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d10255", async() => {
                    WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-6 col-md-8 col-sm-10 offset-lg-0 offset-md-2 offset-sm-1"">
                    <div class=""mobile h5"">Billing Address</div>
                    <div id=""details"" class=""bg-white rounded pb-5"">

                        <div class=""form-group"">
                            <label class=""text-muted"">");
#nullable restore
#line 32 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                                 Write(localizer["Name"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61898ba09c59f4a616c7d09d03fde2c25914208d11237", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.Name);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d13151", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 34 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.Name);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"form-group\">\r\n                                    <label>");
#nullable restore
#line 39 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                      Write(localizer["City"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                    <div class=\"d-flex jusify-content-start align-items-center rounded p-2\">\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61898ba09c59f4a616c7d09d03fde2c25914208d15488", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 41 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.City);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        <span class=\"fas fa-check text-success pr-2\"></span>\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d17421", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 43 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.City);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""form-group"">
                                    <label>");
#nullable restore
#line 49 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                      Write(localizer["Phone Number"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                    <div class=\"d-flex jusify-content-start align-items-center rounded p-2\">\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61898ba09c59f4a616c7d09d03fde2c25914208d19800", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 51 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.PhoneNumber);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        <span class=\"fas fa-check text-success pr-2\"></span>\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d21740", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 53 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.PhoneNumber);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""form-group"">
                                    <label>");
#nullable restore
#line 61 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                      Write(localizer["Address"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                    <div class=\"d-flex jusify-content-start align-items-center rounded p-2\">\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61898ba09c59f4a616c7d09d03fde2c25914208d24199", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 63 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.Address);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        <span class=\"fas fa-check text-success pr-2\"></span>\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61898ba09c59f4a616c7d09d03fde2c25914208d26134", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 65 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.Address);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-6 col-md-8 col-sm-10 offset-lg-0 offset-md-2 offset-sm-1 pt-lg-0 pt-3"">
                    <div id=""cart"" class=""bg-white rounded"">
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""h6"">");
#nullable restore
#line 76 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                       Write(localizer["Cart Summary"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                            <div class=\"h6\">\r\n                                <a href=\"#\">");
#nullable restore
#line 78 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                       Write(localizer["Edit"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 81 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                         foreach (var item in Model.CartsList)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <div class=\"d-flex jusitfy-content-between align-items-center pt-3 pb-2 border-bottom\">\r\n                                <div class=\"item pr-2\">\r\n                                    <img");
                    BeginWriteAttribute("src", " src=\"", 4679, "\"", 4703, 2);
                    WriteAttributeValue("", 4685, "/", 4685, 1, true);
#nullable restore
#line 85 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
WriteAttributeValue("", 4686, item.Product.Img, 4686, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", "\r\n                                         alt=\"", 4704, "\"", 4752, 0);
                    EndWriteAttribute();
                    WriteLiteral(" width=\"80\" height=\"80\">\r\n                                    <div class=\"number\">");
#nullable restore
#line 87 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                                   Write(item.Count);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"d-flex flex-column px-3\">\r\n                                    <b class=\"h5\">");
#nullable restore
#line 90 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                             Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b>\r\n                                </div>\r\n                                <div class=\"ml-auto\">\r\n                                    <b class=\"h5\">$");
#nullable restore
#line 93 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                              Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 96 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n\r\n                        <div class=\"d-flex align-items-center py-2\">\r\n                            <div class=\"display-5\">");
#nullable restore
#line 101 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                              Write(localizer["Total"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                            <div class=\"ml-auto d-flex\">\r\n                                <div class=\"text-primary text-uppercase px-3\">usd</div>\r\n                                <div class=\"font-weight-bold\">$");
#nullable restore
#line 104 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                                          Write(Model.OrderHeader.TotalPrice);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>



                    <div class=""row pt-lg-3 pt-2 buttons mb-sm-0 mb-2"">
                        <div class=""col-md-6"">
                            <div class=""btn text-uppercase"">
                                <a href=""/Customer/Home"">");
#nullable restore
#line 114 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                                    Write(localizer["back to shopping"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6 pt-md-0 pt-1\" style=\"padding-inline: 0px;\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 118 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                     Write(localizer["Place Order"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-muted pt-3\" id=\"mobile\">\r\n                        <span class=\"fas fa-lock\"></span>\r\n                        ");
#nullable restore
#line 123 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
                   Write(localizer["Your information is save"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"text-muted\">\r\n            <span class=\"fas fa-lock\"></span>\r\n            ");
#nullable restore
#line 130 "D:\Faioumy\WORK_SW_Developer\Repos\myshop.Web\myshop.Web\Areas\Customer\Views\Cart\Summary.cshtml"
       Write(localizer["Your information is save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <script type='text/javascript' src='https://stackpath.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.bundle.min.js'></script>
    <script type='text/javascript' src='#'></script>
    <script type='text/javascript' src='#'></script>
    <script type='text/javascript' src='#'></script>
    <script type='text/javascript'>#</script>
    <script type='text/javascript'>
        var myLink = document.querySelector('a[href=""#""]');
        myLink.addEventListener('click', function (e) {
            e.preventDefault();
        });</script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public IOptions<HexaStoreECom.Utilities.StripeData> Stripe { get; private set; }
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
