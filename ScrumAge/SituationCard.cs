/*-------------
Name: Garrett Dyer
Date created: 09/22/21
File name: SituationCard
Purpose: Template for creating a situation card
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class SituationCard
    {
        /* Creating properties for the situtation cards*/
        public int id { get; set; }
        public string situation { get; set; }
        public Dictionary<int, string> cost { get; set; } /* int is the cost, string the resource used*/
        public Dictionary<int, string> reward { get; set; } /* int is the amount given, string the resource given*/
        public bool used { get; set; }

        /* Creating constructor for situation cards*/
        public SituationCard(int id, string situation, Dictionary<int, string> cost, Dictionary<int, string> reward, bool used)
        {
             this.id = id;
            this.situation = situation;
            this.cost = cost;
            this.reward = reward;
            this.used = used;
        }

        

    }
}
