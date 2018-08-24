#pragma checksum "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c7e65d436e27f64bf736ce7b5942724b52c9db3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escola_Index), @"mvc.1.0.view", @"/Views/Escola/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escola/Index.cshtml", typeof(AspNetCore.Views_Escola_Index))]
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
#line 1 "c:\repositorios\github\gerenciador-de-escolas\Views\_ViewImports.cshtml"
using gerenciador_de_escolas;

#line default
#line hidden
#line 2 "c:\repositorios\github\gerenciador-de-escolas\Views\_ViewImports.cshtml"
using gerenciador_de_escolas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e65d436e27f64bf736ce7b5942724b52c9db3", @"/Views/Escola/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029d11e04635cc1bf807a8871ab82c6294cbaa40", @"/Views/_ViewImports.cshtml")]
    public class Views_Escola_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<gerenciador_de_escolas.ViewModels.EscolaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Escola", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("window.location = \'/Escola\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
  
    ViewData["Title"] = "Escola";

#line default
#line hidden
            BeginContext(113, 520, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""container center-align"">
        <span class=""title-view blue-text text-darken-2"">Lista de Escolas</span>
    </div>  
</div>
<div class=""row"">
        <div class=""container center-align"">
            <table class=""striped"">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Telefone</th>
                        <th>Ações</th>
                    </tr>
                </thead>

                <tbody>
");
            EndContext();
#line 22 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
                      foreach(var viewModel in @Model)
                    {

#line default
#line hidden
            BeginContext(712, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(809, 14, false);
#line 26 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
                           Write(viewModel.nome);

#line default
#line hidden
            EndContext();
            BeginContext(823, 120, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"telefone\">\r\n                                ");
            EndContext();
            BeginContext(944, 18, false);
#line 29 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
                           Write(viewModel.telefone);

#line default
#line hidden
            EndContext();
            BeginContext(962, 105, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1067, "\"", 1100, 2);
            WriteAttributeValue("", 1074, "/Escola/Form/", 1074, 13, true);
#line 32 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
WriteAttributeValue("", 1087, viewModel.id, 1087, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1101, 62, true);
            WriteLiteral(" class=\"btn blue\">Editar</a>\r\n                                ");
            EndContext();
            BeginContext(1163, 322, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c77fb6bf4f2427eb6cf6c0ff61719e9", async() => {
                BeginContext(1474, 7, true);
                WriteLiteral("Deletar");
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
#line 33 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
                                                         WriteLiteral(viewModel.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-anti-forgery", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1485, 36, true);
            WriteLiteral("\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1521, "\"", 1549, 2);
            WriteAttributeValue("", 1528, "/Escola/", 1528, 8, true);
#line 37 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
WriteAttributeValue("", 1536, viewModel.id, 1536, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1550, 100, true);
            WriteLiteral(" class=\"btn blue\">Visualizar</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 40 "c:\repositorios\github\gerenciador-de-escolas\Views\Escola\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1673, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1771, 283, true);
                WriteLiteral(@"
    <script src=""/js/jquery.validate.min.js""></script>
    <script src=""/js/jquery.validate.unobtrusive.js""></script>
    <script src=""/js/jquery.unobtrusive-ajax.min.js""></script>
    <script src=""/js/jquery.mask.js""></script>
    <script src=""/js/telefone.js""></script>
    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<gerenciador_de_escolas.ViewModels.EscolaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
