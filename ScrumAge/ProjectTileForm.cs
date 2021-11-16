/*
 Page Created 
     File Name: ProjectTileForm.cs
     Creator Name: Piper Floyd
     Created Date: 11/07/21
     Purpose: Displays the drawn project tile
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
    public partial class ProjectTileForm : Form
    {
        public ProjectTile Tile { get; set; }
        public ProjectDeck Deck { get; set; }
        public ProjectTileForm()
        {
            InitializeComponent();
        }

        public ProjectTileForm(ProjectTile tile, ProjectDeck deck)
        {
            InitializeComponent();
            Tile = tile;
            Deck = deck;
        }
        private void ProjectTileForm_Load(object sender, EventArgs e)
        {
            label1.Text = Placement_Board.Description;
            label5.Text = Placement_Board.RewardType;
            label7.Text = Placement_Board.RewardValue;

            label6.Text = Placement_Board.CostType;
            label8.Text = Placement_Board.CostValue;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Deck.RemoveCard(Tile);
            //do the payment and rewards for the tile
            this.Close();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
