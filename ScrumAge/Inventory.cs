using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
/*-------------
Name: Macen Busic
Date created: 10/01/21
File name: Inventory.cs
Purpose: Create and update
Player Inventory
-------------*/
    public class Inventory
    {
        public int Bitcoin { get; set; }
        public int TrainingPoints { get; set; }
        public int DevelopmentPoints { get; set; }
        public int DesignPoints { get; set; }
        public int Developers { get; set; } 
        public Certifications Certifications { get; set; }
       
        public Inventory()
        {
            this.Bitcoin = 0;
            this.TrainingPoints = 12;
            this.DevelopmentPoints = 0;
            this.DesignPoints = 0;
            Developers = 3;
            Certifications = new Certifications();
        }



   
    }
}
