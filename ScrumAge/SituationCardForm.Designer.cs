
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
            this.button1 = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.SituationLabel = new System.Windows.Forms.TextBox();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.CertificateDescLabel = new System.Windows.Forms.TextBox();
            this.CostDescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 468);
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
            this.costLabel.Location = new System.Drawing.Point(55, 289);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(61, 25);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Cost";
            // 
            // SituationLabel
            // 
            this.SituationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(124)))), ((int)(((byte)(116)))));
            this.SituationLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SituationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SituationLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituationLabel.Location = new System.Drawing.Point(60, 142);
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
            this.rewardsLabel.Location = new System.Drawing.Point(224, 289);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(110, 25);
            this.rewardsLabel.TabIndex = 3;
            this.rewardsLabel.Text = "Rewards";
            // 
            // CertificateDescLabel
            // 
            this.CertificateDescLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(124)))), ((int)(((byte)(116)))));
            this.CertificateDescLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CertificateDescLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CertificateDescLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertificateDescLabel.Location = new System.Drawing.Point(179, 317);
            this.CertificateDescLabel.Multiline = true;
            this.CertificateDescLabel.Name = "CertificateDescLabel";
            this.CertificateDescLabel.Size = new System.Drawing.Size(202, 81);
            this.CertificateDescLabel.TabIndex = 5;
            this.CertificateDescLabel.Text = "None\r\nNone\r\nNone\r\n\r\n";
            this.CertificateDescLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CostDescLabel
            // 
            this.CostDescLabel.AutoSize = true;
            this.CostDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostDescLabel.Font = new System.Drawing.Font("Stencil", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostDescLabel.Location = new System.Drawing.Point(55, 335);
            this.CostDescLabel.Name = "CostDescLabel";
            this.CostDescLabel.Size = new System.Drawing.Size(61, 25);
            this.CostDescLabel.TabIndex = 6;
            this.CostDescLabel.Text = "Cost";
            // 
            // SituationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::ScrumAge.Properties.Resources.PlaceHolder_OR_Template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 517);
            this.Controls.Add(this.CostDescLabel);
            this.Controls.Add(this.CertificateDescLabel);
            this.Controls.Add(this.rewardsLabel);
            this.Controls.Add(this.SituationLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "SituationCardForm";
            this.Text = "SituationCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox SituationLabel;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.TextBox CertificateDescLabel;
        private System.Windows.Forms.Label CostDescLabel;
    }
}