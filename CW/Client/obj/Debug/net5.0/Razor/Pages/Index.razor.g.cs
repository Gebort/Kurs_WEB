#pragma checksum "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7aa22674bcee3230d82fa521869861d1545b11b"
// <auto-generated/>
#pragma warning disable 1591
namespace CW.Client.Pages
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
#line 2 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
using CW.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
using CW.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
using TabBlazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "my-lg-2");
            __builder.OpenComponent<global::TabBlazor.Card>(2);
            __builder.AddAttribute(3, "class", "py-2 px-3 mx-0 mx-lg-2");
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<p class=\"header text-center h1 text-success\">Добро пожаловать в Книгу Фанфиков ДВГУПС!</p>\r\n        ");
                __builder2.AddMarkupContent(6, "<p class=\"text-center\">Здесь вы найдете истории от студентов и про студентов нашего лучшего на свете университета</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "my-2");
            __builder.OpenComponent<global::TabBlazor.Card>(10);
            __builder.AddAttribute(11, "class", "py-2 px-3 mx-0 mx-lg-2");
            __builder.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "<h3>Поиск по работам</h3>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(14);
                __builder2.AddAttribute(15, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 17 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
                         this

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
                                              OnSearchSubmitAsync

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "row");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-6 col-lg-6");
                    __builder3.AddMarkupContent(24, "<label class=\"form-label\">Название</label>\r\n                    ");
                    __builder3.OpenElement(25, "input");
                    __builder3.AddAttribute(26, "type", "text");
                    __builder3.AddAttribute(27, "class", "form-control mb-2");
                    __builder3.AddAttribute(28, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
                                                                              TitlePart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TitlePart = __value, TitlePart));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n                ");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "col-md-6 col-lg-6");
                    __builder3.AddMarkupContent(33, "<label class=\"form-label\">Жанры</label>\r\n                    ");
                    __builder3.OpenElement(34, "input");
                    __builder3.AddAttribute(35, "type", "text");
                    __builder3.AddAttribute(36, "class", "form-control mb-2");
                    __builder3.AddAttribute(37, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
                                                                              Genres

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Genres = __value, Genres));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.AddMarkupContent(40, "<div class=\"d-flex justify-content-center\"><input type=\"submit\" class=\"form-control btn btn-light my-2 py-2\" style=\"font-size: 18px; color: #232323\" value=\"Найти\"></div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 35 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
 if (searchResults != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "my-2");
            __builder.OpenComponent<global::TabBlazor.Card>(43);
            __builder.AddAttribute(44, "class", "py-3 px-3 mx-0 mx-lg-2");
            __builder.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "<p class=\"h3 mb-3 mx-2\">Результаты поиска</p>");
#nullable restore
#line 39 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
             foreach (var writing in searchResults) {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::CW.Client.Components.WritingInfo>(47);
                __builder2.AddAttribute(48, "Writing", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::CW.Shared.Model.Writing>(
#nullable restore
#line 40 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
                                      writing

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 41 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Projects\VisualStudio\Ficbook\CW\Client\Pages\Index.razor"
       
    private Writing[] searchResults { get; set; }

    private string Genres { get; set; }
    private string TitlePart { get; set; }

    private async Task OnSearchSubmitAsync() {
        string request = null;
        if (Genres != null && Genres != "") {
            request += "genres=" + Genres + "&";
        }
        if (TitlePart != null && TitlePart != "") {
            request += "title=" + TitlePart + "&";
        }
        if (request != null) request = "?" + request.TrimEnd('&');
        try {
            searchResults = await Http.GetFromJsonAsync<Writing[]>("api/search" + request);
        } catch (HttpRequestException) {
            searchResults = Array.Empty<Writing>();
        }
    }

    protected async override Task OnInitializedAsync() {
        try {
            searchResults = await Http.GetFromJsonAsync<Writing[]>("api/search");
        } catch (HttpRequestException) {
            searchResults = Array.Empty<Writing>();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
