using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway //TwentyOneGame is part of the TwentyOne namespace and inherits from the Game and implements IWalkAway class
    {
        public TwentyOneDealer Dealer { get; set; } //create Dealer property (which handles dealer's action/state)
        public override void Play() //main method where game's logic is executed
        {
            Dealer = new TwentyOneDealer(); //instantiate Dealer
            foreach (Player player in Players) //iterates over each player and does the following two lines...
            {
                player.Hand = new List<Card>(); //for each round, we want hand to start blank (not carry over from the last round)
                player.Stay = false; //start with stay as false; we don't want the stay from the last round to carry over

            }
            Dealer.Hand = new List<Card>(); //starts dealer hand anew each round
            Dealer.Stay = false; //refresh stay property each round 
            Dealer.Deck = new Deck(); //refreshes the deck each round
            Dealer.Deck.Shuffle(); //shuffles the deck

            foreach (Player player in Players) //iterate over each player in Player
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }
                bool successfullyBet = player.Bet(bet); //checks if a bet is successful, if true the game continues 
                if (!successfullyBet) //if a bet is unsuccessful, do the following
                {
                    return; //ends the game 
                }
                Bets[player] = bet; //finalizes bets from all players
            }
            for (int i = 0; i < 2; i++) //for the deal: count start at 0, can't be more than two cards dealt, and adds 1 to the counter after every round of dealing
            {
                Console.WriteLine("Dealing..."); //prints text 
                foreach (Player player in Players) //iterates over the players 
                {
                    Console.Write("{0}: ", player.Name); //prints text 
                    Dealer.Deal(player.Hand); //deals hands
                    if (i == 1) //after two rounds 
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //checking for blackjack amongst players
                        if (blackJack) //if there is blackjack...
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]); //prints text 
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //if player wins, add winnings to balance
                            return; //ends round 
                        }
                    }
                }
                Console.Write("Dealer: "); //prints text 
                Dealer.Deal(Dealer.Hand); //checks dealers hand 
                if (i == 1) //after two cards are dealt 
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); //checks dealers hand for blackjack
                    if (blackJack) //if dealer has blackjack 
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!"); //prints text 
                        foreach (KeyValuePair<Player, int> entry in Bets) //tablulates betting pool 
                        {
                            Dealer.Balance += entry.Value; //gives betting pool to dealer 
                        }
                        return; //ends round
                    }
                }
            }
            foreach (Player player in Players) //iterates over the players 
            {
                while (!player.Stay) // displays cards and prompts hit or stay
                {
                    Console.WriteLine("Your cards are: "); //prints text 
                    foreach (Card card in player.Hand) //iterates over cards in the players hand 
                    {
                        Console.Write("{0} ", card.ToString()); // disyplay cards as text 
                    }
                    Console.WriteLine("\n\nHit or stay?"); //asks player if they want to hit or stay 
                    string answer = Console.ReadLine().ToLower(); //records player response under variable answer 
                    if (answer == "stay") //if player chooses to stay 
                    {
                        player.Stay = true; //player stays 
                        break; //ends turn 
                    }
                    else if (answer == "hit") //if they hit 
                    {
                        Dealer.Deal(player.Hand); //gives player another card 
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //checks if player busted (went over 21)
                    if (busted) //if the player busted 
                    {
                        Dealer.Balance += Bets[player]; //dealer takes the players bet
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance); //writes line, displays balance
                        Console.WriteLine("Do you want to play again?"); //writes line 
                        answer = Console.ReadLine().ToLower(); //records player response
                        if (answer == "yes" || answer == "yeah") //if player answer yes, or yeah 
                        {
                            player.isActivelyPlaying = true; //player continues playing 
                            return; //return to betting portion
                        } 
                        else //if not yes/yeah
                        {
                            player.isActivelyPlaying = false; //player is no longer playing 
                            return; //return to start 
                        }
                    }

                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks if dealer busted 
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks if dealer stayed 
            while (!Dealer.Stay && !Dealer.isBusted) //while did not dealer stay or is not busted 
            {
                Console.WriteLine("Dealer is hitting..."); //print text 
                Dealer.Deal(Dealer.Hand); //gives dealer another card 
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks if dealer busted 
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks if dealer stayed
            }
            if (Dealer.Stay) //if dealer stays
            {
                Console.WriteLine("Dealer is staying."); //print the following 
            }
            if (Dealer.isBusted) //if dealer busted 
            {
                Console.WriteLine("Dealer Busted!"); //prints text 
                foreach (KeyValuePair<Player, int> entry in Bets) //iterates over player and their bets 
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //prints text and winnings for player
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //tabulates player balances
                    Dealer.Balance -= entry.Value; //tabulates dealer balance
                }
                return; 
            }
            foreach (Player player in Players) //iterates over players 
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //checks who won 
                if (playerWon == null) //if nobody won 
                {
                    Console.WriteLine("Push No one wins!"); //prints text 
                    player.Balance += Bets[player]; //determines balance 
                }
                else if (playerWon == true) //if a player did win
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]); //prints text w/ player and bet 
                    player.Balance += (Bets[player] * 2); //tabulates players new balance 
                    Dealer.Balance -= Bets[player]; //balance of dealer tabulated
                }
                else //if player didn't win 
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]); //prints dealer won, and takes in bets 
                    Dealer.Balance += Bets[player]; //adds bets to dealer balance 
                } 
                Console.WriteLine("Play again?"); //prints text 
                string answer = Console.ReadLine().ToLower(); //records user answer 
                if (answer == "yes" || answer == "yeah") //if player still wants to player 
                {
                    player.isActivelyPlaying = true; //player continues to play; response recorded 
                } 
                else //if not 
                {
                    player.isActivelyPlaying = false; //player no longer playing; response recorded
                }
            }
        }
        public override void ListPlayers() //list players in the game 
        {
            Console.WriteLine("21 Players:"); //prints text 
            base.ListPlayers(); //extends functionality of base Game class 
        }
        public void WalkAway(Player player) //walkaway method is a placehold for player choice. Allows player to leave the game 
        {
            throw new NotImplementedException();
        }
    }
}
