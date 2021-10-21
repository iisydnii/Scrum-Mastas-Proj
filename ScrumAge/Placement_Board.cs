﻿/*
 Page Created 
     File Name: Placement_Board
     Creator Name: Sydni Ward
     Created Date: 09/29/2021
     Purpose: Display Placement Phase
________________________________________________________________________________
Page Modified
    Name, date, line change, what is the change

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
        PictureBox[] bootcamp;
        PictureBox selected;
        int playerId = 0;
        int AvailableDevs = 0;

        public Placement_Board(Player player)
        {
            InitializeComponent();
            playerId = player.Id;
            getAvailableDevs(player);
            createDragAndDrop(player.Id);

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Controlling Changes 
        void getAvailableDevs(Player player)
        {
            int hold = 0;
            hold = player.Inventory.Developers;
            //Check each location if they have devs placed there

            // hold += location.getDevs();

            AvailableDevs = hold;

        }

        // SECTION DRAG AND DROP FUNCTIONS
        void createDragAndDrop(int id) 
        {
            boxes = new PictureBox[] { HRBox, BootCampBox1, BootCampBox2, BootCampBox3, BootCampBox4, BootCampBox5,
                BootCampBox6, BootCampBox7, BootCampBox8, WhiteBoardBox2, WhiteBoardBox3, WhiteBoardBox4, WhiteBoardBox5,
                WhiteBoardBox6, WhiteBoardBox7, WhiteBoardBox8, BitcoinMarketBox1, BitcoinMarketBox2, BitcoinMarketBox3,
                BitcoinMarketBox4, BitcoinMarketBox5, BitcoinMarketBox6, BitcoinMarketBox7, BitcoinMarketBox8, holdDevelopers };

            try
            {
                //Supply your own images here
                switch (player.Id)
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

<<<<<<< Updated upstream
=======
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

            if(filename != "")
            {
                holdDevelopers.BackgroundImage = Image.FromFile(filename);
            }
            else
            {
                holdDevelopers.BackgroundImage = null;
            }
            
        }

>>>>>>> Stashed changes
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
            if (source.Name == "holdDevelopers" )
            {
                //minus 1 dev for the available devs
                AvailableDevs = AvailableDevs - 1;
                //source.BackgroundImage = temp;
                if(AvailableDevs == 0)
                {
                    setImage(5);
                }
            }
            else if (target.Name == "holdDevelopers")
            {
                source.BackgroundImage = null;
                //add 1 dev for the available devs
                AvailableDevs = AvailableDevs + 1;
                if (AvailableDevs != 0)
                {
                    setImage(playerId);
                }
            }
            else // moving to another location
            {
                
                source.BackgroundImage = temp;
            }

        }
    }
}
