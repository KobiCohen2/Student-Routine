using Calendar_Module;
using System;
using System.Collections.Generic;

namespace Education_Module
{
    [Serializable]
    public class Task : IComparable<Task>
    {
        private string name;
        private DateTime deadline;
        private string courseName;
        private ScheduleEvent workOnTask;

        //Empty Constructor
        public Task()
        {

        }//end constructor

        //Constructor
        public Task(string name, DateTime deadline, string courseName)
        {
            this.name = name;
            this.deadline = deadline;
            this.courseName = courseName;
        }//end Constructor

        #region Methods

        //method that searchs free times in user calendar
        public static List<ScheduleEvent> FreeTimeSearch(Calendar c, TimeRecord activityTime, TimeSpan estimateTime, DateTime deadline)
        {
            List<ScheduleEvent> freeTime = new List<ScheduleEvent>();
            TimeSpan dayInterval = TimeSpan.FromDays(1);
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            DateTime endOfDay = new DateTime(today.Year, today.Month, today.Day, activityTime.EndTime.Hour, activityTime.EndTime.Minute, activityTime.EndTime.Second);
            TimeSpan thirtyMinutes = TimeSpan.FromMinutes(30);
            List<ScheduleEvent> day = new List<ScheduleEvent>();
            DateTime floorDeadline = new DateTime(deadline.Year, deadline.Month, deadline.Day, deadline.Hour, deadline.Second, 0);
            while (today.Date <= floorDeadline.Date)
            {
                try
                {
                    day = c[today.Date];
                }
                catch (KeyNotFoundException)
                {

                }
                if (day.Count != 0)
                {
                    for (DateTime i = today; i <= endOfDay; i += thirtyMinutes)
                    {
                        bool free = false;

                        if ((i + estimateTime).TimeOfDay > floorDeadline.TimeOfDay && today.Date == floorDeadline.Date)
                            break;

                        if ((i + estimateTime).TimeOfDay > activityTime.EndTime.TimeOfDay)
                            break;

                        foreach (ScheduleEvent se in day)
                        {
                            if ((i.TimeOfDay >= se.EndTime.TimeOfDay) || (((i + estimateTime).TimeOfDay) <= se.StartTime.TimeOfDay))
                            {
                                free = true;
                            }
                            else
                            {
                                free = false;
                                break;
                            }
                        }

                        if (free)
                        {
                            freeTime.Add(new ScheduleEvent(i, i + estimateTime, "\u200EFree Time", i.ToString("HH:mm") + " - " + (i + estimateTime).ToString("HH: mm"),
                                "", ScheduleEvent.Period.None, i));
                        }

                    }
                }
                else
                {
                    for (DateTime i = today; i <= endOfDay; i += thirtyMinutes)
                    {
                        if ((i + estimateTime).TimeOfDay > floorDeadline.TimeOfDay && today.Date == floorDeadline.Date)
                            break;


                        if ((i + estimateTime).TimeOfDay > activityTime.EndTime.TimeOfDay)
                            break;

                        freeTime.Add(new ScheduleEvent(i, i + estimateTime, "\u200EFree Time", i.ToString("HH:mm") + " - " + (i + estimateTime).ToString("HH: mm"),
                            "", ScheduleEvent.Period.None, i));
                    }
                }

                today = new DateTime(today.Year, today.Month, today.Day, activityTime.StartTime.Hour, activityTime.StartTime.Minute, activityTime.StartTime.Second);
                today += dayInterval;
                endOfDay += dayInterval;
            }

            return freeTime;
        }//end method


        //CompareTo method for List<T>.Sort()
        public int CompareTo(Task other)
        {
            if (this.deadline == other.deadline)
                return 0;
            else if (this.deadline > other.deadline)
                return 1;
            return -1;
        }//end method

        //Override ToString
        public override string ToString()
        {
            string result = "";
            string hebrewString1 = "מועד הגשה: ";
            string hebrewString2 = "ביצוע מטלה: ";
            string workOnTaskString = "";

            result = string.Format("{0}\n{1}\n{2}{3}", this.name, this.courseName, hebrewString1,
                deadline.ToString("dddd dd/M/yyyy HH:mm"));

            if (this.workOnTask != null)
            {
                DateTime end = this.workOnTask.IsMoreThan1Day ? this.workOnTask.Last.EndTime : this.workOnTask.EndTime;
                workOnTaskString = string.Format("\n{0}{1} - {2}", hebrewString2, this.workOnTask.StartTime.ToString("dddd dd/M HH:mm"),
                    end.ToString("HH:mm"));
            }

            return result + workOnTaskString;

        }//end method

        #endregion Methods

        #region Properties
        public string Name
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

        public DateTime Deadline
        {
            get
            {
                return this.deadline;
            }
            set
            {
                this.deadline = value;
            }
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                this.courseName = value;
            }
        }

        public ScheduleEvent WorkOnTask
        {
            get
            {
                try
                {
                    return this.workOnTask;
                }
                catch (Exception) { return null; }
            }
            set
            {
                this.workOnTask = value;
            }
        }
        #endregion Properties


    }//end class
}//end namespace
