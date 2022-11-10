﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //BlackjackGame game = new BlackjackGame();
            //game.Players = new List<string>() { "Alex", "Michael", "Sean" };
            //game.ListPlayers();
            //Console.ReadLine();

            Game game = new BlackjackGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game += player;

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
