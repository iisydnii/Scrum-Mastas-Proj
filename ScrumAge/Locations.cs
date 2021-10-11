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
    abstract class Locations
    {
        //String locationName = "";
        int[,] savePlayerList = new int[2, 4];

        //Save the players to location 
        void setLocation(int playerId, int holdDevs)
        {
            //Save to list
            switch (playerId)
            {
                case 1:
                    if (savePlayerList[0, 0] == 0)
                    {
                        savePlayerList[0, 0] = playerId;
                    }
                    savePlayerList[1, 0] = holdDevs;
                    break;
                case 2:
                    if (savePlayerList[0, 1] == 0)
                    {
                        savePlayerList[0, 1] = playerId;
                    }
                    savePlayerList[1, 1] = holdDevs;
                    break;
                case 3:
                    if (savePlayerList[0, 2] == 0)
                    {
                        savePlayerList[0, 2] = playerId;
                    }
                    savePlayerList[1, 2] = holdDevs;
                    break;
                case 4:
                    if (savePlayerList[0, 3] == 0)
                    {
                        savePlayerList[0, 3] = playerId;
                    }
                    savePlayerList[1, 3] = holdDevs;
                    break;
            }
        }

        void returnPlayers(int playerId)
        {
            //Set players devs to 0
            switch (playerId)
            {
                case 1:
                    savePlayerList[1, 0] = 0;
                    break;
                case 2:
                    savePlayerList[1, 1] = 0;
                    break;
                case 3:
                    savePlayerList[1, 2] = 0;
                    break;
                case 4:
                    savePlayerList[1, 3] = 0;
                    break;
            }
        }
    }
}
