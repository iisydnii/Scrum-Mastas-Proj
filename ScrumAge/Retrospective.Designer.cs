﻿
namespace ScrumAge
{
    partial class Retrospective
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retrospective));
            this.next_button = new System.Windows.Forms.Button();
            this.theGood = new System.Windows.Forms.Label();
            this.theBad = new System.Windows.Forms.Label();
            this.theUgly = new System.Windows.Forms.Label();
            this.groupTheGood = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupTheBad = new System.Windows.Forms.GroupBox();
            this.groupTheUgly = new System.Windows.Forms.GroupBox();
            this.player = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.theUglyMessage = new System.Windows.Forms.TextBox();
            this.groupTheUgly.SuspendLayout();
            this.SuspendLayout();
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(124)))), ((int)(((byte)(116)))));
            this.next_button.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.next_button.Location = new System.Drawing.Point(667, 400);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(121, 38);
            this.next_button.TabIndex = 0;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = false;
            // 
            // theGood
            // 
            this.theGood.AutoSize = true;
            this.theGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(124)))), ((int)(((byte)(116)))));
            this.theGood.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.theGood.Location = new System.Drawing.Point(157, 104);
            this.theGood.Name = "theGood";
            this.theGood.Size = new System.Drawing.Size(118, 25);
            this.theGood.TabIndex = 1;
            this.theGood.Text = "The Good";
            // 
            // theBad
            // 
            this.theBad.AutoSize = true;
            this.theBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(158)))), ((int)(((byte)(70)))));
            this.theBad.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.theBad.Location = new System.Drawing.Point(344, 104);
            this.theBad.Name = "theBad";
            this.theBad.Size = new System.Drawing.Size(105, 25);
            this.theBad.TabIndex = 2;
            this.theBad.Text = "The Bad";
            // 
            // theUgly
            // 
            this.theUgly.AutoSize = true;
            this.theUgly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(56)))), ((int)(((byte)(54)))));
            this.theUgly.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.theUgly.Location = new System.Drawing.Point(519, 104);
            this.theUgly.Name = "theUgly";
            this.theUgly.Size = new System.Drawing.Size(116, 25);
            this.theUgly.TabIndex = 3;
            this.theUgly.Text = "The Ugly";
            // 
            // groupTheGood
            // 
            this.groupTheGood.BackColor = System.Drawing.Color.Transparent;
            this.groupTheGood.Location = new System.Drawing.Point(143, 132);
            this.groupTheGood.Name = "groupTheGood";
            this.groupTheGood.Size = new System.Drawing.Size(147, 197);
            this.groupTheGood.TabIndex = 4;
            this.groupTheGood.TabStop = false;
            this.groupTheGood.Enter += new System.EventHandler(this.groupTheGood_Enter);
            // 
            // groupTheBad
            // 
            this.groupTheBad.BackColor = System.Drawing.Color.Transparent;
            this.groupTheBad.Location = new System.Drawing.Point(325, 132);
            this.groupTheBad.Name = "groupTheBad";
            this.groupTheBad.Size = new System.Drawing.Size(147, 197);
            this.groupTheBad.TabIndex = 5;
            this.groupTheBad.TabStop = false;
            this.groupTheBad.Enter += new System.EventHandler(this.groupTheBad_Enter);
            // 
            // groupTheUgly
            // 
            this.groupTheUgly.BackColor = System.Drawing.Color.Transparent;
            this.groupTheUgly.Controls.Add(this.theUglyMessage);
            this.groupTheUgly.Location = new System.Drawing.Point(507, 132);
            this.groupTheUgly.Name = "groupTheUgly";
            this.groupTheUgly.Size = new System.Drawing.Size(147, 197);
            this.groupTheUgly.TabIndex = 6;
            this.groupTheUgly.TabStop = false;
            this.groupTheUgly.Enter += new System.EventHandler(this.groupTheUgly_Enter);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.player.Location = new System.Drawing.Point(61, 51);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(56, 22);
            this.player.TabIndex = 7;
            this.player.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.Location = new System.Drawing.Point(123, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.playerName_Click);
            // 
            // theUglyMessage
            // 
            this.theUglyMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(180)))));
            this.theUglyMessage.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.theUglyMessage.Location = new System.Drawing.Point(17, 20);
            this.theUglyMessage.Name = "theUglyMessage";
            this.theUglyMessage.Size = new System.Drawing.Size(100, 25);
            this.theUglyMessage.TabIndex = 0;
            // 
            // Retrospective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.groupTheUgly);
            this.Controls.Add(this.groupTheBad);
            this.Controls.Add(this.groupTheGood);
            this.Controls.Add(this.theUgly);
            this.Controls.Add(this.theBad);
            this.Controls.Add(this.theGood);
            this.Controls.Add(this.next_button);
            this.DoubleBuffered = true;
            this.Name = "Retrospective";
            this.Text = "Retrospective";
            this.groupTheUgly.ResumeLayout(false);
            this.groupTheUgly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label theGood;
        private System.Windows.Forms.Label theBad;
        private System.Windows.Forms.Label theUgly;
        private System.Windows.Forms.GroupBox groupTheGood;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupTheBad;
        private System.Windows.Forms.GroupBox groupTheUgly;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox theUglyMessage;
    }
}