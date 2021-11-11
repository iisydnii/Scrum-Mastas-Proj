﻿/*
 Page Created 
     File Name: ProjectTileForm.cs
     Creator Name: Piper Floyd
     Created Date: 11/07/21
     Purpose: Displays the drawn project tile
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
    public partial class ProjectTileForm : Form
    {
        public ProjectTileForm()
        {
            InitializeComponent();
        }

        private void ProjectTileForm_Load(object sender, EventArgs e)
        {
            label1.Text = Placement_Board.Description;
            label5.Text = Placement_Board.RewardType;
            label7.Text = Placement_Board.RewardValue;

            label6.Text = Placement_Board.CostType;
            label8.Text = Placement_Board.CostValue;
            //label6.Text = Placement_Board.Cost;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}