#pragma checksum "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509d02020634a54a141214ed5fb2af1abf35e76a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registro), @"mvc.1.0.view", @"/Views/Home/Registro.cshtml")]
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
#line 1 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\_ViewImports.cshtml"
using Caroto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\_ViewImports.cshtml"
using Caroto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"509d02020634a54a141214ed5fb2af1abf35e76a", @"/Views/Home/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b600d294bd38e7bf239f0be1330c2d1481745bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
 using (Html.BeginForm("Registro", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"box\">\r\n    <div class=\"title-logo-Registro\"></div>\r\n    <hr>\r\n\r\n    ");
#nullable restore
#line 10 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
Write(Html.LabelFor(x => x.Correo, new { @class = "", id = "title", style = "margin: 30px 0px 0px 500px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
Write(Html.TextBoxFor(x => x.Correo, new { @class = "form-control", id = "textBox", placeholder = "Email", style = "margin: 100px 0px 0px 530px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
Write(Html.ValidationMessageFor(x => x.Correo, null, new { @class = "text-danger", style = "margin: 150px 0px 0px 570px; position: fixed;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 14 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
Write(Html.LabelFor(x => x.Contraseña, new { @class = "", id = "title", style = "margin: 180px 0px 0px 500px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
Write(Html.PasswordFor(x => x.Contraseña, new { @class = "form-control", id = "textBox", placeholder = "Contraseña", style = "margin: 250px 0px 0px 530px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
Write(Html.ValidationMessageFor(x => x.Contraseña, null, new { @class = "text-danger", style = "margin: 300px 0px 0px 570px; position: fixed;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <button id=\"btn-general\" type=\"submit\" style = \"margin: 350px 0px 0px 560px;\">Crear Cuenta</button>\r\n</div>\r\n");
#nullable restore
#line 20 "D:\DAW\Programacion\Caroto\Caroto\CapaPresentacion\Views\Home\Registro.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
