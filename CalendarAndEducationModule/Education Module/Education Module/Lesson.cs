using Calendar_Module;
using System;
using System.Collections.Generic;
namespace Education_Module
{
    [Serializable]
    public class Lesson
    {
        public enum LessonType { Lecture, Exercise };
        private LessonType type;
        private Course course;
        private List<ScheduleEvent> lessons;
        private string location;
        private DayOfWeek dayOfWeek;
        TimeSpan timeOfDayStart;
        TimeSpan timeOfDayEnd;

        //Empty Constructor
        public Lesson()
        {

        }//end Constructor

        //Constructor
        public Lesson(DayOfWeek dayOfWeek, TimeSpan timeOfDayStart, TimeSpan timeOfDayEnd, Course course, string location, List<ScheduleEvent> lessons, LessonType type)
        {
            this.dayOfWeek = dayOfWeek;
            this.timeOfDayStart = timeOfDayStart;
            this.timeOfDayEnd = timeOfDayEnd;
            this.course = course;
            this.location = location;
            this.lessons = lessons;
            this.type = type;

        }//end Constructor


        //Override ToString
        public override string ToString()
        {
            string type = this.type == LessonType.Lecture ? "הרצאה" : "תרגול";
            string teacher = this.type == LessonType.Lecture ? course.Lecturer : course.Practices;
            string hebrewDayOfWeek = "";

            switch (this.dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    hebrewDayOfWeek = "יום ראשון";
                    break;
                case DayOfWeek.Monday:
                    hebrewDayOfWeek = "יום שני";
                    break;
                case DayOfWeek.Tuesday:
                    hebrewDayOfWeek = "יום שלישי";
                    break;
                case DayOfWeek.Wednesday:
                    hebrewDayOfWeek = "יום רביעי";
                    break;
                case DayOfWeek.Thursday:
                    hebrewDayOfWeek = "יום חמישי";
                    break;
                case DayOfWeek.Friday:
                    hebrewDayOfWeek = "יום שישי";
                    break;
                case DayOfWeek.Saturday:
                    hebrewDayOfWeek = "יום שבת";
                    break;
            }



            return string.Format("{0}: {1} {2} - {3} עם {4} ב{5}", type,
                                                                hebrewDayOfWeek,
                                                                this.timeOfDayStart.ToString().Substring(0, 5),
                                                                this.timeOfDayEnd.ToString().Substring(0, 5),
                                                                teacher,
                                                                location);
        }//end method

        #region Property
        public DayOfWeek DayOfWeek
        {
            get
            {
                return this.dayOfWeek;
            }
            set
            {
                this.dayOfWeek = value;
            }
        }

        public TimeSpan TimeOfDayStart
        {
            get
            {
                return timeOfDayStart;
            }
            set
            {
                this.timeOfDayStart = value;
            }
        }

        public TimeSpan TimeOfDayEnd
        {
            get
            {
                return timeOfDayEnd;
            }
            set
            {
                this.timeOfDayEnd = value;
            }
        }

        public LessonType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public Course Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
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
        public List<ScheduleEvent> Lessons
        {
            get
            {
                return this.lessons;
            }
            set
            {
                this.lessons = value;
            }
        }
        #endregion Property

    }//end class
}//end namespace