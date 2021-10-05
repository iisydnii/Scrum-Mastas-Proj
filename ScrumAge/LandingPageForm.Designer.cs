
namespace ScrumAge
{
    partial class LandingPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPageForm));
            this.start = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.start.Cursor = System.Windows.Forms.Cursors.Cross;
            this.start.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(654, 400);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(134, 38);
            this.start.TabIndex = 0;
            this.start.Text = "Strart";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.SystemColors.Highlight;
            this.rules.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.rules.Location = new System.Drawing.Point(26, 400);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(121, 38);
            this.rules.TabIndex = 1;
            this.rules.Text = "Rules";
            this.rules.UseVisualStyleBackColor = false;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(39, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(700, 56);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "Welcome to the Scrum Age";
            // 
            // LandingPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.start);
            this.DoubleBuffered = true;
            this.Name = "LandingPageForm";
            this.Text = "LandingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Label welcome;
    }
}