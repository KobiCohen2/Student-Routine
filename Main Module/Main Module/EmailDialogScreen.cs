using Calendar_Module;
using System;
using System.Threading;
using System.Windows.Forms;
namespace Main_Module
{
    public partial class EmailDialogScreen : Form
    {
        private int index;
        private string email;
        private bool shareMode;
        private string userName;
        private string emailMessage;
        private string emailTitle;
        private ScheduleEvent shareScheduleEvent;
        private Thread emailSendThread;

        public EmailDialogScreen()
        {
            InitializeComponent();
        }

        #region Methods

        private void EmailDialogScreen_Load(object sender, EventArgs e)
        {
            //prepare from for share mode
            if (shareMode)
            {
                this.Text = "Share Event";
                this.Icon = Properties.Resources._1493072528_share1;
                lblForgorpassword1.Text = "Enter a friend's email, you'll want to share an event";
                lblForgotPassword2.Visible = false;

            }
            else//prepare form for forgot password mode
            {
                this.Text = "Forgot Password";
                this.Icon = Properties.Resources._1491165747_user_close_security;
                lblForgorpassword1.Text = "Enter the email address you use to sign in to Student Routine,";
                lblForgotPassword2.Visible = true;
            }


            //alllign label
            lblForgorpassword1.Left = (this.ClientRectangle.Width - lblForgorpassword1.Width) / 2;
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            email = txtForgotPasswordEmail.Text;

            if (email == "" || email == "Email")
            {
                MessageBox.Show("Please enter an email");
                return;
            }

            if (!MailService.IsValidEmail(email))
            {
                MessageBox.Show("Email is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (shareMode)
            {
                emailMessage = this.shareScheduleEvent.ToString();
                emailTitle = this.userName + " shared an event with you";
                emailSendThread = new Thread(EmailSend);
                emailSendThread.Start();
                DialogResult result = MessageBox.Show("The event was successfully sent to your friend");

                if (result == DialogResult.OK)
                    this.Close();

            }
            else
            {
                index = StudentRoutine.IsMember(email);

                if (index == -1)
                {
                    MessageBox.Show("Email does not exist in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    emailMessage = string.Format("\u200EYour password is: {0}.", StudentRoutine.Users[index].Password);
                    emailTitle = "Forgot Password";
                    emailSendThread = new Thread(EmailSend);
                    emailSendThread.Start();
                    DialogResult result = MessageBox.Show("Password successfully sent, please check your email account");

                    if (result == DialogResult.OK)
                        this.Close();
                }
            }
        }

        private void EmailSend()
        {
            try
            {
                MailService.EmailSender(email, emailMessage, emailTitle);
            }
            catch (Exception)
            {
                MessageBox.Show("There is a problem with the system. Please try again later");
            }
        }

        #endregion

        #region Properties
        public bool ShareMode
        {
            get
            {
                return this.shareMode;
            }
            set
            {
                this.shareMode = value;
            }
        }

        public ScheduleEvent ShareScheduleEvent
        {
            set
            {
                this.shareScheduleEvent = value;
            }
        }

        public string UserName
        {
            set
            {
                this.userName = value;
            }
        }
        #endregion
    }
}
