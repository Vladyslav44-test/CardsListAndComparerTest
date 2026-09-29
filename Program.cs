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
            List<Card> cards = new List<Card>();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards) && (numberOfCards >= 0))
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    cards.Add(RandomCard());
                }
                PrintCards(cards);
                CardComparer comparer = new CardComparer();
                Console.WriteLine("\n...sorting the cards...\n");
                cards.Sort(comparer);
                PrintCards(cards);
            }
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
