#pragma checksum "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/PartialCustomError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a63176f3ca7ea3ed659b12968b55eb1242fdb6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialCustomError), @"mvc.1.0.view", @"/Views/Home/PartialCustomError.cshtml")]
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
#line 1 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/_ViewImports.cshtml"
using Matrices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/_ViewImports.cshtml"
using Matrices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a63176f3ca7ea3ed659b12968b55eb1242fdb6d", @"/Views/Home/PartialCustomError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdaf004526811a3da471418ef12c772e877c25e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PartialCustomError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Matrices.Models.InfoOp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/PartialCustomError.cshtml"
 if (Model.ErrorMsg!=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul style=\"list-style-type:disc;\">\n");
#nullable restore
#line 6 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/PartialCustomError.cshtml"
     foreach (string err in Model.ErrorMsg)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"text-danger\">");
#nullable restore
#line 8 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/PartialCustomError.cshtml"
                               Write(err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 9 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/PartialCustomError.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 11 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/PartialCustomError.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Matrices.Models.InfoOp> Html { get; private set; }
    }
}
#pragma warning restore 1591