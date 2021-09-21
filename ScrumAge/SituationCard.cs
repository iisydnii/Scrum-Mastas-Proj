/*-------------
Name: Sydni Ward
Date created: 09/20/21
File name: SituationCard
Purpose: Template for creating a situation card
-------------*/
using System;

namespace ScrumAge
{
    public class SituationCard
    {
        /* Create rules for the inputs*/
        public int id { get; set; }
        public string situation { get; set; }
        public Array cost { get; set; }
        public Array reward { get; set; }
        public int used { get; set; }

        public SituationCard(int id, string situation, Array cost,
            Array reward, int used)
        {
            this.id = id;
            this.situation = situation;
            this.cost = cost;
            this.reward = reward;
            this.used = used;
        }
    }
}