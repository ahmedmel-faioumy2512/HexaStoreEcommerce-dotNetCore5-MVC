#pragma checksum "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9420c985021170fe2b3468c6786dd3193a2014"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\_ViewImports.cshtml"
using HexaStoreECom.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\_ViewImports.cshtml"
using HexaStoreECom.Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\_ViewImports.cshtml"
using HexaStoreECom.Entities.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9420c985021170fe2b3468c6786dd3193a2014", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b3d0356c84cb584474d87f5ee117a5bf703c4a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewBag.PageTitle = "Admin Area";
    ViewBag.CardTitle = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Ionicons -->
<link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">

<div class=""row"">
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
              <div class=""inner"">
                <h3>");
#nullable restore
#line 13 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.Orders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>All Orders</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-bag""></i>
              </div>
            <a href=""/Admin/Order/Index"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
              <div class=""inner"">
                <h3>");
#nullable restore
#line 28 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.ApprovedOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>Approved Orders</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
            <a href=""/Admin/Order/Index"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
              <div class=""inner"">
                <h3>");
#nullable restore
#line 43 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.Users);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>User Registrations</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-person-add""></i>
              </div>
            <a href=""/Admin/Users/Index"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
              <div class=""inner"">
                <h3>");
#nullable restore
#line 58 "D:\Faioumy\WORK_SW_Developer\Repos\HexaStoreECom.Web\HexaStoreECom.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.Products);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>Products</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-pie-graph""></i>
              </div>
            <a href=""/Admin/Product/Index"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
          </div>
          <!-- ./col -->
        </div>");
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