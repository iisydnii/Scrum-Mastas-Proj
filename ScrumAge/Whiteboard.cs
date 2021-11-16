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

        public Player player1;
        public Player player2;
        public Player player3;
        public Player player4;
        

        public void SetPlayerList(int[,] playerList)
        {
            this.WhiteboardPlayerList = playerList;
        }


        public int[,] getPlayerList()
        {
            return WhiteboardPlayerList;
        }


        //calculates design points by rolling the dice and multiply by the number by the number of developers on the location
        public int DesignPointsCalc(Player player, int numOfDevs, int roll)
        {
            int DesignPoints = player.Inventory.DesignPoints;
            int calculation = numOfDevs * roll;

            DesignPoints += calculation;

            return DesignPoints;
        }
    }
}
