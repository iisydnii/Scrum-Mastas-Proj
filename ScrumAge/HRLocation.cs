using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class HRLocation
    {
        private int[,] HRPlayerList = new int[2, 4];

        public Player player1 = new Player(1, "John");
        public Player player2;
        public Player player3;
        public Player player4;

        public void SetPlayerList(int[,] playerList)
        {
            this.HRPlayerList = playerList;
        }

        public int[,] GetPlayerList()
        {
            return HRPlayerList;
        }

        public void AddDevs(int playerId)
        {
            if (playerId == 1)
            {
                player1.Inventory.Developers++;
                player1.Inventory.Bitcoin -= 50;
            }
            else if (playerId == 2)
            {
                player2.Inventory.Developers++;
                player2.Inventory.Bitcoin -= 50;
            }
            else if (playerId == 3)
            {
                player3.Inventory.Developers++;
                player3.Inventory.Bitcoin -= 50;
            }
            else
            {
                player4.Inventory.Developers++;
                player4.Inventory.Bitcoin -= 50;
            }
        }

        //Save the players to location 
        public int[,] placeDevs(int playerId, int holdDevs)
        {

            //Save to list
            switch (playerId)
            {
                case 1:
                    if (HRPlayerList[0, 0] == 0)
                    {
                        HRPlayerList[0, 0] = playerId;
                    }
                    HRPlayerList[1, 0] = holdDevs;
                    break;
                case 2:
                    if (HRPlayerList[0, 1] == 0)
                    {
                        HRPlayerList[0, 1] = playerId;
                    }
                    HRPlayerList[1, 1] = holdDevs;
                    break;
                case 3:
                    if (HRPlayerList[0, 2] == 0)
                    {
                        HRPlayerList[0, 2] = playerId;
                    }
                    HRPlayerList[1, 2] = holdDevs;
                    break;
                case 4:
                    if (HRPlayerList[0, 3] == 0)
                    {
                        HRPlayerList[0, 3] = playerId;
                    }
                    HRPlayerList[1, 3] = holdDevs;
                    break;
            }
            return HRPlayerList;
        }

        public int[,] returnPlayers(String location, int playerId)
        {
            //Set players devs to 0
            switch (playerId)
            {
                case 1:
                    HRPlayerList[1, 0] = 0;
                    break;
                case 2:
                    HRPlayerList[1, 1] = 0;
                    break;
                case 3:
                    HRPlayerList[1, 2] = 0;
                    break;
                case 4:
                    HRPlayerList[1, 3] = 0;
                    break;
            }
            return HRPlayerList;
        }

        public String printTestResults()
        {
            string output = "";
            for (int i = 0; i <= 3; i++)
            {

                if (HRPlayerList[0, i] == 1)

                    output += "\nPlayer" + HRPlayerList[0, i] + ", number of developers placed " + HRPlayerList[1, i] + "bitcoin left: " + player1.Inventory.Bitcoin + "Total Devs on the player has: " + player1.Inventory.Developers;
            }

            return output;
        }

    }
}
