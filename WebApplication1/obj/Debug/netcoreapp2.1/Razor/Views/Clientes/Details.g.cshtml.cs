#pragma checksum "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada69feff2ea1391d739ca4f33ba530103216ff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Details.cshtml", typeof(AspNetCore.Views_Clientes_Details))]
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
#line 1 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada69feff2ea1391d739ca4f33ba530103216ff3", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 42, false);
#line 14 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 38, false);
#line 17 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(374, 42, false);
#line 20 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 38, false);
#line 23 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(498, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(542, 44, false);
#line 26 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(630, 40, false);
#line 29 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(670, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(714, 45, false);
#line 32 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.necesidad));

#line default
#line hidden
            EndContext();
            BeginContext(759, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(803, 41, false);
#line 35 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.necesidad));

#line default
#line hidden
            EndContext();
            BeginContext(844, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(888, 48, false);
#line 38 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.tipoDeEvento));

#line default
#line hidden
            EndContext();
            BeginContext(936, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(980, 44, false);
#line 41 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.tipoDeEvento));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1068, 45, false);
#line 44 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1157, 41, false);
#line 47 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1242, 41, false);
#line 50 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1327, 37, false);
#line 53 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1408, 45, false);
#line 56 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.invitados));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1497, 41, false);
#line 59 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.invitados));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1582, 44, false);
#line 62 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.detalles));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1670, 40, false);
#line 65 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.detalles));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1757, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa55354a8094e29a2b3741924dc443a", async() => {
                BeginContext(1803, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\aleja\Documents\Universidad\Semestre5\Integrador\Proyecto3\WebApplication1\WebApplication1\Views\Clientes\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1811, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1819, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d86f578d8a4b048b9b61ba1bd3d5c9", async() => {
                BeginContext(1841, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1857, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
