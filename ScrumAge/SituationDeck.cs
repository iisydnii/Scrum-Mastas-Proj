/*-------------
Name: Garrett Dyer
Date created: 09/22/21
Last Updated: 10/1/21
File name: SituationCard
Purpose: Creates the situation deck, adds cards to the deck, shuffles the deck.
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class SituationDeck
    {
        private HashSet<object> situationDeck { get; set; }

        /* Creating constructor for situation deck */
        public SituationDeck()
        {
            situationDeck = new HashSet<object>();
            createDeck(); // Added this so the deck is automatically created upon the creation of the situationdeck object. -- Austin
        }

        // Updated the situation attributes for these cards to represent the perspective of the player --Austin
        /* Creates situation cards and adds them to the deck */
        public void createDeck()
        {
            int cardsToCreate = 10;

            for (int i = 1; i <= cardsToCreate; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            SituationCard card1 = new SituationCard();
                            card1.id = i;
                            card1.situation = "A developer is having problems getting Github to work. Lose 2 Training points.";
                            card1.cost.Add(2, "Training");
                            card1.reward.Add(10, "Bitcoin");
                            card1.used = false;
                            card1.certifications = "Github certified";
                            card1.diffculty = 1;
                            situationDeck.Add(card1);
                            break;
                        }
                    case 2:
                        {
                            SituationCard card2 = new SituationCard();
                            card2.id = i;
                            card2.situation = "One of your developers called out sick today. Lose 2 Training points.";
                            card2.cost.Add(2, "Training");
                            card2.reward.Add(10, "Bitcoin");
                            card2.used = false;
                            card2.certifications = "Work from home";
                            card2.diffculty = 1;
                            situationDeck.Add(card2);
                            break;
                        }
                    case 3:
                        {
                            SituationCard card3 = new SituationCard();
                            card3.id = i;
                            card3.situation = "A developer's coworker would not stop talking to one of your developers in the kitchen. Lose 2 Training points.";
                            card3.cost.Add(2, "Training");
                            card3.reward.Add(10, "Bitcoin");
                            card3.used = false;
                            card3.certifications = "Coffee Break Gone Wrong";
                            card3.diffculty = 1;
                            situationDeck.Add(card3);
                            break;
                        }
                    case 4:
                        {
                            SituationCard card4 = new SituationCard();
                            card4.id = i;
                            card4.situation = "The team was unexpectedly given more work to do. Lose 2 Training points.";
                            card4.cost.Add(2, "Training");
                            card4.reward.Add(10, "Bitcoin");
                            card4.used = false;
                            card4.certifications = "Homework";
                            card4.diffculty = 1;
                            situationDeck.Add(card4);
                            break;
                        }
                    case 5:
                        {
                            SituationCard card5 = new SituationCard();
                            card5.id = i;
                            card5.situation = "A resource a developer is trying to access is blocked by the firewall. Contact IT. Lose 2 Training points.";
                            card5.cost.Add(2, "Training");
                            card5.reward.Add(10, "Bitcoin");
                            card5.used = false;
                            card5.certifications = "Firewalled";
                            card5.diffculty = 1;
                            situationDeck.Add(card5);
                            break;
                        }
                    case 6:
                        {
                            SituationCard card6 = new SituationCard();
                            card6.id = i;
                            card6.situation = "A developer's child is sick at school. Leave work early. Lose 4 training points";
                            card6.cost.Add(4, "Training");
                            card6.reward.Add(10, "Bitcoin");
                            card6.used = false;
                            card6.certifications = "Stay at home parent";
                            card6.diffculty = 2;
                            situationDeck.Add(card6);
                            break;
                        }
                    case 7:
                        {
                            SituationCard card7 = new SituationCard();
                            card7.id = i;
                            card7.situation = "Develop a form for the company website. Lose 5 Design points";
                            card7.cost.Add(5, "Design");
                            card7.reward.Add(10, "Bitcoin");
                            card7.reward.Add(5, "Training");
                            card7.used = false;
                            card7.certifications = "Formulated";
                            card7.diffculty = 2;
                            situationDeck.Add(card7);
                            break;
                        }
                    case 8:
                        {
                            SituationCard card8 = new SituationCard();
                            card8.id = i;
                            card8.situation = "A developer came to work drunk. Lose 5 Design points";
                            card8.cost.Add(5, "Design");
                            card8.reward.Add(5, "Bitcoin");
                            card8.reward.Add(4, "Training");
                            card8.used = false;
                            card8.certifications = "Party Time";
                            card8.diffculty = 2;
                            situationDeck.Add(card8);
                            break;
                        }
                    case 9:
                        {
                            SituationCard card9 = new SituationCard();
                            card9.id = i;
                            card9.situation = "A developer dropped their phone in coffee. Lose 10 Bitcoin";
                            card9.cost.Add(10, "Bitcoin");
                            card9.reward.Add(5, "Training");
                            card9.reward.Add(4, "Design");
                            card9.used = false;
                            card9.certifications = "Juiced up";
                            card9.diffculty = 3;
                            situationDeck.Add(card9);
                            break;
                        }
                    case 10:
                        {
                            SituationCard card10 = new SituationCard();
                            card10.id = i;
                            card10.situation = "A developer left their work badge at home. Lose 7 Bitcoin";
                            card10.cost.Add(7, "Bitcoin");
                            card10.reward.Add(7, "Design");
                            card10.used = false;
                            card10.certifications = "Commuter";
                            card10.diffculty = 3;
                            situationDeck.Add(card10);
                            break;
                        }


                }
            }

        }


        public void shuffleDeck() //shuffles the deck of cards. Puts 5 cards at the front of the deck for easy completion.
        {
            Random rand = new Random();
            HashSet<object> tempDeck = new HashSet<object>();
            int counter = 4;
            int counter2 = 5;

            for (int i = 0; tempDeck.Count <= 4; i++)
            {

                int randomNumber = rand.Next(counter);
                SituationCard tempCard = (SituationCard)situationDeck.ElementAt(randomNumber);
                tempDeck.Add(tempCard);
                situationDeck.Remove(tempCard);
                counter--;
            }

            for (int i = 0; tempDeck.Count < 10; i++)
            {
                int randomNumber = rand.Next(counter2);
                SituationCard tempCard = (SituationCard)situationDeck.ElementAt(randomNumber);
                tempDeck.Add(tempCard);
                situationDeck.Remove(tempCard);
                counter2--;
            }

            situationDeck = tempDeck;
        }

        //public object drawCard()
        //{
        //    SituationCard tempCard = (SituationCard)situationDeck.ElementAt(0);
        //    situationDeck.Remove(situationDeck.ElementAt(0));
        //    displayCard();
        //    return tempCard;
        //}


        public string displayCard() //testing purposes
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

        public void displayCards() //displays cards for testing purposes
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
                deckTest.createDeck();
                deckTest.shuffleDeck();
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
                if (situationDeck.Count == 10)
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
                Console.WriteLine("Each deck has 10 cards: Test Passed");
            }
            else if (total != 1000)
            {
                Console.WriteLine("Each deck has 10 cards: Test Failed");
            }

        }
    }
}


