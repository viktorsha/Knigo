#pragma checksum "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bba1ee2fbeb2629868d449c1daa962b2bb808f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Books_Views_Books_SearchResult), @"mvc.1.0.view", @"/Areas/Books/Views/Books/SearchResult.cshtml")]
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
#line 1 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\_ViewImports.cshtml"
using Knigo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62bba1ee2fbeb2629868d449c1daa962b2bb808f", @"/Areas/Books/Views/Books/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5a52d9a34a8bacb9c6856a3c6ffc2e817c56dd4", @"/Areas/Books/Views/_ViewImports.cshtml")]
    public class Areas_Books_Views_Books_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Каталог книг</h2>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        \r\n    </div>\r\n    <div class=\"album py-5 bg-light\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3\">\r\n\r\n                \r\n");
#nullable restore
#line 13 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                     foreach (var book in Model.allBooks)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 406, "\"", 432, 1);
#nullable restore
#line 17 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
WriteAttributeValue("", 412, book.Img.ToString(), 412, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Обложка книги\" style=\"border-radius:50%; width:200px; height:200px\">                            \r\n                            <h3>\r\n\r\n                                \"");
#nullable restore
#line 20 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                            Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                ");
#nullable restore
#line 21 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                           Write(book.Author.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h3>\r\n                            <h4>Оценка: ");
#nullable restore
#line 23 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                                   Write(book.Rank.StarsAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" звезд</h4>\r\n                            <h4>Статус прочтения: ");
#nullable restore
#line 24 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                                             Write(book.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h5 class=\"card-title pricing-card-title\">");
#nullable restore
#line 25 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                                                                 Write(book.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" р.<small class=\"text-muted fw-light\"></small></h5>\r\n                            <p><a class=\"btn btn-secondary\"");
            BeginWriteAttribute("href", " href=\"", 1070, "\"", 1103, 2);
            WriteAttributeValue("", 1077, "/Books/Books/List/", 1077, 18, true);
#nullable restore
#line 26 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
WriteAttributeValue("", 1095, book.Id, 1095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Подробнее »</a></p>\r\n                        </div>\r\n");
#nullable restore
#line 28 "H:\Viktoria\University\3 course\6 semester\CourseWork\Knigo — копия\Knigo\Areas\Books\Views\Books\SearchResult.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
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
