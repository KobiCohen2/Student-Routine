using System;
using System.Collections.Generic;
using System.Drawing;

namespace Calendar_Module
{
    [Serializable]
    public class ScheduleEvent : TimeRecord, IComparable<ScheduleEvent>
    {
        public enum Period { None, Daily, Weekly = 7, Monthly };
        private string title;
        private string location;
        private string description;
        private DateTime endReapetedEvent;
        private Period howOften;
        private ScheduleEvent next = null;
        private ScheduleEvent previous = null;
        private object lesson;
        private object task;
        private bool isExam;
        private Color color = Color.Black; // null color

        //Empty Constructor
        public ScheduleEvent()
        {

        }//end constructor

        //Single Schedule Event Constructor
        public ScheduleEvent(DateTime startTime, DateTime endTime, string title,
                             string location, string description, Period howOften, DateTime endReapetedEvent) : base(startTime, endTime)
        {
            this.title = title;
            this.location = location;
            this.description = description;
            this.howOften = howOften;
            this.endReapetedEvent = endReapetedEvent;
        }//end Constructor

        //Reapeted Schedule Event Constructor
        public ScheduleEvent(DateTime startTime, DateTime endTime, string title,
                             string location, string description, Period howOften,
                             DateTime endReapetedEvent, out List<ScheduleEvent> reapetedEvents) : base(startTime, endTime)
        {
            //schedule events series
            reapetedEvents = new List<ScheduleEvent>();

            //the first schedule event in the series
            ScheduleEvent firstScheduleEvent = null;

            //the next schedule event in the series
            ScheduleEvent nextScheduleEvent;

            if (howOften == Period.None)
            {
                reapetedEvents.Add(new ScheduleEvent(startTime, endTime, title, location, description, howOften, endReapetedEvent));
            }
            else if (howOften == Period.Daily)
            {
                DateTime incrementor = startTime;

                firstScheduleEvent = new ScheduleEvent(incrementor, endTime, title, location, description, howOften, endReapetedEvent);

                while (incrementor.Date < endReapetedEvent.Date)
                {
                    incrementor += TimeSpan.FromDays((double)Period.Daily);
                    endTime = endTime.AddDays((double)Period.Daily);

                    nextScheduleEvent = new ScheduleEvent(incrementor, endTime, title, location, description, howOften, endReapetedEvent);

                    //set references
                    firstScheduleEvent.Next = nextScheduleEvent;
                    nextScheduleEvent.Previous = firstScheduleEvent;

                    //add to the series
                    reapetedEvents.Add(firstScheduleEvent);

                    firstScheduleEvent = nextScheduleEvent;
                }

                //add the last schedule event in the series
                reapetedEvents.Add(firstScheduleEvent);
            }
            else if (howOften == Period.Weekly)
            {
                DateTime incrementor = startTime;

                firstScheduleEvent = new ScheduleEvent(incrementor, endTime, title, location, description, howOften, endReapetedEvent);

                //increment dates for the first time
                incrementor += TimeSpan.FromDays((double)Period.Weekly);
                endTime = endTime.AddDays((double)Period.Weekly);

                while (incrementor.Date <= endReapetedEvent.Date)
                {
                    nextScheduleEvent = new ScheduleEvent(incrementor, endTime, title, location, description, howOften, endReapetedEvent);

                    //set references
                    firstScheduleEvent.Next = nextScheduleEvent;
                    nextScheduleEvent.Previous = firstScheduleEvent;

                    //add to the series
                    reapetedEvents.Add(firstScheduleEvent);

                    firstScheduleEvent = nextScheduleEvent;

                    incrementor += TimeSpan.FromDays((double)Period.Weekly);
                    endTime = endTime.AddDays((double)Period.Weekly);
                }

                //add the last schedule event in the series
                reapetedEvents.Add(firstScheduleEvent);
            }
            else
            {
                DateTime incrementor = startTime;

                firstScheduleEvent = new ScheduleEvent(incrementor, endTime, title, location, description, howOften, endReapetedEvent);

                //increment dates for the first time
                TimeSpan daysInMonth = TimeSpan.FromDays(DateTime.DaysInMonth(incrementor.Year, incrementor.Month));
                incrementor += daysInMonth;
                endTime += daysInMonth;

                while (incrementor.Date <= endReapetedEvent.Date)
                {
                    nextScheduleEvent = new ScheduleEvent(incrementor, endTime, title, location, description, howOften, endReapetedEvent);

                    //set references
                    firstScheduleEvent.Next = nextScheduleEvent;
                    nextScheduleEvent.Previous = firstScheduleEvent;

                    //add to the series
                    reapetedEvents.Add(firstScheduleEvent);

                    firstScheduleEvent = nextScheduleEvent;

                    daysInMonth = TimeSpan.FromDays(DateTime.DaysInMonth(incrementor.Year, incrementor.Month));
                    incrementor += daysInMonth;
                    endTime += daysInMonth;

                }
                //add the last schedule event in the series
                reapetedEvents.Add(firstScheduleEvent);
            }

        }//end Constructor

