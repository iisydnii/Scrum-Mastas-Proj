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
            //do nothing 
        }
        public Winners_Losers(List<Player> players)
        {
            InitializeComponent();
            setUpEndOfGame(players);
        }

        public void checkForEndOFGame(SituationDeck situationDeck, ProjectDeck projectDeck)
        {
            if(situationDeck == null || projectDeck == null)
            {
                game.endOfGame = true;
            }
        }

        private void setUpEndOfGame(List<Player> players)
        {
            setAllLosers();

            Player tempPlayer = players[0];
            foreach ( Player player in players )
            {
                if ( player.Inventory.DevelopmentPoints > tempPlayer.Inventory.DevelopmentPoints )
                {
                    tempPlayer = player;
                    setAllLosers();
                    setWinner(player.Id);

                }
                else if(player.Inventory.DevelopmentPoints == tempPlayer.Inventory.DevelopmentPoints)
                {
                    setWinner(player.Id);
                    setWinner(tempPlayer.Id);
                }
            }

            switch (players.Count)
            {
                case 2:
                    this.NameLabelGroup1.Text = players[0].Name;
                    this.NameLabelGroup2.Text = players[1].Name;
                    this.PointLabelGroup1.Text = players[0].Inventory.DevelopmentPoints.ToString();
                    this.PointLabelGroup2.Text = players[1].Inventory.DevelopmentPoints.ToString();
                    this.group3Label1.Visible = false;
                    this.group3Label2.Visible = false;
                    this.group4Label1.Visible = false;
                    this.group4Label2.Visible = false;
                    this.NameLabelGroup3.Visible = false;
                    this.PointLabelGroup3.Visible = false;
                    this.statusGroup3.Visible = false;
                    this.NameLabelGroup4.Visible = false;
                    this.PointLabelGroup4.Visible = false;
                    this.statusGroup4.Visible = false;

                    break;
                case 3:
                    this.NameLabelGroup1.Text = players[0].Name;
                    this.NameLabelGroup2.Text = players[1].Name;
                    this.NameLabelGroup3.Text = players[2].Name;
                    this.PointLabelGroup1.Text = players[0].Inventory.DevelopmentPoints.ToString();
                    this.PointLabelGroup2.Text = players[1].Inventory.DevelopmentPoints.ToString();
                    this.PointLabelGroup3.Text = players[2].Inventory.DevelopmentPoints.ToString();
                    this.group4Label1.Visible = false;
                    this.group4Label2.Visible = false;
                    this.NameLabelGroup4.Visible = false;
                    this.PointLabelGroup4.Visible = false;
                    this.statusGroup4.Visible = false;
                    break;
                case 4:
                    this.NameLabelGroup1.Text = players[0].Name;
                    this.NameLabelGroup2.Text = players[1].Name;
                    this.PointLabelGroup1.Text = players[0].Inventory.DevelopmentPoints.ToString();
                    this.PointLabelGroup2.Text = players[1].Inventory.DevelopmentPoints.ToString();
                    this.NameLabelGroup3.Text = players[2].Name;
                    this.NameLabelGroup4.Text = players[3].Name;
                    this.PointLabelGroup3.Text = players[2].Inventory.DevelopmentPoints.ToString();
                    this.PointLabelGroup4.Text = players[3].Inventory.DevelopmentPoints.ToString();
                    break;
            }


        }

        private void setAllLosers()
        {
            this.statusGroup1.Text = "Loser";
            this.statusGroup1.ForeColor = System.Drawing.Color.FromArgb(157, 56, 54);
            this.statusGroup2.Text = "Loser";
            this.statusGroup2.ForeColor = System.Drawing.Color.FromArgb(157, 56, 54);
            this.statusGroup3.Text = "Loser";
            this.statusGroup3.ForeColor = System.Drawing.Color.FromArgb(157, 56, 54);
            this.statusGroup4.Text = "Loser";
            this.statusGroup4.ForeColor = System.Drawing.Color.FromArgb(157, 56, 54);
        }

        private void setWinner(int Id)
        {
            switch (Id)
            {
                case 1:
                    this.statusGroup1.Text = "Winner";
                    this.statusGroup1.ForeColor = System.Drawing.Color.FromArgb(64, 124, 116);
                    break;
                case 2:
                    this.statusGroup2.Text = "Winner";
                    this.statusGroup2.ForeColor = System.Drawing.Color.FromArgb(64, 124, 116);
                    break;
                case 3:
                    this.statusGroup3.Text = "Winner";
                    this.statusGroup3.ForeColor = System.Drawing.Color.FromArgb(64, 124, 116);
                    break;
                case 4:
                    this.statusGroup4.Text = "Winner";
                    this.statusGroup4.ForeColor = System.Drawing.Color.FromArgb(64, 124, 116);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
