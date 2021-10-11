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
    public partial class Developer_DragAndDrop : Placement_Board
    {
        public Developer_DragAndDrop()
        {
            InitializeComponent();

            Developers.DragEnter += pictureBox5_DragEnter;
            Developers.DragDrop += pictureBox5_DragDrop;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox2.Image = bmp;
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }
    }
}
