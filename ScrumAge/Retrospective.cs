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
        List<Player> defaltList;
        List<Player> manipulatedList; 
        int turn = 0;
        //Player currentPlayer, List<Player> PlayerList
        public Retrospective()
        {
            InitializeComponent();
            //this.currentPlayer = currentPlayer;
           //this.PlayerList = PlayerList;
        }
        public void setLabels()
        {
            this.label1.Text =  currentPlayer.Name;
            this.labelTraining.Text = currentPlayer.Inventory.TrainingPoints.ToString();
            this.labelDesign.Text = currentPlayer.Inventory.DesignPoints.ToString();
            this.labelDevelopers.Text = currentPlayer.Inventory.Developers.ToString();
            this.labelBitcoin.Text = currentPlayer.Inventory.Bitcoin.ToString();
            this.labelDevelopment.Text = currentPlayer.Inventory.DevelopmentPoints.ToString();
            //this.labelCertifications.Text = currentPlayer.Inventory.Certifications.Certification.Count().ToString();
        }
        public void showRetrospective()
        {
            Show();
        }
       
        public void calcRetrospective(List<Player> defaltList, List<Player> manipulatedList, int turn)
        {
           
            // check if player got more training, design, or development points 
            foreach(var player in defaltList)
            {
                if(player.Id == turn -1)
                {
                    // set current player
                    this.currentPlayer = player;

                    //math

                    setLabels();

                    // check for the same ID for the player
                    // look at the inventoty

                }
                
            }
          

        }

      
        private void next_button_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn >= manipulatedList.Count)
            {
                calcRetrospective(defaltList, manipulatedList, turn);
            }
            else
            {
                this.Close();
            }

        }
    }
}
