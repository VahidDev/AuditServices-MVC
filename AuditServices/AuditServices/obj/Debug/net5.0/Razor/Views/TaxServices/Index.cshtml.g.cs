#pragma checksum "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\TaxServices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da489630ad4efb06d9938c20ed2b7f8702cede5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaxServices_Index), @"mvc.1.0.view", @"/Views/TaxServices/Index.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices.ViewModels.AccountVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices.ViewModels.BlogVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices.ViewModels.AdminVMs.UserVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\_ViewImports.cshtml"
using AuditServices.Constants.PocoConstants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da489630ad4efb06d9938c20ed2b7f8702cede5", @"/Views/TaxServices/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85ec031282cfb56073139d3194e9507191d08fe", @"/Views/_ViewImports.cshtml")]
    public class Views_TaxServices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TaxAuditServices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary hover-cc fs-1-7 fw-600 my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TaxAdviceServices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Outsource", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary hover-cc  fs-1-7 fw-600 my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountingServices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("key-services-item fs-2 primary m-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("key-services-item fs-2 primary m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\TaxServices\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""service-head"" class=""pos-rel py-5"">
    <div class=""container"">
        <div class=""row"">
            <div class="" d-flex align-items-center"">
                <i class=""fs-1-7 primary fas fa-home hover-cc me-5""></i>
                <p class=""fs-1-9 primary hover-cc custom-before me-5"">
                    Xidmətlərimiz
                </p>
                <p class=""fs-1-9 primary hover-cc custom-before"">Vergi</p>
            </div>
        </div>
    </div>
</section>
<section id=""service-breadcrumb"" class=""white-bg"">
    <div class=""container pos-rel white-bg background "">
        <div class=""row background-height align-items-center"">
            <div class=""col-6   fw-600 service-title"">Vergi</div>

        </div>
    </div>
</section>
<section id=""service-panel"" class=""py-5 mt-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-lg-2"">
                <div class=""wrapper flex flex-column"">
                    <div class=""fs-2-");
            WriteLiteral(@"5 my-3"">Xidmətlərimiz</div>

                    <div class=""nav-wrapper d-flex justify-content-between align-items-center"">
                        <p class=""nav-drop-head primary fw-600 fs-1-9 hover-cc ls-2"">
                            Vergi
                        </p>
                        <i class=""fas fa-angle-right fs-1-9 hover-cc dropIcon""></i>
                    </div>
                    <div class=""nav-drop-menu d-flex flex-column my-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede58926", async() => {
                WriteLiteral("Vergi auditi xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede510209", async() => {
                WriteLiteral("Vergi məsləhət xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede511495", async() => {
                WriteLiteral("Vergi planlaması xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede512783", async() => {
                WriteLiteral("Vergi sahəsində sair xidmətlər");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""nav-wrapper d-flex justify-content-between align-items-center mt-3"">
                        <p class=""nav-drop-head primary fw-500 fs-1-9 hover-cc ls-2"">
                            Muhasibatlıq
                        </p>
                        <i class=""fas fa-angle-right fs-1-9 hover-cc dropIcon""></i>
                    </div>
                    <div class=""nav-drop-menu d-flex flex-column my-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede514556", async() => {
                WriteLiteral("\r\n                            Muhasibat uçotunun aparılması üzrə autsors\r\n                            xidməti\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede515958", async() => {
                WriteLiteral("\r\n                            Maliyyə uçotunun aparılması üzrə autsors\r\n                            xidmətləri\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede517361", async() => {
                WriteLiteral("\r\n                            Şirkət rəhbərliyinə xərclər və gəlirlilik haqqında\r\n                            hesabatların hazırlanması\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""nav-wrapper d-flex justify-content-between align-items-center"">
                        <p class=""nav-drop-head primary fw-500 fs-1-9 hover-cc ls-2"">
                            Məsləhət
                        </p>
                        <i class=""fas fa-angle-right fs-1-9 hover-cc dropIcon""></i>
                    </div>
                    <div class=""nav-drop-menu my-2"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede519243", async() => {
                WriteLiteral("Xarici ticarət və gömrük xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            <div class=""col-12 col-lg-9 "">
                <div class=""service-card-container d-flex flex-wrap"">
                    <div class=""main-card"">
                        <p class=""fs-2 fw-500 ls-2 primary"">Vergi</p>
                        <p class=""fs-2-5 fw-600 mt-3"">Global transparency report 2020</p>
                    </div>
                    <div class=""side-card "">
                        <div class=""card-info"">
                            <p class=""darkgray fs-2 ls-2"">
                                INSIGHTS
                            </p>
                            <p class=""fs-2-5 fw-600 ls-2"">
                                Business resilience
                            </p>
                            <a href=""#"" class=""fs-2 hover-cc secondary d-flex align-items-center hover-right"">
                                <p class=""fs-2 hover-cc secondary"">Retune your business</p>
               ");
            WriteLiteral(@"                 <i class=""fas fa-long-arrow-alt-right ms-3 mt-1""></i>
                            </a>
                        </div>
                        <div class=""card-image"">
                            <img src=""./assets/img/client-behaviour-300x300.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5196, "\"", 5202, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <p class=""fw-600 fs-3 main-title mt-5"">
                        Going beyond is what makes FA Consulting different. And what
                        clients value most.
                    </p>
                    <p class=""fw-600 fs-3 main-title my-5"">
                        We make business personal.
                    </p>
                    <p class=""text fs-2 my-5"">
                        Lorem ipsum dolor, sit amet consectetur adipisicing elit. Atque,
                        a maxime ipsa cupiditate voluptatum mollitia labore dignissimos
                        quibusdam sint dolor voluptatem excepturi corporis. Expedita
                        delectus non qui vitae velit omnis corrupti ducimus, quas
                        consequatur sequi blanditiis autem deserunt harum architecto
                        iusto ad odit recusandae rerum sed natus illum! Quidem vitae rem
                        praesent");
            WriteLiteral(@"ium ipsam ratione harum!
                    </p>
                    <ul class=""ms-4 my-3"">
                        <p class=""fw-600 ls-2 fs-2-5 my-3""> Transform Value</p>
                        <li class=""fs-1-9 fw-500 my-3"">
                            Define strategic goals and formulate solutions that keep you ahead of disruptive change
                        </li>
                        <li class=""fs-1-9 fw-500 my-3"">
                            Help you sustain and finance growth, manage risk and talent, optimise operations and protect value
                        </li>
                        <li class=""fs-1-9 fw-500 my-3"">
                            Improve financial processes and systems, reduce costs and transform your finance function
                        </li>
                        <li class=""fs-1-9 fw-500 my-3"">
                            Remove the burden of back office operations and compliance challenges, enabling you to focus on growth
                        </li>");
            WriteLiteral(@"
                        <li class=""fs-1-9 fw-500 my-3"">
                            Deliver systematic improvements across people, processes and technology, right through the supply chain
                        </li>
                        <li class=""fs-1-9 fw-500 my-3"">
                            Engage, specify and deliver scalable technology solutions
                        </li>
                    </ul>
                    <p class=""fs-1-9 fw-600 ls-2 my-3"">Talk to us</p>
                    <p class=""fs-2 fw-500 my-4 ls-2"">
                        If you have any questions or would like to find out more about how we can help, please contact your local member firm, or our global head of tax, <b>Lorem Dolar</b>.
                    </p>
                    <div class=""profile-card my-5"">
                        <div class=""profile-photo"">
                            <img src=""./assets/img/sub-sections/profile-photo.png""");
            BeginWriteAttribute("alt", " alt=\"", 8206, "\"", 8212, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        </div>
                        <p class=""fs-2-5 fw-600 ls-2"">
                            Lorem Dolar
                        </p>
                        <p class=""fs-2 fw-500 my-3"">Head of Tax</p>
                    </div>
                    <p class=""fs-2-5 fw-600 ls-2 col-12"">
                        Key Services
                    </p>
                    <div class=""key-services my-5 d-flex flex-wrap"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede525729", async() => {
                WriteLiteral("Vergi auditi xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede527013", async() => {
                WriteLiteral("Vergi məsləhət xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede528299", async() => {
                WriteLiteral("Vergi planlaması xidmətləri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da489630ad4efb06d9938c20ed2b7f8702cede529587", async() => {
                WriteLiteral("Vergi sahəsində sair xidmətlər");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
