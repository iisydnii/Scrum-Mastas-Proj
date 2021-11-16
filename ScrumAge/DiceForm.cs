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
        Dice dice = new Dice();
        int roll_1 = 0;
        int roll_2 = 0;


        public DiceForm()
        {
            InitializeComponent();
        }

        public void showForm()
        {
            Show();
            roll();
        }

        private void roll()
        {

            roll_1 = dice.DiceRoll_1;
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

            roll_2 = dice.DiceRoll_2;

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
            int totalRoll = roll_1 + roll_2;
            
        }

    }
}
