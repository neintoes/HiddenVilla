#pragma checksum "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\LifeCycleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6be6d2e3c792a8043d3cfc8d07fa695452548923"
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
    public partial class LifeCycleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\LifeCycleComponent.razor"
     foreach(var item in EventType)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\LifeCycleComponent.razor"
__builder.AddContent(0, item);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<br>");
#nullable restore
#line 4 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\LifeCycleComponent.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\LearnBlazorComponents\LifeCycleComponent.razor"
       
    List<string> EventType = new List<string>();

    protected override void OnInitialized()
    {
        EventType.Add("OnInitialized is called");
    }
    protected override async Task OnInitializedAsync()
    {
        EventType.Add("OnInitializedAsync has been called.");
        await Task.Delay(1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
