
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
            this.Recruiting = new System.Windows.Forms.Button();
            this.BootCamp = new System.Windows.Forms.Button();
            this.WhiteBoard = new System.Windows.Forms.Button();
            this.CryptoMarket = new System.Windows.Forms.Button();
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
            this.Recruiting.Location = new System.Drawing.Point(132, 187);
            this.Recruiting.Name = "Recruiting";
            this.Recruiting.Size = new System.Drawing.Size(75, 23);
            this.Recruiting.TabIndex = 6;
            this.Recruiting.Text = "Recruiting";
            this.Recruiting.UseVisualStyleBackColor = true;
            this.Recruiting.Click += new System.EventHandler(this.Recruiting_Click);
            // 
            // BootCamp
            // 
            this.BootCamp.Location = new System.Drawing.Point(302, 187);
            this.BootCamp.Name = "BootCamp";
            this.BootCamp.Size = new System.Drawing.Size(75, 23);
            this.BootCamp.TabIndex = 7;
            this.BootCamp.Text = "BootCamp";
            this.BootCamp.UseVisualStyleBackColor = true;
            this.BootCamp.Click += new System.EventHandler(this.BootCamp_Click);
            // 
            // WhiteBoard
            // 
            this.WhiteBoard.Location = new System.Drawing.Point(450, 187);
            this.WhiteBoard.Name = "WhiteBoard";
            this.WhiteBoard.Size = new System.Drawing.Size(81, 23);
            this.WhiteBoard.TabIndex = 8;
            this.WhiteBoard.Text = "WhiteBoard";
            this.WhiteBoard.UseVisualStyleBackColor = true;
            this.WhiteBoard.Click += new System.EventHandler(this.WhiteBoard_Click);
            // 
            // CryptoMarket
            // 
            this.CryptoMarket.Location = new System.Drawing.Point(598, 187);
            this.CryptoMarket.Name = "CryptoMarket";
            this.CryptoMarket.Size = new System.Drawing.Size(81, 23);
            this.CryptoMarket.TabIndex = 9;
            this.CryptoMarket.Text = "CryptoMarket";
            this.CryptoMarket.UseVisualStyleBackColor = true;
            this.CryptoMarket.Click += new System.EventHandler(this.CryptoMarket_Click);
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
        private System.Windows.Forms.Button Recruiting;
        private System.Windows.Forms.Button BootCamp;
        private System.Windows.Forms.Button WhiteBoard;
        private System.Windows.Forms.Button CryptoMarket;
    }
}