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
        private 


        public SituationCardForm(Player CurrentPlayer, SituationCard SC)
        {
            InitializeComponent();

            this.CurrentPlayer = CurrentPlayer;
            this.SC = SC;

            SetLabels();

            //Set Reward
            //foreach (KeyValuePair<int, string> value in SC.reward)
            //{
            //    RewardValue = value.Key.ToString();
            //    RewardType = value.Value;
            //}

        }


        /// <summary>
        /// Sets Form's Labels
        /// </summary>
        private void SetLabels()
        {
            //Set Situation's Description
            SituationLabel.Text = SC.situation;

        }


        /// <summary>
        /// Clicking the "Okay" Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Austin's Test");
            

            this.Close();
        }
    }
}
