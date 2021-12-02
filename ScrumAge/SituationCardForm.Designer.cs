
namespace ScrumAge
{
    partial class SituationCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SituationCardForm));
            this.button1 = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.SituationLabel = new System.Windows.Forms.TextBox();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.CostTypeLabel = new System.Windows.Forms.Label();
            this.CostAmountLabel = new System.Windows.Forms.Label();
            this.RewardTypeLabel1 = new System.Windows.Forms.Label();
            this.RewardTypeLabel2 = new System.Windows.Forms.Label();
            this.RewardValueLabel1 = new System.Windows.Forms.Label();
            this.RewardValueLabel2 = new System.Windows.Forms.Label();
            this.CertificateLabel = new System.Windows.Forms.TextBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BackColor = System.Drawing.Color.Transparent;
            this.costLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(22, 289);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(61, 25);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Cost";
            // 
            // SituationLabel
            // 
            this.SituationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(157)))), ((int)(((byte)(69)))));
            this.SituationLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SituationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SituationLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituationLabel.Location = new System.Drawing.Point(60, 163);
            this.SituationLabel.Multiline = true;
            this.SituationLabel.Name = "SituationLabel";
            this.SituationLabel.Size = new System.Drawing.Size(274, 100);
            this.SituationLabel.TabIndex = 2;
            this.SituationLabel.Text = "None\r\nNone\r\nNone\r\nNone";
            this.SituationLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rewardsLabel
            // 
            this.rewardsLabel.AutoSize = true;
            this.rewardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.rewardsLabel.Font = new System.Drawing.Font("Stencil", 13.74545F);
            this.rewardsLabel.Location = new System.Drawing.Point(227, 289);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(110, 25);
            this.rewardsLabel.TabIndex = 3;
            this.rewardsLabel.Text = "Rewards";
            this.rewardsLabel.Click += new System.EventHandler(this.rewardsLabel_Click);
            // 
            // CostTypeLabel
            // 
            this.CostTypeLabel.AutoSize = true;
            this.CostTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostTypeLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTypeLabel.Location = new System.Drawing.Point(22, 317);
            this.CostTypeLabel.Name = "CostTypeLabel";
            this.CostTypeLabel.Size = new System.Drawing.Size(47, 25);
            this.CostTypeLabel.TabIndex = 6;
            this.CostTypeLabel.Text = "CTL";
            // 
            // CostAmountLabel
            // 
            this.CostAmountLabel.AutoSize = true;
            this.CostAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostAmountLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostAmountLabel.Location = new System.Drawing.Point(133, 317);
            this.CostAmountLabel.Name = "CostAmountLabel";
            this.CostAmountLabel.Size = new System.Drawing.Size(48, 25);
            this.CostAmountLabel.TabIndex = 7;
            this.CostAmountLabel.Text = "CAL";
            // 
            // RewardTypeLabel1
            // 
            this.RewardTypeLabel1.AutoSize = true;
            this.RewardTypeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.RewardTypeLabel1.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardTypeLabel1.Location = new System.Drawing.Point(227, 317);
            this.RewardTypeLabel1.Name = "RewardTypeLabel1";
            this.RewardTypeLabel1.Size = new System.Drawing.Size(50, 25);
            this.RewardTypeLabel1.TabIndex = 8;
            this.RewardTypeLabel1.Text = "RTL";
            // 
            // RewardTypeLabel2
            // 
            this.RewardTypeLabel2.AutoSize = true;
            this.RewardTypeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.RewardTypeLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RewardTypeLabel2.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardTypeLabel2.Location = new System.Drawing.Point(214, 364);
            this.RewardTypeLabel2.Name = "RewardTypeLabel2";
            this.RewardTypeLabel2.Size = new System.Drawing.Size(0, 25);
            this.RewardTypeLabel2.TabIndex = 9;
            // 
            // RewardValueLabel1
            // 
            this.RewardValueLabel1.AutoSize = true;
            this.RewardValueLabel1.BackColor = System.Drawing.Color.Transparent;
            this.RewardValueLabel1.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardValueLabel1.Location = new System.Drawing.Point(338, 317);
            this.RewardValueLabel1.Name = "RewardValueLabel1";
            this.RewardValueLabel1.Size = new System.Drawing.Size(51, 25);
            this.RewardValueLabel1.TabIndex = 10;
            this.RewardValueLabel1.Text = "RVL";
            // 
            // RewardValueLabel2
            // 
            this.RewardValueLabel2.AutoSize = true;
            this.RewardValueLabel2.BackColor = System.Drawing.Color.Transparent;
            this.RewardValueLabel2.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardValueLabel2.Location = new System.Drawing.Point(318, 364);
            this.RewardValueLabel2.Name = "RewardValueLabel2";
            this.RewardValueLabel2.Size = new System.Drawing.Size(0, 25);
            this.RewardValueLabel2.TabIndex = 11;
            // 
            // CertificateLabel
            // 
            this.CertificateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(157)))), ((int)(((byte)(69)))));
            this.CertificateLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CertificateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CertificateLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertificateLabel.Location = new System.Drawing.Point(60, 409);
            this.CertificateLabel.Multiline = true;
            this.CertificateLabel.Name = "CertificateLabel";
            this.CertificateLabel.Size = new System.Drawing.Size(274, 53);
            this.CertificateLabel.TabIndex = 13;
            this.CertificateLabel.Text = "CERTLabel";
            this.CertificateLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(102, 64);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(150, 25);
            this.PlayerLabel.TabIndex = 14;
            this.PlayerLabel.Text = "PlayerLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.74545F);
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player:";
            // 
            // SituationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.CertificateLabel);
            this.Controls.Add(this.RewardValueLabel2);
            this.Controls.Add(this.RewardValueLabel1);
            this.Controls.Add(this.RewardTypeLabel2);
            this.Controls.Add(this.RewardTypeLabel1);
            this.Controls.Add(this.CostAmountLabel);
            this.Controls.Add(this.CostTypeLabel);
            this.Controls.Add(this.rewardsLabel);
            this.Controls.Add(this.SituationLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SituationCardForm";
            this.Text = "Situation Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox SituationLabel;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.Label CostTypeLabel;
        private System.Windows.Forms.Label CostAmountLabel;
        private System.Windows.Forms.Label RewardTypeLabel1;
        private System.Windows.Forms.Label RewardTypeLabel2;
        private System.Windows.Forms.Label RewardValueLabel1;
        private System.Windows.Forms.Label RewardValueLabel2;
        private System.Windows.Forms.TextBox CertificateLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label label1;
    }
}