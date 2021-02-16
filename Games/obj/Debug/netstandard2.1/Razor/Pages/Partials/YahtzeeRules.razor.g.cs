#pragma checksum "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fe63c17a75db9115810ecf6f8444ad23f23ca0"
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
    public partial class YahtzeeRules : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\n\n\n");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "href", "#");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
                      (() => ShowRules = !ShowRules)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(4, "onclick", true);
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 8 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
     if (ShowRules)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "Hide Rules");
#nullable restore
#line 10 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
                               
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "Show Rules");
#nullable restore
#line 14 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
                               
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
#nullable restore
#line 18 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
 if (ShowRules)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<h3>Yahtzee Rules</h3>\n");
            __builder.AddContent(11, "    ");
            __builder.AddMarkupContent(12, "<p>\n        GOAL: Get the highest score possible in thirteen turns.\n    </p>\n");
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<p>\n        Each turn in Yahtzee consists of three \"rolls\". On each turn, players use their first roll\n        to roll all five dice. Prior to subsequent rolls, Players may \"hold\" dice by clicking them,\n        which means they will not roll.\n    </p>\n");
            __builder.AddContent(15, "    ");
            __builder.AddMarkupContent(16, @"<p>
        Each turn ends with the players either ""claiming"" or ""scratching"" a row in the scorecard.
        A player may only claim a roll when their dice meet that row's criteria.
        A player does not need to use all ""rolls"" in a turn before claiming a score.
        If there is no score the player can claim at the end of three rolls, they can ""scratch"" a row,
        which marks that row with a 0. Scratched rows cannot be claimed later.
    </p>
");
            __builder.AddContent(17, "    ");
            __builder.AddMarkupContent(18, "<h4>Example Rolls</h4>\n");
            __builder.AddContent(19, "    ");
            __builder.AddMarkupContent(20, @"<p>
        <i class=""fas fa-3x fa-dice-four""></i>
        <i class=""fas fa-3x fa-dice-three""></i>
        <i class=""fas fa-3x fa-dice-four""></i>
        <i class=""fas fa-3x fa-dice-three""></i>
        <i class=""fas fa-3x fa-dice-four""></i>
        Full House, worth 25 points. Could also be used for the ""three 4s"" row if Full House is already claimed.
    </p>
");
            __builder.AddContent(21, "    ");
            __builder.AddMarkupContent(22, @"<p>
        <i class=""fas fa-3x fa-dice-one""></i>
        <i class=""fas fa-3x fa-dice-six""></i>
        <i class=""fas fa-3x fa-dice-six""></i>
        <i class=""fas fa-3x fa-dice-six""></i>
        <i class=""fas fa-3x fa-dice-six""></i>
        Can be used for three 6s, three-of-a-kind, or four-of-a-kind, each worth 6 + 6 + 6 + 6 = 24 points.
    </p>
");
            __builder.AddContent(23, "    ");
            __builder.AddMarkupContent(24, @"<p>
        <i class=""fas fa-3x fa-dice-three""></i>
        <i class=""fas fa-3x fa-dice-five""></i>
        <i class=""fas fa-3x fa-dice-two""></i>
        <i class=""fas fa-3x fa-dice-one""></i>
        <i class=""fas fa-3x fa-dice-four""></i>
        A large straight, worth 40 points. Can be used for a small straight if a large straight is already claimed.
    </p>
");
            __builder.AddContent(25, "    ");
            __builder.AddMarkupContent(26, @"<p>
        <i class=""fas fa-3x fa-dice-five""></i>
        <i class=""fas fa-3x fa-dice-six""></i>
        <i class=""fas fa-3x fa-dice-five""></i>
        <i class=""fas fa-3x fa-dice-three""></i>
        <i class=""fas fa-3x fa-dice-two""></i>
        Can only be used for Chance, this matches no other row.
    </p>
");
            __builder.AddContent(27, "    ");
            __builder.AddMarkupContent(28, "<h4>Top Section Bonus</h4>\n");
            __builder.AddContent(29, "    ");
            __builder.AddMarkupContent(30, "<p>If the score for the \"three numbers\" rows (e.g. three 1s, three 2s, three 3s, etc.) exceeds 63, then the player is awarded a 35 point bonus.</p>\n");
            __builder.AddContent(31, "    ");
            __builder.AddMarkupContent(32, "<h4>Bonus Yahtzee</h4>\n");
            __builder.AddContent(33, "    ");
            __builder.AddMarkupContent(34, "<p>\n        After the player has already rolled a Yahtzee, the player can then try to roll for a Bonus Yahtzee, worth 100 points.\n    </p>\n");
#nullable restore
#line 87 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\Pages\Partials\YahtzeeRules.razor"
      
    public bool ShowRules { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
