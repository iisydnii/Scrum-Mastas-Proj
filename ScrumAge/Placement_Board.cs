/*
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
        Player player;

        public Placement_Board(Player player)
        {
            InitializeComponent();

            boxes = new PictureBox[] { HRBox, BootCampBox, WhiteBoardBox, BitcoinMarketBox, holdDevelopers };
            this.player = player;

            try
            {
                //Supply your own images here
                switch (player.Id)
                {
                    case 1:
                        holdDevelopers.Image = Image.FromFile(@"Images\red.png");
                        break;
                    case 2:
                        holdDevelopers.Image = Image.FromFile(@"Images\yellow.png");
                        break;
                    case 3:
                        holdDevelopers.Image = Image.FromFile(@"Images\green.png");
                        break;
                    case 4:
                        holdDevelopers.Image = Image.FromFile(@"Images\gray.png");
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

        /// <summary>
        /// Fires after dragging has completed on the target control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PictureBox_DragDrop(object sender, DragEventArgs e)
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
        void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Handle mouse click on picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }

        /// <summary>
        /// Only start DragDrop if the mouse moves. Allows MouseClick to trigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PictureBox_MouseMove(object sender, MouseEventArgs e)
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
        void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = Color.White;
            if (selected == pb)
            {
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle,
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Left
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Top
                   Color.Blue, 5, ButtonBorderStyle.Solid,  // Right
                   Color.Blue, 5, ButtonBorderStyle.Solid); // Bottom
            }
        }

        /// <summary>
        /// Set the selected image, and trigger repaint on all boxes.
        /// </summary>
        /// <param name="pb"></param>
        void SelectBox(PictureBox pb)
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
        /// <param name="source"></param>
        /// <param name="target"></param>
        void SwapImages(PictureBox source, PictureBox target)
        {
            if (source.BackgroundImage == null && target.BackgroundImage == null)
            {
                return;
            }

            var temp = target.BackgroundImage;
            target.BackgroundImage = source.BackgroundImage;
            source.BackgroundImage = temp;
        }
    }
}
