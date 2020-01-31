using Calendar_Module;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Education_Module
{
    [Serializable]
    public class Exam : ScheduleEvent , IComparable<Exam>
    {
        private List<string> subjects;
   
        //Empty Constructor
        public Exam()
        {

        }//end Constructor

        //Constructor
        public Exam(DateTime startTime, DateTime endTime, string title,
                             string location, string description, Period howOften,
                             DateTime endReapetedEvent,string[] subjects) : 
                             base(startTime,endTime,title,location,description,howOften,endReapetedEvent)
           
        {
            this.subjects = new List<string>();
            this.subjects.AddRange(subjects);
        }//end Constructor

        #region Methods

        //CompareTo method for List<T>.Sort()
        public int CompareTo(Exam other)
        {
            if (this.StartTime == other.StartTime)
                return 0;
            else if (this.StartTime > other.StartTime)
                return 1;
            return -1;
        }//end method

        //Override ToString
        public override string ToString()
        {
            string subjects = "";
            string hebrewString = "מועד: ";
            string hebrewString2 = "נושאים: ";
            string hebrewString3 = "מיקום: ";

            for(int i = 0; i<this.subjects.Count; i++)
            {
                if (i == this.subjects.Count - 1)
                {
                    subjects += this.subjects[i];
                    break;
                }
                    
                subjects += this.subjects[i] + ", ";
            }

            if(this.subjects.Count != 0)
            {
                return String.Format("{0}\n{1}\n{2}{3} - {4}\n{5}{6}\n", this.Description,
                this.Title, hebrewString, this.StartTime.ToString("dddd dd/M/yyyy HH:mm"),
                this.EndTime.ToString("HH:mm"), hebrewString3,this.Location) + hebrewString2 + subjects;
            }

            return String.Format("{0}\n{1}\n{2}{3} - {4}\n{5}{6}\n", this.Description,
                this.Title, hebrewString, this.StartTime.ToString("dddd dd/M/yyyy HH:mm"),
                this.EndTime.ToString("HH:mm"), hebrewString3,this.Location);
        }
        #endregion Methods

        #region Properties
        public List<string> Subjects
        {
            get
            {
                return this.subjects;
            }
            set
            {
                this.subjects = value;
            }
        }
        #endregion Properties

    }//end class
}//end namespace
