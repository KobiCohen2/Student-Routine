using Calendar_Module;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Main_Module
{
    public partial class FreeTimeDialog : Form
    {

        private ScheduleEvent chosenFreeTime;

        public FreeTimeDialog()
        {
            InitializeComponent();

            //register event handlers
            btnNextWeek.Click += cclFreeTime.NextWeek;
            btnNextWeek.Click += DateUpdate;

            btnLastWeek.Click += cclFreeTime.PrevWeek;
            btnLastWeek.Click += DateUpdate;
        }

        #region Event Handlers
        private void FreeTimeDialog_Load(object sender, EventArgs e)
        {
            //refresh calendar
            cclFreeTime.Refresh();

            //present current week at the begining
            btnCurrentWeek_Click(null, null);
        }

        //update label event handler
        private void DateUpdate(object sender, EventArgs e)
        {
            lblDate.Text = string.Format("{0}", cclFreeTime.SundayDate.ToString("yyyy MMMM"));

        }//end method

        //free time selected, open message box to modify the request
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (chosenFreeTime == null)
                return;

            ExitDialog();
        }

        //same like selectBtn_Click, but occur at item double click
        private void freeTimeCalendar_ScheduleEventDoubleClick(ScheduleEvent scheduleEvent)
        {
            btnSelect_Click(null, null);
        }

        //present current week event handler
        private void btnCurrentWeek_Click(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;
            cclFreeTime.SundayDate = DateTime.Today;
            DateUpdate(null, null);
        }

        //click on calendar event handler
        private void freeTimeCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            //none schedule event selected
            if (cclFreeTime.ScheduleEventItemSelcted == null)
            {
                //Invalidating buttons
                btnSelect.Enabled = false;
                chosenFreeTime = null;
            }
        }

        //select calendar item event hndler
        private void freeTimeCalendar_CalendarItemSelected(ScheduleEvent scheduleEvent)
        {
            if (scheduleEvent.Title != "\u200EFree Time")
            {
                btnSelect.Enabled = false;
                chosenFreeTime = null;
                return;
            }

            chosenFreeTime = scheduleEvent;
            btnSelect.Enabled = true;
        }

        //next week button click, also to invalidate buttons
        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            freeTimeCalendar_MouseClick(null, null);
        }

        #endregion


        //Service method
        private void ExitDialog()
        {

            DialogResult result = MessageBox.Show("Are you sure this is the free time you want to do the task?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        #region Properties

        public ScheduleEvent ChosenFreeTime
        {
            get
            {
                return this.chosenFreeTime;
            }
        }

        public CalendarControl.CalendarControl FreeTimeCalendar
        {
            get
            {
                return this.cclFreeTime;
            }
        }
        #endregion
    }
}
