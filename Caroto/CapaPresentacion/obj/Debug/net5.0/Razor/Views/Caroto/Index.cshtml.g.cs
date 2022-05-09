#pragma checksum "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40b10639b327eec62c6acdc262935d8d00526edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caroto_Index), @"mvc.1.0.view", @"/Views/Caroto/Index.cshtml")]
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
#line 1 "D:\Caroto\Caroto\CapaPresentacion\Views\_ViewImports.cshtml"
using Caroto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Caroto\Caroto\CapaPresentacion\Views\_ViewImports.cshtml"
using Caroto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b10639b327eec62c6acdc262935d8d00526edc", @"/Views/Caroto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b600d294bd38e7bf239f0be1330c2d1481745bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Caroto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CapaSoporte.Principal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
 using (Html.BeginForm("Index", "Caroto", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"hero\">\r\n        <div class=\"text\">\r\n            <h1>Caroto</h1>\r\n            <p>Tienda Web para comprar y personalizar el Vehiculo que quieras</p>\r\n            <div class=\"buttons\">\r\n                ");
#nullable restore
#line 10 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
           Write(Html.ActionLink("Iniciar Sesión", "", "Caroto", null, new { @class="logButton", onclick="showLog();return false;", style="text-decoration: none;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
           Write(Html.ActionLink("Registrarse", "Registro", "Caroto", null, new { @class="regButton", style="text-decoration: none;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            WriteLiteral("    <div id=\"logWindow\">\r\n        <div class=\"popup\">\r\n            <h1>Iniciar Sesión</h1>\r\n            <div class=\"XBtn\" onclick=\"closeLog()\">&#10060;</div>\r\n            ");
#nullable restore
#line 20 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
       Write(Html.LabelFor(x => x.Correo, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Correo, new { @class = "form-control", placeholder="Correo"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Correo, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 24 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
       Write(Html.LabelFor(x => x.Contraseña, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
       Write(Html.PasswordFor(x => x.Contraseña, new { @class = "form-control", placeholder="Contraseña"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
       Write(Html.ValidationMessageFor(x => x.Contraseña, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"submit\">Iniciar Sesión</button>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <section id=""productos"">
        <div class=""container"">
            <h2>Productos</h2>
            <div class=""card-container"">
                <div class=""card"">
                    <h3>Coches</h3>
                    <p>Elige un coche y personalizalo con las piezas disponibles de tu agrado.</p>
                </div>
                
                <div class=""card"">
                    <h3>Motos</h3>
                    <p>Elige un moto personalizala y presume de ella ante tus amigos.</p>
                </div>
            </div>
        </div>
    </section>
");
            WriteLiteral(@"    <section id=""sobre-nosotros"">
        <div class=""container"">
            <div class=""text"">
                <h3>Sobre Nosotros</h3>
                <p>Somos una tienda web dedicada a la venta de vehiculos personalizados por los usuarios para que puedan comprar el coche de sus sueños.<br><br>Elige tu Coche o Moto disponible entre una serie de gamas.<br><br> Añadele las piezas para hacer de tu vehiculo una experiencia unica</p>
            </div>
            <div class=""img-container""></div>
        </div>
    </section>
");
#nullable restore
#line 57 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CapaSoporte.Principal> Html { get; private set; }
    }
}
#pragma warning restore 1591
