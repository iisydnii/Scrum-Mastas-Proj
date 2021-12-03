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
using System.Threading;

namespace ScrumAge
{
    public partial class ProjectTileForm : Form
    {
        Game game = new Game();
        public ProjectTile Tile { get; set; }
        public ProjectDeck Deck { get; set; }
        public Player currentPlayer { get; set; }
        ManualResetEvent oSignalEvent = new ManualResetEvent(false);

        public ProjectTileForm()
        {
            InitializeComponent();
        }

        public ProjectTileForm(ProjectTile tile, ProjectDeck deck, Player currentPlayer)
        {
            InitializeComponent();
            Tile = tile;
            Deck = deck;
            this.currentPlayer = currentPlayer;
            
            
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
            game.projectDeck = Deck;
            transferFunds();
            game.Tilefunds(this.currentPlayer, this.Deck);
            closeTile();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            closeTile();
        }

        public Player transferFunds()
        {
            string costType = Tile.cost.Values.ElementAt(0);
            var cost = Tile.cost.Keys.ElementAt(0);

            string rewardType = Tile.reward.Values.ElementAt(0);
            var rewardAmount = Tile.reward.Keys.ElementAt(0);

            if (costType == "Bitcoin")
            {
                currentPlayer.Inventory.Bitcoin -= cost;
            }
            else if (costType == "Training")
            {
                currentPlayer.Inventory.TrainingPoints -= cost;
            }
            else if (costType == "Design")
            {
                currentPlayer.Inventory.DesignPoints -= cost;
            }

            if (rewardType == "Development")
            {
                currentPlayer.Inventory.DevelopmentPoints += rewardAmount;
            }
            

            
            return (currentPlayer);
        }

        private void closeTile()
        {
            this.Close();
        }
    }
}
