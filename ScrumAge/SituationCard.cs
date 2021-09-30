/*-------------
Name: Garrett Dyer
Date created: 09/22/21
Last Updated: 9/30/21
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
        public int id { get; set; }
        public string situation { get; set; }
        public Dictionary<int, string> cost { get; set; }
        public Dictionary<int, string> reward { get; set; }
        public bool used { get; set; }
        public string certifications { get; set; }

        /* Creating constructor for situation cards */
        public SituationCard(int id, string situation, Dictionary<int, string> cost, Dictionary<int, string> reward, bool used, string certifications)
        {
            this.id = id;
            this.situation = situation;
            this.cost = cost;
            this.reward = reward;
            this.used = used;
            this.certifications = certifications;
        }

        /* Creating constructor for situation cards */
        public SituationCard()
        {
            cost = new Dictionary<int, string>();
            reward = new Dictionary<int, string>();
        }
    }
}
