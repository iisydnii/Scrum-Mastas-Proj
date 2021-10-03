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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Open the player select form
            SelectPlayersForm playersForm = new SelectPlayersForm();
            playersForm.ShowDialog();
            //Application.Run(playersForm);
            var list = playersForm.GetPlayers();
            this.Close();
        }
    }
}
