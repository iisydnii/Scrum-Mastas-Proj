using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    class Certifications
    {
/*-------------
Name: Macen Busic
Date created: 10/01/21
File name: Certifications.cs
Purpose: Create and update
Players list of certifications
-------------*/
        public string Certification { get; set; }
        public List<string> CertificationsList { get; set; }

        public Certifications()
        {
            CertificationsList = new List<string>();
        }

        public void AddCertification(string certification)
        {
            CertificationsList.Add(certification);
        }
    }
}
