namespace Main_Module
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lblStudentRoutine = new System.Windows.Forms.Label();
            this.picSplashScreenIcon = new System.Windows.Forms.PictureBox();
            this.prgSplashScreen = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreenIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // studentRoutineLbl
            // 
            this.lblStudentRoutine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentRoutine.AutoSize = true;
            this.lblStudentRoutine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblStudentRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRoutine.ForeColor = System.Drawing.Color.White;
            this.lblStudentRoutine.Location = new System.Drawing.Point(105, 168);
            this.lblStudentRoutine.Name = "studentRoutineLbl";
            this.lblStudentRoutine.Size = new System.Drawing.Size(384, 55);
            this.lblStudentRoutine.TabIndex = 10;
            this.lblStudentRoutine.Text = "Student Routine";
            // 
            // splashScreenIcon
            // 
            this.picSplashScreenIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSplashScreenIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.picSplashScreenIcon.Image = global::Main_Module.Properties.Resources._1490195636_Graduate_male_241;
            this.picSplashScreenIcon.Location = new System.Drawing.Point(233, 32);
            this.picSplashScreenIcon.Name = "splashScreenIcon";
            this.picSplashScreenIcon.Size = new System.Drawing.Size(128, 133);
            this.picSplashScreenIcon.TabIndex = 9;
            this.picSplashScreenIcon.TabStop = false;
            // 
            // progressBar
            // 
            this.prgSplashScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.prgSplashScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.prgSplashScreen.Location = new System.Drawing.Point(0, 261);
            this.prgSplashScreen.MarqueeAnimationSpeed = 10;
            this.prgSplashScreen.Maximum = 600;
            this.prgSplashScreen.Name = "progressBar";
            this.prgSplashScreen.Size = new System.Drawing.Size(595, 47);
            this.prgSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSplashScreen.TabIndex = 12;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(595, 348);
            this.Controls.Add(this.prgSplashScreen);
            this.Controls.Add(this.lblStudentRoutine);
            this.Controls.Add(this.picSplashScreenIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(595, 348);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 348);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Routine";
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreenIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentRoutine;
        private System.Windows.Forms.PictureBox picSplashScreenIcon;
        private System.Windows.Forms.ProgressBar prgSplashScreen;
    }
}