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
        PictureBox[] boxes;
        PictureBox selected;
        int AvailableDevs = 0;
        int devs = 0; // once set it never changes
     
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

        public Player Player { get; set; }
        ProjectDeck deck = new ProjectDeck();
        //deck.CreateDeck();

        public Placement_Board(Player player)
        {
            InitializeComponent();
            this.Player = player;
            getAvailableDevs();
            createDragAndDrop();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Controlling Changes 
        void getAvailableDevs()
        {
            int hold = 0;
            hold = Player.Inventory.Developers;
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
                //Supply your own images here
                setImage(Player.Id);

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

        //Set Player Images
        public void setImage(int id) 
        {
            string filename = "";
            //Supply your own images here
            switch (id)
            {
                case 1:
                    filename = @"Images\red.png";
                    break;
                case 2:
                    filename = @"Images\yellow.png";
                    break;
                case 3:
                    filename = @"Images\green.png";
                    break;
                case 4:
                    filename = @"Images\gray.png";
                    break;
                case 5:
                    filename = "";
                    break;
            }

            if (filename != "")
            {
                holdDevelopers.BackgroundImage = Image.FromFile(filename);
            }
            else
            {
                holdDevelopers.BackgroundImage = null;
            }
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
                    setImage(5);
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
                    setImage(Player.Id);
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
            setImage(Player.Id);
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
        label6.Text = Player.Name;
        label2.Text = Player.Inventory.TrainingPoints.ToString();
        label10.Text = Player.Inventory.DesignPoints.ToString();
        label12.Text = Player.Inventory.Bitcoin.ToString();
        label3.Text = Player.Inventory.DevelopmentPoints.ToString();
        label7.Text = Player.Inventory.Developers.ToString();


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

        //Location Controls




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;

            QuitGame quitGame = new QuitGame();
            quitGame.StartPosition = FormStartPosition.CenterParent;
            quitGame.ShowDialog();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjectTiles_Enter(object sender, EventArgs e)
        {

        }

        private void Placement_Board_Load(object sender, EventArgs e)
        {

        }

  


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
            Game game = new Game();
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

            if (Player.Id == 1)
            {
                foreach (var pBox in bootCampBoxes) // cycle through the players bootcamp placement boxes
                {
                    if (pBox.BackgroundImage == p1Red) //see if the background of the box is the same as the dev image
                    {
                        counter1++; // if the background image is the same as the dev image than there is a dev there
                    }
                }
                bootCamp.player1 = Player;
                bootCamp.trainingPointCalc(Player.Id, counter1);
            }
            if (Player.Id == 2)
            {
                foreach (var pBox in bootCampBoxes)
                {
                    if (pBox.BackgroundImage == p2Yellow)
                    {
                        counter2++;
                    }
                }
                bootCamp.player2 = Player;
                bootCamp.trainingPointCalc(Player.Id, counter2);
            }
            if (Player.Id == 3)
            {
                foreach (var pBox in bootCampBoxes)
                {
                    if (pBox.BackgroundImage == p3Green)
                    {
                        counter3++;
                    }
                }
                bootCamp.player3 = Player;
                bootCamp.trainingPointCalc(Player.Id, counter3);
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
                bootCamp.player4 = Player;
                bootCamp.trainingPointCalc(Player.Id, counter4);
            }
        }


        private void WhiteBoardPlacement()
        {
            Whiteboard whiteBoard = new Whiteboard();
            List<PictureBox> whiteBoardBoxes = new List<PictureBox>();
            Game game = new Game();
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

            if (Player.Id == 1)
            {
                counter1 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p1Red);
                whiteBoard.player1 = Player;
                whiteBoard.DesignPointsCalc(Player.Id, counter1);
            }

            if (Player.Id == 2)
            {
                counter2 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p2Yellow);
                whiteBoard.player2 = Player;
                whiteBoard.DesignPointsCalc(Player.Id, counter2);
            }

            if (Player.Id == 3)
            {
                counter3 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p3Green);
                whiteBoard.player3 = Player;
                whiteBoard.DesignPointsCalc(Player.Id, counter3);
            }
            else
            {
                counter4 += whiteBoardBoxes.Count(pictureBox => pictureBox.BackgroundImage == p4Gray);
                whiteBoard.player4 = Player;
                whiteBoard.DesignPointsCalc(Player.Id, counter4);
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
            Game game = new Game();
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

            if (Player.Id == 1)
            {
                counter1 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p1Red);
                cyrptoMarket.player1 = Player;
                cyrptoMarket.CalcGold(Player.Id, counter1);
            }

            if (Player.Id == 2)
            {
                counter2 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p2Yellow);
                cyrptoMarket.player2 = Player;
                cyrptoMarket.CalcGold(Player.Id, counter2);
            }

            if (Player.Id == 3)
            {
                counter3 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p3Green);
                cyrptoMarket.player3 = Player;
                cyrptoMarket.CalcGold(Player.Id, counter3);
            }
            else
            {
                counter4 += cyrptoMarketBoxes.Count(pictureBox => pictureBox.BackgroundImage == p4Gray);
                cyrptoMarket.player4 = Player;
                cyrptoMarket.CalcGold(Player.Id, counter4);
            }
        }

        private void Placement_Board_Load_1(object sender, EventArgs e)
        {

        }

        private void ProjectTiles_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
