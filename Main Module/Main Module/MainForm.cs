using Calendar_Module;
using Education_Module;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Main_Module
{
    public partial class MainForm : Form
    {
        private User user;
        private UserData userData;
        private int itemWidth;
        private ScheduleEvent chosenScheduleEvent;
        private DialogScreen dialog = new DialogScreen();
        private FreeTimeDialog freeTimeDialog = new FreeTimeDialog();
        private ScheduleEvent chosenFreeTime;
        private bool editScheduleEventMode;
        private bool liveTailstate = true;
        private string emailMessage;
        private string emailTitle;

        public MainForm()
        {
            InitializeComponent();

            //Make the splash screen appear longer
            Thread.Sleep(555);
        }

        #region Transitions between screens event handlers
        private void MoveToLogInScreen(object sender, System.EventArgs e)
        {
            SetVisible(true, false, false, false, false, false, false, false, false, false, false);
            mppLoginScreen.BringToFront();

            //clear data
            lstTasks.Items.Clear();
            cboAcademicYearDisplayTaskPanel.Items.Clear();
            cboSemesterDisplayTaskPanel.Items.Clear();
            cboCourseDisplayTaskPanel.Items.Clear();
            cboCourseTaskPanel.Items.Clear();
        }
        private void signUpBtn_Click(object sender, System.EventArgs e)
        {
            SetVisible(false, true, false, false, false, false, false, false, false, false, false);
            mppSignUpScreen.BringToFront();

            //clear controls
            txtFullName.Text = txtEmailSignUp.Text = txtPasswordSignUp.Text = txtConfirmPasswordSignUp.Text = "";
            dtpBirthdaySignUp.Value = dtpStartAcativitySignUp.Value = dtpEndActivitySignUp.Value = DateTime.Now;
        }
        private void MoveToCalendarScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, true, false, false, false, false, false, false, false);
            mppCalendarScreen.BringToFront();

            //invalidate buttons
            cclUserCalendar_MouseClick(null, null);

            //set calendar view to the chosen schedule event start time(if exist)
            if (chosenScheduleEvent != null)
            {
                dtpChooseDate.Value = chosenScheduleEvent.StartTime;
            }

            //refresh user calendar
            this.cclUserCalendar.Refresh();
        }
        private void MoveToAddEventScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, false, false, false, false, false, true, false, false);
            mppAddEventScreen.BringToFront();
        }
        private void MoveToEditEventScreen(object sender, System.EventArgs e)
        {
            if (chosenScheduleEvent.IsExam)
            {
                DialogResult result = MessageBox.Show("You can not edit an exam from Calendar screen.\nDo you want to switch to the Exam Screen ?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //invalidate buttons
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnShare.Enabled = false;

                    //prepare exam screen
                    Exam chosenExam = (Exam)chosenScheduleEvent;
                    MoveToExamsScreen(null, null);
                    lstExams.SelectedItem = chosenExam;
                    lstExams_DoubleClick(chosenExam, null);
                    return;
                }
                else
                {
                    return;
                }
            }

            if (chosenScheduleEvent.Task != null)
            {
                DialogResult result = MessageBox.Show("You can not edit a task from Calendar screen.\nDo you want to switch to the Task Screen ?",
                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //invalidate buttons
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnShare.Enabled = false;

                    //prepare task screen
                    Task chosenTask = (Task)chosenScheduleEvent.Task;
                    MoveToTasksScreen(null, null);
                    lstTasks.SelectedItem = chosenTask;
                    lstTasks_DoubleClick(chosenTask, null);
                    return;
                }
                else
                {
                    return;
                }

            }

            SetVisible(false, false, false, false, false, false, false, false, false, true, false);
            mppEditEventScreen.BringToFront();

            if (chosenScheduleEvent.Lesson != null)
            {
                lblEditEvent.Text = "Edit Class";

                //Align label
                lblEditEvent.Left = (this.Width - lblEditEvent.Width) / 2;

                //invalidate controls
                rtfEditEventTitle.Enabled = rtfEditEventDescription.Enabled =

                cboEditEventHowOften.Visible = lblEditEventRepeats.Visible = lblEditEventEnds.Visible =

                dtpEditEventEndRepeatedEvent.Visible = chkEditEventAllDay.Visible = false;

            }
            else
            {
                lblEditEvent.Text = "Edit schedule event";

                //Align label
                lblEditEvent.Left = (this.Width - lblEditEvent.Width) / 2;

                //invalidate controls
                rtfEditEventTitle.Enabled = rtfEditEventDescription.Enabled =

                cboEditEventHowOften.Visible = lblEditEventRepeats.Visible = lblEditEventEnds.Visible =

                dtpEditEventEndRepeatedEvent.Visible = chkEditEventAllDay.Visible = true;
            }
        }
        private void MoveToCoursesScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, false, true, false, false, false, false, false, false);
            mppCoursesScreen.BringToFront();
        }
        private void MoveToMainScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, true, false, false, false, false, false, false, false, false);
            mppMainScreen.BringToFront();

            //refresh main calendar
            this.cclMainCalendar.Refresh();
        }
        private void MoveToTasksScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, false, false, true, false, false, false, false, false);
            mppTasksScreen.BringToFront();
        }
        private void MoveToExamsScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, false, false, false, true, false, false, false, false);
            mppExamsScreen.BringToFront();
        }
        private void MoveToNotesScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, false, false, false, false, true, false, false, false);
            mppNotesScreen.BringToFront();
        }
        private void MoveToSettingsScreen(object sender, System.EventArgs e)
        {
            SetVisible(false, false, false, false, false, false, false, false, false, false, true);
            mppSettingsScreen.BringToFront();
        }

        private void SetVisible(bool login, bool signUp, bool main, bool calendar, bool courses,
                                bool tasks, bool exams, bool notes, bool addEvent, bool editEvent, bool settings)
        {
            mppLoginScreen.Visible = login;
            mppSignUpScreen.Visible = signUp;
            mppMainScreen.Visible = main;
            mppCalendarScreen.Visible = calendar;
            mppCoursesScreen.Visible = courses;
            mppTasksScreen.Visible = tasks;
            mppExamsScreen.Visible = exams;
            mppNotesScreen.Visible = notes;
            mppAddEventScreen.Visible = addEvent;
            mppEditEventScreen.Visible = editEvent;
            mppSettingsScreen.Visible = settings;
        }
        #endregion

        #region Login Screen

        private void mppLoginScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppLoginScreen.Visible)
                return;

            //set defaule values in controls
            txtEmail.Text = "Email";
            txtPassword.Text = "Password";

            mppLoginScreen.Select();

        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            int userIndex = StudentRoutine.IsMember(txtEmail.Text);

            if (txtEmail.Text == "" || txtEmail.Text == "Email")
            {
                MessageBox.Show("enter an email please");
                return;
            }
            else if (txtPassword.Text == "" || txtPassword.Text == "Password")
            {
                MessageBox.Show("enter a password please");
                return;
            }
            else if (StudentRoutine.Users.Count == 0 || userIndex == -1)
            {
                MessageBox.Show("User does not exist in the system");
                return;
            }
            else if (StudentRoutine.Users[userIndex].Password == txtPassword.Text)
            {
                //curent user
                this.user = StudentRoutine.Users[userIndex];
                this.userData = StudentRoutine.Users[userIndex].UserData;
                cclUserCalendar.Calendar = this.userData.Calendar;
                cclMainCalendar.Calendar = this.userData.Calendar;
                freeTimeDialog.FreeTimeCalendar.Calendar = this.userData.Calendar;//free time calendar assignment
                dialog.Calendar = this.userData.Calendar;
                //clear user privacy details
                txtEmail.Text = "Email";
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false; //clear password char
                //system entery
                mppMainScreen.BringToFront();
                mppMainScreen.Visible = true;

            }
            else
            {
                MessageBox.Show("The password is incorrect");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void lklForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailDialogScreen fps = new EmailDialogScreen();
            fps.ShowDialog();
        }
        #endregion

        #region Sign Up Screen
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" ||
               txtEmailSignUp.Text == "" ||
               txtPasswordSignUp.Text == "" ||
               txtConfirmPasswordSignUp.Text == "")
            {
                MessageBox.Show("All fields must be filled in");
                return;
            }
            else if (txtPasswordSignUp.Text != txtConfirmPasswordSignUp.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            else if (!MailService.IsValidEmail(txtEmailSignUp.Text))
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dtpBirthdaySignUp.Value > new DateTime(2007, 1, 1))
            {
                MessageBox.Show("You are too young");
                return;
            }
            else if (dtpEndActivitySignUp.Value - dtpStartAcativitySignUp.Value < TimeSpan.FromHours(4))
            {
                MessageBox.Show("You are lazy!");
                return;
            }
            else if (dtpStartAcativitySignUp.Value > dtpEndActivitySignUp.Value)
            {
                MessageBox.Show("End time must be greater than start time");
                return;
            }
            else if (StudentRoutine.IsMember(txtEmailSignUp.Text) != -1)
            {
                MessageBox.Show("User exists in the system. \nYou can perform a password recovery");
                return;
            }

            //on send email thread
            emailMessage = string.Format("\u200EHi {0},\n\n\u200EWelcome to Student Routine software.\n\u200EWe hope you will enjoy using the software,\n\u200Eand your educational life will be conducted in a good and efficient way", txtFullName.Text);
            emailTitle = "Welcome to Student Routine";
            new Thread(EmailSend).Start();

            TimeRecord activityTime = new TimeRecord(dtpStartAcativitySignUp.Value, dtpEndActivitySignUp.Value);
            User newUser = new User(txtFullName.Text, txtEmailSignUp.Text, txtPasswordSignUp.Text,
                                    activityTime, dtpBirthdaySignUp.Value);

            //set next birthday
            newUser.NextBirthday = new DateTime(DateTime.Now.Year, dtpBirthdaySignUp.Value.Month, dtpBirthdaySignUp.Value.Day, 0, 0, 0);
            if (dtpBirthdaySignUp.Value.Month > DateTime.Now.Month && dtpBirthdaySignUp.Value.Day > DateTime.Now.Day)
                newUser.NextBirthday.AddYears(1);

            StudentRoutine.Users.Add(newUser);
            Calendar userCalendar = new Calendar(txtFullName.Text);
            UserData userData = new UserData(userCalendar);
            newUser.UserData = userData;
            MessageBox.Show("User created successfully");
            MoveToLogInScreen(null, null);
        }
        #endregion

        #region Form Event Handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            //lodaing data
            StudentRoutine.RestoreAll();

            //register event handlers
            btnNextWeek.Click += cclUserCalendar.NextWeek;
            btnNextWeek.Click += DateUpdate;

            btnLastWeek.Click += cclUserCalendar.PrevWeek;
            btnLastWeek.Click += DateUpdate;

            //login screen bring to front
            MoveToLogInScreen(null, null);

            //get focus
            this.Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save
            StudentRoutine.SaveAll();
        }

        //on form resize
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (mppSignUpScreen.Visible)
            {

            }

        }
        #endregion

        #region Main Screen
        private void mppMainScreen_VisibleChanged(object sender, System.EventArgs e)
        {
            if (!mppMainScreen.Visible)
            {
                //realse resources
                tmrLiveTiles.Stop();
                tmrLiveTiles.Dispose();
                return;
            }

            //Birthday Greeting Email
            if (this.user.NextBirthday.Date == DateTime.Now.Date.Date)
            {

                //next birthday
                this.user.NextBirthday += TimeSpan.FromDays(365);

                //set email content
                emailTitle = "\u200EHappy Birthday!";
                emailMessage = string.Format("\u200EHelo {0}, \n\u200ECongratulations on your birthday, \n\u200Efrom Student Routine team", this.user.FullName);

                //start email send thread
                new Thread(EmailSend).Start();

            }

            //turn on timer at the first time
            mppMainScreen.Select();
            tmrLiveTiles_Tick(null, null);

            //turn on timer
            tmrLiveTiles.Start();

            cclMainCalendar.Refresh();
            //set user name and email
            lblName.Text = this.user.FullName;
            lblEmail.Text = this.user.Email;
            lblNameFirstLetter.Text = this.user.FullName.Substring(0, 1).ToUpper();
        }

        private void tmrLiveTiles_Tick(object sender, EventArgs e)
        {
            if (liveTailstate)
            {
                mtlToday.Text = this.userData.TodyScheduleEvents();
                mtlTasks.Text = this.userData.RemainingTasks();
                mtlClasses.Text = this.userData.RemainingClasses();
                mtlExams.Text = this.userData.RemainingExams();
                Animate(mtlToday2, 350, 90);
                Animate(mtlTasks2, 350, 90);
                Animate(mtlClasses2, 350, 90);
                Animate(mtlExams2, 350, 90);
            }
            else
            {
                mtlToday2.Text = this.userData.TodayCourses();
                mtlTasks2.Text = this.userData.NextTask();
                mtlClasses2.Text = this.userData.NextClass();
                mtlExams2.Text = this.userData.NextExam();
            }


            //toggle flag
            liveTailstate = !liveTailstate;
        }

        //Service method
        private void Animate(Control ctl, int msec, int angle)
        {
            int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            int[] effmap = { 0, 0x40000, 0x10, 0x80000 };
            int flags = effmap[1];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;

            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }//end method

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        #endregion

        #region Calendar Screen
        //Calendar Screen Event Handlers
        private void mppCalendarScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppCalendarScreen.Visible)
                return;

            //set current week view
            currentWeekBtn_Click(null, null);


            //set cclUserCalendar time scale
            cclUserCalendar.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.ThirtyMinutes;

            //set date label
            DateUpdate(null, null);
        }

        //current week event handler
        private void currentWeekBtn_Click(object sender, EventArgs e)
        {
            cclUserCalendar.SundayDate = DateTime.Today;
            DateUpdate(null, null);
        }

        //update label event handler
        private void DateUpdate(object sender, EventArgs e)
        {
            lblDate.Text = string.Format("{0}", cclUserCalendar.SundayDate.ToString("yyyy MMMM"));
            dtpChooseDate.Value = cclUserCalendar.SundayDate;

        }//end method

        //choose date event handler
        private void dtpChooseDate_ValueChanged(object sender, EventArgs e)
        {
            cclUserCalendar.SundayDate = dtpChooseDate.Value;
            cclUserCalendar_MouseClick(null, null);
            DateUpdate(null, null);
        }

        private void cclUserCalendar_CalendarItemSelected(ScheduleEvent scheduleEvent)
        {
            chosenScheduleEvent = scheduleEvent;


            //validating buttons
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnShare.Enabled = true;

            //load schedule event data to edit event screen controls
            rtfEditEventTitle.Text = scheduleEvent.Title;
            rtfEditEventLocation.Text = scheduleEvent.Location;
            rtfEditEventDescription.Text = scheduleEvent.Description;
            cboEditEventHowOften.SelectedItem = scheduleEvent.HowOften;
            dtpEditEventEndRepeatedEvent.Value = scheduleEvent.EndReapetedEvent;
            if (chosenScheduleEvent.IsMoreThan1Day)
            {
                dtpEditEventStartTime.Value = scheduleEvent.First.StartTime;
                dtpEditEventEndTime.Value = scheduleEvent.Last.EndTime;
                chkEditEventAllDay.Checked = scheduleEvent.First.AllDay;
                cboEditEventHowOften.SelectedItem = ScheduleEvent.Period.None;
            }
            else
            {
                dtpEditEventStartTime.Value = scheduleEvent.StartTime;
                dtpEditEventEndTime.Value = scheduleEvent.EndTime;
                chkEditEventAllDay.Checked = scheduleEvent.AllDay;
            }
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            EmailDialogScreen emailDialg = new EmailDialogScreen();
            emailDialg.ShareScheduleEvent = chosenScheduleEvent;
            emailDialg.UserName = this.user.FullName;
            emailDialg.ShareMode = true;

            emailDialg.ShowDialog();
        }

        //user calendar mouse click event handler
        private void cclUserCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            //none schedule event selected
            if (cclUserCalendar.ScheduleEventItemSelcted == null)
            {
                //Invalidating buttons
                btnShare.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                chosenScheduleEvent = null;
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (sender == dtpEditEventStartTime)
            {
                dtpEditEventEndTime.Value = dtpEditEventStartTime.Value + TimeSpan.FromMinutes(25);
            }
            else
            {
                dtpAddEventEndTime.Value = dtpAddEventStartTime.Value + TimeSpan.FromMinutes(25);
            }
        }

        #endregion

        #region Add Schedule Event Screen

        private void mppAddEventScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppAddEventScreen.Visible)
                return;

            //set defaulte values in controls
            rtfAddEventTitle.Text = "Untitled schedule event";
            txtAddEventLocation.Text = "Enter a location";
            txtAddEventDescription.Text = "Add a description";
            dtpAddEventStartTime.Value = DateTime.Now;
            dtpAddEventEndTime.Value = DateTime.Now;
            dtpAddEventEndRepeated.Value = DateTime.Now;
            chkAddEventAllDay.Checked = false;
            cboAddeventHowOften.SelectedIndex = 0;
            dtpAddEventEndRepeated.Enabled = false;

            //set dtpAddEventEndRepeated to the minimum event duration
            dtp_ValueChanged(dtpAddEventStartTime, null);
        }

        private void cboEventHowOften_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cboAddeventHowOften)
            {
                dtpAddEventEndRepeated.Enabled =
                    (ScheduleEvent.Period)cboAddeventHowOften.SelectedItem == ScheduleEvent.Period.None ? false : true;
            }
            else
            {
                dtpEditEventEndRepeatedEvent.Enabled =
                                   (ScheduleEvent.Period)cboEditEventHowOften.SelectedItem == ScheduleEvent.Period.None ? false : true;
            }
        }

        //add new schedule event event handler
        private void btnAddEventSave_Click(object sender, EventArgs e)
        {
            SaveScheduleEvent(rtfAddEventTitle, dtpAddEventStartTime, dtpAddEventEndTime, cboAddeventHowOften,
                              dtpAddEventEndRepeated, txtAddEventLocation, txtAddEventDescription, chkAddEventAllDay);
        }

        //Service method
        private void SaveScheduleEvent(RichTextBox rtfTitle, DateTimePicker dtpStart, DateTimePicker dtpEnd, MetroComboBox cboHowOften,
                                       DateTimePicker dtpEndRepeated, RichTextBox rtfLocation, RichTextBox rtfDescription, CheckBox chkAllDay)
        {
            string title, location, description;
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            title = rtfTitle.Text == "Untitled schedule event" ? "" : rtfTitle.Text; ;
            location = rtfLocation.Text == "Enter a location" ? "" : rtfLocation.Text;
            description = rtfDescription.Text == "Add a description" ? "" : rtfDescription.Text;

            if (dtpEnd.Value.Date != dtpStart.Value.Date && (ScheduleEvent.Period)cboHowOften.SelectedItem != ScheduleEvent.Period.None)
            {
                MessageBox.Show("An event that occurs more than one day can not be duplicated");
                return;
            }

            if (chkAllDay.Checked)
            {
                start = start.Date;
                end = end.Date + TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59) + TimeSpan.FromSeconds(59);
            }
            try
            {
                this.userData.Calendar.AddScheduleEvent(start, end, title, location, description,
                                                       (ScheduleEvent.Period)cboHowOften.SelectedItem, dtpEndRepeated.Value);
                MoveToCalendarScreen(null, null);
                dtpChooseDate.Value = start;
            }
            catch (DateMissMatchException)
            {
                MessageBox.Show("The duration of the event is too short");
                dtpAddEventStartTime.CalendarTrailingForeColor = Color.Red;
                dtpAddEventEndTime.CalendarTrailingForeColor = Color.Red;
            }

            //refresh calendar
            cclUserCalendar.Refresh();
        }
        private void chkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chosenChx = (CheckBox)sender;
            if (chosenChx.Checked)
            {
                if (mppAddEventScreen.Visible)
                {
                    this.dtpAddEventStartTime.CustomFormat = "yyyy MMMM dd dddd";
                    this.dtpAddEventEndTime.CustomFormat = "yyyy MMMM dd dddd";
                }
                else
                {
                    this.dtpEditEventStartTime.CustomFormat = "yyyy MMMM dd dddd";
                    this.dtpEditEventEndTime.CustomFormat = "yyyy MMMM dd dddd";
                }
            }
            else
            {
                if (mppAddEventScreen.Visible)
                {
                    this.dtpAddEventStartTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
                    this.dtpAddEventEndTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
                }
                else
                {
                    this.dtpEditEventStartTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
                    this.dtpEditEventEndTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
                }
            }
        }

        private void txtDeleteText_Click(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Text = "";
        }
        #endregion

        #region Edit Schedule Event Screen

        //edit schedule event event handler
        private void btnEditEventSave_Click(object sender, EventArgs e)
        {
            //edit mode
            editScheduleEventMode = true;

            //check event validation
            if (dtpEditEventEndTime.Value - dtpEditEventStartTime.Value < TimeSpan.FromMinutes(25))
            {
                MessageBox.Show("The duration of the event is too short");
                return;
            }

            if (dtpEditEventEndTime.Value.Date != dtpEditEventStartTime.Value.Date && (ScheduleEvent.Period)cboEditEventHowOften.SelectedItem != ScheduleEvent.Period.None)
            {
                MessageBox.Show("An event that occurs more than one day can not be duplicated");
                return;
            }

            //default method
            dialog.Method = this.userData.Calendar.RemoveScheduleEvent;
            //delete event
            btnDelete_Click(null, null);


            //cancel edit
            if (dialog.Method == null)
                return;

            //if the schedule event is part of lessons
            if (chosenScheduleEvent.Lesson != null)
            {
                if (dialog.Method == this.userData.Calendar.RemoveScheduleEvent)
                {
                    chosenScheduleEvent.StartTime = dtpEditEventStartTime.Value;
                    chosenScheduleEvent.EndTime = dtpEditEventEndTime.Value;
                    chosenScheduleEvent.Location = rtfEditEventLocation.Text;

                    this.userData.Calendar.AddScheduleEvent(chosenScheduleEvent);
                }
                else
                {
                    Lesson lesson = (Lesson)chosenScheduleEvent.Lesson;
                    Course course = lesson.Course;
                    List<ScheduleEvent> lessons = course.AddNewLesson(lesson.Type, dtpEditEventStartTime.Value, dtpEditEventEndTime.Value,
                                        course.Semester, rtfEditEventLocation.Text);

                    this.userData.Calendar.AddScheduleEvents(lessons);
                }
            }
            else
            {


                //If the user wants to change a single instance
                if (dialog.Method == this.userData.Calendar.RemoveScheduleEvent && (ScheduleEvent.Period)cboEditEventHowOften.SelectedItem == ScheduleEvent.Period.None)
                {
                    cboEditEventHowOften.SelectedItem = ScheduleEvent.Period.None;
                    dtpEditEventEndRepeatedEvent.Value = DateTime.Today;
                }

                SaveScheduleEvent(rtfEditEventTitle, dtpEditEventStartTime, dtpEditEventEndTime,
                                  cboEditEventHowOften, dtpEditEventEndRepeatedEvent, rtfEditEventLocation,
                                  rtfEditEventDescription, chkEditEventAllDay);

            }
            //exit edit mode
            editScheduleEventMode = true;
            MoveToCalendarScreen(null, null);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //visible buttons
            dialog.BtnAll.Visible = true;
            dialog.LblAll.Visible = true;

            //unvisible all seires button on edit
            if (editScheduleEventMode)
            {
                dialog.BtnAll.Visible = false;
                dialog.LblAll.Visible = false;
                //exit edit mode
                editScheduleEventMode = false;
            }

            //more than 1 day schedule event
            if (chosenScheduleEvent.IsMoreThan1Day)
            {
                this.userData.Calendar.RemoveAllScheduleEventsInSeries(chosenScheduleEvent);
                dialog.Method = this.userData.Calendar.RemoveScheduleEvent;
            }
            else if (chosenScheduleEvent.IsExam)
            {
                //remove from calendar
                this.userData.Calendar.RemoveScheduleEvent(chosenScheduleEvent);
                dialog.Method = this.userData.Calendar.RemoveScheduleEvent;

                //remove from data
                Exam chosenExam = (Exam)chosenScheduleEvent;
                this.userData.FindCourse(chosenExam).Exams.Remove(chosenExam);

                //if there are no exams
                if (this.userData.GetExams().Count == 0)
                {
                    pnlNoExams.Visible = true;
                    pnlNoExams.BringToFront();
                }
            }
            else
            {
                if (!chosenScheduleEvent.IsBelongsToSeries)
                {
                    this.userData.Calendar.RemoveScheduleEvent(chosenScheduleEvent);
                    dialog.Method = this.userData.Calendar.RemoveScheduleEvent;
                }
                else
                {
                    dialog.ShowDialog();

                    if (dialog.Method != null)
                    {
                        dialog.Method(chosenScheduleEvent);

                        if (dialog.Method == this.userData.Calendar.RemoveScheduleEvent && chosenScheduleEvent.HowOften == (ScheduleEvent.Period)cboEditEventHowOften.SelectedItem)
                        {
                            cboEditEventHowOften.SelectedItem = ScheduleEvent.Period.None;
                        }
                    }



                    if (chosenScheduleEvent.Lesson != null &&
                        (dialog.Method == this.userData.Calendar.RemoveAllScheduleEventsInSeries ||
                        dialog.Method == this.userData.Calendar.RemoveFollowingScheduleEventsInSeries))
                    {
                        Lesson lesson = (Lesson)chosenScheduleEvent.Lesson;
                        Course course = lesson.Course;
                        course.RemoveLesson(lesson);
                    }
                }
            }

            if (chosenScheduleEvent.Task != null)
            {
                ((Task)chosenScheduleEvent.Task).WorkOnTask = null;
            }


            //invalidate buttons
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnShare.Enabled = false;

            cclUserCalendar.Refresh();
        }

        private void cclSserCalendar_RemoveScheduleEvent(ScheduleEvent scheduleEvent)
        {
            btnDelete_Click(null, null);
        }

        private void cclUserCalendar_ScheduleEventDoubleClick(ScheduleEvent scheduleEvent)
        {
            MoveToEditEventScreen(null, null);
        }
        #endregion

        #region Courses Screen

        #region Courses panels Transitions
        private void goToLessonBtn_Click(object sender, System.EventArgs e)
        {
            //clear controls
            dtpStartLesson.Value = DateTime.Now;
            nudClassDuration.Value = 0;
            txtLocationClass.Text = "";
            cboLessonPanelType.SelectedIndex = 0;

            if (cboLessonPanelSemester.SelectedItem != null)
                dtpStartLesson.Value = ((Semester)cboLessonPanelSemester.SelectedItem).StartTime;

            //beack to adding course
            btnBackToAddingMode_Click(null, null);

            //bring panel to front
            pnlLesson.BringToFront();
            pnlLesson.Select();

            //set combo boxes
            SetComboBoxes(pnlLesson);

            //set tab stop
            SetTabStop(pnlCourse, false);
            SetTabStop(pnlLesson, true);

            //set tab order
            cboLessonPanelAcademicYear.TabIndex = 0;
            cboLessonPanelSemester.TabIndex = 1;
            cboLessonPanelCourse.TabIndex = 2;
            dtpStartLesson.TabIndex = 3;
            nudClassDuration.TabIndex = 4;
            cboLessonTimeUnit.TabIndex = 5;
            txtLocationClass.TabIndex = 6;
            cboLessonPanelType.TabIndex = 7;
            btnLessonPanelSave.TabIndex = 8;
            btnBackToCourse.TabIndex = 9;
        }

        private void backToAcademicYearBtn_Click(object sender, System.EventArgs e)
        {
            //bring panel to front
            pnlAcademicYear.BringToFront();
            pnlAcademicYear.Select();

            //set combo boxes
            SetComboBoxes(pnlEditAcademicYear);

            rbtAddAcademicYear.Checked = true;
        }

        private void goToCourseBtn_Click(object sender, System.EventArgs e)
        {
            //set cmobo boxes
            SetComboBoxes(pnlCourse);

            //bring panel to front
            pnlCourse.BringToFront();
            pnlCourse.Select();

            //set tab stop
            SetTabStop(pnlSemester, false);
            SetTabStop(pnlAddSemester, false);
            SetTabStop(pnlEditSemester, false);
            SetTabStop(pnlCourse, true);

            //set order
            cboAcademicYearCoursePanel.TabIndex = 0;
            cboSemesterCoursePanel.TabIndex = 1;
            txtCourseName.TabIndex = 2;
            txtLecturer.TabIndex = 3;
            txtPractices.TabIndex = 4;
            btnSaveCoursePanel.TabIndex = 5;
            btnGoToLesson.TabIndex = 6;
            btnBackToSemester.TabIndex = 7;
        }

        private void goToSemesterBtn_Click(object sender, System.EventArgs e)
        {
            //beack to adding course
            btnBackToAddingMode_Click(null, null);

            //set combo boxes
            SetComboBoxes(pnlAddSemester);

            //bring panel to front
            pnlSemester.BringToFront();
            pnlSemester.Select();

            //set tab stop
            SetTabStop(pnlAcademicYear, false);
            SetTabStop(pnlAddNewAcademicYear, false);
            SetTabStop(pnlEditAcademicYear, false);
            SetTabStop(pnlSemester, false);

            if (rbtEditSemester.Checked)
                rbtAddSemester.Checked = true;
            else
                SetTabStop(pnlAddSemester, true);

        }
        #endregion

        private void mppCoursesScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppCoursesScreen.Visible)
                return;

            //no data
            if (this.userData == null)
                return;

            //clear list box
            lstCourses.Items.Clear();


            if (this.userData.AcademicYears.Count == 0)
            {
                //Undo validation
                rbtEditAcademicYear.Enabled = false;
                btnGoToSemester.Enabled = false;
                rbtEditSemester.Enabled = false;
                btnGoToCourse.Enabled = false;
                btnGoToLesson.Enabled = false;

                //no courses
                pnlNoCourses.BringToFront();
                pnlCoursesToPresent.Visible = false;
            }
            else
            {
                //get data
                object[] academicYears = this.userData.AcademicYears.ToArray();
                object[] semesters = this.userData.GetSemesters().ToArray();
                object[] courses = this.userData.GetCourses().ToArray();
                AcademicYear currentYear = this.userData.GetCurrentAcademicYear();
                List<Course> coursesOfCurrentYear = this.userData.GetCoursesOfYear(currentYear);
                object[] coursesOfCurrenYearArray = null;
                if (coursesOfCurrentYear != null)
                {
                    coursesOfCurrenYearArray = coursesOfCurrentYear.ToArray();
                }

                //clear combo boxes
                cboChooseExistAcademicYear.Items.Clear();
                cboAcademicYearSemesterPanel.Items.Clear();
                cboAcademicYearEditSemesterPanel.Items.Clear();
                cboAcademicYearCoursePanel.Items.Clear();
                cboLessonPanelAcademicYear.Items.Clear();
                cboAcademicYearPresentCourse.Items.Clear();
                cboChooseSemester.Items.Clear();
                cboSemesterCoursePanel.Items.Clear();
                cboLessonPanelSemester.Items.Clear();
                cboSemesterPresentCourse.Items.Clear();
                cboLessonPanelCourse.Items.Clear();

                //Loading combo boxes
                cboChooseExistAcademicYear.Items.AddRange(academicYears);
                cboAcademicYearSemesterPanel.Items.AddRange(academicYears);
                cboAcademicYearEditSemesterPanel.Items.AddRange(academicYears);
                cboAcademicYearCoursePanel.Items.AddRange(academicYears);
                cboLessonPanelAcademicYear.Items.AddRange(academicYears);
                cboAcademicYearPresentCourse.Items.AddRange(academicYears);
                cboChooseSemester.Items.AddRange(semesters);
                cboSemesterCoursePanel.Items.AddRange(semesters);
                cboLessonPanelSemester.Items.AddRange(semesters);
                cboSemesterPresentCourse.Items.AddRange(semesters);
                cboLessonPanelCourse.Items.AddRange(courses);


                //validation
                if (semesters.Length == 0)
                {
                    rbtEditSemester.Enabled = false;
                    btnGoToCourse.Enabled = false;
                }
                else
                {
                    rbtEditSemester.Enabled = true;
                    btnGoToCourse.Enabled = true;
                }

                if (courses.Length == 0)
                {
                    //no courses
                    pnlNoCourses.BringToFront();
                    pnlCoursesToPresent.Visible = false;
                    btnGoToLesson.Enabled = false;
                }
                else
                {
                    pnlCoursesToPresent.BringToFront();
                    pnlCoursesToPresent.Visible = true;
                    btnGoToLesson.Enabled = true;
                    //lodaing list box
                    lstCourses.Items.Clear();
                    lstCourses.Items.AddRange(coursesOfCurrenYearArray);
                }

                //validation
                rbtEditAcademicYear.Enabled = true;
                btnGoToSemester.Enabled = true;
            }
            //Set the initial value of the combo boxes
            SetComboBoxes(pnlAddNewAcademicYear);
            SetComboBoxes(pnlEditAcademicYear);
            SetComboBoxes(pnlAddSemester);
            SetComboBoxes(pnlEditSemester);
            SetComboBoxes(pnlCourse);
            SetComboBoxes(pnlLesson);

            //current year and semester in order to display newest courses
            try
            {
                AcademicYear lastYear = this.userData.GetCurrentAcademicYear();
                Semester lastSemester = this.userData.LastSemesterOfCurrentYear(lastYear);

                foreach (Semester s in lastYear.Semsters)
                {
                    if (s.Courses.Count != 0)
                    {
                        lstCourses.Items.Clear();
                        cboAcademicYearPresentCourse.SelectedItem = lastYear;
                        cboSemesterPresentCourse.SelectedItem = s;
                        lstCourses.Items.Clear();
                        lstCourses.Items.AddRange(s.Courses.ToArray());
                        break;
                    }

                }
            }
            catch (Exception) { }


            //start at academic year panel
            backToAcademicYearBtn_Click(null, null);

            //set tab stop status
            SetTabStop(pnlAcademicYear, false);
            SetTabStop(pnlAddNewAcademicYear, true);
            SetTabStop(pnlEditAcademicYear, false);
            SetTabStop(pnlSemester, false);
            SetTabStop(pnlAddSemester, false);
            SetTabStop(pnlEditSemester, false);
            SetTabStop(pnlCourse, false);
            SetTabStop(pnlLesson, false);
        }
        //
        //Academic Year
        //
        //Switch between Add Panel and Edit Panel event handler
        private void rbtAddAcademicYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAddAcademicYear.Checked)
            {
                //fix tab order

                SetTabStop(pnlAddNewAcademicYear, true);
                SetTabStop(pnlEditAcademicYear, false);

                pnlEditAcademicYear.Visible = false;
                pnlAddNewAcademicYear.Visible = true;
                pnlAddNewAcademicYear.BringToFront();
                SetTabStop(pnlAcademicYear, false);
                dtpStartAcademicYear.TabIndex = 0;
                dtpEndAcademicYear.TabIndex = 1;
                cboAcademicYearNameAddPanel.TabIndex = 2;
                btnSaveAcademicYearPanel.TabIndex = 3;
                SetTabStop(pnlAcademicYear, true);
                btnGoToSemester.TabIndex = 4;
                btnCoursesBack.TabIndex = 5;

                pnlAddNewAcademicYear.Select();
            }
            else
            {
                //set combo boxes
                SetComboBoxes(pnlEditAcademicYear);

                //fix tab order
                pnlAddNewAcademicYear.Visible = false;
                pnlEditAcademicYear.Visible = true;
                pnlEditAcademicYear.BringToFront();
                cboChooseExistAcademicYear.TabIndex = 0;
                btnDeleteAcademicYear.TabIndex = 1;
                dtpStartAcademicYearEditPanel.TabIndex = 2;
                dtpEndAcademicYearEditPanel.TabIndex = 3;
                cboAcademicYearNameEditPanel.TabIndex = 4;
                btnSaveEditedAcademicYear.TabIndex = 5;

                SetTabStop(pnlEditAcademicYear, true);
                SetTabStop(pnlAddNewAcademicYear, false);

                pnlEditAcademicYear.Select();

            }
        }
        //save new academic year event handler
        private void btnSaveAcademicYearPanel_Click(object sender, EventArgs e)
        {
            bool yearAdded = false;
            SaveAcademicYear(ref yearAdded, dtpStartAcademicYear, dtpEndAcademicYear, cboAcademicYearNameAddPanel);

            if (!yearAdded)
                return;

            btnGoToSemester.Enabled = true;
            rbtEditAcademicYear.Enabled = true;

            MessageBox.Show("A new academic year was successfully created");
        }
        //save edited academic year event handler
        private void saveEditedAcademicYearBtn_Click(object sender, EventArgs e)
        {
            bool yearAdded = false;

            //create new one with the changes
            SaveAcademicYear(ref yearAdded, dtpStartAcademicYearEditPanel, dtpEndAcademicYearEditPanel, cboAcademicYearNameEditPanel);

            if (!yearAdded)
                return;

            AcademicYear year = (AcademicYear)cboChooseExistAcademicYear.SelectedItem;
            //Delete the old one
            user.UserData.AcademicYears.Remove(year);
            //Remove from combo box
            cboChooseExistAcademicYear.Items.Remove(year);

            MessageBox.Show("The requested academic year was successfully updated");
        }

        //service method
        private void SaveAcademicYear(ref bool yearAdded, DateTimePicker dtpStart, DateTimePicker dtpEnd, MetroComboBox cboYearNumber)
        {
            //check validation
            if (dtpEnd.Value < dtpStart.Value)
            {
                MessageBox.Show("The length of an academic year can not be completed before it begins");
                return;
            }
            else if (dtpEnd.Value - dtpStart.Value < TimeSpan.FromDays(180))
            {
                MessageBox.Show("Academic year can not be less than 6 months");
                return;
            }

            try
            {
                AcademicYear year = this.userData[(AcademicYear.AcademicYearName)cboYearNumber.SelectedItem];
            }
            catch (KeyNotFoundException)
            {
                //data is okay
                yearAdded = true;

                //create new academic year
                AcademicYear newAcademicYear = new AcademicYear(dtpStart.Value, dtpEnd.Value,
                                                               (AcademicYear.AcademicYearName)cboYearNumber.SelectedItem);

                //update data
                this.userData.AcademicYears.Add(newAcademicYear);
                this.userData.AcademicYears.Sort();

                //update combo boixes

                cboChooseExistAcademicYear.Items.Add(newAcademicYear);
                cboAcademicYearSemesterPanel.Items.Add(newAcademicYear);
                cboAcademicYearEditSemesterPanel.Items.Add(newAcademicYear);
                cboAcademicYearCoursePanel.Items.Add(newAcademicYear);
                cboLessonPanelAcademicYear.Items.Add(newAcademicYear);
                cboAcademicYearPresentCourse.Items.Add(newAcademicYear);
                cboAcademicYearDisplayTaskPanel.Items.Add(newAcademicYear);
                cboAcademicYearDisplayExamPanel.Items.Add(newAcademicYear);

                return;
            }
            MessageBox.Show("This academic year exists");

        }
        //load academic year data event handler
        private void cboChooseExistAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load data to controls
            AcademicYear year = (AcademicYear)cboChooseExistAcademicYear.SelectedItem;
            dtpStartAcademicYearEditPanel.Value = year.StartTime;
            dtpEndAcademicYearEditPanel.Value = year.EndTime;
            cboAcademicYearNameEditPanel.SelectedItem = year.Name;
        }
        //Delete academic year event handler
        private void btnDeleteAcademicYear_Click(object sender, EventArgs e)
        {
            AcademicYear year = (AcademicYear)cboChooseExistAcademicYear.SelectedItem;

            if (year == null)//empty item was deleted
                return;
            //Remove from combo boxes
            cboChooseExistAcademicYear.Items.Remove(year);
            cboAcademicYearEditSemesterPanel.Items.Remove(year);
            cboAcademicYearSemesterPanel.Items.Remove(year);
            cboAcademicYearCoursePanel.Items.Remove(year);
            cboLessonPanelAcademicYear.Items.Remove(year);
            cboAcademicYearPresentCourse.Items.Remove(year);
            cboAcademicYearDisplayTaskPanel.Items.Remove(year);
            cboAcademicYearDisplayExamPanel.Items.Remove(year);

            //Remove from data
            this.userData.AcademicYears.Remove(year);
            this.userData.AcademicYears.Sort();

            //check if there is academic year after remove
            if (cboChooseExistAcademicYear.Items.Count == 0)
            {
                rbtAddAcademicYear.Checked = true;
                rbtEditAcademicYear.Enabled = false;
            }

            MessageBox.Show("Academic year was successfully deleted");
        }
        //
        //Semester
        //
        //Switch between Add Panel and Edit Panel event handler
        private void rbtAddSemester_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAddSemester.Checked)
            {
                pnlEditSemester.Visible = false;
                pnlAddSemester.Visible = true;
                pnlAddSemester.BringToFront();
                SetTabStop(pnlSemester, false);
                cboAcademicYearSemesterPanel.TabIndex = 0;
                dtpStartSemester.TabIndex = 1;
                dtpEndSemester.TabIndex = 2;
                cboSemesterName.TabIndex = 3;
                btnSaveSemesrerPanel.TabIndex = 4;
                SetTabStop(pnlSemester, false);
                btnGoToCourse.TabIndex = 0;
                btnBackToAcademicYear.TabIndex = 1;

                SetTabStop(pnlAddSemester, true);
                SetTabStop(pnlEditSemester, false);
                pnlAddSemester.Select();


            }
            else
            {
                //set combo boxes
                SetComboBoxes(pnlEditSemester);

                //fix tab order
                pnlAddSemester.Visible = false;
                pnlEditSemester.Visible = true;
                pnlEditSemester.BringToFront();
                SetTabStop(pnlSemester, false);
                cboAcademicYearEditSemesterPanel.TabIndex = 0;
                cboChooseSemester.TabIndex = 1;
                btnDeleteSemester.TabIndex = 2;
                dtpStartSemesterEditPanel.TabIndex = 3;
                dtpEndSemesterEditPanel.TabIndex = 4;
                cboSemesterNameEditPanel.TabIndex = 5;
                btnSaveEditedSemester.TabIndex = 6;
                SetTabStop(pnlSemester, true);
                btnGoToCourse.TabIndex = 0;
                btnBackToAcademicYear.TabIndex = 1;

                SetTabStop(pnlEditSemester, true);
                SetTabStop(pnlAddSemester, false);
                pnlEditSemester.Select();
            }
        }
        //save new semester event handler
        private void btnSaveSemesrerPanel_Click(object sender, EventArgs e)
        {
            bool semesterAdded = false;
            SaveSemester(ref semesterAdded, cboAcademicYearSemesterPanel, dtpStartSemester, dtpEndSemester, cboSemesterName);

            //if the semester does not added
            if (!semesterAdded)
                return;

            btnGoToCourse.Enabled = true;

            MessageBox.Show("New semester successfully created");

            rbtEditSemester.Enabled = true; // validate button
        }
        //service method
        private void SaveSemester(ref bool semesterAdded, MetroComboBox cboYear, DateTimePicker dtpStart, DateTimePicker dtpEnd, MetroComboBox cboSemesterNum)
        {
            AcademicYear academicYear = (AcademicYear)cboYear.SelectedItem;

            //check validation
            if (dtpEnd.Value.Date < dtpStart.Value.Date)
            {
                MessageBox.Show("The length of an semester can not be completed before it begins");
                return;
            }
            else if ((Semester.SemesterName)cboSemesterNum.SelectedItem == Semester.SemesterName.SemesterA ||
                    (Semester.SemesterName)cboSemesterNum.SelectedItem == Semester.SemesterName.SemesterB)
            {
                if (academicYear.StartTime.Date > dtpStart.Value.Date || academicYear.EndTime.Date < dtpEnd.Value.Date)
                {
                    MessageBox.Show("A semester that is not a summer semester, must occur at the academic year time interval");
                    return;
                }

                if (dtpEnd.Value - dtpStart.Value < TimeSpan.FromDays(60))
                {
                    MessageBox.Show("Semester can not be less than 60 days");
                    return;
                }
            }
            else if (dtpEnd.Value - dtpStart.Value < TimeSpan.FromDays(28))
            {
                MessageBox.Show("Summer semester can not be less than 28 days");
                return;
            }

            if (this.userData.IsSemesterExists(academicYear, (Semester.SemesterName)cboSemesterNum.SelectedItem))
            {
                MessageBox.Show("This semester exists");
                return;
            }

            //data is okay
            semesterAdded = true;

            //create a new semester
            Semester newSemester = new Semester(dtpStart.Value, dtpEnd.Value, (Semester.SemesterName)cboSemesterNum.SelectedItem);

            //update data
            academicYear.AddSemester(newSemester);
            academicYear.Semsters.Sort();

            //update combo boxes
            cboChooseSemester.Items.Add(newSemester);
            cboSemesterCoursePanel.Items.Add(newSemester);
            cboLessonPanelSemester.Items.Add(newSemester);
            cboSemesterPresentCourse.Items.Add(newSemester);
            cboSemesterDisplayTaskPanel.Items.Add(newSemester);
            cboSemesterDisplayExamPanel.Items.Add(newSemester);
        }
        //save edited semester event handler
        private void btnSaveEditedSemester_Click(object sender, EventArgs e)
        {

            bool semesterAdded = false;

            //create new one with the changes
            SaveSemester(ref semesterAdded, cboAcademicYearEditSemesterPanel, dtpStartSemesterEditPanel, dtpEndSemesterEditPanel, cboSemesterNameEditPanel);

            if (!semesterAdded)
                return;

            //delete the old one
            AcademicYear year = (AcademicYear)cboAcademicYearEditSemesterPanel.SelectedItem;
            Semester semester = (Semester)cboChooseSemester.SelectedItem;
            year.Semsters.Remove(semester);
            //remove from combo box
            cboChooseSemester.Items.Remove(semester);

            MessageBox.Show("The requested semester was successfully updated");
        }
        //load semester data event handler
        private void cboChooseSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Semester semester = (Semester)((MetroComboBox)sender).SelectedItem;
            //display semester courses
            if (sender == cboLessonPanelSemester)
            {
                SetCoursesOfSemester(cboLessonPanelCourse, semester);
                dtpStartLesson.Value = semester.StartTime;
            }


            if (sender == cboSemesterPresentCourse)
            {
                //clear list box
                lstCourses.Items.Clear();
                //load courses
                Course[] courses;
                try { courses = semester.Courses.ToArray(); }
                catch (Exception) { return; }

                //add to list box chosen courses of semester
                lstCourses.Items.AddRange(courses);

            }

            //load data to controls
            if (sender == cboChooseSemester)
            {
                cboAcademicYearEditSemesterPanel.SelectedItem = this.userData.FindAcademicYear(semester);
                dtpStartSemesterEditPanel.Value = semester.StartTime;
                dtpEndSemesterEditPanel.Value = semester.EndTime;
                cboSemesterNameEditPanel.SelectedItem = semester.Name;
            }
        }
        //service method
        private void SetCoursesOfSemester(MetroComboBox cbo, Semester semester)
        {
            //clear old courses
            cbo.Items.Clear();

            if (semester == null)
                return;

            //the courses
            List<Course> courses = semester.Courses;

            //if there are courses
            if (courses != null)
            {
                cbo.Items.AddRange(courses.ToArray());
                if (cbo.Items.Count != 0)
                    cbo.SelectedIndex = 0;
            }
        }
        //Set semesters of selected academic year event handler
        private void cboAcademicYearEditSemesterPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcademicYear year = (AcademicYear)((MetroComboBox)sender).SelectedItem;
            try
            {
                if (year.Semsters == null)
                    return;
            }
            catch (Exception) { return; }

            object[] semestersOfYear = year.Semsters.ToArray();
            if (sender == cboAcademicYearEditSemesterPanel)
            {
                SetSemesterOfYear(cboChooseSemester, semestersOfYear);
            }
            else if (sender == cboAcademicYearCoursePanel)
            {
                SetSemesterOfYear(cboSemesterCoursePanel, semestersOfYear);
            }
            else if (sender == cboLessonPanelAcademicYear)
            {
                SetSemesterOfYear(cboLessonPanelSemester, semestersOfYear);
            }
            else if (sender == cboAcademicYearPresentCourse)
            {
                SetSemesterOfYear(cboSemesterPresentCourse, semestersOfYear);
            }
        }
        //service method
        private void SetSemesterOfYear(MetroComboBox cbo, object[] semesterOfYear)
        {
            cbo.Items.Clear();
            cbo.Items.AddRange(semesterOfYear);

            if (cbo.Items.Count != 0)
                cbo.SelectedIndex = 0;
        }
        //Delete semester event handler
        private void btnDeleteSemester_Click(object sender, EventArgs e)
        {
            Semester semester = (Semester)cboChooseSemester.SelectedItem;
            AcademicYear year = this.userData.FindAcademicYear(semester);

            if (semester == null)//empty item was deleted
                return;

            //Remove from combo box
            cboChooseSemester.Items.Remove(semester);
            cboSemesterCoursePanel.Items.Remove(semester);
            cboLessonPanelSemester.Items.Remove(semester);
            cboSemesterPresentCourse.Items.Remove(semester);
            cboSemesterDisplayTaskPanel.Items.Remove(semester);
            cboSemesterDisplayExamPanel.Items.Remove(semester);

            //Remove from data
            year.Semsters.Remove(semester);
            year.Semsters.Sort();

            //check if there is semester after remove
            if (cboChooseSemester.Items.Count == 0)
            {
                rbtAddSemester.Checked = true;
                rbtEditSemester.Enabled = false;
            }

            MessageBox.Show("Academic year was successfully deleted");
        }
        //
        //Course
        //
        //selecting course event handler
        private void lstCourses_DoubleClick_1(object sender, EventArgs e)
        {
            //if list box is empty
            if (lstCourses.Items.Count == 0)
                return;

            Course chosenCourse = (Course)lstCourses.SelectedItem;
            Semester semester = this.userData.FindSemester(chosenCourse);
            AcademicYear year = this.userData.FindAcademicYear(semester);

            //course panel
            pnlCourse.BringToFront();

            //enter to edit mode
            lblAddCourse.Text = "Edit a course";
            pnlBackToAddingMode.BringToFront();
            pnlDeletecoursep.BringToFront();

            //load course data to controls
            cboAcademicYearCoursePanel.SelectedItem = year;
            cboSemesterCoursePanel.SelectedItem = semester;
            txtCourseName.Text = chosenCourse.Name;
            txtLecturer.Text = chosenCourse.Lecturer;
            txtPractices.Text = chosenCourse.Practices;
        }
        //save new course event handler
        private void btnSaveCoursePanel_Click(object sender, EventArgs e)
        {
            AcademicYear year = (AcademicYear)cboAcademicYearCoursePanel.SelectedItem;
            Semester semester = (Semester)cboSemesterCoursePanel.SelectedItem;
            List<Lesson> lessons = new List<Lesson>();
            bool editedCourse = false;
            string message;


            //check validation
            if (txtCourseName.Text == "" || txtLecturer.Text == "" || txtPractices.Text == "")
            {
                MessageBox.Show("You must fill out all fields");
                return;
            }

            if (lblAddCourse.Text == "Edit a course")//edit mode
            {
                //turn on flag
                editedCourse = true;
                Course chosenCourse = (Course)lstCourses.SelectedItem;
                //save courses lessons
                lessons = chosenCourse.Lessons;
                //remove from data
                semester.Courses.Remove(chosenCourse);
                //remove from combo box
                cboLessonPanelCourse.Items.Remove(chosenCourse);
                //remove from list box
                lstCourses.Items.Remove(chosenCourse);
            }

            //set the message
            message = editedCourse ? "Course successfully updated" : "New course successfully created";

            //create new course
            Course newCourse = new Course(txtCourseName.Text, txtLecturer.Text, txtPractices.Text, semester);
            //update lessons data
            foreach (Lesson l in lessons)
            {
                foreach (ScheduleEvent se in l.Lessons)
                {
                    se.Title = newCourse.Name;
                }
            }
            //Assigning the lessons to the course
            newCourse.Lessons = lessons;
            MessageBox.Show(message);

            btnGoToLesson.Enabled = true; //validate

            //Evacuation of the label indicating that there are no courses
            pnlCoursesToPresent.BringToFront();
            pnlCoursesToPresent.Visible = true;

            //update data
            semester.Courses.Add(newCourse);
            semester.Courses.Sort();


            //update list box
            lstCourses.Items.Add(newCourse);
            cboAcademicYearPresentCourse.SelectedItem = year;

            //update combo boxes
            cboLessonPanelCourse.Items.Add(newCourse);
            cboCourseTaskPanel.Items.Add(newCourse);
            cboCourseDisplayTaskPanel.Items.Add(newCourse);
            cboChooseCourseExamPage.Items.Add(newCourse);
            cboCourseDisplayExamPanel.Items.Add(newCourse);
            //update list box
            cboSemesterPresentCourse.SelectedItem = semester;
            //lstCourses.Items.Add(newCourse);
        }
        //back to adding mode event handler
        private void btnBackToAddingMode_Click(object sender, EventArgs e)
        {
            lblAddCourse.Text = "Add a new course";

            pnlBackToAddingModeCover.BringToFront();
            pnlCoverDeleteCourse.BringToFront();

            //Assigns default values to controls
            CoursesPanelDefauleValues();
        }
        //service method
        private void CoursesPanelDefauleValues()
        {
            //Assigns default values to controls
            if (cboAcademicYearCoursePanel.Items.Count != 0)
                cboAcademicYearCoursePanel.SelectedIndex = 0;
            if (cboSemesterCoursePanel.Items.Count != 0)
                cboSemesterCoursePanel.SelectedIndex = 0;

            //unselect item
            lstCourses.SelectedIndex = -1;

            txtCourseName.Text = "";
            txtLecturer.Text = "";
            txtPractices.Text = "";
        }
        //delete course event handler
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Course chosenCourse = (Course)lstCourses.SelectedItem;
            Semester semester = this.userData.FindSemester(chosenCourse);

            //no course 
            if (chosenCourse == null)
                return;
            //Assigns default values to controls
            CoursesPanelDefauleValues();

            //update data
            try
            {
                foreach (Lesson l in chosenCourse.Lessons)
                {
                    this.userData.Calendar.RemoveScheduleEvents(l.Lessons);
                }
                foreach (Task t in chosenCourse.Tasks)
                {
                    this.userData.Calendar.RemoveAllScheduleEventsInSeries(t.WorkOnTask);
                }
                foreach (Exam exam in chosenCourse.Exams)
                {
                    this.userData.Calendar.RemoveScheduleEvent(exam);
                }
            }
            catch (Exception) { }


            //update data
            semester.Courses.Remove(chosenCourse);
            semester.Courses.Sort();

            //update combo boxes
            cboLessonPanelCourse.Items.Remove(chosenCourse);
            cboChooseCourseExamPage.Items.Remove(chosenCourse);
            cboCourseDisplayExamPanel.Items.Remove(chosenCourse);
            cboCourseTaskPanel.Items.Remove(chosenCourse);
            cboCourseDisplayTaskPanel.Items.Remove(chosenCourse);

            //update list box
            lstCourses.Items.Remove(chosenCourse);

            if (semester.Courses.Count == 0)
                pnlNoCourses.BringToFront();

            //User update
            MessageBox.Show("Course successfully deleted");

            //back to adding mode
            btnBackToAddingMode_Click(null, null);
        }
        //courses list box draw item event handler
        private void lstCourses_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if the list is empty
            if (lstCourses.Items.Count == 0)
                return;

            lstCourses.RightToLeft = RightToLeft.Yes;
            Font f = new Font("Gill Sans MT", 16, FontStyle.Bold);
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = ((Course)lst.Items[e.Index]).ToString("");

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.MediumSlateBlue);//Choose the color
            }

            // Draw the background.
            e.DrawBackground();
            var back = this.BackColor;
            var fore = this.ForeColor;
            TextRenderer.DrawText(e.Graphics, txt, f, e.Bounds, back, TextFormatFlags.Right);

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        //set item size event handler
        private void lstCourses_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            int ItemMargin = 20;
            Font f = new Font("Gill Sans MT", 16, FontStyle.Regular);
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = ((Course)lst.Items[e.Index]).ToString("");

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, f);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
            itemWidth = e.ItemWidth;
        }
        //
        //Lesson
        //
        private void btnLessonPanelSave_Click(object sender, EventArgs e)
        {
            Semester chosenSemester = (Semester)cboLessonPanelSemester.SelectedItem;
            Course chosenCourse = (Course)cboLessonPanelCourse.SelectedItem;

            //calculate lesson duration
            DateTime end = (string)cboLessonTimeUnit.SelectedItem == "minutes" ?
            dtpStartLesson.Value + TimeSpan.FromMinutes((double)nudClassDuration.Value) :
            dtpStartLesson.Value + TimeSpan.FromHours((double)nudClassDuration.Value);


            //if the lesson is too short
            if (end - dtpStartLesson.Value < TimeSpan.FromMinutes(25))
            {
                MessageBox.Show("A class can not be less than 25 minutes");
                return;
            }
            else if (dtpStartLesson.Value.Date < chosenSemester.StartTime.Date) //if the user try to add a class before the semester
            {
                MessageBox.Show("You can not add a class before the beginning of the semester");
                return;
            }

            List<ScheduleEvent> newLesson = chosenCourse.AddNewLesson((Lesson.LessonType)cboLessonPanelType.SelectedItem, dtpStartLesson.Value,
                                                                       end, chosenSemester, txtLocationClass.Text);


            //update courses list box
            lstCourses.Items.Clear();
            lstCourses.Items.AddRange(chosenSemester.Courses.ToArray());


            this.userData.Calendar.AddScheduleEvents(newLesson);
        }

        #endregion

        #region Tasks Screen
        //
        //Tasks screen
        //
        //task screen visible changed event handler
        private void mppTasksScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppTasksScreen.Visible)
                return;

            //data
            List<AcademicYear> academicYears = this.userData.AcademicYears;
            List<Semester> semesters = this.userData.GetSemesters();
            List<Course> courses = this.userData.GetCourses();

            //clear combo boxes
            cboAcademicYearDisplayTaskPanel.Items.Clear();
            cboSemesterDisplayTaskPanel.Items.Clear();
            cboCourseDisplayTaskPanel.Items.Clear();
            cboCourseTaskPanel.Items.Clear();

            //load combo boxes
            cboAcademicYearDisplayTaskPanel.Items.AddRange(academicYears.ToArray());
            cboSemesterDisplayTaskPanel.Items.AddRange(semesters.ToArray());
            cboCourseDisplayTaskPanel.Items.AddRange(courses.ToArray());
            cboCourseTaskPanel.Items.AddRange(courses.ToArray());

            //set initial values in combo boxes
            SetComboBoxes(pnlTasks);
            SetComboBoxes(pnlFreeTimeSearch);

            //clear list box
            lstTasks.Items.Clear();

            //no tasks to present panel
            pnlCoverDisplayTask.BringToFront();

            //set adding mode
            btnBackToAddingTask_Click(null, null);


            if (this.userData.GetTasks().Count != 0)
            {
                //current year and semester in order to display newest tasks
                AcademicYear lastYear = this.userData.GetCurrentAcademicYear();
                cboAcademicYearDisplayTaskPanel.SelectedItem = lastYear;
                Semester lastSemester = this.userData.LastSemesterOfCurrentYear(lastYear);
                cboSemesterDisplayTaskPanel.SelectedItem = lastSemester;

                if (cboCourseDisplayTaskPanel.Items.Count != 0)
                    cboCourseDisplayTaskPanel.SelectedIndex = 0;

                pnlSelectTask.BringToFront();

                //refresh list box
                lstTasks.Items.Clear();
                try
                {
                    bool thereAreTasks = false;
                    foreach (Semester s in lastYear.Semsters)
                    {
                        if (s.Courses.Count != 0)
                        {
                            foreach (Course c in s.Courses)
                            {
                                if (c.Tasks.Count != 0)
                                {
                                    cboAcademicYearDisplayTaskPanel.SelectedItem = lastYear;
                                    cboSemesterDisplayTaskPanel.SelectedItem = s;
                                    cboCourseDisplayTaskPanel.SelectedItem = c;
                                    lstTasks.Items.Clear();
                                    lstTasks.Items.AddRange(c.Tasks.ToArray());
                                    thereAreTasks = true;
                                    break;
                                }

                            }
                            if (thereAreTasks)
                                break;
                        }
                    }
                }
                catch (Exception) { }
            }

        }

        private void lstTasks_DoubleClick(object sender, EventArgs e)
        {
            //if list box is empty
            if (lstTasks.Items.Count == 0)
                return;

            Task chosenTask = (Task)lstTasks.SelectedItem;
            Course course = this.userData.FindCourse(chosenTask);

            //enter to edit mode
            lblNewTask.Text = "Edit a task";
            btnBackToAddingTask.Visible = true;
            btnDeleteTask.Visible = true;
            rbtStartAndEndTask.Checked = true;

            //load task data to controls
            txtTaskName.Text = chosenTask.Name;
            cboCourseTaskPanel.SelectedItem = course;
            if (chosenTask.WorkOnTask != null)
            {
                dtpStartTask.Value = chosenTask.WorkOnTask.StartTime;
                dtpEndTask.Value = chosenTask.WorkOnTask.EndTime;
            }
            dtpDeadline.Value = chosenTask.Deadline;
        }

        //back to adding mode event handler
        private void btnBackToAddingTask_Click(object sender, EventArgs e)
        {
            lblNewTask.Text = "Add a new task";

            btnBackToAddingTask.Visible = false;
            btnDeleteTask.Visible = false;

            //unselect item
            lstTasks.SelectedIndex = -1;

            //Assigns default values to controls
            try
            {
                TasksPanelDefauleValues();
            }
            catch (Exception) { }
        }
        //service method
        private void TasksPanelDefauleValues()
        {
            //Assigns default values to controls
            cboCourseTaskPanel.SelectedIndex = 0;
            txtTaskName.Text = "";
            rbtFreeTimeSearch.Checked = true;
            nudEstimateTime.Value = 0;
            cboEstimateTimeUnit.SelectedIndex = 0;
            dtpStartTask.Value = dtpEndTask.Value =
            dtpDeadline.Value = DateTime.Now;

        }


        private void lstTasks_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            int ItemMargin = 20;
            string txt;
            Font f = new Font("Gill Sans MT", 16, FontStyle.Regular);

            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;

            txt = ((Task)lst.Items[e.Index]).ToString();

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, f);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
            itemWidth = e.ItemWidth;
        }

        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if the list is empty
            if (lstTasks.Items.Count == 0)
                return;

            lstTasks.RightToLeft = RightToLeft.Yes;
            Font f = new Font("Gill Sans MT", 16, FontStyle.Bold);
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = ((Task)lst.Items[e.Index]).ToString();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Orchid);//Choose the color
            }

            // Draw the background.
            e.DrawBackground();
            var back = this.BackColor;
            var fore = this.ForeColor;
            TextRenderer.DrawText(e.Graphics, txt, f, e.Bounds, back, TextFormatFlags.Right);

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        //combo boxes index changed event handlers
        private void academicYearDisplayTaskPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cboAcademicYearDisplayTaskPanel)
            {
                AcademicYear year = (AcademicYear)cboAcademicYearDisplayTaskPanel.SelectedItem;

                cboSemesterDisplayTaskPanel.Items.Clear();
                cboSemesterDisplayTaskPanel.Items.AddRange(year.Semsters.ToArray());


                if (cboSemesterDisplayTaskPanel.Items.Count != 0)
                    cboSemesterDisplayTaskPanel.SelectedIndex = 0;
                else
                {
                    cboCourseDisplayTaskPanel.Text = "";
                    cboCourseDisplayTaskPanel.Items.Clear();
                    lstTasks.Items.Clear();
                }
            }

            if (sender == cboSemesterDisplayTaskPanel)
            {
                Semester semester = (Semester)cboSemesterDisplayTaskPanel.SelectedItem;

                cboCourseDisplayTaskPanel.Items.Clear();
                cboCourseDisplayTaskPanel.Items.AddRange(semester.Courses.ToArray());

                if (cboCourseDisplayTaskPanel.Items.Count != 0)
                    cboCourseDisplayTaskPanel.SelectedIndex = 0;
                else
                    lstTasks.Items.Clear();
            }

            if (sender == cboCourseDisplayTaskPanel)
            {
                Course course = (Course)cboCourseDisplayTaskPanel.SelectedItem;

                lstTasks.Items.Clear();
                if (course.Tasks.Count == 0)
                {
                    return;
                }
                lstTasks.Items.AddRange(course.Tasks.ToArray());
            }
        }

        private void rbtFreeTimeSearch_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtFreeTimeSearch.Checked)
            {
                pnlChooseTime.Visible = false;
                pnlFreeTimeSearch.Visible = true;
                pnlFreeTimeSearch.BringToFront();

                //set tab stop
                SetTabStop(pnlTasks, false);
                SetTabStop(pnlChooseTime, false);
                SetTabStop(pnlFreeTimeSearch, true);

                //set tab order
                nudEstimateTime.TabIndex = 0;
                cboEstimateTimeUnit.TabIndex = 1;
                btnFreeTimeSearch.TabIndex = 2;
                SetTabStop(pnlTasks, true);
                btnSaveTask.TabIndex = 0;

                pnlFreeTimeSearch.Select();
            }
            else
            {
                pnlFreeTimeSearch.Visible = false;
                pnlChooseTime.Visible = true;
                pnlChooseTime.BringToFront();

                //set tab stop
                SetTabStop(pnlTasks, false);
                SetTabStop(pnlChooseTime, true);
                SetTabStop(pnlFreeTimeSearch, false);

                //set tab order
                dtpStartTask.TabIndex = 0;
                dtpEndTask.TabIndex = 1;
                SetTabStop(pnlTasks, true);
                btnSaveTask.TabIndex = 0;

                pnlChooseTime.Select();
            }
        }

        private void nudEstimateTime_ValueChanged(object sender, EventArgs e)
        {
            if (nudEstimateTime.Value == 0)
            {
                btnFreeTimeSearch.Enabled = false;
                return;
            }
            else
            {
                btnFreeTimeSearch.Enabled = true;

            }
        }

        private void btnFreeTimeSearch_Click(object sender, EventArgs e)
        {
            //calculate estimate time
            string timeUnit = (string)cboEstimateTimeUnit.SelectedItem;
            int timeValue = (int)nudEstimateTime.Value;
            TimeSpan estimateTime = timeUnit == "minutes" ? TimeSpan.FromMinutes(timeValue) : TimeSpan.FromHours(timeValue);

            //get free times
            List<ScheduleEvent> freeTimes = Task.FreeTimeSearch(this.userData.Calendar, this.user.ActivityTime, estimateTime, dtpDeadline.Value);

            //add free times to calendar
            this.userData.Calendar.AddScheduleEvents(freeTimes);

            //show free time dialog
            freeTimeDialog.ShowDialog();

            //remove free times from calendar
            if (freeTimes != null)
                this.userData.Calendar.RemoveScheduleEvents(freeTimes);

            //mark as free time
            chosenFreeTime = freeTimeDialog.ChosenFreeTime;

            //set times
            if (chosenFreeTime != null)
            {
                dtpStartTask.Value = chosenFreeTime.StartTime;
                dtpEndTask.Value = chosenFreeTime.EndTime;
                rbtStartAndEndTask.Checked = true;
                MessageBox.Show("The requested time was successfully selected");
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            Course course = (Course)cboCourseTaskPanel.SelectedItem;
            Semester semester = this.userData.FindSemester(course);
            bool editedTask = false;
            string message;

            //check validation
            if (txtTaskName.Text == "")
            {
                MessageBox.Show("You must fill out all fields");
                return;
            }

            if (cboCourseTaskPanel.SelectedItem == null)
            {
                MessageBox.Show("There is no course yet");
                return;
            }

            if (dtpDeadline.Value <= DateTime.Now)
            {
                MessageBox.Show("The deadline has passed");
                return;
            }

            if (lblNewTask.Text == "Edit a task")//edit mode
            {
                //turn on flag
                editedTask = true;
                Task chosenTask = (Task)lstTasks.SelectedItem;
                //remove task's schedule event
                if (chosenTask.WorkOnTask != null)
                {
                    this.userData.Calendar.RemoveAllScheduleEventsInSeries(chosenTask.WorkOnTask);
                }
                //remove from data
                course.Tasks.Remove(chosenTask);

                //remove from list box
                lstTasks.Items.Remove(chosenTask);
            }

            //set the message
            message = editedTask ? "Task successfully updated" : "New task successfully created";

            //create new task
            Task newTask = new Task(txtTaskName.Text, dtpDeadline.Value, course.Name);

            //create the schedule event of the task

            if (rbtStartAndEndTask.Checked)
            {
                try
                {
                    //if the work on the task is after the deadline
                    if (dtpStartTask.Value >= dtpDeadline.Value)
                    {
                        MessageBox.Show("You can not add time to do a task after the deadline");
                        return;
                    }

                    List<ScheduleEvent> temp;
                    string hebrewString = "מטלה בקורס: ";
                    string hebrewString2 = "מועד הגשה: ";
                    ScheduleEvent taskEvent = new ScheduleEvent(dtpStartTask.Value, dtpEndTask.Value, newTask.Name,
                        "", string.Format("{0}{1}\n{2}{3}", hebrewString, newTask.CourseName, hebrewString2, newTask.Deadline.ToString("dddd dd/M/yyyy HH:mm")),
                        ScheduleEvent.Period.None, dtpEndTask.Value, out temp);

                    temp[0].Task = newTask;
                    newTask.WorkOnTask = temp[0];

                    //add to calendar
                    this.userData.Calendar.AddScheduleEvents(temp);
                }
                catch (DateMissMatchException)
                {
                    MessageBox.Show("The duration of the task is too short");
                }
            }
            else if (chosenFreeTime != null && nudEstimateTime.Value != 0)
            {

                try
                {
                    //if the work on the task is after the deadline
                    if (chosenFreeTime.StartTime >= dtpDeadline.Value)
                    {
                        MessageBox.Show("You can not add time to do a task after the deadline");
                        return;
                    }

                    List<ScheduleEvent> temp;
                    string hebrewString = "מטלה בקורס: ";
                    string hebrewString2 = "מועד הגשה: ";
                    ScheduleEvent taskEvent = new ScheduleEvent(chosenFreeTime.StartTime, chosenFreeTime.EndTime, newTask.Name,
                        "", string.Format("{0}{1}\n{2}{3}", hebrewString, newTask.CourseName, hebrewString2, newTask.Deadline.ToString("dddd dd/M/yyyy HH:mm")),
                        ScheduleEvent.Period.None, dtpEndTask.Value, out temp);

                    temp[0].Task = newTask;
                    newTask.WorkOnTask = temp[0];

                    //add to calendar
                    this.userData.Calendar.AddScheduleEvents(temp);
                }
                catch (DateMissMatchException)
                {
                    MessageBox.Show("The duration of the task is too short");
                }
            }

            //reset free time
            chosenFreeTime = null;

            //Evacuation of the label indicating that there are no tasks
            pnlSelectTask.BringToFront();
            pnlSelectTask.Visible = true;

            //update data
            course.Tasks.Add(newTask);
            course.Tasks.Sort();

            //deafault values
            TasksPanelDefauleValues();

            //add to list box
            lstTasks.Items.Add(newTask);

            //update list box
            cboAcademicYearDisplayTaskPanel.SelectedItem = this.userData.FindAcademicYear(semester);
            cboSemesterDisplayTaskPanel.SelectedItem = semester;
            cboCourseDisplayTaskPanel.SelectedItem = course;

            lstTasks.Refresh();

            //exit edit mode
            lblNewTask.Text = "Add a new task";
            rbtFreeTimeSearch.Checked = true;

            //show message
            MessageBox.Show(message);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Task chosenTask = (Task)lstTasks.SelectedItem;
            Course course = this.userData.FindCourse(chosenTask);

            //no task
            if (chosenTask == null)
                return;
            //Assigns default values to controls
            TasksPanelDefauleValues();

            //remove task's schedule event
            if (chosenTask.WorkOnTask != null)
            {
                this.userData.Calendar.RemoveAllScheduleEventsInSeries(chosenTask.WorkOnTask);
            }
            //update data
            course.Tasks.Remove(chosenTask);
            course.Tasks.Sort();

            //update list box
            lstTasks.Items.Remove(chosenTask);

            //exit edit mode
            lblNewTask.Text = "Add a new task";
            rbtFreeTimeSearch.Checked = true;

            if (this.userData.GetTasks().Count == 0)
            {
                pnlCoverDisplayTask.BringToFront();
                pnlCoverDisplayTask.Visible = true;
            }

        }


        #endregion

        #region Exam Screen
        private void mppExamsScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppExamsScreen.Visible)
                return;

            //data
            List<AcademicYear> academicYears = this.userData.AcademicYears;
            List<Semester> semesters = this.userData.GetSemesters();
            List<Course> courses = this.userData.GetCourses();


            //clear combo boxes
            cboAcademicYearDisplayExamPanel.Items.Clear();
            cboSemesterDisplayExamPanel.Items.Clear();
            cboCourseDisplayExamPanel.Items.Clear();
            cboChooseCourseExamPage.Items.Clear();

            //load combo boxes
            cboAcademicYearDisplayExamPanel.Items.AddRange(academicYears.ToArray());
            cboSemesterDisplayExamPanel.Items.AddRange(semesters.ToArray());
            cboCourseDisplayExamPanel.Items.AddRange(courses.ToArray());
            cboChooseCourseExamPage.Items.AddRange(courses.ToArray());


            //set initial values in combo boxes
            SetComboBoxes(pnlExams);

            //clear list box
            lstExams.Items.Clear();

            //no exams yet
            pnlNoExams.BringToFront();

            //set adding mode
            btnBackToAddingExam_Click(null, null);

            if (this.userData.GetExams().Count != 0)
            {
                //current year and semester in order to display newest tasks
                AcademicYear lastYear = this.userData.GetCurrentAcademicYear();
                cboAcademicYearDisplayExamPanel.SelectedItem = lastYear;
                Semester lastSemester = this.userData.LastSemesterOfCurrentYear(lastYear);
                cboSemesterDisplayExamPanel.SelectedItem = lastSemester;

                if (cboCourseDisplayExamPanel.Items.Count != 0)
                    cboCourseDisplayExamPanel.SelectedIndex = 0;

                pnlSelectExam.BringToFront();

                //refresh list box
                lstExams.Items.Clear();
                try
                {
                    bool thereAreExams = false;
                    foreach (Semester s in lastYear.Semsters)
                    {
                        if (s.Courses.Count != 0)
                        {
                            foreach (Course c in s.Courses)
                            {
                                if (c.Exams.Count != 0)
                                {
                                    cboAcademicYearDisplayExamPanel.SelectedItem = lastYear;
                                    cboSemesterDisplayExamPanel.SelectedItem = s;
                                    cboCourseDisplayExamPanel.SelectedItem = c;
                                    lstExams.Items.Clear();
                                    lstExams.Items.AddRange(c.Exams.ToArray());
                                    thereAreExams = true;
                                    break;
                                }
                            }
                            if (thereAreExams)
                                break;
                        }
                    }
                }
                catch (Exception) { }
            }
        }

        private void lstExams_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            int ItemMargin = 20;
            string txt;
            Font f = new Font("Gill Sans MT", 16, FontStyle.Regular);

            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;

            txt = ((Exam)lst.Items[e.Index]).ToString();

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, f);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
            itemWidth = e.ItemWidth;
        }

        private void lstExams_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if the list is empty
            if (lstExams.Items.Count == 0)
                return;

            lstExams.RightToLeft = RightToLeft.Yes;
            Font f = new Font("Gill Sans MT", 16, FontStyle.Bold);
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = ((Exam)lst.Items[e.Index]).ToString();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.LightSeaGreen);//Choose the color
            }

            // Draw the background.
            e.DrawBackground();
            var back = this.BackColor;
            var fore = this.ForeColor;
            TextRenderer.DrawText(e.Graphics, txt, f, e.Bounds, back, TextFormatFlags.Right);

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        private void cboAcademicYearDisplayExamPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cboAcademicYearDisplayExamPanel)
            {
                AcademicYear year = (AcademicYear)cboAcademicYearDisplayExamPanel.SelectedItem;

                cboSemesterDisplayExamPanel.Items.Clear();
                cboSemesterDisplayExamPanel.Items.AddRange(year.Semsters.ToArray());


                if (cboSemesterDisplayExamPanel.Items.Count != 0)
                    cboSemesterDisplayExamPanel.SelectedIndex = 0;
                else
                {
                    cboCourseDisplayExamPanel.Text = "";
                    cboCourseDisplayExamPanel.Items.Clear();
                    lstExams.Items.Clear();
                }
            }
            else if (sender == cboSemesterDisplayExamPanel)
            {
                Semester semester = (Semester)cboSemesterDisplayExamPanel.SelectedItem;

                cboCourseDisplayExamPanel.Items.Clear();
                cboCourseDisplayExamPanel.Items.AddRange(semester.Courses.ToArray());

                if (cboCourseDisplayExamPanel.Items.Count != 0)
                    cboCourseDisplayExamPanel.SelectedIndex = 0;
                else
                    lstExams.Items.Clear();
            }
            else if (sender == cboCourseDisplayExamPanel)
            {
                Course course = (Course)cboCourseDisplayExamPanel.SelectedItem;

                lstExams.Items.Clear();
                if (course.Exams.Count == 0)
                {
                    return;
                }
                lstExams.Items.AddRange(course.Exams.ToArray());
            }
        }

        private void lstExams_DoubleClick(object sender, EventArgs e)
        {
            //if list box is empty
            if (lstExams.Items.Count == 0)
                return;

            Exam chosenExam = (Exam)lstExams.SelectedItem;
            Course course = this.userData.FindCourse(chosenExam);

            //enter to edit mode
            lblNewExam.Text = "Edit an exam";
            btnBackToAddingExam.Visible = true;
            btnDeleteExam.Visible = true;

            //load task data to controls
            txtExamTitle.Text = chosenExam.Title;
            txtExamLocation.Text = chosenExam.Location;
            cboChooseCourseExamPage.SelectedItem = course;
            dtpExam.Value = chosenExam.StartTime;
            nudExamDuration.Value = (decimal)chosenExam.TimeSpan.TotalMinutes;
            cboExamTimeUnit.SelectedIndex = 0;
            lstSubjects.Items.Clear();
            lstSubjects.Items.AddRange(chosenExam.Subjects.ToArray());

        }

        //save exam event handler
        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            Course course = (Course)cboChooseCourseExamPage.SelectedItem;
            Semester semester = this.userData.FindSemester(course);
            bool editedExam = false;

            string message;

            //check validation
            if (txtExamTitle.Text == "" || nudExamDuration.Value == 0)
            {
                MessageBox.Show("You must fill out all fields");
                return;
            }

            if (cboChooseCourseExamPage.SelectedItem == null)
            {
                MessageBox.Show("There is no courses yet");
                return;
            }

            if ((string)cboExamTimeUnit.SelectedItem == "minutes" && nudExamDuration.Value < 15)
            {

                MessageBox.Show("A test can not take less than 15 minutes");
                return;
            }
            else if ((string)cboExamTimeUnit.SelectedItem == "hours" && nudExamDuration.Value > 5)
            {
                MessageBox.Show("More than 5 hours test?!?, substitute profession");
                return;
            }


            if (lblNewExam.Text == "Edit an exam")//edit mode
            {
                //turn on flag
                editedExam = true;
                Exam chosenExam = (Exam)lstExams.SelectedItem;

                //remove from data
                course.Exams.Remove(chosenExam);

                //remove from calendar
                this.userData.Calendar.RemoveScheduleEvent(chosenExam);

                //remove from list box
                lstExams.Items.Remove(chosenExam);
            }

            //set the message
            message = editedExam ? "Exam successfully updated" : "New exam successfully created";

            //create new exam
            DateTime end = (string)cboExamTimeUnit.SelectedItem == "minutes" ?
                dtpExam.Value + TimeSpan.FromMinutes((double)nudExamDuration.Value) :
                dtpExam.Value + TimeSpan.FromHours((double)nudExamDuration.Value);
            string[] subjects = new string[lstSubjects.Items.Count];
            lstSubjects.Items.CopyTo(subjects, 0);

            Exam newExam = new Exam(dtpExam.Value, end, txtExamTitle.Text, txtExamLocation.Text,
                ((Course)cboChooseCourseExamPage.SelectedItem).Name,
                ScheduleEvent.Period.None, DateTime.Today, subjects);

            //set IsExam propery
            newExam.IsExam = true;

            //adding the exam to the calendar
            this.userData.Calendar.AddScheduleEvent(newExam);

            MessageBox.Show(message);

            //Evacuation of the label indicating that there are no tasks
            pnlSelectExam.BringToFront();
            pnlSelectExam.Visible = true;


            //update data
            course.Exams.Add(newExam);
            course.Exams.Sort();

            //add to list box
            lstExams.Items.Add(newExam);

            //deafault values
            ExamsPanelDefauleValues();

            //update list box
            cboAcademicYearDisplayExamPanel.SelectedItem = this.userData.FindAcademicYear(semester);
            cboSemesterDisplayExamPanel.SelectedItem = semester;
            cboCourseDisplayExamPanel.SelectedItem = course;

            //exit edit mode
            lblNewExam.Text = "Add a new exam";
        }

        //delete exam event handler
        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            Exam chosenExam = (Exam)lstExams.SelectedItem;
            Course course = this.userData.FindCourse(chosenExam);

            //no task
            if (chosenExam == null)
                return;

            //Assigns default values to controls
            ExamsPanelDefauleValues();

            //remove exam from calendar
            this.userData.Calendar.RemoveAllScheduleEventsInSeries(chosenExam);

            //update data
            course.Exams.Remove(chosenExam);
            course.Exams.Sort();

            //update list box
            lstExams.Items.Remove(chosenExam);

            //exit edit mode
            lblNewExam.Text = "Add a new exam";

            if (this.userData.GetExams().Count == 0)
            {
                pnlNoExams.BringToFront();
                pnlNoExams.Visible = true;
            }

            //batck to adding mode
            btnBackToAddingExam_Click(null, null);

        }

        //back to adding mode event handler
        private void btnBackToAddingExam_Click(object sender, EventArgs e)
        {
            lblNewExam.Text = "Add a new exam";

            btnBackToAddingExam.Visible = false;
            btnDeleteExam.Visible = false;

            //cancel exam selection
            lstExams.SelectedIndex = -1;

            //Assigns default values to controls
            try { ExamsPanelDefauleValues(); }
            catch (Exception) { }
        }
        //service method
        private void ExamsPanelDefauleValues()
        {
            //Assigns default values to controls
            cboChooseCourseExamPage.SelectedIndex = 0;
            txtExamTitle.Text = "";
            dtpExam.Value = DateTime.Now;
            nudExamDuration.Value = 0;
            cboExamTimeUnit.SelectedIndex = 0;
            txtSubjects.Text = "";
            lstSubjects.Items.Clear();
            txtExamLocation.Text = "";
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (txtSubjects.Text.Trim() != "")
            {
                lstSubjects.Items.Add(txtSubjects.Text.Trim());
                txtSubjects.Text = "";
            }
        }

        private void txtSubjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAddSubject_Click(null, null);
            }
        }

        private void lstSubjects_DoubleClick(object sender, EventArgs e)
        {
            string chosenSubject = (string)lstSubjects.SelectedItem;
            txtSubjects.Text = chosenSubject;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            //no subject chosen
            if (lstSubjects.SelectedItem == null)
                return;

            //delete subject
            txtSubjects.Text = "";
            lstSubjects.Items.Remove(lstSubjects.SelectedItem);
        }

        private void btnBackToAddingExam_Click_1(object sender, EventArgs e)
        {
            lblNewExam.Text = "Add a new exam";

            btnBackToAddingExam.Visible = false;
            btnDeleteExam.Visible = false;

            //Assigns default values to controls
            ExamsPanelDefauleValues();
        }

        #endregion

        #region Note Screen

        private void mppNotesScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (mppNotesScreen.Visible)
            {
                for (int i = 0; i < 10; i++)
                {
                    mppNotesScreen.Controls[i].Text = this.userData.Notes[i].Text;
                    if (this.userData.Notes[i].Text != "~")
                    {
                        mppNotesScreen.Controls[i].Visible = true;
                    }
                    else
                    {
                        mppNotesScreen.Controls[i].Visible = false;
                    }
                }

            }
            else
            {
                for (int j = 0; j < 10; j++)
                {
                    mppNotesScreen.Controls[j].Visible = true;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (mppNotesScreen.Controls[j].Text == "")
                    {
                        mppNotesScreen.Controls[j].Text = "~";
                    }
                    this.userData.Notes[j].Text = mppNotesScreen.Controls[j].Text;
                }
            }
        }

        //add a new note event handler
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            int usedNotes = 0;
            //check the number of used notes
            for (int i = 0; i < 10; i++)
            {
                if (mppNotesScreen.Controls[i].Visible)
                {
                    usedNotes++;
                }
            }

            //maximum num of notes
            if (usedNotes == 10)
            {
                MessageBox.Show("The quota of notes has run out \nIf you want to add a new note, delete an existing note");
                return;
            }

            //create a "new" note
            for (int j = 0; j < 10; j++)
            {
                if (!mppNotesScreen.Controls[j].Visible)
                {
                    mppNotesScreen.Controls[j].Text = "";
                    mppNotesScreen.Controls[j].Visible = true;
                    break;
                }
            }
        }

        private void rtfNote_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RichTextBox chosenNote = (RichTextBox)sender;

            if (chosenNote.BackColor == Color.FromArgb(255, 255, 141))
            {
                chosenNote.BackColor = Color.Red;
            }
            else
            {
                chosenNote.BackColor = Color.FromArgb(255, 255, 141);
            }

            btnRemoveNote.Visible = true;
            lblRemoveNote.Visible = true;
        }

        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (mppNotesScreen.Controls[i].BackColor == Color.Red)
                {
                    mppNotesScreen.Controls[i].Text = "~";//mark of deleted
                    this.userData.Notes[i].Text = "~";//mark of deleted
                    mppNotesScreen.Controls[i].BackColor = Color.FromArgb(255, 255, 141);
                    mppNotesScreen.Controls[i].Visible = false;
                }
            }

            btnRemoveNote.Visible = false;
            lblRemoveNote.Visible = false;
        }
        #endregion

        #region Settings Screen
        private void mppSettingsScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (!mppSettingsScreen.Visible)
                return;

            //set default values
            dtpStartActivity.Value = this.user.ActivityTime.StartTime;
            dtpEndActivity.Value = this.user.ActivityTime.EndTime;
            dtpBirthDay.Value = this.user.DateOfBirth;
            txtOldPassword.Text = txtNewPassword.Text = txtConfirmNewPassword.Text =
            txtNewEmail.Text = "";

        }
        private void saveEmailLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtNewEmail.Text == "")
            {
                MessageBox.Show("You must fill in the email");
                return;
            }
            else if (!MailService.IsValidEmail(txtNewEmail.Text))
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (StudentRoutine.IsMember(txtNewEmail.Text) != -1)
            {
                MessageBox.Show("User exists in the system");
                return;
            }
            else
            {
                this.user.Email = txtNewEmail.Text;
                txtNewEmail.Text = "";
                MessageBox.Show("Email successfully updated");
            }
        }

        private void lklSavePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmNewPassword.Text == "")
            {
                MessageBox.Show("You must fill out all fields");
                return;
            }
            else if (txtOldPassword.Text != this.user.Password)
            {
                MessageBox.Show("The old password you entered is incorrect");
                return;
            }
            else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            else
            {
                this.user.Password = txtNewPassword.Text;
                txtOldPassword.Text = txtNewPassword.Text = txtConfirmNewPassword.Text = "";
                MessageBox.Show("Password successfully updated");
            }
        }

        private void lklSaveChanges_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dtpEndActivity.Value - dtpStartActivity.Value < TimeSpan.FromHours(4))
            {
                MessageBox.Show("You are lazy!");
                return;
            }
            else if (dtpStartActivity.Value > dtpEndActivity.Value)
            {
                MessageBox.Show("End time must be greater than start time");
                return;
            }
            else if (dtpBirthDay.Value > new DateTime(2007, 1, 1))
            {
                MessageBox.Show("You are too young");
                return;
            }
            else
            {
                this.user.ActivityTime.StartTime = dtpStartActivity.Value;
                this.user.ActivityTime.EndTime = dtpEndActivity.Value;
                this.user.DateOfBirth = dtpBirthDay.Value;
                MessageBox.Show("Changes successfully executed");
            }
        }
        #endregion

        #region Service Methods
        //set intial values of combo boxes
        private void SetComboBoxes(Panel pnl)
        {
            try
            {


                foreach (Control c in pnl.Controls)
                {
                    if (c is ComboBox)
                    {
                        if (((ComboBox)c).Items.Count != 0)
                        {
                            ((ComboBox)c).SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception) { }
        }//end method

        //set controls tab stop
        private void SetTabStop(Panel pnl, bool state)
        {
            foreach (Control c in pnl.Controls)
            {
                c.TabStop = state;
            }
        }//end metod

        //overlload
        private void SetTabStop(MultiPanelPage mpp, bool state)
        {
            foreach (Control c in mpp.Controls)
            {
                c.TabStop = state;

                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        c2.TabStop = state;
                    }
                }
            }
        }//end method

        //send email
        private void EmailSend()
        {

                if (emailTitle == "\u200EHappy Birthday!")
                    txtEmailSignUp.Text = this.user.Email;

                try
                {
                    MailService.EmailSender(txtEmailSignUp.Text, emailMessage, emailTitle);
                }
                catch (Exception) { }

                //exit birthday mode
                emailTitle = "";
            
        }//end method

        #endregion
    }
}
