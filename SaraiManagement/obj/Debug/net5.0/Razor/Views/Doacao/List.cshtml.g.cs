#pragma checksum "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56119f0630d16e2d04f6d9d75dd34745a585c398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doacao_List), @"mvc.1.0.view", @"/Views/Doacao/List.cshtml")]
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
#line 1 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Models.Enuns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Infraestrutura;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56119f0630d16e2d04f6d9d75dd34745a585c398", @"/Views/Doacao/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f313b1f01ac52a4fbf6214bdf8bb969f11c4e10e", @"/Views/_ViewImports.cshtml")]
    public class Views_Doacao_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaraiManagement.Models.ViewModels.DoacaoListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ItemDoado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    \r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
 foreach (var item in Model.Doacaos) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <div class=\"card-text p-1\">");
#nullable restore
#line 17 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
                                      Write(item.Donatario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </td>\r\n            <td>\r\n                <div class=\"card-text p-1\">");
#nullable restore
#line 20 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
                                      Write(item.Usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </td>\r\n            <td>\r\n                <div class=\"card-text p-1\">");
#nullable restore
#line 23 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
                                      Write(item.dataDoacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </td>\r\n           \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56119f0630d16e2d04f6d9d75dd34745a585c3986430", async() => {
                WriteLiteral("Adicionar Items");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
                                                                  WriteLiteral(item.DoacaoID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\JGL\Desktop\UNIFENAS\Ferramentas de Desenvolvimento\ProjetoFinal\SaraiManagement\Views\Doacao\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaraiManagement.Models.ViewModels.DoacaoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
