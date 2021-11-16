/*
 Page Created 
     File Name: Dice.cs
     Creator Name: Piper Floyd
     Created Date: 09/20/21
     Purpose: Acts as a dice roll. Returns a numeric total of the rolled dice
________________________________________________________________________________
Page Modified
    Name, date, line change, what is the change
    Piper Floyd, 10/04/21, lines 33-52, Added the constructor and removed RollDice()

*/


using System;
using System.Collections.Generic;
using System.Text;


namespace ScrumAge
{
    class Dice
    {
        Random random = new Random();
        public int DiceRoll_1 { get; set; }
        public int DiceRoll_2 { get; set; }
        public bool SnakeEyes { get; set; }


        /// <summary>
        /// This constructor rolls a dice and adds the values of the dice together. 
        /// </summary>
        public Dice()
        {
            // do nothing
        }

        public int rollDice()
        {
            var diceValue = 0;
            SnakeEyes = false;


            DiceRoll_1 = random.Next(1, 6);
            DiceRoll_2 = random.Next(1, 6);

            diceValue = DiceRoll_1 + DiceRoll_2;


            //Discerns snake eyes
            if (diceValue == 2)
            {
                SnakeEyes = true;
            }

            return diceValue;
        }
    }
}
