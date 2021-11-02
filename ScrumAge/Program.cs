﻿/*-------------
Name: ScrumAge
Date created: 09/13/21
File name: Program
Purpose: this is the main entry point for the application
         Used for testings purposes.
________________________________________________________________________________
Page Modified
    Name: Nataliya Chibizova
    Date: 10/04
    Line change: 32
    What is the change: Form1 deleted, LandingPageForm added

-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumAge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Game.StartGame();

        } // end of main
    }//end of class
}
