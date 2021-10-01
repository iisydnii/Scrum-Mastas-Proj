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


namespace ScrumAge
{
    class Dice
    {
        Random random = new Random();


        /// <summary>
        /// This method rolls a dice and adds the values of the dice together. 
        /// </summary>
        /// <returns>A total of all the dice rolls.</returns>
        public int RollDice()
        {
            var diceValue = 0;
            var diceTotal = 0;


            for (int i = 0; i < 2; i++)
            {
                diceValue = random.Next(1, 6);
                diceTotal += diceValue;
            }


            //Discerns snake eyes
            //Snake eyes returns a 0
            if (diceTotal == 2)
            {
                diceTotal = 0;
            }


            return diceTotal;
        }

    }
}
