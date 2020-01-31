using Calendar_Module;
using System;
using System.Windows.Forms;
namespace Main_Module
{

    public partial class DialogScreen : Form
    {
        private CalendarControl.CalendarControl.ScheduleEventMethod method;
        private Calendar calendar;

        public DialogScreen()
        {
            InitializeComponent();
        }


        #region Event Handlers
        //dialog result 
        private void btn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();

            Button chosenBtn = (Button)sender;

            method = chosenBtn == btnOneInstance ? calendar.RemoveScheduleEvent :
                     chosenBtn == btnFollowing ? calendar.RemoveFollowingScheduleEventsInSeries :
                     chosenBtn == btnAll ? calendar.RemoveAllScheduleEventsInSeries :
                     (CalendarControl.CalendarControl.ScheduleEventMethod)null;

            this.Close();
        }
        #endregion

        #region Properties
        public CalendarControl.CalendarControl.ScheduleEventMethod Method
        {
            get
            {
                return this.method;
            }
            set
            {
                this.method = value;
            }
        }

        public Calendar Calendar
        {
            set { this.calendar = value; }
        }

        public Button BtnAll
        {
            get
            {
                return btnAll;
            }
        }

        public Label LblAll
        {
            get
            {
                return lblAll;
            }
        }
        #endregion
    }
}
