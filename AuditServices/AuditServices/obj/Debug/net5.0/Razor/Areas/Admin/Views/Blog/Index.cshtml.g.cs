#pragma checksum "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0492a903896f44ab27f5e2d1c7419223f8075a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.ViewModels.AdminVMs.UserVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.Constants.PocoConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.Models.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.ViewModels.AdminVMs.PageVMs.HomePageVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\_ViewImports.cshtml"
using AuditServices.ViewModels.AdminVMs.PageVMs.FooterVMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0492a903896f44ab27f5e2d1c7419223f8075a1", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c35213ea9d0fb2191d6575af4d2119843a597e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/dist/img/user1-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-size-50 mr-3 img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/dist/img/user8-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-size-50 img-circle mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/dist/img/user3-128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:300px;object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Blog shekli"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("Navbar", async() => {
                WriteLiteral(@"
    <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
        <!-- Left navbar links -->
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
            </li>
            <li class=""nav-item d-none d-sm-inline-block"">
                <a href=""index3.html"" class=""nav-link"">Ev</a>
            </li>
            <li class=""nav-item d-none d-sm-inline-block"">
                <a href=""#"" class=""nav-link"">Əlaqə</a>
            </li>
        </ul>

        <!-- Right navbar links -->
        <ul class=""navbar-nav ml-auto"">
            <!-- Navbar Search -->
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                    <i class=""fas fa-search""></i>
                </a>
                <div class=""navbar-search-block"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0492a903896f44ab27f5e2d1c7419223f8075a111275", async() => {
                    WriteLiteral(@"
                        <div class=""input-group input-group-sm"">
                            <input class=""form-control form-control-navbar"" type=""search"" id=""searchUser"" placeholder=""Search"" aria-label=""Search"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-navbar"" type=""submit"">
                                    <i class=""fas fa-search""></i>
                                </button>
                                <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                    <i class=""fas fa-times""></i>
                                </button>
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
                </div>
            </li>

            <!-- Messages Dropdown Menu -->
            <li class=""nav-item dropdown"">
                <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                    <i class=""far fa-comments""></i>
                    <span class=""badge badge-danger navbar-badge"">3</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                    <a href=""#"" class=""dropdown-item"">
                        <!-- Message Start -->
                        <div class=""media"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0492a903896f44ab27f5e2d1c7419223f8075a114088", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""media-body"">
                                <h3 class=""dropdown-item-title"">
                                    Brad Diesel
                                    <span class=""float-right text-sm text-danger""><i class=""fas fa-star""></i></span>
                                </h3>
                                <p class=""text-sm"">Call me whenever you can...</p>
                                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                            </div>
                        </div>
                        <!-- Message End -->
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <!-- Message Start -->
                        <div class=""media"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0492a903896f44ab27f5e2d1c7419223f8075a116269", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""media-body"">
                                <h3 class=""dropdown-item-title"">
                                    John Pierce
                                    <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                                </h3>
                                <p class=""text-sm"">I got your message bro</p>
                                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                            </div>
                        </div>
                        <!-- Message End -->
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <!-- Message Start -->
                        <div class=""media"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0492a903896f44ab27f5e2d1c7419223f8075a118444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""media-body"">
                                <h3 class=""dropdown-item-title"">
                                    Nora Silvester
                                    <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                                </h3>
                                <p class=""text-sm"">The subject goes here</p>
                                <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                            </div>
                        </div>
                        <!-- Message End -->
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
                </div>
            </li>
            <!-- Notifications Dropdown Menu -->
            <li class=""nav-item dropdown"">
                <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
    ");
                WriteLiteral(@"                <i class=""far fa-bell""></i>
                    <span class=""badge badge-warning navbar-badge"">15</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                    <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <i class=""fas fa-envelope mr-2""></i> 4 new messages
                        <span class=""float-right text-muted text-sm"">3 mins</span>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item"">
                        <i class=""fas fa-users mr-2""></i> 8 friend requests
                        <span class=""float-right text-muted text-sm"">12 hours</span>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdow");
                WriteLiteral(@"n-item"">
                        <i class=""fas fa-file mr-2""></i> 3 new reports
                        <span class=""float-right text-muted text-sm"">2 days</span>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a href=""#"" class=""dropdown-item dropdown-footer"">See All Notifications</a>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
                    <i class=""fas fa-expand-arrows-alt""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"" role=""button"">
                    <i class=""fas fa-th-large""></i>
                </a>
            </li>
        </ul>
    </nav>
");
            }
            );
            WriteLiteral(@"<!-- /.navbar -->
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"" id=""myModal"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Bloqların siyahısı</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0492a903896f44ab27f5e2d1c7419223f8075a123410", async() => {
                WriteLiteral("Əsas panel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"">Bloqlar</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Bloqlar</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example2"" class=""table table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th>Şəkil</th>
                                        <th>İstifadəçi</th>
                                        <th>Kontent</th>
            ");
            WriteLiteral("                        </tr>\r\n                                </thead>\r\n                                <tbody id=\"result\">\r\n");
#nullable restore
#line 182 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
                                     foreach (var blog in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"userInfoEl\">\r\n                                            <td style=\"width: 40%;\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0492a903896f44ab27f5e2d1c7419223f8075a126502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9554, "~/assets/img/", 9554, 13, true);
#nullable restore
#line 186 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 9567, blog.Image, 9567, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 190 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
                                           Write(blog.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><p style=\"overflow-y: auto; height: 300px;\">");
#nullable restore
#line 191 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
                                                                                       Write(blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0492a903896f44ab27f5e2d1c7419223f8075a129213", async() => {
                WriteLiteral("Daha ətraflı");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 193 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
                                                                              WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10272, "\"", 10288, 1);
#nullable restore
#line 194 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 10280, blog.Id, 10280, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10362, "\"", 10389, 1);
#nullable restore
#line 195 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 10370, blog.User.UserName, 10370, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <!--Fake Button trigger modal -->
                                                <button type=""button"" class=""btn btn-danger w-100 my-3 modalBtn"">
                                                    Sil
                                                </button>
                                            </td>
                                        </tr>
");
#nullable restore
#line 202 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>
<!--Delete modal-->
<!-- Real Button trigger modal -->
<input type=""hidden"" id=""modalActivate"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">İstifadəçi sil</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            ");
            WriteLiteral(@"</div>
            <div class=""modal-body"">
                Bu bloqu silməkdə əminsiniz? User: <span class=""text-primary"" id=""userInfo""></span>
                <input type=""hidden"" id=""blogId"" />
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Ləğv et</button>
                <button type=""button"" class=""btn btn-danger"" data-bs-dismiss=""modal"" id=""deleteBlog"">Sil</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM\" crossorigin=\"anonymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0492a903896f44ab27f5e2d1c7419223f8075a135130", async() => {
                    WriteLiteral(@"
        ""use strict"";
        window.onload = () => {
            // For Deleting
            let modalBtns = document.querySelectorAll("".modalBtn"");
            for (let modalBtn of modalBtns) {
                modalBtn.addEventListener(""click"", GetBlogId);
            }
            jQuery(document).on(""click"", ""#deleteBlog"", function (e) {
                $.ajax({
                    method: ""Post"",
                    url: ""Blog/Delete/"" + $(""#blogId"").val(),
                    success: function (res) {
                        if (res === ""Success"") {
                            $("".elToDelete"").detach()
                        } else {
                            window.location.replace(window.location.href + ""NotFound"");
                        }
                    }
                });
            });
        }
        function GetBlogId(e) {
            let btn = e.target;
            let userName = btn.previousElementSibling.value;
            document.querySelector(""#blogI");
                    WriteLiteral(@"d"").value = btn.previousElementSibling
                .previousElementSibling.value;
            document.getElementById(""userInfo"").textContent = userName;
            document.querySelector(""#modalActivate"").click();
            btn.closest("".userInfoEl"").classList.add(""elToDelete"");
        }
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#nullable restore
#line 242 "C:\Users\User\OneDrive\Desktop\AuditServices\AuditServices\AuditServices\Areas\Admin\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
