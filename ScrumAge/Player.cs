/*-------------
Name: Macen Busic
Date created: 09/22/21
File name: Player.cs
Purpose: Create a player
_____________________________________________________________________________
Page Modified
    Piper Floyd, 10/24/21, lines 46 - 55, Added payment method

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    public class Player
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Inventory Inventory { get; set; }

        public Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Inventory = new Inventory();
        }

        public Player(int id)
        {
            this.Id = id;
            this.Name = "";
            this.Inventory = new Inventory();
        }

        /// <summary>
        /// Player pays and inventory reflects the update
        /// </summary>
        /// <param name="toPay"></param>
        public void Pay(int toPay)
        {
            if (Inventory.Bitcoin > 0)
            {
                Inventory.Bitcoin -= toPay;
            }
           
        }


    }
}
