using Calendar_Module;
using System;

namespace Main_Module
{
    [Serializable]
    public class User
    {
        private UserData userData;
        private string fullName;
        private string email;
        private string password;
        private TimeRecord activityTime;
        private DateTime dateOfBirth;
        private DateTime nextBitrthday;

        //Empty Constructor
        public User()
        {

        }//end Constructor

        //Constructor
        public User(string fullName, string email, string password, TimeRecord activityTime, DateTime dateOfBirth)
        {
            this.fullName = fullName;
            this.email = email;
            this.password = password;
            this.activityTime = activityTime;
            this.dateOfBirth = dateOfBirth;
        }//end Constructor

        #region Properties
        public UserData UserData
        {
            get
            {
                return this.userData;
            }
            set
            {
                this.userData = value;
            }
        }
        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        public TimeRecord ActivityTime
        {
            get
            {
                return this.activityTime;
            }
            set
            {
                this.activityTime = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }
        public DateTime NextBirthday
        {
            get
            {
                return this.nextBitrthday;
            }
            set
            {
                this.nextBitrthday = value;
            }
        }
        #endregion Properties
    }//end class
}//end namespace
