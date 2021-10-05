/*-------------
Name: ScrumAge
Date created: 09/13/21
File name: SelectPlayersForm
Purpose: display the form to start the game
-------------*/
namespace ScrumAge
{
    partial class SelectPlayersForm
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
            this.Begin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player3Label = new System.Windows.Forms.Label();
            this.Player4Label = new System.Windows.Forms.Label();
            this.Player1TextBox = new System.Windows.Forms.TextBox();
            this.Player2Textbox = new System.Windows.Forms.TextBox();
            this.Player3Textbox = new System.Windows.Forms.TextBox();
            this.Player4Textbox = new System.Windows.Forms.TextBox();
            this.NumOfPlayersDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Begin
            // 
            this.Begin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Begin.BackColor = System.Drawing.Color.Transparent;
            this.Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.Location = new System.Drawing.Point(250, 329);
            this.Begin.Margin = new System.Windows.Forms.Padding(2);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(100, 25);
            this.Begin.TabIndex = 0;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = false;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            this.Begin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Begin_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Consolas", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Scrum Age!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(172, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Your Players";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1Label
            // 
            this.Player1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Player1Label.Location = new System.Drawing.Point(174, 152);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(120, 23);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "Player 1: ";
            // 
            // Player2Label
            // 
            this.Player2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2Label.AutoSize = true;
            this.Player2Label.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Player2Label.Location = new System.Drawing.Point(174, 196);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(109, 23);
            this.Player2Label.TabIndex = 4;
            this.Player2Label.Text = "Player 2:";
            // 
            // Player3Label
            // 
            this.Player3Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player3Label.AutoSize = true;
            this.Player3Label.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Player3Label.Location = new System.Drawing.Point(174, 234);
            this.Player3Label.Name = "Player3Label";
            this.Player3Label.Size = new System.Drawing.Size(109, 23);
            this.Player3Label.TabIndex = 5;
            this.Player3Label.Text = "Player 3:";
            // 
            // Player4Label
            // 
            this.Player4Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player4Label.AutoSize = true;
            this.Player4Label.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Player4Label.Location = new System.Drawing.Point(174, 275);
            this.Player4Label.Name = "Player4Label";
            this.Player4Label.Size = new System.Drawing.Size(109, 23);
            this.Player4Label.TabIndex = 6;
            this.Player4Label.Text = "Player 4:";
            // 
            // Player1TextBox
            // 
            this.Player1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player1TextBox.Location = new System.Drawing.Point(294, 155);
            this.Player1TextBox.Name = "Player1TextBox";
            this.Player1TextBox.Size = new System.Drawing.Size(134, 20);
            this.Player1TextBox.TabIndex = 8;
            // 
            // Player2Textbox
            // 
            this.Player2Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2Textbox.Location = new System.Drawing.Point(294, 196);
            this.Player2Textbox.Name = "Player2Textbox";
            this.Player2Textbox.Size = new System.Drawing.Size(134, 20);
            this.Player2Textbox.TabIndex = 9;
            // 
            // Player3Textbox
            // 
            this.Player3Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player3Textbox.Location = new System.Drawing.Point(294, 237);
            this.Player3Textbox.Name = "Player3Textbox";
            this.Player3Textbox.Size = new System.Drawing.Size(134, 20);
            this.Player3Textbox.TabIndex = 10;
            // 
            // Player4Textbox
            // 
            this.Player4Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player4Textbox.Location = new System.Drawing.Point(294, 278);
            this.Player4Textbox.Name = "Player4Textbox";
            this.Player4Textbox.Size = new System.Drawing.Size(134, 20);
            this.Player4Textbox.TabIndex = 11;
            // 
            // NumOfPlayersDropDown
            // 
            this.NumOfPlayersDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumOfPlayersDropDown.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NumOfPlayersDropDown.FormattingEnabled = true;
            this.NumOfPlayersDropDown.Location = new System.Drawing.Point(229, 113);
            this.NumOfPlayersDropDown.Name = "NumOfPlayersDropDown";
            this.NumOfPlayersDropDown.Size = new System.Drawing.Size(121, 21);
            this.NumOfPlayersDropDown.TabIndex = 12;
            this.NumOfPlayersDropDown.SelectedIndexChanged += new System.EventHandler(this.NumOfPlayersDropDown_SelectedIndexChanged);
            // 
            // SelectPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.NumOfPlayersDropDown);
            this.Controls.Add(this.Player4Textbox);
            this.Controls.Add(this.Player3Textbox);
            this.Controls.Add(this.Player2Textbox);
            this.Controls.Add(this.Player1TextBox);
            this.Controls.Add(this.Player4Label);
            this.Controls.Add(this.Player3Label);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Begin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectPlayersForm";
            this.Text = "Welcome! Select Players";
            this.Load += new System.EventHandler(this.SelectPlayersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Label Player3Label;
        private System.Windows.Forms.Label Player4Label;
        private System.Windows.Forms.TextBox Player1TextBox;
        private System.Windows.Forms.TextBox Player2Textbox;
        private System.Windows.Forms.TextBox Player3Textbox;
        private System.Windows.Forms.TextBox Player4Textbox;
        private System.Windows.Forms.ComboBox NumOfPlayersDropDown;
    }
}

