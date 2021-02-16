#pragma checksum "C:\Games\Games\Pages\Partials\YahtzeeDie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21596383c366f0bff925a757203643b4c0fc62af"
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
#line 1 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
using Games.Models.Yahtzee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
using Games.Models.Yahtzee.Enums;

#line default
#line hidden
#nullable disable
    public partial class YahtzeeDie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 14 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
         if (Die.State == DieState.Rolling)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "            <i class=\"fas fa-5x fa-dice\"></i>\n");
#nullable restore
#line 17 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
             if (IsStartOfTurn)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "i");
            __builder.AddAttribute(9, "class", "fas" + " fa-5x" + " fa-dice-" + (
#nullable restore
#line 22 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
                                             Die.GetClassName()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 23 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
            }
            else if (Die.IsHeld)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "i");
            __builder.AddAttribute(13, "class", "fas" + " fa-5x" + " fa-dice-" + (
#nullable restore
#line 26 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
                                             Die.GetClassName()

#line default
#line hidden
#nullable disable
            ) + " text-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
                                                                                          () => Die.Hold()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 27 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "i");
            __builder.AddAttribute(18, "class", "fas" + " fa-5x" + " fa-dice-" + (
#nullable restore
#line 30 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
                                             Die.GetClassName()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
                                                                             () => Die.Hold()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#nullable restore
#line 31 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Games\Games\Pages\Partials\YahtzeeDie.razor"
       
    [Parameter]
    public Die Die { get; set; }

    [Parameter]
    public bool IsStartOfTurn { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
