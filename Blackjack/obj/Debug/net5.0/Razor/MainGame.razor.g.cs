#pragma checksum "C:\Blackjack\Blackjack\MainGame.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52277ab74fb12d3e483f68ca63ab6157b048ae73"
// <auto-generated/>
#pragma warning disable 1591
namespace Blackjack
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blackjack\Blackjack\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blackjack\Blackjack\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blackjack\Blackjack\_Imports.razor"
using Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\Blackjack\MainGame.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\Blackjack\MainGame.razor"
using Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blackjack\Blackjack\MainGame.razor"
using Pages.Partials;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blackjack")]
    public partial class MainGame : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-3");
            __builder.OpenElement(4, "div");
#nullable restore
#line 196 "C:\Blackjack\Blackjack\MainGame.razor"
                  
                    int cardCount = dealer.Deck.Count + 1;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "C:\Blackjack\Blackjack\MainGame.razor"
                 while (cardCount > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"blackjack-drawdeck\"><img src=\"images/cardBack.png\"></div>");
#nullable restore
#line 204 "C:\Blackjack\Blackjack\MainGame.razor"
                    cardCount -= 13;
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.OpenComponent<Blackjack.Pages.Partials.BlackjackHand>(9);
            __builder.AddAttribute(10, "Cards", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Blackjack.Models.Card>>(
#nullable restore
#line 209 "C:\Blackjack\Blackjack\MainGame.razor"
                                                           dealer.Cards

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-3");
            __builder.OpenComponent<Blackjack.Pages.Partials.BlackjackScore>(14);
            __builder.AddAttribute(15, "State", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Enums.GameState>(
#nullable restore
#line 212 "C:\Blackjack\Blackjack\MainGame.razor"
                                                            state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Player", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Person>(
#nullable restore
#line 212 "C:\Blackjack\Blackjack\MainGame.razor"
                                                                           dealer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-3");
#nullable restore
#line 220 "C:\Blackjack\Blackjack\MainGame.razor"
             if (state == GameState.Betting)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 222 "C:\Blackjack\Blackjack\MainGame.razor"
                 if (player.Funds < 10)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<span class=\"display-3 text-danger\">Out of money</span>");
#nullable restore
#line 225 "C:\Blackjack\Blackjack\MainGame.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 226 "C:\Blackjack\Blackjack\MainGame.razor"
                 if (player.Funds >= 10)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 228 "C:\Blackjack\Blackjack\MainGame.razor"
                                                              (()=> Bet(10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Bet $10");
            __builder.CloseElement();
#nullable restore
#line 229 "C:\Blackjack\Blackjack\MainGame.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 230 "C:\Blackjack\Blackjack\MainGame.razor"
                 if (player.Funds >= 20)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 232 "C:\Blackjack\Blackjack\MainGame.razor"
                                                              (()=> Bet(20))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Bet $20");
            __builder.CloseElement();
#nullable restore
#line 233 "C:\Blackjack\Blackjack\MainGame.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 234 "C:\Blackjack\Blackjack\MainGame.razor"
                 if (player.Funds >= 50)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 236 "C:\Blackjack\Blackjack\MainGame.razor"
                                                              (()=> Bet(50))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Bet $50");
            __builder.CloseElement();
#nullable restore
#line 237 "C:\Blackjack\Blackjack\MainGame.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 237 "C:\Blackjack\Blackjack\MainGame.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-3");
#nullable restore
#line 241 "C:\Blackjack\Blackjack\MainGame.razor"
             if(state == GameState.Payout)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blackjack.Pages.Partials.BlackjackHandResult>(38);
            __builder.AddAttribute(39, "Player", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Person>(
#nullable restore
#line 243 "C:\Blackjack\Blackjack\MainGame.razor"
                                                                      player

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Dealer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Person>(
#nullable restore
#line 243 "C:\Blackjack\Blackjack\MainGame.razor"
                                                                                      dealer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 244 "C:\Blackjack\Blackjack\MainGame.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 246 "C:\Blackjack\Blackjack\MainGame.razor"
             if(state == GameState.Dealing || state == GameState.Shuffling || state == GameState.InProgress)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blackjack.Pages.Partials.BlackjackMessage>(41);
            __builder.AddAttribute(42, "State", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Enums.GameState>(
#nullable restore
#line 248 "C:\Blackjack\Blackjack\MainGame.razor"
                                                                  state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "Bet", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 248 "C:\Blackjack\Blackjack\MainGame.razor"
                                                                              player.Bet

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 249 "C:\Blackjack\Blackjack\MainGame.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n        <div class=\"col-3\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-3");
#nullable restore
#line 259 "C:\Blackjack\Blackjack\MainGame.razor"
             if (state == GameState.NotStarted)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-secondary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 262 "C:\Blackjack\Blackjack\MainGame.razor"
                                  (() => InitializeHand())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                    Start Game\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 265 "C:\Blackjack\Blackjack\MainGame.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 267 "C:\Blackjack\Blackjack\MainGame.razor"
             if (!player.IsBusted && state == GameState.InProgress && !player.HasStood)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 269 "C:\Blackjack\Blackjack\MainGame.razor"
                                                          (() => Stand())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n                    Stand\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 272 "C:\Blackjack\Blackjack\MainGame.razor"
                                                          (() => Hit())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "\r\n                    Hit\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 276 "C:\Blackjack\Blackjack\MainGame.razor"
                 if (player.Score >= 9
                  && player.Score <= 11
                  && player.Cards.Count == 2
                  && player.Funds >= player.Bet * 2)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "<br>\r\n                    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-warning");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 283 "C:\Blackjack\Blackjack\MainGame.razor"
                                      (() => DoubleDown())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "\r\n                        Double Down\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 286 "C:\Blackjack\Blackjack\MainGame.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 288 "C:\Blackjack\Blackjack\MainGame.razor"
                 if (dealer.HasAceShowing && !player.HasInsurance)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "<br>\r\n                    ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-warning");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 292 "C:\Blackjack\Blackjack\MainGame.razor"
                                      (() => Insurance())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "\r\n                        Insurance ($");
            __builder.AddContent(73, 
#nullable restore
#line 293 "C:\Blackjack\Blackjack\MainGame.razor"
                                      player.Bet / 2

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, ")\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 295 "C:\Blackjack\Blackjack\MainGame.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 295 "C:\Blackjack\Blackjack\MainGame.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 298 "C:\Blackjack\Blackjack\MainGame.razor"
             if (state == GameState.Payout)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-secondary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 300 "C:\Blackjack\Blackjack\MainGame.razor"
                                                            (() => NewHand())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "\r\n                    Keep Going!\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 303 "C:\Blackjack\Blackjack\MainGame.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-3");
            __builder.OpenComponent<Blackjack.Pages.Partials.BlackjackHand>(82);
            __builder.AddAttribute(83, "Cards", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Blackjack.Models.Card>>(
#nullable restore
#line 306 "C:\Blackjack\Blackjack\MainGame.razor"
                                                           player.Cards

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "col-3");
            __builder.OpenComponent<Blackjack.Pages.Partials.BlackjackScore>(87);
            __builder.AddAttribute(88, "State", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Enums.GameState>(
#nullable restore
#line 309 "C:\Blackjack\Blackjack\MainGame.razor"
                                                            state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "Player", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blackjack.Models.Person>(
#nullable restore
#line 309 "C:\Blackjack\Blackjack\MainGame.razor"
                                                                           player

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Blackjack\Blackjack\MainGame.razor"
       
    Dealer dealer = new Dealer(); //Creating a new Dealer also
                                  //creates a new, shuffled CardDeck
    Player player = new Player();

    GameState state = GameState.NotStarted;


    public async Task Bet(decimal amount)
    {
        if (player.Funds >= amount)
        {
            player.Bet += amount;
            await Deal();
        }
    }

    public async Task Delay(int milisec)
    {
        await Task.Delay(milisec);
        StateHasChanged();
    }

    public async Task InitializeHand()
    {
        if (dealer.Deck.Count < 13)
        {
            state = GameState.Shuffling;
            dealer.Deck = new CardDeck();
            await Delay(1000);
        }
    }

    public async Task Deal()
    {
        state = GameState.Dealing;

        //Deal cards. Cards not visible

        await dealer.DealToPlayer(player);
        StateHasChanged();

        var dealerCard = dealer.Deal();
        dealerCard.IsVisible = false;
        await dealer.AddCard(dealerCard);
        StateHasChanged();

        //Deal another card to dealer and player
        await dealer.DealToPlayer(player);
        StateHasChanged();

        await dealer.DealToSelf();
        StateHasChanged();

        state = GameState.InProgress;

        if (player.HasNaturalBlackjack)
        {
            EndHand();
        }
    }

    public async Task DealerTurn()
    {
        if (dealer.Score < 17)
        {
            await dealer.DealToSelf();
            StateHasChanged();
            await DealerTurn();
        }
    }

    public async Task Hit()
    {
        await dealer.DealToPlayer(player);

        if (player.IsBusted)
        {
            EndHand();
        }
    }

    public async Task Stand()
    {
        player.HasStood = true;
        dealer.Reveal();

        await DealerTurn();

        EndHand();
    }

    public async Task DoubleDown()
    {
        player.HasStood = true;
        //Only if shown score is 9,10, 11
        //If yes, the player doubles the bet
        player.Bet *= 2;

        await Delay(3000);

        //Player gets additional card
        await player.AddCard(dealer.Deal());

        //Forced to stand
        await Stand();
    }

    public void Insurance()
    {
        state = GameState.Insurance;

        if (dealer.HasAceShowing)
        {
            //Insuranec bet is half the original bet
            player.InsuranceBet = player.Bet / 2;

            if (dealer.Score == 21)
            {
                dealer.Reveal();

                player.Change += player.InsuranceBet * 2;

                state = GameState.Payout;
                StateHasChanged();
                EndHand();
            }

            else
            {
                player.Change -= player.InsuranceBet;
            }
        }

        state = GameState.InProgress;
    }

    public void EndHand()
    {
        state = GameState.Payout;

        if (player.HasNaturalBlackjack && dealer.Score != 21)
        {
            player.Change += player.Bet * 1.5M;
        }

        else if (!player.IsBusted && dealer.IsBusted)
        {
            player.Change += player.Bet;
        }

        else if (!dealer.IsBusted && !player.IsBusted && player.Score > dealer.Score)
        {
            player.Change += player.Bet;
        }

        else if (!dealer.IsBusted && !player.IsBusted && player.Score == dealer.Score)
        {
            //just  push
        }

        else
        {
            player.Change += player.Bet * -1;
        }

        player.Bet = 0;
        player.HasStood = false;
    }

    public async Task NewHand()
    {
        player.Collect();

        player.ClearHand();
        dealer.ClearHand();

        state = GameState.NotStarted;

        await InitializeHand();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
