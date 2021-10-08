/*-------------
    Name: Macen Busic
    Date created: 09/22/21
    File name: SelectPlayersForm.cs
    Purpose: Add functionality to SelectPlayersForm
    ----------------------------------------
    Modifications:
    Sydni 08/10/2021             changes to better work with the placement board
    -------------*/

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
    public partial class SelectPlayersForm : Form
    {
        List<Player> players = new List<Player>();

        public SelectPlayersForm()
        {
            InitializeComponent();
        }

        void SelectPlayersForm_Load(object sender, EventArgs e)
        {
            // Add the number of players allowed to the dropdown
            NumOfPlayersDropDown.Items.Add(2);
            NumOfPlayersDropDown.Items.Add(3);
            NumOfPlayersDropDown.Items.Add(4);
            // Default the choice to 2 players
            NumOfPlayersDropDown.SelectedIndex = 0;
        }

        void NumOfPlayersDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If 2 players is selected hide players 3 and 4 fields 
            if (NumOfPlayersDropDown.SelectedIndex == 0)
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
                    player1.Name = "Player 1";
                }
                else
                {
                    player1.Name = Player1TextBox.Text;
                }

                // If no name for player 2 is given
                if (string.IsNullOrWhiteSpace(Player2Textbox.Text.ToString()))
                {
                    player2.Name = "Player 2";
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
                    player1.Name = "Player 1";
                }
                else
                {
                    player1.Name = Player1TextBox.Text;
                }

                // If no name for player 2 is given
                if (string.IsNullOrWhiteSpace(Player2Textbox.Text.ToString()))
                {
                    player2.Name = "Player 2";
                }
                else
                {
                    player2.Name = Player2Textbox.Text;
                }

                // If no name for player 3 is given
                if (string.IsNullOrWhiteSpace(Player3Textbox.Text.ToString()))
                {
                    player3.Name = "Player 3";
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
                    player1.Name = "Player 1";
                }
                else
                {
                    player1.Name = Player1TextBox.Text;
                }

                // If no name for player 2 is given
                if (string.IsNullOrWhiteSpace(Player2Textbox.Text.ToString()))
                {
                    player2.Name = "Player 2";
                }
                else
                {
                    player2.Name = Player2Textbox.Text;
                }

                // If no name for player 3 is given
                if (string.IsNullOrWhiteSpace(Player3Textbox.Text.ToString()))
                {
                    player3.Name = "Player 3";
                }
                else
                {
                    player3.Name = Player3Textbox.Text;
                }

                // If no name for player 4 is given
                if (string.IsNullOrWhiteSpace(Player4Textbox.Text.ToString()))
                {
                    player4.Name = "Player 4";
                }
                else
                {
                    player4.Name = Player4Textbox.Text;
                }
            }

            this.Visible = false;
            //Open the player select form
            Placement_Board board = new Placement_Board(player1);
            board.ShowDialog();
            this.Close();
        }
    }

}
