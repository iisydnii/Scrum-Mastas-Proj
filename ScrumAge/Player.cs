using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class Player
    {
/*-------------
Name: Macen Busic
Date created: 09/22/21
File name: Player.cs
Purpose: Create a player
-------------*/
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
    }
}