        //CompareTo method for List<T>.Sort()
        public int CompareTo(ScheduleEvent other)
        {
            if (this.StartTime.TimeOfDay == other.StartTime.TimeOfDay)
                return 0;
            else if (this.StartTime.TimeOfDay > other.StartTime.TimeOfDay)
                return 1;
            return -1;
        }//end method

        #region Properties
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public ScheduleEvent Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }

        public ScheduleEvent Previous
        {
            get
            {
                return this.previous;
            }
            set
            {
                this.previous = value;
            }
        }

        public ScheduleEvent First
        {
            get
            {
                ScheduleEvent firstScheduleEventInSeries = null;
                ScheduleEvent scheduleEvent = this;
                //find the first schedule event in the series
                while (scheduleEvent != null)
                {
                    firstScheduleEventInSeries = scheduleEvent;
                    scheduleEvent = scheduleEvent.Previous;
                }

                return firstScheduleEventInSeries;
            }

        }

        public ScheduleEvent Last
        {
            get
            {
                ScheduleEvent lastScheduleEventInSeries = null;
                ScheduleEvent scheduleEvent = this;
                //find the first schedule event in the series
                while (scheduleEvent != null)
                {
                    lastScheduleEventInSeries = scheduleEvent;
                    scheduleEvent = scheduleEvent.Next;
                }

                return lastScheduleEventInSeries;
            }
        }

        public object Lesson
        {
            get
            {
                return this.lesson;
            }
            set
            {
                this.lesson = value;
            }
        }

        public object Task
        {
            get
            {
                return this.task;
            }
            set
            {
                this.task = value;
            }
        }

        public bool IsExam
        {
            get
            {
                return this.isExam;
            }
            set
            {
                this.isExam = value;
            }
        }
        public Period HowOften
        {
            get
            {
                return this.howOften;
            }
            set
            {
                this.howOften = value;
            }
        }

        public DateTime EndReapetedEvent
        {
            get
            {
                return this.endReapetedEvent;
            }
            set
            {
                this.endReapetedEvent = value;
            }
        }

        public bool AllDay
        {
            get
            {
                DateTime startOfDay = this.StartTime.Date;
                DateTime endOfDay = this.StartTime.Date +
                    TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59) +
                    TimeSpan.FromSeconds(59);

                return (this.StartTime == startOfDay && this.EndTime == endOfDay);
            }

        }

        public bool IsMoreThan1Day
        {
            get
            {   if (this.IsBelongsToSeries && this.howOften == Period.None)
                    return true;                                                                
                else
                    return false;
            }
        }

        public bool IsBelongsToSeries
        {
            get
            {
                if (this.next == null && this.previous == null)
                    return false;

                return true;
            }
        }

        public Color Color
        {
            get
            {
                if (this.Lesson != null)
                    return System.Drawing.Color.MediumSlateBlue;
                else if (this.Task != null)
                    return System.Drawing.Color.Orchid;
                else if (this.title == "\u200EFree Time")
                    return System.Drawing.Color.GreenYellow;
                else if (this.IsExam == true)
                    return System.Drawing.Color.LightSeaGreen;

                return color;
            }
            set
            {
                color = value;
            }
        }
        #endregion Properties

        //Override ToString
        public override string ToString()
        {
            if (this.AllDay)
                return string.Format("{0}", this.title);

            return string.Format("{0} \n{1} \n{2}", this.title, this.location, this.description);
        }//end method 

    }//end class
}//end namespace
