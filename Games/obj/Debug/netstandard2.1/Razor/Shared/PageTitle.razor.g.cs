#pragma checksum "C:\Blackjack\BlazorGames\Shared\PageTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c963f6db639d2f097732cc62be21a019a06bcab"
// <auto-generated/>
#pragma warning disable 1591
namespace Games.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blackjack\BlazorGames\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blackjack\BlazorGames\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blackjack\BlazorGames\_Imports.razor"
using Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blackjack\BlazorGames\_Imports.razor"
using Games.Shared;

#line default
#line hidden
#nullable disable
    public partial class PageTitle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 18 "C:\Blackjack\BlazorGames\Shared\PageTitle.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\Shared\PageTitle.razor"
       
    [Parameter]
    public string Title { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await setTitle();
    }

    private async Task setTitle()
    {
        await _jsRuntime.InvokeVoidAsync("setTitle", Title );
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
