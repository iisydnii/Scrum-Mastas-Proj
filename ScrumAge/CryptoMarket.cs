/*
 Page Created 
     File Name: CryptoMarket.cs
     Creator Name: Piper Floyd
     Created Date: 11/07/21
     Purpose: The crypto market location. Calculates bitcoin based on the stock market.
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
    class CryptoMarket : Locations
    {
        private int[,] BootcampPlayerList = new int[2, 4];

        public int[,] getPlayerList()
        {
            return BootcampPlayerList;
        }

        /// <summary>
        /// Calculates bitcoin based on a player's bet stock and bought stock 
        /// </summary>
        public int CalcGold(Player player, int numOfDevs, int betStock, int boughtStock, int stockPrice)
        {
            if (stockPrice == 0)
            {
                stockPrice = 1;
            }
            int calculation_1 = boughtStock * stockPrice;

            stockPrice = calculation_1 / stockPrice;
            int bitcoin_1 = stockPrice * numOfDevs;

            int bitcoin_2 = bitcoin_1 * (-1);

            
            if (betStock > boughtStock)
            {
                player.Inventory.Bitcoin += bitcoin_1;
            }
            else if (betStock <= boughtStock)
            {
                player.Inventory.Bitcoin += bitcoin_2;

            }

            return player.Inventory.Bitcoin;
        }
    }
}
