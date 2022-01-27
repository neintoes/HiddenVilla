// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelRoom
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
#line 3 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Business.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Business.Repository.IRepoosiory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{HotelRoomId:int}")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\antho\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       
    [Parameter]
    public int? HotelRoomId { get; set; }

    private string title = "";
    private HotelRoomDTO roomModel = new HotelRoomDTO();
    //Not going to instantiate a new copy of HotelRoomImage until the file upload method.
    private HotelRoomImageDTO imageDTO = new HotelRoomImageDTO();

    string preExistingHotelName;
    List<string> preExistingImageUrls = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        if(HotelRoomId == null)
        {
            //method is create
            title = "Create";
        }
        else
        {
            //method is update
            title = "Edit";
            roomModel = await hotelRoomRepository.GetHotelRoom(HotelRoomId.Value);
            preExistingHotelName = roomModel.Name;
            roomModel.ImageUrls = new List<string>();
            if(roomModel.Images != null)
            {
                foreach(HotelRoomImageDTO image in roomModel.Images)
                {
                    roomModel.ImageUrls.Add(image.ImageUrl);
                    preExistingImageUrls.Add(image.ImageUrl);
                }
            }
        }
    }

    private async Task HandleHotelRoomUpsert()
    {
        try
        {
            //If the name of the hotel has been changed, then it will be checked to see if it is unique.
            //If it is not unique then the method will return.
            if(roomModel.Name != preExistingHotelName)
            {
                var isRoomUnique = await hotelRoomRepository.IsHotelUnique(roomModel.Name);
                if (isRoomUnique != null)
                {
                    await ErrorPress("Uh Oh! It seems that Hotel room name is already taken.", "Please try naming it something else.");
                    return;
                }
            }

            if(HotelRoomId == null)
            {
                //Handling create form input
                Console.WriteLine("Submitting form.");

                var createdRoom = await hotelRoomRepository.CreateHotelRoom(roomModel);
                await AddHotelRoomImage(createdRoom);
                await SuccessPress("The newly created hotel room Id is: " + createdRoom.HotelRoomId);
                await SuccessPress($"{roomModel.Name} has been successfully entered into the system.");
            }
            else
            {
                //Handling update form input
                var updatedRoom = await hotelRoomRepository.UpdateHotelRoom(HotelRoomId.Value, roomModel);
                await AddHotelRoomImage(updatedRoom);
                await SuccessPress($"{roomModel.Name} has been successfully updated in our system.");
            }
            NavigationManager.NavigateTo("hotel-room");

        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
        //Check to see if the room name is already taken, and prompt the user if so. 

    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        try
        {
            var images = new List<string>();
            if(e.FileCount > 0)
            {
                foreach(var file in e.GetMultipleFiles())
                {
                    FileInfo fileInfo = new FileInfo(file.Name);
                    if(fileInfo.Extension.ToLower() == ".jpg" ||
                    fileInfo.Extension.ToLower() == ".png" ||
                    fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        //Upload the image file and add the filePath to the local images list.
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        //Image is of incorrect file extension, prompt user to upload another file.
                        await ErrorPress("Uh Oh! This file is of the incorrect type.", "Please upload a file ending in 'jpg','jpeg' or 'png'.");
                        return;
                    }
                }
                if (images.Any())
                //if any images have been uploaded..
                {
                    if(roomModel.ImageUrls != null && roomModel.ImageUrls.Any())
                    //if there are already image URLS contained in the HotelRoomDTO...
                    {
                        roomModel.ImageUrls.AddRange(images);
                    }
                    else
                    //else if there are none.
                    {
                        roomModel.ImageUrls = new List<string>();
                        roomModel.ImageUrls.AddRange(images);
                    }
                }
            }
        } 
        catch(Exception ex)
        {
            await ErrorPress(ex.ToString(), "failure");
            new Exception(ex.ToString());
        }
    }

    private async Task AddHotelRoomImage(HotelRoomDTO createdRoom)
    {
        {
            if (title == "Create")
            {
                foreach (var imageUrl in roomModel.ImageUrls)
                {
                    imageDTO = new HotelRoomImageDTO()
                    {
                        HotelRoomId = createdRoom.HotelRoomId,
                        ImageUrl = imageUrl
                    };
                    await hotelRoomImageRepository.CreateHotelRoomImage(imageDTO);
                }
            }
            else
            {
                foreach (var imageUrl in roomModel.ImageUrls)
                {
                    if (roomModel.Images.Where(x => x.ImageUrl == imageUrl).Count() == 0)
                    {

                        imageDTO = new HotelRoomImageDTO()
                        {
                            HotelRoomId = createdRoom.HotelRoomId,
                            ImageUrl = imageUrl
                        };
                        await hotelRoomImageRepository.CreateHotelRoomImage(imageDTO);
                    }
                }   
            }
        }
    }

    //JS button alerts.
    private async Task ErrorPress(string inputMessage, string inputMessageTwo)
    {
        await JSRuntime.SwalError(inputMessage, inputMessageTwo);
    }

    private async Task SuccessPress(string inputMessage)
    {
        await JSRuntime.ToastrSuccess(inputMessage);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomImageRepository hotelRoomImageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository hotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
