/*-------------
Name: Garrett Dyer
Date created: 10/16/21
Last Updated: 10/16/21
File name: Card
Purpose: Creates the Card Parent class.
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class Card
    {
        /* Creating properties for the situtation cards adn project tiles*/
        public int id { get; set; }
        public Dictionary<int, string> cost { get; set; }/* int is the cost, string the resource used*/
        public Dictionary<int, string> reward { get; set; } /* int is the amount given, string the resource given*/
        public bool used { get; set; }
    }
}
