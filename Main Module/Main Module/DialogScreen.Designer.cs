namespace Main_Module
{
    partial class DialogScreen
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
            this.btnOneInstance = new System.Windows.Forms.Button();
            this.btnFollowing = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOneInstance = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oneInstanceBtn
            // 
            this.btnOneInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneInstance.AutoSize = true;
            this.btnOneInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnOneInstance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOneInstance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnOneInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOneInstance.ForeColor = System.Drawing.Color.White;
            this.btnOneInstance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOneInstance.Location = new System.Drawing.Point(9, 31);
            this.btnOneInstance.Name = "oneInstanceBtn";
            this.btnOneInstance.Size = new System.Drawing.Size(202, 32);
            this.btnOneInstance.TabIndex = 10;
            this.btnOneInstance.Text = "Only this instance";
            this.btnOneInstance.UseVisualStyleBackColor = false;
            this.btnOneInstance.Click += new System.EventHandler(this.btn_Click);
            // 
            // followingBtn
            // 
            this.btnFollowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFollowing.AutoSize = true;
            this.btnFollowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnFollowing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFollowing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnFollowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFollowing.ForeColor = System.Drawing.Color.White;
            this.btnFollowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFollowing.Location = new System.Drawing.Point(9, 85);
            this.btnFollowing.Name = "followingBtn";
            this.btnFollowing.Size = new System.Drawing.Size(202, 32);
            this.btnFollowing.TabIndex = 10;
            this.btnFollowing.Text = "All following";
            this.btnFollowing.UseVisualStyleBackColor = false;
            this.btnFollowing.Click += new System.EventHandler(this.btn_Click);
            // 
            // allBtn
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.AutoSize = true;
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(9, 139);
            this.btnAll.Name = "allBtn";
            this.btnAll.Size = new System.Drawing.Size(202, 32);
            this.btnAll.TabIndex = 10;
            this.btnAll.Text = "All events in the series";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btn_Click);
            // 
            // cancelBtn
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(424, 206);
            this.btnCancel.Name = "cancelBtn";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btn_Click);
            // 
            // oneInstanceLbl
            // 
            this.lblOneInstance.AutoSize = true;
            this.lblOneInstance.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneInstance.ForeColor = System.Drawing.Color.White;
            this.lblOneInstance.Location = new System.Drawing.Point(211, 35);
            this.lblOneInstance.Name = "oneInstanceLbl";
            this.lblOneInstance.Size = new System.Drawing.Size(275, 23);
            this.lblOneInstance.TabIndex = 11;
            this.lblOneInstance.Text = "All other events in the series will remain";
            // 
            // followingLbl
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowing.ForeColor = System.Drawing.Color.White;
            this.lblFollowing.Location = new System.Drawing.Point(211, 89);
            this.lblFollowing.Name = "followingLbl";
            this.lblFollowing.Size = new System.Drawing.Size(325, 23);
            this.lblFollowing.TabIndex = 11;
            this.lblFollowing.Text = "This and all the following events will be changed";
            // 
            // allLbl
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.Location = new System.Drawing.Point(211, 143);
            this.lblAll.Name = "allLbl";
            this.lblAll.Size = new System.Drawing.Size(263, 23);
            this.lblAll.TabIndex = 11;
            this.lblAll.Text = "All events in the series will be changed";
            // 
            // DialogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(539, 250);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblFollowing);
            this.Controls.Add(this.lblOneInstance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnFollowing);
            this.Controls.Add(this.btnOneInstance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneInstance;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOneInstance;
        private System.Windows.Forms.Label lblFollowing;
        private System.Windows.Forms.Label lblAll;
    }
}