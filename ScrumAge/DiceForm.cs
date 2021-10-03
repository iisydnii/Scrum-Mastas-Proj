/*-------------
Name: ScrumAge
Author: Piper Floyd 
Date created: 09/20/21
File name: DiceForm.cs
Purpose: Creates the methods for the button clicks and labels for the Dice form
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
    public partial class DiceForm : Form
    {
        public DiceForm()
        {
            InitializeComponent();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Dice dice = new Dice();
            label4.Text = dice.RollDice().ToString();

            int count = 0;
            count++;
         
            //Ensures that the dice can only be rolled once
            if (count == 1)
            {
                button1.Enabled = false;
                
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void DiceForm_Load(object sender, EventArgs e)
        {

        }

        // Would remove these unneeded methods -- Austin
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
