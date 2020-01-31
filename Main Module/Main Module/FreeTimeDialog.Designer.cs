namespace Main_Module
{
    partial class FreeTimeDialog
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeTimeDialog));
            this.cclFreeTime = new CalendarControl.CalendarControl();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.btnCurrentWeek = new System.Windows.Forms.Button();
            this.lblNextWeek = new System.Windows.Forms.Label();
            this.lblLastWeek = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSelectFreeTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cclFreeTime
            // 
            this.cclFreeTime.AllowDrop = true;
            this.cclFreeTime.AllowItemEdit = false;
            this.cclFreeTime.AllowItemResize = false;
            this.cclFreeTime.AllowNew = false;
            this.cclFreeTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cclFreeTime.Calendar = null;
            this.cclFreeTime.CalendarControlView = CalendarControl.CalendarControl.CalendarView.WeekView;
            this.cclFreeTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Sunday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Saturday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            this.cclFreeTime.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5,
        calendarHighlightRange6,
        calendarHighlightRange7};
            this.cclFreeTime.Location = new System.Drawing.Point(12, 127);
            this.cclFreeTime.Name = "cclFreeTime";
            this.cclFreeTime.Size = new System.Drawing.Size(1057, 459);
            this.cclFreeTime.SundayDate = new System.DateTime(2017, 4, 9, 0, 0, 0, 0);
            this.cclFreeTime.TabIndex = 16;
            this.cclFreeTime.TabStop = false;
            this.cclFreeTime.CalendarItemSelected += new CalendarControl.CalendarControl.ScheduleEventMethod(this.freeTimeCalendar_CalendarItemSelected);
            this.cclFreeTime.ScheduleEventDoubleClick += new CalendarControl.CalendarControl.ScheduleEventMethod(this.freeTimeCalendar_ScheduleEventDoubleClick);
            this.cclFreeTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.freeTimeCalendar_MouseClick);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSelect.Enabled = false;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(12, 75);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(108, 35);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastWeek.AutoSize = true;
            this.btnLastWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnLastWeek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLastWeek.BackgroundImage")));
            this.btnLastWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnLastWeek.Location = new System.Drawing.Point(871, 48);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(32, 42);
            this.btnLastWeek.TabIndex = 3;
            this.btnLastWeek.UseVisualStyleBackColor = false;
            this.btnLastWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextWeek.AutoSize = true;
            this.btnNextWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNextWeek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextWeek.BackgroundImage")));
            this.btnNextWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNextWeek.Location = new System.Drawing.Point(1012, 48);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(32, 42);
            this.btnNextWeek.TabIndex = 2;
            this.btnNextWeek.UseVisualStyleBackColor = false;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // btnCurrentWeek
            // 
            this.btnCurrentWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCurrentWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCurrentWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCurrentWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCurrentWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCurrentWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentWeek.Location = new System.Drawing.Point(893, 52);
            this.btnCurrentWeek.Name = "btnCurrentWeek";
            this.btnCurrentWeek.Size = new System.Drawing.Size(130, 32);
            this.btnCurrentWeek.TabIndex = 1;
            this.btnCurrentWeek.Text = "Current Week";
            this.btnCurrentWeek.UseVisualStyleBackColor = false;
            this.btnCurrentWeek.Click += new System.EventHandler(this.btnCurrentWeek_Click);
            // 
            // lblNextWeek
            // 
            this.lblNextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNextWeek.Location = new System.Drawing.Point(976, 93);
            this.lblNextWeek.Name = "lblNextWeek";
            this.lblNextWeek.Size = new System.Drawing.Size(92, 27);
            this.lblNextWeek.TabIndex = 17;
            this.lblNextWeek.Text = "next week";
            // 
            // lblLastWeek
            // 
            this.lblLastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLastWeek.Location = new System.Drawing.Point(859, 93);
            this.lblLastWeek.Name = "lblLastWeek";
            this.lblLastWeek.Size = new System.Drawing.Size(92, 27);
            this.lblLastWeek.TabIndex = 18;
            this.lblLastWeek.Text = "last week";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblDate.Location = new System.Drawing.Point(608, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(237, 38);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectFreeTime
            // 
            this.lblSelectFreeTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSelectFreeTime.AutoSize = true;
            this.lblSelectFreeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFreeTime.ForeColor = System.Drawing.Color.White;
            this.lblSelectFreeTime.Location = new System.Drawing.Point(338, 9);
            this.lblSelectFreeTime.Name = "lblSelectFreeTime";
            this.lblSelectFreeTime.Size = new System.Drawing.Size(404, 55);
            this.lblSelectFreeTime.TabIndex = 20;
            this.lblSelectFreeTime.Text = "Select Free Time";
            // 
            // FreeTimeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1081, 598);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.btnCurrentWeek);
            this.Controls.Add(this.lblNextWeek);
            this.Controls.Add(this.lblLastWeek);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSelectFreeTime);
            this.Controls.Add(this.cclFreeTime);
            this.Controls.Add(this.btnSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1097, 637);
            this.Name = "FreeTimeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Free Time";
            this.Load += new System.EventHandler(this.FreeTimeDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CalendarControl.CalendarControl cclFreeTime;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Button btnCurrentWeek;
        private System.Windows.Forms.Label lblNextWeek;
        private System.Windows.Forms.Label lblLastWeek;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSelectFreeTime;
    }
}