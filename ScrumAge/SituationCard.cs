/*-------------
Name: ScrumAge
Date created: 09/18/21
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
        public int payment;
        public int points;
        public int cost;

       
        public int GetPayment()
        {
            return payment;
        }

        public int GetPoints()
        {
            return points;
        }

        public int GetCost()
        {
            return cost;
        }

        public void SetPayment(int payment_)
        {
            payment = payment_;
        }

        public void SetPoints(int points_)
        {
            points = points_;
        }
        public void SetCost(int cost_)
        {
            cost = cost_;
        }

    }
}
