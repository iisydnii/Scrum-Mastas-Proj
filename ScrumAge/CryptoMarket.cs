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

        public Player player1 = new Player(1, "Jane");
        //TODO: remove = new player(1,"Jane") after testing.
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



        /// <summary>
        /// Calculates bitcoin based on a player's bet stock and bought stock 
        /// </summary>
        /// <param name="playerId">The player's id</param>
        /// <param name="numOfDevs">The number of developers a person places</param>
        

        //Change to below method header once locations are implemented 
        //public void goldCalc(int playerId, int numOfDevs, int betStock, int boughtStock) 

        public void CalcGold(int playerId, int numOfDevs) 
        {
<<<<<<< Updated upstream
            //Change to first dice roll
            int betStock = 3;

            //Change to second dice roll
            int boughtStock = 6;
            var stockPrice = 1;

            var calculation_1 = boughtStock * stockPrice;
=======
            if (stockPrice == 0)
            {
                stockPrice = 1;
            }
            int calculation_1 = boughtStock * stockPrice;
>>>>>>> Stashed changes
            stockPrice = calculation_1 / stockPrice;
            var bitcoin_1 = stockPrice * numOfDevs;

            var bitcoin_2 = bitcoin_1 * (-1);

            if (playerId == 1)
            {
                if (betStock > boughtStock)
                {
                    player1.Inventory.Bitcoin += bitcoin_1;
                }
                else if (betStock <= boughtStock)
                {
                    player1.Inventory.Bitcoin += bitcoin_2;

                }

            }
            if (playerId == 2)
            {
                if (betStock > boughtStock)
                {
                    player2.Inventory.Bitcoin += bitcoin_1;
                }
                else if (betStock <= boughtStock)
                {
                    player2.Inventory.Bitcoin += bitcoin_2;

                }
            }
            if (playerId == 3)
            {
                if (betStock > boughtStock)
                {
                    player3.Inventory.Bitcoin += bitcoin_1;
                }
                else if (betStock <= boughtStock)
                {
                    player3.Inventory.Bitcoin += bitcoin_2;

                }
            }
            if (playerId == 4)
            {
                if (betStock > boughtStock)
                {
                    player4.Inventory.Bitcoin += bitcoin_1;
                }
                else if (betStock <= boughtStock)
                {
                    player4.Inventory.Bitcoin += bitcoin_2;

                }
            }


            //may need loop if the placement board method calcs placement of all players at once.      
            placeDevs(playerId, numOfDevs);
        }
    }
}
