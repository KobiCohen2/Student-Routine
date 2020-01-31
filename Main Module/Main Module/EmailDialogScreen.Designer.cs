namespace Main_Module
{
    partial class EmailDialogScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailDialogScreen));
            this.lblForgorpassword1 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtForgotPasswordEmail = new System.Windows.Forms.TextBox();
            this.lblForgotPassword2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForgorpassword
            // 
            this.lblForgorpassword1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblForgorpassword1.AutoSize = true;
            this.lblForgorpassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblForgorpassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgorpassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblForgorpassword1.Location = new System.Drawing.Point(14, 30);
            this.lblForgorpassword1.Name = "lblForgorpassword";
            this.lblForgorpassword1.Size = new System.Drawing.Size(586, 24);
            this.lblForgorpassword1.TabIndex = 12;
            this.lblForgorpassword1.Text = "Enter the email address you use to sign in to Student Routine,";
            // 
            // sendEmailBtn
            // 
            this.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(190, 197);
            this.btnSendEmail.Name = "sendEmailBtn";
            this.btnSendEmail.Size = new System.Drawing.Size(235, 35);
            this.btnSendEmail.TabIndex = 11;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // forgotPasswordEmailTxt
            // 
            this.txtForgotPasswordEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForgotPasswordEmail.BackColor = System.Drawing.Color.Black;
            this.txtForgotPasswordEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForgotPasswordEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtForgotPasswordEmail.ForeColor = System.Drawing.Color.White;
            this.txtForgotPasswordEmail.Location = new System.Drawing.Point(190, 146);
            this.txtForgotPasswordEmail.Name = "forgotPasswordEmailTxt";
            this.txtForgotPasswordEmail.Size = new System.Drawing.Size(235, 29);
            this.txtForgotPasswordEmail.TabIndex = 9;
            this.txtForgotPasswordEmail.Text = "Email";
            // 
            // forgotPasswordLbl2
            // 
            this.lblForgotPassword2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblForgotPassword2.AutoSize = true;
            this.lblForgotPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblForgotPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblForgotPassword2.Location = new System.Drawing.Point(147, 82);
            this.lblForgotPassword2.Name = "forgotPasswordLbl2";
            this.lblForgotPassword2.Size = new System.Drawing.Size(321, 24);
            this.lblForgotPassword2.TabIndex = 12;
            this.lblForgotPassword2.Text = "and we\'ll send you the password.";
            // 
            // EmailDialogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(615, 318);
            this.Controls.Add(this.lblForgotPassword2);
            this.Controls.Add(this.lblForgorpassword1);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtForgotPasswordEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmailDialogScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.EmailDialogScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgorpassword1;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtForgotPasswordEmail;
        private System.Windows.Forms.Label lblForgotPassword2;
    }
}