using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class HRLocation : Locations
    {
        private int[,] HRPlayerList = new int[2, 4];

        public Player player1;
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

        public void AddDevs(int playerId, int numOfDevs)
        {
            placeDevs(playerId, numOfDevs);
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
    }
}
