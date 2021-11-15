/*-------------
Name: Sydni Ward
Date created: 10/11/21
File name: Locations.cs
Purpose: Abstract class for the different locations to inherit 
________________________________________________________________________________
Page Modified
-------------*/
using System;
using System.Collections.Generic;

namespace ScrumAge
{
    class Locations
    {
        public string name = "";
        public int[,] playerList = new int[2, 4];

        public Locations()
        {
            //do nothing
        }

        public void setPlayerList(int[,] PlayerList)
        {
            this.playerList = PlayerList;
        }
        public List<Locations> createList()
        {
            List<Locations> locationList = new List<Locations>()
            {
                new Locations() { name = "HR", playerList = {[0,0]= 1, [0,1] = 2, [0, 2] = 3, [0, 3] = 4,
                                                            [1,0] = 0, [1,1] = 0, [1,2] = 0, [1,3] = 0,} },
                new Locations() { name = "Boot Camp", playerList = {[0,0]= 1, [0,1] = 2, [0, 2] = 3, [0, 3] = 4,
                                                            [1,0] = 0, [1,1] = 0, [1,2] = 0, [1,3] = 0,} },
                new Locations() { name = "White Board", playerList = {[0,0]= 1, [0,1] = 2, [0, 2] = 3, [0, 3] = 4,
                                                            [1,0] = 0, [1,1] = 0, [1,2] = 0, [1,3] = 0,} },
                new Locations() { name = "Crypto Market", playerList = {[0,0]= 1, [0,1] = 2, [0, 2] = 3, [0, 3] = 4,
                                                            [1,0] = 0, [1,1] = 0, [1,2] = 0, [1,3] = 0,} }

            };
            return locationList;
        }

        //Save the players to location 
        public int[,] placeDevs( int playerId, int holdDevs)
        {

            //Save to list
            switch (playerId)
            {
                case 1:
                    if (playerList[0, 0] == 0)
                    {
                        playerList[0, 0] = playerId;
                    }
                    playerList[1, 0] = holdDevs;
                    break;
                case 2:
                    if (playerList[0, 1] == 0)
                    {
                        playerList[0, 1] = playerId;
                    }
                    playerList[1, 1] = holdDevs;
                    break;
                case 3:
                    if (playerList[0, 2] == 0)
                    {
                        playerList[0, 2] = playerId;
                    }
                    playerList[1, 2] = holdDevs;
                    break;
                case 4:
                    if (playerList[0, 3] == 0)
                    {
                        playerList[0, 3] = playerId;
                    }
                    playerList[1, 3] = holdDevs;
                    break;
            }
            return playerList;
        }
       
        public int[,] returnPlayers(String location, int playerId)
        {
            //Set players devs to 0
            switch (playerId)
            {
                case 1:
                    playerList[1, 0] = 0;
                    break;
                case 2:
                    playerList[1, 1] = 0;
                    break;
                case 3:
                    playerList[1, 2] = 0;
                    break;
                case 4:
                    playerList[1, 3] = 0;
                    break;
            }
            return playerList;
        }

        public String printTestResults()
        {
            string output = "";
            for (int i = 0; i <= 3; i++)
            {
                output += "\nPlayer" + playerList[0, i] + ", number of developers placed " + playerList[1, i];
            }

            return output;
        }
    }
}
