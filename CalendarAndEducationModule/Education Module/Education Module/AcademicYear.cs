using Calendar_Module;
using System;
using System.Collections.Generic;
namespace Education_Module
{
    [Serializable]
    public class AcademicYear : TimeRecord , IComparable<AcademicYear>
    {
        public enum AcademicYearName { FirstYear, SecondYear, ThirdYear, FourthYear, FifthYear, SixthYear, SeventhYear };
        private AcademicYearName name;
        private List<Semester> semesters;

        //Empty Constructor
        public AcademicYear()
        {

        }//end Constructor

        //Constructor
        public AcademicYear(DateTime startTime, DateTime endTime, AcademicYearName name) : base(startTime, endTime)
        {
            this.name = name;
            this.semesters = new List<Semester>(); //initialize list
        }//end Constructor

        #region Methods
        //Add Semester method
        public void AddSemester(Semester semester)
        {
            this.semesters.Add(semester);
        }//end method

        //Remove Semester method
        public void RemoveSemester(Semester semester)
        {
            if (!this.semesters.Contains(semester))
            {
                throw new KeyNotFoundException();
            }
            this.semesters.Remove(semester);
        }//end method

        //override ToString
        public override string ToString()
        {
            return string.Format("{0}", this.name);
        }//end method

         //CompareTo method for List<T>.Sort()
        public int CompareTo(AcademicYear other)
        {
            if (this.StartTime == other.StartTime)
                return 0;
            else if (this.StartTime > other.StartTime)
                return -1;
            return 1;
        }//end method
        #endregion Methods

        #region Properties
        public AcademicYearName Name
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
        public List<Semester> Semsters
        {
            get
            {
                return this.semesters;
            }
            set
            {
                this.semesters = value;
            }
        }
        #endregion Properties

    }//end class
}//end namespace
