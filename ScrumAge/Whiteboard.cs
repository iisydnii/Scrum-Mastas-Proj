/*
 Page Created 
     File Name: Whiteboard
     Creator Name: Nataliya Chibizova
     Created Date: 10/21/21
     Purpose: Calculate the design  points.
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
    class Whiteboard : Locations
    {
        private int[,] WhiteboardPlayerList = new int[2, 4];
        
        public Player player1 = new Player(1, "Jane");
        //TODO: remove = new player(1,"Jane") after testing.
        public Player player2;
        public Player player3;
        public Player player4;
        

        public void SetPlayerList(int[,] playerList)
        {
            this.WhiteboardPlayerList = playerList;
        }


        public int[,] GetPlayerList()
        {
            return WhiteboardPlayerList;
        }


        //calculates design points by rolling the dice and multiply by the number by the number of developers on the location
        public void DesignPointsCalc(int playerId, int numOfDevs)
        {
            var tempRoll = 3; // TODO: change it to the Dice later
            var calculation = numOfDevs * tempRoll;

            if (playerId == 1)
            {
                player1.Inventory.DesignPoints += calculation;
            }
            if (playerId == 2)
            {
                player2.Inventory.DesignPoints += calculation;
            }
            if (playerId == 3)
            {
                player3.Inventory.DesignPoints += calculation;
            }
            if (playerId == 4)
            {
                player4.Inventory.DesignPoints += calculation;
            }
            
            placeDevs(playerId, numOfDevs);
        }
    }
}
