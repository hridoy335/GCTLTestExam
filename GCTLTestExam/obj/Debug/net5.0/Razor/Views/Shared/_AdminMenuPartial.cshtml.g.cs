#pragma checksum "D:\My Project\GCTLTestExam\GCTLTestExam\Views\Shared\_AdminMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff6912546cda0930d4ee8606b3e2a3e927e90c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminMenuPartial), @"mvc.1.0.view", @"/Views/Shared/_AdminMenuPartial.cshtml")]
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
#line 1 "D:\My Project\GCTLTestExam\GCTLTestExam\Views\_ViewImports.cshtml"
using GCTLTestExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Project\GCTLTestExam\GCTLTestExam\Views\_ViewImports.cshtml"
using GCTLTestExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff6912546cda0930d4ee8606b3e2a3e927e90c5", @"/Views/Shared/_AdminMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7c7987982ea5bbd8668f4a3cb14312879fa8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <!--  BEGIN SIDEBAR  -->
<div class=""sidebar-wrapper sidebar-theme"">

    <nav id=""sidebar"">
        <div class=""shadow-bottom""></div>
        <ul class=""list-unstyled menu-categories"" id=""accordionExample"">
            <li class=""menu"">
                <a href=""#dashboard"" data-active=""true"" data-toggle=""collapse"" aria-expanded=""true"" class=""dropdown-toggle"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 395, "\"", 403, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-home""><path d=""M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z""></path><polyline points=""9 22 9 12 15 12 15 22""></polyline></svg>
                        <span>Dashboard</span>
                    </div>
                    <div>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-chevron-right""><polyline points=""9 18 15 12 9 6""></polyline></svg>
                    </div>
                </a>
                <ul class=""collapse submenu list-unstyled show"" id=""dashboard"" data-parent=""#accordionExample"">
                    <li class=""active"">
                        <a href=""#""> Dashboard </a>
                  ");
            WriteLiteral("  </li>\n                   \n                </ul>\n            </li>\n\n            <li class=\"menu\">\n                <a href=\"#app\" data-toggle=\"collapse\" aria-expanded=\"false\" class=\"dropdown-toggle\">\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1652, "\"", 1660, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-cpu""><rect x=""4"" y=""4"" width=""16"" height=""16"" rx=""2"" ry=""2""></rect><rect x=""9"" y=""9"" width=""6"" height=""6""></rect><line x1=""9"" y1=""1"" x2=""9"" y2=""4""></line><line x1=""15"" y1=""1"" x2=""15"" y2=""4""></line><line x1=""9"" y1=""20"" x2=""9"" y2=""23""></line><line x1=""15"" y1=""20"" x2=""15"" y2=""23""></line><line x1=""20"" y1=""9"" x2=""23"" y2=""9""></line><line x1=""20"" y1=""14"" x2=""23"" y2=""14""></line><line x1=""1"" y1=""9"" x2=""4"" y2=""9""></line><line x1=""1"" y1=""14"" x2=""4"" y2=""14""></line></svg>
                        <span>Exam 1</span>
                    </div>
                    <div>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-chevr");
            WriteLiteral(@"on-right""><polyline points=""9 18 15 12 9 6""></polyline></svg>
                    </div>
                </a>
                <ul class=""collapse submenu list-unstyled"" id=""app"" data-parent=""#accordionExample"">
                    <li>
                        <a href=""#""> Add Customer </a>
                    </li>
                    <li>
                        <a href=""/Exam/GetCustomerInfo""> View Customer  </a>
                    </li>
              
                </ul>
            </li>

            <li class=""menu"">
                <a href=""#components"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 3348, "\"", 3356, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-box""><path d=""M21 16V8a2 2 0 0 0-1-1.73l-7-4a2 2 0 0 0-2 0l-7 4A2 2 0 0 0 3 8v8a2 2 0 0 0 1 1.73l7 4a2 2 0 0 0 2 0l7-4A2 2 0 0 0 21 16z""></path><polyline points=""3.27 6.96 12 12.01 20.73 6.96""></polyline><line x1=""12"" y1=""22.08"" x2=""12"" y2=""12""></line></svg>
                        <span>Exam 2</span>
                    </div>
                    <div>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-chevron-right""><polyline points=""9 18 15 12 9 6""></polyline></svg>
                    </div>
                </a>
                <ul class=""collapse submenu list-unstyled"" id=""components"" data-parent=""#accord");
            WriteLiteral(@"ionExample"">
                    <li>
                        <a href=""#""> Report Download </a>
                    </li>
                  
              
                </ul>
            </li>


        </ul>
        <!-- <div class=""shadow-bottom""></div> -->

    </nav>

</div>
<!--  END SIDEBAR  -->");
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