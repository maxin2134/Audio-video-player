
namespace thinkgear_form
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.lblWelcomeMobile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeText.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeText.ForeColor = System.Drawing.Color.Silver;
            this.lblWelcomeText.Location = new System.Drawing.Point(121, 58);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(102, 23);
            this.lblWelcomeText.TabIndex = 0;
            this.lblWelcomeText.Text = "Welcome in";
            // 
            // lblWelcomeMobile
            // 
            this.lblWelcomeMobile.AutoSize = true;
            this.lblWelcomeMobile.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeMobile.ForeColor = System.Drawing.Color.Silver;
            this.lblWelcomeMobile.Location = new System.Drawing.Point(21, 104);
            this.lblWelcomeMobile.Name = "lblWelcomeMobile";
            this.lblWelcomeMobile.Size = new System.Drawing.Size(317, 23);
            this.lblWelcomeMobile.TabIndex = 1;
            this.lblWelcomeMobile.Text = "MindWave Mobile 2 Audio/Video Player ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(95, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Let\'s start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(357, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcomeMobile);
            this.Controls.Add(this.lblWelcomeText);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioVideoPlayer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Label lblWelcomeMobile;
        private System.Windows.Forms.Button button1;
    }
}