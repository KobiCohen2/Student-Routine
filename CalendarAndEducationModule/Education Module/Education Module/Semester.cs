using Calendar_Module;
using System;
using System.Collections.Generic;

namespace Education_Module
{
    [Serializable]
    public class Semester : TimeRecord , IComparable<Semester>
    {
        public enum SemesterName { SemesterA, SemesterB, SemesterC };
        private SemesterName name;
        private List<Course> courses;

        //Empty Constructor
        public Semester()
        {

        }//end constructor

        //Constructor
        public Semester(DateTime startTime, DateTime endTime, SemesterName semesterName) : base(startTime, endTime)
        {
            courses = new List<Course>();//intialize list
            this.name = semesterName;
        }//end Constructor

        #region Methods
        //Adding method
        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }//end method

        //Removing method
        public void RemoveCourse(Course course)
        {
            if (!this.courses.Contains(course))
            {
                throw new KeyNotFoundException();
            }
            this.courses.Remove(course);
        }//end method

        //Override ToString
        public override string ToString()
        {
            return String.Format("{0}", this.name);
        }//end method

        //My ToString
        public string ToString(string f)
        {
            return String.Format("{0} {1} - {2}", this.name, this.StartTime.ToString("d"), this.EndTime.ToString("d"));
        }//end method

        //CompareTo method for List<T>.Sort()
        public int CompareTo(Semester other)
        {
            if (this.StartTime == other.StartTime)
                return 0;
            else if (this.StartTime > other.StartTime)
                return -1;
            return 1;
        }//end method

        #endregion Methods

        #region Properties
        public SemesterName Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
        #endregion Properties
    }//end class
}//end namespace
