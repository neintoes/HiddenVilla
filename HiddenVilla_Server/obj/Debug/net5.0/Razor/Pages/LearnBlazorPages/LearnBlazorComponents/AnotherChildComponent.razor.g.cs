#pragma checksum "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8332108b80a62fc209e7aaf5348fae6d1e139d83"
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
    public partial class AnotherChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-primary pt-3");
            __builder.AddMarkupContent(2, "<h4>This is another child component</h4>\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "COmponent: ");
#nullable restore
#line 3 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor"
__builder.AddContent(5, componentTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "<br>\r\n\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "id", "thisInput");
            __builder.AddMultipleAttributes(10, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor"
                                                    inputDictionary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<p>Checking the contents of the dictionary:</p>");
#nullable restore
#line 7 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor"
     if (inputDictionary.TryGetValue("placeholder",out result))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor"
__builder.AddContent(13, result.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor"
                          ;
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\AnotherChildComponent.razor"
       
    [Parameter]
    public string componentTitle { get; set; }
    public object result = new object();

    [Parameter(CaptureUnmatchedValues =true)]
    public Dictionary<string, object> inputDictionary { get; set; } = new Dictionary<string, object>();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
