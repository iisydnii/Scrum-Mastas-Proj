/*
 Page Created 
     File Name: Placement_Board
     Creator Name: Sydni Ward
     Created Date: 09/29/2021
     Purpose: Display Placement Phase
________________________________________________________________________________
Page Modified
    Piper Floyd, 10/24/21, lines 31,223-233, 270-285 Added Player property and injected it into controller
                                        so that its values can be accessed. Added method to display
                                        player's resources. Added method to display dice roll.
    Garrett Dyer, 10/24/21,  lines 304-374, added the bootcamp placement method. 
                                        Checks the picture boxes for developers and sends the data to the bootcamp class.
    Nataliya Chibizova, 10/25/21,  lines 341-391, added the WhiteBoardPlacement method. 
                                        Checks the picture boxes for developers and sends the data to the Whiteboard.cs 
    Piper Floyd, 11/7/21, lines 574-584 Added quit game buton and expanded the form
    Sydni Ward   11/13/2021             Fixing errors
    Piper Floyd, 11/10/21,              Added project tile methods
    Austin Trivette, 11/15/21,          Added Situation Card Form To Open in activation and situation deck (Lines 856-897)
    Sydni Ward 11/16/2021               Payment

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumAge
{

    public partial class Placement_Board : Form
    {
        Game game = new Game();
        public List<Player> PlayerList;
        List<Locations> locationList;
        List<Box> trackBoxes;
        PictureBox[] boxes;
        PictureBox selected;
        Player currentPlayer;
        int AvailableDevs = 0;
        int devs = 0; // once set it never changes
        int turn;
        int roll = 0;
        public int stockPrice;
        Bootcamp bootCamp = new Bootcamp();
        Whiteboard whiteBoard = new Whiteboard();
        HRLocation hr = new HRLocation();
        CryptoMarket market = new CryptoMarket();
        ProjectDeck deck = new ProjectDeck();
        Locations location = new Locations();
        DiceForm DiceForm = new DiceForm();
        private bool picBox5WasClicked = false;
        private bool picBox6WasClicked = false;
        private bool picBox7WasClicked = false;
        private bool picBox8WasClicked = false;
        bool activate = false;

        public static string Description = "";
        public static string RewardType = "";
        public static string RewardValue = "";
        public static string CostType = "";
        public static string CostValue = "";

        public static string Reward = "";
        public static Dictionary<int, string> RewardD;
        public static Dictionary<int, string> Cost;

        public Placement_Board(List<Player> PlayerList, int stockPrice)
        {
            InitializeComponent();
            this.PlayerList = PlayerList;
            this.stockPrice = stockPrice;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            locationList = location.createList();
            createDragAndDrop();
            createBoxTracker();
            currentPlayer = PlayerList[0];
            setStatus();
            turn = 0;
            setImage();
            getAvailableDevs(0);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextPlayer();
        }
        private void nextPlayer()
        {
            if (activate == false)
            {
                //unlock all
                UnlockBoxes();
                //lock boxes that are not null
                lockUsedBoxes();

                //Save Devs
                //HR
                HRPlacement();
                //Bootcamp
                BootCampPlacement();
                //Whiteboard
                WhiteBoardPlacement();
                //Bitcoin Market
                CryptoMarkerPlacement();

                unlockEmptyBoxes();
                turn++;
                if (turn == PlayerList.Count)
                {
                    turn = 0;
                }
                setUpPlayerTurns();
            }
            else
            {
                activationTurns();
            }
        }

        private void setUpPlayerTurns()
        {
            Boolean AvailableDevsBool = true;
            

            AvailableDevsBool = checkPlayersDevs();
            if (AvailableDevsBool == false)
            {
                activate = true;
                beginActivation();
            }
            else
            {
                getAvailableDevs(turn);
                if (AvailableDevs != 0)
                {
                    currentPlayer = PlayerList[turn];
                    setStatus();
                    setImage();
                }
                else
                {
                    turn++;
                    if (turn == PlayerList.Count)
                    {
                        turn = 0;
                    }
                    setUpPlayerTurns();
                }
            }
        }

        private Boolean checkPlayersDevs()
        {
            int trueDev = 0;
            for (int i = 0; i <= PlayerList.Count - 1; i++)
            {
                getAvailableDevs(i);
                if (AvailableDevs == 0)
                { }
                else
                {
                    trueDev += 1;
                }
            }

            if (trueDev == 0)
            {
                return false;
            }

            return true;
        }

        void getAvailableDevs(int id)
        {
            int hold = 0;
            //get players total devs
            hold = PlayerList[id].Inventory.Developers;

            switch (id)
            {
                case 0:
                    hold -= locationList[0].playerList[1, 0];
                    hold -= locationList[1].playerList[1, 0];
                    hold -= locationList[2].playerList[1, 0];
                    hold -= locationList[3].playerList[1, 0];
                    break;
                case 1:
                    hold -= locationList[0].playerList[1, 1];
                    hold -= locationList[1].playerList[1, 1];
                    hold -= locationList[2].playerList[1, 1];
                    hold -= locationList[3].playerList[1, 1];
                    break;
                case 2:
                    hold -= locationList[0].playerList[1, 2];
                    hold -= locationList[1].playerList[1, 2];
                    hold -= locationList[2].playerList[1, 2];
                    hold -= locationList[3].playerList[1, 2];
                    break;
                case 3:
                    hold -= locationList[0].playerList[1, 3];
                    hold -= locationList[1].playerList[1, 3];
                    hold -= locationList[2].playerList[1, 3];
                    hold -= locationList[3].playerList[1, 3];
                    break;
            }

            AvailableDevs = hold;
            devs = AvailableDevs;
        }

        // SECTION DRAG AND DROP FUNCTIONS
        void createDragAndDrop()
        {
            boxes = new PictureBox[] { HRBox, BootCampBox1, BootCampBox2, BootCampBox3, BootCampBox4, BootCampBox5,
                BootCampBox6, BootCampBox7, BootCampBox8, WhiteBoardBox1, WhiteBoardBox2, WhiteBoardBox3, WhiteBoardBox4, WhiteBoardBox5,
                WhiteBoardBox6, WhiteBoardBox7, WhiteBoardBox8, BitcoinMarketBox1, BitcoinMarketBox2, BitcoinMarketBox3,
                BitcoinMarketBox4, BitcoinMarketBox5, BitcoinMarketBox6, BitcoinMarketBox7, BitcoinMarketBox8, holdDevelopers };

            try
            {

                foreach (var box in boxes)
                {
                    box.AllowDrop = true;
                    box.DragDrop += PictureBox_DragDrop;
                    box.DragEnter += PictureBox_DragEnter;
                    box.MouseClick += PictureBox_MouseClick;
                    box.MouseMove += PictureBox_MouseMove;
                    box.Paint += PictureBox_Paint;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No images found", "No Images Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        void createBoxTracker()
        {
            trackBoxes = new List<Box>()
            {
                new Box() { pictureBox = HRBox, used = false },
                new Box() { pictureBox = BootCampBox1, used = false },
                new Box() { pictureBox = BootCampBox2, used = false },
                new Box() { pictureBox = BootCampBox3, used = false },
                new Box() { pictureBox = BootCampBox4, used = false },
                new Box() { pictureBox = BootCampBox5, used = false },
                new Box() { pictureBox = BootCampBox6, used = false },
                new Box() { pictureBox = BootCampBox7, used = false },
                new Box() { pictureBox = BootCampBox8, used = false },
                new Box() { pictureBox = WhiteBoardBox1, used = false },
                new Box() { pictureBox = WhiteBoardBox2, used = false },
                new Box() { pictureBox = WhiteBoardBox3, used = false },
                new Box() { pictureBox = WhiteBoardBox4, used = false },
                new Box() { pictureBox = WhiteBoardBox5, used = false },
                new Box() { pictureBox = WhiteBoardBox6, used = false },
                new Box() { pictureBox = WhiteBoardBox7, used = false },
                new Box() { pictureBox = WhiteBoardBox8, used = false },
                new Box() { pictureBox = BitcoinMarketBox1, used = false },
                new Box() { pictureBox = BitcoinMarketBox2, used = false },
                new Box() { pictureBox = BitcoinMarketBox3, used = false },
                new Box() { pictureBox = BitcoinMarketBox4, used = false },
                new Box() { pictureBox = BitcoinMarketBox5, used = false },
                new Box() { pictureBox = BitcoinMarketBox6, used = false },
                new Box() { pictureBox = BitcoinMarketBox7, used = false },
                new Box() { pictureBox = BitcoinMarketBox8, used = false },
            };
        }

        //Set Player Images
        public void setImage()
        {
            holdDevelopers.BackgroundImage = Image.FromFile(currentPlayer.pictureFile);
        }

        /// <summary>
        /// Fires after dragging has completed on the target control
        /// </summary>
        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
                if (source != target)
                {
                    // You can swap the images out, replace the target image, etc.
                    SwapImages(source, target);

                    selected = null;
                    SelectBox(target);
                    return;
                }
            }
            Console.WriteLine("Don't do DragDrop");
        }

        /// <summary>
        /// Set the target's accepted DragDropEffect. Should match the source.
        /// </summary>
        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Handle mouse click on picture box
        /// </summary>
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }

        /// <summary>
        /// Only start DragDrop if the mouse moves. Allows MouseClick to trigger
        /// </summary>
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pb = (PictureBox)sender;
                if (pb.BackgroundImage != null)
                {
                    pb.DoDragDrop(pb, DragDropEffects.Move);
                }
            }
        }

        /// <summary>
        /// Override paint so we can draw a border on a selected image
        /// </summary>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = Color.FromArgb(245, 235, 208); //set to tan
            if (selected == pb)
            {
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle,
                   Color.Blue, 1, ButtonBorderStyle.Solid,  // Left
                   Color.Blue, 1, ButtonBorderStyle.Solid,  // Top
                   Color.Blue, 1, ButtonBorderStyle.Solid,  // Right
                   Color.Blue, 1, ButtonBorderStyle.Solid); // Bottom
            }
        }

        /// <summary>
        /// Set the selected image, and trigger repaint on all boxes.
        /// </summary>
        private void SelectBox(PictureBox pb)
        {
            if (selected != pb)
            {
                selected = pb;
            }
            else
            {
                selected = null;
            }

            // Cause each box to repaint
            foreach (var box in boxes) box.Invalidate();
        }

        /// <summary>
        /// Swap images between two PictureBoxes
        /// </summary>
        private void SwapImages(PictureBox source, PictureBox target)
        {
            int index = 0;
            if (source.BackgroundImage == null && target.BackgroundImage == null)
            {
                return;
            }
            if (target.BackgroundImage != null && target.Name != "holdDevelopers")
            {
                return;
            }
            var temp = target.BackgroundImage;
            target.BackgroundImage = source.BackgroundImage;
            
            if (source.Name == "holdDevelopers")
            {
                usedBox(target.Name);
                //minus 1 dev for the available devs
                AvailableDevs = AvailableDevs - 1;
                if (AvailableDevs == 0)
                {
                    holdDevelopers.BackgroundImage = null;
                }
                if (devs == AvailableDevs)
                {
                    UnlockBoxes();
                    //lock boxes that are not null
                    lockUsedBoxes();
                }
                else
                { 
                       lockOtherLocations(target.Name);
                }
            }
            else if (target.Name == "holdDevelopers")
            {
                setBoxEmpty(source.Name);
                source.BackgroundImage = null;
                source = null;
                //add 1 dev for the available devs
                AvailableDevs = AvailableDevs + 1;
                if (devs == AvailableDevs)
                {
                    UnlockBoxes();
                    //lock boxes that are not null
                    lockUsedBoxes();
                }
            }
            else // moving to another location
            { 
                source.BackgroundImage = temp;
                usedBox(target.Name);
                setBoxEmpty(source.Name);
            }
        }


        /// <summary>
        /// Dsiplays the players name and current inventory
        /// </summary>
        private void setStatus()
        {
            label6.Text = currentPlayer.Name;
            label2.Text = currentPlayer.Inventory.TrainingPoints.ToString();
            label10.Text = currentPlayer.Inventory.DesignPoints.ToString();
            label12.Text = currentPlayer.Inventory.Bitcoin.ToString();
            label3.Text = currentPlayer.Inventory.DevelopmentPoints.ToString();
            label7.Text = currentPlayer.Inventory.Developers.ToString();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;

            QuitGame quitGame = new QuitGame();
            quitGame.StartPosition = FormStartPosition.CenterParent;
            quitGame.ShowDialog();
            this.Close();
        }

        //UNLOCK PICTUREBOXES
        private void UnlockBoxes()
        {
            foreach (var box in boxes)
            {
                box.Enabled = true;
                box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            }
        }

        private void lockOtherLocations(string boxName)
        {
            if (!boxName.Contains("HRBox"))
            {
                HRBox.Enabled = false;
            }
            if (!boxName.Contains("BootCampBox"))
            {
                BootCampBox1.Enabled = false;
                BootCampBox2.Enabled = false;
                BootCampBox3.Enabled = false;
                BootCampBox4.Enabled = false;
                BootCampBox5.Enabled = false;
                BootCampBox6.Enabled = false;
                BootCampBox7.Enabled = false;
                BootCampBox8.Enabled = false;
            }
            if (!boxName.Contains("WhiteBoardBox"))
            {
                WhiteBoardBox1.Enabled = false;
                WhiteBoardBox2.Enabled = false;
                WhiteBoardBox3.Enabled = false;
                WhiteBoardBox4.Enabled = false;
                WhiteBoardBox5.Enabled = false;
                WhiteBoardBox6.Enabled = false;
                WhiteBoardBox7.Enabled = false;
                WhiteBoardBox8.Enabled = false;
            }
            if (!boxName.Contains("BitcoinMarketBox"))
            {
                BitcoinMarketBox1.Enabled = false;
                BitcoinMarketBox2.Enabled = false;
                BitcoinMarketBox3.Enabled = false;
                BitcoinMarketBox4.Enabled = false;
                BitcoinMarketBox5.Enabled = false;
                BitcoinMarketBox6.Enabled = false;
                BitcoinMarketBox7.Enabled = false;
                BitcoinMarketBox8.Enabled = false;
            }
        }

        private void lockUsedBoxes()
        {
            foreach (var box in boxes)
            {
                if( box.BackgroundImage != null && box.Name != "holdDevelopers")
                {
                    box.Enabled = false;
                }
            }
        }
        private void unlockEmptyBoxes()
        {
            foreach (var box in boxes)
            {
                if (box.BackgroundImage == null && box.Name != "holdDevelopers")
                {
                    box.Enabled = true;
                }
            }
        }

        private void usedBox(string boxName)
        {
            
            if (boxName == "HRBox" && trackBoxes[0].playerId == 0)
            { trackBoxes[0].playerId = currentPlayer.Id; }

            if (boxName == "BootCampBox1" && trackBoxes[1].playerId == 0)
            { trackBoxes[1].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox2" && trackBoxes[2].playerId == 0)
            { trackBoxes[2].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox3" && trackBoxes[3].playerId == 0)
            { trackBoxes[3].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox4" && trackBoxes[4].playerId == 0)
            { trackBoxes[4].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox5" && trackBoxes[5].playerId == 0)
            { trackBoxes[5].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox6" && trackBoxes[6].playerId == 0)
            { trackBoxes[6].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox7" && trackBoxes[7].playerId == 0)
            { trackBoxes[7].playerId = currentPlayer.Id; }
            else if (boxName == "BootCampBox8" && trackBoxes[8].playerId == 0)
            { trackBoxes[8].playerId = currentPlayer.Id; }

            if (boxName == "WhiteBoardBox1" && trackBoxes[9].playerId == 0)
            { trackBoxes[9].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox2" && trackBoxes[10].playerId == 0)
            { trackBoxes[10].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox3" && trackBoxes[11].playerId == 0)
            { trackBoxes[11].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox4" && trackBoxes[12].playerId == 0)
            { trackBoxes[12].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox5" && trackBoxes[13].playerId == 0)
            { trackBoxes[13].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox6" && trackBoxes[14].playerId == 0)
            { trackBoxes[14].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox7" && trackBoxes[15].playerId == 0)
            { trackBoxes[15].playerId = currentPlayer.Id; }
            else if (boxName == "WhiteBoardBox8" && trackBoxes[16].playerId == 0)
            { trackBoxes[16].playerId = currentPlayer.Id; }

            if (boxName == "BitcoinMarketBox1" && trackBoxes[17].playerId == 0)
            { trackBoxes[17].playerId = currentPlayer.Id; }
            else if (boxName == "BitcoinMarketBox2" && trackBoxes[18].playerId == 0)
            { trackBoxes[18].playerId = currentPlayer.Id; }
            else if (boxName == "BitcoinMarketBox3" && trackBoxes[19].playerId == 0)
            { trackBoxes[19].playerId = currentPlayer.Id; }
            else if (boxName == "BitcoinMarketBox4" && trackBoxes[20].playerId == 0)
            { trackBoxes[20].playerId = currentPlayer.Id;}
            else if (boxName == "BitcoinMarketBox5" && trackBoxes[21].playerId == 0)
            { trackBoxes[21].playerId = currentPlayer.Id; }
            else if (boxName == "BitcoinMarketBox6" && trackBoxes[22].playerId == 0)
            { trackBoxes[22].playerId = currentPlayer.Id; }
            else if (boxName == "BitcoinMarketBox7" && trackBoxes[23].playerId == 0)
            { trackBoxes[23].playerId = currentPlayer.Id; }
            else if (boxName == "BitcoinMarketBox8" && trackBoxes[24].playerId == 0)
            { trackBoxes[24].playerId = currentPlayer.Id; }

        }

        private void setBoxEmpty(string boxName)
        {

            if (boxName == "HRBox" && trackBoxes[0].playerId != 0)
            { trackBoxes[0].playerId = 0; }

            if (boxName == "BootCampBox1" && trackBoxes[1].playerId != 0)
            { trackBoxes[1].playerId = 0; }
            else if (boxName == "BootCampBox2" && trackBoxes[2].playerId != 0)
            { trackBoxes[2].playerId = 0; }
            else if (boxName == "BootCampBox3" && trackBoxes[3].playerId != 0)
            { trackBoxes[3].playerId = 0; }
            else if (boxName == "BootCampBox4" && trackBoxes[4].playerId != 0)
            { trackBoxes[4].playerId = 0; }
            else if (boxName == "BootCampBox5" && trackBoxes[5].playerId != 0)
            { trackBoxes[5].playerId = 0; }
            else if (boxName == "BootCampBox6" && trackBoxes[6].playerId != 0)
            { trackBoxes[6].playerId = 0; }
            else if (boxName == "BootCampBox7" && trackBoxes[7].playerId != 0)
            { trackBoxes[7].playerId = 0; }
            else if (boxName == "BootCampBox8" && trackBoxes[8].playerId != 0)
            { trackBoxes[8].playerId = currentPlayer.Id; }

            if (boxName == "WhiteBoardBox1" && trackBoxes[9].playerId != 0)
            { trackBoxes[9].playerId = 0; }
            else if (boxName == "WhiteBoardBox2" && trackBoxes[10].playerId != 0)
            { trackBoxes[10].playerId = 0; }
            else if (boxName == "WhiteBoardBox3" && trackBoxes[11].playerId != 0)
            { trackBoxes[11].playerId = 0; }
            else if (boxName == "WhiteBoardBox4" && trackBoxes[12].playerId != 0)
            { trackBoxes[12].playerId = 0; }
            else if (boxName == "WhiteBoardBox5" && trackBoxes[13].playerId != 0)
            { trackBoxes[13].playerId = 0; }
            else if (boxName == "WhiteBoardBox6" && trackBoxes[14].playerId != 0)
            { trackBoxes[14].playerId = 0; }
            else if (boxName == "WhiteBoardBox7" && trackBoxes[15].playerId != 0)
            { trackBoxes[15].playerId = 0; }
            else if (boxName == "WhiteBoardBox8" && trackBoxes[16].playerId != 0)
            { trackBoxes[16].playerId = currentPlayer.Id; }

            if (boxName == "BitcoinMarketBox1" && trackBoxes[17].playerId != 0)
            { trackBoxes[17].playerId = 0; }
            else if (boxName == "BitcoinMarketBox2" && trackBoxes[18].playerId != 0)
            { trackBoxes[18].playerId = 0; }
            else if (boxName == "BitcoinMarketBox3" && trackBoxes[19].playerId != 0)
            { trackBoxes[19].playerId = 0; }
            else if (boxName == "BitcoinMarketBox4" && trackBoxes[20].playerId != 0)
            { trackBoxes[20].playerId = 0; }
            else if (boxName == "BitcoinMarketBox5" && trackBoxes[21].playerId != 0)
            { trackBoxes[21].playerId = 0; }
            else if (boxName == "BitcoinMarketBox6" && trackBoxes[22].playerId != 0)
            { trackBoxes[22].playerId = 0; }
            else if (boxName == "BitcoinMarketBox7" && trackBoxes[23].playerId != 0)
            { trackBoxes[23].playerId = 0; }
            else if (boxName == "BitcoinMarketBox8" && trackBoxes[24].playerId != 0)
            { trackBoxes[24].playerId = 0; }

        }

        private void lockBox(string boxName)
        {
            if (boxName == "HRBox")
            { HRBox.Enabled = false; }

            if (boxName == "BootCampBox1")
            { BootCampBox1.Enabled = false; }
            else if (boxName == "BootCampBox2")
            { BootCampBox2.Enabled = false; }
            else if (boxName == "BootCampBox3")
            { BootCampBox3.Enabled = false; }
            else if (boxName == "BootCampBox4")
            { BootCampBox4.Enabled = false; }
            else if (boxName == "BootCampBox5")
            { BootCampBox5.Enabled = false; }
            else if (boxName == "BootCampBox6")
            { BootCampBox6.Enabled = false; }
            else if (boxName == "BootCampBox7")
            { BootCampBox7.Enabled = false; }
            else if (boxName == "BootCampBox8")
            { BootCampBox8.Enabled = false; }

            if (boxName == "WhiteBoardBox1")
            { WhiteBoardBox1.Enabled = false; }
            else if (boxName == "WhiteBoardBox2")
            { WhiteBoardBox2.Enabled = false; }
            else if (boxName == "WhiteBoardBox3")
            { WhiteBoardBox3.Enabled = false; }
            else if (boxName == "WhiteBoardBox4")
            { WhiteBoardBox4.Enabled = false; }
            else if (boxName == "WhiteBoardBox5")
            { WhiteBoardBox5.Enabled = false; }
            else if (boxName == "WhiteBoardBox6")
            { WhiteBoardBox6.Enabled = false; }
            else if (boxName == "WhiteBoardBox7")
            { WhiteBoardBox7.Enabled = false; }
            else if (boxName == "WhiteBoardBox8")
            { WhiteBoardBox8.Enabled = false; }

            if (boxName == "BitcoinMarketBox1")
            { BitcoinMarketBox1.Enabled = false; }
            else if (boxName == "BitcoinMarketBox2")
            { BitcoinMarketBox2.Enabled = false; }
            else if (boxName == "BitcoinMarketBox3")
            { BitcoinMarketBox3.Enabled = false; }
            else if (boxName == "BitcoinMarketBox4")
            { BitcoinMarketBox4.Enabled = false; }
            else if (boxName == "BitcoinMarketBox5")
            { BitcoinMarketBox5.Enabled = false; }
            else if (boxName == "BitcoinMarketBox6")
            { BitcoinMarketBox6.Enabled = false; }
            else if (boxName == "BitcoinMarketBox7")
            { BitcoinMarketBox7.Enabled = false; }
            else if (boxName == "BitcoinMarketBox8")
            { BitcoinMarketBox8.Enabled = false; }
        }

        private void HRPlacement()
        {
            int counter = 0;

            foreach (var box in trackBoxes)
            {
                if (box.playerId == currentPlayer.Id && box.pictureBox.Name.Contains("HRBox"))
                {
                    counter++;
                    lockBox(box.pictureBox.Name);
                }
            }
            locationList[0].playerList = hr.placeDevs(currentPlayer.Id, counter);
        }

        private void BootCampPlacement()
        {
            int counter = 0;

            foreach (var box in trackBoxes)
            {
                if (box.playerId == currentPlayer.Id && box.pictureBox.Name.Contains("BootCampBox"))
                {
                    counter++;
                    lockBox(box.pictureBox.Name);
                }
            }
            locationList[1].playerList = bootCamp.placeDevs(currentPlayer.Id, counter);
        }

        private void WhiteBoardPlacement()
        {
            int counter = 0;

            foreach (var box in trackBoxes)
            {
                if (box.playerId == currentPlayer.Id && box.pictureBox.Name.Contains("WhiteBoardBox"))
                {
                    counter++;
                    lockBox(box.pictureBox.Name);
                }
            }
            locationList[2].playerList = whiteBoard.placeDevs(currentPlayer.Id, counter);
        }

        private void CryptoMarkerPlacement()
        {
            int counter = 0;
            foreach (var box in trackBoxes)
            {
                if (box.playerId == currentPlayer.Id && box.pictureBox.Name.Contains("BitcoinMarketBox"))
                {
                    counter++;
                    lockBox(box.pictureBox.Name);
                }
            }
            locationList[3].playerList = market.placeDevs(currentPlayer.Id, counter);
        }

        // -------------------------------------------------------------
        // Activation Phase 
        // -------------------------------------------------------------

        // Project Tiles
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ProjectTile projectTile = deck.DrawCard();
            Description = projectTile.Description;

            foreach (KeyValuePair<int, string> value in projectTile.reward)
            {
                RewardValue = value.Key.ToString();
                RewardType = value.Value;
            }
            foreach (KeyValuePair<int, string> value in projectTile.cost)
            {
                CostValue = value.Key.ToString();
                CostType = value.Value;
            }

            if (picBox6WasClicked == true || picBox7WasClicked == true || picBox8WasClicked == true)
            {
                pictureBox5.Enabled = false;
            }
            else 
            {
                pictureBox5.Enabled = true;
                picBox5WasClicked = true;
                ProjectTileForm projectTileForm = new ProjectTileForm(projectTile, deck, currentPlayer);
                projectTileForm.Show();
                
            }
        }

        /// <summary>
        /// Displays second project tile
        /// </summary>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ProjectTile projectTile = deck.DrawCard();
            Description = projectTile.Description;

            foreach (KeyValuePair<int, string> value in projectTile.reward)
            {
                RewardValue = value.Key.ToString();
                RewardType = value.Value;
            }
            foreach (KeyValuePair<int, string> value in projectTile.cost)
            {
                CostValue = value.Key.ToString();
                CostType = value.Value;
            }
            
            if (picBox5WasClicked == true || picBox7WasClicked == true || picBox8WasClicked == true)
            {
                pictureBox6.Enabled = false;
            }
            else
            {
                pictureBox6.Enabled = false;
                picBox6WasClicked = true;
                ProjectTileForm projectTileForm = new ProjectTileForm(projectTile, deck, currentPlayer);
                projectTileForm.Show();
            }
        }

        /// <summary>
        /// Displays fourht project tile
        /// </summary>
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ProjectTile projectTile = deck.DrawCard();
            Description = projectTile.Description;

            foreach (KeyValuePair<int, string> value in projectTile.reward)
            {
                RewardValue = value.Key.ToString();
                RewardType = value.Value;
            }
            foreach (KeyValuePair<int, string> value in projectTile.cost)
            {
                CostValue = value.Key.ToString();
                CostType = value.Value;
            }
            //ProjectTileForm projectTileForm = new ProjectTileForm();
            //projectTileForm.Show();

            if (picBox6WasClicked == true || picBox5WasClicked == true || picBox8WasClicked == true)
            {
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox7.Enabled = true;
                picBox7WasClicked = true;
                ProjectTileForm projectTileForm = new ProjectTileForm(projectTile, deck, currentPlayer);
                projectTileForm.Show();
            }
        }

        /// <summary>
        /// Displays third project tile
        /// </summary>
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ProjectTile projectTile = deck.DrawCard();
            Description = projectTile.Description;

            foreach (KeyValuePair<int, string> value in projectTile.reward)
            {
                RewardValue = value.Key.ToString();
                RewardType = value.Value;
            }
            foreach (KeyValuePair<int, string> value in projectTile.cost)
            {
                CostValue = value.Key.ToString();
                CostType = value.Value;
            }
            if (picBox6WasClicked == true || picBox7WasClicked == true || picBox5WasClicked == true)
            {
                pictureBox8.Enabled = false;
            }
            else
            {
                pictureBox8.Enabled = true;
                picBox8WasClicked = true;
                ProjectTileForm projectTileForm = new ProjectTileForm(projectTile, deck, currentPlayer);
                projectTileForm.Show();

            }
        }

        public void setUpAfterTile(Player player, ProjectDeck deck)
        {
            this.deck = deck;
            this.currentPlayer = player;
            setStatus();
            nextPlayer();
        }

        private SituationDeck sdDeck = new SituationDeck();
        

        private void beginActivation()
        {
            //set holddevelopers to null
            holdDevelopers.BackgroundImage = null;
            //set project tiles to visible 
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            //set currentplayer to 1
            turn = 0;
            activationTurns();
        }

        private Player transferFunds(Player CurrentPlayer, SituationCard SC)
        {
            string costType = SC.cost.Values.ElementAt(0);
            var cost = SC.cost.Keys.ElementAt(0);

            string rewardType = SC.reward.Values.ElementAt(0);
            var rewardAmount = SC.reward.Keys.ElementAt(0);

            if (costType == "Bitcoin")
            {
                CurrentPlayer.Inventory.Bitcoin -= cost;
            }
            else if (costType == "Training")
            {
                CurrentPlayer.Inventory.TrainingPoints -= cost;
            }
            else if (costType == "Design")
            {
                CurrentPlayer.Inventory.DesignPoints -= cost;
            }

            if (rewardType == "Bitcoin")
            {
                CurrentPlayer.Inventory.Bitcoin += rewardAmount;
                CurrentPlayer.Inventory.Certifications.AddCertification(SC.certifications);
            }
            else if (rewardType == "Training")
            {
                CurrentPlayer.Inventory.TrainingPoints += rewardAmount;
                CurrentPlayer.Inventory.Certifications.AddCertification(SC.certifications);
            }
            else if (rewardType == "Design")
            {
                CurrentPlayer.Inventory.DesignPoints += rewardAmount;
                CurrentPlayer.Inventory.Certifications.AddCertification(SC.certifications);
            }

            return CurrentPlayer;
        }

        //turns
        private void activationTurns()
        {
            if (turn >= PlayerList.Count)
            {
                //call retropective 
                Retrospective retrospective = new Retrospective(game.PlayerList, PlayerList, 0);
                retrospective.ShowDialog();
                retrospective.calcRetrospective();
                

                game.stockprice = stockPrice;
                game.PlayerList = PlayerList;

                this.Close();
            }
            else
            {
                currentPlayer = PlayerList[turn];
                //Deduct points from the players 
                chargeAndAdd();
                //Draw a situational card for player
                SituationCard sc = sdDeck.DrawCard();
                transferFunds(currentPlayer, sc);


                // Open Situational Card Form and Pass sc to it
                Game.DisplaySituationCardForm(currentPlayer, sc);
                setStatus();
            }
            turn++;
        }

       

        private void chargeAndAdd()
        {
            //HR
            if (trackBoxes[0].playerId == currentPlayer.Id)
            {
                currentPlayer.Inventory.Bitcoin -= hr.chargePlayerSalary();
                addDev();
            }

            //Bootcamp
            if (locationList[1].playerList[1, turn] != 0)
            {
                DiceForm.set_labels(currentPlayer.Name, "Boot Camp");
                roll = DiceForm.showForm();
                System.Threading.Thread.Sleep(1500);
                DiceForm.Hide();
                currentPlayer.Inventory.TrainingPoints = bootCamp.trainingPointCalc(currentPlayer, locationList[1].playerList[1, turn], roll);
            }
            //Whiteboard
            if (locationList[2].playerList[1, turn] != 0)
            {
                DiceForm.set_labels(currentPlayer.Name, "Whiteboard");
                roll = DiceForm.showForm();
                System.Threading.Thread.Sleep(1500);
                DiceForm.Hide();
                currentPlayer.Inventory.DesignPoints = whiteBoard.DesignPointsCalc(currentPlayer, locationList[2].playerList[1, turn], roll);
            }
            //CryptoMarket 
            if (locationList[3].playerList[1, turn] != 0)
            {
                DiceForm.set_labels(currentPlayer.Name, "Crypto Market: Bet Stock");
                roll = DiceForm.showForm();
                System.Threading.Thread.Sleep(1500);
                DiceForm.Hide();
                DiceForm.set_labels(currentPlayer.Name, "Crypto Market: Bought Stock");
                int roll_2 = DiceForm.showForm();
                System.Threading.Thread.Sleep(1500);
                DiceForm.Hide();
                currentPlayer.Inventory.Bitcoin = market.CalcGold(currentPlayer, locationList[3].playerList[1, turn], roll, roll_2, stockPrice);
                stockPrice = currentPlayer.Inventory.Bitcoin;
            }
            setStatus();
        }

        private void addDev()
        {
            currentPlayer.Inventory.Developers++;
        }

        private void Certificates_Click(object sender, EventArgs e)
        {
            //Call form to show all of the player's certificates
            
        }

        
    }
}
public class Box
{
    public PictureBox pictureBox = null;
    public int playerId;
    public bool used = false;
}
