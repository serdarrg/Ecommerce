#pragma checksum "C:\Users\z0048j5a\Source\Repos\Ecommerce\Views\Shared\_customnav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c0f3c2ae4b6852488ad9b6efe362259e9e87fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__customnav), @"mvc.1.0.view", @"/Views/Shared/_customnav.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c0f3c2ae4b6852488ad9b6efe362259e9e87fb", @"/Views/Shared/_customnav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__customnav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"navbar-custom\">\n    <ul class=\"list-unstyled topnav-menu float-right mb-0\">\n\n        <li class=\"d-none d-sm-block\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c0f3c2ae4b6852488ad9b6efe362259e9e87fb3703", async() => {
                WriteLiteral(@"
                <div class=""app-search-box"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        <div class=""input-group-append"">
                            <button class=""btn"" type=""submit"">
                                <i class=""fe-search""></i>
                            </button>
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>

        <li class=""dropdown notification-list"">
            <a class=""nav-link dropdown-toggle  waves-effect waves-light"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
                <i class=""fe-bell noti-icon""></i>
                <span class=""badge badge-danger rounded-circle noti-icon-badge"">9</span>
            </a>
            <div class=""dropdown-menu dropdown-menu-right dropdown-lg"">

                <div class=""slimscroll noti-scroll"">

                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item notify-item active"">
                        <div class=""notify-icon"">
                            <img src=""/images/users/user-1.jpg"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 1446, "\"", 1452, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <p class=""notify-details"">Cristina Pride</p>
                        <p class=""text-muted mb-0 user-msg"">
                            <small>Hi, How are you? What about our next meeting</small>
                        </p>
                    </a>

                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                        <div class=""notify-icon bg-primary"">
                            <i class=""mdi mdi-comment-account-outline""></i>
                        </div>
                        <p class=""notify-details"">
                            Caleb Flakelar commented on Admin
                            <small class=""text-muted"">1 min ago</small>
                        </p>
                    </a>

                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                        <div class=""notify-icon"">
                      ");
            WriteLiteral("      <img src=\"/images/users/user-4.jpg\" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 2551, "\"", 2557, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <p class=""notify-details"">Karen Robinson</p>
                        <p class=""text-muted mb-0 user-msg"">
                            <small>Wow ! this admin looks good and awesome design</small>
                        </p>
                    </a>

                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                        <div class=""notify-icon bg-warning"">
                            <i class=""mdi mdi-account-plus""></i>
                        </div>
                        <p class=""notify-details"">
                            New user registered.
                            <small class=""text-muted"">5 hours ago</small>
                        </p>
                    </a>

                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                        <div class=""notify-icon bg-info"">
                            <i cla");
            WriteLiteral(@"ss=""mdi mdi-comment-account-outline""></i>
                        </div>
                        <p class=""notify-details"">
                            Caleb Flakelar commented on Admin
                            <small class=""text-muted"">4 days ago</small>
                        </p>
                    </a>

                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                        <div class=""notify-icon bg-secondary"">
                            <i class=""mdi mdi-heart""></i>
                        </div>
                        <p class=""notify-details"">
                            Carlos Crouch liked
                            <b>Admin</b>
                            <small class=""text-muted"">13 days ago</small>
                        </p>
                    </a>
                </div>

                <!-- All-->
                <a href=""javascript:void(0);"" class=""dropdown-item text-center text-primary notify-item notify-all"">
   ");
            WriteLiteral(@"                 View all
                    <i class=""fi-arrow-right""></i>
                </a>

            </div>
        </li>

        <li class=""dropdown notification-list"">
            <a class=""nav-link dropdown-toggle nav-user mr-0 waves-effect waves-light"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
                <img src=""/images/users/user-1.jpg"" alt=""user-image"" class=""rounded-circle"">
                <span class=""pro-user-name ml-1"">
                    Geneva <i class=""mdi mdi-chevron-down""></i>
                </span>
            </a>
            <div class=""dropdown-menu dropdown-menu-right profile-dropdown "">
                <!-- item-->
                <div class=""dropdown-header noti-title"">
                    <h6 class=""text-overflow m-0"">Welcome !</h6>
                </div>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                    <i class=""fe-user""></i>
          ");
            WriteLiteral(@"          <span>My Account</span>
                </a>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                    <i class=""fe-settings""></i>
                    <span>Settings</span>
                </a>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                    <i class=""fe-lock""></i>
                    <span>Lock Screen</span>
                </a>

                <div class=""dropdown-divider""></div>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item notify-item"">
                    <i class=""fe-log-out""></i>
                    <span>Logout</span>
                </a>

            </div>
        </li>

        <li class=""dropdown notification-list"">
            <a href=""javascript:void(0);"" class=""nav-link right-bar-toggle waves-effect waves-light"">
                <i class=""fe-settings noti-icon""></i>
            </");
            WriteLiteral("a>\n        </li>\n\n\n    </ul>\n\n    <!-- LOGO -->\n    <div class=\"logo-box\">\n        <a href=\"index.html\" class=\"logo text-center\">\n            <span class=\"logo-lg\">\n                <img src=\"/images/logo-light.png\"");
            BeginWriteAttribute("alt", " alt=\"", 6868, "\"", 6874, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"18\">\n                <!-- <span class=\"logo-lg-text-light\">UBold</span> -->\n            </span>\n            <span class=\"logo-sm\">\n                <!-- <span class=\"logo-sm-text-dark\">U</span> -->\n                <img src=\"/images/logo-sm.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7127, "\"", 7133, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""24"">
            </span>
        </a>
    </div>

    <ul class=""list-unstyled topnav-menu topnav-menu-left m-0"">
        <li>
            <button class=""button-menu-mobile waves-effect waves-light"">
                <i class=""fe-menu""></i>
            </button>
        </li>

        <li class=""dropdown d-none d-lg-block"">
            <a class=""nav-link dropdown-toggle waves-effect waves-light"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
                Create New
                <i class=""mdi mdi-chevron-down""></i>
            </a>
            <div class=""dropdown-menu"">
                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item"">
                    <i class=""fe-briefcase mr-1""></i>
                    <span>New Projects</span>
                </a>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item"">
                    <i class=""fe-user mr-1""></i>
                    <s");
            WriteLiteral(@"pan>Create Users</span>
                </a>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item"">
                    <i class=""fe-bar-chart-line- mr-1""></i>
                    <span>Revenue Report</span>
                </a>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item"">
                    <i class=""fe-settings mr-1""></i>
                    <span>Settings</span>
                </a>

                <div class=""dropdown-divider""></div>

                <!-- item-->
                <a href=""javascript:void(0);"" class=""dropdown-item"">
                    <i class=""fe-headphones mr-1""></i>
                    <span>Help & Support</span>
                </a>

            </div>
        </li>

        <li class=""dropdown dropdown-mega d-none d-lg-block"">
            <a class=""nav-link dropdown-toggle waves-effect waves-light"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false""");
            WriteLiteral(@">
                Mega Menu
                <i class=""mdi mdi-chevron-down""></i>
            </a>
            <div class=""dropdown-menu dropdown-megamenu"">
                <div class=""row"">
                    <div class=""col-sm-8"">

                        <div class=""row"">
                            <div class=""col-md-4"">
                                <h5 class=""text-dark mt-0"">UI Components</h5>
                                <ul class=""list-unstyled megamenu-list"">
                                    <li>
                                        <a href=""javascript:void(0);"">Widgets</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Nestable List</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Range Sliders</a>
                                    </li>
                                    <li");
            WriteLiteral(@">
                                        <a href=""javascript:void(0);"">Masonry Items</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Sweet Alerts</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Treeview Page</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Tour Page</a>
                                    </li>
                                </ul>
                            </div>

                            <div class=""col-md-4"">
                                <h5 class=""text-dark mt-0"">Applications</h5>
                                <ul class=""list-unstyled megamenu-list"">
                                    <li>
                                        <a href=""javascript:void(0);");
            WriteLiteral(@""">eCommerce Pages</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">CRM Pages</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Email</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Calendar</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Team Contacts</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Task Board</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Email Template");
            WriteLiteral(@"s</a>
                                    </li>
                                </ul>
                            </div>

                            <div class=""col-md-4"">
                                <h5 class=""text-dark mt-0"">Extra Pages</h5>
                                <ul class=""list-unstyled megamenu-list"">
                                    <li>
                                        <a href=""javascript:void(0);"">Left Sidebar with User</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Menu Collapsed</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Small Left Sidebar</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">New Header Style</a>
                                    </li>
");
            WriteLiteral(@"                                    <li>
                                        <a href=""javascript:void(0);"">Search Result</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Gallery Pages</a>
                                    </li>
                                    <li>
                                        <a href=""javascript:void(0);"">Maintenance & Coming Soon</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-4"">
                        <div class=""text-center mt-3"">
                            <h3 class=""text-dark"">Special Discount Sale!</h3>
                            <h4>Save up to 70% off.</h4>
                            <button class=""btn btn-primary btn-rounded mt-3"">Download Now</button>
                        </div>
     ");
            WriteLiteral("               </div>\n                </div>\n\n            </div>\n        </li>\n    </ul>\n</div>");
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
