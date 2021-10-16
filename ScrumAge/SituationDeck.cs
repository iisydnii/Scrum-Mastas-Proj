/*-------------
Name: Garrett Dyer
Date created: 09/22/21
Last Updated: 10/16/21
File name: SituationCard
Purpose: Creates the situation deck, adds cards to the deck, shuffles the deck.
________________________________________________________________________________
Page Modified
        Garrett Dyer, 10/16/21, Added 22 Situation Cards to the deck, and updated counters.
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class SituationDeck : IDeck
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
            int cardsToCreate = 32;

            for (int i = 1; i <= cardsToCreate; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            SituationCard card1 = new SituationCard();
                            card1.id = i;
                            card1.situation = "You are having problems getting Github to work. Lose 2 Training points.";
                            card1.cost.Add(2, "Training");
                            card1.reward.Add(10, "Bitcoin");
                            card1.used = false;
                            card1.certifications = "Github Certification";
                            card1.diffculty = 1;
                            situationDeck.Add(card1);
                            break;
                        }
                    case 2:
                        {
                            SituationCard card2 = new SituationCard();
                            card2.id = i;
                            card2.situation = "You need to call out sick today. Lose 2 Training points.";
                            card2.cost.Add(2, "Training");
                            card2.reward.Add(10, "Bitcoin");
                            card2.used = false;
                            card2.certifications = "Go Certification";
                            card2.diffculty = 1;
                            situationDeck.Add(card2);
                            break;
                        }
                    case 3:
                        {
                            SituationCard card3 = new SituationCard();
                            card3.id = i;
                            card3.situation = "A coworker would not stop talking to you in the kitchen. Lose 2 Training points.";
                            card3.cost.Add(2, "Training");
                            card3.reward.Add(10, "Bitcoin");
                            card3.used = false;
                            card3.certifications = "PHP Certification";
                            card3.diffculty = 1;
                            situationDeck.Add(card3);
                            break;
                        }
                    case 4:
                        {
                            SituationCard card4 = new SituationCard();
                            card4.id = i;
                            card4.situation = "You are unexpectedly given more work to do. Lose 2 Training points.";
                            card4.cost.Add(2, "Training");
                            card4.reward.Add(10, "Bitcoin");
                            card4.used = false;
                            card4.certifications = "Kotlin Certification";
                            card4.diffculty = 1;
                            situationDeck.Add(card4);
                            break;
                        }
                    case 5:
                        {
                            SituationCard card5 = new SituationCard();
                            card5.id = i;
                            card5.situation = "A resource you are trying to access is blocked by the firewall. Contact IT. Lose 2 Training points.";
                            card5.cost.Add(2, "Training");
                            card5.reward.Add(10, "Bitcoin");
                            card5.used = false;
                            card5.certifications = "Firewall Certification";
                            card5.diffculty = 1;
                            situationDeck.Add(card5);
                            break;
                        }
                    case 6:
                        {
                            SituationCard card6 = new SituationCard();
                            card6.id = i;
                            card6.situation = "Your child is sick at school. Leave work early. Lose 4 training points";
                            card6.cost.Add(4, "Training");
                            card6.reward.Add(10, "Bitcoin");
                            card6.used = false;
                            card6.certifications = "MATLAB Certification";
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
                            card7.certifications = "HTMl Certification";
                            card7.diffculty = 2;
                            situationDeck.Add(card7);
                            break;
                        }
                    case 8:
                        {
                            SituationCard card8 = new SituationCard();
                            card8.id = i;
                            card8.situation = "A coworker comes to work drunk. Lose 5 Design points";
                            card8.cost.Add(5, "Design");
                            card8.reward.Add(5, "Bitcoin");
                            card8.reward.Add(4, "Training");
                            card8.used = false;
                            card8.certifications = "Scala Certification";
                            card8.diffculty = 2;
                            situationDeck.Add(card8);
                            break;
                        }
                    case 9:
                        {
                            SituationCard card9 = new SituationCard();
                            card9.id = i;
                            card9.situation = "You dropped your phone in your coffee. Lose 10 Bitcoin";
                            card9.cost.Add(10, "Bitcoin");
                            card9.reward.Add(5, "Training");
                            card9.reward.Add(4, "Design");
                            card9.used = false;
                            card9.certifications = "SAP Certification";
                            card9.diffculty = 3;
                            situationDeck.Add(card9);
                            break;
                        }
                    case 10:
                        {
                            SituationCard card10 = new SituationCard();
                            card10.id = i;
                            card10.situation = "You left your work badge at home. Lose 7 Bitcoin";
                            card10.cost.Add(7, "Bitcoin");
                            card10.reward.Add(7, "Design");
                            card10.used = false;
                            card10.certifications = ".Net Certification";
                            card10.diffculty = 3;
                            situationDeck.Add(card10);
                            break;
                        }
                    case 11:
                        {
                            SituationCard card11 = new SituationCard();
                            card11.id = i;
                            card11.situation = "A developer ripped their pants picking their phone up off the floor. Lose 3 Design points.";
                            card11.cost.Add(3, "Design");
                            card11.reward.Add(2, "Training");
                            card11.used = false;
                            card11.certifications = "Oracle SQL Certification";
                            card11.diffculty = 1;
                            situationDeck.Add(card11);
                            break;
                        }
                    case 12:
                        {
                            SituationCard card12 = new SituationCard();
                            card12.id = i;
                            card12.situation = "A developer is late for the carpool. Lose 3 Training points.";
                            card12.cost.Add(3, "Training");
                            card12.reward.Add(2, "Design");
                            card12.used = false;
                            card12.certifications = "MySQL Certification";
                            card12.diffculty = 1;
                            situationDeck.Add(card12);
                            break;
                        }
                    case 13:
                        {
                            SituationCard card13 = new SituationCard();
                            card13.id = i;
                            card13.situation = "A developer lock their keys in their car. Lose 3 Training points.";
                            card13.cost.Add(3, "Training");
                            card13.reward.Add(2, "Design");
                            card13.used = false;
                            card13.certifications = "Python Certification";
                            card13.diffculty = 1;
                            situationDeck.Add(card13);
                            break;
                        }
                    case 14:
                        {
                            SituationCard card14 = new SituationCard();
                            card14.id = i;
                            card14.situation = "A developer is taking a smoke break. Lose 2 Design points.";
                            card14.cost.Add(2, "Design");
                            card14.reward.Add(2, "Training");
                            card14.used = false;
                            card14.certifications = "R Certification";
                            card14.diffculty = 1;
                            situationDeck.Add(card14);
                            break;
                        }
                    case 15:
                        {
                            SituationCard card15 = new SituationCard();
                            card15.id = i;
                            card15.situation = "A developers car broke down on the way to work. Lose 2 Training points.";
                            card15.cost.Add(2, "Training");
                            card15.reward.Add(2, "Design");
                            card15.used = false;
                            card15.certifications = "LINQ Certification";
                            card15.diffculty = 1;
                            situationDeck.Add(card15);
                            break;
                        }
                    case 16:
                        {
                            SituationCard card16 = new SituationCard();
                            card16.id = i;
                            card16.situation = "A developers Windows license has expired. Lose 5 Design points.";
                            card16.cost.Add(5, "Design");
                            card16.reward.Add(3, "Training");
                            card16.used = false;
                            card16.certifications = "Windows Server Certification";
                            card16.diffculty = 2;
                            situationDeck.Add(card16);
                            break;
                        }
                    case 17:
                        {
                            SituationCard card17 = new SituationCard();
                            card17.id = i;
                            card17.situation = "A developers keyboard stopped working. Lose 4 Design points.";
                            card17.cost.Add(4, "Design");
                            card17.reward.Add(3, "Training");
                            card17.used = false;
                            card17.certifications = "Linux Certification";
                            card17.diffculty = 2;
                            situationDeck.Add(card17);
                            break;
                        }
                    case 18:
                        {
                            SituationCard card18 = new SituationCard();
                            card18.id = i;
                            card18.situation = "A developers mouse stopped working. Lose 4 Training points.";
                            card18.cost.Add(4, "Training");
                            card18.reward.Add(3, "Design");
                            card18.used = false;
                            card18.certifications = "Kali Certification";
                            card18.diffculty = 2;
                            situationDeck.Add(card18);
                            break;
                        }
                    case 19:
                        {
                            SituationCard card19 = new SituationCard();
                            card19.id = i;
                            card19.situation = "A developers computer is out date. Lose 5 Training points.";
                            card19.cost.Add(5, "Training");
                            card19.reward.Add(4, "Design");
                            card19.used = false;
                            card19.certifications = "C# Certification";
                            card19.diffculty = 2;
                            situationDeck.Add(card19);
                            break;
                        }
                    case 20:
                        {
                            SituationCard card20 = new SituationCard();
                            card20.id = i;
                            card20.situation = "A developers computer has quit working. Lose 5 Bitcoin.";
                            card20.cost.Add(5, "Bitcoin");
                            card20.reward.Add(4, "Training");
                            card20.used = false;
                            card20.certifications = "C Certification";
                            card20.diffculty = 2;
                            situationDeck.Add(card20);
                            break;
                        }
                    case 21:
                        {
                            SituationCard card21 = new SituationCard();
                            card21.id = i;
                            card21.situation = "A developers monitor has quit working. Lose 4 Bitcoin.";
                            card21.cost.Add(4, "Bitcoin");
                            card21.reward.Add(5, "Training");
                            card21.used = false;
                            card21.certifications = "C++ Certification";
                            card21.diffculty = 2;
                            situationDeck.Add(card21);
                            break;
                        }
                    case 22:
                        {
                            SituationCard card22 = new SituationCard();
                            card22.id = i;
                            card22.situation = "A developers pen broke and leaked ink on the keyboard. Lose 4 Training points.";
                            card22.cost.Add(4, "Training");
                            card22.reward.Add(5, "Design");
                            card22.used = false;
                            card22.certifications = "MVC Certification";
                            card22.diffculty = 2;
                            situationDeck.Add(card22);
                            break;
                        }
                    case 23:
                        {
                            SituationCard card23 = new SituationCard();
                            card23.id = i;
                            card23.situation = "A developer spilled coffee on their computer. Lose 7 Bitcoin.";
                            card23.cost.Add(7, "Bitcoin");
                            card23.reward.Add(5, "Training");
                            card23.used = false;
                            card23.certifications = "Java Certification";
                            card23.diffculty = 3;
                            situationDeck.Add(card23);
                            break;
                        }
                    case 24:
                        {
                            SituationCard card24 = new SituationCard();
                            card24.id = i;
                            card24.situation = "A developer had a medical emergency. Lose 8 Training Points.";
                            card24.cost.Add(8, "Training");
                            card24.reward.Add(6, "Design");
                            card24.used = false;
                            card24.certifications = "Javascript Certification";
                            card24.diffculty = 3;
                            situationDeck.Add(card24);
                            break;
                        }
                    case 25:
                        {
                            SituationCard card25 = new SituationCard();
                            card25.id = i;
                            card25.situation = "The customer wants to change a few things in the prototype. Lose 8 Design Points.";
                            card25.cost.Add(8, "Design");
                            card25.reward.Add(6, "Training");
                            card25.used = false;
                            card25.certifications = "CSS Certification";
                            card25.diffculty = 3;
                            situationDeck.Add(card25);
                            break;
                        }
                    case 26:
                        {
                            SituationCard card26 = new SituationCard();
                            card26.id = i;
                            card26.situation = "A developer has been fired. Lose 9 Training Points.";
                            card26.cost.Add(9, "Training");
                            card26.reward.Add(7, "Design");
                            card26.used = false;
                            card26.certifications = "BootStrap Certification";
                            card26.diffculty = 3;
                            situationDeck.Add(card26);
                            break;
                        }
                    case 27:
                        {
                            SituationCard card27 = new SituationCard();
                            card27.id = i;
                            card27.situation = "A developer has quit. Lose 9 Design Points.";
                            card27.cost.Add(9, "Design");
                            card27.reward.Add(7, "Training");
                            card27.used = false;
                            card27.certifications = "Ruby Certification";
                            card27.diffculty = 3;
                            situationDeck.Add(card27);
                            break;
                        }
                    case 28:
                        {
                            SituationCard card28 = new SituationCard();
                            card28.id = i;
                            card28.situation = "The companies Visual Studio license has expired. Lose 8 Bitcoin.";
                            card28.cost.Add(8, "Bitcoin");
                            card28.reward.Add(6, "Training");
                            card28.used = false;
                            card28.certifications = "React Certification";
                            card28.diffculty = 3;
                            situationDeck.Add(card28);
                            break;
                        }
                    case 29:
                        {
                            SituationCard card29 = new SituationCard();
                            card29.id = i;
                            card29.situation = "The companies JetBrains license has expired. Lose 8 Bitcoin.";
                            card29.cost.Add(8, "Bitcoin");
                            card29.reward.Add(6, "Design");
                            card29.used = false;
                            card29.certifications = "Angular Certification";
                            card29.diffculty = 3;
                            situationDeck.Add(card29);
                            break;
                        }
                    case 30:
                        {
                            SituationCard card30 = new SituationCard();
                            card30.id = i;
                            card30.situation = "A developer is having trouble understanding Swift. Lose 9 Design Points.";
                            card30.cost.Add(9, "Design");
                            card30.reward.Add(8, "Training");
                            card30.used = false;
                            card30.certifications = "Swift Certification";
                            card30.diffculty = 3;
                            situationDeck.Add(card30);
                            break;
                        }
                    case 31:
                        {
                            SituationCard card31 = new SituationCard();
                            card31.id = i;
                            card31.situation = "A developer accidently deleted the customer database. Lose 12 Design Points.";
                            card31.cost.Add(12, "Design");
                            card31.reward.Add(10, "Training");
                            card31.used = false;
                            card31.certifications = "NoSQL Certification";
                            card31.diffculty = 4;
                            situationDeck.Add(card31);
                            break;
                        }
                    case 32:
                        {
                            SituationCard card32 = new SituationCard();
                            card32.id = i;
                            card32.situation = "The customer does not like the product. Lose 12 Training Points.";
                            card32.cost.Add(12, "Training");
                            card32.reward.Add(10, "Design");
                            card32.used = false;
                            card32.certifications = "TypeScript Certification";
                            card32.diffculty = 4;
                            situationDeck.Add(card32);
                            break;
                        }


                }
            }

        }


        public void shuffleDeck() //shuffles the deck of cards. Puts 4 cards at the front of the deck for easy completion.
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

        public void drawCard()
        {
            throw new NotImplementedException();
        }
    }
}


