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
        public Player player1 = new Player(1,"jef");
        //remove = new player(1,"jef") after testing. the player obj's will be passed when we can test
        public Player player2;
        public Player player3;
        public Player player4;



        public void SetPlayerList(int[,] playerList)
        {
            this.BootcampPlayerList = playerList;
        }

        public int[,] getPlayerList()
        {
            return BootcampPlayerList;
        }

        //calculates the amount of training points to give the player
        public void trainingPointCalc(int playerId, int numOfDevs) //rename later
        {
            var tempRoll = 5; //change to dice result 
            var calculation = numOfDevs * tempRoll;

            if (playerId == 1)
            {
                player1.Inventory.TrainingPoints += calculation;
            }
            if (playerId == 2)
            {
                player2.Inventory.TrainingPoints += calculation;
            }
            if (playerId == 3)
            {
                player3.Inventory.TrainingPoints += calculation;
            }
            if(playerId == 4)
            {
                player4.Inventory.TrainingPoints += calculation;
            }
            //may need loop if the placement board method calcs placement of all players at once.      
            placeDevs(playerId, numOfDevs);
        }
    }
}
