#pragma checksum "C:\Games\Games\Pages\Partials\BlackjackHand.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49dc6de2c6c121fe4c398082d899c8653e27893e"
// <auto-generated/>
#pragma warning disable 1591
namespace Games.Pages.Partials
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Games\Games\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\Games\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Games\Games\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Games\Games\_Imports.razor"
using Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Games\Games\_Imports.razor"
using Games.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Games\Games\Pages\Partials\BlackjackHand.razor"
using Games.Models.Blackjack;

#line default
#line hidden
#nullable disable
    public partial class BlackjackHand : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n");
#nullable restore
#line 10 "C:\Games\Games\Pages\Partials\BlackjackHand.razor"
     foreach (var card in Cards)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenComponent<Games.Pages.Partials.BlackjackCard>(3);
            __builder.AddAttribute(4, "Card", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Games.Models.Blackjack.Card>(
#nullable restore
#line 12 "C:\Games\Games\Pages\Partials\BlackjackHand.razor"
                             card

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 13 "C:\Games\Games\Pages\Partials\BlackjackHand.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Games\Games\Pages\Partials\BlackjackHand.razor"
 
    [Parameter]
    public List<Card> Cards { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
