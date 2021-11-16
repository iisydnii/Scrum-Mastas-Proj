/*-------------
Name: Garrett Dyer
Date created: 09/22/21
Last Updated: 11/5/21
File name: SituationCard
Purpose: Creates the situation deck, adds cards to the deck, shuffles the deck.
________________________________________________________________________________
Page Modified
        Garrett Dyer, 10/16/21, Added 22 Situation Cards to the deck, and updated counters.
        Garrett Dyer, 11/5/21, Moved deck creation to a factory.
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fixed some pascal casing issues here --Austin
//Make sure in the future to always capitalize Pascal Case Properties and Methods :: like MethodName or PropertyName

namespace ScrumAge
{
    class SituationDeck : IDeck
    {
        public HashSet<object> situationDeck { get; set; }

        /* Creating constructor for situation deck */
        public SituationDeck()
        {
            situationDeck = new HashSet<object>();
            CreateDeck(); // Added this so the deck is automatically created upon the creation of the situationdeck object. -- Austin
        }

       
        /* Creates situation cards and adds them to the deck */
        public void CreateDeck()
        {
            DeckFactory deckFactory = new DeckFactory();
            situationDeck = deckFactory.CreateSituationDeck();
        }


        public void ShuffleDeck() //shuffles the deck of cards. Puts 4 cards at the front of the deck for easy completion.
        {
            Random rand = new Random();
            HashSet<object> tempDeck = new HashSet<object>();
            int counter = 4;
            int counter2 = 27;

            for (int i = 0; tempDeck.Count <= 4; i++)
            {

                int randomNumber = rand.Next(counter);
                SituationCard tempCard = (SituationCard)situationDeck.ElementAt(randomNumber);
                tempDeck.Add(tempCard);
                situationDeck.Remove(tempCard);
                counter--;
            }

            for (int i = 0; tempDeck.Count < 32; i++)
            {
                int randomNumber = rand.Next(counter2);
                SituationCard tempCard = (SituationCard)situationDeck.ElementAt(randomNumber);
                tempDeck.Add(tempCard);
                situationDeck.Remove(tempCard);
                counter2--;
            }

            situationDeck = tempDeck;
        }

        public SituationCard DrawCard()
        { 
            SituationCard tempCard = (SituationCard)situationDeck.ElementAt(0);
            situationDeck.Remove(situationDeck.ElementAt(0));
            DisplayCard();
            Console.WriteLine($"There are {situationDeck.Count()} Cards left in the deck");
            return tempCard;
        }


        public string DisplayCard() //testing purposes
        {
            SituationCard tempCard = (SituationCard)situationDeck.ElementAt(0);
            string cardText = "";
            cardText += $"-------------------";
            cardText += $"\n\nSituation: {tempCard.situation}";
            foreach (var k in tempCard.cost)
            {
                cardText += $"\n\nCost: This costs {k.Key} {k.Value} ";
            }
            foreach (var j in tempCard.reward)
            {
                cardText += $"\n\nReward: This gives you {j.Key} {j.Value} ";
            }
            cardText += $"\n\nCertification: {tempCard.certifications}";
            cardText += $"\n\nDiffculty: {tempCard.diffculty.ToString()}";
            cardText += $"\n\n-------------------\n\n";
            Console.WriteLine(cardText);
            return "";
        }

        public void DisplayCards() //displays cards for testing purposes
        {
            for (int i = 0; i < situationDeck.Count; i++)
            {
                SituationCard tempCard = (SituationCard)situationDeck.ElementAt(i);
                string cardText = "";
                cardText += $"-------------------";
                cardText += $"\n\nSituation: {tempCard.situation}";
                foreach (var k in tempCard.cost)
                {
                    cardText += $"\n\nCost: This costs {k.Key} {k.Value} ";
                }
                foreach (var j in tempCard.reward)
                {
                    cardText += $"\n\nReward: This costs {j.Key} {j.Value} ";
                }
                cardText += $"\n\nCertification: {tempCard.certifications}";
                cardText += $"\n\nDiffculty: {tempCard.diffculty.ToString()}";
                cardText += $"\n\n-------------------\n\n";
                Console.WriteLine(cardText);
            }

        }

        public void test() //displays cards for testing purposes
        {
            int total = 0;
            int total2 = 0;

            for (int i = 0; i < 1000; i++)
            {
                SituationDeck deckTest = new SituationDeck();
                deckTest.CreateDeck();
                deckTest.ShuffleDeck();
                SituationCard card0 = (SituationCard)situationDeck.ElementAt(0);
                SituationCard card1 = (SituationCard)situationDeck.ElementAt(1);
                SituationCard card2 = (SituationCard)situationDeck.ElementAt(2);
                SituationCard card3 = (SituationCard)situationDeck.ElementAt(3);

                if (card0.diffculty == 1)
                {
                    total++;
                }
                if (card1.diffculty == 1)
                {
                    total++;
                }
                if (card2.diffculty == 1)
                {
                    total++;
                }
                if (card3.diffculty == 1)
                {
                    total++;
                }
                if (situationDeck.Count == 32)
                {
                    total2++;
                }

            }

            if (total == 4000)
            {
                Console.WriteLine("First 4 cards are easy: Test Passed");
            }
            else if (total != 4000)
            {
                Console.WriteLine("First 4 cards are easy: Test Failed");
            }

            if (total2 == 1000)
            {
                Console.WriteLine("Each deck has 32 cards: Test Passed");
            }
            else if (total != 1000)
            {
                Console.WriteLine("Each deck has 32 cards: Test Failed");
            }

        }

    }
}


