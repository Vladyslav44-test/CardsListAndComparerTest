using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CardsListAndComparerTest
{
    internal class Program
    {
        private static Random random = new Random(); 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# 14.0 and higher!");
        }
        private static Card RandomCard()
        {
            Suits randomSuit = (Suits)random.Next(4);
            Values randomValue = (Values)random.Next(1, 14);
            return new Card(randomValue, randomSuit);
        }
        private static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
