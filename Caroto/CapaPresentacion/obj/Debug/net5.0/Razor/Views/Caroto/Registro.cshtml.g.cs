#pragma checksum "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf5f8f45b4543655d60858fde1bde61434b261fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caroto_Registro), @"mvc.1.0.view", @"/Views/Caroto/Registro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf5f8f45b4543655d60858fde1bde61434b261fc", @"/Views/Caroto/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b600d294bd38e7bf239f0be1330c2d1481745bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Caroto_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CapaSoporte.Principal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
  
    Layout = "_Layout - registro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
 using (Html.BeginForm("Registro", "Caroto", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"registro\">\r\n        <div class=\"reg-container\">\r\n            <div class=\"popup\">\r\n                <h1>");
#nullable restore
#line 12 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
               Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                ");
#nullable restore
#line 13 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.LabelFor(x => x.Correo, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.TextBoxFor(x => x.Correo, new { @class = "form-control", placeholder = "Correo" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.ValidationMessageFor(x => x.Correo, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 17 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.LabelFor(x => x.Contraseña, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.PasswordFor(x => x.Contraseña, new { @class = "form-control", placeholder = "Contraseña" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.ValidationMessageFor(x => x.Contraseña, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
           Write(Html.ActionLink("Crear", "SeleccionVehiculo", "Caroto", null, new { @class = "popup a", style = "width: 200px;", onclick = "document.forms[0].submit();return false" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"img-container\"></div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 25 "E:\Caroto\Caroto\CapaPresentacion\Views\Caroto\Registro.cshtml"
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
