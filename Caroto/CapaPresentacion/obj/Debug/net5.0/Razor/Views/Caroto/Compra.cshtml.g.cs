#pragma checksum "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Compra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16757928c66687c74d318e8b519f815a926bcaa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caroto_Compra), @"mvc.1.0.view", @"/Views/Caroto/Compra.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16757928c66687c74d318e8b519f815a926bcaa2", @"/Views/Caroto/Compra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b600d294bd38e7bf239f0be1330c2d1481745bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Caroto_Compra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"Comprar\">\r\n");
#nullable restore
#line 2 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Compra.cshtml"
     if (ViewBag.matricula != null && ViewBag.imagen != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"photoView\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 143, "\"", 164, 1);
#nullable restore
#line 5 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Compra.cshtml"
WriteAttributeValue("", 149, ViewBag.imagen, 149, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"shopText\">\r\n            <p>\r\n                <span style=\"font-size: 2em;\">Matricula:</span>\r\n                ");
#nullable restore
#line 10 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Compra.cshtml"
           Write(ViewBag.matricula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br /><br />\r\n                <span style=\"font-size: 2em;\">Piezas seleccionadas:</span>\r\n                <br />\r\n                <br />\r\n                <br />\r\n                <br />\r\n            </p>\r\n            ");
#nullable restore
#line 18 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Compra.cshtml"
       Write(Html.ActionLink("Comprar", "", "Caroto", null, new { @class = "regButton",id="ShopButton" , onclick = "showLog();return false;", style = "text-decoration: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Compra.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</section>

<div id=""logWindow"">
    <div class=""popup"">
        <h1>Felicidades</h1>
        <div class=""XBtn2"" onclick=""closeLog()"">&#10060;</div>
        <p>
            Ha realizado la compra satisfactoriamente.
            <br /><br />
            Para efectuar el pago y retirar el coche de nuestra tienda.<br />Por favor vaya a su tienda Caroto fisica mas cercana
        </p>
    </div>
</div>");
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
