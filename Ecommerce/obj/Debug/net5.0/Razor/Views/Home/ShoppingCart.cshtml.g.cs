#pragma checksum "C:\Users\z0048j5a\Source\Repos\Ecommerce\Views\Home\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46493fbcc983e38f6e9c14fb37d42e5c77342d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShoppingCart), @"mvc.1.0.view", @"/Views/Home/ShoppingCart.cshtml")]
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
#line 1 "C:\Users\z0048j5a\Source\Repos\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\z0048j5a\Source\Repos\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46493fbcc983e38f6e9c14fb37d42e5c77342d5f", @"/Views/Home/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">

            <!-- start page title -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""page-title-box"">
                        <div class=""page-title-right"">
                            <ol class=""breadcrumb m-0"">
                                <li class=""breadcrumb-item""><a href=""javascript: void(0);"">UBold</a></li>
                                <li class=""breadcrumb-item""><a href=""javascript: void(0);"">Ecommerce</a></li>
                                <li class=""breadcrumb-item active"">Shopping Cart</li>
                            </ol>
                        </div>
                        <h4 class=""page-title"">Shopping Cart</h4>
                    </div>
                </div>
            </div>
            <!-- end page title -->

            <div class=""row"">
                <div class=""col-12"">
     ");
            WriteLiteral(@"               <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-lg-8"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-borderless table-centered mb-0"">
                                            <thead class=""thead-light"">
                                                <tr>
                                                    <th>Product</th>
                                                    <th>Price</th>
                                                    <th>Quantity</th>
                                                    <th>Total</th>
                                                    <th style=""width: 50px;""></th>
                                                </tr>
                                            </thead>
                                            <tbody>
                   ");
            WriteLiteral(@"                             <tr>
                                                    <td>
                                                        <img src=""/images/products/product-1.png"" alt=""contact-img""
                                                             title=""contact-img"" class=""rounded mr-3"" height=""48"" />
                                                        <p class=""m-0 d-inline-block align-middle font-16"">
                                                            <a href=""ecommerce-product-detail.html"" class=""text-reset font-family-secondary"">Polo Navy blue T-shirt</a>
                                                            <br>
                                                            <small class=""mr-2""><b>Size:</b> Large </small>
                                                            <small>
                                                                <b>Color:</b> Light Green
                                                            </small>
             ");
            WriteLiteral(@"                                           </p>
                                                    </td>
                                                    <td>
                                                        $148.66
                                                    </td>
                                                    <td>
                                                        <input type=""number"" min=""1"" value=""5"" class=""form-control"" placeholder=""Qty"" style=""width: 90px;"">
                                                    </td>
                                                    <td>
                                                        $743.30
                                                    </td>
                                                    <td>
                                                        <a href=""javascript:void(0);"" class=""action-icon""> <i class=""mdi mdi-delete""></i></a>
                                                    </td>
                  ");
            WriteLiteral(@"                              </tr>
                                                <tr>
                                                    <td>
                                                        <img src=""/images/products/product-2.png"" alt=""contact-img""
                                                             title=""contact-img"" class=""rounded mr-3"" height=""48"" />
                                                        <p class=""m-0 d-inline-block align-middle font-16"">
                                                            <a href=""ecommerce-product-detail.html"" class=""text-body font-family-secondary"">Brown Hoodie for men</a>
                                                            <br>
                                                            <small class=""mr-2""><b>Size:</b> Small </small>
                                                            <small><b>Color:</b> Brown </small>
                                                        </p>
                               ");
            WriteLiteral(@"                     </td>
                                                    <td>
                                                        $99.00
                                                    </td>
                                                    <td>
                                                        <input type=""number"" min=""1"" value=""2"" class=""form-control"" placeholder=""Qty"" style=""width: 90px;"">
                                                    </td>
                                                    <td>
                                                        $198.00
                                                    </td>
                                                    <td>
                                                        <a href=""javascript:void(0);"" class=""action-icon""> <i class=""mdi mdi-delete""></i></a>
                                                    </td>
                                                </tr>
                                            ");
            WriteLiteral(@"    <tr>
                                                    <td>
                                                        <img src=""/images/products/product-3.png"" alt=""contact-img""
                                                             title=""contact-img"" class=""rounded mr-3"" height=""48"" />
                                                        <p class=""m-0 d-inline-block align-middle font-16"">
                                                            <a href=""ecommerce-product-detail.html"" class=""text-body font-family-secondary"">Designer Awesome T-Shirt</a>
                                                            <br>
                                                            <small class=""mr-2""><b>Size:</b> Medium </small>
                                                            <small><b>Color:</b> Light Pink </small>
                                                        </p>
                                                    </td>
                                           ");
            WriteLiteral(@"         <td>
                                                        $49.99
                                                    </td>
                                                    <td>
                                                        <input type=""number"" min=""1"" value=""10"" class=""form-control"" placeholder=""Qty"" style=""width: 90px;"">
                                                    </td>
                                                    <td>
                                                        $499.90
                                                    </td>
                                                    <td>
                                                        <a href=""javascript:void(0);"" class=""action-icon""> <i class=""mdi mdi-delete""></i></a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
  ");
            WriteLiteral(@"                                                      <img src=""/images/products/product-5.png"" alt=""contact-img""
                                                             title=""contact-img"" class=""rounded mr-3"" height=""48"" />
                                                        <p class=""m-0 d-inline-block align-middle font-16"">
                                                            <a href=""ecommerce-product-detail.html"" class=""text-body font-family-secondary"">Half Sleeves Tshirt</a>
                                                            <br>
                                                            <small class=""mr-2""><b>Size:</b> Large </small>
                                                            <small><b>Color:</b> Green </small>
                                                        </p>
                                                    </td>
                                                    <td>
                                                        $129.99
 ");
            WriteLiteral(@"                                                   </td>
                                                    <td>
                                                        <input type=""number"" min=""1"" value=""1"" class=""form-control"" placeholder=""Qty"" style=""width: 90px;"">
                                                    </td>
                                                    <td>
                                                        $129.99
                                                    </td>
                                                    <td>
                                                        <a href=""javascript:void(0);"" class=""action-icon""> <i class=""mdi mdi-delete""></i></a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div> <!-- end table-responsive-->
                  ");
            WriteLiteral(@"                  <!-- Add note input-->
                                    <div class=""mt-3"">
                                        <label for=""example-textarea"">Add a Note:</label>
                                        <textarea class=""form-control"" id=""example-textarea"" rows=""3"" placeholder=""Write some note..""></textarea>
                                    </div>

                                    <!-- action buttons-->
                                    <div class=""row mt-4"">
                                        <div class=""col-sm-6"">
                                            <a href=""ecommerce-products.html"" class=""btn text-muted d-none d-sm-inline-block btn-link font-weight-semibold"">
                                                <i class=""mdi mdi-arrow-left""></i> Continue Shopping
                                            </a>
                                        </div> <!-- end col -->
                                        <div class=""col-sm-6"">
                   ");
            WriteLiteral(@"                         <div class=""text-sm-right"">
                                                <a href=""ecommerce-checkout.html"" class=""btn btn-danger""><i class=""mdi mdi-cart-plus mr-1""></i> Checkout </a>
                                            </div>
                                        </div> <!-- end col -->
                                    </div> <!-- end row-->
                                </div>
                                <!-- end col -->

                                <div class=""col-lg-4"">
                                    <div class=""border p-3 mt-4 mt-lg-0 rounded"">
                                        <h4 class=""header-title mb-3"">Order Summary</h4>

                                        <div class=""table-responsive"">
                                            <table class=""table mb-0"">
                                                <tbody>
                                                    <tr>
                                                    ");
            WriteLiteral(@"    <td>Grand Total :</td>
                                                        <td>$1571.19</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Discount : </td>
                                                        <td>-$157.11</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Shipping Charge :</td>
                                                        <td>$25</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Estimated Tax : </td>
                                                        <td>$19.22</td>
                                                    </tr>
                                                ");
            WriteLiteral(@"    <tr>
                                                        <th>Total :</th>
                                                        <th>$1458.3</th>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <!-- end table-responsive -->
                                    </div>

                                    <div class=""alert alert-warning mt-3"" role=""alert"">
                                        Use coupon code <strong>UBTF25</strong> and get 25% discount !
                                    </div>

                                    <div class=""input-group mt-3"">
                                        <input type=""text"" class=""form-control form-control-light"" placeholder=""Coupon code""
                                               aria-label=""Recipient's username"">
              ");
            WriteLiteral(@"                          <div class=""input-group-append"">
                                            <button class=""btn btn-light"" type=""button"">Apply</button>
                                        </div>
                                    </div>

                                </div> <!-- end col -->

                            </div> <!-- end row -->
                        </div> <!-- end card-body-->
                    </div> <!-- end card-->
                </div> <!-- end col -->
            </div>
            <!-- end row -->

        </div> <!-- container -->

    </div> <!-- content -->
");
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
