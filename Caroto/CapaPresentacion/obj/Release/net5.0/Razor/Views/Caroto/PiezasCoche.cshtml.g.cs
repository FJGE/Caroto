#pragma checksum "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b189e8aec71dee7fe8c33ce7ca9e9db16cee72f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b189e8aec71dee7fe8c33ce7ca9e9db16cee72f", @"/Views/Caroto/PiezasCoche.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b600d294bd38e7bf239f0be1330c2d1481745bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Caroto_PiezasCoche : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CapaSoporte.AllList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Caroto\Caroto\CapaPresentacion\Views\Caroto\PiezasCoche.cshtml"
Write(Html.LabelFor(x => x.GamaBaja, new { style = "margin-left: 50px; margin-top: 20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<img id=""btn1"" onclick=""cambiarStyle(1)"" style=""cursor: pointer; margin-top: -10px; margin-left: 10px;"" src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAABOUlEQVRIS+2V7xHBQBDFpQMlKIEO6IASdEAFqIAO6IAO6IAOpANKsL8PZy6y7k/mTnzIzuyE3N572Ze9l6LXUhQt8fY64p8p/xdS96XdleQwU9s3wV0abLvjqdw8ZiI1sHP5ceCPTUzHj4zET8GeSNJ57Tjl7BqZd5rU5h5y8wAp4yRgMxtQm2okv0tyTREViV0ds5ZS8orEPmLWU0jOBDPJtXAZCFJfJQcN9S5l30gSqaOIKR5LnhsSM0wMlRohlrmVnYtIco7N26WadGz2IHmolTolNoAhHVPLe+aI+YL3icQXX2EoMTjIjeyu2Mji2kfKegwx9S7J8WC8WJ3iz4eJJf72IVHdydV5LDFYmqup7pSaGDzb1WofgBzv2GAi+V6SK5ZYhpDZNU2kjuVQ6zviJDKGgLQm9QsC7S0fn4YEFgAAAABJRU5ErkJggg=="" />

<div class=""invisible"" id=""H1"">
    <div class=""row row-cols-1 row-cols-md-4 mb-3 text-center"" style=""display: flex; flex-direction: row; gap: 50px; padding-top: 10px; padding-left: 100px;"">
        
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CapaSoporte.AllList> Html { get; private set; }
    }
}
#pragma warning restore 1591
