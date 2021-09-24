/*-------------
Name: ScrumAge
Author: Piper Floyd 
Date created: 09/20/21
File name: Dice
Purpose: Acts as a dice roll. Returns a numeric total of the rolled dice
-------------*/

using System;
using System.Collections.Generic;
using System.Text;


namespace ScrumGameTemp
{
    class Dice
    {

        //Added these properties because I (Piper Floyd) was unsure
        //if the dice was always going to be 2 6-sided or not
        public int Sides { get; set; }
        public int Rolls { get; set; }

        Random random = new Random();


        public Dice()
        {
            Sides = 6;
            Rolls = 2;

        }

        /// <summary>
        /// This method rolls a dice and adds the values of the dice together. 
        /// </summary>
        /// <returns>A total of all the dice rolls.</returns>
        public int RollDice()
        {
            var diceValue = 0;
            var diceTotal = 0;

            for (int i = 0; i < Rolls; i++)
            {

                //If dice will always be two 6-sided, then we can change Sides to 6
                diceValue = random.Next(1, Sides);
                diceTotal += diceValue;
            }

            return diceTotal;
        }
    }
}
