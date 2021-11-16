/*
 Page Created 
     File Name: DiceForm.cs
     Creator Name: Piper Floyd
     Created Date: 09/20/21
     Purpose: Acts as a dice roll. 
________________________________________________________________________________
Page Modified
    Name, date, line change, what is the change


*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumAge
{
    public partial class DiceForm : Form
    {
        private bool picBox2WasClicked = false;
<<<<<<< Updated upstream
=======
        Dice dice = new Dice();
        int roll_1 = 0;
        int roll_2 = 0;
        int totalRoll = 0;

>>>>>>> Stashed changes

        Dice dice = new Dice();
   
        public DiceForm()
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream
        private void pictureBox1_Click(object sender, EventArgs e)
        {
=======
        public int showForm()
        {
            Show();
            roll();
            return totalRoll;
        }
>>>>>>> Stashed changes


            //Remove Labels after testing
            label1.Text = dice.DiceRoll_1.ToString();
            label2.Text = dice.DiceRoll_2.ToString();
            label3.Text = dice.Total.ToString();



            int roll_1 = dice.DiceRoll_1;


            int counter = 0;

            var random = new Random();
            var num = random.Next(1, 6);

            List<Image> images = new List<Image>();
            images.Add(ScrumAge.Properties.Resources.dice6);
            images.Add(ScrumAge.Properties.Resources.dice3);
            images.Add(ScrumAge.Properties.Resources.dice5);
            images.Add(ScrumAge.Properties.Resources.dice1);
            images.Add(ScrumAge.Properties.Resources.dice2);
            images.Add(ScrumAge.Properties.Resources.dice4);


            var randomRoll = images.OrderBy(r => random.Next()).ToList();
            var index = 0;
            foreach(var item in images)
            {
                pictureBox1.Image = item;
                pictureBox1.Refresh();
                pictureBox2.Image = randomRoll[index];
                pictureBox2.Refresh();
                Thread.Sleep(180);

                index++;
            }

 


            switch (roll_1)
            {
                case 1:
                    pictureBox1.Image = ScrumAge.Properties.Resources.dice1;
                    break;
                case 2:
                    pictureBox1.Image = ScrumAge.Properties.Resources.dice2;
                    break;
                case 3:
                    pictureBox1.Image = ScrumAge.Properties.Resources.dice3;
                    break;
                case 4:
                    pictureBox1.Image = ScrumAge.Properties.Resources.dice4;
                    break;
                case 5:
                    pictureBox1.Image = ScrumAge.Properties.Resources.dice5;
                    break;
                case 6:
                    pictureBox1.Image = ScrumAge.Properties.Resources.dice6;
                    break;
            }

            int roll_2 = dice.DiceRoll_2;

            switch (roll_2)
            {
                case 1:
                    pictureBox2.Image = ScrumAge.Properties.Resources.dice1;
                    break;
                case 2:
                    pictureBox2.Image = ScrumAge.Properties.Resources.dice2;
                    break;
                case 3:
                    pictureBox2.Image = ScrumAge.Properties.Resources.dice3;
                    break;
                case 4:
                    pictureBox2.Image = ScrumAge.Properties.Resources.dice4;
                    break;
                case 5:
                    pictureBox2.Image = ScrumAge.Properties.Resources.dice5;
                    break;
                case 6:
                    pictureBox2.Image = ScrumAge.Properties.Resources.dice6;
                    break;
            }


        


            int count = 0;
            count++;

            //Ensures that the dice can only be rolled once
            if (count == 1)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
            }
<<<<<<< Updated upstream
=======
            totalRoll = roll_1 + roll_2;
>>>>>>> Stashed changes
        }



        private void DiceForm_Load(object sender, EventArgs e)
        {
        
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picBox2WasClicked = true;
            if (picBox2WasClicked == true)
            {
                pictureBox1_Click(sender, e);
                pictureBox2.Enabled = false;
            }

      
                pictureBox2.Enabled = false;

        }
    }
}
