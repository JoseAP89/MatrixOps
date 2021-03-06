#pragma checksum "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "496e1c64a66d99fc0d072b2f748087260b77d376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"496e1c64a66d99fc0d072b2f748087260b77d376", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdaf004526811a3da471418ef12c772e877c25e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Matrices.ViewModels.MatrixViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Substraction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
  
    ViewData["Title"] = "Result Page";
    ViewData["CurrentPage"] = Context.Request.Path;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col text-center\">\n        <h2>Result</h2>\n        <table class=\"table table-bordered\">\n            <tbody>\n");
#nullable restore
#line 11 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                 foreach (List<double> row in Model.Result)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        \n");
#nullable restore
#line 15 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                         foreach (double val in row)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 17 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                            Write(String.Format("{0:F4}",val));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 18 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 20 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""row"">
    <div class=""col"">
        <p class=""text-dark"">Do another operation with the Matrix Result (Not working yet)</p class=""text-dark"">
    </div>
</div>
<div class=""row"">
    <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "496e1c64a66d99fc0d072b2f748087260b77d3766517", async() => {
                WriteLiteral("\n            <input type=\"hidden\" class=\"form-control\" name=\"RowA\"");
                BeginWriteAttribute("value", " value=\"", 1072, "\"", 1099, 1);
#nullable restore
#line 33 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 1080, Model.Result.Row, 1080, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n            <input type=\"hidden\" class=\"form-control\" name=\"ColA\"");
                BeginWriteAttribute("value", " value=\"", 1168, "\"", 1195, 1);
#nullable restore
#line 34 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 1176, Model.Result.Col, 1176, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n            <input type=\"hidden\" class=\"form-control\" name=\"RowB\"");
                BeginWriteAttribute("value", " value=\"", 1264, "\"", 1291, 1);
#nullable restore
#line 35 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 1272, Model.Result.Row, 1272, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n            <input type=\"hidden\" class=\"form-control\" name=\"ColB\"");
                BeginWriteAttribute("value", " value=\"", 1360, "\"", 1387, 1);
#nullable restore
#line 36 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 1368, Model.Result.Col, 1368, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n            <input type=\"hidden\" class=\"form-control\" name=\"Type\" value=\"OpSum\" >\n");
#nullable restore
#line 38 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
             foreach (List<double> row in Model.Result)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                 foreach (double val in row)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"hidden\" class=\"form-control\" name=\"Result\"");
                BeginWriteAttribute("value", " value=\"", 1681, "\"", 1693, 1);
#nullable restore
#line 42 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 1689, val, 1689, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n");
#nullable restore
#line 43 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" class=\"btn btn-secondary\">Sum</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "496e1c64a66d99fc0d072b2f748087260b77d37611720", async() => {
                WriteLiteral("\n                <input type=\"hidden\" class=\"form-control\" name=\"RowA\"");
                BeginWriteAttribute("value", " value=\"", 1964, "\"", 1991, 1);
#nullable restore
#line 48 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 1972, Model.Result.Row, 1972, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n                <input type=\"hidden\" class=\"form-control\" name=\"ColA\"");
                BeginWriteAttribute("value", " value=\"", 2064, "\"", 2091, 1);
#nullable restore
#line 49 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 2072, Model.Result.Col, 2072, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n                <input type=\"hidden\" class=\"form-control\" name=\"RowB\"");
                BeginWriteAttribute("value", " value=\"", 2164, "\"", 2191, 1);
#nullable restore
#line 50 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 2172, Model.Result.Row, 2172, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n                <input type=\"hidden\" class=\"form-control\" name=\"ColB\"");
                BeginWriteAttribute("value", " value=\"", 2264, "\"", 2291, 1);
#nullable restore
#line 51 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 2272, Model.Result.Col, 2272, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n                <input type=\"hidden\" class=\"form-control\" name=\"Type\" value=\"OpSub\" >\n");
#nullable restore
#line 53 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                 foreach (List<double> row in Model.Result)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                     foreach (double val in row)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\" class=\"form-control\" name=\"Result\"");
                BeginWriteAttribute("value", " value=\"", 2609, "\"", 2621, 1);
#nullable restore
#line 57 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
WriteAttributeValue("", 2617, val, 2617, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n");
#nullable restore
#line 58 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/home/josealvarez/Documents/Engineering/Projects/DOTNET/Matrices/Views/Home/Result.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"btn btn-secondary\">Substraction</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </button>\n        <button class=\"btn btn-secondary\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 2846, "\"", 2853, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white\">Transpose</a>\n        </button>\n        <button class=\"btn btn-secondary\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 2963, "\"", 2970, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white\">Inverse</a>\n        </button>\n        <button class=\"btn btn-secondary\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 3078, "\"", 3085, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white\">Solution</a>\n        </button>\n    </div>\n</div>\n\n\n\n\n");
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
