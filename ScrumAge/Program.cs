/*-------------
Name: ScrumAge
Date created: 09/13/21
File name: Program
Purpose:
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumAge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test -- Macen
            SelectPlayersForm playersForm = new SelectPlayersForm();
            Application.Run(playersForm);
            var list = playersForm.GetPlayers();
            ///Test
            Application.Run(new Placement_Board());

            // Test of Situation Deck --Austin
            //SituationDeck situationDeck = new SituationDeck();
            //situationDeck.displayCards();
            //situationDeck.shuffleDeck();
            //situationDeck.test();
            //situationDeck.displayCard();

            // Test of Dice Class --Austin
            //Dice dice = new Dice();

            //Console.WriteLine(dice.RollDice());

        }
    }
}
