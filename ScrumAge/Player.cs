/*-------------
Name: Macen Busic
Date created: 09/22/21
File name: Player.cs
Purpose: Create a player
_____________________________________________________________________________
Page Modified
    Piper Floyd, 10/24/21, lines 46 - 55, Added payment method
    Sydni Ward, 11/09/2021 - Add Picture Path

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
        public string pictureFile { get; set; }

        public Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Inventory = new Inventory();
            pictureFile = setImage(id);
        }

        public Player(int id)
        {
            this.Id = id;
            this.Name = "";
            this.Inventory = new Inventory();
            setImage(id);
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

        //Set Player Images
        public string setImage(int id)
        {
            string filename = "";
            //Supply your own images here
            switch (id)
            {
                case 1:
                    filename = @"Images\red.png";
                    break;
                case 2:
                    filename = @"Images\yellow.png";
                    break;
                case 3:
                    filename = @"Images\green.png";
                    break;
                case 4:
                    filename = @"Images\gray.png";
                    break;
            }

            return filename;
        }
    }
}
