
namespace ScrumAge
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.myRules = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(436, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 434);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(124)))), ((int)(((byte)(116)))));
            this.start.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.start.Location = new System.Drawing.Point(662, 405);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(121, 38);
            this.start.TabIndex = 1;
            this.start.Text = "Strart";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(56)))), ((int)(((byte)(54)))));
            this.goBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.goBack.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.goBack.Location = new System.Drawing.Point(12, 405);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(121, 38);
            this.goBack.TabIndex = 2;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // myRules
            // 
            this.myRules.BackColor = System.Drawing.SystemColors.MenuBar;
            this.myRules.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRules.Location = new System.Drawing.Point(22, 25);
            this.myRules.Name = "myRules";
            this.myRules.Size = new System.Drawing.Size(408, 374);
            this.myRules.TabIndex = 3;
            this.myRules.Text = "Rules Will Be Displayed Here\n";
            this.myRules.TextChanged += new System.EventHandler(this.myRules_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(447, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 106);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.myRules);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "RulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button goBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox myRules;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}