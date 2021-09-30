/*-------------
Name: Garrett Dyer
Date created: 09/29/21
Last Updated: 9/30/21
File name: SituationDeck
Purpose: Adds situation cards to the situation deck
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
        public HashSet<object> situationDeck { get; set; }

        /* Creating constructor for situation deck */
        public SituationDeck()
        {
            situationDeck = new HashSet<object>();
        }

        /* Creates situation cards and adds them to the deck */
        public void addCard()
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
                            card1.situation = "You are having problems getting Github to work. Lose 2 Traingng points.";
                            card1.cost.Add(2, "Training");
                            card1.reward.Add(10, "Bitcoin");
                            card1.used = false;
                            card1.certifications = "Github certified";
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
                            card2.certifications = "Work from home";
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
                            card3.certifications = "Coffee Break Gone Wrong";
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
                            card4.certifications = "Homework";
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
                            card5.certifications = "Firewalled";
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
                            card6.certifications = "Stay at home parent";
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
                            card8.certifications = "Party Time";
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
                            card9.certifications = "Juiced up";
                            situationDeck.Add(card9);
                            break;
                        }
                    case 10:
                        {
                            SituationCard card10 = new SituationCard();
                            card10.id = i;
                            card10.situation = "You left your work badge at home. Lose 3 Bitcoin";
                            card10.cost.Add(3, "Bitcoin");
                            card10.reward.Add(3, "Design");
                            card10.used = false;
                            card10.certifications = "Commuter";
                            situationDeck.Add(card10);
                            break;
                        }


                }
            }

            Console.WriteLine(situationDeck.Count());
        }
    }
}
