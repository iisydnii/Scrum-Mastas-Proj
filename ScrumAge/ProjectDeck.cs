/*-------------
Name: Garrett Dyer
Date created: 10/16/21
Last Updated: 10/16/21
File name: ProjectDeck
Purpose: Creates the prject deck, adds cards to the deck, shuffles the deck.    
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
    class ProjectDeck : IDeck
    {
        public HashSet<object> projectDeck { get; set; }

        public ProjectDeck()
        {
            projectDeck = new HashSet<object>();
            CreateDeck(); // Added this so the deck is automatically created upon the creation of the ProjectTile object. -- Austin

        }

        public void CreateDeck() // creates the project tile deck. 
        {
            int cardsToCreate = 1;

            for (int i = 1; i <= cardsToCreate; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            ProjectTile card1 = new ProjectTile();
                            card1.id = i;
                            card1.Description = "temp project";
                            card1.cost.Add(2, "Training");
                            card1.reward.Add(10, "Bitcoin");
                            card1.used = false;
                            projectDeck.Add(card1);
                            break;
                        }
                }
            }
        }

        public string DisplayCard() //displays cards for testing purposes
        {
            ProjectTile tempTile = (ProjectTile)projectDeck.ElementAt(0);
            string cardText = "";
            cardText += $"-------------------";
            cardText += $"\n\nSituation: {tempTile.Description}";
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

        public void ShuffleDeck()
        {
            throw new NotImplementedException();
        }

        public void DrawCard()
        {
            throw new NotImplementedException();
        }
    }
}
