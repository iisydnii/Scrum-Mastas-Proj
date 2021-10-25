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

        public Player Player { get; set; }
        

        public Placement_Board(int id, Player player)
        {
            InitializeComponent();

            Player = player;

            boxes = new PictureBox[] { HRBox, BootCampBox1, BootCampBox2, BootCampBox3, BootCampBox4, BootCampBox5,
                BootCampBox6, BootCampBox7, BootCampBox8, WhiteBoardBox1, WhiteBoardBox2, WhiteBoardBox3, WhiteBoardBox4, WhiteBoardBox5,
                WhiteBoardBox6, WhiteBoardBox7, WhiteBoardBox8, BitcoinMarketBox1, BitcoinMarketBox2, BitcoinMarketBox3,
                BitcoinMarketBox4, BitcoinMarketBox5, BitcoinMarketBox6, BitcoinMarketBox7, BitcoinMarketBox8, holdDevelopers };

            try
            {
                setImage(id);

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

        //SetPlayer Images
        public void setImage(int id) 
        {
            //Supply your own images here
            switch (id)
            {
                case 1:
                    holdDevelopers.BackgroundImage = Image.FromFile(@"Images\red.png");
                    break;
                case 2:
                    holdDevelopers.BackgroundImage = Image.FromFile(@"Images\yellow.png");
                    break;
                case 3:
                    holdDevelopers.BackgroundImage = Image.FromFile(@"Images\green.png");
                    break;
                case 4:
                    holdDevelopers.BackgroundImage = Image.FromFile(@"Images\gray.png");
                    break;
            }
        }

        /// <summary>
        /// Fires after dragging has completed on the target control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
                if (source != target)
                {
                    Console.WriteLine("Do DragDrop from " + source.Name + " to " + target.Name);
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Handle mouse click on picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }

        /// <summary>
        /// Only start DragDrop if the mouse moves. Allows MouseClick to trigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="pb"></param>
        private void SelectBox(PictureBox pb)
        {
            if (selected != pb)
            {
                selected = pb;
                Console.WriteLine("selectbox");
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
        /// <param name="source"></param>
        /// <param name="target"></param>
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
                //source.BackgroundImage = temp;
            }
            else if (target.Name == "holdDevelopers")
            {
                source.BackgroundImage = null;
            }
            else
            {

                source.BackgroundImage = temp;
            }

        }

      
            /// <summary>
            /// Dsiplays the players name and current inventory
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProjectTiles_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Displays the value of the dice roll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            label18.Text = dice.Total.ToString();

            int count = 0;
            count++;

            //Ensures that the dice can only be rolled once
            if (count == 1)
            {
                button1.Enabled = false;

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void BootCampBox3_Click(object sender, EventArgs e)
        {

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
    }
}
