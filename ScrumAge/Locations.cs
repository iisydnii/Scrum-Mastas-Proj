/*-------------
Name: Sydni Ward
Date created: 10/11/21
File name: Locations.cs
Purpose: Abstract class for the different locations to inherit 
________________________________________________________________________________
Page Modified
-------------*/
using System;

namespace ScrumAge
{
    class Locations
    {
        int[,] PlayerList = new int[2, 4];

        
        public void setPlayerList(int[,] PlayerList)
        {
            this.PlayerList = PlayerList;
        }

        //Save the players to location 
        public int[,] placeDevs( int playerId, int holdDevs)
        {

            //Save to list
            switch (playerId)
            {
                case 1:
                    if (PlayerList[0, 0] == 0)
                    {
                        PlayerList[0, 0] = playerId;
                    }
                    PlayerList[1, 0] = holdDevs;
                    break;
                case 2:
                    if (PlayerList[0, 1] == 0)
                    {
                        PlayerList[0, 1] = playerId;
                    }
                    PlayerList[1, 1] = holdDevs;
                    break;
                case 3:
                    if (PlayerList[0, 2] == 0)
                    {
                        PlayerList[0, 2] = playerId;
                    }
                    PlayerList[1, 2] = holdDevs;
                    break;
                case 4:
                    if (PlayerList[0, 3] == 0)
                    {
                        PlayerList[0, 3] = playerId;
                    }
                    PlayerList[1, 3] = holdDevs;
                    break;
            }
            return PlayerList;
        }
       
        public int[,] returnPlayers(String location, int playerId)
        {
            //Set players devs to 0
            switch (playerId)
            {
                case 1:
                    PlayerList[1, 0] = 0;
                    break;
                case 2:
                    PlayerList[1, 1] = 0;
                    break;
                case 3:
                    PlayerList[1, 2] = 0;
                    break;
                case 4:
                    PlayerList[1, 3] = 0;
                    break;
            }
            return PlayerList;
        }

        public String printTestResults()
        {
            string output = "";
            for (int i = 0; i <= 3; i++)
            {
                output += "\nPlayer" + PlayerList[0, i] + ", number of developers placed " + PlayerList[1, i];
            }

            return output;
        }
    }
}
