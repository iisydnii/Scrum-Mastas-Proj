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
        List<Player> defaultList;
        List<Player> manipulatedList;
        int turn;
        public Retrospective(List<Player> defaultList, List<Player> manipulatedList, int turn)
        {
            InitializeComponent();

            this.defaultList = defaultList;
            this.manipulatedList = manipulatedList;
            this.turn = turn;
            this.currentPlayer = manipulatedList[turn];
            setLabels();
            calcRetrospective();
            Show();
        }

        private void setLabels() 
        { 
            this.label1.Text =  currentPlayer.Name;
            this.labelTraining.Text = defaultList[currentPlayer.Id].Inventory.TrainingPoints.ToString();
            this.labelDesign.Text = defaultList[currentPlayer.Id].Inventory.DesignPoints.ToString();
            this.labelDevelopers.Text = defaultList[currentPlayer.Id].Inventory.Developers.ToString();
            this.labelBitcoin.Text = defaultList[currentPlayer.Id].Inventory.Bitcoin.ToString();
            this.labelDevelopment.Text = defaultList[currentPlayer.Id].Inventory.DevelopmentPoints.ToString();
        }
       
        public void calcRetrospective()
        {

            // set current player
            Player Mplayer = manipulatedList[turn];
            Player Dplayer = defaultList[turn];

                //Math

            //Devs
            int hold = 0;
                hold = Dplayer.Inventory.Developers - Mplayer.Inventory.Developers;
                //loss
                if (Dplayer.Inventory.Developers < Mplayer.Inventory.Developers)
                {
                    this.good.Text += "Gain " + hold + " Developers!\n";
                }

                //Training
                hold = Dplayer.Inventory.TrainingPoints - Mplayer.Inventory.TrainingPoints;
                //loss
                if (Dplayer.Inventory.TrainingPoints > Mplayer.Inventory.TrainingPoints)
                {
                    this.bad.Text += "Lost " + Math.Abs(hold) + "Training Points\n";
                }
                //gain
                else if (Dplayer.Inventory.TrainingPoints < Mplayer.Inventory.TrainingPoints)
                {
                    this.good.Text += "Gain " + hold + " Training Points!\n";
                }

                //Design
                hold = Dplayer.Inventory.DesignPoints - Mplayer.Inventory.DesignPoints;
                //loss
                if (Dplayer.Inventory.DesignPoints > Mplayer.Inventory.DesignPoints)
                {
                    this.bad.Text += "Lost " + Math.Abs(hold) + " Design Points\n";
                }
                //gain
                else if (Dplayer.Inventory.DesignPoints < Mplayer.Inventory.DesignPoints)
                {
                    this.good.Text += "Gain " + hold + " Design Points!\n";
                }

                //Bitcoin
                hold = Dplayer.Inventory.Bitcoin - Mplayer.Inventory.Bitcoin;
                //loss
                if (Dplayer.Inventory.Bitcoin > Mplayer.Inventory.Bitcoin)
                {
                    this.bad.Text += "Lost " + Math.Abs(hold) + " Bitcoin\n";
                }
                //gain
                else if (Dplayer.Inventory.Bitcoin < Mplayer.Inventory.Bitcoin)
                {
                    this.good.Text += "Gain " + hold + " Bitcoin!\n";
                }
                //Development
                //Bitcoin
                hold = Dplayer.Inventory.DevelopmentPoints - Mplayer.Inventory.DevelopmentPoints;
                //loss
                if (Dplayer.Inventory.DevelopmentPoints > Mplayer.Inventory.DevelopmentPoints)
                {
                    this.bad.Text += "Lost " + Math.Abs(hold) + " Development Points\n";
                }
                //gain
                else if (Dplayer.Inventory.DevelopmentPoints < Mplayer.Inventory.DevelopmentPoints)
                {
                    this.good.Text += "Gain " + hold + " Development Points!\n";
                }
          

        }
        private void next_button_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn >= this.manipulatedList.Count)
            {
                this.currentPlayer = manipulatedList[turn];
                calcRetrospective();
                Show();
            }
            else
            {
                this.Hide();
                this.Close();
            }

        }
    }
}
