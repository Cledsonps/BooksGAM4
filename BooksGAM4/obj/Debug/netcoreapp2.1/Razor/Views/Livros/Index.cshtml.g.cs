#pragma checksum "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b9cce537f8a1ebdfe463268ed24ea3d841bc380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livros_Index), @"mvc.1.0.view", @"/Views/Livros/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livros/Index.cshtml", typeof(AspNetCore.Views_Livros_Index))]
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
#line 1 "C:\GIT\BooksGAM4\BooksGAM4\Views\_ViewImports.cshtml"
using BooksGAM4;

#line default
#line hidden
#line 2 "C:\GIT\BooksGAM4\BooksGAM4\Views\_ViewImports.cshtml"
using BooksGAM4.Models;

#line default
#line hidden
#line 3 "C:\GIT\BooksGAM4\BooksGAM4\Views\_ViewImports.cshtml"
using BooksGAM4.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9cce537f8a1ebdfe463268ed24ea3d841bc380", @"/Views/Livros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a556a6194eacec4c467f3d9dd205bc1c0d122379", @"/Views/_ViewImports.cshtml")]
    public class Views_Livros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BooksGAM4.Models.Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detalhar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Deletar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
  
    ViewData["Title"] = "Gestão de Livros";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(164, 121, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css\" />\r\n");
                EndContext();
            }
            );
            BeginContext(288, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(291, 39, false);
#line 12 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
Write(await Html.PartialAsync("_LayoutLivro"));

#line default
#line hidden
            EndContext();
            BeginContext(330, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(352, 1381, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js""></script>

    <script type=""text/javascript"">
            $(document).ready(function () {
                $('#tbLivros').DataTable(
                    {
                        ""bJQueryUI"": true,
                        ""oLanguage"":
                        {
                            ""sProcessing"": ""Processando..."",
                            ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                            ""sZeroRecords"": ""N?o foram encontrados resultados"",
                            ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
                            ""sInfoEmpty"": ""Mostrando de 0 até 0 de 0 registros"",
                            ""sInfoFiltered"": """",
                            ""sInfoPostFix"": """",
                            ""sSearch"": ""Buscar:"",
                            ""sUrl"": """",
                            ""oPaginate"":
                         ");
                WriteLiteral(@"   {
                                ""sFirst"": ""Primeiro"",
                                ""sPrevious"": ""Anterior"",
                                ""sNext"": ""Seguinte"",
                                ""sLast"": ""último""
                            }
                        }
                    }
                );
            });
    </script>
");
                EndContext();
            }
            );
            BeginContext(1736, 186, true);
            WriteLiteral("\r\n<table id=\"tbLivros\" class=\"table display\" style=\"width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Capa\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1923, 42, false);
#line 54 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2021, 41, false);
#line 57 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 121, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Data Public\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2184, 41, false);
#line 63 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 153, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"font-weight:normal; font-size:12px\">Edita | Detalha | Deleta</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 69 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2427, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2491, "\"", 2516, 1);
#line 73 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
WriteAttributeValue("", 2497, item.ImagemCapaUrl, 2497, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2517, 122, true);
            WriteLiteral(" style=\"width: 60px; height: 82px;\" />\r\n                </td>\r\n                <td class=\"ellipsis\">\r\n                    ");
            EndContext();
            BeginContext(2640, 41, false);
#line 76 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(2681, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2749, 40, false);
#line 79 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Autor));

#line default
#line hidden
            EndContext();
            BeginContext(2789, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"ellipsisAutor\">\r\n                    ");
            EndContext();
            BeginContext(2879, 42, false);
#line 82 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
               Write(item.DataPublicacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2921, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2989, 24, false);
#line 85 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
               Write(item.Preco.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 116, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group\">\r\n                        ");
            EndContext();
            BeginContext(3129, 833, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d85d36c90866461e929b9f5da5b3d153", async() => {
                BeginContext(3215, 743, true);
                WriteLiteral(@"
                            <svg xmlns=""~/images/icons/pencil-square.svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16"">
                                <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z""></path>
                                <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z""></path>
                            </svg>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3962, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3988, 787, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3ad3cf7e5a54b45acd75fe563bb6bd8", async() => {
                BeginContext(4074, 697, true);
                WriteLiteral(@"
                            <svg xmlns=""~/images/icons/card-text.svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16"">
                                <path d=""M14.5 3a.5.5 0 0 1 .5.5v9a.5.5 0 0 1-.5.5h-13a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5h13zm-13-1A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h13a1.5 1.5 0 0 0 1.5-1.5v-9A1.5 1.5 0 0 0 14.5 2h-13z""></path>
                                <path d=""M3 5.5a.5.5 0 0 1 .5-.5h9a.5.5 0 0 1 0 1h-9a.5.5 0 0 1-.5-.5zM3 8a.5.5 0 0 1 .5-.5h9a.5.5 0 0 1 0 1h-9A.5.5 0 0 1 3 8zm0 2.5a.5.5 0 0 1 .5-.5h6a.5.5 0 0 1 0 1h-6a.5.5 0 0 1-.5-.5z""></path>
                            </svg>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4775, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4801, 828, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd5deef92f004c2abbcc114d836441d9", async() => {
                BeginContext(4887, 738, true);
                WriteLiteral(@"
                            <svg xmlns=""~/images/icons/trash.svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16"">
                                <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z""></path>
                                <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z""></path>
                            </svg>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5629, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 110 "C:\GIT\BooksGAM4\BooksGAM4\Views\Livros\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5712, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BooksGAM4.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
