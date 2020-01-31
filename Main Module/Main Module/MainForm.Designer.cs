using System.Windows.Forms;

namespace Main_Module
{
    partial class MainForm
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
            System.Windows.Forms.Button backGroundbtn;
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange29 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange30 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange31 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange32 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange33 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange34 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange35 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange36 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange37 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange38 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange39 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange40 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange41 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange42 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.mplScreens = new MultiPanel();
            this.mppMainScreen = new MultiPanelPage();
            this.mtlClasses2 = new MetroFramework.Controls.MetroTile();
            this.cclMainCalendar = new CalendarControl.CalendarControl();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblNameFirstLetter = new System.Windows.Forms.Label();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.mtlTasks2 = new MetroFramework.Controls.MetroTile();
            this.mtlTasks = new MetroFramework.Controls.MetroTile();
            this.mtlExams2 = new MetroFramework.Controls.MetroTile();
            this.mtlExams = new MetroFramework.Controls.MetroTile();
            this.mtlToday2 = new MetroFramework.Controls.MetroTile();
            this.mtlToday = new MetroFramework.Controls.MetroTile();
            this.btnBackground = new System.Windows.Forms.Button();
            this.mtlClasses = new MetroFramework.Controls.MetroTile();
            this.mppCoursesScreen = new MultiPanelPage();
            this.pnlAcademicYear = new System.Windows.Forms.Panel();
            this.pnlAddNewAcademicYear = new System.Windows.Forms.Panel();
            this.lblAcademicYearEnd = new System.Windows.Forms.Label();
            this.btnSaveAcademicYearPanel = new System.Windows.Forms.Button();
            this.cboAcademicYearNameAddPanel = new MetroFramework.Controls.MetroComboBox();
            this.dtpStartAcademicYear = new System.Windows.Forms.DateTimePicker();
            this.dtpEndAcademicYear = new System.Windows.Forms.DateTimePicker();
            this.lblAcademicYearName = new System.Windows.Forms.Label();
            this.lblAcademicYearStart = new System.Windows.Forms.Label();
            this.btnGoToSemester = new System.Windows.Forms.Button();
            this.pnlEditAcademicYear = new System.Windows.Forms.Panel();
            this.btnSaveEditedAcademicYear = new System.Windows.Forms.Button();
            this.cboChooseExistAcademicYear = new MetroFramework.Controls.MetroComboBox();
            this.btnDeleteAcademicYear = new System.Windows.Forms.Button();
            this.cboAcademicYearNameEditPanel = new MetroFramework.Controls.MetroComboBox();
            this.dtpStartAcademicYearEditPanel = new System.Windows.Forms.DateTimePicker();
            this.dtpEndAcademicYearEditPanel = new System.Windows.Forms.DateTimePicker();
            this.lblEndAcademicYearEditpanel = new System.Windows.Forms.Label();
            this.lblChooseAcademicYear = new System.Windows.Forms.Label();
            this.lblYearNameEditPanel = new System.Windows.Forms.Label();
            this.lblStartAcademicYearEditPanel = new System.Windows.Forms.Label();
            this.btnCoursesBack = new System.Windows.Forms.Button();
            this.lblSemester2 = new System.Windows.Forms.Label();
            this.rbtEditAcademicYear = new System.Windows.Forms.RadioButton();
            this.rbtAddAcademicYear = new System.Windows.Forms.RadioButton();
            this.pnlSemester = new System.Windows.Forms.Panel();
            this.btnBackToAcademicYear = new System.Windows.Forms.Button();
            this.pnlAddSemester = new System.Windows.Forms.Panel();
            this.btnSaveSemesrerPanel = new System.Windows.Forms.Button();
            this.cboAcademicYearSemesterPanel = new MetroFramework.Controls.MetroComboBox();
            this.cboSemesterName = new MetroFramework.Controls.MetroComboBox();
            this.lblSemesterName = new System.Windows.Forms.Label();
            this.lblSemesterEnd = new System.Windows.Forms.Label();
            this.dtpStartSemester = new System.Windows.Forms.DateTimePicker();
            this.lblSemesterStart = new System.Windows.Forms.Label();
            this.dtpEndSemester = new System.Windows.Forms.DateTimePicker();
            this.lblAcademicYearSemesterPanel = new System.Windows.Forms.Label();
            this.btnGoToCourse = new System.Windows.Forms.Button();
            this.pnlEditSemester = new System.Windows.Forms.Panel();
            this.cboSemesterNameEditPanel = new MetroFramework.Controls.MetroComboBox();
            this.cboAcademicYearEditSemesterPanel = new MetroFramework.Controls.MetroComboBox();
            this.btnSaveEditedSemester = new System.Windows.Forms.Button();
            this.lblSemesterNameEditPanel = new System.Windows.Forms.Label();
            this.lblEndSemesterEditPanel = new System.Windows.Forms.Label();
            this.dtpStartSemesterEditPanel = new System.Windows.Forms.DateTimePicker();
            this.lblStartSemesterEditPanel = new System.Windows.Forms.Label();
            this.dtpEndSemesterEditPanel = new System.Windows.Forms.DateTimePicker();
            this.lblAcademicYearSemesterEditPanel = new System.Windows.Forms.Label();
            this.cboChooseSemester = new MetroFramework.Controls.MetroComboBox();
            this.btnDeleteSemester = new System.Windows.Forms.Button();
            this.lblChooseSemester = new System.Windows.Forms.Label();
            this.rbtEditSemester = new System.Windows.Forms.RadioButton();
            this.rbtAddSemester = new System.Windows.Forms.RadioButton();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.pnlBackToAddingModeCover = new System.Windows.Forms.Panel();
            this.pnlBackToAddingMode = new System.Windows.Forms.Panel();
            this.btnBackToAddingMode = new System.Windows.Forms.Button();
            this.pnlCoverDeleteCourse = new System.Windows.Forms.Panel();
            this.pnlDeletecoursep = new System.Windows.Forms.Panel();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.cboAcademicYearCoursePanel = new MetroFramework.Controls.MetroComboBox();
            this.btnBackToSemester = new System.Windows.Forms.Button();
            this.cboSemesterCoursePanel = new MetroFramework.Controls.MetroComboBox();
            this.btnSaveCoursePanel = new System.Windows.Forms.Button();
            this.btnGoToLesson = new System.Windows.Forms.Button();
            this.txtPractices = new System.Windows.Forms.TextBox();
            this.txtLecturer = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblAddCourse = new System.Windows.Forms.Label();
            this.lblSemesterCoursePanel = new System.Windows.Forms.Label();
            this.lblAcademicYearCoursPanel = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblPractices = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.pnlCoursesToPresent = new System.Windows.Forms.Panel();
            this.lblCoursesToPresent = new System.Windows.Forms.Label();
            this.cboSemesterPresentCourse = new MetroFramework.Controls.MetroComboBox();
            this.cboAcademicYearPresentCourse = new MetroFramework.Controls.MetroComboBox();
            this.pnlNoCourses = new System.Windows.Forms.Panel();
            this.lblNoCoursesYet = new System.Windows.Forms.Label();
            this.pnlLesson = new System.Windows.Forms.Panel();
            this.cboLessonTimeUnit = new MetroFramework.Controls.MetroComboBox();
            this.lblAddNewClass = new System.Windows.Forms.Label();
            this.nudClassDuration = new System.Windows.Forms.NumericUpDown();
            this.btnBackToCourse = new System.Windows.Forms.Button();
            this.cboLessonPanelSemester = new MetroFramework.Controls.MetroComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblLessonPanelAcademicYear = new System.Windows.Forms.Label();
            this.cboLessonPanelAcademicYear = new MetroFramework.Controls.MetroComboBox();
            this.btnLessonPanelSave = new System.Windows.Forms.Button();
            this.lblLessonPanelCourse = new System.Windows.Forms.Label();
            this.lblLessonPanelSemester = new System.Windows.Forms.Label();
            this.lblStartLesson = new System.Windows.Forms.Label();
            this.cboLessonPanelType = new MetroFramework.Controls.MetroComboBox();
            this.dtpStartLesson = new System.Windows.Forms.DateTimePicker();
            this.lblLessonPanelType = new System.Windows.Forms.Label();
            this.cboLessonPanelCourse = new MetroFramework.Controls.MetroComboBox();
            this.lblLocationClass = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtLocationClass = new System.Windows.Forms.TextBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.mppCalendarScreen = new MultiPanelPage();
            this.dtpChooseDate = new System.Windows.Forms.DateTimePicker();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.btnCurrentWeek = new System.Windows.Forms.Button();
            this.cclUserCalendar = new CalendarControl.CalendarControl();
            this.lblNextWeek = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblLastWeek = new System.Windows.Forms.Label();
            this.btnCalendarBack = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.mppLoginScreen = new MultiPanelPage();
            this.lblStudentRoutine = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblOr2 = new System.Windows.Forms.Label();
            this.lblOr3 = new System.Windows.Forms.Label();
            this.picCompanyIcon = new System.Windows.Forms.PictureBox();
            this.lklForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mppEditEventScreen = new MultiPanelPage();
            this.rtfEditEventDescription = new System.Windows.Forms.RichTextBox();
            this.rtfEditEventLocation = new System.Windows.Forms.RichTextBox();
            this.rtfEditEventTitle = new System.Windows.Forms.RichTextBox();
            this.chkEditEventAllDay = new System.Windows.Forms.CheckBox();
            this.cboEditEventHowOften = new MetroFramework.Controls.MetroComboBox();
            this.dtpEditEventEndRepeatedEvent = new System.Windows.Forms.DateTimePicker();
            this.dtpEditEventEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEditEventStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnEditEventBack = new System.Windows.Forms.Button();
            this.btnEditEventSave = new System.Windows.Forms.Button();
            this.lblEditEventEnds = new System.Windows.Forms.Label();
            this.lblEditEventDescription = new System.Windows.Forms.Label();
            this.lblEditEventTo = new System.Windows.Forms.Label();
            this.lblEditEventLocation = new System.Windows.Forms.Label();
            this.lblEditEventRepeats = new System.Windows.Forms.Label();
            this.lblEditEventTime = new System.Windows.Forms.Label();
            this.lblEditEventTitle = new System.Windows.Forms.Label();
            this.lblEditEvent = new System.Windows.Forms.Label();
            this.picBackground2 = new System.Windows.Forms.PictureBox();
            this.mppAddEventScreen = new MultiPanelPage();
            this.rtfAddEventTitle = new System.Windows.Forms.RichTextBox();
            this.txtAddEventDescription = new System.Windows.Forms.RichTextBox();
            this.txtAddEventLocation = new System.Windows.Forms.RichTextBox();
            this.chkAddEventAllDay = new System.Windows.Forms.CheckBox();
            this.cboAddeventHowOften = new MetroFramework.Controls.MetroComboBox();
            this.dtpAddEventEndRepeated = new System.Windows.Forms.DateTimePicker();
            this.dtpAddEventEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpAddEventStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddEventBack = new System.Windows.Forms.Button();
            this.btnAddEventSave = new System.Windows.Forms.Button();
            this.lblAddEventEnds = new System.Windows.Forms.Label();
            this.lblAddEventDescription = new System.Windows.Forms.Label();
            this.lblAddEventTo = new System.Windows.Forms.Label();
            this.lblAddEventLocation = new System.Windows.Forms.Label();
            this.lblAddEventRepeats = new System.Windows.Forms.Label();
            this.lblAddEventTime = new System.Windows.Forms.Label();
            this.lblAddEventTitle = new System.Windows.Forms.Label();
            this.lblAddScheduleEvent = new System.Windows.Forms.Label();
            this.picBackground1 = new System.Windows.Forms.PictureBox();
            this.mppExamsScreen = new MultiPanelPage();
            this.lstExams = new System.Windows.Forms.ListBox();
            this.pnlNoExams = new System.Windows.Forms.Panel();
            this.lblNoExams = new System.Windows.Forms.Label();
            this.pnlSelectExam = new System.Windows.Forms.Panel();
            this.lblSelectExam = new System.Windows.Forms.Label();
            this.cboCourseDisplayExamPanel = new MetroFramework.Controls.MetroComboBox();
            this.cboSemesterDisplayExamPanel = new MetroFramework.Controls.MetroComboBox();
            this.cboAcademicYearDisplayExamPanel = new MetroFramework.Controls.MetroComboBox();
            this.pnlExams = new System.Windows.Forms.Panel();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnBackToAddingExam = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.txtExamLocation = new System.Windows.Forms.TextBox();
            this.txtExamTitle = new System.Windows.Forms.TextBox();
            this.txtSubjects = new System.Windows.Forms.TextBox();
            this.lstSubjects = new System.Windows.Forms.ListBox();
            this.cboExamTimeUnit = new MetroFramework.Controls.MetroComboBox();
            this.cboChooseCourseExamPage = new MetroFramework.Controls.MetroComboBox();
            this.nudExamDuration = new System.Windows.Forms.NumericUpDown();
            this.btnSaveExam = new System.Windows.Forms.Button();
            this.dtpExam = new System.Windows.Forms.DateTimePicker();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.lblNewExam = new System.Windows.Forms.Label();
            this.btnExamBack = new System.Windows.Forms.Button();
            this.lblDuartion = new System.Windows.Forms.Label();
            this.lblStartExam = new System.Windows.Forms.Label();
            this.lblExamLocation = new System.Windows.Forms.Label();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblExamsScreenCourse = new System.Windows.Forms.Label();
            this.lblExams = new System.Windows.Forms.Label();
            this.mppSettingsScreen = new MultiPanelPage();
            this.lklSaveChanges = new System.Windows.Forms.LinkLabel();
            this.lklSaveEmail = new System.Windows.Forms.LinkLabel();
            this.lklSavePassword = new System.Windows.Forms.LinkLabel();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.dtpEndActivity = new System.Windows.Forms.DateTimePicker();
            this.dtpStartActivity = new System.Windows.Forms.DateTimePicker();
            this.btnSettingsBack = new System.Windows.Forms.Button();
            this.lblEndActivity = new System.Windows.Forms.Label();
            this.lblStartActivity = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblChangeEmail = new System.Windows.Forms.Label();
            this.lblGashashim = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.lblActivityTime = new System.Windows.Forms.Label();
            this.lblPrivacy = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.mppTasksScreen = new MultiPanelPage();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.pnlFreeTimeSearch = new System.Windows.Forms.Panel();
            this.btnFreeTimeSearch = new System.Windows.Forms.Button();
            this.cboEstimateTimeUnit = new MetroFramework.Controls.MetroComboBox();
            this.lblAvailableTime = new System.Windows.Forms.Label();
            this.nudEstimateTime = new System.Windows.Forms.NumericUpDown();
            this.lblEstimateTime = new System.Windows.Forms.Label();
            this.pnlChooseTime = new System.Windows.Forms.Panel();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.dtpEndTask = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTask = new System.Windows.Forms.DateTimePicker();
            this.lblEndTask = new System.Windows.Forms.Label();
            this.lblStartTask = new System.Windows.Forms.Label();
            this.btnBackToAddingTask = new System.Windows.Forms.Button();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.cboCourseTaskPanel = new MetroFramework.Controls.MetroComboBox();
            this.rbtStartAndEndTask = new System.Windows.Forms.RadioButton();
            this.rbtFreeTimeSearch = new System.Windows.Forms.RadioButton();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblNewTask = new System.Windows.Forms.Label();
            this.btnTasksBack = new System.Windows.Forms.Button();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblCourseTasksPage = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.pnlCoverDisplayTask = new System.Windows.Forms.Panel();
            this.lblNoTasksYet = new System.Windows.Forms.Label();
            this.pnlSelectTask = new System.Windows.Forms.Panel();
            this.lblSelectTask = new System.Windows.Forms.Label();
            this.cboCourseDisplayTaskPanel = new MetroFramework.Controls.MetroComboBox();
            this.cboSemesterDisplayTaskPanel = new MetroFramework.Controls.MetroComboBox();
            this.cboAcademicYearDisplayTaskPanel = new MetroFramework.Controls.MetroComboBox();
            this.mppNotesScreen = new MultiPanelPage();
            this.rtfNote1 = new System.Windows.Forms.RichTextBox();
            this.rtfNote2 = new System.Windows.Forms.RichTextBox();
            this.rtfNote3 = new System.Windows.Forms.RichTextBox();
            this.rtfNote4 = new System.Windows.Forms.RichTextBox();
            this.rtfNote5 = new System.Windows.Forms.RichTextBox();
            this.rtfNote6 = new System.Windows.Forms.RichTextBox();
            this.rtfNote7 = new System.Windows.Forms.RichTextBox();
            this.rtfNote8 = new System.Windows.Forms.RichTextBox();
            this.rtfNote9 = new System.Windows.Forms.RichTextBox();
            this.rtfNote10 = new System.Windows.Forms.RichTextBox();
            this.btnNotesBack = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnRemoveNote = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.lblRemoveNote = new System.Windows.Forms.Label();
            this.lblAddNote = new System.Windows.Forms.Label();
            this.mppSignUpScreen = new MultiPanelPage();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.dtpBirthdaySignUp = new System.Windows.Forms.DateTimePicker();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordSignUp = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmailSignUp = new System.Windows.Forms.TextBox();
            this.dtpStartAcativitySignUp = new System.Windows.Forms.DateTimePicker();
            this.dtpEndActivitySignUp = new System.Windows.Forms.DateTimePicker();
            this.btnSignUpBack = new System.Windows.Forms.Button();
            this.lblConfirmPasswordSignUp = new System.Windows.Forms.Label();
            this.lblPasswordSignUp = new System.Windows.Forms.Label();
            this.lblToSignUp = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmailSignUp = new System.Windows.Forms.Label();
            this.lblBirthdaySignUp = new System.Windows.Forms.Label();
            this.lblActivityTimeSignUp = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.picBackground3 = new System.Windows.Forms.PictureBox();
            this.tmrLiveTiles = new System.Windows.Forms.Timer(this.components);
            backGroundbtn = new System.Windows.Forms.Button();
            this.mplScreens.SuspendLayout();
            this.mppMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            this.mppCoursesScreen.SuspendLayout();
            this.pnlAcademicYear.SuspendLayout();
            this.pnlAddNewAcademicYear.SuspendLayout();
            this.pnlEditAcademicYear.SuspendLayout();
            this.pnlSemester.SuspendLayout();
            this.pnlAddSemester.SuspendLayout();
            this.pnlEditSemester.SuspendLayout();
            this.pnlCourse.SuspendLayout();
            this.pnlBackToAddingMode.SuspendLayout();
            this.pnlDeletecoursep.SuspendLayout();
            this.pnlCoursesToPresent.SuspendLayout();
            this.pnlNoCourses.SuspendLayout();
            this.pnlLesson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClassDuration)).BeginInit();
            this.mppCalendarScreen.SuspendLayout();
            this.mppLoginScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyIcon)).BeginInit();
            this.mppEditEventScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground2)).BeginInit();
            this.mppAddEventScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground1)).BeginInit();
            this.mppExamsScreen.SuspendLayout();
            this.pnlNoExams.SuspendLayout();
            this.pnlSelectExam.SuspendLayout();
            this.pnlExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamDuration)).BeginInit();
            this.mppSettingsScreen.SuspendLayout();
            this.mppTasksScreen.SuspendLayout();
            this.pnlTasks.SuspendLayout();
            this.pnlFreeTimeSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimateTime)).BeginInit();
            this.pnlChooseTime.SuspendLayout();
            this.pnlCoverDisplayTask.SuspendLayout();
            this.pnlSelectTask.SuspendLayout();
            this.mppNotesScreen.SuspendLayout();
            this.mppSignUpScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground3)).BeginInit();
            this.SuspendLayout();
            // 
            // backGroundbtn
            // 
            backGroundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            backGroundbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            backGroundbtn.Enabled = false;
            backGroundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            backGroundbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            backGroundbtn.ForeColor = System.Drawing.Color.White;
            backGroundbtn.Location = new System.Drawing.Point(0, 46);
            backGroundbtn.Name = "backGroundbtn";
            backGroundbtn.Size = new System.Drawing.Size(1334, 175);
            backGroundbtn.TabIndex = 8;
            backGroundbtn.TabStop = false;
            backGroundbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            backGroundbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            backGroundbtn.UseCompatibleTextRendering = true;
            backGroundbtn.UseMnemonic = false;
            backGroundbtn.UseVisualStyleBackColor = false;
            // 
            // mplScreens
            // 
            this.mplScreens.Controls.Add(this.mppMainScreen);
            this.mplScreens.Controls.Add(this.mppCoursesScreen);
            this.mplScreens.Controls.Add(this.mppCalendarScreen);
            this.mplScreens.Controls.Add(this.mppLoginScreen);
            this.mplScreens.Controls.Add(this.mppEditEventScreen);
            this.mplScreens.Controls.Add(this.mppAddEventScreen);
            this.mplScreens.Controls.Add(this.mppExamsScreen);
            this.mplScreens.Controls.Add(this.mppSettingsScreen);
            this.mplScreens.Controls.Add(this.mppTasksScreen);
            this.mplScreens.Controls.Add(this.mppNotesScreen);
            this.mplScreens.Controls.Add(this.mppSignUpScreen);
            this.mplScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mplScreens.Location = new System.Drawing.Point(0, 0);
            this.mplScreens.Name = "mplScreens";
            this.mplScreens.SelectedPage = this.mppTasksScreen;
            this.mplScreens.Size = new System.Drawing.Size(1334, 736);
            this.mplScreens.TabIndex = 0;
            // 
            // mppMainScreen
            // 
            this.mppMainScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppMainScreen.Controls.Add(this.mtlClasses2);
            this.mppMainScreen.Controls.Add(this.cclMainCalendar);
            this.mppMainScreen.Controls.Add(this.btnLogOut);
            this.mppMainScreen.Controls.Add(this.lblNameFirstLetter);
            this.mppMainScreen.Controls.Add(this.picCircle);
            this.mppMainScreen.Controls.Add(this.lblLogOut);
            this.mppMainScreen.Controls.Add(this.lblEmail);
            this.mppMainScreen.Controls.Add(this.lblName);
            this.mppMainScreen.Controls.Add(this.btnSettings);
            this.mppMainScreen.Controls.Add(this.btnNotes);
            this.mppMainScreen.Controls.Add(this.btnExams);
            this.mppMainScreen.Controls.Add(this.btnTasks);
            this.mppMainScreen.Controls.Add(this.btnCourses);
            this.mppMainScreen.Controls.Add(this.btnCalendar);
            this.mppMainScreen.Controls.Add(this.lblDashboard);
            this.mppMainScreen.Controls.Add(this.mtlTasks2);
            this.mppMainScreen.Controls.Add(this.mtlTasks);
            this.mppMainScreen.Controls.Add(this.mtlExams2);
            this.mppMainScreen.Controls.Add(this.mtlExams);
            this.mppMainScreen.Controls.Add(this.mtlToday2);
            this.mppMainScreen.Controls.Add(this.mtlToday);
            this.mppMainScreen.Controls.Add(this.btnBackground);
            this.mppMainScreen.Controls.Add(this.mtlClasses);
            this.mppMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppMainScreen.Location = new System.Drawing.Point(0, 0);
            this.mppMainScreen.Name = "mppMainScreen";
            this.mppMainScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppMainScreen.TabIndex = 0;
            this.mppMainScreen.TabStop = false;
            this.mppMainScreen.Text = "Page1";
            this.mppMainScreen.VisibleChanged += new System.EventHandler(this.mppMainScreen_VisibleChanged);
            // 
            // mtlClasses2
            // 
            this.mtlClasses2.ActiveControl = null;
            this.mtlClasses2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlClasses2.AutoSize = true;
            this.mtlClasses2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.mtlClasses2.Location = new System.Drawing.Point(449, 458);
            this.mtlClasses2.Name = "mtlClasses2";
            this.mtlClasses2.Size = new System.Drawing.Size(280, 180);
            this.mtlClasses2.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtlClasses2.TabIndex = 1;
            this.mtlClasses2.TabStop = false;
            this.mtlClasses2.Text = "שיעורים";
            this.mtlClasses2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlClasses2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtlClasses2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlClasses2.UseCustomBackColor = true;
            this.mtlClasses2.UseSelectable = true;
            this.mtlClasses2.Click += new System.EventHandler(this.MoveToCoursesScreen);
            // 
            // cclMainCalendar
            // 
            this.cclMainCalendar.AllowItemEdit = false;
            this.cclMainCalendar.AllowItemResize = false;
            this.cclMainCalendar.AllowNew = false;
            this.cclMainCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cclMainCalendar.Calendar = null;
            this.cclMainCalendar.CalendarControlView = CalendarControl.CalendarControl.CalendarView.DayView;
            this.cclMainCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange29.DayOfWeek = System.DayOfWeek.Sunday;
            calendarHighlightRange29.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange29.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange30.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange30.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange30.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange31.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange31.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange31.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange32.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange32.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange32.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange33.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange33.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange33.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange34.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange34.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange34.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange35.DayOfWeek = System.DayOfWeek.Saturday;
            calendarHighlightRange35.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange35.StartTime = System.TimeSpan.Parse("08:00:00");
            this.cclMainCalendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange29,
        calendarHighlightRange30,
        calendarHighlightRange31,
        calendarHighlightRange32,
        calendarHighlightRange33,
        calendarHighlightRange34,
        calendarHighlightRange35};
            this.cclMainCalendar.Location = new System.Drawing.Point(0, 59);
            this.cclMainCalendar.Name = "cclMainCalendar";
            this.cclMainCalendar.Size = new System.Drawing.Size(282, 392);
            this.cclMainCalendar.SundayDate = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            this.cclMainCalendar.TabIndex = 44;
            this.cclMainCalendar.TabStop = false;
            this.cclMainCalendar.Text = "calendarControl1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnLogOut.Location = new System.Drawing.Point(1253, 17);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(69, 78);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.MoveToLogInScreen);
            // 
            // lblNameFirstLetter
            // 
            this.lblNameFirstLetter.AutoSize = true;
            this.lblNameFirstLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(62)))), ((int)(((byte)(197)))));
            this.lblNameFirstLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNameFirstLetter.ForeColor = System.Drawing.Color.White;
            this.lblNameFirstLetter.Location = new System.Drawing.Point(15, 12);
            this.lblNameFirstLetter.Name = "lblNameFirstLetter";
            this.lblNameFirstLetter.Size = new System.Drawing.Size(29, 29);
            this.lblNameFirstLetter.TabIndex = 8;
            this.lblNameFirstLetter.Text = "S";
            // 
            // picCircle
            // 
            this.picCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.picCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCircle.BackgroundImage")));
            this.picCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCircle.Location = new System.Drawing.Point(1, 2);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(56, 51);
            this.picCircle.TabIndex = 7;
            this.picCircle.TabStop = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLogOut.Location = new System.Drawing.Point(1249, 98);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(73, 20);
            this.lblLogOut.TabIndex = 6;
            this.lblLogOut.Text = "Log Out";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(62, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(62, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 686);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(282, 50);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.MoveToSettingsScreen);
            // 
            // btnNotes
            // 
            this.btnNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNotes.ForeColor = System.Drawing.Color.White;
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.Location = new System.Drawing.Point(0, 639);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(282, 50);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = false;
            this.btnNotes.Click += new System.EventHandler(this.MoveToNotesScreen);
            // 
            // btnExams
            // 
            this.btnExams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnExams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExams.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExams.ForeColor = System.Drawing.Color.White;
            this.btnExams.Image = ((System.Drawing.Image)(resources.GetObject("btnExams.Image")));
            this.btnExams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExams.Location = new System.Drawing.Point(0, 592);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(282, 50);
            this.btnExams.TabIndex = 3;
            this.btnExams.Text = "Exams";
            this.btnExams.UseVisualStyleBackColor = false;
            this.btnExams.Click += new System.EventHandler(this.MoveToExamsScreen);
            // 
            // btnTasks
            // 
            this.btnTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(0, 546);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(282, 50);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.MoveToTasksScreen);
            // 
            // btnCourses
            // 
            this.btnCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(0, 499);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(282, 50);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.MoveToCoursesScreen);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(188)))), ((int)(((byte)(158)))));
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 450);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(282, 50);
            this.btnCalendar.TabIndex = 0;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.MoveToCalendarScreen);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(418, 44);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(270, 55);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Dashboard";
            // 
            // mtlTasks2
            // 
            this.mtlTasks2.ActiveControl = null;
            this.mtlTasks2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlTasks2.AutoSize = true;
            this.mtlTasks2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.mtlTasks2.Location = new System.Drawing.Point(907, 207);
            this.mtlTasks2.Name = "mtlTasks2";
            this.mtlTasks2.Size = new System.Drawing.Size(280, 180);
            this.mtlTasks2.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtlTasks2.TabIndex = 1;
            this.mtlTasks2.TabStop = false;
            this.mtlTasks2.Text = "מטלות";
            this.mtlTasks2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlTasks2.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlTasks2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlTasks2.UseCustomBackColor = true;
            this.mtlTasks2.UseSelectable = true;
            this.mtlTasks2.Click += new System.EventHandler(this.MoveToTasksScreen);
            // 
            // mtlTasks
            // 
            this.mtlTasks.ActiveControl = null;
            this.mtlTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlTasks.AutoSize = true;
            this.mtlTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.mtlTasks.Location = new System.Drawing.Point(907, 207);
            this.mtlTasks.Name = "mtlTasks";
            this.mtlTasks.Size = new System.Drawing.Size(280, 180);
            this.mtlTasks.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtlTasks.TabIndex = 1;
            this.mtlTasks.TabStop = false;
            this.mtlTasks.Text = "מטלות";
            this.mtlTasks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlTasks.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlTasks.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlTasks.UseCustomBackColor = true;
            this.mtlTasks.UseSelectable = true;
            this.mtlTasks.Click += new System.EventHandler(this.MoveToTasksScreen);
            // 
            // mtlExams2
            // 
            this.mtlExams2.ActiveControl = null;
            this.mtlExams2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlExams2.AutoSize = true;
            this.mtlExams2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(39)))));
            this.mtlExams2.Location = new System.Drawing.Point(907, 458);
            this.mtlExams2.Name = "mtlExams2";
            this.mtlExams2.Size = new System.Drawing.Size(280, 180);
            this.mtlExams2.Style = MetroFramework.MetroColorStyle.Green;
            this.mtlExams2.TabIndex = 1;
            this.mtlExams2.TabStop = false;
            this.mtlExams2.Text = "מבחנים";
            this.mtlExams2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlExams2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlExams2.UseCustomBackColor = true;
            this.mtlExams2.UseSelectable = true;
            this.mtlExams2.Click += new System.EventHandler(this.MoveToExamsScreen);
            // 
            // mtlExams
            // 
            this.mtlExams.ActiveControl = null;
            this.mtlExams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlExams.AutoSize = true;
            this.mtlExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(39)))));
            this.mtlExams.Location = new System.Drawing.Point(907, 458);
            this.mtlExams.Name = "mtlExams";
            this.mtlExams.Size = new System.Drawing.Size(280, 180);
            this.mtlExams.Style = MetroFramework.MetroColorStyle.Green;
            this.mtlExams.TabIndex = 1;
            this.mtlExams.TabStop = false;
            this.mtlExams.Text = "מבחנים";
            this.mtlExams.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlExams.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlExams.UseCustomBackColor = true;
            this.mtlExams.UseSelectable = true;
            this.mtlExams.Click += new System.EventHandler(this.MoveToExamsScreen);
            // 
            // mtlToday2
            // 
            this.mtlToday2.ActiveControl = null;
            this.mtlToday2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlToday2.AutoSize = true;
            this.mtlToday2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mtlToday2.Location = new System.Drawing.Point(449, 207);
            this.mtlToday2.Name = "mtlToday2";
            this.mtlToday2.Size = new System.Drawing.Size(280, 180);
            this.mtlToday2.TabIndex = 1;
            this.mtlToday2.TabStop = false;
            this.mtlToday2.Text = "היום";
            this.mtlToday2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlToday2.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlToday2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlToday2.UseCustomBackColor = true;
            this.mtlToday2.UseSelectable = true;
            // 
            // mtlToday
            // 
            this.mtlToday.ActiveControl = null;
            this.mtlToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlToday.AutoSize = true;
            this.mtlToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mtlToday.Location = new System.Drawing.Point(449, 207);
            this.mtlToday.Name = "mtlToday";
            this.mtlToday.Size = new System.Drawing.Size(280, 180);
            this.mtlToday.TabIndex = 1;
            this.mtlToday.TabStop = false;
            this.mtlToday.Text = "היום";
            this.mtlToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlToday.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlToday.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlToday.UseCustomBackColor = true;
            this.mtlToday.UseSelectable = true;
            // 
            // btnBackground
            // 
            this.btnBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackground.Enabled = false;
            this.btnBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackground.Location = new System.Drawing.Point(0, 0);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(282, 736);
            this.btnBackground.TabIndex = 0;
            this.btnBackground.TabStop = false;
            this.btnBackground.UseVisualStyleBackColor = false;
            // 
            // mtlClasses
            // 
            this.mtlClasses.ActiveControl = null;
            this.mtlClasses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtlClasses.AutoSize = true;
            this.mtlClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.mtlClasses.Location = new System.Drawing.Point(449, 458);
            this.mtlClasses.Name = "mtlClasses";
            this.mtlClasses.Size = new System.Drawing.Size(280, 180);
            this.mtlClasses.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtlClasses.TabIndex = 1;
            this.mtlClasses.TabStop = false;
            this.mtlClasses.Text = "שיעורים";
            this.mtlClasses.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtlClasses.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtlClasses.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtlClasses.UseCustomBackColor = true;
            this.mtlClasses.UseSelectable = true;
            this.mtlClasses.Click += new System.EventHandler(this.MoveToCoursesScreen);
            // 
            // mppCoursesScreen
            // 
            this.mppCoursesScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppCoursesScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mppCoursesScreen.Controls.Add(this.pnlAcademicYear);
            this.mppCoursesScreen.Controls.Add(this.pnlSemester);
            this.mppCoursesScreen.Controls.Add(this.pnlCourse);
            this.mppCoursesScreen.Controls.Add(this.pnlCoursesToPresent);
            this.mppCoursesScreen.Controls.Add(this.pnlNoCourses);
            this.mppCoursesScreen.Controls.Add(this.pnlLesson);
            this.mppCoursesScreen.Controls.Add(this.lblCourses);
            this.mppCoursesScreen.Controls.Add(this.lstCourses);
            this.mppCoursesScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppCoursesScreen.Location = new System.Drawing.Point(0, 0);
            this.mppCoursesScreen.Name = "mppCoursesScreen";
            this.mppCoursesScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppCoursesScreen.TabIndex = 0;
            this.mppCoursesScreen.Text = "Page7";
            this.mppCoursesScreen.VisibleChanged += new System.EventHandler(this.mppCoursesScreen_VisibleChanged);
            // 
            // pnlAcademicYear
            // 
            this.pnlAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlAcademicYear.Controls.Add(this.pnlAddNewAcademicYear);
            this.pnlAcademicYear.Controls.Add(this.btnGoToSemester);
            this.pnlAcademicYear.Controls.Add(this.pnlEditAcademicYear);
            this.pnlAcademicYear.Controls.Add(this.btnCoursesBack);
            this.pnlAcademicYear.Controls.Add(this.lblSemester2);
            this.pnlAcademicYear.Controls.Add(this.rbtEditAcademicYear);
            this.pnlAcademicYear.Controls.Add(this.rbtAddAcademicYear);
            this.pnlAcademicYear.Location = new System.Drawing.Point(-1, 0);
            this.pnlAcademicYear.Name = "pnlAcademicYear";
            this.pnlAcademicYear.Size = new System.Drawing.Size(278, 755);
            this.pnlAcademicYear.TabIndex = 0;
            // 
            // pnlAddNewAcademicYear
            // 
            this.pnlAddNewAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlAddNewAcademicYear.Controls.Add(this.lblAcademicYearEnd);
            this.pnlAddNewAcademicYear.Controls.Add(this.btnSaveAcademicYearPanel);
            this.pnlAddNewAcademicYear.Controls.Add(this.cboAcademicYearNameAddPanel);
            this.pnlAddNewAcademicYear.Controls.Add(this.dtpStartAcademicYear);
            this.pnlAddNewAcademicYear.Controls.Add(this.dtpEndAcademicYear);
            this.pnlAddNewAcademicYear.Controls.Add(this.lblAcademicYearName);
            this.pnlAddNewAcademicYear.Controls.Add(this.lblAcademicYearStart);
            this.pnlAddNewAcademicYear.Location = new System.Drawing.Point(0, 227);
            this.pnlAddNewAcademicYear.Name = "pnlAddNewAcademicYear";
            this.pnlAddNewAcademicYear.Size = new System.Drawing.Size(278, 345);
            this.pnlAddNewAcademicYear.TabIndex = 39;
            // 
            // lblAcademicYearEnd
            // 
            this.lblAcademicYearEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYearEnd.AutoSize = true;
            this.lblAcademicYearEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYearEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearEnd.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYearEnd.Location = new System.Drawing.Point(2, 76);
            this.lblAcademicYearEnd.Name = "lblAcademicYearEnd";
            this.lblAcademicYearEnd.Size = new System.Drawing.Size(53, 25);
            this.lblAcademicYearEnd.TabIndex = 27;
            this.lblAcademicYearEnd.Text = "End";
            // 
            // btnSaveAcademicYearPanel
            // 
            this.btnSaveAcademicYearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveAcademicYearPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAcademicYearPanel.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveAcademicYearPanel.ForeColor = System.Drawing.Color.White;
            this.btnSaveAcademicYearPanel.Location = new System.Drawing.Point(195, 217);
            this.btnSaveAcademicYearPanel.Name = "btnSaveAcademicYearPanel";
            this.btnSaveAcademicYearPanel.Size = new System.Drawing.Size(74, 29);
            this.btnSaveAcademicYearPanel.TabIndex = 3;
            this.btnSaveAcademicYearPanel.Text = "Save";
            this.btnSaveAcademicYearPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAcademicYearPanel.UseVisualStyleBackColor = false;
            this.btnSaveAcademicYearPanel.Click += new System.EventHandler(this.btnSaveAcademicYearPanel_Click);
            // 
            // cboAcademicYearNameAddPanel
            // 
            this.cboAcademicYearNameAddPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearNameAddPanel.FormattingEnabled = true;
            this.cboAcademicYearNameAddPanel.ItemHeight = 23;
            this.cboAcademicYearNameAddPanel.Items.AddRange(new object[] {
            Education_Module.AcademicYear.AcademicYearName.FirstYear,
            Education_Module.AcademicYear.AcademicYearName.SecondYear,
            Education_Module.AcademicYear.AcademicYearName.ThirdYear,
            Education_Module.AcademicYear.AcademicYearName.FourthYear,
            Education_Module.AcademicYear.AcademicYearName.FifthYear,
            Education_Module.AcademicYear.AcademicYearName.SixthYear,
            Education_Module.AcademicYear.AcademicYearName.SeventhYear});
            this.cboAcademicYearNameAddPanel.Location = new System.Drawing.Point(77, 135);
            this.cboAcademicYearNameAddPanel.Name = "cboAcademicYearNameAddPanel";
            this.cboAcademicYearNameAddPanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearNameAddPanel.TabIndex = 2;
            this.cboAcademicYearNameAddPanel.UseSelectable = true;
            // 
            // dtpStartAcademicYear
            // 
            this.dtpStartAcademicYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStartAcademicYear.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartAcademicYear.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpStartAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStartAcademicYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartAcademicYear.Location = new System.Drawing.Point(77, 18);
            this.dtpStartAcademicYear.Name = "dtpStartAcademicYear";
            this.dtpStartAcademicYear.Size = new System.Drawing.Size(193, 22);
            this.dtpStartAcademicYear.TabIndex = 0;
            // 
            // dtpEndAcademicYear
            // 
            this.dtpEndAcademicYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEndAcademicYear.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndAcademicYear.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpEndAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEndAcademicYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndAcademicYear.Location = new System.Drawing.Point(77, 78);
            this.dtpEndAcademicYear.Name = "dtpEndAcademicYear";
            this.dtpEndAcademicYear.Size = new System.Drawing.Size(193, 22);
            this.dtpEndAcademicYear.TabIndex = 1;
            // 
            // lblAcademicYearName
            // 
            this.lblAcademicYearName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYearName.AutoSize = true;
            this.lblAcademicYearName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYearName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearName.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYearName.Location = new System.Drawing.Point(3, 135);
            this.lblAcademicYearName.Name = "lblAcademicYearName";
            this.lblAcademicYearName.Size = new System.Drawing.Size(62, 25);
            this.lblAcademicYearName.TabIndex = 27;
            this.lblAcademicYearName.Text = "Year";
            // 
            // lblAcademicYearStart
            // 
            this.lblAcademicYearStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYearStart.AutoSize = true;
            this.lblAcademicYearStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYearStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearStart.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYearStart.Location = new System.Drawing.Point(3, 16);
            this.lblAcademicYearStart.Name = "lblAcademicYearStart";
            this.lblAcademicYearStart.Size = new System.Drawing.Size(62, 25);
            this.lblAcademicYearStart.TabIndex = 27;
            this.lblAcademicYearStart.Text = "Start";
            // 
            // btnGoToSemester
            // 
            this.btnGoToSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnGoToSemester.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToSemester.BackgroundImage")));
            this.btnGoToSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoToSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnGoToSemester.Location = new System.Drawing.Point(215, 16);
            this.btnGoToSemester.Name = "btnGoToSemester";
            this.btnGoToSemester.Size = new System.Drawing.Size(59, 56);
            this.btnGoToSemester.TabIndex = 0;
            this.btnGoToSemester.UseVisualStyleBackColor = false;
            this.btnGoToSemester.Click += new System.EventHandler(this.goToSemesterBtn_Click);
            // 
            // pnlEditAcademicYear
            // 
            this.pnlEditAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlEditAcademicYear.Controls.Add(this.btnSaveEditedAcademicYear);
            this.pnlEditAcademicYear.Controls.Add(this.cboChooseExistAcademicYear);
            this.pnlEditAcademicYear.Controls.Add(this.btnDeleteAcademicYear);
            this.pnlEditAcademicYear.Controls.Add(this.cboAcademicYearNameEditPanel);
            this.pnlEditAcademicYear.Controls.Add(this.dtpStartAcademicYearEditPanel);
            this.pnlEditAcademicYear.Controls.Add(this.dtpEndAcademicYearEditPanel);
            this.pnlEditAcademicYear.Controls.Add(this.lblEndAcademicYearEditpanel);
            this.pnlEditAcademicYear.Controls.Add(this.lblChooseAcademicYear);
            this.pnlEditAcademicYear.Controls.Add(this.lblYearNameEditPanel);
            this.pnlEditAcademicYear.Controls.Add(this.lblStartAcademicYearEditPanel);
            this.pnlEditAcademicYear.Location = new System.Drawing.Point(0, 227);
            this.pnlEditAcademicYear.Name = "pnlEditAcademicYear";
            this.pnlEditAcademicYear.Size = new System.Drawing.Size(278, 345);
            this.pnlEditAcademicYear.TabIndex = 0;
            this.pnlEditAcademicYear.Visible = false;
            // 
            // btnSaveEditedAcademicYear
            // 
            this.btnSaveEditedAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveEditedAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEditedAcademicYear.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveEditedAcademicYear.ForeColor = System.Drawing.Color.White;
            this.btnSaveEditedAcademicYear.Location = new System.Drawing.Point(190, 303);
            this.btnSaveEditedAcademicYear.Name = "btnSaveEditedAcademicYear";
            this.btnSaveEditedAcademicYear.Size = new System.Drawing.Size(74, 29);
            this.btnSaveEditedAcademicYear.TabIndex = 4;
            this.btnSaveEditedAcademicYear.Text = "Save";
            this.btnSaveEditedAcademicYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveEditedAcademicYear.UseVisualStyleBackColor = false;
            this.btnSaveEditedAcademicYear.Click += new System.EventHandler(this.saveEditedAcademicYearBtn_Click);
            // 
            // cboChooseExistAcademicYear
            // 
            this.cboChooseExistAcademicYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboChooseExistAcademicYear.FormattingEnabled = true;
            this.cboChooseExistAcademicYear.ItemHeight = 23;
            this.cboChooseExistAcademicYear.Location = new System.Drawing.Point(12, 53);
            this.cboChooseExistAcademicYear.Name = "cboChooseExistAcademicYear";
            this.cboChooseExistAcademicYear.Size = new System.Drawing.Size(121, 29);
            this.cboChooseExistAcademicYear.TabIndex = 0;
            this.cboChooseExistAcademicYear.UseSelectable = true;
            this.cboChooseExistAcademicYear.SelectedIndexChanged += new System.EventHandler(this.cboChooseExistAcademicYear_SelectedIndexChanged);
            // 
            // btnDeleteAcademicYear
            // 
            this.btnDeleteAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteAcademicYear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAcademicYear.BackgroundImage")));
            this.btnDeleteAcademicYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteAcademicYear.Location = new System.Drawing.Point(139, 47);
            this.btnDeleteAcademicYear.Name = "btnDeleteAcademicYear";
            this.btnDeleteAcademicYear.Size = new System.Drawing.Size(36, 40);
            this.btnDeleteAcademicYear.TabIndex = 5;
            this.btnDeleteAcademicYear.UseVisualStyleBackColor = false;
            this.btnDeleteAcademicYear.Click += new System.EventHandler(this.btnDeleteAcademicYear_Click);
            // 
            // cboAcademicYearNameEditPanel
            // 
            this.cboAcademicYearNameEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearNameEditPanel.FormattingEnabled = true;
            this.cboAcademicYearNameEditPanel.ItemHeight = 23;
            this.cboAcademicYearNameEditPanel.Items.AddRange(new object[] {
            Education_Module.AcademicYear.AcademicYearName.FirstYear,
            Education_Module.AcademicYear.AcademicYearName.SecondYear,
            Education_Module.AcademicYear.AcademicYearName.ThirdYear,
            Education_Module.AcademicYear.AcademicYearName.FourthYear,
            Education_Module.AcademicYear.AcademicYearName.FifthYear,
            Education_Module.AcademicYear.AcademicYearName.SixthYear,
            Education_Module.AcademicYear.AcademicYearName.SeventhYear});
            this.cboAcademicYearNameEditPanel.Location = new System.Drawing.Point(78, 221);
            this.cboAcademicYearNameEditPanel.Name = "cboAcademicYearNameEditPanel";
            this.cboAcademicYearNameEditPanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearNameEditPanel.TabIndex = 3;
            this.cboAcademicYearNameEditPanel.UseSelectable = true;
            // 
            // dtpStartAcademicYearEditPanel
            // 
            this.dtpStartAcademicYearEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStartAcademicYearEditPanel.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartAcademicYearEditPanel.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpStartAcademicYearEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStartAcademicYearEditPanel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartAcademicYearEditPanel.Location = new System.Drawing.Point(77, 104);
            this.dtpStartAcademicYearEditPanel.Name = "dtpStartAcademicYearEditPanel";
            this.dtpStartAcademicYearEditPanel.Size = new System.Drawing.Size(193, 22);
            this.dtpStartAcademicYearEditPanel.TabIndex = 1;
            // 
            // dtpEndAcademicYearEditPanel
            // 
            this.dtpEndAcademicYearEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEndAcademicYearEditPanel.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndAcademicYearEditPanel.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpEndAcademicYearEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEndAcademicYearEditPanel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndAcademicYearEditPanel.Location = new System.Drawing.Point(78, 165);
            this.dtpEndAcademicYearEditPanel.Name = "dtpEndAcademicYearEditPanel";
            this.dtpEndAcademicYearEditPanel.Size = new System.Drawing.Size(193, 22);
            this.dtpEndAcademicYearEditPanel.TabIndex = 2;
            // 
            // lblEndAcademicYearEditpanel
            // 
            this.lblEndAcademicYearEditpanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndAcademicYearEditpanel.AutoSize = true;
            this.lblEndAcademicYearEditpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblEndAcademicYearEditpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndAcademicYearEditpanel.ForeColor = System.Drawing.Color.White;
            this.lblEndAcademicYearEditpanel.Location = new System.Drawing.Point(7, 162);
            this.lblEndAcademicYearEditpanel.Name = "lblEndAcademicYearEditpanel";
            this.lblEndAcademicYearEditpanel.Size = new System.Drawing.Size(53, 25);
            this.lblEndAcademicYearEditpanel.TabIndex = 27;
            this.lblEndAcademicYearEditpanel.Text = "End";
            // 
            // lblChooseAcademicYear
            // 
            this.lblChooseAcademicYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChooseAcademicYear.AutoSize = true;
            this.lblChooseAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblChooseAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAcademicYear.ForeColor = System.Drawing.Color.White;
            this.lblChooseAcademicYear.Location = new System.Drawing.Point(7, 12);
            this.lblChooseAcademicYear.Name = "lblChooseAcademicYear";
            this.lblChooseAcademicYear.Size = new System.Drawing.Size(252, 25);
            this.lblChooseAcademicYear.TabIndex = 38;
            this.lblChooseAcademicYear.Text = "Choose academic year";
            // 
            // lblYearNameEditPanel
            // 
            this.lblYearNameEditPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYearNameEditPanel.AutoSize = true;
            this.lblYearNameEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblYearNameEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearNameEditPanel.ForeColor = System.Drawing.Color.White;
            this.lblYearNameEditPanel.Location = new System.Drawing.Point(-2, 221);
            this.lblYearNameEditPanel.Name = "lblYearNameEditPanel";
            this.lblYearNameEditPanel.Size = new System.Drawing.Size(62, 25);
            this.lblYearNameEditPanel.TabIndex = 27;
            this.lblYearNameEditPanel.Text = "Year";
            // 
            // lblStartAcademicYearEditPanel
            // 
            this.lblStartAcademicYearEditPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartAcademicYearEditPanel.AutoSize = true;
            this.lblStartAcademicYearEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblStartAcademicYearEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartAcademicYearEditPanel.ForeColor = System.Drawing.Color.White;
            this.lblStartAcademicYearEditPanel.Location = new System.Drawing.Point(-2, 102);
            this.lblStartAcademicYearEditPanel.Name = "lblStartAcademicYearEditPanel";
            this.lblStartAcademicYearEditPanel.Size = new System.Drawing.Size(62, 25);
            this.lblStartAcademicYearEditPanel.TabIndex = 27;
            this.lblStartAcademicYearEditPanel.Text = "Start";
            // 
            // btnCoursesBack
            // 
            this.btnCoursesBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCoursesBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoursesBack.BackgroundImage")));
            this.btnCoursesBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoursesBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursesBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnCoursesBack.Location = new System.Drawing.Point(3, 15);
            this.btnCoursesBack.Name = "btnCoursesBack";
            this.btnCoursesBack.Size = new System.Drawing.Size(59, 56);
            this.btnCoursesBack.TabIndex = 5;
            this.btnCoursesBack.UseVisualStyleBackColor = false;
            this.btnCoursesBack.Click += new System.EventHandler(this.MoveToMainScreen);
            // 
            // lblSemester2
            // 
            this.lblSemester2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemester2.AutoSize = true;
            this.lblSemester2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemester2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester2.ForeColor = System.Drawing.Color.White;
            this.lblSemester2.Location = new System.Drawing.Point(202, 67);
            this.lblSemester2.Name = "lblSemester2";
            this.lblSemester2.Size = new System.Drawing.Size(72, 16);
            this.lblSemester2.TabIndex = 27;
            this.lblSemester2.Text = "semester";
            // 
            // rbtEditAcademicYear
            // 
            this.rbtEditAcademicYear.AutoSize = true;
            this.rbtEditAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEditAcademicYear.ForeColor = System.Drawing.Color.White;
            this.rbtEditAcademicYear.Location = new System.Drawing.Point(3, 175);
            this.rbtEditAcademicYear.Name = "rbtEditAcademicYear";
            this.rbtEditAcademicYear.Size = new System.Drawing.Size(243, 29);
            this.rbtEditAcademicYear.TabIndex = 36;
            this.rbtEditAcademicYear.Text = "Edit an academic year";
            this.rbtEditAcademicYear.UseVisualStyleBackColor = true;
            // 
            // rbtAddAcademicYear
            // 
            this.rbtAddAcademicYear.AutoSize = true;
            this.rbtAddAcademicYear.Checked = true;
            this.rbtAddAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAddAcademicYear.ForeColor = System.Drawing.Color.White;
            this.rbtAddAcademicYear.Location = new System.Drawing.Point(4, 127);
            this.rbtAddAcademicYear.Name = "rbtAddAcademicYear";
            this.rbtAddAcademicYear.Size = new System.Drawing.Size(277, 29);
            this.rbtAddAcademicYear.TabIndex = 35;
            this.rbtAddAcademicYear.TabStop = true;
            this.rbtAddAcademicYear.Text = "Add a new academic year";
            this.rbtAddAcademicYear.UseVisualStyleBackColor = true;
            this.rbtAddAcademicYear.CheckedChanged += new System.EventHandler(this.rbtAddAcademicYear_CheckedChanged);
            // 
            // pnlSemester
            // 
            this.pnlSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlSemester.Controls.Add(this.btnBackToAcademicYear);
            this.pnlSemester.Controls.Add(this.pnlAddSemester);
            this.pnlSemester.Controls.Add(this.btnGoToCourse);
            this.pnlSemester.Controls.Add(this.pnlEditSemester);
            this.pnlSemester.Controls.Add(this.rbtEditSemester);
            this.pnlSemester.Controls.Add(this.rbtAddSemester);
            this.pnlSemester.Controls.Add(this.lblAcademicYear);
            this.pnlSemester.Controls.Add(this.lblCourse2);
            this.pnlSemester.Location = new System.Drawing.Point(-2, -1);
            this.pnlSemester.Name = "pnlSemester";
            this.pnlSemester.Size = new System.Drawing.Size(278, 755);
            this.pnlSemester.TabIndex = 1;
            // 
            // btnBackToAcademicYear
            // 
            this.btnBackToAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAcademicYear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToAcademicYear.BackgroundImage")));
            this.btnBackToAcademicYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAcademicYear.Location = new System.Drawing.Point(20, 18);
            this.btnBackToAcademicYear.Name = "btnBackToAcademicYear";
            this.btnBackToAcademicYear.Size = new System.Drawing.Size(49, 56);
            this.btnBackToAcademicYear.TabIndex = 6;
            this.btnBackToAcademicYear.UseVisualStyleBackColor = false;
            this.btnBackToAcademicYear.Click += new System.EventHandler(this.backToAcademicYearBtn_Click);
            // 
            // pnlAddSemester
            // 
            this.pnlAddSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlAddSemester.Controls.Add(this.btnSaveSemesrerPanel);
            this.pnlAddSemester.Controls.Add(this.cboAcademicYearSemesterPanel);
            this.pnlAddSemester.Controls.Add(this.cboSemesterName);
            this.pnlAddSemester.Controls.Add(this.lblSemesterName);
            this.pnlAddSemester.Controls.Add(this.lblSemesterEnd);
            this.pnlAddSemester.Controls.Add(this.dtpStartSemester);
            this.pnlAddSemester.Controls.Add(this.lblSemesterStart);
            this.pnlAddSemester.Controls.Add(this.dtpEndSemester);
            this.pnlAddSemester.Controls.Add(this.lblAcademicYearSemesterPanel);
            this.pnlAddSemester.Location = new System.Drawing.Point(1, 213);
            this.pnlAddSemester.Name = "pnlAddSemester";
            this.pnlAddSemester.Size = new System.Drawing.Size(278, 400);
            this.pnlAddSemester.TabIndex = 39;
            // 
            // btnSaveSemesrerPanel
            // 
            this.btnSaveSemesrerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveSemesrerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSemesrerPanel.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveSemesrerPanel.ForeColor = System.Drawing.Color.White;
            this.btnSaveSemesrerPanel.Location = new System.Drawing.Point(181, 286);
            this.btnSaveSemesrerPanel.Name = "btnSaveSemesrerPanel";
            this.btnSaveSemesrerPanel.Size = new System.Drawing.Size(74, 29);
            this.btnSaveSemesrerPanel.TabIndex = 4;
            this.btnSaveSemesrerPanel.Text = "Save";
            this.btnSaveSemesrerPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveSemesrerPanel.UseVisualStyleBackColor = false;
            this.btnSaveSemesrerPanel.Click += new System.EventHandler(this.btnSaveSemesrerPanel_Click);
            // 
            // cboAcademicYearSemesterPanel
            // 
            this.cboAcademicYearSemesterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearSemesterPanel.FormattingEnabled = true;
            this.cboAcademicYearSemesterPanel.ItemHeight = 23;
            this.cboAcademicYearSemesterPanel.Location = new System.Drawing.Point(13, 61);
            this.cboAcademicYearSemesterPanel.Name = "cboAcademicYearSemesterPanel";
            this.cboAcademicYearSemesterPanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearSemesterPanel.TabIndex = 0;
            this.cboAcademicYearSemesterPanel.UseSelectable = true;
            // 
            // cboSemesterName
            // 
            this.cboSemesterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSemesterName.FormattingEnabled = true;
            this.cboSemesterName.ItemHeight = 23;
            this.cboSemesterName.Items.AddRange(new object[] {
            Education_Module.Semester.SemesterName.SemesterA,
            Education_Module.Semester.SemesterName.SemesterB,
            Education_Module.Semester.SemesterName.SemesterC});
            this.cboSemesterName.Location = new System.Drawing.Point(116, 219);
            this.cboSemesterName.Name = "cboSemesterName";
            this.cboSemesterName.Size = new System.Drawing.Size(121, 29);
            this.cboSemesterName.TabIndex = 3;
            this.cboSemesterName.UseSelectable = true;
            // 
            // lblSemesterName
            // 
            this.lblSemesterName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemesterName.AutoSize = true;
            this.lblSemesterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemesterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterName.ForeColor = System.Drawing.Color.White;
            this.lblSemesterName.Location = new System.Drawing.Point(-1, 219);
            this.lblSemesterName.Name = "lblSemesterName";
            this.lblSemesterName.Size = new System.Drawing.Size(111, 25);
            this.lblSemesterName.TabIndex = 27;
            this.lblSemesterName.Text = "Semester";
            // 
            // lblSemesterEnd
            // 
            this.lblSemesterEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemesterEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemesterEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterEnd.ForeColor = System.Drawing.Color.White;
            this.lblSemesterEnd.Location = new System.Drawing.Point(-1, 163);
            this.lblSemesterEnd.Name = "lblSemesterEnd";
            this.lblSemesterEnd.Size = new System.Drawing.Size(66, 37);
            this.lblSemesterEnd.TabIndex = 27;
            this.lblSemesterEnd.Text = "End";
            // 
            // dtpStartSemester
            // 
            this.dtpStartSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStartSemester.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartSemester.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpStartSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStartSemester.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartSemester.Location = new System.Drawing.Point(62, 113);
            this.dtpStartSemester.Name = "dtpStartSemester";
            this.dtpStartSemester.Size = new System.Drawing.Size(201, 22);
            this.dtpStartSemester.TabIndex = 1;
            // 
            // lblSemesterStart
            // 
            this.lblSemesterStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemesterStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemesterStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterStart.ForeColor = System.Drawing.Color.White;
            this.lblSemesterStart.Location = new System.Drawing.Point(-1, 108);
            this.lblSemesterStart.Name = "lblSemesterStart";
            this.lblSemesterStart.Size = new System.Drawing.Size(66, 37);
            this.lblSemesterStart.TabIndex = 27;
            this.lblSemesterStart.Text = "Start";
            // 
            // dtpEndSemester
            // 
            this.dtpEndSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEndSemester.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndSemester.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpEndSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEndSemester.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndSemester.Location = new System.Drawing.Point(62, 168);
            this.dtpEndSemester.Name = "dtpEndSemester";
            this.dtpEndSemester.Size = new System.Drawing.Size(201, 22);
            this.dtpEndSemester.TabIndex = 2;
            // 
            // lblAcademicYearSemesterPanel
            // 
            this.lblAcademicYearSemesterPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYearSemesterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYearSemesterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearSemesterPanel.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYearSemesterPanel.Location = new System.Drawing.Point(8, 21);
            this.lblAcademicYearSemesterPanel.Name = "lblAcademicYearSemesterPanel";
            this.lblAcademicYearSemesterPanel.Size = new System.Drawing.Size(171, 37);
            this.lblAcademicYearSemesterPanel.TabIndex = 27;
            this.lblAcademicYearSemesterPanel.Text = "Academic Year";
            // 
            // btnGoToCourse
            // 
            this.btnGoToCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnGoToCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToCourse.BackgroundImage")));
            this.btnGoToCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoToCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnGoToCourse.Location = new System.Drawing.Point(220, 18);
            this.btnGoToCourse.Name = "btnGoToCourse";
            this.btnGoToCourse.Size = new System.Drawing.Size(59, 56);
            this.btnGoToCourse.TabIndex = 0;
            this.btnGoToCourse.UseVisualStyleBackColor = false;
            this.btnGoToCourse.Click += new System.EventHandler(this.goToCourseBtn_Click);
            // 
            // pnlEditSemester
            // 
            this.pnlEditSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlEditSemester.Controls.Add(this.cboSemesterNameEditPanel);
            this.pnlEditSemester.Controls.Add(this.cboAcademicYearEditSemesterPanel);
            this.pnlEditSemester.Controls.Add(this.btnSaveEditedSemester);
            this.pnlEditSemester.Controls.Add(this.lblSemesterNameEditPanel);
            this.pnlEditSemester.Controls.Add(this.lblEndSemesterEditPanel);
            this.pnlEditSemester.Controls.Add(this.dtpStartSemesterEditPanel);
            this.pnlEditSemester.Controls.Add(this.lblStartSemesterEditPanel);
            this.pnlEditSemester.Controls.Add(this.dtpEndSemesterEditPanel);
            this.pnlEditSemester.Controls.Add(this.lblAcademicYearSemesterEditPanel);
            this.pnlEditSemester.Controls.Add(this.cboChooseSemester);
            this.pnlEditSemester.Controls.Add(this.btnDeleteSemester);
            this.pnlEditSemester.Controls.Add(this.lblChooseSemester);
            this.pnlEditSemester.Location = new System.Drawing.Point(-1, 213);
            this.pnlEditSemester.Name = "pnlEditSemester";
            this.pnlEditSemester.Size = new System.Drawing.Size(278, 400);
            this.pnlEditSemester.TabIndex = 0;
            // 
            // cboSemesterNameEditPanel
            // 
            this.cboSemesterNameEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSemesterNameEditPanel.FormattingEnabled = true;
            this.cboSemesterNameEditPanel.ItemHeight = 23;
            this.cboSemesterNameEditPanel.Items.AddRange(new object[] {
            Education_Module.Semester.SemesterName.SemesterA,
            Education_Module.Semester.SemesterName.SemesterB,
            Education_Module.Semester.SemesterName.SemesterC});
            this.cboSemesterNameEditPanel.Location = new System.Drawing.Point(125, 294);
            this.cboSemesterNameEditPanel.Name = "cboSemesterNameEditPanel";
            this.cboSemesterNameEditPanel.Size = new System.Drawing.Size(121, 29);
            this.cboSemesterNameEditPanel.TabIndex = 5;
            this.cboSemesterNameEditPanel.UseSelectable = true;
            // 
            // cboAcademicYearEditSemesterPanel
            // 
            this.cboAcademicYearEditSemesterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearEditSemesterPanel.FormattingEnabled = true;
            this.cboAcademicYearEditSemesterPanel.ItemHeight = 23;
            this.cboAcademicYearEditSemesterPanel.Location = new System.Drawing.Point(14, 53);
            this.cboAcademicYearEditSemesterPanel.Name = "cboAcademicYearEditSemesterPanel";
            this.cboAcademicYearEditSemesterPanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearEditSemesterPanel.TabIndex = 0;
            this.cboAcademicYearEditSemesterPanel.UseSelectable = true;
            this.cboAcademicYearEditSemesterPanel.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearEditSemesterPanel_SelectedIndexChanged);
            // 
            // btnSaveEditedSemester
            // 
            this.btnSaveEditedSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveEditedSemester.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEditedSemester.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveEditedSemester.ForeColor = System.Drawing.Color.White;
            this.btnSaveEditedSemester.Location = new System.Drawing.Point(188, 354);
            this.btnSaveEditedSemester.Name = "btnSaveEditedSemester";
            this.btnSaveEditedSemester.Size = new System.Drawing.Size(74, 29);
            this.btnSaveEditedSemester.TabIndex = 6;
            this.btnSaveEditedSemester.Text = "Save";
            this.btnSaveEditedSemester.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveEditedSemester.UseVisualStyleBackColor = false;
            this.btnSaveEditedSemester.Click += new System.EventHandler(this.btnSaveEditedSemester_Click);
            // 
            // lblSemesterNameEditPanel
            // 
            this.lblSemesterNameEditPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemesterNameEditPanel.AutoSize = true;
            this.lblSemesterNameEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemesterNameEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterNameEditPanel.ForeColor = System.Drawing.Color.White;
            this.lblSemesterNameEditPanel.Location = new System.Drawing.Point(6, 294);
            this.lblSemesterNameEditPanel.Name = "lblSemesterNameEditPanel";
            this.lblSemesterNameEditPanel.Size = new System.Drawing.Size(111, 25);
            this.lblSemesterNameEditPanel.TabIndex = 43;
            this.lblSemesterNameEditPanel.Text = "Semester";
            // 
            // lblEndSemesterEditPanel
            // 
            this.lblEndSemesterEditPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndSemesterEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblEndSemesterEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndSemesterEditPanel.ForeColor = System.Drawing.Color.White;
            this.lblEndSemesterEditPanel.Location = new System.Drawing.Point(6, 238);
            this.lblEndSemesterEditPanel.Name = "lblEndSemesterEditPanel";
            this.lblEndSemesterEditPanel.Size = new System.Drawing.Size(66, 37);
            this.lblEndSemesterEditPanel.TabIndex = 44;
            this.lblEndSemesterEditPanel.Text = "End";
            // 
            // dtpStartSemesterEditPanel
            // 
            this.dtpStartSemesterEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStartSemesterEditPanel.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartSemesterEditPanel.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpStartSemesterEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStartSemesterEditPanel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartSemesterEditPanel.Location = new System.Drawing.Point(69, 193);
            this.dtpStartSemesterEditPanel.Name = "dtpStartSemesterEditPanel";
            this.dtpStartSemesterEditPanel.Size = new System.Drawing.Size(201, 22);
            this.dtpStartSemesterEditPanel.TabIndex = 3;
            // 
            // lblStartSemesterEditPanel
            // 
            this.lblStartSemesterEditPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartSemesterEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblStartSemesterEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSemesterEditPanel.ForeColor = System.Drawing.Color.White;
            this.lblStartSemesterEditPanel.Location = new System.Drawing.Point(6, 190);
            this.lblStartSemesterEditPanel.Name = "lblStartSemesterEditPanel";
            this.lblStartSemesterEditPanel.Size = new System.Drawing.Size(66, 37);
            this.lblStartSemesterEditPanel.TabIndex = 45;
            this.lblStartSemesterEditPanel.Text = "Start";
            // 
            // dtpEndSemesterEditPanel
            // 
            this.dtpEndSemesterEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEndSemesterEditPanel.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndSemesterEditPanel.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpEndSemesterEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEndSemesterEditPanel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndSemesterEditPanel.Location = new System.Drawing.Point(69, 241);
            this.dtpEndSemesterEditPanel.Name = "dtpEndSemesterEditPanel";
            this.dtpEndSemesterEditPanel.Size = new System.Drawing.Size(201, 22);
            this.dtpEndSemesterEditPanel.TabIndex = 4;
            // 
            // lblAcademicYearSemesterEditPanel
            // 
            this.lblAcademicYearSemesterEditPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYearSemesterEditPanel.AutoSize = true;
            this.lblAcademicYearSemesterEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYearSemesterEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearSemesterEditPanel.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYearSemesterEditPanel.Location = new System.Drawing.Point(9, 15);
            this.lblAcademicYearSemesterEditPanel.Name = "lblAcademicYearSemesterEditPanel";
            this.lblAcademicYearSemesterEditPanel.Size = new System.Drawing.Size(256, 25);
            this.lblAcademicYearSemesterEditPanel.TabIndex = 46;
            this.lblAcademicYearSemesterEditPanel.Text = "Choose academic Year";
            // 
            // cboChooseSemester
            // 
            this.cboChooseSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboChooseSemester.FormattingEnabled = true;
            this.cboChooseSemester.ItemHeight = 23;
            this.cboChooseSemester.Location = new System.Drawing.Point(14, 135);
            this.cboChooseSemester.Name = "cboChooseSemester";
            this.cboChooseSemester.Size = new System.Drawing.Size(121, 29);
            this.cboChooseSemester.TabIndex = 1;
            this.cboChooseSemester.UseSelectable = true;
            this.cboChooseSemester.SelectedIndexChanged += new System.EventHandler(this.cboChooseSemester_SelectedIndexChanged);
            // 
            // btnDeleteSemester
            // 
            this.btnDeleteSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteSemester.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSemester.BackgroundImage")));
            this.btnDeleteSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteSemester.Location = new System.Drawing.Point(141, 130);
            this.btnDeleteSemester.Name = "btnDeleteSemester";
            this.btnDeleteSemester.Size = new System.Drawing.Size(36, 40);
            this.btnDeleteSemester.TabIndex = 2;
            this.btnDeleteSemester.UseVisualStyleBackColor = false;
            this.btnDeleteSemester.Click += new System.EventHandler(this.btnDeleteSemester_Click);
            // 
            // lblChooseSemester
            // 
            this.lblChooseSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChooseSemester.AutoSize = true;
            this.lblChooseSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblChooseSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSemester.ForeColor = System.Drawing.Color.White;
            this.lblChooseSemester.Location = new System.Drawing.Point(9, 97);
            this.lblChooseSemester.Name = "lblChooseSemester";
            this.lblChooseSemester.Size = new System.Drawing.Size(195, 25);
            this.lblChooseSemester.TabIndex = 38;
            this.lblChooseSemester.Text = "Choose semester";
            // 
            // rbtEditSemester
            // 
            this.rbtEditSemester.AutoSize = true;
            this.rbtEditSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEditSemester.ForeColor = System.Drawing.Color.White;
            this.rbtEditSemester.Location = new System.Drawing.Point(13, 177);
            this.rbtEditSemester.Name = "rbtEditSemester";
            this.rbtEditSemester.Size = new System.Drawing.Size(179, 29);
            this.rbtEditSemester.TabIndex = 35;
            this.rbtEditSemester.Text = "Edit a semester";
            this.rbtEditSemester.UseVisualStyleBackColor = true;
            // 
            // rbtAddSemester
            // 
            this.rbtAddSemester.AutoSize = true;
            this.rbtAddSemester.Checked = true;
            this.rbtAddSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAddSemester.ForeColor = System.Drawing.Color.White;
            this.rbtAddSemester.Location = new System.Drawing.Point(13, 133);
            this.rbtAddSemester.Name = "rbtAddSemester";
            this.rbtAddSemester.Size = new System.Drawing.Size(225, 29);
            this.rbtAddSemester.TabIndex = 35;
            this.rbtAddSemester.TabStop = true;
            this.rbtAddSemester.Text = "Add a new semester";
            this.rbtAddSemester.UseVisualStyleBackColor = true;
            this.rbtAddSemester.CheckedChanged += new System.EventHandler(this.rbtAddSemester_CheckedChanged);
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYear.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYear.Location = new System.Drawing.Point(1, 70);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(111, 16);
            this.lblAcademicYear.TabIndex = 27;
            this.lblAcademicYear.Text = "academic year";
            // 
            // lblCourse2
            // 
            this.lblCourse2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse2.ForeColor = System.Drawing.Color.White;
            this.lblCourse2.Location = new System.Drawing.Point(214, 70);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(55, 16);
            this.lblCourse2.TabIndex = 27;
            this.lblCourse2.Text = "course";
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlCourse.Controls.Add(this.pnlBackToAddingModeCover);
            this.pnlCourse.Controls.Add(this.pnlBackToAddingMode);
            this.pnlCourse.Controls.Add(this.pnlCoverDeleteCourse);
            this.pnlCourse.Controls.Add(this.pnlDeletecoursep);
            this.pnlCourse.Controls.Add(this.cboAcademicYearCoursePanel);
            this.pnlCourse.Controls.Add(this.btnBackToSemester);
            this.pnlCourse.Controls.Add(this.cboSemesterCoursePanel);
            this.pnlCourse.Controls.Add(this.btnSaveCoursePanel);
            this.pnlCourse.Controls.Add(this.btnGoToLesson);
            this.pnlCourse.Controls.Add(this.txtPractices);
            this.pnlCourse.Controls.Add(this.txtLecturer);
            this.pnlCourse.Controls.Add(this.lblSemester);
            this.pnlCourse.Controls.Add(this.lblLesson);
            this.pnlCourse.Controls.Add(this.lblAddCourse);
            this.pnlCourse.Controls.Add(this.lblSemesterCoursePanel);
            this.pnlCourse.Controls.Add(this.lblAcademicYearCoursPanel);
            this.pnlCourse.Controls.Add(this.txtCourseName);
            this.pnlCourse.Controls.Add(this.lblCourseName);
            this.pnlCourse.Controls.Add(this.lblPractices);
            this.pnlCourse.Controls.Add(this.lblLecturer);
            this.pnlCourse.Location = new System.Drawing.Point(-1, 0);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(278, 755);
            this.pnlCourse.TabIndex = 2;
            // 
            // pnlBackToAddingModeCover
            // 
            this.pnlBackToAddingModeCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlBackToAddingModeCover.Location = new System.Drawing.Point(12, 97);
            this.pnlBackToAddingModeCover.Name = "pnlBackToAddingModeCover";
            this.pnlBackToAddingModeCover.Size = new System.Drawing.Size(227, 44);
            this.pnlBackToAddingModeCover.TabIndex = 39;
            // 
            // pnlBackToAddingMode
            // 
            this.pnlBackToAddingMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlBackToAddingMode.Controls.Add(this.btnBackToAddingMode);
            this.pnlBackToAddingMode.Location = new System.Drawing.Point(8, 96);
            this.pnlBackToAddingMode.Name = "pnlBackToAddingMode";
            this.pnlBackToAddingMode.Size = new System.Drawing.Size(245, 46);
            this.pnlBackToAddingMode.TabIndex = 39;
            // 
            // btnBackToAddingMode
            // 
            this.btnBackToAddingMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAddingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToAddingMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAddingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToAddingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAddingMode.ForeColor = System.Drawing.Color.White;
            this.btnBackToAddingMode.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToAddingMode.Image")));
            this.btnBackToAddingMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToAddingMode.Location = new System.Drawing.Point(3, 3);
            this.btnBackToAddingMode.Name = "btnBackToAddingMode";
            this.btnBackToAddingMode.Size = new System.Drawing.Size(236, 40);
            this.btnBackToAddingMode.TabIndex = 6;
            this.btnBackToAddingMode.Text = "Back to adding mode";
            this.btnBackToAddingMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToAddingMode.UseVisualStyleBackColor = false;
            this.btnBackToAddingMode.Click += new System.EventHandler(this.btnBackToAddingMode_Click);
            // 
            // pnlCoverDeleteCourse
            // 
            this.pnlCoverDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlCoverDeleteCourse.Location = new System.Drawing.Point(13, 461);
            this.pnlCoverDeleteCourse.Name = "pnlCoverDeleteCourse";
            this.pnlCoverDeleteCourse.Size = new System.Drawing.Size(177, 61);
            this.pnlCoverDeleteCourse.TabIndex = 39;
            // 
            // pnlDeletecoursep
            // 
            this.pnlDeletecoursep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlDeletecoursep.Controls.Add(this.btnDeleteCourse);
            this.pnlDeletecoursep.Location = new System.Drawing.Point(8, 461);
            this.pnlDeletecoursep.Name = "pnlDeletecoursep";
            this.pnlDeletecoursep.Size = new System.Drawing.Size(186, 57);
            this.pnlDeletecoursep.TabIndex = 39;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCourse.Image")));
            this.btnDeleteCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCourse.Location = new System.Drawing.Point(0, 9);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(178, 40);
            this.btnDeleteCourse.TabIndex = 5;
            this.btnDeleteCourse.Text = "Delete course";
            this.btnDeleteCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // cboAcademicYearCoursePanel
            // 
            this.cboAcademicYearCoursePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearCoursePanel.FormattingEnabled = true;
            this.cboAcademicYearCoursePanel.ItemHeight = 23;
            this.cboAcademicYearCoursePanel.Location = new System.Drawing.Point(151, 203);
            this.cboAcademicYearCoursePanel.Name = "cboAcademicYearCoursePanel";
            this.cboAcademicYearCoursePanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearCoursePanel.TabIndex = 0;
            this.cboAcademicYearCoursePanel.UseSelectable = true;
            this.cboAcademicYearCoursePanel.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearEditSemesterPanel_SelectedIndexChanged);
            // 
            // btnBackToSemester
            // 
            this.btnBackToSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToSemester.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToSemester.BackgroundImage")));
            this.btnBackToSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToSemester.Location = new System.Drawing.Point(13, 15);
            this.btnBackToSemester.Name = "btnBackToSemester";
            this.btnBackToSemester.Size = new System.Drawing.Size(46, 56);
            this.btnBackToSemester.TabIndex = 8;
            this.btnBackToSemester.UseVisualStyleBackColor = false;
            this.btnBackToSemester.Click += new System.EventHandler(this.goToSemesterBtn_Click);
            // 
            // cboSemesterCoursePanel
            // 
            this.cboSemesterCoursePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSemesterCoursePanel.FormattingEnabled = true;
            this.cboSemesterCoursePanel.ItemHeight = 23;
            this.cboSemesterCoursePanel.Location = new System.Drawing.Point(150, 257);
            this.cboSemesterCoursePanel.Name = "cboSemesterCoursePanel";
            this.cboSemesterCoursePanel.Size = new System.Drawing.Size(121, 29);
            this.cboSemesterCoursePanel.TabIndex = 1;
            this.cboSemesterCoursePanel.UseSelectable = true;
            // 
            // btnSaveCoursePanel
            // 
            this.btnSaveCoursePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveCoursePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCoursePanel.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveCoursePanel.ForeColor = System.Drawing.Color.White;
            this.btnSaveCoursePanel.Location = new System.Drawing.Point(197, 501);
            this.btnSaveCoursePanel.Name = "btnSaveCoursePanel";
            this.btnSaveCoursePanel.Size = new System.Drawing.Size(70, 30);
            this.btnSaveCoursePanel.TabIndex = 5;
            this.btnSaveCoursePanel.Text = "Save";
            this.btnSaveCoursePanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveCoursePanel.UseVisualStyleBackColor = false;
            this.btnSaveCoursePanel.Click += new System.EventHandler(this.btnSaveCoursePanel_Click);
            // 
            // btnGoToLesson
            // 
            this.btnGoToLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnGoToLesson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToLesson.BackgroundImage")));
            this.btnGoToLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoToLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnGoToLesson.Location = new System.Drawing.Point(216, 15);
            this.btnGoToLesson.Name = "btnGoToLesson";
            this.btnGoToLesson.Size = new System.Drawing.Size(55, 56);
            this.btnGoToLesson.TabIndex = 6;
            this.btnGoToLesson.UseVisualStyleBackColor = false;
            this.btnGoToLesson.Click += new System.EventHandler(this.goToLessonBtn_Click);
            // 
            // txtPractices
            // 
            this.txtPractices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPractices.Location = new System.Drawing.Point(119, 416);
            this.txtPractices.Name = "txtPractices";
            this.txtPractices.Size = new System.Drawing.Size(153, 26);
            this.txtPractices.TabIndex = 4;
            // 
            // txtLecturer
            // 
            this.txtLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturer.Location = new System.Drawing.Point(119, 366);
            this.txtLecturer.Name = "txtLecturer";
            this.txtLecturer.Size = new System.Drawing.Size(153, 26);
            this.txtLecturer.TabIndex = 3;
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemester.AutoSize = true;
            this.lblSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(13, 69);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(72, 16);
            this.lblSemester.TabIndex = 27;
            this.lblSemester.Text = "semester";
            // 
            // lblLesson
            // 
            this.lblLesson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLesson.AutoSize = true;
            this.lblLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesson.ForeColor = System.Drawing.Color.White;
            this.lblLesson.Location = new System.Drawing.Point(216, 68);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(45, 16);
            this.lblLesson.TabIndex = 27;
            this.lblLesson.Text = "class";
            // 
            // lblAddCourse
            // 
            this.lblAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourse.ForeColor = System.Drawing.Color.White;
            this.lblAddCourse.Location = new System.Drawing.Point(3, 145);
            this.lblAddCourse.Name = "lblAddCourse";
            this.lblAddCourse.Size = new System.Drawing.Size(231, 37);
            this.lblAddCourse.TabIndex = 27;
            this.lblAddCourse.Text = "Add a new course";
            // 
            // lblSemesterCoursePanel
            // 
            this.lblSemesterCoursePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemesterCoursePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSemesterCoursePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterCoursePanel.ForeColor = System.Drawing.Color.White;
            this.lblSemesterCoursePanel.Location = new System.Drawing.Point(3, 260);
            this.lblSemesterCoursePanel.Name = "lblSemesterCoursePanel";
            this.lblSemesterCoursePanel.Size = new System.Drawing.Size(168, 37);
            this.lblSemesterCoursePanel.TabIndex = 27;
            this.lblSemesterCoursePanel.Text = "Semester";
            // 
            // lblAcademicYearCoursPanel
            // 
            this.lblAcademicYearCoursPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAcademicYearCoursPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAcademicYearCoursPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYearCoursPanel.ForeColor = System.Drawing.Color.White;
            this.lblAcademicYearCoursPanel.Location = new System.Drawing.Point(3, 202);
            this.lblAcademicYearCoursPanel.Name = "lblAcademicYearCoursPanel";
            this.lblAcademicYearCoursPanel.Size = new System.Drawing.Size(168, 37);
            this.lblAcademicYearCoursPanel.TabIndex = 27;
            this.lblAcademicYearCoursPanel.Text = "Academic Year";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(90, 316);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(182, 26);
            this.txtCourseName.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(4, 315);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(77, 37);
            this.lblCourseName.TabIndex = 27;
            this.lblCourseName.Text = "Name";
            // 
            // lblPractices
            // 
            this.lblPractices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPractices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblPractices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPractices.ForeColor = System.Drawing.Color.White;
            this.lblPractices.Location = new System.Drawing.Point(3, 416);
            this.lblPractices.Name = "lblPractices";
            this.lblPractices.Size = new System.Drawing.Size(114, 37);
            this.lblPractices.TabIndex = 27;
            this.lblPractices.Text = "Practices";
            // 
            // lblLecturer
            // 
            this.lblLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturer.ForeColor = System.Drawing.Color.White;
            this.lblLecturer.Location = new System.Drawing.Point(4, 365);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(114, 37);
            this.lblLecturer.TabIndex = 27;
            this.lblLecturer.Text = "Lecturer";
            // 
            // pnlCoursesToPresent
            // 
            this.pnlCoursesToPresent.Controls.Add(this.lblCoursesToPresent);
            this.pnlCoursesToPresent.Controls.Add(this.cboSemesterPresentCourse);
            this.pnlCoursesToPresent.Controls.Add(this.cboAcademicYearPresentCourse);
            this.pnlCoursesToPresent.Location = new System.Drawing.Point(330, 91);
            this.pnlCoursesToPresent.Name = "pnlCoursesToPresent";
            this.pnlCoursesToPresent.Size = new System.Drawing.Size(349, 92);
            this.pnlCoursesToPresent.TabIndex = 73;
            // 
            // lblCoursesToPresent
            // 
            this.lblCoursesToPresent.AutoSize = true;
            this.lblCoursesToPresent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblCoursesToPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesToPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblCoursesToPresent.Location = new System.Drawing.Point(3, 6);
            this.lblCoursesToPresent.Name = "lblCoursesToPresent";
            this.lblCoursesToPresent.Size = new System.Drawing.Size(277, 25);
            this.lblCoursesToPresent.TabIndex = 27;
            this.lblCoursesToPresent.Text = "Select courses to display";
            // 
            // cboSemesterPresentCourse
            // 
            this.cboSemesterPresentCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSemesterPresentCourse.FormattingEnabled = true;
            this.cboSemesterPresentCourse.ItemHeight = 23;
            this.cboSemesterPresentCourse.Location = new System.Drawing.Point(145, 48);
            this.cboSemesterPresentCourse.Name = "cboSemesterPresentCourse";
            this.cboSemesterPresentCourse.Size = new System.Drawing.Size(121, 29);
            this.cboSemesterPresentCourse.TabIndex = 28;
            this.cboSemesterPresentCourse.TabStop = false;
            this.cboSemesterPresentCourse.UseSelectable = true;
            this.cboSemesterPresentCourse.SelectedIndexChanged += new System.EventHandler(this.cboChooseSemester_SelectedIndexChanged);
            // 
            // cboAcademicYearPresentCourse
            // 
            this.cboAcademicYearPresentCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearPresentCourse.FormattingEnabled = true;
            this.cboAcademicYearPresentCourse.ItemHeight = 23;
            this.cboAcademicYearPresentCourse.Location = new System.Drawing.Point(8, 48);
            this.cboAcademicYearPresentCourse.Name = "cboAcademicYearPresentCourse";
            this.cboAcademicYearPresentCourse.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearPresentCourse.TabIndex = 0;
            this.cboAcademicYearPresentCourse.TabStop = false;
            this.cboAcademicYearPresentCourse.UseSelectable = true;
            this.cboAcademicYearPresentCourse.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearEditSemesterPanel_SelectedIndexChanged);
            // 
            // pnlNoCourses
            // 
            this.pnlNoCourses.Controls.Add(this.lblNoCoursesYet);
            this.pnlNoCourses.Location = new System.Drawing.Point(329, 91);
            this.pnlNoCourses.Name = "pnlNoCourses";
            this.pnlNoCourses.Size = new System.Drawing.Size(349, 92);
            this.pnlNoCourses.TabIndex = 73;
            // 
            // lblNoCoursesYet
            // 
            this.lblNoCoursesYet.AutoSize = true;
            this.lblNoCoursesYet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNoCoursesYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCoursesYet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNoCoursesYet.Location = new System.Drawing.Point(3, 6);
            this.lblNoCoursesYet.Name = "lblNoCoursesYet";
            this.lblNoCoursesYet.Size = new System.Drawing.Size(170, 25);
            this.lblNoCoursesYet.TabIndex = 27;
            this.lblNoCoursesYet.Text = "No courses yet";
            // 
            // pnlLesson
            // 
            this.pnlLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlLesson.Controls.Add(this.cboLessonTimeUnit);
            this.pnlLesson.Controls.Add(this.lblAddNewClass);
            this.pnlLesson.Controls.Add(this.nudClassDuration);
            this.pnlLesson.Controls.Add(this.btnBackToCourse);
            this.pnlLesson.Controls.Add(this.cboLessonPanelSemester);
            this.pnlLesson.Controls.Add(this.lblCourse);
            this.pnlLesson.Controls.Add(this.lblLessonPanelAcademicYear);
            this.pnlLesson.Controls.Add(this.cboLessonPanelAcademicYear);
            this.pnlLesson.Controls.Add(this.btnLessonPanelSave);
            this.pnlLesson.Controls.Add(this.lblLessonPanelCourse);
            this.pnlLesson.Controls.Add(this.lblLessonPanelSemester);
            this.pnlLesson.Controls.Add(this.lblStartLesson);
            this.pnlLesson.Controls.Add(this.cboLessonPanelType);
            this.pnlLesson.Controls.Add(this.dtpStartLesson);
            this.pnlLesson.Controls.Add(this.lblLessonPanelType);
            this.pnlLesson.Controls.Add(this.cboLessonPanelCourse);
            this.pnlLesson.Controls.Add(this.lblLocationClass);
            this.pnlLesson.Controls.Add(this.lblDuration);
            this.pnlLesson.Controls.Add(this.txtLocationClass);
            this.pnlLesson.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLesson.Location = new System.Drawing.Point(0, 0);
            this.pnlLesson.Name = "pnlLesson";
            this.pnlLesson.Size = new System.Drawing.Size(278, 736);
            this.pnlLesson.TabIndex = 3;
            // 
            // cboLessonTimeUnit
            // 
            this.cboLessonTimeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLessonTimeUnit.FormattingEnabled = true;
            this.cboLessonTimeUnit.ItemHeight = 23;
            this.cboLessonTimeUnit.Items.AddRange(new object[] {
            "minutes",
            "hours"});
            this.cboLessonTimeUnit.Location = new System.Drawing.Point(117, 459);
            this.cboLessonTimeUnit.Name = "cboLessonTimeUnit";
            this.cboLessonTimeUnit.Size = new System.Drawing.Size(121, 29);
            this.cboLessonTimeUnit.TabIndex = 5;
            this.cboLessonTimeUnit.UseSelectable = true;
            // 
            // lblAddNewClass
            // 
            this.lblAddNewClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddNewClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAddNewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewClass.ForeColor = System.Drawing.Color.White;
            this.lblAddNewClass.Location = new System.Drawing.Point(6, 106);
            this.lblAddNewClass.Name = "lblAddNewClass";
            this.lblAddNewClass.Size = new System.Drawing.Size(197, 37);
            this.lblAddNewClass.TabIndex = 27;
            this.lblAddNewClass.Text = "Add a new class";
            // 
            // nudClassDuration
            // 
            this.nudClassDuration.AutoSize = true;
            this.nudClassDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudClassDuration.Location = new System.Drawing.Point(15, 460);
            this.nudClassDuration.Maximum = new decimal(new int[] {
            555,
            0,
            0,
            0});
            this.nudClassDuration.Name = "nudClassDuration";
            this.nudClassDuration.Size = new System.Drawing.Size(65, 26);
            this.nudClassDuration.TabIndex = 4;
            // 
            // btnBackToCourse
            // 
            this.btnBackToCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToCourse.BackgroundImage")));
            this.btnBackToCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToCourse.Location = new System.Drawing.Point(8, 16);
            this.btnBackToCourse.Name = "btnBackToCourse";
            this.btnBackToCourse.Size = new System.Drawing.Size(59, 56);
            this.btnBackToCourse.TabIndex = 0;
            this.btnBackToCourse.UseVisualStyleBackColor = false;
            this.btnBackToCourse.Click += new System.EventHandler(this.goToCourseBtn_Click);
            // 
            // cboLessonPanelSemester
            // 
            this.cboLessonPanelSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLessonPanelSemester.FormattingEnabled = true;
            this.cboLessonPanelSemester.ItemHeight = 23;
            this.cboLessonPanelSemester.Location = new System.Drawing.Point(131, 241);
            this.cboLessonPanelSemester.Name = "cboLessonPanelSemester";
            this.cboLessonPanelSemester.Size = new System.Drawing.Size(121, 29);
            this.cboLessonPanelSemester.TabIndex = 1;
            this.cboLessonPanelSemester.UseSelectable = true;
            this.cboLessonPanelSemester.SelectedIndexChanged += new System.EventHandler(this.cboChooseSemester_SelectedIndexChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.White;
            this.lblCourse.Location = new System.Drawing.Point(12, 70);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(55, 16);
            this.lblCourse.TabIndex = 27;
            this.lblCourse.Text = "course";
            // 
            // lblLessonPanelAcademicYear
            // 
            this.lblLessonPanelAcademicYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLessonPanelAcademicYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLessonPanelAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonPanelAcademicYear.ForeColor = System.Drawing.Color.White;
            this.lblLessonPanelAcademicYear.Location = new System.Drawing.Point(3, 146);
            this.lblLessonPanelAcademicYear.Name = "lblLessonPanelAcademicYear";
            this.lblLessonPanelAcademicYear.Size = new System.Drawing.Size(197, 37);
            this.lblLessonPanelAcademicYear.TabIndex = 27;
            this.lblLessonPanelAcademicYear.Text = "Academic Year";
            // 
            // cboLessonPanelAcademicYear
            // 
            this.cboLessonPanelAcademicYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLessonPanelAcademicYear.FormattingEnabled = true;
            this.cboLessonPanelAcademicYear.ItemHeight = 23;
            this.cboLessonPanelAcademicYear.Location = new System.Drawing.Point(11, 186);
            this.cboLessonPanelAcademicYear.Name = "cboLessonPanelAcademicYear";
            this.cboLessonPanelAcademicYear.Size = new System.Drawing.Size(121, 29);
            this.cboLessonPanelAcademicYear.TabIndex = 0;
            this.cboLessonPanelAcademicYear.UseSelectable = true;
            this.cboLessonPanelAcademicYear.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearEditSemesterPanel_SelectedIndexChanged);
            // 
            // btnLessonPanelSave
            // 
            this.btnLessonPanelSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnLessonPanelSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLessonPanelSave.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLessonPanelSave.ForeColor = System.Drawing.Color.White;
            this.btnLessonPanelSave.Location = new System.Drawing.Point(188, 617);
            this.btnLessonPanelSave.Name = "btnLessonPanelSave";
            this.btnLessonPanelSave.Size = new System.Drawing.Size(68, 34);
            this.btnLessonPanelSave.TabIndex = 8;
            this.btnLessonPanelSave.Text = "Save";
            this.btnLessonPanelSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLessonPanelSave.UseVisualStyleBackColor = false;
            this.btnLessonPanelSave.Click += new System.EventHandler(this.btnLessonPanelSave_Click);
            // 
            // lblLessonPanelCourse
            // 
            this.lblLessonPanelCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLessonPanelCourse.AutoSize = true;
            this.lblLessonPanelCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLessonPanelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonPanelCourse.ForeColor = System.Drawing.Color.White;
            this.lblLessonPanelCourse.Location = new System.Drawing.Point(10, 293);
            this.lblLessonPanelCourse.Name = "lblLessonPanelCourse";
            this.lblLessonPanelCourse.Size = new System.Drawing.Size(87, 25);
            this.lblLessonPanelCourse.TabIndex = 27;
            this.lblLessonPanelCourse.Text = "Course";
            // 
            // lblLessonPanelSemester
            // 
            this.lblLessonPanelSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLessonPanelSemester.AutoSize = true;
            this.lblLessonPanelSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLessonPanelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonPanelSemester.ForeColor = System.Drawing.Color.White;
            this.lblLessonPanelSemester.Location = new System.Drawing.Point(6, 242);
            this.lblLessonPanelSemester.Name = "lblLessonPanelSemester";
            this.lblLessonPanelSemester.Size = new System.Drawing.Size(111, 25);
            this.lblLessonPanelSemester.TabIndex = 27;
            this.lblLessonPanelSemester.Text = "Semester";
            // 
            // lblStartLesson
            // 
            this.lblStartLesson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartLesson.AutoSize = true;
            this.lblStartLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblStartLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLesson.ForeColor = System.Drawing.Color.White;
            this.lblStartLesson.Location = new System.Drawing.Point(10, 335);
            this.lblStartLesson.Name = "lblStartLesson";
            this.lblStartLesson.Size = new System.Drawing.Size(62, 25);
            this.lblStartLesson.TabIndex = 27;
            this.lblStartLesson.Text = "Start";
            // 
            // cboLessonPanelType
            // 
            this.cboLessonPanelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLessonPanelType.FormattingEnabled = true;
            this.cboLessonPanelType.ItemHeight = 23;
            this.cboLessonPanelType.Items.AddRange(new object[] {
            Education_Module.Lesson.LessonType.Lecture,
            Education_Module.Lesson.LessonType.Exercise});
            this.cboLessonPanelType.Location = new System.Drawing.Point(117, 556);
            this.cboLessonPanelType.Name = "cboLessonPanelType";
            this.cboLessonPanelType.Size = new System.Drawing.Size(121, 29);
            this.cboLessonPanelType.TabIndex = 7;
            this.cboLessonPanelType.UseSelectable = true;
            // 
            // dtpStartLesson
            // 
            this.dtpStartLesson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStartLesson.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpStartLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartLesson.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartLesson.Location = new System.Drawing.Point(19, 375);
            this.dtpStartLesson.Name = "dtpStartLesson";
            this.dtpStartLesson.Size = new System.Drawing.Size(237, 22);
            this.dtpStartLesson.TabIndex = 3;
            // 
            // lblLessonPanelType
            // 
            this.lblLessonPanelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLessonPanelType.AutoSize = true;
            this.lblLessonPanelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLessonPanelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonPanelType.ForeColor = System.Drawing.Color.White;
            this.lblLessonPanelType.Location = new System.Drawing.Point(10, 556);
            this.lblLessonPanelType.Name = "lblLessonPanelType";
            this.lblLessonPanelType.Size = new System.Drawing.Size(64, 25);
            this.lblLessonPanelType.TabIndex = 27;
            this.lblLessonPanelType.Text = "Type";
            // 
            // cboLessonPanelCourse
            // 
            this.cboLessonPanelCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLessonPanelCourse.FormattingEnabled = true;
            this.cboLessonPanelCourse.ItemHeight = 23;
            this.cboLessonPanelCourse.Location = new System.Drawing.Point(131, 294);
            this.cboLessonPanelCourse.Name = "cboLessonPanelCourse";
            this.cboLessonPanelCourse.Size = new System.Drawing.Size(121, 29);
            this.cboLessonPanelCourse.TabIndex = 2;
            this.cboLessonPanelCourse.UseSelectable = true;
            // 
            // lblLocationClass
            // 
            this.lblLocationClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocationClass.AutoSize = true;
            this.lblLocationClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLocationClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationClass.ForeColor = System.Drawing.Color.White;
            this.lblLocationClass.Location = new System.Drawing.Point(10, 510);
            this.lblLocationClass.Name = "lblLocationClass";
            this.lblLocationClass.Size = new System.Drawing.Size(102, 25);
            this.lblLocationClass.TabIndex = 27;
            this.lblLocationClass.Text = "Location";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(10, 418);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(101, 25);
            this.lblDuration.TabIndex = 27;
            this.lblDuration.Text = "Duration";
            // 
            // txtLocationClass
            // 
            this.txtLocationClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationClass.Location = new System.Drawing.Point(117, 509);
            this.txtLocationClass.Name = "txtLocationClass";
            this.txtLocationClass.Size = new System.Drawing.Size(153, 26);
            this.txtLocationClass.TabIndex = 6;
            // 
            // lblCourses
            // 
            this.lblCourses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.White;
            this.lblCourses.Location = new System.Drawing.Point(669, 21);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(216, 65);
            this.lblCourses.TabIndex = 27;
            this.lblCourses.Text = "Courses";
            // 
            // lstCourses
            // 
            this.lstCourses.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lstCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lstCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCourses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourses.ForeColor = System.Drawing.SystemColors.Window;
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 30;
            this.lstCourses.Location = new System.Drawing.Point(329, 184);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstCourses.Size = new System.Drawing.Size(954, 532);
            this.lstCourses.TabIndex = 72;
            this.lstCourses.TabStop = false;
            this.lstCourses.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstCourses_DrawItem);
            this.lstCourses.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstCourses_MeasureItem);
            this.lstCourses.DoubleClick += new System.EventHandler(this.lstCourses_DoubleClick_1);
            // 
            // mppCalendarScreen
            // 
            this.mppCalendarScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppCalendarScreen.Controls.Add(this.dtpChooseDate);
            this.mppCalendarScreen.Controls.Add(this.btnLastWeek);
            this.mppCalendarScreen.Controls.Add(this.btnNextWeek);
            this.mppCalendarScreen.Controls.Add(this.btnCurrentWeek);
            this.mppCalendarScreen.Controls.Add(this.cclUserCalendar);
            this.mppCalendarScreen.Controls.Add(this.lblNextWeek);
            this.mppCalendarScreen.Controls.Add(this.lblSelectDate);
            this.mppCalendarScreen.Controls.Add(this.lblLastWeek);
            this.mppCalendarScreen.Controls.Add(this.btnCalendarBack);
            this.mppCalendarScreen.Controls.Add(this.btnShare);
            this.mppCalendarScreen.Controls.Add(this.btnDelete);
            this.mppCalendarScreen.Controls.Add(this.btnEdit);
            this.mppCalendarScreen.Controls.Add(this.btnCreate);
            this.mppCalendarScreen.Controls.Add(this.lblDate);
            this.mppCalendarScreen.Controls.Add(this.lblCalendar);
            this.mppCalendarScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppCalendarScreen.Location = new System.Drawing.Point(0, 0);
            this.mppCalendarScreen.Name = "mppCalendarScreen";
            this.mppCalendarScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppCalendarScreen.TabIndex = 0;
            this.mppCalendarScreen.Text = "Page4";
            this.mppCalendarScreen.VisibleChanged += new System.EventHandler(this.mppCalendarScreen_VisibleChanged);
            // 
            // dtpChooseDate
            // 
            this.dtpChooseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpChooseDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtpChooseDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtpChooseDate.Location = new System.Drawing.Point(693, 96);
            this.dtpChooseDate.Name = "dtpChooseDate";
            this.dtpChooseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpChooseDate.TabIndex = 4;
            this.dtpChooseDate.ValueChanged += new System.EventHandler(this.dtpChooseDate_ValueChanged);
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
            this.btnLastWeek.Location = new System.Drawing.Point(1134, 55);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(32, 42);
            this.btnLastWeek.TabIndex = 7;
            this.btnLastWeek.UseVisualStyleBackColor = false;
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
            this.btnNextWeek.Location = new System.Drawing.Point(1275, 55);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(32, 42);
            this.btnNextWeek.TabIndex = 6;
            this.btnNextWeek.UseVisualStyleBackColor = false;
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
            this.btnCurrentWeek.Location = new System.Drawing.Point(1156, 59);
            this.btnCurrentWeek.Name = "btnCurrentWeek";
            this.btnCurrentWeek.Size = new System.Drawing.Size(130, 32);
            this.btnCurrentWeek.TabIndex = 5;
            this.btnCurrentWeek.Text = "Current Week";
            this.btnCurrentWeek.UseVisualStyleBackColor = false;
            this.btnCurrentWeek.Click += new System.EventHandler(this.currentWeekBtn_Click);
            // 
            // cclUserCalendar
            // 
            this.cclUserCalendar.AllowDrop = true;
            this.cclUserCalendar.AllowItemEdit = false;
            this.cclUserCalendar.AllowItemResize = false;
            this.cclUserCalendar.AllowNew = false;
            this.cclUserCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cclUserCalendar.Calendar = null;
            this.cclUserCalendar.CalendarControlView = CalendarControl.CalendarControl.CalendarView.WeekView;
            this.cclUserCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange36.DayOfWeek = System.DayOfWeek.Sunday;
            calendarHighlightRange36.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange36.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange37.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange37.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange37.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange38.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange38.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange38.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange39.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange39.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange39.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange40.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange40.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange40.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange41.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange41.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange41.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange42.DayOfWeek = System.DayOfWeek.Saturday;
            calendarHighlightRange42.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange42.StartTime = System.TimeSpan.Parse("08:00:00");
            this.cclUserCalendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange36,
        calendarHighlightRange37,
        calendarHighlightRange38,
        calendarHighlightRange39,
        calendarHighlightRange40,
        calendarHighlightRange41,
        calendarHighlightRange42};
            this.cclUserCalendar.Location = new System.Drawing.Point(12, 130);
            this.cclUserCalendar.MinimumSize = new System.Drawing.Size(1175, 544);
            this.cclUserCalendar.Name = "cclUserCalendar";
            this.cclUserCalendar.Size = new System.Drawing.Size(1310, 594);
            this.cclUserCalendar.SundayDate = new System.DateTime(2017, 4, 9, 0, 0, 0, 0);
            this.cclUserCalendar.TabIndex = 8;
            this.cclUserCalendar.TabStop = false;
            this.cclUserCalendar.CalendarItemSelected += new CalendarControl.CalendarControl.ScheduleEventMethod(this.cclUserCalendar_CalendarItemSelected);
            this.cclUserCalendar.RemoveScheduleEvent += new CalendarControl.CalendarControl.ScheduleEventMethod(this.cclSserCalendar_RemoveScheduleEvent);
            this.cclUserCalendar.ScheduleEventDoubleClick += new CalendarControl.CalendarControl.ScheduleEventMethod(this.cclUserCalendar_ScheduleEventDoubleClick);
            this.cclUserCalendar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cclUserCalendar_MouseClick);
            // 
            // lblNextWeek
            // 
            this.lblNextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNextWeek.Location = new System.Drawing.Point(1239, 100);
            this.lblNextWeek.Name = "lblNextWeek";
            this.lblNextWeek.Size = new System.Drawing.Size(92, 27);
            this.lblNextWeek.TabIndex = 3;
            this.lblNextWeek.Text = "next week";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSelectDate.Location = new System.Drawing.Point(490, 97);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(197, 20);
            this.lblSelectDate.TabIndex = 3;
            this.lblSelectDate.Text = "Select a date to display";
            // 
            // lblLastWeek
            // 
            this.lblLastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblLastWeek.Location = new System.Drawing.Point(1122, 100);
            this.lblLastWeek.Name = "lblLastWeek";
            this.lblLastWeek.Size = new System.Drawing.Size(92, 27);
            this.lblLastWeek.TabIndex = 3;
            this.lblLastWeek.Text = "last week";
            // 
            // btnCalendarBack
            // 
            this.btnCalendarBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCalendarBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalendarBack.BackgroundImage")));
            this.btnCalendarBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalendarBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCalendarBack.Location = new System.Drawing.Point(12, 6);
            this.btnCalendarBack.Name = "btnCalendarBack";
            this.btnCalendarBack.Size = new System.Drawing.Size(50, 46);
            this.btnCalendarBack.TabIndex = 8;
            this.btnCalendarBack.UseVisualStyleBackColor = false;
            this.btnCalendarBack.Click += new System.EventHandler(this.MoveToMainScreen);
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnShare.Enabled = false;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShare.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShare.ForeColor = System.Drawing.Color.White;
            this.btnShare.Image = ((System.Drawing.Image)(resources.GetObject("btnShare.Image")));
            this.btnShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShare.Location = new System.Drawing.Point(316, 89);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(99, 35);
            this.btnShare.TabIndex = 3;
            this.btnShare.Text = "Share";
            this.btnShare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(203, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(108, 89);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.MoveToEditEventScreen);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(13, 89);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(81, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.MoveToAddEventScreen);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblDate.Location = new System.Drawing.Point(879, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(237, 49);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalendar
            // 
            this.lblCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.ForeColor = System.Drawing.Color.White;
            this.lblCalendar.Location = new System.Drawing.Point(553, 0);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(228, 55);
            this.lblCalendar.TabIndex = 3;
            this.lblCalendar.Text = "Calendar";
            // 
            // mppLoginScreen
            // 
            this.mppLoginScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mppLoginScreen.Controls.Add(this.lblStudentRoutine);
            this.mppLoginScreen.Controls.Add(this.lblOr);
            this.mppLoginScreen.Controls.Add(this.lblOr2);
            this.mppLoginScreen.Controls.Add(this.lblOr3);
            this.mppLoginScreen.Controls.Add(this.picCompanyIcon);
            this.mppLoginScreen.Controls.Add(backGroundbtn);
            this.mppLoginScreen.Controls.Add(this.lklForgotPassword);
            this.mppLoginScreen.Controls.Add(this.btnSignUp);
            this.mppLoginScreen.Controls.Add(this.btnSignIn);
            this.mppLoginScreen.Controls.Add(this.txtPassword);
            this.mppLoginScreen.Controls.Add(this.txtEmail);
            this.mppLoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppLoginScreen.Location = new System.Drawing.Point(0, 0);
            this.mppLoginScreen.Name = "mppLoginScreen";
            this.mppLoginScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppLoginScreen.TabIndex = 0;
            this.mppLoginScreen.TabStop = false;
            this.mppLoginScreen.Text = "Page1";
            this.mppLoginScreen.VisibleChanged += new System.EventHandler(this.mppLoginScreen_VisibleChanged);
            // 
            // lblStudentRoutine
            // 
            this.lblStudentRoutine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentRoutine.AutoSize = true;
            this.lblStudentRoutine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblStudentRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRoutine.ForeColor = System.Drawing.Color.White;
            this.lblStudentRoutine.Location = new System.Drawing.Point(475, 155);
            this.lblStudentRoutine.Name = "lblStudentRoutine";
            this.lblStudentRoutine.Size = new System.Drawing.Size(384, 55);
            this.lblStudentRoutine.TabIndex = 6;
            this.lblStudentRoutine.Text = "Student Routine";
            // 
            // lblOr
            // 
            this.lblOr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOr.AutoSize = true;
            this.lblOr.ForeColor = System.Drawing.Color.White;
            this.lblOr.Location = new System.Drawing.Point(657, 518);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(23, 13);
            this.lblOr.TabIndex = 8;
            this.lblOr.Text = "OR";
            // 
            // lblOr2
            // 
            this.lblOr2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOr2.AutoSize = true;
            this.lblOr2.ForeColor = System.Drawing.Color.White;
            this.lblOr2.Location = new System.Drawing.Point(683, 513);
            this.lblOr2.Name = "lblOr2";
            this.lblOr2.Size = new System.Drawing.Size(103, 13);
            this.lblOr2.TabIndex = 8;
            this.lblOr2.Text = "________________";
            // 
            // lblOr3
            // 
            this.lblOr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOr3.AutoSize = true;
            this.lblOr3.ForeColor = System.Drawing.Color.White;
            this.lblOr3.Location = new System.Drawing.Point(548, 513);
            this.lblOr3.Name = "lblOr3";
            this.lblOr3.Size = new System.Drawing.Size(103, 13);
            this.lblOr3.TabIndex = 8;
            this.lblOr3.Text = "________________";
            this.lblOr3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picCompanyIcon
            // 
            this.picCompanyIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picCompanyIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.picCompanyIcon.Image = global::Main_Module.Properties.Resources._1490195636_Graduate_male_241;
            this.picCompanyIcon.Location = new System.Drawing.Point(604, 56);
            this.picCompanyIcon.Name = "picCompanyIcon";
            this.picCompanyIcon.Size = new System.Drawing.Size(126, 104);
            this.picCompanyIcon.TabIndex = 7;
            this.picCompanyIcon.TabStop = false;
            // 
            // lklForgotPassword
            // 
            this.lklForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklForgotPassword.AutoSize = true;
            this.lklForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lklForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lklForgotPassword.Location = new System.Drawing.Point(613, 608);
            this.lklForgotPassword.Name = "lklForgotPassword";
            this.lklForgotPassword.Size = new System.Drawing.Size(110, 16);
            this.lklForgotPassword.TabIndex = 5;
            this.lklForgotPassword.TabStop = true;
            this.lklForgotPassword.Text = "Forgot Password";
            this.lklForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklForgotPassword_LinkClicked);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(551, 552);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(235, 38);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(551, 461);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(235, 35);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(551, 409);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(551, 361);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 29);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email";
            // 
            // mppEditEventScreen
            // 
            this.mppEditEventScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppEditEventScreen.Controls.Add(this.rtfEditEventDescription);
            this.mppEditEventScreen.Controls.Add(this.rtfEditEventLocation);
            this.mppEditEventScreen.Controls.Add(this.rtfEditEventTitle);
            this.mppEditEventScreen.Controls.Add(this.chkEditEventAllDay);
            this.mppEditEventScreen.Controls.Add(this.cboEditEventHowOften);
            this.mppEditEventScreen.Controls.Add(this.dtpEditEventEndRepeatedEvent);
            this.mppEditEventScreen.Controls.Add(this.dtpEditEventEndTime);
            this.mppEditEventScreen.Controls.Add(this.dtpEditEventStartTime);
            this.mppEditEventScreen.Controls.Add(this.btnEditEventBack);
            this.mppEditEventScreen.Controls.Add(this.btnEditEventSave);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventEnds);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventDescription);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventTo);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventLocation);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventRepeats);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventTime);
            this.mppEditEventScreen.Controls.Add(this.lblEditEventTitle);
            this.mppEditEventScreen.Controls.Add(this.lblEditEvent);
            this.mppEditEventScreen.Controls.Add(this.picBackground2);
            this.mppEditEventScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppEditEventScreen.Location = new System.Drawing.Point(0, 0);
            this.mppEditEventScreen.Name = "mppEditEventScreen";
            this.mppEditEventScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppEditEventScreen.TabIndex = 0;
            this.mppEditEventScreen.Text = "Page6";
            // 
            // rtfEditEventDescription
            // 
            this.rtfEditEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfEditEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfEditEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfEditEventDescription.Location = new System.Drawing.Point(284, 477);
            this.rtfEditEventDescription.Name = "rtfEditEventDescription";
            this.rtfEditEventDescription.Size = new System.Drawing.Size(515, 157);
            this.rtfEditEventDescription.TabIndex = 28;
            this.rtfEditEventDescription.Text = "Add a description";
            // 
            // rtfEditEventLocation
            // 
            this.rtfEditEventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfEditEventLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfEditEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfEditEventLocation.Location = new System.Drawing.Point(284, 405);
            this.rtfEditEventLocation.Name = "rtfEditEventLocation";
            this.rtfEditEventLocation.Size = new System.Drawing.Size(319, 35);
            this.rtfEditEventLocation.TabIndex = 28;
            this.rtfEditEventLocation.Text = "Enter a location";
            // 
            // rtfEditEventTitle
            // 
            this.rtfEditEventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfEditEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfEditEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfEditEventTitle.Location = new System.Drawing.Point(284, 191);
            this.rtfEditEventTitle.Name = "rtfEditEventTitle";
            this.rtfEditEventTitle.Size = new System.Drawing.Size(515, 29);
            this.rtfEditEventTitle.TabIndex = 28;
            this.rtfEditEventTitle.Text = "Untitled schedule event";
            // 
            // chkEditEventAllDay
            // 
            this.chkEditEventAllDay.AutoSize = true;
            this.chkEditEventAllDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(81)))));
            this.chkEditEventAllDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditEventAllDay.ForeColor = System.Drawing.Color.White;
            this.chkEditEventAllDay.Location = new System.Drawing.Point(852, 272);
            this.chkEditEventAllDay.Name = "chkEditEventAllDay";
            this.chkEditEventAllDay.Size = new System.Drawing.Size(84, 24);
            this.chkEditEventAllDay.TabIndex = 3;
            this.chkEditEventAllDay.Text = "All Day";
            this.chkEditEventAllDay.UseVisualStyleBackColor = false;
            this.chkEditEventAllDay.CheckedChanged += new System.EventHandler(this.chkAllDay_CheckedChanged);
            // 
            // cboEditEventHowOften
            // 
            this.cboEditEventHowOften.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboEditEventHowOften.FormattingEnabled = true;
            this.cboEditEventHowOften.ItemHeight = 23;
            this.cboEditEventHowOften.Items.AddRange(new object[] {
            Calendar_Module.ScheduleEvent.Period.None,
            Calendar_Module.ScheduleEvent.Period.Daily,
            Calendar_Module.ScheduleEvent.Period.Weekly,
            Calendar_Module.ScheduleEvent.Period.Monthly});
            this.cboEditEventHowOften.Location = new System.Drawing.Point(284, 338);
            this.cboEditEventHowOften.Name = "cboEditEventHowOften";
            this.cboEditEventHowOften.Size = new System.Drawing.Size(121, 29);
            this.cboEditEventHowOften.TabIndex = 4;
            this.cboEditEventHowOften.UseSelectable = true;
            this.cboEditEventHowOften.SelectedIndexChanged += new System.EventHandler(this.cboEventHowOften_SelectedIndexChanged);
            // 
            // dtpEditEventEndRepeatedEvent
            // 
            this.dtpEditEventEndRepeatedEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEditEventEndRepeatedEvent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditEventEndRepeatedEvent.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpEditEventEndRepeatedEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEditEventEndRepeatedEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditEventEndRepeatedEvent.Location = new System.Drawing.Point(505, 345);
            this.dtpEditEventEndRepeatedEvent.Name = "dtpEditEventEndRepeatedEvent";
            this.dtpEditEventEndRepeatedEvent.Size = new System.Drawing.Size(193, 22);
            this.dtpEditEventEndRepeatedEvent.TabIndex = 5;
            // 
            // dtpEditEventEndTime
            // 
            this.dtpEditEventEndTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditEventEndTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpEditEventEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEditEventEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditEventEndTime.Location = new System.Drawing.Point(593, 274);
            this.dtpEditEventEndTime.Name = "dtpEditEventEndTime";
            this.dtpEditEventEndTime.Size = new System.Drawing.Size(240, 22);
            this.dtpEditEventEndTime.TabIndex = 2;
            // 
            // dtpEditEventStartTime
            // 
            this.dtpEditEventStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEditEventStartTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpEditEventStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditEventStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditEventStartTime.Location = new System.Drawing.Point(284, 273);
            this.dtpEditEventStartTime.Name = "dtpEditEventStartTime";
            this.dtpEditEventStartTime.Size = new System.Drawing.Size(237, 22);
            this.dtpEditEventStartTime.TabIndex = 1;
            this.dtpEditEventStartTime.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btnEditEventBack
            // 
            this.btnEditEventBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEditEventBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditEventBack.BackgroundImage")));
            this.btnEditEventBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditEventBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEventBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEditEventBack.Location = new System.Drawing.Point(68, 23);
            this.btnEditEventBack.Name = "btnEditEventBack";
            this.btnEditEventBack.Size = new System.Drawing.Size(50, 46);
            this.btnEditEventBack.TabIndex = 9;
            this.btnEditEventBack.UseVisualStyleBackColor = false;
            this.btnEditEventBack.Click += new System.EventHandler(this.MoveToCalendarScreen);
            // 
            // btnEditEventSave
            // 
            this.btnEditEventSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEventSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnEditEventSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditEventSave.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEditEventSave.ForeColor = System.Drawing.Color.White;
            this.btnEditEventSave.Location = new System.Drawing.Point(1014, 616);
            this.btnEditEventSave.Name = "btnEditEventSave";
            this.btnEditEventSave.Size = new System.Drawing.Size(97, 38);
            this.btnEditEventSave.TabIndex = 8;
            this.btnEditEventSave.Text = "Save";
            this.btnEditEventSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditEventSave.UseVisualStyleBackColor = false;
            this.btnEditEventSave.Click += new System.EventHandler(this.btnEditEventSave_Click);
            // 
            // lblEditEventEnds
            // 
            this.lblEditEventEnds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventEnds.AutoSize = true;
            this.lblEditEventEnds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventEnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventEnds.ForeColor = System.Drawing.Color.White;
            this.lblEditEventEnds.Location = new System.Drawing.Point(423, 338);
            this.lblEditEventEnds.Name = "lblEditEventEnds";
            this.lblEditEventEnds.Size = new System.Drawing.Size(72, 29);
            this.lblEditEventEnds.TabIndex = 18;
            this.lblEditEventEnds.Text = "Ends";
            // 
            // lblEditEventDescription
            // 
            this.lblEditEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventDescription.AutoSize = true;
            this.lblEditEventDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventDescription.ForeColor = System.Drawing.Color.White;
            this.lblEditEventDescription.Location = new System.Drawing.Point(122, 476);
            this.lblEditEventDescription.Name = "lblEditEventDescription";
            this.lblEditEventDescription.Size = new System.Drawing.Size(153, 29);
            this.lblEditEventDescription.TabIndex = 19;
            this.lblEditEventDescription.Text = "Descritption";
            // 
            // lblEditEventTo
            // 
            this.lblEditEventTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventTo.AutoSize = true;
            this.lblEditEventTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventTo.ForeColor = System.Drawing.Color.White;
            this.lblEditEventTo.Location = new System.Drawing.Point(538, 265);
            this.lblEditEventTo.Name = "lblEditEventTo";
            this.lblEditEventTo.Size = new System.Drawing.Size(35, 29);
            this.lblEditEventTo.TabIndex = 20;
            this.lblEditEventTo.Text = "to";
            // 
            // lblEditEventLocation
            // 
            this.lblEditEventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventLocation.AutoSize = true;
            this.lblEditEventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventLocation.ForeColor = System.Drawing.Color.White;
            this.lblEditEventLocation.Location = new System.Drawing.Point(163, 404);
            this.lblEditEventLocation.Name = "lblEditEventLocation";
            this.lblEditEventLocation.Size = new System.Drawing.Size(112, 29);
            this.lblEditEventLocation.TabIndex = 21;
            this.lblEditEventLocation.Text = "Location";
            // 
            // lblEditEventRepeats
            // 
            this.lblEditEventRepeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventRepeats.AutoSize = true;
            this.lblEditEventRepeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventRepeats.ForeColor = System.Drawing.Color.White;
            this.lblEditEventRepeats.Location = new System.Drawing.Point(165, 329);
            this.lblEditEventRepeats.Name = "lblEditEventRepeats";
            this.lblEditEventRepeats.Size = new System.Drawing.Size(110, 29);
            this.lblEditEventRepeats.TabIndex = 16;
            this.lblEditEventRepeats.Text = "Repeats";
            // 
            // lblEditEventTime
            // 
            this.lblEditEventTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventTime.AutoSize = true;
            this.lblEditEventTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventTime.ForeColor = System.Drawing.Color.White;
            this.lblEditEventTime.Location = new System.Drawing.Point(202, 265);
            this.lblEditEventTime.Name = "lblEditEventTime";
            this.lblEditEventTime.Size = new System.Drawing.Size(73, 29);
            this.lblEditEventTime.TabIndex = 15;
            this.lblEditEventTime.Text = "Time";
            // 
            // lblEditEventTitle
            // 
            this.lblEditEventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditEventTitle.AutoSize = true;
            this.lblEditEventTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEditEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditEventTitle.Location = new System.Drawing.Point(209, 191);
            this.lblEditEventTitle.Name = "lblEditEventTitle";
            this.lblEditEventTitle.Size = new System.Drawing.Size(66, 29);
            this.lblEditEventTitle.TabIndex = 14;
            this.lblEditEventTitle.Text = "Title";
            // 
            // lblEditEvent
            // 
            this.lblEditEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditEvent.AutoSize = true;
            this.lblEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEvent.ForeColor = System.Drawing.Color.White;
            this.lblEditEvent.Location = new System.Drawing.Point(436, 32);
            this.lblEditEvent.Name = "lblEditEvent";
            this.lblEditEvent.Size = new System.Drawing.Size(462, 55);
            this.lblEditEvent.TabIndex = 17;
            this.lblEditEvent.Text = "Edit schedule event";
            // 
            // picBackground2
            // 
            this.picBackground2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackground2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackground2.BackgroundImage")));
            this.picBackground2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground2.Location = new System.Drawing.Point(70, 92);
            this.picBackground2.Name = "picBackground2";
            this.picBackground2.Size = new System.Drawing.Size(1195, 632);
            this.picBackground2.TabIndex = 27;
            this.picBackground2.TabStop = false;
            // 
            // mppAddEventScreen
            // 
            this.mppAddEventScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppAddEventScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mppAddEventScreen.Controls.Add(this.rtfAddEventTitle);
            this.mppAddEventScreen.Controls.Add(this.txtAddEventDescription);
            this.mppAddEventScreen.Controls.Add(this.txtAddEventLocation);
            this.mppAddEventScreen.Controls.Add(this.chkAddEventAllDay);
            this.mppAddEventScreen.Controls.Add(this.cboAddeventHowOften);
            this.mppAddEventScreen.Controls.Add(this.dtpAddEventEndRepeated);
            this.mppAddEventScreen.Controls.Add(this.dtpAddEventEndTime);
            this.mppAddEventScreen.Controls.Add(this.dtpAddEventStartTime);
            this.mppAddEventScreen.Controls.Add(this.btnAddEventBack);
            this.mppAddEventScreen.Controls.Add(this.btnAddEventSave);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventEnds);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventDescription);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventTo);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventLocation);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventRepeats);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventTime);
            this.mppAddEventScreen.Controls.Add(this.lblAddEventTitle);
            this.mppAddEventScreen.Controls.Add(this.lblAddScheduleEvent);
            this.mppAddEventScreen.Controls.Add(this.picBackground1);
            this.mppAddEventScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppAddEventScreen.Location = new System.Drawing.Point(0, 0);
            this.mppAddEventScreen.Name = "mppAddEventScreen";
            this.mppAddEventScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppAddEventScreen.TabIndex = 4;
            this.mppAddEventScreen.Text = "Page5";
            this.mppAddEventScreen.VisibleChanged += new System.EventHandler(this.mppAddEventScreen_VisibleChanged);
            // 
            // rtfAddEventTitle
            // 
            this.rtfAddEventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfAddEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfAddEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfAddEventTitle.Location = new System.Drawing.Point(284, 181);
            this.rtfAddEventTitle.Name = "rtfAddEventTitle";
            this.rtfAddEventTitle.Size = new System.Drawing.Size(515, 35);
            this.rtfAddEventTitle.TabIndex = 29;
            this.rtfAddEventTitle.Text = "Untitled schedule event";
            this.rtfAddEventTitle.Click += new System.EventHandler(this.txtDeleteText_Click);
            // 
            // txtAddEventDescription
            // 
            this.txtAddEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddEventDescription.Location = new System.Drawing.Point(284, 467);
            this.txtAddEventDescription.Name = "txtAddEventDescription";
            this.txtAddEventDescription.Size = new System.Drawing.Size(515, 157);
            this.txtAddEventDescription.TabIndex = 29;
            this.txtAddEventDescription.Text = "Add a description";
            this.txtAddEventDescription.Click += new System.EventHandler(this.txtDeleteText_Click);
            // 
            // txtAddEventLocation
            // 
            this.txtAddEventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddEventLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddEventLocation.Location = new System.Drawing.Point(284, 395);
            this.txtAddEventLocation.Name = "txtAddEventLocation";
            this.txtAddEventLocation.Size = new System.Drawing.Size(319, 35);
            this.txtAddEventLocation.TabIndex = 29;
            this.txtAddEventLocation.Text = "Enter a location";
            this.txtAddEventLocation.Click += new System.EventHandler(this.txtDeleteText_Click);
            // 
            // chkAddEventAllDay
            // 
            this.chkAddEventAllDay.AutoSize = true;
            this.chkAddEventAllDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(93)))), ((int)(((byte)(81)))));
            this.chkAddEventAllDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddEventAllDay.ForeColor = System.Drawing.Color.White;
            this.chkAddEventAllDay.Location = new System.Drawing.Point(859, 262);
            this.chkAddEventAllDay.Name = "chkAddEventAllDay";
            this.chkAddEventAllDay.Size = new System.Drawing.Size(84, 24);
            this.chkAddEventAllDay.TabIndex = 11;
            this.chkAddEventAllDay.Text = "All Day";
            this.chkAddEventAllDay.UseVisualStyleBackColor = false;
            this.chkAddEventAllDay.CheckedChanged += new System.EventHandler(this.chkAllDay_CheckedChanged);
            // 
            // cboAddeventHowOften
            // 
            this.cboAddeventHowOften.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAddeventHowOften.FormattingEnabled = true;
            this.cboAddeventHowOften.ItemHeight = 23;
            this.cboAddeventHowOften.Items.AddRange(new object[] {
            Calendar_Module.ScheduleEvent.Period.None,
            Calendar_Module.ScheduleEvent.Period.Daily,
            Calendar_Module.ScheduleEvent.Period.Weekly,
            Calendar_Module.ScheduleEvent.Period.Monthly});
            this.cboAddeventHowOften.Location = new System.Drawing.Point(284, 328);
            this.cboAddeventHowOften.Name = "cboAddeventHowOften";
            this.cboAddeventHowOften.Size = new System.Drawing.Size(121, 29);
            this.cboAddeventHowOften.TabIndex = 4;
            this.cboAddeventHowOften.UseSelectable = true;
            this.cboAddeventHowOften.SelectedIndexChanged += new System.EventHandler(this.cboEventHowOften_SelectedIndexChanged);
            // 
            // dtpAddEventEndRepeated
            // 
            this.dtpAddEventEndRepeated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAddEventEndRepeated.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddEventEndRepeated.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpAddEventEndRepeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpAddEventEndRepeated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddEventEndRepeated.Location = new System.Drawing.Point(505, 335);
            this.dtpAddEventEndRepeated.Name = "dtpAddEventEndRepeated";
            this.dtpAddEventEndRepeated.Size = new System.Drawing.Size(194, 22);
            this.dtpAddEventEndRepeated.TabIndex = 5;
            // 
            // dtpAddEventEndTime
            // 
            this.dtpAddEventEndTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddEventEndTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpAddEventEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpAddEventEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddEventEndTime.Location = new System.Drawing.Point(593, 264);
            this.dtpAddEventEndTime.Name = "dtpAddEventEndTime";
            this.dtpAddEventEndTime.Size = new System.Drawing.Size(240, 22);
            this.dtpAddEventEndTime.TabIndex = 3;
            // 
            // dtpAddEventStartTime
            // 
            this.dtpAddEventStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAddEventStartTime.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpAddEventStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddEventStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddEventStartTime.Location = new System.Drawing.Point(284, 263);
            this.dtpAddEventStartTime.Name = "dtpAddEventStartTime";
            this.dtpAddEventStartTime.Size = new System.Drawing.Size(237, 22);
            this.dtpAddEventStartTime.TabIndex = 2;
            this.dtpAddEventStartTime.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btnAddEventBack
            // 
            this.btnAddEventBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAddEventBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddEventBack.BackgroundImage")));
            this.btnAddEventBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddEventBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEventBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAddEventBack.Location = new System.Drawing.Point(33, 13);
            this.btnAddEventBack.Name = "btnAddEventBack";
            this.btnAddEventBack.Size = new System.Drawing.Size(50, 46);
            this.btnAddEventBack.TabIndex = 9;
            this.btnAddEventBack.UseVisualStyleBackColor = false;
            this.btnAddEventBack.Click += new System.EventHandler(this.MoveToCalendarScreen);
            // 
            // btnAddEventSave
            // 
            this.btnAddEventSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEventSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnAddEventSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEventSave.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddEventSave.ForeColor = System.Drawing.Color.White;
            this.btnAddEventSave.Location = new System.Drawing.Point(1014, 616);
            this.btnAddEventSave.Name = "btnAddEventSave";
            this.btnAddEventSave.Size = new System.Drawing.Size(97, 38);
            this.btnAddEventSave.TabIndex = 8;
            this.btnAddEventSave.Text = "Save";
            this.btnAddEventSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddEventSave.UseVisualStyleBackColor = false;
            this.btnAddEventSave.Click += new System.EventHandler(this.btnAddEventSave_Click);
            // 
            // lblAddEventEnds
            // 
            this.lblAddEventEnds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventEnds.AutoSize = true;
            this.lblAddEventEnds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventEnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventEnds.ForeColor = System.Drawing.Color.White;
            this.lblAddEventEnds.Location = new System.Drawing.Point(423, 328);
            this.lblAddEventEnds.Name = "lblAddEventEnds";
            this.lblAddEventEnds.Size = new System.Drawing.Size(72, 29);
            this.lblAddEventEnds.TabIndex = 4;
            this.lblAddEventEnds.Text = "Ends";
            // 
            // lblAddEventDescription
            // 
            this.lblAddEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventDescription.AutoSize = true;
            this.lblAddEventDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventDescription.ForeColor = System.Drawing.Color.White;
            this.lblAddEventDescription.Location = new System.Drawing.Point(122, 466);
            this.lblAddEventDescription.Name = "lblAddEventDescription";
            this.lblAddEventDescription.Size = new System.Drawing.Size(153, 29);
            this.lblAddEventDescription.TabIndex = 4;
            this.lblAddEventDescription.Text = "Descritption";
            // 
            // lblAddEventTo
            // 
            this.lblAddEventTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventTo.AutoSize = true;
            this.lblAddEventTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventTo.ForeColor = System.Drawing.Color.White;
            this.lblAddEventTo.Location = new System.Drawing.Point(538, 255);
            this.lblAddEventTo.Name = "lblAddEventTo";
            this.lblAddEventTo.Size = new System.Drawing.Size(35, 29);
            this.lblAddEventTo.TabIndex = 4;
            this.lblAddEventTo.Text = "to";
            // 
            // lblAddEventLocation
            // 
            this.lblAddEventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventLocation.AutoSize = true;
            this.lblAddEventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventLocation.ForeColor = System.Drawing.Color.White;
            this.lblAddEventLocation.Location = new System.Drawing.Point(163, 394);
            this.lblAddEventLocation.Name = "lblAddEventLocation";
            this.lblAddEventLocation.Size = new System.Drawing.Size(112, 29);
            this.lblAddEventLocation.TabIndex = 4;
            this.lblAddEventLocation.Text = "Location";
            // 
            // lblAddEventRepeats
            // 
            this.lblAddEventRepeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventRepeats.AutoSize = true;
            this.lblAddEventRepeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventRepeats.ForeColor = System.Drawing.Color.White;
            this.lblAddEventRepeats.Location = new System.Drawing.Point(174, 322);
            this.lblAddEventRepeats.Name = "lblAddEventRepeats";
            this.lblAddEventRepeats.Size = new System.Drawing.Size(110, 29);
            this.lblAddEventRepeats.TabIndex = 4;
            this.lblAddEventRepeats.Text = "Repeats";
            // 
            // lblAddEventTime
            // 
            this.lblAddEventTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventTime.AutoSize = true;
            this.lblAddEventTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventTime.ForeColor = System.Drawing.Color.White;
            this.lblAddEventTime.Location = new System.Drawing.Point(202, 255);
            this.lblAddEventTime.Name = "lblAddEventTime";
            this.lblAddEventTime.Size = new System.Drawing.Size(73, 29);
            this.lblAddEventTime.TabIndex = 4;
            this.lblAddEventTime.Text = "Time";
            // 
            // lblAddEventTitle
            // 
            this.lblAddEventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEventTitle.AutoSize = true;
            this.lblAddEventTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblAddEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventTitle.ForeColor = System.Drawing.Color.White;
            this.lblAddEventTitle.Location = new System.Drawing.Point(202, 181);
            this.lblAddEventTitle.Name = "lblAddEventTitle";
            this.lblAddEventTitle.Size = new System.Drawing.Size(66, 29);
            this.lblAddEventTitle.TabIndex = 4;
            this.lblAddEventTitle.Text = "Title";
            // 
            // lblAddScheduleEvent
            // 
            this.lblAddScheduleEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddScheduleEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddScheduleEvent.ForeColor = System.Drawing.Color.White;
            this.lblAddScheduleEvent.Location = new System.Drawing.Point(414, 21);
            this.lblAddScheduleEvent.Name = "lblAddScheduleEvent";
            this.lblAddScheduleEvent.Size = new System.Drawing.Size(507, 65);
            this.lblAddScheduleEvent.TabIndex = 4;
            this.lblAddScheduleEvent.Text = "Add a schedule event";
            // 
            // picBackground1
            // 
            this.picBackground1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackground1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackground1.BackgroundImage")));
            this.picBackground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground1.Location = new System.Drawing.Point(70, 83);
            this.picBackground1.Name = "picBackground1";
            this.picBackground1.Size = new System.Drawing.Size(1195, 632);
            this.picBackground1.TabIndex = 10;
            this.picBackground1.TabStop = false;
            // 
            // mppExamsScreen
            // 
            this.mppExamsScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppExamsScreen.Controls.Add(this.lstExams);
            this.mppExamsScreen.Controls.Add(this.pnlNoExams);
            this.mppExamsScreen.Controls.Add(this.pnlSelectExam);
            this.mppExamsScreen.Controls.Add(this.pnlExams);
            this.mppExamsScreen.Controls.Add(this.lblExams);
            this.mppExamsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppExamsScreen.Location = new System.Drawing.Point(0, 0);
            this.mppExamsScreen.Name = "mppExamsScreen";
            this.mppExamsScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppExamsScreen.TabIndex = 8;
            this.mppExamsScreen.Text = "Page9";
            this.mppExamsScreen.VisibleChanged += new System.EventHandler(this.mppExamsScreen_VisibleChanged);
            // 
            // lstExams
            // 
            this.lstExams.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lstExams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lstExams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstExams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExams.ForeColor = System.Drawing.SystemColors.Window;
            this.lstExams.FormattingEnabled = true;
            this.lstExams.ItemHeight = 30;
            this.lstExams.Location = new System.Drawing.Point(332, 177);
            this.lstExams.Name = "lstExams";
            this.lstExams.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstExams.Size = new System.Drawing.Size(954, 532);
            this.lstExams.TabIndex = 77;
            this.lstExams.TabStop = false;
            this.lstExams.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstExams_DrawItem);
            this.lstExams.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstExams_MeasureItem);
            this.lstExams.DoubleClick += new System.EventHandler(this.lstExams_DoubleClick);
            // 
            // pnlNoExams
            // 
            this.pnlNoExams.Controls.Add(this.lblNoExams);
            this.pnlNoExams.Location = new System.Drawing.Point(332, 79);
            this.pnlNoExams.Name = "pnlNoExams";
            this.pnlNoExams.Size = new System.Drawing.Size(422, 92);
            this.pnlNoExams.TabIndex = 79;
            // 
            // lblNoExams
            // 
            this.lblNoExams.AutoSize = true;
            this.lblNoExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNoExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNoExams.Location = new System.Drawing.Point(3, 6);
            this.lblNoExams.Name = "lblNoExams";
            this.lblNoExams.Size = new System.Drawing.Size(155, 25);
            this.lblNoExams.TabIndex = 27;
            this.lblNoExams.Text = "No exams yet";
            // 
            // pnlSelectExam
            // 
            this.pnlSelectExam.Controls.Add(this.lblSelectExam);
            this.pnlSelectExam.Controls.Add(this.cboCourseDisplayExamPanel);
            this.pnlSelectExam.Controls.Add(this.cboSemesterDisplayExamPanel);
            this.pnlSelectExam.Controls.Add(this.cboAcademicYearDisplayExamPanel);
            this.pnlSelectExam.Location = new System.Drawing.Point(332, 79);
            this.pnlSelectExam.Name = "pnlSelectExam";
            this.pnlSelectExam.Size = new System.Drawing.Size(422, 92);
            this.pnlSelectExam.TabIndex = 78;
            // 
            // lblSelectExam
            // 
            this.lblSelectExam.AutoSize = true;
            this.lblSelectExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblSelectExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSelectExam.Location = new System.Drawing.Point(3, 6);
            this.lblSelectExam.Name = "lblSelectExam";
            this.lblSelectExam.Size = new System.Drawing.Size(250, 25);
            this.lblSelectExam.TabIndex = 27;
            this.lblSelectExam.Text = "Select exam to display";
            // 
            // cboCourseDisplayExamPanel
            // 
            this.cboCourseDisplayExamPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCourseDisplayExamPanel.FormattingEnabled = true;
            this.cboCourseDisplayExamPanel.ItemHeight = 23;
            this.cboCourseDisplayExamPanel.Location = new System.Drawing.Point(282, 48);
            this.cboCourseDisplayExamPanel.Name = "cboCourseDisplayExamPanel";
            this.cboCourseDisplayExamPanel.Size = new System.Drawing.Size(137, 29);
            this.cboCourseDisplayExamPanel.TabIndex = 28;
            this.cboCourseDisplayExamPanel.TabStop = false;
            this.cboCourseDisplayExamPanel.UseSelectable = true;
            this.cboCourseDisplayExamPanel.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearDisplayExamPanel_SelectedIndexChanged);
            // 
            // cboSemesterDisplayExamPanel
            // 
            this.cboSemesterDisplayExamPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSemesterDisplayExamPanel.FormattingEnabled = true;
            this.cboSemesterDisplayExamPanel.ItemHeight = 23;
            this.cboSemesterDisplayExamPanel.Location = new System.Drawing.Point(145, 48);
            this.cboSemesterDisplayExamPanel.Name = "cboSemesterDisplayExamPanel";
            this.cboSemesterDisplayExamPanel.Size = new System.Drawing.Size(121, 29);
            this.cboSemesterDisplayExamPanel.TabIndex = 28;
            this.cboSemesterDisplayExamPanel.TabStop = false;
            this.cboSemesterDisplayExamPanel.UseSelectable = true;
            this.cboSemesterDisplayExamPanel.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearDisplayExamPanel_SelectedIndexChanged);
            // 
            // cboAcademicYearDisplayExamPanel
            // 
            this.cboAcademicYearDisplayExamPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearDisplayExamPanel.FormattingEnabled = true;
            this.cboAcademicYearDisplayExamPanel.ItemHeight = 23;
            this.cboAcademicYearDisplayExamPanel.Location = new System.Drawing.Point(8, 48);
            this.cboAcademicYearDisplayExamPanel.Name = "cboAcademicYearDisplayExamPanel";
            this.cboAcademicYearDisplayExamPanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearDisplayExamPanel.TabIndex = 28;
            this.cboAcademicYearDisplayExamPanel.TabStop = false;
            this.cboAcademicYearDisplayExamPanel.UseSelectable = true;
            this.cboAcademicYearDisplayExamPanel.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearDisplayExamPanel_SelectedIndexChanged);
            // 
            // pnlExams
            // 
            this.pnlExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlExams.Controls.Add(this.btnDeleteSubject);
            this.pnlExams.Controls.Add(this.btnDeleteExam);
            this.pnlExams.Controls.Add(this.btnBackToAddingExam);
            this.pnlExams.Controls.Add(this.btnAddSubject);
            this.pnlExams.Controls.Add(this.txtExamLocation);
            this.pnlExams.Controls.Add(this.txtExamTitle);
            this.pnlExams.Controls.Add(this.txtSubjects);
            this.pnlExams.Controls.Add(this.lstSubjects);
            this.pnlExams.Controls.Add(this.cboExamTimeUnit);
            this.pnlExams.Controls.Add(this.cboChooseCourseExamPage);
            this.pnlExams.Controls.Add(this.nudExamDuration);
            this.pnlExams.Controls.Add(this.btnSaveExam);
            this.pnlExams.Controls.Add(this.dtpExam);
            this.pnlExams.Controls.Add(this.lblSubjects);
            this.pnlExams.Controls.Add(this.lblNewExam);
            this.pnlExams.Controls.Add(this.btnExamBack);
            this.pnlExams.Controls.Add(this.lblDuartion);
            this.pnlExams.Controls.Add(this.lblStartExam);
            this.pnlExams.Controls.Add(this.lblExamLocation);
            this.pnlExams.Controls.Add(this.lblExamTitle);
            this.pnlExams.Controls.Add(this.lblExamsScreenCourse);
            this.pnlExams.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExams.Location = new System.Drawing.Point(0, 0);
            this.pnlExams.Name = "pnlExams";
            this.pnlExams.Size = new System.Drawing.Size(278, 736);
            this.pnlExams.TabIndex = 36;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSubject.BackgroundImage")));
            this.btnDeleteSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSubject.Location = new System.Drawing.Point(232, 455);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(30, 40);
            this.btnDeleteSubject.TabIndex = 8;
            this.btnDeleteSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExam.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExam.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteExam.Image")));
            this.btnDeleteExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteExam.Location = new System.Drawing.Point(17, 605);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(144, 40);
            this.btnDeleteExam.TabIndex = 80;
            this.btnDeleteExam.Text = "Delete exam";
            this.btnDeleteExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            this.btnDeleteExam.Visible = false;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnBackToAddingExam
            // 
            this.btnBackToAddingExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAddingExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToAddingExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAddingExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToAddingExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAddingExam.ForeColor = System.Drawing.Color.White;
            this.btnBackToAddingExam.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToAddingExam.Image")));
            this.btnBackToAddingExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToAddingExam.Location = new System.Drawing.Point(13, 54);
            this.btnBackToAddingExam.Name = "btnBackToAddingExam";
            this.btnBackToAddingExam.Size = new System.Drawing.Size(236, 40);
            this.btnBackToAddingExam.TabIndex = 81;
            this.btnBackToAddingExam.Text = "Back to adding mode";
            this.btnBackToAddingExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToAddingExam.UseVisualStyleBackColor = false;
            this.btnBackToAddingExam.Visible = false;
            this.btnBackToAddingExam.Click += new System.EventHandler(this.btnBackToAddingExam_Click_1);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.BackgroundImage")));
            this.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnAddSubject.Location = new System.Drawing.Point(191, 460);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(35, 30);
            this.btnAddSubject.TabIndex = 7;
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtExamLocation
            // 
            this.txtExamLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamLocation.Location = new System.Drawing.Point(110, 181);
            this.txtExamLocation.Name = "txtExamLocation";
            this.txtExamLocation.Size = new System.Drawing.Size(139, 26);
            this.txtExamLocation.TabIndex = 1;
            // 
            // txtExamTitle
            // 
            this.txtExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamTitle.Location = new System.Drawing.Point(110, 141);
            this.txtExamTitle.Name = "txtExamTitle";
            this.txtExamTitle.Size = new System.Drawing.Size(139, 26);
            this.txtExamTitle.TabIndex = 0;
            // 
            // txtSubjects
            // 
            this.txtSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjects.Location = new System.Drawing.Point(17, 462);
            this.txtSubjects.Name = "txtSubjects";
            this.txtSubjects.Size = new System.Drawing.Size(168, 26);
            this.txtSubjects.TabIndex = 6;
            this.txtSubjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubjects_KeyDown);
            // 
            // lstSubjects
            // 
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.Location = new System.Drawing.Point(17, 497);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(168, 95);
            this.lstSubjects.TabIndex = 8;
            this.lstSubjects.TabStop = false;
            this.lstSubjects.DoubleClick += new System.EventHandler(this.lstSubjects_DoubleClick);
            // 
            // cboExamTimeUnit
            // 
            this.cboExamTimeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboExamTimeUnit.FormattingEnabled = true;
            this.cboExamTimeUnit.ItemHeight = 23;
            this.cboExamTimeUnit.Items.AddRange(new object[] {
            "minutes",
            "hours"});
            this.cboExamTimeUnit.Location = new System.Drawing.Point(105, 374);
            this.cboExamTimeUnit.Name = "cboExamTimeUnit";
            this.cboExamTimeUnit.Size = new System.Drawing.Size(121, 29);
            this.cboExamTimeUnit.TabIndex = 5;
            this.cboExamTimeUnit.UseSelectable = true;
            // 
            // cboChooseCourseExamPage
            // 
            this.cboChooseCourseExamPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboChooseCourseExamPage.FormattingEnabled = true;
            this.cboChooseCourseExamPage.ItemHeight = 23;
            this.cboChooseCourseExamPage.Location = new System.Drawing.Point(92, 223);
            this.cboChooseCourseExamPage.Name = "cboChooseCourseExamPage";
            this.cboChooseCourseExamPage.Size = new System.Drawing.Size(157, 29);
            this.cboChooseCourseExamPage.TabIndex = 2;
            this.cboChooseCourseExamPage.UseSelectable = true;
            // 
            // nudExamDuration
            // 
            this.nudExamDuration.AutoSize = true;
            this.nudExamDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExamDuration.Location = new System.Drawing.Point(12, 375);
            this.nudExamDuration.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudExamDuration.Name = "nudExamDuration";
            this.nudExamDuration.Size = new System.Drawing.Size(65, 26);
            this.nudExamDuration.TabIndex = 4;
            // 
            // btnSaveExam
            // 
            this.btnSaveExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveExam.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveExam.ForeColor = System.Drawing.Color.White;
            this.btnSaveExam.Location = new System.Drawing.Point(205, 646);
            this.btnSaveExam.Name = "btnSaveExam";
            this.btnSaveExam.Size = new System.Drawing.Size(70, 30);
            this.btnSaveExam.TabIndex = 9;
            this.btnSaveExam.Text = "Save";
            this.btnSaveExam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveExam.UseVisualStyleBackColor = false;
            this.btnSaveExam.Click += new System.EventHandler(this.btnSaveExam_Click);
            // 
            // dtpExam
            // 
            this.dtpExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpExam.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExam.Location = new System.Drawing.Point(12, 294);
            this.dtpExam.Name = "dtpExam";
            this.dtpExam.Size = new System.Drawing.Size(237, 22);
            this.dtpExam.TabIndex = 3;
            // 
            // lblSubjects
            // 
            this.lblSubjects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjects.ForeColor = System.Drawing.Color.White;
            this.lblSubjects.Location = new System.Drawing.Point(12, 420);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(110, 37);
            this.lblSubjects.TabIndex = 27;
            this.lblSubjects.Text = "Subjects";
            // 
            // lblNewExam
            // 
            this.lblNewExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewExam.AutoSize = true;
            this.lblNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNewExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewExam.ForeColor = System.Drawing.Color.White;
            this.lblNewExam.Location = new System.Drawing.Point(8, 98);
            this.lblNewExam.Name = "lblNewExam";
            this.lblNewExam.Size = new System.Drawing.Size(185, 25);
            this.lblNewExam.TabIndex = 27;
            this.lblNewExam.Text = "Add a new exam";
            // 
            // btnExamBack
            // 
            this.btnExamBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnExamBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExamBack.BackgroundImage")));
            this.btnExamBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExamBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnExamBack.Location = new System.Drawing.Point(3, 5);
            this.btnExamBack.Name = "btnExamBack";
            this.btnExamBack.Size = new System.Drawing.Size(59, 43);
            this.btnExamBack.TabIndex = 10;
            this.btnExamBack.UseVisualStyleBackColor = false;
            this.btnExamBack.Click += new System.EventHandler(this.MoveToMainScreen);
            // 
            // lblDuartion
            // 
            this.lblDuartion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDuartion.AutoSize = true;
            this.lblDuartion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblDuartion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuartion.ForeColor = System.Drawing.Color.White;
            this.lblDuartion.Location = new System.Drawing.Point(5, 334);
            this.lblDuartion.Name = "lblDuartion";
            this.lblDuartion.Size = new System.Drawing.Size(101, 25);
            this.lblDuartion.TabIndex = 27;
            this.lblDuartion.Text = "Duartion";
            // 
            // lblStartExam
            // 
            this.lblStartExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartExam.AutoSize = true;
            this.lblStartExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblStartExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartExam.ForeColor = System.Drawing.Color.White;
            this.lblStartExam.Location = new System.Drawing.Point(8, 261);
            this.lblStartExam.Name = "lblStartExam";
            this.lblStartExam.Size = new System.Drawing.Size(62, 25);
            this.lblStartExam.TabIndex = 27;
            this.lblStartExam.Text = "Start";
            // 
            // lblExamLocation
            // 
            this.lblExamLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExamLocation.AutoSize = true;
            this.lblExamLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblExamLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamLocation.ForeColor = System.Drawing.Color.White;
            this.lblExamLocation.Location = new System.Drawing.Point(8, 179);
            this.lblExamLocation.Name = "lblExamLocation";
            this.lblExamLocation.Size = new System.Drawing.Size(102, 25);
            this.lblExamLocation.TabIndex = 27;
            this.lblExamLocation.Text = "Location";
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTitle.ForeColor = System.Drawing.Color.White;
            this.lblExamTitle.Location = new System.Drawing.Point(8, 141);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(58, 25);
            this.lblExamTitle.TabIndex = 27;
            this.lblExamTitle.Text = "Title";
            // 
            // lblExamsScreenCourse
            // 
            this.lblExamsScreenCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExamsScreenCourse.AutoSize = true;
            this.lblExamsScreenCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblExamsScreenCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamsScreenCourse.ForeColor = System.Drawing.Color.White;
            this.lblExamsScreenCourse.Location = new System.Drawing.Point(5, 222);
            this.lblExamsScreenCourse.Name = "lblExamsScreenCourse";
            this.lblExamsScreenCourse.Size = new System.Drawing.Size(87, 25);
            this.lblExamsScreenCourse.TabIndex = 27;
            this.lblExamsScreenCourse.Text = "Course";
            // 
            // lblExams
            // 
            this.lblExams.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExams.ForeColor = System.Drawing.Color.White;
            this.lblExams.Location = new System.Drawing.Point(678, 9);
            this.lblExams.Name = "lblExams";
            this.lblExams.Size = new System.Drawing.Size(185, 65);
            this.lblExams.TabIndex = 35;
            this.lblExams.Text = "Exams";
            // 
            // mppSettingsScreen
            // 
            this.mppSettingsScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppSettingsScreen.Controls.Add(this.lklSaveChanges);
            this.mppSettingsScreen.Controls.Add(this.lklSaveEmail);
            this.mppSettingsScreen.Controls.Add(this.lklSavePassword);
            this.mppSettingsScreen.Controls.Add(this.dtpBirthDay);
            this.mppSettingsScreen.Controls.Add(this.txtOldPassword);
            this.mppSettingsScreen.Controls.Add(this.txtConfirmNewPassword);
            this.mppSettingsScreen.Controls.Add(this.txtNewPassword);
            this.mppSettingsScreen.Controls.Add(this.txtNewEmail);
            this.mppSettingsScreen.Controls.Add(this.dtpEndActivity);
            this.mppSettingsScreen.Controls.Add(this.dtpStartActivity);
            this.mppSettingsScreen.Controls.Add(this.btnSettingsBack);
            this.mppSettingsScreen.Controls.Add(this.lblEndActivity);
            this.mppSettingsScreen.Controls.Add(this.lblStartActivity);
            this.mppSettingsScreen.Controls.Add(this.lblBirthday);
            this.mppSettingsScreen.Controls.Add(this.lblConfirmNewPassword);
            this.mppSettingsScreen.Controls.Add(this.lblNewPassword);
            this.mppSettingsScreen.Controls.Add(this.lblOldPassword);
            this.mppSettingsScreen.Controls.Add(this.lblNewEmail);
            this.mppSettingsScreen.Controls.Add(this.lblAbout);
            this.mppSettingsScreen.Controls.Add(this.lblChangeEmail);
            this.mppSettingsScreen.Controls.Add(this.lblGashashim);
            this.mppSettingsScreen.Controls.Add(this.lblChangePassword);
            this.mppSettingsScreen.Controls.Add(this.lblActivityTime);
            this.mppSettingsScreen.Controls.Add(this.lblPrivacy);
            this.mppSettingsScreen.Controls.Add(this.lblGeneral);
            this.mppSettingsScreen.Controls.Add(this.lblSettings);
            this.mppSettingsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppSettingsScreen.Location = new System.Drawing.Point(0, 0);
            this.mppSettingsScreen.Name = "mppSettingsScreen";
            this.mppSettingsScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppSettingsScreen.TabIndex = 0;
            this.mppSettingsScreen.Text = "Page11";
            this.mppSettingsScreen.VisibleChanged += new System.EventHandler(this.mppSettingsScreen_VisibleChanged);
            // 
            // lklSaveChanges
            // 
            this.lklSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lklSaveChanges.AutoSize = true;
            this.lklSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lklSaveChanges.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lklSaveChanges.Location = new System.Drawing.Point(809, 231);
            this.lklSaveChanges.Name = "lklSaveChanges";
            this.lklSaveChanges.Size = new System.Drawing.Size(110, 20);
            this.lklSaveChanges.TabIndex = 3;
            this.lklSaveChanges.TabStop = true;
            this.lklSaveChanges.Text = "Save changes";
            this.lklSaveChanges.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSaveChanges_LinkClicked);
            // 
            // lklSaveEmail
            // 
            this.lklSaveEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lklSaveEmail.AutoSize = true;
            this.lklSaveEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lklSaveEmail.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lklSaveEmail.Location = new System.Drawing.Point(809, 521);
            this.lklSaveEmail.Name = "lklSaveEmail";
            this.lklSaveEmail.Size = new System.Drawing.Size(86, 20);
            this.lklSaveEmail.TabIndex = 9;
            this.lklSaveEmail.TabStop = true;
            this.lklSaveEmail.Text = "Save email";
            this.lklSaveEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveEmailLinkLbl_LinkClicked);
            // 
            // lklSavePassword
            // 
            this.lklSavePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lklSavePassword.AutoSize = true;
            this.lklSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lklSavePassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lklSavePassword.Location = new System.Drawing.Point(791, 434);
            this.lklSavePassword.Name = "lklSavePassword";
            this.lklSavePassword.Size = new System.Drawing.Size(117, 20);
            this.lklSavePassword.TabIndex = 7;
            this.lklSavePassword.TabStop = true;
            this.lklSavePassword.Text = "Save password";
            this.lklSavePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSavePassword_LinkClicked);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBirthDay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDay.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDay.Location = new System.Drawing.Point(568, 227);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(233, 26);
            this.dtpBirthDay.TabIndex = 2;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(596, 359);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(190, 26);
            this.txtOldPassword.TabIndex = 4;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(596, 434);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(190, 26);
            this.txtConfirmNewPassword.TabIndex = 6;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(596, 398);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(190, 26);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmail.Location = new System.Drawing.Point(532, 516);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(254, 26);
            this.txtNewEmail.TabIndex = 8;
            // 
            // dtpEndActivity
            // 
            this.dtpEndActivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndActivity.CustomFormat = "HH:mm";
            this.dtpEndActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndActivity.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndActivity.Location = new System.Drawing.Point(795, 181);
            this.dtpEndActivity.Name = "dtpEndActivity";
            this.dtpEndActivity.ShowUpDown = true;
            this.dtpEndActivity.Size = new System.Drawing.Size(65, 26);
            this.dtpEndActivity.TabIndex = 1;
            // 
            // dtpStartActivity
            // 
            this.dtpStartActivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartActivity.CustomFormat = "HH:mm";
            this.dtpStartActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartActivity.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartActivity.Location = new System.Drawing.Point(638, 181);
            this.dtpStartActivity.Name = "dtpStartActivity";
            this.dtpStartActivity.ShowUpDown = true;
            this.dtpStartActivity.Size = new System.Drawing.Size(65, 26);
            this.dtpStartActivity.TabIndex = 0;
            // 
            // btnSettingsBack
            // 
            this.btnSettingsBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSettingsBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsBack.BackgroundImage")));
            this.btnSettingsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettingsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSettingsBack.Location = new System.Drawing.Point(37, 29);
            this.btnSettingsBack.Name = "btnSettingsBack";
            this.btnSettingsBack.Size = new System.Drawing.Size(50, 46);
            this.btnSettingsBack.TabIndex = 10;
            this.btnSettingsBack.UseVisualStyleBackColor = false;
            this.btnSettingsBack.Click += new System.EventHandler(this.MoveToMainScreen);
            // 
            // lblEndActivity
            // 
            this.lblEndActivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndActivity.AutoSize = true;
            this.lblEndActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblEndActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndActivity.ForeColor = System.Drawing.Color.White;
            this.lblEndActivity.Location = new System.Drawing.Point(721, 178);
            this.lblEndActivity.Name = "lblEndActivity";
            this.lblEndActivity.Size = new System.Drawing.Size(48, 24);
            this.lblEndActivity.TabIndex = 41;
            this.lblEndActivity.Text = "End";
            // 
            // lblStartActivity
            // 
            this.lblStartActivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartActivity.AutoSize = true;
            this.lblStartActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblStartActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartActivity.ForeColor = System.Drawing.Color.White;
            this.lblStartActivity.Location = new System.Drawing.Point(563, 178);
            this.lblStartActivity.Name = "lblStartActivity";
            this.lblStartActivity.Size = new System.Drawing.Size(51, 24);
            this.lblStartActivity.TabIndex = 41;
            this.lblStartActivity.Text = "Start";
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(418, 228);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(133, 24);
            this.lblBirthday.TabIndex = 41;
            this.lblBirthday.Text = "Date Of Birth:";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(418, 432);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(174, 24);
            this.lblConfirmNewPassword.TabIndex = 41;
            this.lblConfirmNewPassword.Text = "confirm password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(418, 398);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(144, 24);
            this.lblNewPassword.TabIndex = 41;
            this.lblNewPassword.Text = "new password";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.ForeColor = System.Drawing.Color.White;
            this.lblOldPassword.Location = new System.Drawing.Point(418, 359);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(134, 24);
            this.lblOldPassword.TabIndex = 41;
            this.lblOldPassword.Text = "old password";
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmail.ForeColor = System.Drawing.Color.White;
            this.lblNewEmail.Location = new System.Drawing.Point(418, 516);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(105, 24);
            this.lblNewEmail.TabIndex = 41;
            this.lblNewEmail.Text = "new email";
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(416, 568);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(90, 31);
            this.lblAbout.TabIndex = 41;
            this.lblAbout.Text = "About";
            // 
            // lblChangeEmail
            // 
            this.lblChangeEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChangeEmail.AutoSize = true;
            this.lblChangeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblChangeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeEmail.ForeColor = System.Drawing.Color.White;
            this.lblChangeEmail.Location = new System.Drawing.Point(418, 476);
            this.lblChangeEmail.Name = "lblChangeEmail";
            this.lblChangeEmail.Size = new System.Drawing.Size(147, 24);
            this.lblChangeEmail.TabIndex = 41;
            this.lblChangeEmail.Text = "Change Email:";
            // 
            // lblGashashim
            // 
            this.lblGashashim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGashashim.AutoSize = true;
            this.lblGashashim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblGashashim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGashashim.ForeColor = System.Drawing.Color.White;
            this.lblGashashim.Location = new System.Drawing.Point(418, 622);
            this.lblGashashim.Name = "lblGashashim";
            this.lblGashashim.Size = new System.Drawing.Size(182, 24);
            this.lblGashashim.TabIndex = 41;
            this.lblGashashim.Text = "“Gashashim” team";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.White;
            this.lblChangePassword.Location = new System.Drawing.Point(418, 321);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(184, 24);
            this.lblChangePassword.TabIndex = 41;
            this.lblChangePassword.Text = "Change password:";
            // 
            // lblActivityTime
            // 
            this.lblActivityTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActivityTime.AutoSize = true;
            this.lblActivityTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblActivityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityTime.ForeColor = System.Drawing.Color.White;
            this.lblActivityTime.Location = new System.Drawing.Point(418, 178);
            this.lblActivityTime.Name = "lblActivityTime";
            this.lblActivityTime.Size = new System.Drawing.Size(126, 24);
            this.lblActivityTime.TabIndex = 41;
            this.lblActivityTime.Text = "Activity time:";
            // 
            // lblPrivacy
            // 
            this.lblPrivacy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrivacy.AutoSize = true;
            this.lblPrivacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivacy.ForeColor = System.Drawing.Color.White;
            this.lblPrivacy.Location = new System.Drawing.Point(416, 277);
            this.lblPrivacy.Name = "lblPrivacy";
            this.lblPrivacy.Size = new System.Drawing.Size(111, 31);
            this.lblPrivacy.TabIndex = 41;
            this.lblPrivacy.Text = "Privacy";
            // 
            // lblGeneral
            // 
            this.lblGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.White;
            this.lblGeneral.Location = new System.Drawing.Point(416, 131);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(117, 31);
            this.lblGeneral.TabIndex = 41;
            this.lblGeneral.Text = "General";
            // 
            // lblSettings
            // 
            this.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(563, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(209, 65);
            this.lblSettings.TabIndex = 41;
            this.lblSettings.Text = "Settings";
            // 
            // mppTasksScreen
            // 
            this.mppTasksScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppTasksScreen.Controls.Add(this.pnlTasks);
            this.mppTasksScreen.Controls.Add(this.lblTasks);
            this.mppTasksScreen.Controls.Add(this.lstTasks);
            this.mppTasksScreen.Controls.Add(this.pnlCoverDisplayTask);
            this.mppTasksScreen.Controls.Add(this.pnlSelectTask);
            this.mppTasksScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppTasksScreen.Location = new System.Drawing.Point(0, 0);
            this.mppTasksScreen.Name = "mppTasksScreen";
            this.mppTasksScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppTasksScreen.TabIndex = 0;
            this.mppTasksScreen.Text = "Page8";
            this.mppTasksScreen.VisibleChanged += new System.EventHandler(this.mppTasksScreen_VisibleChanged);
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlTasks.Controls.Add(this.pnlFreeTimeSearch);
            this.pnlTasks.Controls.Add(this.pnlChooseTime);
            this.pnlTasks.Controls.Add(this.btnBackToAddingTask);
            this.pnlTasks.Controls.Add(this.btnSaveTask);
            this.pnlTasks.Controls.Add(this.cboCourseTaskPanel);
            this.pnlTasks.Controls.Add(this.rbtStartAndEndTask);
            this.pnlTasks.Controls.Add(this.rbtFreeTimeSearch);
            this.pnlTasks.Controls.Add(this.dtpDeadline);
            this.pnlTasks.Controls.Add(this.lblNewTask);
            this.pnlTasks.Controls.Add(this.btnTasksBack);
            this.pnlTasks.Controls.Add(this.lblTaskName);
            this.pnlTasks.Controls.Add(this.lblDeadline);
            this.pnlTasks.Controls.Add(this.txtTaskName);
            this.pnlTasks.Controls.Add(this.lblCourseTasksPage);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(278, 736);
            this.pnlTasks.TabIndex = 0;
            // 
            // pnlFreeTimeSearch
            // 
            this.pnlFreeTimeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlFreeTimeSearch.Controls.Add(this.btnFreeTimeSearch);
            this.pnlFreeTimeSearch.Controls.Add(this.cboEstimateTimeUnit);
            this.pnlFreeTimeSearch.Controls.Add(this.lblAvailableTime);
            this.pnlFreeTimeSearch.Controls.Add(this.nudEstimateTime);
            this.pnlFreeTimeSearch.Controls.Add(this.lblEstimateTime);
            this.pnlFreeTimeSearch.Location = new System.Drawing.Point(-1, 373);
            this.pnlFreeTimeSearch.Name = "pnlFreeTimeSearch";
            this.pnlFreeTimeSearch.Size = new System.Drawing.Size(278, 239);
            this.pnlFreeTimeSearch.TabIndex = 4;
            // 
            // btnFreeTimeSearch
            // 
            this.btnFreeTimeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnFreeTimeSearch.Enabled = false;
            this.btnFreeTimeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFreeTimeSearch.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFreeTimeSearch.ForeColor = System.Drawing.Color.White;
            this.btnFreeTimeSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnFreeTimeSearch.Image")));
            this.btnFreeTimeSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreeTimeSearch.Location = new System.Drawing.Point(12, 154);
            this.btnFreeTimeSearch.Name = "btnFreeTimeSearch";
            this.btnFreeTimeSearch.Size = new System.Drawing.Size(232, 35);
            this.btnFreeTimeSearch.TabIndex = 2;
            this.btnFreeTimeSearch.Text = "Search Free Time";
            this.btnFreeTimeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFreeTimeSearch.UseVisualStyleBackColor = false;
            this.btnFreeTimeSearch.Click += new System.EventHandler(this.btnFreeTimeSearch_Click);
            // 
            // cboEstimateTimeUnit
            // 
            this.cboEstimateTimeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboEstimateTimeUnit.FormattingEnabled = true;
            this.cboEstimateTimeUnit.ItemHeight = 23;
            this.cboEstimateTimeUnit.Items.AddRange(new object[] {
            "minutes",
            "hours"});
            this.cboEstimateTimeUnit.Location = new System.Drawing.Point(109, 50);
            this.cboEstimateTimeUnit.Name = "cboEstimateTimeUnit";
            this.cboEstimateTimeUnit.Size = new System.Drawing.Size(121, 29);
            this.cboEstimateTimeUnit.TabIndex = 1;
            this.cboEstimateTimeUnit.UseSelectable = true;
            this.cboEstimateTimeUnit.SelectedIndexChanged += new System.EventHandler(this.nudEstimateTime_ValueChanged);
            // 
            // lblAvailableTime
            // 
            this.lblAvailableTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAvailableTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblAvailableTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTime.ForeColor = System.Drawing.Color.White;
            this.lblAvailableTime.Location = new System.Drawing.Point(7, 101);
            this.lblAvailableTime.Name = "lblAvailableTime";
            this.lblAvailableTime.Size = new System.Drawing.Size(168, 37);
            this.lblAvailableTime.TabIndex = 27;
            this.lblAvailableTime.Text = "Available time";
            // 
            // nudEstimateTime
            // 
            this.nudEstimateTime.AutoSize = true;
            this.nudEstimateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEstimateTime.Location = new System.Drawing.Point(12, 51);
            this.nudEstimateTime.Maximum = new decimal(new int[] {
            555,
            0,
            0,
            0});
            this.nudEstimateTime.Name = "nudEstimateTime";
            this.nudEstimateTime.Size = new System.Drawing.Size(65, 26);
            this.nudEstimateTime.TabIndex = 0;
            this.nudEstimateTime.ValueChanged += new System.EventHandler(this.nudEstimateTime_ValueChanged);
            // 
            // lblEstimateTime
            // 
            this.lblEstimateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstimateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblEstimateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimateTime.ForeColor = System.Drawing.Color.White;
            this.lblEstimateTime.Location = new System.Drawing.Point(7, 2);
            this.lblEstimateTime.Name = "lblEstimateTime";
            this.lblEstimateTime.Size = new System.Drawing.Size(168, 37);
            this.lblEstimateTime.TabIndex = 27;
            this.lblEstimateTime.Text = "Estimate Time";
            // 
            // pnlChooseTime
            // 
            this.pnlChooseTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlChooseTime.Controls.Add(this.btnDeleteTask);
            this.pnlChooseTime.Controls.Add(this.dtpEndTask);
            this.pnlChooseTime.Controls.Add(this.dtpStartTask);
            this.pnlChooseTime.Controls.Add(this.lblEndTask);
            this.pnlChooseTime.Controls.Add(this.lblStartTask);
            this.pnlChooseTime.Location = new System.Drawing.Point(-1, 373);
            this.pnlChooseTime.Name = "pnlChooseTime";
            this.pnlChooseTime.Size = new System.Drawing.Size(278, 239);
            this.pnlChooseTime.TabIndex = 34;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.Image")));
            this.btnDeleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTask.Location = new System.Drawing.Point(8, 178);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(133, 40);
            this.btnDeleteTask.TabIndex = 5;
            this.btnDeleteTask.TabStop = false;
            this.btnDeleteTask.Text = "Delete task";
            this.btnDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Visible = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // dtpEndTask
            // 
            this.dtpEndTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEndTask.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTask.Location = new System.Drawing.Point(8, 139);
            this.dtpEndTask.Name = "dtpEndTask";
            this.dtpEndTask.Size = new System.Drawing.Size(237, 22);
            this.dtpEndTask.TabIndex = 8;
            this.dtpEndTask.TabStop = false;
            // 
            // dtpStartTask
            // 
            this.dtpStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStartTask.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpStartTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTask.Location = new System.Drawing.Point(8, 55);
            this.dtpStartTask.Name = "dtpStartTask";
            this.dtpStartTask.Size = new System.Drawing.Size(237, 22);
            this.dtpStartTask.TabIndex = 0;
            this.dtpStartTask.TabStop = false;
            // 
            // lblEndTask
            // 
            this.lblEndTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndTask.AutoSize = true;
            this.lblEndTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTask.ForeColor = System.Drawing.Color.White;
            this.lblEndTask.Location = new System.Drawing.Point(4, 101);
            this.lblEndTask.Name = "lblEndTask";
            this.lblEndTask.Size = new System.Drawing.Size(53, 25);
            this.lblEndTask.TabIndex = 27;
            this.lblEndTask.Text = "End";
            // 
            // lblStartTask
            // 
            this.lblStartTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartTask.AutoSize = true;
            this.lblStartTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblStartTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTask.ForeColor = System.Drawing.Color.White;
            this.lblStartTask.Location = new System.Drawing.Point(6, 14);
            this.lblStartTask.Name = "lblStartTask";
            this.lblStartTask.Size = new System.Drawing.Size(62, 25);
            this.lblStartTask.TabIndex = 27;
            this.lblStartTask.Text = "Start";
            // 
            // btnBackToAddingTask
            // 
            this.btnBackToAddingTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAddingTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackToAddingTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnBackToAddingTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToAddingTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAddingTask.ForeColor = System.Drawing.Color.White;
            this.btnBackToAddingTask.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToAddingTask.Image")));
            this.btnBackToAddingTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToAddingTask.Location = new System.Drawing.Point(10, 62);
            this.btnBackToAddingTask.Name = "btnBackToAddingTask";
            this.btnBackToAddingTask.Size = new System.Drawing.Size(233, 40);
            this.btnBackToAddingTask.TabIndex = 6;
            this.btnBackToAddingTask.TabStop = false;
            this.btnBackToAddingTask.Text = "Back to adding mode";
            this.btnBackToAddingTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToAddingTask.UseVisualStyleBackColor = false;
            this.btnBackToAddingTask.Visible = false;
            this.btnBackToAddingTask.Click += new System.EventHandler(this.btnBackToAddingTask_Click);
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnSaveTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveTask.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaveTask.ForeColor = System.Drawing.Color.White;
            this.btnSaveTask.Location = new System.Drawing.Point(198, 621);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(70, 30);
            this.btnSaveTask.TabIndex = 5;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveTask.UseVisualStyleBackColor = false;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // cboCourseTaskPanel
            // 
            this.cboCourseTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCourseTaskPanel.FormattingEnabled = true;
            this.cboCourseTaskPanel.ItemHeight = 23;
            this.cboCourseTaskPanel.Location = new System.Drawing.Point(108, 194);
            this.cboCourseTaskPanel.Name = "cboCourseTaskPanel";
            this.cboCourseTaskPanel.Size = new System.Drawing.Size(160, 29);
            this.cboCourseTaskPanel.TabIndex = 1;
            this.cboCourseTaskPanel.UseSelectable = true;
            // 
            // rbtStartAndEndTask
            // 
            this.rbtStartAndEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtStartAndEndTask.ForeColor = System.Drawing.Color.White;
            this.rbtStartAndEndTask.Location = new System.Drawing.Point(7, 338);
            this.rbtStartAndEndTask.Name = "rbtStartAndEndTask";
            this.rbtStartAndEndTask.Size = new System.Drawing.Size(237, 37);
            this.rbtStartAndEndTask.TabIndex = 4;
            this.rbtStartAndEndTask.Text = "Select Start and End";
            this.rbtStartAndEndTask.UseVisualStyleBackColor = true;
            // 
            // rbtFreeTimeSearch
            // 
            this.rbtFreeTimeSearch.Checked = true;
            this.rbtFreeTimeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFreeTimeSearch.ForeColor = System.Drawing.Color.White;
            this.rbtFreeTimeSearch.Location = new System.Drawing.Point(7, 304);
            this.rbtFreeTimeSearch.Name = "rbtFreeTimeSearch";
            this.rbtFreeTimeSearch.Size = new System.Drawing.Size(237, 37);
            this.rbtFreeTimeSearch.TabIndex = 3;
            this.rbtFreeTimeSearch.TabStop = true;
            this.rbtFreeTimeSearch.Text = "Use free time search";
            this.rbtFreeTimeSearch.UseVisualStyleBackColor = true;
            this.rbtFreeTimeSearch.CheckedChanged += new System.EventHandler(this.rbtFreeTimeSearch_CheckedChanged);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDeadline.CustomFormat = "yyyy MMMM dd dddd - HH:mm";
            this.dtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(7, 280);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(237, 22);
            this.dtpDeadline.TabIndex = 2;
            this.dtpDeadline.ValueChanged += new System.EventHandler(this.nudEstimateTime_ValueChanged);
            // 
            // lblNewTask
            // 
            this.lblNewTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTask.ForeColor = System.Drawing.Color.White;
            this.lblNewTask.Location = new System.Drawing.Point(5, 108);
            this.lblNewTask.Name = "lblNewTask";
            this.lblNewTask.Size = new System.Drawing.Size(231, 37);
            this.lblNewTask.TabIndex = 27;
            this.lblNewTask.Text = "Add a new task";
            // 
            // btnTasksBack
            // 
            this.btnTasksBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnTasksBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTasksBack.BackgroundImage")));
            this.btnTasksBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTasksBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasksBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.btnTasksBack.Location = new System.Drawing.Point(3, 3);
            this.btnTasksBack.Name = "btnTasksBack";
            this.btnTasksBack.Size = new System.Drawing.Size(59, 56);
            this.btnTasksBack.TabIndex = 4;
            this.btnTasksBack.UseVisualStyleBackColor = false;
            this.btnTasksBack.Click += new System.EventHandler(this.MoveToMainScreen);
            // 
            // lblTaskName
            // 
            this.lblTaskName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(5, 148);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(77, 37);
            this.lblTaskName.TabIndex = 27;
            this.lblTaskName.Text = "Name";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.White;
            this.lblDeadline.Location = new System.Drawing.Point(2, 240);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(114, 37);
            this.lblDeadline.TabIndex = 27;
            this.lblDeadline.Text = "Deadline";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(88, 150);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(182, 26);
            this.txtTaskName.TabIndex = 0;
            // 
            // lblCourseTasksPage
            // 
            this.lblCourseTasksPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseTasksPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblCourseTasksPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTasksPage.ForeColor = System.Drawing.Color.White;
            this.lblCourseTasksPage.Location = new System.Drawing.Point(5, 195);
            this.lblCourseTasksPage.Name = "lblCourseTasksPage";
            this.lblCourseTasksPage.Size = new System.Drawing.Size(92, 37);
            this.lblCourseTasksPage.TabIndex = 27;
            this.lblCourseTasksPage.Text = "Course";
            // 
            // lblTasks
            // 
            this.lblTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.ForeColor = System.Drawing.Color.White;
            this.lblTasks.Location = new System.Drawing.Point(716, 16);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(158, 65);
            this.lblTasks.TabIndex = 32;
            this.lblTasks.Text = "Tasks";
            // 
            // lstTasks
            // 
            this.lstTasks.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lstTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTasks.ForeColor = System.Drawing.SystemColors.Window;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 30;
            this.lstTasks.Location = new System.Drawing.Point(330, 177);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstTasks.Size = new System.Drawing.Size(954, 532);
            this.lstTasks.TabIndex = 74;
            this.lstTasks.TabStop = false;
            this.lstTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstTasks_DrawItem);
            this.lstTasks.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstTasks_MeasureItem);
            this.lstTasks.DoubleClick += new System.EventHandler(this.lstTasks_DoubleClick);
            // 
            // pnlCoverDisplayTask
            // 
            this.pnlCoverDisplayTask.Controls.Add(this.lblNoTasksYet);
            this.pnlCoverDisplayTask.Location = new System.Drawing.Point(330, 84);
            this.pnlCoverDisplayTask.Name = "pnlCoverDisplayTask";
            this.pnlCoverDisplayTask.Size = new System.Drawing.Size(422, 92);
            this.pnlCoverDisplayTask.TabIndex = 76;
            // 
            // lblNoTasksYet
            // 
            this.lblNoTasksYet.AutoSize = true;
            this.lblNoTasksYet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNoTasksYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTasksYet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblNoTasksYet.Location = new System.Drawing.Point(3, 6);
            this.lblNoTasksYet.Name = "lblNoTasksYet";
            this.lblNoTasksYet.Size = new System.Drawing.Size(143, 25);
            this.lblNoTasksYet.TabIndex = 27;
            this.lblNoTasksYet.Text = "No tasks yet";
            // 
            // pnlSelectTask
            // 
            this.pnlSelectTask.Controls.Add(this.lblSelectTask);
            this.pnlSelectTask.Controls.Add(this.cboCourseDisplayTaskPanel);
            this.pnlSelectTask.Controls.Add(this.cboSemesterDisplayTaskPanel);
            this.pnlSelectTask.Controls.Add(this.cboAcademicYearDisplayTaskPanel);
            this.pnlSelectTask.Location = new System.Drawing.Point(330, 84);
            this.pnlSelectTask.Name = "pnlSelectTask";
            this.pnlSelectTask.Size = new System.Drawing.Size(422, 92);
            this.pnlSelectTask.TabIndex = 75;
            // 
            // lblSelectTask
            // 
            this.lblSelectTask.AutoSize = true;
            this.lblSelectTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblSelectTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.lblSelectTask.Location = new System.Drawing.Point(3, 6);
            this.lblSelectTask.Name = "lblSelectTask";
            this.lblSelectTask.Size = new System.Drawing.Size(238, 25);
            this.lblSelectTask.TabIndex = 27;
            this.lblSelectTask.Text = "Select task to display";
            // 
            // cboCourseDisplayTaskPanel
            // 
            this.cboCourseDisplayTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCourseDisplayTaskPanel.FormattingEnabled = true;
            this.cboCourseDisplayTaskPanel.ItemHeight = 23;
            this.cboCourseDisplayTaskPanel.Location = new System.Drawing.Point(282, 48);
            this.cboCourseDisplayTaskPanel.Name = "cboCourseDisplayTaskPanel";
            this.cboCourseDisplayTaskPanel.Size = new System.Drawing.Size(137, 29);
            this.cboCourseDisplayTaskPanel.TabIndex = 28;
            this.cboCourseDisplayTaskPanel.TabStop = false;
            this.cboCourseDisplayTaskPanel.UseSelectable = true;
            this.cboCourseDisplayTaskPanel.SelectedIndexChanged += new System.EventHandler(this.academicYearDisplayTaskPanel_SelectedIndexChanged);
            // 
            // cboSemesterDisplayTaskPanel
            // 
            this.cboSemesterDisplayTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSemesterDisplayTaskPanel.FormattingEnabled = true;
            this.cboSemesterDisplayTaskPanel.ItemHeight = 23;
            this.cboSemesterDisplayTaskPanel.Location = new System.Drawing.Point(145, 48);
            this.cboSemesterDisplayTaskPanel.Name = "cboSemesterDisplayTaskPanel";
            this.cboSemesterDisplayTaskPanel.Size = new System.Drawing.Size(121, 29);
            this.cboSemesterDisplayTaskPanel.TabIndex = 28;
            this.cboSemesterDisplayTaskPanel.TabStop = false;
            this.cboSemesterDisplayTaskPanel.UseSelectable = true;
            this.cboSemesterDisplayTaskPanel.SelectedIndexChanged += new System.EventHandler(this.academicYearDisplayTaskPanel_SelectedIndexChanged);
            // 
            // cboAcademicYearDisplayTaskPanel
            // 
            this.cboAcademicYearDisplayTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAcademicYearDisplayTaskPanel.FormattingEnabled = true;
            this.cboAcademicYearDisplayTaskPanel.ItemHeight = 23;
            this.cboAcademicYearDisplayTaskPanel.Location = new System.Drawing.Point(8, 48);
            this.cboAcademicYearDisplayTaskPanel.Name = "cboAcademicYearDisplayTaskPanel";
            this.cboAcademicYearDisplayTaskPanel.Size = new System.Drawing.Size(121, 29);
            this.cboAcademicYearDisplayTaskPanel.TabIndex = 28;
            this.cboAcademicYearDisplayTaskPanel.TabStop = false;
            this.cboAcademicYearDisplayTaskPanel.UseSelectable = true;
            this.cboAcademicYearDisplayTaskPanel.SelectedIndexChanged += new System.EventHandler(this.academicYearDisplayTaskPanel_SelectedIndexChanged);
            // 
            // mppNotesScreen
            // 
            this.mppNotesScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppNotesScreen.Controls.Add(this.rtfNote1);
            this.mppNotesScreen.Controls.Add(this.rtfNote2);
            this.mppNotesScreen.Controls.Add(this.rtfNote3);
            this.mppNotesScreen.Controls.Add(this.rtfNote4);
            this.mppNotesScreen.Controls.Add(this.rtfNote5);
            this.mppNotesScreen.Controls.Add(this.rtfNote6);
            this.mppNotesScreen.Controls.Add(this.rtfNote7);
            this.mppNotesScreen.Controls.Add(this.rtfNote8);
            this.mppNotesScreen.Controls.Add(this.rtfNote9);
            this.mppNotesScreen.Controls.Add(this.rtfNote10);
            this.mppNotesScreen.Controls.Add(this.btnNotesBack);
            this.mppNotesScreen.Controls.Add(this.lblNotes);
            this.mppNotesScreen.Controls.Add(this.btnRemoveNote);
            this.mppNotesScreen.Controls.Add(this.btnAddNote);
            this.mppNotesScreen.Controls.Add(this.lblRemoveNote);
            this.mppNotesScreen.Controls.Add(this.lblAddNote);
            this.mppNotesScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppNotesScreen.Location = new System.Drawing.Point(0, 0);
            this.mppNotesScreen.Name = "mppNotesScreen";
            this.mppNotesScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppNotesScreen.TabIndex = 0;
            this.mppNotesScreen.Text = "Page10";
            this.mppNotesScreen.Visible = false;
            this.mppNotesScreen.VisibleChanged += new System.EventHandler(this.mppNotesScreen_VisibleChanged);
            // 
            // rtfNote1
            // 
            this.rtfNote1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote1.Location = new System.Drawing.Point(93, 128);
            this.rtfNote1.Name = "rtfNote1";
            this.rtfNote1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote1.Size = new System.Drawing.Size(180, 163);
            this.rtfNote1.TabIndex = 1;
            this.rtfNote1.Text = "~";
            this.rtfNote1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote2
            // 
            this.rtfNote2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote2.Location = new System.Drawing.Point(335, 128);
            this.rtfNote2.Name = "rtfNote2";
            this.rtfNote2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote2.Size = new System.Drawing.Size(180, 163);
            this.rtfNote2.TabIndex = 2;
            this.rtfNote2.Text = "~";
            this.rtfNote2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote3
            // 
            this.rtfNote3.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote3.Location = new System.Drawing.Point(577, 128);
            this.rtfNote3.Name = "rtfNote3";
            this.rtfNote3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote3.Size = new System.Drawing.Size(180, 163);
            this.rtfNote3.TabIndex = 3;
            this.rtfNote3.Text = "~";
            this.rtfNote3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote4
            // 
            this.rtfNote4.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote4.Location = new System.Drawing.Point(819, 128);
            this.rtfNote4.Name = "rtfNote4";
            this.rtfNote4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote4.Size = new System.Drawing.Size(180, 163);
            this.rtfNote4.TabIndex = 4;
            this.rtfNote4.Text = "~";
            this.rtfNote4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote5
            // 
            this.rtfNote5.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote5.Location = new System.Drawing.Point(1061, 128);
            this.rtfNote5.Name = "rtfNote5";
            this.rtfNote5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote5.Size = new System.Drawing.Size(180, 163);
            this.rtfNote5.TabIndex = 5;
            this.rtfNote5.Text = "~";
            this.rtfNote5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote6
            // 
            this.rtfNote6.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote6.Location = new System.Drawing.Point(93, 418);
            this.rtfNote6.Name = "rtfNote6";
            this.rtfNote6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote6.Size = new System.Drawing.Size(180, 163);
            this.rtfNote6.TabIndex = 6;
            this.rtfNote6.Text = "~";
            this.rtfNote6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote7
            // 
            this.rtfNote7.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote7.Location = new System.Drawing.Point(335, 418);
            this.rtfNote7.Name = "rtfNote7";
            this.rtfNote7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote7.Size = new System.Drawing.Size(180, 163);
            this.rtfNote7.TabIndex = 7;
            this.rtfNote7.Text = "~";
            this.rtfNote7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote8
            // 
            this.rtfNote8.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote8.Location = new System.Drawing.Point(577, 418);
            this.rtfNote8.Name = "rtfNote8";
            this.rtfNote8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote8.Size = new System.Drawing.Size(180, 163);
            this.rtfNote8.TabIndex = 8;
            this.rtfNote8.Text = "~";
            this.rtfNote8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote9
            // 
            this.rtfNote9.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote9.Location = new System.Drawing.Point(819, 418);
            this.rtfNote9.Name = "rtfNote9";
            this.rtfNote9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote9.Size = new System.Drawing.Size(180, 163);
            this.rtfNote9.TabIndex = 9;
            this.rtfNote9.Text = "~";
            this.rtfNote9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // rtfNote10
            // 
            this.rtfNote10.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rtfNote10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfNote10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.rtfNote10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfNote10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtfNote10.Location = new System.Drawing.Point(1061, 418);
            this.rtfNote10.Name = "rtfNote10";
            this.rtfNote10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtfNote10.Size = new System.Drawing.Size(180, 163);
            this.rtfNote10.TabIndex = 10;
            this.rtfNote10.Text = "~";
            this.rtfNote10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtfNote_MouseDoubleClick);
            // 
            // btnNotesBack
            // 
            this.btnNotesBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNotesBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotesBack.BackgroundImage")));
            this.btnNotesBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNotesBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotesBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNotesBack.Location = new System.Drawing.Point(28, 29);
            this.btnNotesBack.Name = "btnNotesBack";
            this.btnNotesBack.Size = new System.Drawing.Size(50, 46);
            this.btnNotesBack.TabIndex = 12;
            this.btnNotesBack.UseVisualStyleBackColor = false;
            this.btnNotesBack.Click += new System.EventHandler(this.MoveToMainScreen);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(609, 19);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(165, 65);
            this.lblNotes.TabIndex = 39;
            this.lblNotes.Text = "Notes";
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveNote.BackgroundImage")));
            this.btnRemoveNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRemoveNote.Location = new System.Drawing.Point(1048, 629);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(50, 53);
            this.btnRemoveNote.TabIndex = 11;
            this.btnRemoveNote.UseVisualStyleBackColor = true;
            this.btnRemoveNote.Visible = false;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNote.BackgroundImage")));
            this.btnAddNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAddNote.Location = new System.Drawing.Point(1221, 629);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(50, 53);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // lblRemoveNote
            // 
            this.lblRemoveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemoveNote.AutoSize = true;
            this.lblRemoveNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblRemoveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.lblRemoveNote.Location = new System.Drawing.Point(999, 685);
            this.lblRemoveNote.Name = "lblRemoveNote";
            this.lblRemoveNote.Size = new System.Drawing.Size(150, 25);
            this.lblRemoveNote.TabIndex = 40;
            this.lblRemoveNote.Text = "Remove note";
            this.lblRemoveNote.Visible = false;
            // 
            // lblAddNote
            // 
            this.lblAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddNote.AutoSize = true;
            this.lblAddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.lblAddNote.Location = new System.Drawing.Point(1196, 685);
            this.lblAddNote.Name = "lblAddNote";
            this.lblAddNote.Size = new System.Drawing.Size(106, 25);
            this.lblAddNote.TabIndex = 40;
            this.lblAddNote.Text = "Add note";
            // 
            // mppSignUpScreen
            // 
            this.mppSignUpScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mppSignUpScreen.Controls.Add(this.btnCreateUser);
            this.mppSignUpScreen.Controls.Add(this.dtpBirthdaySignUp);
            this.mppSignUpScreen.Controls.Add(this.txtPasswordSignUp);
            this.mppSignUpScreen.Controls.Add(this.txtConfirmPasswordSignUp);
            this.mppSignUpScreen.Controls.Add(this.txtFullName);
            this.mppSignUpScreen.Controls.Add(this.txtEmailSignUp);
            this.mppSignUpScreen.Controls.Add(this.dtpStartAcativitySignUp);
            this.mppSignUpScreen.Controls.Add(this.dtpEndActivitySignUp);
            this.mppSignUpScreen.Controls.Add(this.btnSignUpBack);
            this.mppSignUpScreen.Controls.Add(this.lblConfirmPasswordSignUp);
            this.mppSignUpScreen.Controls.Add(this.lblPasswordSignUp);
            this.mppSignUpScreen.Controls.Add(this.lblToSignUp);
            this.mppSignUpScreen.Controls.Add(this.lblFullName);
            this.mppSignUpScreen.Controls.Add(this.lblEmailSignUp);
            this.mppSignUpScreen.Controls.Add(this.lblBirthdaySignUp);
            this.mppSignUpScreen.Controls.Add(this.lblActivityTimeSignUp);
            this.mppSignUpScreen.Controls.Add(this.lblSignUp);
            this.mppSignUpScreen.Controls.Add(this.picBackground3);
            this.mppSignUpScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppSignUpScreen.Location = new System.Drawing.Point(0, 0);
            this.mppSignUpScreen.Name = "mppSignUpScreen";
            this.mppSignUpScreen.Size = new System.Drawing.Size(1334, 736);
            this.mppSignUpScreen.TabIndex = 0;
            this.mppSignUpScreen.Text = "Page12";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateUser.Font = new System.Drawing.Font("Guttman Myamfix", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateUser.Image")));
            this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.Location = new System.Drawing.Point(587, 644);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(160, 38);
            this.btnCreateUser.TabIndex = 7;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // dtpBirthdaySignUp
            // 
            this.dtpBirthdaySignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBirthdaySignUp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdaySignUp.CustomFormat = "yyyy MMMM dd dddd";
            this.dtpBirthdaySignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpBirthdaySignUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdaySignUp.Location = new System.Drawing.Point(627, 479);
            this.dtpBirthdaySignUp.Name = "dtpBirthdaySignUp";
            this.dtpBirthdaySignUp.Size = new System.Drawing.Size(235, 26);
            this.dtpBirthdaySignUp.TabIndex = 4;
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(597, 312);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.PasswordChar = '*';
            this.txtPasswordSignUp.Size = new System.Drawing.Size(190, 26);
            this.txtPasswordSignUp.TabIndex = 2;
            this.txtPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // txtConfirmPasswordSignUp
            // 
            this.txtConfirmPasswordSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordSignUp.Location = new System.Drawing.Point(672, 390);
            this.txtConfirmPasswordSignUp.Name = "txtConfirmPasswordSignUp";
            this.txtConfirmPasswordSignUp.Size = new System.Drawing.Size(190, 26);
            this.txtConfirmPasswordSignUp.TabIndex = 3;
            this.txtConfirmPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(597, 148);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(254, 26);
            this.txtFullName.TabIndex = 0;
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSignUp.Location = new System.Drawing.Point(560, 225);
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(291, 26);
            this.txtEmailSignUp.TabIndex = 1;
            // 
            // dtpStartAcativitySignUp
            // 
            this.dtpStartAcativitySignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartAcativitySignUp.CustomFormat = "HH:mm";
            this.dtpStartAcativitySignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartAcativitySignUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartAcativitySignUp.Location = new System.Drawing.Point(618, 577);
            this.dtpStartAcativitySignUp.Name = "dtpStartAcativitySignUp";
            this.dtpStartAcativitySignUp.ShowUpDown = true;
            this.dtpStartAcativitySignUp.Size = new System.Drawing.Size(72, 26);
            this.dtpStartAcativitySignUp.TabIndex = 5;
            // 
            // dtpEndActivitySignUp
            // 
            this.dtpEndActivitySignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndActivitySignUp.CustomFormat = "HH:mm";
            this.dtpEndActivitySignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndActivitySignUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndActivitySignUp.Location = new System.Drawing.Point(749, 577);
            this.dtpEndActivitySignUp.Name = "dtpEndActivitySignUp";
            this.dtpEndActivitySignUp.ShowUpDown = true;
            this.dtpEndActivitySignUp.Size = new System.Drawing.Size(73, 26);
            this.dtpEndActivitySignUp.TabIndex = 6;
            // 
            // btnSignUpBack
            // 
            this.btnSignUpBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSignUpBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUpBack.BackgroundImage")));
            this.btnSignUpBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSignUpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSignUpBack.Location = new System.Drawing.Point(25, 31);
            this.btnSignUpBack.Name = "btnSignUpBack";
            this.btnSignUpBack.Size = new System.Drawing.Size(50, 46);
            this.btnSignUpBack.TabIndex = 8;
            this.btnSignUpBack.UseVisualStyleBackColor = false;
            this.btnSignUpBack.Click += new System.EventHandler(this.MoveToLogInScreen);
            // 
            // lblConfirmPasswordSignUp
            // 
            this.lblConfirmPasswordSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirmPasswordSignUp.AutoSize = true;
            this.lblConfirmPasswordSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblConfirmPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordSignUp.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPasswordSignUp.Location = new System.Drawing.Point(473, 392);
            this.lblConfirmPasswordSignUp.Name = "lblConfirmPasswordSignUp";
            this.lblConfirmPasswordSignUp.Size = new System.Drawing.Size(177, 24);
            this.lblConfirmPasswordSignUp.TabIndex = 49;
            this.lblConfirmPasswordSignUp.Text = "Confirm password";
            // 
            // lblPasswordSignUp
            // 
            this.lblPasswordSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPasswordSignUp.AutoSize = true;
            this.lblPasswordSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignUp.ForeColor = System.Drawing.Color.White;
            this.lblPasswordSignUp.Location = new System.Drawing.Point(473, 312);
            this.lblPasswordSignUp.Name = "lblPasswordSignUp";
            this.lblPasswordSignUp.Size = new System.Drawing.Size(100, 24);
            this.lblPasswordSignUp.TabIndex = 50;
            this.lblPasswordSignUp.Text = "Password";
            // 
            // lblToSignUp
            // 
            this.lblToSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToSignUp.ForeColor = System.Drawing.Color.White;
            this.lblToSignUp.Location = new System.Drawing.Point(708, 579);
            this.lblToSignUp.Name = "lblToSignUp";
            this.lblToSignUp.Size = new System.Drawing.Size(33, 30);
            this.lblToSignUp.TabIndex = 51;
            this.lblToSignUp.Text = "to";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(473, 148);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(103, 24);
            this.lblFullName.TabIndex = 51;
            this.lblFullName.Text = "Full name";
            // 
            // lblEmailSignUp
            // 
            this.lblEmailSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmailSignUp.AutoSize = true;
            this.lblEmailSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignUp.ForeColor = System.Drawing.Color.White;
            this.lblEmailSignUp.Location = new System.Drawing.Point(473, 225);
            this.lblEmailSignUp.Name = "lblEmailSignUp";
            this.lblEmailSignUp.Size = new System.Drawing.Size(62, 24);
            this.lblEmailSignUp.TabIndex = 51;
            this.lblEmailSignUp.Text = "Email";
            // 
            // lblBirthdaySignUp
            // 
            this.lblBirthdaySignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBirthdaySignUp.AutoSize = true;
            this.lblBirthdaySignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblBirthdaySignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdaySignUp.ForeColor = System.Drawing.Color.White;
            this.lblBirthdaySignUp.Location = new System.Drawing.Point(473, 481);
            this.lblBirthdaySignUp.Name = "lblBirthdaySignUp";
            this.lblBirthdaySignUp.Size = new System.Drawing.Size(127, 24);
            this.lblBirthdaySignUp.TabIndex = 53;
            this.lblBirthdaySignUp.Text = "Date Of Birth";
            // 
            // lblActivityTimeSignUp
            // 
            this.lblActivityTimeSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActivityTimeSignUp.AutoSize = true;
            this.lblActivityTimeSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
            this.lblActivityTimeSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityTimeSignUp.ForeColor = System.Drawing.Color.White;
            this.lblActivityTimeSignUp.Location = new System.Drawing.Point(473, 577);
            this.lblActivityTimeSignUp.Name = "lblActivityTimeSignUp";
            this.lblActivityTimeSignUp.Size = new System.Drawing.Size(120, 24);
            this.lblActivityTimeSignUp.TabIndex = 54;
            this.lblActivityTimeSignUp.Text = "Activity time";
            // 
            // lblSignUp
            // 
            this.lblSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(563, 12);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(209, 65);
            this.lblSignUp.TabIndex = 55;
            this.lblSignUp.Text = "Sign Up";
            // 
            // picBackground3
            // 
            this.picBackground3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackground3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackground3.BackgroundImage")));
            this.picBackground3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground3.Location = new System.Drawing.Point(71, 68);
            this.picBackground3.Name = "picBackground3";
            this.picBackground3.Size = new System.Drawing.Size(1203, 656);
            this.picBackground3.TabIndex = 56;
            this.picBackground3.TabStop = false;
            // 
            // tmrLiveTiles
            // 
            this.tmrLiveTiles.Interval = 4000;
            this.tmrLiveTiles.Tick += new System.EventHandler(this.tmrLiveTiles_Tick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAddSubject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 736);
            this.Controls.Add(this.mplScreens);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1350, 775);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Routine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mplScreens.ResumeLayout(false);
            this.mppMainScreen.ResumeLayout(false);
            this.mppMainScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            this.mppCoursesScreen.ResumeLayout(false);
            this.pnlAcademicYear.ResumeLayout(false);
            this.pnlAcademicYear.PerformLayout();
            this.pnlAddNewAcademicYear.ResumeLayout(false);
            this.pnlAddNewAcademicYear.PerformLayout();
            this.pnlEditAcademicYear.ResumeLayout(false);
            this.pnlEditAcademicYear.PerformLayout();
            this.pnlSemester.ResumeLayout(false);
            this.pnlSemester.PerformLayout();
            this.pnlAddSemester.ResumeLayout(false);
            this.pnlAddSemester.PerformLayout();
            this.pnlEditSemester.ResumeLayout(false);
            this.pnlEditSemester.PerformLayout();
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            this.pnlBackToAddingMode.ResumeLayout(false);
            this.pnlDeletecoursep.ResumeLayout(false);
            this.pnlCoursesToPresent.ResumeLayout(false);
            this.pnlCoursesToPresent.PerformLayout();
            this.pnlNoCourses.ResumeLayout(false);
            this.pnlNoCourses.PerformLayout();
            this.pnlLesson.ResumeLayout(false);
            this.pnlLesson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClassDuration)).EndInit();
            this.mppCalendarScreen.ResumeLayout(false);
            this.mppCalendarScreen.PerformLayout();
            this.mppLoginScreen.ResumeLayout(false);
            this.mppLoginScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyIcon)).EndInit();
            this.mppEditEventScreen.ResumeLayout(false);
            this.mppEditEventScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground2)).EndInit();
            this.mppAddEventScreen.ResumeLayout(false);
            this.mppAddEventScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground1)).EndInit();
            this.mppExamsScreen.ResumeLayout(false);
            this.pnlNoExams.ResumeLayout(false);
            this.pnlNoExams.PerformLayout();
            this.pnlSelectExam.ResumeLayout(false);
            this.pnlSelectExam.PerformLayout();
            this.pnlExams.ResumeLayout(false);
            this.pnlExams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamDuration)).EndInit();
            this.mppSettingsScreen.ResumeLayout(false);
            this.mppSettingsScreen.PerformLayout();
            this.mppTasksScreen.ResumeLayout(false);
            this.pnlTasks.ResumeLayout(false);
            this.pnlTasks.PerformLayout();
            this.pnlFreeTimeSearch.ResumeLayout(false);
            this.pnlFreeTimeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimateTime)).EndInit();
            this.pnlChooseTime.ResumeLayout(false);
            this.pnlChooseTime.PerformLayout();
            this.pnlCoverDisplayTask.ResumeLayout(false);
            this.pnlCoverDisplayTask.PerformLayout();
            this.pnlSelectTask.ResumeLayout(false);
            this.pnlSelectTask.PerformLayout();
            this.mppNotesScreen.ResumeLayout(false);
            this.mppNotesScreen.PerformLayout();
            this.mppSignUpScreen.ResumeLayout(false);
            this.mppSignUpScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MultiPanel mplScreens;
        private MultiPanelPage mppMainScreen;
        private MultiPanelPage mppCalendarScreen;
        private MultiPanelPage mppAddEventScreen;
        private MultiPanelPage mppEditEventScreen;
        private MultiPanelPage mppTasksScreen;
        private MultiPanelPage mppExamsScreen;
        private MultiPanelPage mppNotesScreen;
        private MultiPanelPage mppSettingsScreen;
        private MultiPanelPage mppSignUpScreen;
        private MultiPanelPage mppLoginScreen;
        private MultiPanelPage mppCoursesScreen;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.LinkLabel lklForgotPassword;
        private System.Windows.Forms.PictureBox picCompanyIcon;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblOr2;
        private System.Windows.Forms.Label lblOr3;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Label lblDashboard;
        private MetroFramework.Controls.MetroTile mtlTasks;
        private MetroFramework.Controls.MetroTile mtlExams;
        private MetroFramework.Controls.MetroTile mtlClasses;
        private MetroFramework.Controls.MetroTile mtlToday;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.Label lblNameFirstLetter;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Button btnCalendarBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblAddScheduleEvent;
        private System.Windows.Forms.Button btnAddEventBack;
        private System.Windows.Forms.Button btnAddEventSave;
        private System.Windows.Forms.Label lblAddEventTo;
        private System.Windows.Forms.Label lblAddEventTime;
        private System.Windows.Forms.Label lblAddEventTitle;
        private System.Windows.Forms.DateTimePicker dtpAddEventStartTime;
        private System.Windows.Forms.DateTimePicker dtpAddEventEndTime;
        private MetroFramework.Controls.MetroComboBox cboAddeventHowOften;
        private System.Windows.Forms.Label lblAddEventRepeats;
        private System.Windows.Forms.DateTimePicker dtpAddEventEndRepeated;
        private System.Windows.Forms.Label lblAddEventEnds;
        private System.Windows.Forms.Label lblAddEventDescription;
        private System.Windows.Forms.Label lblAddEventLocation;
        private MetroFramework.Controls.MetroComboBox cboEditEventHowOften;
        private System.Windows.Forms.DateTimePicker dtpEditEventEndRepeatedEvent;
        private System.Windows.Forms.DateTimePicker dtpEditEventEndTime;
        private System.Windows.Forms.DateTimePicker dtpEditEventStartTime;
        private System.Windows.Forms.Button btnEditEventBack;
        private System.Windows.Forms.Button btnEditEventSave;
        private System.Windows.Forms.Label lblEditEventEnds;
        private System.Windows.Forms.Label lblEditEventDescription;
        private System.Windows.Forms.Label lblEditEventTo;
        private System.Windows.Forms.Label lblEditEventLocation;
        private System.Windows.Forms.Label lblEditEventRepeats;
        private System.Windows.Forms.Label lblEditEventTime;
        private System.Windows.Forms.Label lblEditEventTitle;
        private System.Windows.Forms.Label lblEditEvent;
        private System.Windows.Forms.Label lblStudentRoutine;
        private System.Windows.Forms.Panel pnlAcademicYear;
        private System.Windows.Forms.Button btnBackToAcademicYear;
        private System.Windows.Forms.Button btnSaveAcademicYearPanel;
        private System.Windows.Forms.Label lblStartLesson;
        private System.Windows.Forms.Label lblAcademicYearStart;
        private System.Windows.Forms.Label lblAcademicYearEnd;
        private System.Windows.Forms.DateTimePicker dtpStartAcademicYear;
        private System.Windows.Forms.DateTimePicker dtpEndAcademicYear;
        private System.Windows.Forms.TextBox txtPractices;
        private System.Windows.Forms.TextBox txtLecturer;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.DateTimePicker dtpEndSemester;
        private System.Windows.Forms.DateTimePicker dtpStartSemester;
        private System.Windows.Forms.Label lblPractices;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.Label lblSemesterEnd;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSemesterStart;
        private System.Windows.Forms.Label lblAddCourse;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Panel pnlSemester;
        private System.Windows.Forms.Button btnSaveSemesrerPanel;
        private System.Windows.Forms.Button btnGoToCourse;
        private System.Windows.Forms.Label lblAcademicYearSemesterPanel;
        private System.Windows.Forms.Panel pnlCourse;
        private System.Windows.Forms.Button btnBackToSemester;
        private System.Windows.Forms.Button btnSaveCoursePanel;
        private System.Windows.Forms.Button btnGoToLesson;
        private System.Windows.Forms.Label lblSemesterCoursePanel;
        private System.Windows.Forms.Label lblAcademicYearCoursPanel;
        private System.Windows.Forms.Panel pnlLesson;
        private System.Windows.Forms.Button btnBackToCourse;
        private System.Windows.Forms.Button btnLessonPanelSave;
        private System.Windows.Forms.Button btnCoursesBack;
        private System.Windows.Forms.Label lblLessonPanelSemester;
        private System.Windows.Forms.Label lblLessonPanelAcademicYear;
        private System.Windows.Forms.Label lblLessonPanelType;
        private System.Windows.Forms.Label lblLessonPanelCourse;
        private System.Windows.Forms.Label lblNewTask;
        private System.Windows.Forms.Button btnTasksBack;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Label lblCourseTasksPage;
        private System.Windows.Forms.Label lblEstimateTime;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Panel pnlChooseTime;
        private System.Windows.Forms.DateTimePicker dtpEndTask;
        private System.Windows.Forms.DateTimePicker dtpStartTask;
        private System.Windows.Forms.Label lblEndTask;
        private System.Windows.Forms.Label lblStartTask;
        private System.Windows.Forms.Panel pnlFreeTimeSearch;
        private System.Windows.Forms.RadioButton rbtStartAndEndTask;
        private System.Windows.Forms.RadioButton rbtFreeTimeSearch;
        private System.Windows.Forms.NumericUpDown nudEstimateTime;
        private System.Windows.Forms.Label lblAvailableTime;
        private System.Windows.Forms.Panel pnlExams;
        private System.Windows.Forms.NumericUpDown nudExamDuration;
        private System.Windows.Forms.Button btnSaveExam;
        private System.Windows.Forms.DateTimePicker dtpExam;
        private System.Windows.Forms.Label lblNewExam;
        private System.Windows.Forms.Button btnExamBack;
        private System.Windows.Forms.Label lblDuartion;
        private System.Windows.Forms.Label lblExamsScreenCourse;
        private System.Windows.Forms.Label lblExams;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.TextBox txtSubjects;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnNotesBack;
        private System.Windows.Forms.DateTimePicker dtpStartActivity;
        private System.Windows.Forms.Button btnSettingsBack;
        private System.Windows.Forms.Label lblActivityTime;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.DateTimePicker dtpEndActivity;
        private System.Windows.Forms.Label lblEndActivity;
        private System.Windows.Forms.Label lblStartActivity;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblChangeEmail;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblPrivacy;
        private System.Windows.Forms.LinkLabel lklSavePassword;
        private System.Windows.Forms.LinkLabel lklSaveChanges;
        private System.Windows.Forms.LinkLabel lklSaveEmail;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblGashashim;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.DateTimePicker dtpBirthdaySignUp;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.TextBox txtConfirmPasswordSignUp;
        private System.Windows.Forms.TextBox txtEmailSignUp;
        private System.Windows.Forms.DateTimePicker dtpStartAcativitySignUp;
        private System.Windows.Forms.DateTimePicker dtpEndActivitySignUp;
        private System.Windows.Forms.Button btnSignUpBack;
        private System.Windows.Forms.Label lblConfirmPasswordSignUp;
        private System.Windows.Forms.Label lblPasswordSignUp;
        private System.Windows.Forms.Label lblToSignUp;
        private System.Windows.Forms.Label lblEmailSignUp;
        private System.Windows.Forms.Label lblBirthdaySignUp;
        private System.Windows.Forms.Label lblActivityTimeSignUp;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Label lblNextWeek;
        private System.Windows.Forms.Label lblLastWeek;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picBackground1;
        private System.Windows.Forms.PictureBox picBackground2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox picBackground3;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnGoToSemester;
        private System.Windows.Forms.Label lblSemester2;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblCourse2;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearNameAddPanel;
        private System.Windows.Forms.Label lblAcademicYearName;
        private System.Windows.Forms.Panel pnlEditSemester;
        private System.Windows.Forms.Button btnDeleteSemester;
        private System.Windows.Forms.Label lblChooseSemester;
        private System.Windows.Forms.DateTimePicker dtpStartLesson;
        private System.Windows.Forms.Panel pnlAddNewAcademicYear;
        private System.Windows.Forms.Panel pnlEditAcademicYear;
        private System.Windows.Forms.Button btnSaveEditedAcademicYear;
        private MetroFramework.Controls.MetroComboBox cboChooseExistAcademicYear;
        private System.Windows.Forms.Button btnDeleteAcademicYear;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearNameEditPanel;
        private System.Windows.Forms.DateTimePicker dtpStartAcademicYearEditPanel;
        private System.Windows.Forms.DateTimePicker dtpEndAcademicYearEditPanel;
        private System.Windows.Forms.Label lblEndAcademicYearEditpanel;
        private System.Windows.Forms.Label lblChooseAcademicYear;
        private System.Windows.Forms.Label lblYearNameEditPanel;
        private System.Windows.Forms.Label lblStartAcademicYearEditPanel;
        private System.Windows.Forms.RadioButton rbtEditAcademicYear;
        private System.Windows.Forms.RadioButton rbtAddAcademicYear;
        private System.Windows.Forms.RadioButton rbtAddSemester;
        private System.Windows.Forms.Panel pnlAddSemester;
        private System.Windows.Forms.RadioButton rbtEditSemester;
        private MetroFramework.Controls.MetroComboBox cboSemesterName;
        private System.Windows.Forms.Label lblSemesterName;
        private MetroFramework.Controls.MetroComboBox cboSemesterCoursePanel;
        private MetroFramework.Controls.MetroComboBox cboSemesterNameEditPanel;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearEditSemesterPanel;
        private System.Windows.Forms.Button btnSaveEditedSemester;
        private System.Windows.Forms.Label lblSemesterNameEditPanel;
        private System.Windows.Forms.Label lblEndSemesterEditPanel;
        private System.Windows.Forms.DateTimePicker dtpStartSemesterEditPanel;
        private System.Windows.Forms.Label lblStartSemesterEditPanel;
        private System.Windows.Forms.DateTimePicker dtpEndSemesterEditPanel;
        private System.Windows.Forms.Label lblAcademicYearSemesterEditPanel;
        private MetroFramework.Controls.MetroComboBox cboChooseSemester;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearSemesterPanel;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLogOut;
        private MetroFramework.Controls.MetroComboBox cboLessonPanelType;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearCoursePanel;
        private MetroFramework.Controls.MetroComboBox cboLessonPanelCourse;
        private MetroFramework.Controls.MetroComboBox cboLessonPanelSemester;
        private MetroFramework.Controls.MetroComboBox cboLessonPanelAcademicYear;
        private System.Windows.Forms.Panel pnlCoverDeleteCourse;
        private System.Windows.Forms.Panel pnlDeletecoursep;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Panel pnlBackToAddingMode;
        private System.Windows.Forms.Button btnBackToAddingMode;
        private System.Windows.Forms.Panel pnlBackToAddingModeCover;
        private System.Windows.Forms.Label lblNoCoursesYet;
        private System.Windows.Forms.Panel pnlNoCourses;
        private System.Windows.Forms.Panel pnlCoursesToPresent;
        private System.Windows.Forms.Label lblCoursesToPresent;
        private MetroFramework.Controls.MetroComboBox cboSemesterPresentCourse;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearPresentCourse;
        private System.Windows.Forms.RichTextBox rtfNote10;
        private System.Windows.Forms.RichTextBox rtfNote5;
        private System.Windows.Forms.RichTextBox rtfNote9;
        private System.Windows.Forms.RichTextBox rtfNote4;
        private System.Windows.Forms.RichTextBox rtfNote8;
        private System.Windows.Forms.RichTextBox rtfNote3;
        private System.Windows.Forms.RichTextBox rtfNote7;
        private System.Windows.Forms.RichTextBox rtfNote2;
        private System.Windows.Forms.RichTextBox rtfNote6;
        private System.Windows.Forms.RichTextBox rtfNote1;
        private Button btnRemoveNote;
        private CalendarControl.CalendarControl cclUserCalendar;
        private Button btnCurrentWeek;
        private DateTimePicker dtpChooseDate;
        private Label lblSelectDate;
        private Button btnDelete;
        private Button btnEdit;
        private CheckBox chkAddEventAllDay;
        private CheckBox chkEditEventAllDay;
        private CalendarControl.CalendarControl cclMainCalendar;
        private Label lblAddNewClass;
        private NumericUpDown nudClassDuration;
        private Label lblDuration;
        private TextBox txtLocationClass;
        private Label lblLocationClass;
        private Panel pnlSelectTask;
        private Label lblSelectTask;
        private MetroFramework.Controls.MetroComboBox cboCourseDisplayTaskPanel;
        private MetroFramework.Controls.MetroComboBox cboSemesterDisplayTaskPanel;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearDisplayTaskPanel;
        private Button btnBackToAddingTask;
        private Button btnDeleteTask;
        private ListBox lstTasks;
        private Panel pnlCoverDisplayTask;
        private Label lblNoTasksYet;
        private MetroFramework.Controls.MetroComboBox cboCourseTaskPanel;
        private ListBox lstExams;
        private Panel pnlNoExams;
        private Label lblNoExams;
        private Panel pnlSelectExam;
        private Label lblSelectExam;
        private MetroFramework.Controls.MetroComboBox cboCourseDisplayExamPanel;
        private MetroFramework.Controls.MetroComboBox cboSemesterDisplayExamPanel;
        private MetroFramework.Controls.MetroComboBox cboAcademicYearDisplayExamPanel;
        private MetroFramework.Controls.MetroComboBox cboChooseCourseExamPage;
        private Label lblStartExam;
        private Label lblExamTitle;
        private Button btnDeleteExam;
        private Button btnBackToAddingExam;
        private TextBox txtExamTitle;
        private TextBox txtExamLocation;
        private Label lblExamLocation;
        private Button btnDeleteSubject;
        private Timer tmrLiveTiles;
        private MetroFramework.Controls.MetroTile mtlToday2;
        private MetroFramework.Controls.MetroTile mtlTasks2;
        private MetroFramework.Controls.MetroTile mtlExams2;
        private MetroFramework.Controls.MetroTile mtlClasses2;
        private TextBox txtConfirmNewPassword;
        private Label lblConfirmNewPassword;
        private Button btnShare;
        private MetroFramework.Controls.MetroComboBox cboExamTimeUnit;
        private MetroFramework.Controls.MetroComboBox cboEstimateTimeUnit;
        private MetroFramework.Controls.MetroComboBox cboLessonTimeUnit;
        private Button btnFreeTimeSearch;
        private Label lblAddNote;
        private Label lblRemoveNote;
        private RichTextBox rtfEditEventTitle;
        private RichTextBox rtfEditEventLocation;
        private RichTextBox rtfEditEventDescription;
        private RichTextBox rtfAddEventTitle;
        private RichTextBox txtAddEventDescription;
        private RichTextBox txtAddEventLocation;
    }
}

