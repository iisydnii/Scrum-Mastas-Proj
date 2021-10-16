/*-------------
Name: Garrett Dyer
Date created: 09/22/21
Date Modified: 10/16/21
File name: SituationCard
Purpose: Template for creating a situation card
________________________________________________________________________________
Page Modified
        Garrett Dyer, 10/16/21, removed properties.
-------------*/

// --Austin wuz here !!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class SituationCard : Card
    {
        /* Creating properties for the situtation cards*/
        public string situation { get; set; }
        public string certifications { get; set; }
        public int diffculty { get; set; }

        /* Creating constructor for situation cards */
        public SituationCard(int id, string situation, Dictionary<int, string> cost, Dictionary<int, string> reward, bool used, string certifications, int diffculty)
        {
            this.id = id;
            this.situation = situation;
            this.cost = cost;
            this.reward = reward;
            this.used = used;
            this.certifications = certifications;
            this.diffculty = diffculty;
        }

        /* Creating a blank constructor for situation cards*/
        public SituationCard()
        {
            cost = new Dictionary<int, string>();
            reward = new Dictionary<int, string>();
        }
    }
}
