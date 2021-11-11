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
    Piper Floyd, 11/10/21,              Added project tile methods  

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
        public List<Player> PlayerList { get; set; }
        List<Box> trackBoxes;
        PictureBox[] boxes;
        PictureBox selected;
        Player currentPlayer;
        int AvailableDevs = 0;
        int devs = 0; // once set it never changes
        int turn;
        int[,] playerLocationList = new int[2, 4];
        Bootcamp bootCamp = new Bootcamp();
        Whiteboard whiteBoard = new Whiteboard();
        HRLocation hr = new HRLocation();
        CryptoMarket market = new CryptoMarket();
        Random rand = new Random();

        public static string Description = "";
        public static string RewardType = "";
        public static string RewardValue = "";
        public static string CostType = "";
        public static string CostValue = "";

        private bool picBox5WasClicked = false;
        private bool picBox6WasClicked = false;
        private bool picBox7WasClicked = false;
        private bool picBox8WasClicked = false;

        ProjectDeck deck = new ProjectDeck();
        //deck.CreateDeck();

        public Placement_Board(List<Player> PlayerList)
        {
            InitializeComponent();
            this.PlayerList = PlayerList;
            createDragAndDrop();
            createBoxTracker();
            currentPlayer = PlayerList[0];
            turn = 0;
            setImage();
            getAvailableDevs(0);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Save Devs
            //HR
            //HRPlacement();
            //Bootcamp
            //BootCampPlacement();
            //Whiteboard
            //WhiteBoardPlacement();
            //Bitcoin Market

            turn++;
            if (turn == PlayerList.Count)
            {
                turn = 0;
            }
            setUpPlayerTurns();
        }

        private void setUpPlayerTurns()
        {
            Boolean AvailableDevsBool = true;

            AvailableDevsBool = checkPlayersDevs();
            if (AvailableDevsBool == false)
            {
                this.Close();
            }
            else
            {
                getAvailableDevs(turn);
                if (AvailableDevs != 0)
                {
                    currentPlayer = PlayerList[turn];
                }
                setImage();
                //unlock all
                UnlockBoxes();
                //lock all boxes with images

            }
        }

        private Boolean checkPlayersDevs()
        {
            int trueDev = 0;
            for (int i = 0; i <= PlayerList.Count - 1; i++)
            {
                getAvailableDevs(i);
                if (AvailableDevs == 0)
                {}
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
            //Check each location if they have devs placed there
            int i;
            for (i = 0; i <= 3; i++)
            {
                switch (i)
                {
                    case 0:
                        playerLocationList = hr.getPlayerList();
                        break;
                    case 1:
                        playerLocationList = bootCamp.getPlayerList();
                        break;
                    case 2:
                        playerLocationList = whiteBoard.getPlayerList();
                        break;
                    case 3:
                        playerLocationList = market.getPlayerList();
                        break;
                }

                switch (id)
                {
                    case 0:
                        hold -= playerLocationList[1, 0];
                        break;
                    case 1:
                        hold -= playerLocationList[1, 1];
                        break;
                    case 2:
                        hold -= playerLocationList[1, 2];
                        break;
                    case 3:
                        hold -= playerLocationList[1, 3];
                        break;
                }
            }

            AvailableDevs = hold;
            devs = AvailableDevs;
        }


        //Controlling Changes 
        void getAvailableDevs()
        {
            int hold = 0;
            hold = currentPlayer.Inventory.Developers;
            //Check each location if they have devs placed there

            // hold += location.getDevs();

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
            if (source.BackgroundImage == null && target.BackgroundImage == null)
            {
                return;
            }

            var temp = target.BackgroundImage;
            target.BackgroundImage = source.BackgroundImage;
            if (source.Name == "holdDevelopers")
            {
                //minus 1 dev for the available devs
                AvailableDevs = AvailableDevs - 1;
                //source.BackgroundImage = temp;
                if (AvailableDevs == 0)
                {
                    holdDevelopers.BackgroundImage = null;
                }

                if (devs == AvailableDevs)
                {
                    UnlockBoxes();
                }
                else
                {
                    LockBoxes();
                }
            }
            else if (target.Name == "holdDevelopers")
            {
                source.BackgroundImage = null;
                //add 1 dev for the available devs
                AvailableDevs = AvailableDevs + 1;
                if (AvailableDevs != 0)
                {
                    setImage();
                }

                if (devs == AvailableDevs)
                {
                    UnlockBoxes();
                }
                else
                {
                    LockBoxes();
                }
            }
            else // moving to another location
            {
                
                source.BackgroundImage = temp;
            }
        }

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            foreach (var box in boxes)
            {
                if (box.Name != "holdDevelopers")
                {
                    box.BackgroundImage = null;
                }
            }
            AvailableDevs = devs;
            setImage();
            UnlockBoxes();
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

        //LOCK PICTUREBOXES
        private void LockBoxes() 
        { 
            if (HRBox.BackgroundImage != null)
            {
                foreach (var box in boxes)
                {
                    if (box.Name != HRBox.Name )
                    {
                        box.Enabled = false;
                        box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
                        HRBox.Enabled = true;
                        holdDevelopers.Enabled = true;
                    }
                }
            }
            else if (BootCampBox1.BackgroundImage != null || BootCampBox2.BackgroundImage != null ||
                BootCampBox3.BackgroundImage != null || BootCampBox4.BackgroundImage != null ||
                BootCampBox5.BackgroundImage != null || BootCampBox6.BackgroundImage != null ||
                BootCampBox7.BackgroundImage != null || BootCampBox8.BackgroundImage != null) 
            {
                foreach (var box in boxes)
                {
                    if (box.Name != BootCampBox1.Name || box.Name != BootCampBox2.Name || box.Name != BootCampBox3.Name ||
                    box.Name != BootCampBox4.Name || box.Name != BootCampBox5.Name || box.Name != BootCampBox6.Name ||
                    box.Name != BootCampBox7.Name || box.Name != BootCampBox8.Name )
                    {
                        box.Enabled = false;
                        box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
                        BootCampBox1.Enabled = true;
                        BootCampBox2.Enabled = true;
                        BootCampBox3.Enabled = true;
                        BootCampBox4.Enabled = true;
                        BootCampBox5.Enabled = true;
                        BootCampBox6.Enabled = true;
                        BootCampBox7.Enabled = true;
                        BootCampBox8.Enabled = true;
                        holdDevelopers.Enabled = true;
                    }
                }
            }
            else if (WhiteBoardBox1.BackgroundImage != null || WhiteBoardBox2.BackgroundImage != null ||
                WhiteBoardBox3.BackgroundImage != null || WhiteBoardBox4.BackgroundImage != null ||
                WhiteBoardBox5.BackgroundImage != null || WhiteBoardBox6.BackgroundImage != null ||
                WhiteBoardBox7.BackgroundImage != null || WhiteBoardBox8.BackgroundImage != null)
            {
                foreach (var box in boxes)
                {
                    if (box.Name != WhiteBoardBox1.Name || box.Name != WhiteBoardBox2.Name || box.Name != WhiteBoardBox3.Name ||
                    box.Name != WhiteBoardBox4.Name || box.Name != WhiteBoardBox5.Name || box.Name != WhiteBoardBox6.Name ||
                    box.Name != WhiteBoardBox7.Name || box.Name != WhiteBoardBox8.Name && box.Name != holdDevelopers.Name)
                    {
                        box.Enabled = false;
                        box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
                        WhiteBoardBox1.Enabled = true;
                        WhiteBoardBox2.Enabled = true;
                        WhiteBoardBox3.Enabled = true;
                        WhiteBoardBox4.Enabled = true;
                        WhiteBoardBox5.Enabled = true;
                        WhiteBoardBox6.Enabled = true;
                        WhiteBoardBox7.Enabled = true;
                        WhiteBoardBox8.Enabled = true;
                        holdDevelopers.Enabled = true;
                    }
                }
            }
            else if (BitcoinMarketBox1.BackgroundImage != null || BitcoinMarketBox2.BackgroundImage != null ||
                BitcoinMarketBox3.BackgroundImage != null || BitcoinMarketBox4.BackgroundImage != null ||
                BitcoinMarketBox5.BackgroundImage != null || BitcoinMarketBox6.BackgroundImage != null ||
                BitcoinMarketBox7.BackgroundImage != null || BitcoinMarketBox8.BackgroundImage != null)
            {
                foreach (var box in boxes)
                {
                    if (box.Name != BitcoinMarketBox1.Name || box.Name != BitcoinMarketBox2.Name || box.Name != BitcoinMarketBox3.Name ||
                    box.Name != BitcoinMarketBox4.Name || box.Name != BitcoinMarketBox5.Name || box.Name != BitcoinMarketBox6.Name ||
                    box.Name != BitcoinMarketBox7.Name || box.Name != BitcoinMarketBox8.Name && box.Name != holdDevelopers.Name)
                    {
                        box.Enabled = false;
                        box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
                        BitcoinMarketBox1.Enabled = true;
                        BitcoinMarketBox2.Enabled = true;
                        BitcoinMarketBox3.Enabled = true;
                        BitcoinMarketBox4.Enabled = true;
                        BitcoinMarketBox5.Enabled = true;
                        BitcoinMarketBox6.Enabled = true;
                        BitcoinMarketBox7.Enabled = true;
                        BitcoinMarketBox8.Enabled = true;
                        holdDevelopers.Enabled = true;
                    }
                }
            }
            else
            {
                // Do Nothing
            }

        }

        //STATUS CONTROLS
      
        /// <summary>
        /// Dsiplays the players name and current inventory
        /// </summary>
        private void StatusBox_Enter(object sender, EventArgs e)
        {
        label6.Text = currentPlayer.Name;
        label2.Text = currentPlayer.Inventory.TrainingPoints.ToString();
        label10.Text = currentPlayer.Inventory.DesignPoints.ToString();
        label12.Text = currentPlayer.Inventory.Bitcoin.ToString();
        label3.Text = currentPlayer.Inventory.DevelopmentPoints.ToString();
        label7.Text = currentPlayer.Inventory.Developers.ToString();


        //Test updated player resources
        //Player.Pay(1);
        //MessageBox.Show(Player.Inventory.Bitcoin.ToString());

        }


        /// <summary>
        /// Displays the value of the dice roll
        /// </summary>
        private void roll_Click(object sender, EventArgs e)
        {
            //Dice dice = new Dice();
            //label18.Text = dice.Total.ToString();

            //int count = 0;
            //count++;

            ////Ensures that the dice can only be rolled once
            //if (count == 1)
            //{
            //    button1.Enabled = false;

            //}

            DiceForm diceForm = new DiceForm();
            diceForm.Show();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;

            QuitGame quitGame = new QuitGame();
            quitGame.StartPosition = FormStartPosition.CenterParent;
            quitGame.ShowDialog();


        }


        private void ProjectTiles_Enter(object sender, EventArgs e)
        {

        }

        private void Placement_Board_Load(object sender, EventArgs e)
        {

        }

  
        private bool picBox5WasClicked = false;
        private bool picBox6WasClicked = false;
        private bool picBox7WasClicked = false;
        private bool picBox8WasClicked = false;


        /// <summary>
        /// Displays first project tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                ProjectTileForm projectTileForm = new ProjectTileForm();
                projectTileForm.Show();
            }


        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BootCampBox3_Click(object sender, EventArgs e)
        {

        }

        private void WhiteBoardBox6_Click(object sender, EventArgs e)
        {

        }

        private void BitcoinMarketBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays second project tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                ProjectTileForm projectTileForm = new ProjectTileForm();
                projectTileForm.Show();
            }
        }

        /// <summary>
        /// Displays third project tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                ProjectTileForm projectTileForm = new ProjectTileForm();
                projectTileForm.Show();

            }
        }


        /// <summary>
        /// Displays fourht project tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


            ProjectTileForm projectTileForm = new ProjectTileForm();
            projectTileForm.Show();


            if (picBox6WasClicked == true || picBox5WasClicked == true || picBox8WasClicked == true)
            {
                pictureBox7.Enabled = false;
            }
            else
            {
                pictureBox7.Enabled = true;
                picBox7WasClicked = true;
                ProjectTileForm projectTileForm = new ProjectTileForm();
                projectTileForm.Show();

            }
        }

        private void BootCampPlacement()
        {
            Bootcamp bootCamp = new Bootcamp();
            List<PictureBox> bootCampBoxes = new List<PictureBox>();
            bootCampBoxes.Add(BootCampBox1);
            bootCampBoxes.Add(BootCampBox2);
            bootCampBoxes.Add(BootCampBox3);
            bootCampBoxes.Add(BootCampBox4);
            bootCampBoxes.Add(BootCampBox5);
            bootCampBoxes.Add(BootCampBox6);
            bootCampBoxes.Add(BootCampBox7);
            bootCampBoxes.Add(BootCampBox8);
            var p1Red = Image.FromFile(@"Images\red.png");
            var p2Yellow = Image.FromFile(@"Images\yellow.png");
            var p3Green = Image.FromFile(@"Images\green.png");
            var p4Gray = Image.FromFile(@"Images\gray.png");
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            if (currentPlayer.Id == 1)
            {
                foreach (var pBox in bootCampBoxes) // cycle through the players bootcamp placement boxes
                {
                    if (pBox.BackgroundImage == p1Red) //see if the background of the box is the same as the dev image
                    {
                        counter1++; // if the background image is the same as the dev image than there is a dev there
                    }
                }
                bootCamp.player1 = currentPlayer;
                bootCamp.trainingPointCalc(currentPlayer.Id, counter1);
            }
            if (currentPlayer.Id == 2)
            {
                foreach (var pBox in bootCampBoxes)
                {
                    if (pBox.BackgroundImage == p2Yellow)
                    {
                        counter2++;
                    }
                }
                bootCamp.player2 = currentPlayer;
                bootCamp.trainingPointCalc(currentPlayer.Id, counter2);
            }
            if (currentPlayer.Id == 3)
            {
                foreach (var pBox in bootCampBoxes)
                {
                    if (pBox.BackgroundImage == p3Green)
                    {
                        counter3++;
                    }
                }
                bootCamp.player3 = currentPlayer;
                bootCamp.trainingPointCalc(currentPlayer.Id, counter3);
            }
            else
            {
                foreach (var pBox in bootCampBoxes)
                {
                    if (pBox.BackgroundImage == p4Gray)
                    {
                        counter4++;
                    }
                }
                bootCamp.player4 = currentPlayer;
                bootCamp.trainingPointCalc(currentPlayer.Id, counter4);
            }
        }

        private void WhiteBoardPlacement()
        {
            Whiteboard whiteBoard = new Whiteboard();
            List<PictureBox> whiteBoardBoxes = new List<PictureBox>();
            whiteBoardBoxes.Add(WhiteBoardBox1);
            whiteBoardBoxes.Add(WhiteBoardBox2);
            whiteBoardBoxes.Add(WhiteBoardBox3);
            whiteBoardBoxes.Add(WhiteBoardBox4);
            whiteBoardBoxes.Add(WhiteBoardBox5);
            whiteBoardBoxes.Add(WhiteBoardBox6);
            whiteBoardBoxes.Add(WhiteBoardBox7);
            whiteBoardBoxes.Add(WhiteBoardBox8);

            var p1Red = Image.FromFile(@"Images\red.png");
            var p2Yellow = Image.FromFile(@"Images\yellow.png");
            var p3Green = Image.FromFile(@"Images\green.png");
            var p4Gray = Image.FromFile(@"Images\gray.png");

            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;

            if (currentPlayer.Id == 1)
            {
                counter1 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p1Red);
                whiteBoard.player1 = currentPlayer;
                whiteBoard.DesignPointsCalc(currentPlayer.Id, counter1);
            }

            if (currentPlayer.Id == 2)
            {
                counter2 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p2Yellow);
                whiteBoard.player2 = currentPlayer;
                whiteBoard.DesignPointsCalc(currentPlayer.Id, counter2);
            }

            if (currentPlayer.Id == 3)
            {
                counter3 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p3Green);
                whiteBoard.player3 = currentPlayer;
                whiteBoard.DesignPointsCalc(currentPlayer.Id, counter3);
            }
            else
            {
                counter4 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p4Gray);
                whiteBoard.player4 = currentPlayer;
                whiteBoard.DesignPointsCalc(currentPlayer.Id, counter4);
            }
        }

        /// Bitcoin location
        /// 
        /// ** Later, change CalcGold(playerid, numOfDevs, betstock, boughtstock) ** 
        /// </summary>
        private void CryptoMarkerPlacement()

        {
            CryptoMarket cyrptoMarket = new CryptoMarket();
            List<PictureBox> cyrptoMarketBoxes = new List<PictureBox>();
            cyrptoMarketBoxes.Add(BitcoinMarketBox1);
            cyrptoMarketBoxes.Add(BitcoinMarketBox2);
            cyrptoMarketBoxes.Add(BitcoinMarketBox3);
            cyrptoMarketBoxes.Add(BitcoinMarketBox4);
            cyrptoMarketBoxes.Add(BitcoinMarketBox5);
            cyrptoMarketBoxes.Add(BitcoinMarketBox6);
            cyrptoMarketBoxes.Add(BitcoinMarketBox7);
            cyrptoMarketBoxes.Add(BitcoinMarketBox8);


            var p1Red = Image.FromFile(@"Images\red.png");
            var p2Yellow = Image.FromFile(@"Images\yellow.png");
            var p3Green = Image.FromFile(@"Images\green.png");
            var p4Gray = Image.FromFile(@"Images\gray.png");

            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;

            if (currentPlayer.Id == 1)
            {
                counter1 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p1Red);
                cyrptoMarket.player1 = currentPlayer;
                cyrptoMarket.CalcGold(currentPlayer.Id, counter1);
            }

            if (currentPlayer.Id == 2)
            {
                counter2 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p2Yellow);
                cyrptoMarket.player2 = currentPlayer;
                cyrptoMarket.CalcGold(currentPlayer.Id, counter2);
            }

            if (currentPlayer.Id == 3)
            {
                counter3 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p3Green);
                cyrptoMarket.player3 = currentPlayer;
                cyrptoMarket.CalcGold(currentPlayer.Id, counter3);
            }
            else
            {
                counter4 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p4Gray);
                cyrptoMarket.player4 = currentPlayer;
                cyrptoMarket.CalcGold(currentPlayer.Id, counter4);
            }
        }

        private void HRPlacement()
        {
            HRLocation hr = new HRLocation();
            List<PictureBox> hrBox = new List<PictureBox>();
            hrBox.Add(HRBox);

            var p1Red = Image.FromFile(@"Images\red.png");
            var p2Yellow = Image.FromFile(@"Images\yellow.png");
            var p3Green = Image.FromFile(@"Images\green.png");
            var p4Gray = Image.FromFile(@"Images\gray.png");
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            if (currentPlayer.Id == 1)
            {
                foreach (var pBox in hrBox) // cycle through the players bootcamp placement boxes
                {
                    if (pBox.BackgroundImage == p1Red) //see if the background of the box is the same as the dev image
                    {
                        counter1++; // if the background image is the same as the dev image than there is a dev there
                    }
                }
                hr.player1 = currentPlayer;
                hr.placeDevs(currentPlayer.Id, counter1);
            }
            if (currentPlayer.Id == 2)
            {
                foreach (var pBox in hrBox)
                {
                    if (pBox.BackgroundImage == p2Yellow)
                    {
                        counter2++;
                    }
                }
                hr.player2 = currentPlayer;
                hr.placeDevs(currentPlayer.Id, counter2);
            }
            if (currentPlayer.Id == 3)
            {
                foreach (var pBox in hrBox)
                {
                    if (pBox.BackgroundImage == p3Green)
                    {
                        counter3++;
                    }
                }
                hr.player3 = currentPlayer;
                hr.AddDevs(currentPlayer.Id, counter3);
            }
            else
            {
                foreach (var pBox in hrBox)
                {
                    if (pBox.BackgroundImage == p4Gray)
                    {
                        counter4++;
                    }
                }
                hr.player4 = currentPlayer;
                hr.AddDevs(currentPlayer.Id, counter4);
            }
        }


        private void ProjectTiles_Enter_1(object sender, EventArgs e)
        {

        }

    }
}
public class Box
{
    public PictureBox pictureBox = null;
    public bool used = false;
}