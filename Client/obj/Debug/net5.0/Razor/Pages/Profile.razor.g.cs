#pragma checksum "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aafe3d674d2db5f29355799088b30ae709dc811f"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using ChatApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using ChatApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\С#\Deploy\ChatApp\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
using ChatApp.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"white-text\"><b>Profile</b></h2>\r\n<hr class=\"white-horizontal-line\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-4 col-md-6 col-sm-8");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 15 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                   _profileViewModel.ProfilePicDataUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", "User Profile Picture");
            __builder.AddAttribute(8, "class", "img-thumbnail");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, " <br> <br>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(10);
            __builder.AddAttribute(11, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 16 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                              OnInputFileChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "style", "margin-bottom: 1rem;");
            __builder.AddAttribute(13, "class", "white-text");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-lg-8 col-md-6 col-sm-12");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-control dark-theme-textbox");
            __builder.AddAttribute(20, "placeholder", "first name");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                                        _profileViewModel.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.FirstName = __value, _profileViewModel.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        <br>\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control dark-theme-textbox");
            __builder.AddAttribute(27, "placeholder", "last name");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                                        _profileViewModel.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.LastName = __value, _profileViewModel.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        <br>\r\n        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control dark-theme-textbox");
            __builder.AddAttribute(34, "placeholder", "email address");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                                        _profileViewModel.EmailAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.EmailAddress = __value, _profileViewModel.EmailAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        <br>\r\n        ");
            __builder.OpenElement(38, "textarea");
            __builder.AddAttribute(39, "class", "form-control dark-theme-textbox");
            __builder.AddAttribute(40, "placeholder", "about me");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                         _profileViewModel.AboutMe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.AboutMe = __value, _profileViewModel.AboutMe));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        <br>\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
                                                  _profileViewModel.UpdateProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\С#\Deploy\ChatApp\Client\Pages\Profile.razor"
       

    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            var claim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);
            _profileViewModel.UserId = Convert.ToInt64(claim?.Value);
            try
            {
                await _profileViewModel.GetProfile();

                if (_profileViewModel.ProfilePicDataUrl == null)
                {
                    _profileViewModel.ProfilePicDataUrl = "/img/profile_pic.jpg";
                    Console.WriteLine(_profileViewModel.ProfilePicDataUrl);
                }
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                if (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await _httpClient.GetAsync("user/logoutuser");
                    _navigationManager.NavigateTo("/", true);
                }
            }
        }
        else
        {
            _navigationManager.NavigateTo("/");
        }
    }
    private async Task OnInputFileChanged(InputFileChangeEventArgs inputFileChangeEvent)
    {
        //get the file
        var file = inputFileChangeEvent.File;

        //read that file in a byte array
        var buffer = new byte[file.Size];
        await file.OpenReadStream(1512000).ReadAsync(buffer);

        //convert byte array to base 64 string
        _profileViewModel.ProfilePicDataUrl = $"data:image/png;base64,{Convert.ToBase64String(buffer)}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProfileViewModel _profileViewModel { get; set; }
    }
}
#pragma warning restore 1591