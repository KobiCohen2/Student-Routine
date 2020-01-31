using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar_Module
{
    [Serializable]
    public class Calendar
    {
        private Dictionary<DateTime, List<ScheduleEvent>> days;
        private string owner;

        //empty Constructor
        public Calendar()
        {

        }//end Constructor

        //Constructor
        public Calendar(string owner)
        {
            this.days = new Dictionary<DateTime, List<ScheduleEvent>>();
            this.owner = owner;
        }//end Constructor

        #region Methods
        //GetDays method
        public List<List<ScheduleEvent>> GetDays(DateTime start, DateTime end)
        {
            List<List<ScheduleEvent>> selectedDays = new List<List<ScheduleEvent>>();
            TimeSpan interval = TimeSpan.FromDays((double)ScheduleEvent.Period.Daily);
            while (start.Date <= end.Date)
            {
                try
                {
                    selectedDays.Add(GetDay(start));
                }
                catch (KeyNotFoundException)
                {

                }
                start += interval;
            }
            return selectedDays;
        }//end method

        //Overload GetDays method
        public List<List<ScheduleEvent>> GetDays(DateTime start, int amount)
        {
            DateTime end = start + TimeSpan.FromDays(amount);
            return GetDays(start, end);
        }//end method

        //GetDay method
        public List<ScheduleEvent> GetDay(DateTime date)
        {
            if (!days.ContainsKey(date.Date))
            {
                throw new KeyNotFoundException();
            }
            return this.days[date.Date];
        }//end method

        //GetLasSunday method
        public static DateTime GetLastSunday()
        {
            DateTime sundayOfCurrentWeek = DateTime.Today;
            TimeSpan deccrementor = TimeSpan.FromDays(1);
            while (sundayOfCurrentWeek.DayOfWeek != DayOfWeek.Sunday)
            {
                sundayOfCurrentWeek -= deccrementor;
            }
            return sundayOfCurrentWeek;
        }//end method

        //GetCurrentWeek method
        public List<List<ScheduleEvent>> GetCurrentWeek()
        {
            DateTime sundayOfCurrentWeek = GetLastSunday();
            return (GetDays(sundayOfCurrentWeek, 6));
        }//end method

        //AddScheduleEvent method
        public void AddScheduleEvent(ScheduleEvent scheduleEvent)
        {
            if (scheduleEvent.EndTime - scheduleEvent.StartTime < TimeSpan.FromMinutes(25))
            {
                throw new DateMissMatchException();
            }
            else if (scheduleEvent.StartTime.Date == scheduleEvent.EndTime.Date)
            {
                AddToDictionary(scheduleEvent);
            }
            else
            {
                List<ScheduleEvent> dailyReapetedEvents;
                DateTime endTime = new DateTime(scheduleEvent.StartTime.Year, scheduleEvent.StartTime.Month, scheduleEvent.StartTime.Day, 23, 59, 59);
                ScheduleEvent se = new ScheduleEvent(scheduleEvent.StartTime, endTime,
                                                     scheduleEvent.Title, scheduleEvent.Location,
                                                     scheduleEvent.Description, ScheduleEvent.Period.Daily, scheduleEvent.EndTime.Date, out dailyReapetedEvents);
                ScheduleEvent nextScheduleEvent = dailyReapetedEvents[0];

                ScheduleEvent lasScheduleEvent = dailyReapetedEvents[dailyReapetedEvents.Count - 1];

                lasScheduleEvent.EndTime = scheduleEvent.EndTime;

                ScheduleEvent firstScheduleEvent = nextScheduleEvent;

                DateTime firstScheduleEventStartTime = nextScheduleEvent.StartTime.Date;

                while (nextScheduleEvent != null)
                {
                    //An event that spreads over more than one day is not a recurring event
                    nextScheduleEvent.HowOften = ScheduleEvent.Period.None;
                    nextScheduleEvent.EndReapetedEvent = firstScheduleEventStartTime;

                    if (nextScheduleEvent != firstScheduleEvent)
                    {
                        DateTime startTime = nextScheduleEvent.StartTime;
                        nextScheduleEvent.StartTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 00, 00, 0);
                    }
                    AddToDictionary(nextScheduleEvent);
                    nextScheduleEvent = nextScheduleEvent.Next;
                }
            }
        }//end method

        //Service method
        private void AddToDictionary(ScheduleEvent scheduleEvent)
        {
            if (days.ContainsKey(scheduleEvent.StartTime.Date))
            {
                this.days[scheduleEvent.StartTime.Date].Add(scheduleEvent);
                this.days[scheduleEvent.StartTime.Date].Sort();
            }
            else
            {
                List<ScheduleEvent> day = new List<ScheduleEvent>();
                day.Add(scheduleEvent);
                day.Sort();
                days.Add(scheduleEvent.StartTime.Date, day);
            }
        }//end method

        //AddScheduleEvents method 
        public void AddScheduleEvents(List<ScheduleEvent> scheduleEvents)
        {
            foreach (ScheduleEvent se in scheduleEvents)
            {
                AddScheduleEvent(se);
            }
        }//end method 

        //Overload AddScheduleEvent
        public void AddScheduleEvent(DateTime startTime, DateTime endTime, string title,
                             string location, string description, ScheduleEvent.Period howOften,
                             DateTime endReapetedEvent)
        {
            List<ScheduleEvent> temp;
            ScheduleEvent se = new ScheduleEvent(startTime, endTime, title, location, description, howOften, endReapetedEvent, out temp);
            AddScheduleEvents(temp);
        }//end method

        //Overload AddScheduleEvent
        public void AddScheduleEvent(DateTime startTime, DateTime endTime, string title,
                             string location, string description)
        {
            AddScheduleEvent(startTime, endTime, title, location, description, ScheduleEvent.Period.None, endTime);
        }//end method

        //RemoveScheduleEvents method 
        public void RemoveScheduleEvents(List<ScheduleEvent> scheduleEvents)
        {
            foreach (ScheduleEvent se in scheduleEvents)
            {
                RemoveScheduleEvent(se);
            }
        }//end method

        //Remove the following events in the series method
        public void RemoveFollowingScheduleEventsInSeries(ScheduleEvent scheduleEvent)
        {
            ScheduleEvent nextScheduleEvent;

            while (scheduleEvent != null)
            {
                nextScheduleEvent = scheduleEvent.Next;
                RemoveScheduleEvent(scheduleEvent);
                scheduleEvent = nextScheduleEvent;
            }
        }//end method

        //Remove the all schedule events in the Series
        public void RemoveAllScheduleEventsInSeries(ScheduleEvent scheduleEvent)
        {
            //remove all subsequent events starting with the first event, i.e all series
            RemoveFollowingScheduleEventsInSeries(scheduleEvent.First);

        }//end method

        //Remove Schedule Event method
        public void RemoveScheduleEvent(ScheduleEvent scheduleEvent)
        {
            if (!days.ContainsKey(scheduleEvent.StartTime.Date))
            {
                throw new KeyNotFoundException();
            }

            //fix references
            if (scheduleEvent.Previous != null)
            {
                scheduleEvent.Previous.Next = scheduleEvent.Next;
            }

            if (scheduleEvent.Next != null)
            {
                scheduleEvent.Next.Previous = scheduleEvent.Previous;
            }

            //remove from dictionary
            this.days[scheduleEvent.StartTime.Date].Remove(scheduleEvent);
            days[scheduleEvent.StartTime.Date].Sort();

        }//end method

        //Get key of a value method
        public DateTime GetKey(List<ScheduleEvent> day)
        {
            foreach (DateTime date in days.Keys)
            {
                if (days[date] == day)
                {
                    return date;
                }
            }
            throw new KeyNotFoundException();
        }//end method

        //Override ToString
        public override string ToString()
        {
            return String.Format("{0}'s Calendar", owner);
        }//end method

        //string to date method
        private DateTime StringToDate(string date)
        {
            List<string> seprarateDate = new List<string>();
            seprarateDate = date.Split('/').ToList<string>();
            return new DateTime(int.Parse(seprarateDate[2]), int.Parse(seprarateDate[1]), int.Parse(seprarateDate[0]));
        }//end method

        #endregion Methods

        #region Property
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public Dictionary<DateTime, List<ScheduleEvent>> Days
        {
            get
            {
                return this.days;
            }
            set
            {
                this.days = value;
            }
        }
        #endregion Property

        #region Indexers
        public List<ScheduleEvent> this[DateTime date]
        {
            get
            {
                if (!days.ContainsKey(date.Date))
                {
                    throw new KeyNotFoundException();
                }
                return this.days[date.Date];
            }
            set
            {
                if (days.ContainsKey(date.Date))
                {
                    this.days[date.Date] = value;
                }
                this.days.Add(date.Date, value);
            }
        }
        public List<ScheduleEvent> this[string date]
        {
            get
            {
                return this[StringToDate(date).Date];
            }
            set
            {
                this[StringToDate(date).Date] = value;
            }
        }
        #endregion Indexers 
    }//end class
}//end namespace
