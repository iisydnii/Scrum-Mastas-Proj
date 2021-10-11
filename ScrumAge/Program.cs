/*-------------
Name: ScrumAge
Date created: 09/13/21
File name: Program
Purpose: this is the main entry point for the application
         Used for testings purposes.
________________________________________________________________________________
Page Modified
    Name: Nataliya Chibizova
    Date: 10/04
    Line change: 32
    What is the change: Form1 deleted, LandingPageForm added

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
            Application.Run(new LandingPageForm());

            ///Test
            // Application.Run(new Placement_Board());

            // Test of Situation Deck --Austin
            //SituationDeck situationDeck = new SituationDeck();
            //situationDeck.displayCards();
            //situationDeck.shuffleDeck();
            //situationDeck.test();
            //situationDeck.displayCard();

            // Test of Dice Class --Austin
            //Dice dice = new Dice();

            //Console.WriteLine(dice.RollDice());

            //Application.Run(new DiceForm());

            //Testing Abstract class
            TestLocations test = new TestLocations();
            
            test.setLocation(1, 3);
            test.setLocation(2, 1);
            test.setLocation(3, 2);

            Console.WriteLine(test.printTestResults());

            test.returnPlayers(1);
            
            Console.WriteLine(test.printTestResults());

        } // end of main
    }//end of class
}
