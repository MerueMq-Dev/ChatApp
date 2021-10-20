#pragma checksum "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab54e8c51290c62aa8e5976b8e56be611ab55f01"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatApp.Client.Shared
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
#line 1 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
using ChatApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-xf6wwz41am");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-xf6wwz41am");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<ChatApp.Client.Shared.NavMenu>(8);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(10);
            __builder.AddAttribute(11, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 18 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
                              ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
                             3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 20 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
                              IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(15, "SuccessIcon", "fa fa-thumbs-up");
            __builder.AddAttribute(16, "ErrorIcon", "fa fa-bug");
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "main");
            __builder.AddAttribute(20, "b-xf6wwz41am");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(21);
            __builder.AddAttribute(22, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "top-row px-4");
                __builder2.AddAttribute(25, "b-xf6wwz41am");
                __builder2.OpenElement(26, "h4");
                __builder2.AddAttribute(27, "b-xf6wwz41am");
                __builder2.OpenElement(28, "b");
                __builder2.AddAttribute(29, "b-xf6wwz41am");
                __builder2.AddContent(30, "Hello, ");
                __builder2.AddContent(31, 
#nullable restore
#line 29 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, " &nbsp; &nbsp;\r\n                    ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "class", "btn btn-danger");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
                                                             LogoutUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "b-xf6wwz41am");
                __builder2.AddContent(37, "Logout");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "content px-4");
            __builder.AddAttribute(41, "b-xf6wwz41am");
            __builder.AddContent(42, 
#nullable restore
#line 35 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\С#\Deploy\ChatApp\Client\Shared\MainLayout.razor"
      

    protected override async Task OnInitializedAsync()
    {
        User currentUser = await _httpClient.GetFromJsonAsync<User>("user/getcurrentuser");

        if (currentUser != null)
        {
            var themeName = currentUser.DarkTheme == 1 ? "dark" : "light";

            var module = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./js/site.js");
            await module.InvokeVoidAsync("setTheme", themeName);
        }

        await base.OnInitializedAsync();
    }

    private async Task LogoutUser()
    {
        await _httpClient.GetAsync("user/logoutuser");
        _navigationManager.NavigateTo("/", true);
    }

    private void LoginUser()
    {
        _navigationManager.NavigateTo("/", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
