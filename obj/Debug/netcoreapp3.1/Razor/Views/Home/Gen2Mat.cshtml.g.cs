#pragma checksum "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d6c8d353b1b401e228c99912dc7ee8b2e46cc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Gen2Mat), @"mvc.1.0.view", @"/Views/Home/Gen2Mat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d6c8d353b1b401e228c99912dc7ee8b2e46cc1", @"/Views/Home/Gen2Mat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdaf004526811a3da471418ef12c772e877c25e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Gen2Mat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Matrices.ViewModels.MatrixViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
  
    ViewData["Title"] = "Gen2 Mat";
    ViewData["CurrentPage"] = Context.Request.Path;
    string action = Model.Accion;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center row\">\n    <div class=\"col\">\n        <h1 class=\"display-4\">Escriba las Matrices</h1>\n    </div>\n</div>\n<div class=\"text-center row\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d6c8d353b1b401e228c99912dc7ee8b2e46cc14479", async() => {
                WriteLiteral("\n        <p>Matriz A</p><br>\n        <input type=\"hidden\" class=\"form-control\" name=\"RowA\"");
                BeginWriteAttribute("value", " value=\"", 462, "\"", 481, 1);
#nullable restore
#line 16 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
WriteAttributeValue("", 470, Model.RowA, 470, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n        <input type=\"hidden\" class=\"form-control\" name=\"ColA\"");
                BeginWriteAttribute("value", " value=\"", 546, "\"", 565, 1);
#nullable restore
#line 17 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
WriteAttributeValue("", 554, Model.ColA, 554, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n        <input type=\"hidden\" class=\"form-control\" name=\"RowB\"");
                BeginWriteAttribute("value", " value=\"", 630, "\"", 649, 1);
#nullable restore
#line 18 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
WriteAttributeValue("", 638, Model.RowB, 638, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n        <input type=\"hidden\" class=\"form-control\" name=\"ColB\"");
                BeginWriteAttribute("value", " value=\"", 714, "\"", 733, 1);
#nullable restore
#line 19 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
WriteAttributeValue("", 722, Model.ColB, 722, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n");
#nullable restore
#line 20 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
         for (int i = 0; i < Model.RowA; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\n");
#nullable restore
#line 23 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
             for (int j = 0; j < Model.ColA; j++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col\">\n                    <small class=\"text-secondary\">A");
#nullable restore
#line 26 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
                                                   Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\n                    <input type=\"text\" class=\"form-control\" name=\"Data\" value=\"0\" >\n                </div> \n");
#nullable restore
#line 29 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br>\n            </div>\n");
#nullable restore
#line 32 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\n        <p>Matriz B</p><br>\n");
#nullable restore
#line 35 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
         for (int i = 0; i < Model.RowB; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\n");
#nullable restore
#line 38 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
             for (int j = 0; j < Model.ColB; j++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col\">\n                    <small class=\"text-secondary\">B");
#nullable restore
#line 41 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
                                                   Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\n                    <input type=\"text\" class=\"form-control\" name=\"Data\" value=\"0\" >\n                </div> \n");
#nullable restore
#line 44 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br>\n            </div>\n");
#nullable restore
#line 47 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d6c8d353b1b401e228c99912dc7ee8b2e46cc110037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 49 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <button type=\"submit\" class=\"btn btn-primary mb-2\">Mandar</button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Gen2Mat.cshtml"
          WriteLiteral(action);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Matrices.ViewModels.MatrixViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
