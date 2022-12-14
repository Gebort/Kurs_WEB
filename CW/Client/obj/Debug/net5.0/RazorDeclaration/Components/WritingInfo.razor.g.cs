// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\WritingInfo.razor"
using CW.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\WritingInfo.razor"
using CW.Client.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\WritingInfo.razor"
using TabBlazor.Components.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\WritingInfo.razor"
using TabBlazor.Services;

#line default
#line hidden
#nullable disable
    public partial class WritingInfo : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\Projects\VisualStudio\Ficbook\CW\Client\Components\WritingInfo.razor"
       

    [Parameter]
    public Writing Writing { get; set; } = null!;

    [Parameter]
    public Action<Writing> OnDelete { get; set; }

    [Parameter]
    public bool IsEditable { get; set; } = false;

    private void OnEditWritingClick() {
        NavManager.NavigateTo("/edit/" + Writing.Id.ToString());
    }

    private async Task OnDeleteWritingClick() {
        var responce = await Http.DeleteAsync("/user/deletewriting?id=" + Writing.Id.ToString());
        OnDelete.Invoke(Writing);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
