#pragma checksum "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436a2c025721f471028a4b04598a615d665dedb8"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazorPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindProp")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"bg-light border p-2\">\r\n    First Hotel Room\r\n</h2>\r\nRoom: ");
#nullable restore
#line 11 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(1, newRoom.RoomName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n<br>\r\nPrice: ");
#nullable restore
#line 13 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(3, newRoom.Price);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "\r\n<br>\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "checked", 
#nullable restore
#line 15 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                                                                  newRoom.IsActive

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                                     newRoom.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newRoom.IsActive = __value, newRoom.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\nAvailability:\r\n<br>\r\n");
            __builder.OpenElement(11, "span");
#nullable restore
#line 18 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(12, newRoom.IsActive?"This room is available for booking.":"This room is unavailable for booking right now.");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
               selectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedRoomProp = __value, selectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 22 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
     foreach(var prop in newRoom.RoomProps)
    { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 24 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                        prop.Name

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 24 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(19, prop.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, "The room property selected is: ");
#nullable restore
#line 27 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(23, selectedRoomProp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table table-dark");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 32 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
         foreach(var room in allRooms)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "th");
            __builder.AddAttribute(30, "scope", "row");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                                                                room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                                                    room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                 foreach(var prop in room.RoomProps)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "td");
#nullable restore
#line 39 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(42, prop.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, ": ");
#nullable restore
#line 39 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(44, prop.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.OpenElement(46, "p");
#nullable restore
#line 47 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
     foreach(var room in allRooms)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "span");
            __builder.AddContent(48, "The ");
#nullable restore
#line 49 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(49, room.RoomName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, " is available for ??");
#nullable restore
#line 49 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
__builder.AddContent(51, room.Price);

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, " per night.");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        <br>");
#nullable restore
#line 51 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazorPages\BindProp.razor"
      
    string selectedRoomProp = "";
    List<BlazorRoom> allRooms = new List<BlazorRoom>();
    BlazorRoom newRoom = new BlazorRoom()
    {
        Id = 1,
        RoomName = "Hudson Suite",
        Price = 320,
        IsActive = false,
        RoomProps = new List<BlazorRoomProp>()
    {
            new BlazorRoomProp{Id = 1, Name = "Sq Ft", Value = "100"},
            new BlazorRoomProp{Id = 2, Name = "Occupancy", Value= "3"}
        }
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        allRooms.Add(new BlazorRoom()
        {
            Id = 1,
            RoomName = "Hudson Suite",
            Price = 320,
            IsActive = false,
            RoomProps = new List<BlazorRoomProp>()
            {
                new BlazorRoomProp{Id = 1, Name = "Sq Ft", Value = "100"},
                new BlazorRoomProp{Id = 2, Name = "Occupancy", Value= "3"}
            }
        });

        allRooms.Add(new BlazorRoom()
        {
            Id = 1,
            RoomName = "Jefferson Suite",
            Price = 380,
            IsActive = false,
            RoomProps = new List<BlazorRoomProp>()
            {
                new BlazorRoomProp{Id = 1, Name = "Sq Ft", Value = "180"},
                new BlazorRoomProp{Id = 2, Name = "Occupancy", Value= "4"}
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
