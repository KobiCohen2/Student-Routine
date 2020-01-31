using System;

namespace Calendar_Module
{
    [Serializable]
    public class TimeRecord
    {
        private DateTime startTime, endTime;

        //Empty Constructor
        public TimeRecord()
        {

        }//end Constructor 

        //Constructor
        public TimeRecord(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }//end Constructor

        #region Properties
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                this.startTime = value;
            }

        }


        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                this.endTime = value;
            }

        }

        public TimeSpan TimeSpan
        {
            get
            {
                return (endTime.Subtract(startTime));
            }
            set { }
        }
        #endregion Properties

    }//end class
}//end namespace
