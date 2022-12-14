#pragma checksum "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\LoginChecker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c92f64b9ec19b734076428c3dea58338753f251"
// <auto-generated/>
#pragma warning disable 1591
namespace CW.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using CW.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using CW.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\VisualStudio\Ficbook\CW\Client\_Imports.razor"
using TabBlazor;

#line default
#line hidden
#nullable disable
    public partial class LoginChecker : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\LoginChecker.razor"
                  LogUsername

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Log username");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
#nullable restore
#line 3 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\LoginChecker.razor"
__builder.AddContent(5, authMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\LoginChecker.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private string authMessage;

    private async Task LogUsername()
    {
        var authState = await authenticationStateTask;
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            authMessage = $"{user.Identity.Name} is authenticated.";
        }
        else
        {
            authMessage = "The user is NOT authenticated.";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
