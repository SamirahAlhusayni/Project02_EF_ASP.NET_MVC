#pragma checksum "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432d070bc56113b95b2201140bb18e708b779f66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paintings_Details), @"mvc.1.0.view", @"/Views/Paintings/Details.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\_ViewImports.cshtml"
using ArtGallery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\_ViewImports.cshtml"
using ArtGallery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432d070bc56113b95b2201140bb18e708b779f66", @"/Views/Paintings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59bfea3feaf772ebbdfb9372a7c5483608d01f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Paintings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml"
  
    var Artists = (ArtistModel)ViewData["Artists"];
    var Paintings = (PaintingModel)ViewData["Paintings"];
    var Galleries = (GalleryModel)ViewData["Galleries"]; 
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mb-5\" style=\"margin-bottom:20px; margin-top:20px; text-align:center\">\r\n    <div class=\"card mb-12\">\r\n        <h3 class=\"card-header\">  ");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml"
                             Write(Paintings.PntName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <div class=\"card-body\">\r\n           \r\n            <div class=\"row\" style=\"align-content: center\">\r\n                <div class=\"col d-flex justify-content-center align-items-center\">\r\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 598, "\"", 621, 1);
#nullable restore
#line 17 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml"
WriteAttributeValue("", 604, Paintings.PntImg, 604, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"400\" width=\"200\">\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <p>\r\n                    ");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml"
               Write(Paintings.PntOverview);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    Negotiated in ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml"
                             Write(Galleries.GlrName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\ArtGallery\ArtGallery\Views\Paintings\Details.cshtml"
                                                   Write(Galleries.GlrLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
                </p>
            </div>
        </div>

        <div class=""card-body"">
            <div class=""card-body"">
                <a href=""/Paintings"" class=""btn btn-dark"">Back</a>
            </div>

        </div>
    </div>
</div>




");
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