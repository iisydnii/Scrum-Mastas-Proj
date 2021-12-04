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
<<<<<<< Updated upstream
=======
            this.defaultList = defaultList;
            this.manipulatedList = manipulatedList;
            this.turn = turn;



            //Set first player's labels
            this.label1.Text = defaultList[0].Name;
            this.labelTraining.Text = defaultList[0].Inventory.TrainingPoints.ToString();
            this.labelDesign.Text = defaultList[0].Inventory.DesignPoints.ToString();
            this.labelDevelopers.Text = defaultList[0].Inventory.Developers.ToString();
            this.labelBitcoin.Text = defaultList[0].Inventory.Bitcoin.ToString();
            this.labelDevelopment.Text = defaultList[0].Inventory.DevelopmentPoints.ToString();
            this.labelCertifications.Text = manipulatedList[0].Inventory.Certifications.CertificationsList.Count().ToString();
            calcRetrospective();
>>>>>>> Stashed changes
        }

        private void playerName_Click(object sender, EventArgs e)
        {
            label1.Text = currentPlayer.Name;
        }
<<<<<<< Updated upstream

        private void groupTheGood_Enter(object sender, EventArgs e)
=======
       
        public void calcRetrospective()
        {
            int bitcoin = 5, training;
            // check if player got more training, design, or development points 
            foreach(var player in defaultList)
            {
                foreach (var mPlayer in manipulatedList)
                {
                    if (player.Id == turn + 1)
                    {
                        // set current player
                        this.currentPlayer = player;

                        //math
                        //bitcoin = mPlayer.Inventory.TrainingPoints - player.Inventory.TrainingPoints;
                        training = mPlayer.Inventory.TrainingPoints - player.Inventory.TrainingPoints; 
                        //setLabels();

                        // check for the same ID for the player
                        // look at the inventoty

                    } 
                }

            }
            if (bitcoin > 0)
            {
                this.labelGood.Text = $"Gain + {bitcoin} bitcon";
                this.labelBad.Text = " ";
                this.labelUgly.Text = " ";

            }

        }

      
        private void next_button_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
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
