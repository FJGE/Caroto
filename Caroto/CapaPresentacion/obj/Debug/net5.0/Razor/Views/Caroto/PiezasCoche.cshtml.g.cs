#pragma checksum "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b8618a1d56f4d989860f121f2e77623ffbd408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caroto_PiezasCoche), @"mvc.1.0.view", @"/Views/Caroto/PiezasCoche.cshtml")]
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
#line 1 "E:\Caroto\Caroto\CapaPresentacion\Views\_ViewImports.cshtml"
using Caroto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Caroto\Caroto\CapaPresentacion\Views\_ViewImports.cshtml"
using Caroto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b8618a1d56f4d989860f121f2e77623ffbd408", @"/Views/Caroto/PiezasCoche.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b600d294bd38e7bf239f0be1330c2d1481745bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Caroto_PiezasCoche : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CapaSoporte.AllList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
  
    Layout = "_Layout - coche";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
 using (Html.BeginForm("Index", "Caroto", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
Write(Html.LabelFor(x => x.Titulo, new { style = "margin-left: 50px; margin-top: 20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row row-cols-1 row-cols-md-4 mb-3 text-center\" style=\"display: flex; flex-direction: row; gap: 50px; padding-top: 10px; padding-left: 100px;\">\r\n");
#nullable restore
#line 12 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
         foreach (var item in Model.PiezasCoche)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cardMk2\" style=\"height: 265px !important;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 539, "\"", 557, 1);
#nullable restore
#line 15 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
WriteAttributeValue("", 545, item.Imagen, 545, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin: auto; width:200px;\" /><br />\r\n                ");
#nullable restore
#line 16 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
           Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("€\r\n                <input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 763, "\"", 779, 1);
#nullable restore
#line 18 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
WriteAttributeValue("", 771, item.id, 771, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-top: 7px;\">\r\n            </div>\r\n");
#nullable restore
#line 20 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
            WriteLiteral("    <div class=\"buttons\" style=\"justify-content: center;\">\r\n        ");
#nullable restore
#line 24 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
   Write(Html.ActionLink("Continuar", "Compra", "Caroto", new { matricula = ViewBag.matricula, imagen = ViewBag.imagen }, new { @class = "regButton", style = "text-decoration: none; position: center;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 26 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CapaSoporte.AllList> Html { get; private set; }
    }
}
#pragma warning restore 1591
