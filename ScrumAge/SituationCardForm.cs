/*
 Page Created 
     File Name: SituationCardForm.cs
     Creator Name: Austin Trivette
     Created Date: 11/15/2021
     Purpose: Display Situational Card
________________________________________________________________________________
Page Modified

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
    partial class SituationCardForm : Form
    {
        private Player CurrentPlayer;
        private SituationCard SC;


        public SituationCardForm(Player CurrentPlayer, SituationCard SC)
        {
            InitializeComponent();

            this.CurrentPlayer = CurrentPlayer;
            this.SC = SC;

            SetLabels();

            //TODO
            //Actually add rewards and subtract costs

        }


        /// <summary>
        /// Sets Form's Labels
        /// </summary>
        private void SetLabels()
        {
            // Set Situation and Description Labels
            SituationLabel.Text = SC.situation;
            CertificateLabel.Text = SC.certifications;

            // Get values For cost and rewards
            string rewardValue = "";
            string rewardType = "";
            string costValue = "";
            string costType = "";
            string rewardString = "";

            
            int counter = 0;
            foreach (KeyValuePair<int, string> value in SC.reward)
            {
                if(counter == 0)
                {
                    rewardValue = value.Key.ToString();
                    rewardType = value.Value;
                    rewardString += "";          
                    RewardTypeLabel1.Text = rewardType;
                    RewardValueLabel1.Text = rewardValue;
                }
                else // If there's more than one reward, max is two
                {
                    rewardValue = value.Key.ToString();
                    rewardType = value.Value;
                    rewardString += "";
                    RewardTypeLabel2.Text = rewardType;
                    RewardValueLabel2.Text = rewardValue;
                }
                counter++;
            }

            foreach (KeyValuePair<int, string> value in SC.cost)
            {
                costValue = value.Key.ToString();
                costType = value.Value;
            }

            CostTypeLabel.Text = costType;
            CostAmountLabel.Text = costValue;


        }


        /// <summary>
        /// Clicking the "Okay" Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
