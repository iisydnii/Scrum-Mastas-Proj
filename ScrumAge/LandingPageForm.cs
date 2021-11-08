/*
 Page Created 
     File Name: LandingPageForm
     Creator Name: Nataliya Chibizova
     Created Date: 10/04/2021
     Purpose: Display the landing page of the game to player
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
    /// Display the landing page og the game to user
    /// </summary>
    public partial class LandingPageForm : Form
    {
        /// <summary>
        /// Initialize the Component
        /// </summary>
        public LandingPageForm()
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
            ////Open the player select form
            //SelectPlayersForm playersForm = new SelectPlayersForm(); -- Austin -- Converted to game class
            //playersForm.ShowDialog();
            Game.DisplaySetPlayersForm();
            this.Close();
        }

        /// <summary>
        /// this button redirect player to the RulesForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rules_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //RulesForm rules = new RulesForm();
            //rules.Show();
            Game.DisplayRulesForm();
        }

        private void LandingPageForm_Load(object sender, EventArgs e)
        {

        }



    }// end of LandingPageForm
}
