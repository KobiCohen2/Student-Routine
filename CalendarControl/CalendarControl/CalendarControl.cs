using Calendar_Module;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using System.Drawing;

namespace CalendarControl
{


    public class CalendarControl : System.Windows.Forms.Calendar.Calendar
    {
        public enum CalendarView { DayView = 1, WeekView = 7 };

        #region delegates
        public delegate void ScheduleEventMethod(ScheduleEvent scheduleEvent);
        #endregion

        #region Fields
        public event ScheduleEventMethod CalendarItemSelected;
        public event ScheduleEventMethod RemoveScheduleEvent;
        public event ScheduleEventMethod ScheduleEventDoubleClick;
        private Dictionary<CalendarItem, ScheduleEvent> calendarControlItems;
        private DateTime startDateView;
        private Calendar_Module.Calendar calendar;
        CalendarView calendarView;

        #endregion

        #region Ctor

        public CalendarControl()
        {
            this.calendarControlItems = new Dictionary<CalendarItem, ScheduleEvent>();
            this.ItemDeleted += DeleteScheduleEventFromCalendarControl;
            this.ItemSelected += CalendarControlItemSelected;
            this.DoubleClick += CalendarControl_DoubleClick;
            this.AllowDrop = this.AllowItemResize = this.AllowNew = this.AllowItemEdit = false;
            calendarView = CalendarView.WeekView;
            TimeScale = CalendarTimeScale.ThirtyMinutes;
            SetViewRange(GetLastSunday(DateTime.Today), GetLastSunday(DateTime.Today).AddDays(6));

        }


        #endregion

        #region Properties

        public ScheduleEvent ScheduleEventItemSelcted

        {
            get
            {
                List<CalendarItem> calendarItems = (List<CalendarItem>)GetSelectedItems();
                try
                {
                    return (calendarControlItems[calendarItems[0]]);
                }
                catch (Exception) { return null; }
            }

        }

        public CalendarView CalendarControlView
        {
            get
            {
                return calendarView;
            }
            set
            {
                calendarView = value;
                if (calendarView == CalendarView.DayView)
                    startDateView = DateTime.Today;
                Refresh();
            }
        }


        // Set and Get DateTime Of the Sunday shown in the calendar control
        public DateTime SundayDate
        {
            get
            {
                return startDateView;
            }
            set
            {
                if (calendarView != CalendarView.DayView)
                    startDateView = GetLastSunday(value);
                else
                    startDateView = DateTime.Today;
                this.Refresh();
            }
        }

        // Set and Get calendar shown in the calendar control

        public Calendar_Module.Calendar Calendar
        {
            get
            {
                return calendar;
            }
            set
            {
                calendar = value;
                Refresh();
            }
        }


        #endregion

        #region Event Methods

        // on calendar item Selected
        private void CalendarControlItemSelected(object sender, CalendarItemEventArgs e)
        {
            try
            {
                if (CalendarItemSelected != null)
                    CalendarItemSelected(ScheduleEventItemSelcted);
            }
            catch (Exception) { }
        }


        // on calendar item Is Delete
        private void DeleteScheduleEventFromCalendarControl(object Sender, CalendarItemEventArgs e)
        {
            if (RemoveScheduleEvent != null)
            {
                CalendarItem calendarItem = e.Item;
            ScheduleEvent calendarItemDelete = calendarControlItems[calendarItem];
            Refresh();

                    
                    RemoveScheduleEvent(calendarItemDelete);
            }

            Refresh();

        }

        private void CalendarControl_DoubleClick(object sender, EventArgs e)
        {
            if (ScheduleEventItemSelcted != null && ScheduleEventDoubleClick!=null)
            {
                ScheduleEventDoubleClick(ScheduleEventItemSelcted);
            }
        }

        #endregion

        #region Public Methods

        public static DateTime GetLastSunday(DateTime date)
        {
            date = date.Date;
            while (date.DayOfWeek != DayOfWeek.Sunday)
            {
                try
                {
                    date -= TimeSpan.FromDays(1);
                }
                catch (Exception)
                {
                    date = GetLastSunday(DateTime.Today);
                    break;
                }
            }
            return date;
        }

        // This method refreshes a calendar control
        public override void Refresh()
        {
            base.Refresh();
            this.calendarControlItems.Clear();
            SetViewRange(startDateView, startDateView + TimeSpan.FromDays((int)calendarView - 1));
            if (calendar != null)
            {
                AddWeekToCalendarControl(calendar.GetDays(startDateView, (int)calendarView - 1));
            }
        }

        // This method moves the Calendar Control view to the next week
        public void NextWeek(object sender, EventArgs e)
        {
            SundayDate += TimeSpan.FromDays(7);
        }

        // This method moves the Calendar control view to view the previous week
        public void PrevWeek(object sender, EventArgs e)
        {
            SundayDate -= TimeSpan.FromDays(7);
        }

        #endregion

        #region Private Methods
        //This method adds an schedule event to a calendar control
        private CalendarItem AddScheduleEventToCalendarControl(ScheduleEvent scheduleEvent)
        {
            bool notAllDay = (scheduleEvent.EndTime.TimeOfDay ==
                (new DateTime() + TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59) + TimeSpan.FromSeconds(59)).TimeOfDay) &&
                !scheduleEvent.AllDay;
            if (notAllDay)
            {
                scheduleEvent.EndTime -= TimeSpan.FromSeconds(10);
            }
            CalendarItem calendarItem = new CalendarItem(this, scheduleEvent.StartTime,
                                                         scheduleEvent.EndTime, scheduleEvent.ToString());


            calendarItem.BackgroundColor = Color.Salmon;
            if (scheduleEvent.Color != Color.Black)
            {
                calendarItem.BackgroundColor = scheduleEvent.Color;
            }
            calendarControlItems.Add(calendarItem, scheduleEvent);
            return calendarItem;
        }

        //This method adds an event list to a calendar control
        private void AddWeekToCalendarControl(List<List<ScheduleEvent>> week)
        {
            CalendarItem calendarItem;
            TimeSpan minTime=TimeSpan.FromHours(10);
            List<CalendarItem> calendarItems = new List<CalendarItem>();
            foreach (List<ScheduleEvent> day in week)
                foreach (ScheduleEvent scheduleEvent in day)
                {
                    calendarItem = this.AddScheduleEventToCalendarControl(scheduleEvent);
                    if (!scheduleEvent.AllDay && (minTime == null || minTime > scheduleEvent.StartTime.TimeOfDay))
                    {
                        minTime = scheduleEvent.StartTime.TimeOfDay;
                    }
                    calendarItems.Add(calendarItem);     
                }
            if (calendarItems.Count > 0)
            {
                this.Items.AddRange(calendarItems);
            }

            this.TimeUnitsOffset = -(int)(minTime.TotalHours*2);
        }


        #endregion


    }
}

