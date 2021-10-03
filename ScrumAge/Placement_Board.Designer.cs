
namespace ScrumAge
{
    partial class Placement_Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placement_Board));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Recruiting = new System.Windows.Forms.ComboBox();
            this.BootCamp = new System.Windows.Forms.ComboBox();
            this.WhiteBoard = new System.Windows.Forms.ComboBox();
            this.CryptoMarket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 159);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Recruiting
            // 
            this.Recruiting.FormattingEnabled = true;
            this.Recruiting.Location = new System.Drawing.Point(116, 187);
            this.Recruiting.Name = "Recruiting";
            this.Recruiting.Size = new System.Drawing.Size(121, 21);
            this.Recruiting.TabIndex = 11;
            this.Recruiting.SelectedIndexChanged += new System.EventHandler(this.Recruiting_SelectedIndexChanged);
            // 
            // BootCamp
            // 
            this.BootCamp.FormattingEnabled = true;
            this.BootCamp.Location = new System.Drawing.Point(272, 187);
            this.BootCamp.Name = "BootCamp";
            this.BootCamp.Size = new System.Drawing.Size(121, 21);
            this.BootCamp.TabIndex = 12;
            this.BootCamp.SelectedIndexChanged += new System.EventHandler(this.BootCamp_SelectedIndexChanged);
            // 
            // WhiteBoard
            // 
            this.WhiteBoard.FormattingEnabled = true;
            this.WhiteBoard.Location = new System.Drawing.Point(432, 187);
            this.WhiteBoard.Name = "WhiteBoard";
            this.WhiteBoard.Size = new System.Drawing.Size(121, 21);
            this.WhiteBoard.TabIndex = 13;
            this.WhiteBoard.SelectedIndexChanged += new System.EventHandler(this.WhiteBoard_SelectedIndexChanged);
            // 
            // CryptoMarket
            // 
            this.CryptoMarket.FormattingEnabled = true;
            this.CryptoMarket.Location = new System.Drawing.Point(590, 187);
            this.CryptoMarket.Name = "CryptoMarket";
            this.CryptoMarket.Size = new System.Drawing.Size(121, 21);
            this.CryptoMarket.TabIndex = 14;
            this.CryptoMarket.SelectedIndexChanged += new System.EventHandler(this.CryptoMarket_SelectedIndexChanged);
            // 
            // Placement_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CryptoMarket);
            this.Controls.Add(this.WhiteBoard);
            this.Controls.Add(this.BootCamp);
            this.Controls.Add(this.Recruiting);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Placement_Board";
            this.Text = "Placement_Board";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Recruiting;
        private System.Windows.Forms.ComboBox BootCamp;
        private System.Windows.Forms.ComboBox WhiteBoard;
        private System.Windows.Forms.ComboBox CryptoMarket;
    }
}