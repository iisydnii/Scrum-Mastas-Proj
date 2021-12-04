/*
 Page Created 
     File Name: Winners_Losers.cs
     Creator Name: Piper Floyd
     Created Date: 11/07/21
     Purpose: Scoreboard of winners and losers
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
    public partial class Winners_Losers : Form
    {
        Game game = new Game();
        public Winners_Losers()
        {
            InitializeComponent();
        }

        public void checkForEndOFGame(SituationDeck situationDeck, ProjectDeck projectDeck)
        {
            if(situationDeck == null || projectDeck == null)
            {
                game.endOfGame = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Game.QuitGame();
            this.Close();
        }
    }
}
