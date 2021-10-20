#pragma checksum "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "473c040ac44cb582a2f8b95cbf392a268dbebf47"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatApp.Client.Pages.Authentication
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
#line 2 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
using ChatApp.Client.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"white-text\"><b>Login</b></h2>\r\n<hr class=\"white-horizontal-line\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-xl-6 col-md-8 col-12");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control dark-theme-textbox");
            __builder.AddAttribute(6, "placeholder", "email address");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
                              _loginViewModel.EmailAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _loginViewModel.EmailAddress = __value, _loginViewModel.EmailAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xl-6 col-md-8 col-12");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "password");
            __builder.AddAttribute(14, "class", "form-control dark-theme-textbox");
            __builder.AddAttribute(15, "placeholder", "password");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
                                  _loginViewModel.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _loginViewModel.Password = __value, _loginViewModel.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-xl-6 col-md-8 col-12 row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-xl-2 col-lg-2 col-md-6 col-sm-3 col-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenSwitch>(23);
            __builder.AddAttribute(24, "style", "margin-bottom: 20px;");
            __builder.AddAttribute(25, "Name", "RememberMe");
            __builder.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
                                                                 _loginViewModel.RememberMe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _loginViewModel.RememberMe = __value, _loginViewModel.RememberMe))));
            __builder.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => _loginViewModel.RememberMe));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.AddMarkupContent(30, "<div class=\"col-xl-5 col-lg-5 col-md-6 col-sm-9 col-9\"><label style=\"margin-top: 20px; font-weight: bold; color: #0366d6;\" class=\"white-text\">Remember Me</label></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-xl-6 col-md-8 col-12 row");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-xl-2 col-lg-2 col-md-6 col-sm-3 col-3");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
                                                 LoginUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.AddMarkupContent(41, "<div class=\"col-xl-5 col-lg-5 col-md-6 col-sm-9 col-9\"><a style=\"font-weight: bold;\" href=\"/createaccount\">Create an account</a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n<hr class=\"white-horizontal-line\">\r\n<br>\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-xl-6 col-md-8 col-12");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "btn btn-block btn-social btn-facebook");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
                                                               FacebookSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "href", "");
            __builder.AddMarkupContent(49, "<span class=\"fa fa-facebook\"></span> ");
            __builder.AddMarkupContent(50, "<b>Sign in with Facebook</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n<br>\r\n");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-xl-6 col-md-8 col-12");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "class", "btn btn-block btn-social btn-google");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
                                                             GoogleSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "href", "");
            __builder.AddMarkupContent(58, "<span class=\"fa fa-google\"></span> ");
            __builder.AddMarkupContent(59, "<b>Sign in with Google</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n<hr class=\"white-horizontal-line\">\r\n");
            __builder.AddMarkupContent(61, @"<div class=""col-12 white-text""><p style=""font-size: larger;"" class=""white-text"">Or you can login with Man Of Your Dream' crendetials</p>
    <p style=""font-size: large;"" class=""white-text""><b>email address :</b> manOfYourDream@gmail.com <br> <b>password : </b>manOfYourDream
    </p></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\С#\Deploy\ChatApp\Client\Pages\Authentication\Login.razor"
       

    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
            _navigationManager.NavigateTo("/profile", true);
        }
    }

    public async Task LoginUser()
    {
        await _loginViewModel.LoginUser();
        _navigationManager.NavigateTo("/profile", true);
    }

    private void FacebookSignIn()
    {
        _navigationManager.NavigateTo($"user/FacebookSignIn?isPersistent={_loginViewModel.RememberMe}", true);
    }

    private void GoogleSignIn()
    {
        _navigationManager.NavigateTo($"user/GoogleSignIn?isPersistent={_loginViewModel.RememberMe}", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginViewModel _loginViewModel { get; set; }
    }
}
#pragma warning restore 1591
