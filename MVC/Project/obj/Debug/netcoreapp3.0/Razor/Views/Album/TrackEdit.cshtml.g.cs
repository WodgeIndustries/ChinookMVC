#pragma checksum "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3dad6c7083603070b9a906082f3861c3a71ee06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_TrackEdit), @"mvc.1.0.view", @"/Views/Album/TrackEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3dad6c7083603070b9a906082f3861c3a71ee06", @"/Views/Album/TrackEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4e172a66a2c409f13199468497d829b5703e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_TrackEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChinookProject.Shared.Track>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
  
    ViewData["Title"] = "Create Track";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Track</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">        \r\n        <h4>Track Details</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 13 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n            <div class=\"form-group\">\r\n                <p>");
#nullable restore
#line 15 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
              Write(Html.LabelFor(model => model.TrackID));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 15 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
                                                      Write(ViewBag.TrackID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 16 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
              Write(Html.LabelFor(model => model.AlbumID));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 16 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
                                                      Write(ViewBag.AlbumID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
#nullable restore
#line 17 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 19 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>            \r\n                ");
#nullable restore
#line 22 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
           Write(Html.LabelFor(model => model.MediaTypeID,htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 24 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.DropDownListFor(model => model.MediaTypeID, new SelectList(ViewBag.Media_TypeList, "MediaTypeID","Name"), "-Select Media Type", htmlAttributes: new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.MediaTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n                </div>\r\n                ");
#nullable restore
#line 27 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
           Write(Html.LabelFor(model => model.GenreID,htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 29 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.DropDownListFor(model => model.GenreID, new SelectList(ViewBag.GenreList, "GenreID","Name"), "-Select Track Genre", htmlAttributes: new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.GenreID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n                </div>              \r\n                ");
#nullable restore
#line 32 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
           Write(Html.LabelFor(model => model.Milliseconds,htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 34 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.EditorFor(model => model.Milliseconds, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Milliseconds, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 37 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
           Write(Html.LabelFor(model => model.UnitPrice, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 39 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.EditorFor(model => model.UnitPrice, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.UnitPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>     
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Update"" class=""btn btn-primary"" />
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 49 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 52 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\TrackEdit.cshtml"
   Write(Html.ActionLink("Cancel", "AlbumDetail", new { id=@ViewBag.albumID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChinookProject.Shared.Track> Html { get; private set; }
    }
}
#pragma warning restore 1591