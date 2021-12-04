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
    public partial class CertificationsForm : Form
    {
        public CertificationsForm(Player currentPlayer)
        {
            InitializeComponent();

            int count = 1;
            var certList = "";
            foreach (string certification in currentPlayer.Inventory.Certifications.CertificationsList)
            {
            
                var cert = certification;
                certList += $"{count}. " + certification +  "\n";
                count++;
            }
            label3.Text = certList;
        }

        private void CertificationsForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Close();
        }
    }
}
