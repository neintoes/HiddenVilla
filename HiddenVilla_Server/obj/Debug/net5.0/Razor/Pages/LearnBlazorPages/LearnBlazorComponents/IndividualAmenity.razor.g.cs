#pragma checksum "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1630952d165912517f26ee246c37cc0fd170e782"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazorPages.LearnBlazorComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazorPages.LearnBlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    public partial class IndividualAmenity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
               (args)=> InvokeAmenityChangeCallback(args, amenity.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "bg-light border p-2 col-5");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, "Amenity - ");
#nullable restore
#line 2 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
__builder.AddContent(5, amenity.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
#nullable restore
#line 3 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
__builder.AddContent(7, amenity.Name);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<br>\r\n    ");
#nullable restore
#line 4 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
__builder.AddContent(9, amenity.Value);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<br>\r\n    These are the render fragments from the amenity -<br>\r\n    ");
#nullable restore
#line 6 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
__builder.AddContent(11, firstFragment);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<br>\r\n    ");
#nullable restore
#line 7 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
__builder.AddContent(13, secondFragment);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\IndividualAmenity.razor"
      
    [Parameter]
    public BlazorAmenities amenity { get; set; }
    [Parameter]
    public EventCallback<string> AmenityChangeCallback { get; set; }
    [Parameter]
    public RenderFragment firstFragment { get; set; }
    [Parameter]
    public RenderFragment secondFragment { get; set; }

    protected async Task InvokeAmenityChangeCallback(EventArgs e, string inputAmenity)
    {
        await AmenityChangeCallback.InvokeAsync(inputAmenity);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
