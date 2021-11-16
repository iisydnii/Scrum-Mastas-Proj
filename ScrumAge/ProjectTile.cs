/*-------------
Name: Garrett Dyer
Date created: 10/16/21
Last Updated: 10/16/21
File name: ProjectTile
Purpose: Template for creating the project tiles.  
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fixed some pascal casing issues here --Austin
//Make sure in the future to always capitalize Pascal Case Properties and Methods :: like MethodName or PropertyName

namespace ScrumAge
{
    public class ProjectTile : Card
    {
        public string Description { get; set; }

        public ProjectTile(int id, string description, Dictionary<int, string> cost, Dictionary<int, string> reward, bool used)
        {
            this.id = id;
            this.Description = description;
            this.cost = cost;
            this.reward = reward;
            this.used = used;
        }

        public ProjectTile()
        {
            cost = new Dictionary<int, string>();
            reward = new Dictionary<int, string>();
        }
    }
}
