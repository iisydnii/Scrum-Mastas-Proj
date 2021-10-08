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

        public int Total { get; set; }
        public bool SnakeEyes { get; set; }


        /// <summary>
        /// This constructor rolls a dice and adds the values of the dice together. 
        /// </summary>
        public Dice()
        {
            var diceValue = 0;
            SnakeEyes = false;


            for (int i = 0; i < 2; i++)
            {
                diceValue = random.Next(1, 6);
                Total += diceValue;
            }


            //Discerns snake eyes
            if (Total == 2)
            {
                SnakeEyes = true;
            }
        }


    }
}
