#pragma checksum "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5184f585c1940302aa52c54ac30df63643881df0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_ArtistView), @"mvc.1.0.view", @"/Views/Artist/ArtistView.cshtml")]
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
#line 1 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\_ViewImports.cshtml"
using ChinookMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\_ViewImports.cshtml"
using ChinookMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5184f585c1940302aa52c54ac30df63643881df0", @"/Views/Artist/ArtistView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4e172a66a2c409f13199468497d829b5703e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Artist_ArtistView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChinookMVC.Models.ArtistViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistView.cshtml"
  
    ViewData["Title"] = "Artists";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Artist Management</h2>
<table class=""table table-condensed table-bordered table-striped"">
  <thead class=""thead-inverse"">
    <tr>      
      <th>Artist Name</th>
      <th><a class=""btn btn-primary"" href=""CreateArtist"">Add Artist</a></th>      
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 15 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistView.cshtml"
   foreach (var item in @Model.Artists)

    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>        \r\n        <td>");
#nullable restore
#line 19 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistView.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                        \r\n        <td>");
#nullable restore
#line 20 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistView.cshtml"
       Write(Html.ActionLink("Edit", "ArtistEdit", new { id=item.ArtistID }, new { @class = "btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>        \r\n      </tr>\r\n");
#nullable restore
#line 22 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChinookMVC.Models.ArtistViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
