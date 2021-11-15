/*-------------
Name: Garrett Dyer
Date created: 10/16/21
Last Updated: 11/5/21
File name: ProjectDeck
Purpose: Creates the prject deck, adds cards to the deck, shuffles the deck.    
________________________________________________________________________________
Page Modified
        Garrett Dyer, 11/5/21, Moved deck creation to a factory.
        Piper Floyd, 11/10/21, Modified DrawCard() to pull a random card from the hash set 
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
    public class ProjectDeck : IDeck
    {
        public HashSet<object> projectDeck { get; set; }

        public ProjectDeck()
        {
            projectDeck = new HashSet<object>();
            CreateDeck(); // Added this so the deck is automatically created upon the creation of the ProjectTile object. -- Austin
        }

        public void CreateDeck() // creates the project tile deck. 
        {
            DeckFactory deckFactory = new DeckFactory();
            projectDeck = deckFactory.CreateProjectDeck();
        }

        public string DisplayCard() //displays card for testing purposes
        {
            ProjectTile tempTile = (ProjectTile)projectDeck.ElementAt(0);
            string cardText = "";
            cardText += $"-------------------";
            cardText += $"\n\ndescription: {tempTile.Description}";
            foreach (var k in tempTile.cost)
            {
                cardText += $"\n\nCost: This costs {k.Key} {k.Value} ";
            }
            foreach (var j in tempTile.reward)
            {
                cardText += $"\n\nReward: This gives you {j.Key} {j.Value} ";
            }
            cardText += $"\n\n-------------------\n\n";
            Console.WriteLine(cardText);
            return "";
        }

        public void DisplayCards() //displays cards for testing purposes
        {

            for (int i = 0; i < projectDeck.Count; i++)
            {
                ProjectTile tempCard = (ProjectTile)projectDeck.ElementAt(i);
                string cardText = "";
                cardText += $"-------------------";
                cardText += $"\n\ndescription: {tempCard.Description}";
                foreach (var k in tempCard.cost)
                {
                    cardText += $"\n\nCost: This costs {k.Key} {k.Value} ";
                }
                foreach (var j in tempCard.reward)
                {
                    cardText += $"\n\nReward: This gives you {j.Key} {j.Value} ";
                }
                cardText += $"\n\n-------------------\n\n";
                Console.WriteLine(cardText);
            }

        }




        public void ShuffleDeck()
        {
            throw new NotImplementedException();
        }

        public ProjectTile DrawCard()
        {
            Random random = new Random();
            ProjectTile tempCard = (ProjectTile)projectDeck.ElementAt(random.Next(projectDeck.Count));
            //projectDeck.Remove(projectDeck.ElementAt(0));
            DisplayCard();
            Console.WriteLine($"There are {projectDeck.Count()} Cards left in the deck");
            return tempCard;
        }

        public void RemoveCard(ProjectTile pickedUpTile)
        {
            projectDeck.Remove(pickedUpTile);
        }
    }
}
