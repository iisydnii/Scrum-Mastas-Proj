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
/*-------------
Name: Macen Busic
Date created: 09/22/21
File name: SelectPlayersForm.cs
Purpose: Add functionality to SelectPlayersForm
-------------*/
    public partial class SelectPlayersForm : Form
    {

        public List<Player> players { get; set; }

        public SelectPlayersForm()
        {
            players = new List<Player>();
            InitializeComponent();
        }

        private void SelectPlayersForm_Load(object sender, EventArgs e)
        {
            // Add the number of players allowed to the dropdown
            NumOfPlayersDropDown.Items.Add(2);
            NumOfPlayersDropDown.Items.Add(3);
            NumOfPlayersDropDown.Items.Add(4);
            // Default the choice to 2 players
            NumOfPlayersDropDown.SelectedIndex = 0;
        }

        private void NumOfPlayersDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If 2 players is selected hide players 3 and 4 fields 
            if(NumOfPlayersDropDown.SelectedIndex == 0)
            {
                Player3Label.Visible = false; 
                Player3Textbox.Visible = false;
                Player4Label.Visible = false;
                Player4Textbox.Visible = false;
            }

            // If 3 players is selected hide player 4 fields
            else if (NumOfPlayersDropDown.SelectedIndex == 1)
            {
                Player3Label.Visible = true;
                Player3Textbox.Visible = true;
                Player4Label.Visible = false;
                Player4Textbox.Visible = false;
            }

            //If 4 players is selected make all fields visible 
            else
            {
                Player3Label.Visible = true;
                Player3Textbox.Visible = true;
                Player4Label.Visible = true;
                Player4Textbox.Visible = true;
            }
        }

        // Once Begin is clicked 
        private void Begin_Click(object sender, EventArgs e)
        {
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            players.Add(player1);
            players.Add(player2);

            //if 2 players were selected 
            if (Player3Label.Visible == false)
            {
                // If no name for player 1 is given
                if (string.IsNullOrWhiteSpace(Player1TextBox.Text.ToString()))
                {
                    player1.Name = "1";
                }
                else
                {
                    player1.Name = Player1TextBox.Text;
                }

                // If no name for player 2 is given
                if (string.IsNullOrWhiteSpace(Player2Textbox.Text.ToString()))
                {
                    player2.Name = "2";
                }
                else
                {
                    player2.Name = Player2Textbox.Text;
                }
            }

            // If 3 players were selected
            else if (Player4Label.Visible == false)
            {
                Player player3 = new Player(3);
                players.Add(player3);

                // If no name for player 1 is given
                if (string.IsNullOrWhiteSpace(Player1TextBox.Text.ToString()))
                {
                    player1.Name = "1";
                }
                else
                {
                    player1.Name = Player1TextBox.Text;
                }

                // If no name for player 2 is given
                if (string.IsNullOrWhiteSpace(Player2Textbox.Text.ToString()))
                {
                    player2.Name = "2";
                }
                else
                {
                    player2.Name = Player2Textbox.Text;
                }

                // If no name for player 3 is given
                if (string.IsNullOrWhiteSpace(Player3Textbox.Text.ToString()))
                {
                    player3.Name = "3";
                }
                else
                {
                    player3.Name = Player3Textbox.Text;
                }
            }

            // If 4 players were selected
            else
            {
                Player player3 = new Player(3);
                Player player4 = new Player(4);
                players.Add(player3);
                players.Add(player4);

                // If no name for player 1 is given
                if (string.IsNullOrWhiteSpace(Player1TextBox.Text.ToString()))
                {
                    player1.Name = "1";
                }
                else
                {
                    player1.Name = Player1TextBox.Text;
                }

                // If no name for player 2 is given
                if (string.IsNullOrWhiteSpace(Player2Textbox.Text.ToString()))
                {
                    player2.Name = "2";
                }
                else
                {
                    player2.Name = Player2Textbox.Text;
                }

                // If no name for player 3 is given
                if (string.IsNullOrWhiteSpace(Player3Textbox.Text.ToString()))
                {
                    player3.Name = "3";
                }
                else
                {
                    player3.Name = Player3Textbox.Text;
                }

                // If no name for player 4 is given
                if (string.IsNullOrWhiteSpace(Player4Textbox.Text.ToString()))
                {
                    player4.Name = "4";
                }
                else
                {
                    player4.Name = Player4Textbox.Text;
                }
            }

            this.Visible = false;
            //Open the player select form
            //Placement_Board board = new Placement_Board(1);
            //board.ShowDialog();
            Game game = new Game();
            game.DisplayPlacementBoard();
            this.Close();
        }

    }

    public static class FormState
    {
        public static Form PreviousPage;
    }
}
