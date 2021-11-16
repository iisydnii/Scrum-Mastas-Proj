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

        public int[,] getPlayerList()
        {
            return HRPlayerList;
        }

        public int chargePlayerSalary()
        {
            return 50;
        }
    }
}
