#pragma checksum "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a807b1864e20ee5063795504ffdf469221968cd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encuesta_Index), @"mvc.1.0.view", @"/Views/Encuesta/Index.cshtml")]
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
#line 1 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\_ViewImports.cshtml"
using WebApp.NET_MVC_2022_12D_PP_Encuestadora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\_ViewImports.cshtml"
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a807b1864e20ee5063795504ffdf469221968cd4", @"/Views/Encuesta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f84e31561e196a2a0514c683b1c9750f33b8a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Encuesta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Encuesta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Encuestas</h1>\r\n\r\n<p>Comentario1: Deberia filtrar las encuestas del Cliente </p>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a807b1864e20ee5063795504ffdf469221968cd45662", async() => {
                WriteLiteral("Nueva Encuesta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cliente.nombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a807b1864e20ee5063795504ffdf469221968cd411378", async() => {
                WriteLiteral("Ver Encuesta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
                                              WriteLiteral(item.EncuestaId);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a807b1864e20ee5063795504ffdf469221968cd413978", async() => {
                WriteLiteral("Volver a Clientes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Encuesta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
