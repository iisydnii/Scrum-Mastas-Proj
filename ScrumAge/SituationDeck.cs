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
        Austin Trivette, 11/15/21, Made Class Public for Situational Card Form
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
    public class SituationDeck : IDeck
    {
        private HashSet<object> situationDeck { get; set; }

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
        
        public void UpdateDeck(SituationCard card)
        {
            //remove card from deck
            situationDeck.Remove(card);
        }


    }
}


