﻿/*
 Page Created 
     File Name: RulesForm
     Creator Name: Nataliya Chibizova
     Created Date: 10/04/2021
     Purpose: Display the rules of the game to player
________________________________________________________________________________
Page Modified
    Name:
    Date:
    Line change:
    What is the change:

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumAge
{
    /// <summary>
    /// display the rules, click Start or Go Back button
    /// </summary>
    public partial class RulesForm : Form
    {
        /// <summary>
        /// Initialize the Component
        /// </summary>
        public RulesForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this button redirects player to the SelectPlayersForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Open the player select form
            SelectPlayersForm playersForm = new SelectPlayersForm();
            playersForm.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// this button redirects player back to the LandingPageForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPageForm ld = new LandingPageForm();
            ld.Show();
        }
    }// end of RulesForm
}