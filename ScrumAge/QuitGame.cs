/*
 Page Created 
     File Name: Dice.cs
     Creator Name: Piper Floyd
     Created Date: 11/07/21
     Purpose: Confirmation form for quitting game. 
________________________________________________________________________________
Page Modified
    Name, date, line change, what is the change

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

    public partial class QuitGame : Form
    {
        public QuitGame()
        {
            InitializeComponent();
        }

        //No, continue playing
        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }


        //Yes, Quit Game
        private void start_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.DisplayWinners_Losers();


            this.Visible = false;
            //this.Close();
        
        }
    }
}
