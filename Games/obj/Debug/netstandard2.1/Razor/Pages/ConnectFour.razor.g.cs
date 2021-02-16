#pragma checksum "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274b66f9e208f63e18a59011725811e91bfe351f"
// <auto-generated/>
#pragma warning disable 1591
namespace Games.Pages
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
#nullable restore
#line 2 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
using Games.Models.ConnectFour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
using Games.Models.ConnectFour.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
using Games.Pages.Partials;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/connectfour")]
    public partial class ConnectFour : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Games.Shared.PageTitle>(0);
            __builder.AddAttribute(1, "Title", "ConnectFour");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n\n");
#nullable restore
#line 12 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
 if (board.WinningPlay == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
         board.CurrentTurn

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "\'s Turn!");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 15 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 19 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
         board.WinningPlay.WinningColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " Wins! ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-success");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
                                                                                          () => board.Reset()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Reset");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 20 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "connectfour-board");
            __builder.AddMarkupContent(20, "\n");
#nullable restore
#line 23 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
     for (int i = 0; i < 7; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "connectfour-column");
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 26 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
             for (int j = 0; j < 6; j++)
            {
                int x = i;
                int y = j;
                var color = board.Board[i, j].Color;
                if (color == PieceColor.Blank)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "connectfour-gamepiece\n                         connectfour-blank");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
                                                        () => board.PieceClicked(x,y)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 35 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "connectfour-gamepiece" + "\n                         connectfour-" + (
#nullable restore
#line 39 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
                                      color.ToString().ToLower()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "style", 
#nullable restore
#line 40 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
                                  board.IsGamePieceAWinningPiece(i, j)? "opacity: 0.6" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 41 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
#nullable restore
#line 44 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Blackjack\BlazorGames\Pages\ConnectFour.razor"
       
    GameBoard board = new GameBoard();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
