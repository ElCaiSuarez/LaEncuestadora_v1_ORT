#pragma checksum "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "821fd812a488214581ffed7de3c639a6597aaca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encuesta_Delete), @"mvc.1.0.view", @"/Views/Encuesta/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821fd812a488214581ffed7de3c639a6597aaca1", @"/Views/Encuesta/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f84e31561e196a2a0514c683b1c9750f33b8a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Encuesta_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Encuesta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Borrar</h1>\r\n\r\n");
            WriteLiteral("<div>\r\n    <h4>Encuesta</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "821fd812a488214581ffed7de3c639a6597aaca17971", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "821fd812a488214581ffed7de3c639a6597aaca18237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EncuestaId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Borrar\" class=\"btn btn-danger\" /> |\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 1602, "\"", 1642, 2);
                WriteAttributeValue("", 1609, "/Cliente/Details/", 1609, 17, true);
#nullable restore
#line 49 "C:\Users\sj011105\source\repos\Solucion_WebApp.NET_MVC-2022-12D-PP_Encuestadora\WebApp.NET_MVC-2022-12D-PP_Encuestadora\Views\Encuesta\Delete.cshtml"
WriteAttributeValue("", 1626, Model.ClienteId, 1626, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Volver al Cliente</a>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models.Encuesta> Html { get; private set; }
    }
}
#pragma warning restore 1591
