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
    public partial class SituationCardForm : Form
    {
        private Player CurrentPlayer;
        private SituationDeck SD;


        public SituationCardForm(Player CurrentPlayer)
        {
            InitializeComponent();

            this.CurrentPlayer = CurrentPlayer;

           


            
        }

        private void PopulateSituationDeck()
        {
            SD = Placement_Board.
        }

        /// <summary>
        /// Clicking the "Okay" Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Austin's Test");
            //SD.DisplayCards();
            


            //SD.DrawCard();

            this.Close();
        }
    }
}
