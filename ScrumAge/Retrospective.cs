/*
 Page Created:
     File Name: Retrospective
     Creator Name: Nataliya Chibizova
     Created Date: 11/10/2021
     Purpose: Retrospective Phase
________________________________________________________________________________
Page Modified:
    
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
    public partial class Retrospective : Form
    {
        Player currentPlayer;
        public Retrospective()
        {
            InitializeComponent();
        }

        private void playerName_Click(object sender, EventArgs e)
        {
            label1.Text = currentPlayer.Name;
        }

        private void groupTheGood_Enter(object sender, EventArgs e)
        {
            // check if player got more training, design, or development points 
            // or got more bitcoin, or developers

        }

        private void groupTheBad_Enter(object sender, EventArgs e)
        {
            // check if player lost  training, design, or development points 
            // or lost bitcoin, or developers
        }

        private void groupTheUgly_Enter(object sender, EventArgs e)
        {
            // check if the player lost the game
            // otherwise, display "Good luck in the next sprint"
            if (currentPlayer.Inventory.Bitcoin <=0)
            {
                theUglyMessage.Text = "Sorry, looks like you losing the game. Check your strategy!";
            }
            else
            {
                theUglyMessage.Text = "Good luck in the next sprint";
            }

        }
    }
}
