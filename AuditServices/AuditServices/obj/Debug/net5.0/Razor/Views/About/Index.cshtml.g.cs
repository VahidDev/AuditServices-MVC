#pragma checksum "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22041029a0b6e5e507e074ac7d07e53a155a5fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22041029a0b6e5e507e074ac7d07e53a155a5fee", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85ec031282cfb56073139d3194e9507191d08fe", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("white hover-cc fw-300 my-4 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\OneDrive\Рабочий стол\AuditServices\AuditServices\AuditServices\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""breadcrumb-about"" class=""pos-rel"">
    <div class=""container"">
        <div class=""row flex-column align-items-around"">
            <div class=""mt-5 primary-bg page-location d-flex align-items-center"">
                <i class=""fs-2 white fas fa-home hover-cc""></i>
                <p class=""fs-2 white hover-cc"">Haqqımızda</p>
            </div>
            <div class=""breadcrumb--title fs-2 white fw-400"">Audit Services</div>
            <div class=""breadcrumb--text white mt-5"">
                Biznesdə daha irəlidə olun, bizi seçməklə sizdə gələcəyə irəliləyin
            </div>
            <div class=""breadcrumb--nav d-flex flex-column flex-lg-row"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22041029a0b6e5e507e074ac7d07e53a155a5fee6551", async() => {
                WriteLiteral("Niyə görə biz?");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22041029a0b6e5e507e074ac7d07e53a155a5fee7817", async() => {
                WriteLiteral("Müştərilərimiz");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22041029a0b6e5e507e074ac7d07e53a155a5fee9083", async() => {
                WriteLiteral("Komandamız");
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
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<section id=""main-info"" class=""py-5 margin-sec"">
    <div class=""container"">
        <div class=""row my-5"">
            <div class=""col-12"">
                <p class=""fw-600 fs-3 main-title"">
                    Audit Services <br />
                    Going beyond business as usual, so you can too.
                </p>
                <p class=""text fs-2 my-5"">
                    We invest in listening, building relationships and understanding
                    your concerns to deliver an experience that’s more personal,
                    agile and proactive. We work at the pace that matters. Yours.
                    That's why we celebrate fresh thinking and diverse perspectives
                    to find better solutions. We don’t predict the future. We help
                    you shape it.
                </p>
                <p class=""fw-600 fs-3 main-title mt-5"">
                    We embrace what makes each market");
            WriteLiteral(@" unique. <br />
                    On a global scale.
                </p>
                <p class=""text fs-2 my-5"">
                    We are a global network of 58,000 people in member firms in over
                    130 countries with a common goal — to help you realise your
                    ambitions. Which is why our network combines global scale and
                    capability with local insights and understanding. So, whether
                    you’re growing in one market or many, looking to operate more
                    effectively, managing risk and regulation, or realising
                    stakeholder value, our member firms have the assurance, tax and
                    advisory capabilities you need with the quality you expect.
                </p>
            </div>
        </div>
    </div>
</section>
<section id=""personel"">
    <div class=""contanier-fluid"">
        <div class=""row"">
            <div class=""col-12 col-lg-4 px-0"">
                <div clas");
            WriteLiteral(@"s=""personel-card""
                     style=""
                  background-image: url('./assets/img/about-us/ceo-personel.webp');
                "">
                    <div class=""personel-card-title white"">Leadership</div>
                    <div class=""personel-card-info white mt-5"">
                        James Delore, CEO , FA Consulting.
                    </div>
                    <div class=""personel-card-sub white my-3"">
                        Hear from our global CEO
                    </div>
                    <a href=""#"">
                        <button class=""default-btn btn-w border-w"">
                            Read more about James Delore
                        </button>
                    </a>
                </div>
            </div>
            <div class=""col-12 col-lg-4 px-0"">
                <div class=""personel-card""
                     style=""
                  background-image: url('./assets/img/about-us/personel-3.jpg');
                "">
        ");
            WriteLiteral(@"            <div class=""personel-card-title white"">GLOBAL SCALE</div>
                    <div class=""personel-card-info white mt-5"">
                        Global results 2020
                    </div>
                    <div class=""personel-card-sub white my-3"">
                        FA Consulting in facts and figures
                    </div>
                    <a href=""#"">
                        <button class=""default-btn btn-w border-w"">
                            Explore how we do it
                        </button>
                    </a>
                </div>
            </div>
            <div class=""col-12 col-lg-4 px-0"">
                <div class=""personel-card""
                     style=""
                  background-image: url('./assets/img/about-us/personel-2.webp');
                "">
                    <div class=""personel-card-title white"">PEOPLE</div>
                    <div class=""personel-card-info white mt-5"">
                        Inside FA Consulti");
            WriteLiteral(@"ng.
                    </div>
                    <div class=""personel-card-sub white my-3"">
                        Discover Grant Thornton through the eyes of our people,
                        clients and communities.
                    </div>
                    <a href=""#"">
                        <button class=""default-btn btn-w border-w"">
                            Step inside FA Consulting
                        </button>
                    </a>
                </div>
            </div>
        </div>
    </div>
</section>


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
