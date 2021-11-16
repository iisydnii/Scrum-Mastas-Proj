/*
 Page Created 
     File Name: BootCamp
     Creator Name: Garrett Dyer
     Created Date: 10/18/21
     Purpose: Calculate the amount of trainging points to give the player.
________________________________________________________________________________
Page Modified
    Name, date, line change, what is the change
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class Bootcamp : Locations
    {
       
        private int[,] BootcampPlayerList = new int[2, 4];

        public int[,] getPlayerList()
        {
            return BootcampPlayerList;
        }

        //calculates the amount of training points to give the player
        public int trainingPointCalc(Player player, int numOfDevs, int roll) //rename later
        {
            int trainingPoints = player.Inventory.TrainingPoints;
            int calculation = numOfDevs * roll;

            trainingPoints += calculation;

            return trainingPoints;
        }

        
    }
}
