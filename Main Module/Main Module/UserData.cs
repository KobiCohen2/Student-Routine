using Calendar_Module;
using Education_Module;
using System;
using System.Collections.Generic;

namespace Main_Module
{
    [Serializable]
    public class UserData
    {
        private Calendar calendar;
        private List<AcademicYear> academicYears;
        private Note[] notes;
        //Empty Constructor
        public UserData()
        {

        }//end Constructor

        //Constructor
        public UserData(Calendar calendar)
        {
            this.Calendar = calendar;

            //intitialize lists
            academicYears = new List<AcademicYear>();
            notes = new Note[10];

            //assign empty notes 
            for (int i = 0; i < 10; i++)
            {
                notes[i] = new Note();
            }
        }

        #region Methods
        //Add methods
        public void AddAcademicYear(AcademicYear academicYear)
        {
            this.academicYears.Add(academicYear);
        } //end method


        //Remove methods
        public void RemoveAcademicYear(AcademicYear academicYear)
        {
            if (!this.academicYears.Contains(academicYear))
            {
                throw new KeyNotFoundException();
            }
            this.academicYears.Remove(academicYear);
        }//end method


        //Find a year that contains a given semester
        public AcademicYear FindAcademicYear(Semester semester)
        {
            foreach (AcademicYear y in academicYears)
            {
                if (y.Semsters.Contains(semester))
                {
                    return y;
                }
            }
            return null;
        }//end method

        //Get current academic year
        public AcademicYear GetCurrentAcademicYear()
        {
            foreach (AcademicYear y in academicYears)
            {
                if (y.StartTime <= DateTime.Now && DateTime.Now <= y.EndTime)
                {
                    return y;
                }
            }
            return null;
        }//end method

        //lat semester of cuurent year
        public Semester LastSemesterOfCurrentYear(AcademicYear year)
        {
            Semester semester = null;
            try
            {
                semester = year.Semsters[0];
                foreach (Semester s in year.Semsters)
                {
                    if (s.StartTime > semester.StartTime)
                        semester = s;
                    else
                        continue;
                }
                return semester;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }//end method


        //Find a semester that contains a given course
        public Semester FindSemester(Course course)
        {
            foreach (AcademicYear y in academicYears)
            {
                foreach (Semester s in y.Semsters)
                {
                    if (s.Courses.Contains(course))
                    {
                        return s;
                    }
                }
            }
            return null;
        }//end method

        //Get all semesters method
        public List<Semester> GetSemesters()
        {
            List<Semester> semesters = new List<Semester>();
            try
            {
                foreach (AcademicYear y in academicYears)
                {
                    foreach (Semester s in y.Semsters)
                    {
                        semesters.Add(s);
                    }
                }
                semesters.Sort();
            }
            catch (Exception) { }
            return semesters;
        }//end method

        //check if semester exists
        public bool IsSemesterExists(AcademicYear year, Semester.SemesterName name)
        {
            try
            {
                foreach (Semester semester in year.Semsters)
                {
                    if (semester.Name == name)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }//end method

        //Get all courses method
        public List<Course> GetCourses()
        {
            List<Semester> semesters = GetSemesters();
            List<Course> courses = new List<Course>();
            try
            {
                foreach (Semester s in semesters)
                {
                    foreach (Course c in s.Courses)
                    {
                        courses.Add(c);
                    }
                }
                courses.Sort();
            }
            catch (Exception) { }
            return courses;
        }//end method

        //Get courses of year
        public List<Course> GetCoursesOfYear(AcademicYear year)
        {
            try
            {
                List<Course> coursesOfYear = new List<Course>();
                foreach (Semester s in year.Semsters)
                {
                    foreach (Course c in s.Courses)
                    {
                        coursesOfYear.Add(c);
                    }
                }
                coursesOfYear.Sort();
                return coursesOfYear;
            }
            catch (NullReferenceException)
            {
                return null;
            }

        }//end method

        //Find course
        public Course FindCourse(Task task)
        {
            List<Course> courses = GetCourses();

            try
            {
                foreach (Course course in courses)
                {
                    if (course.Tasks.Contains(task))
                    {
                        return course;
                    }
                }
            }
            catch (Exception) { }

            return null;
        }//end method

        //Overload Find course
        public Course FindCourse(Exam exam)
        {
            List<Course> courses = GetCourses();

            try
            {
                foreach (Course course in courses)
                {
                    if (course.Exams.Contains(exam))
                    {
                        return course;
                    }
                }
            }
            catch (Exception) { }

            return null;
        }//end method

        //Get tasks
        public List<Task> GetTasks()
        {
            List<Course> courses = GetCourses();
            List<Task> tasks = new List<Task>();
            try
            {
                foreach (Course course in courses)
                {
                    tasks.AddRange(course.Tasks);
                }
                tasks.Sort();
            }
            catch (Exception) { }

            return tasks;
        }//end methos

        //Get exams
        public List<Exam> GetExams()
        {
            List<Course> courses = GetCourses();
            List<Exam> exams = new List<Exam>();
            try
            {
                foreach (Course course in courses)
                {
                    exams.AddRange(course.Exams);
                }
                exams.Sort();
            }
            catch (Exception) { }

            return exams;
        }//end methos


        //Service methods
        private AcademicYear FindAcademicYear(AcademicYear.AcademicYearName name)
        {
            foreach (AcademicYear year in academicYears)
            {
                if (year.Name == name)
                {
                    return year;
                }
            }
            return null;
        }//end method
        #endregion Methods

        #region Live Tails Methods
        //return string of the future events today
        public string TodyScheduleEvents()
        {
            int numOfScheduleEvents = 0;
            List<ScheduleEvent> scheduleEvents = new List<ScheduleEvent>();
            try
            { scheduleEvents = this.calendar[DateTime.Today]; }
            catch (Exception) { }

            foreach (ScheduleEvent se in scheduleEvents)
            {
                if (se.EndTime >= DateTime.Now)
                {
                    numOfScheduleEvents++;
                }
            }

            return "היום\n\n" + string.Format("\u200F{0} אירועים עתידים להתרחש היום", numOfScheduleEvents);
        }//end method

        //return string of the courses occur today
        public string TodayCourses()
        {
            string coursesList = "";
            string noCourses = "אין שיעורים היום";
            bool thereIsLesson = false;
            List<ScheduleEvent> scheduleEvents = new List<ScheduleEvent>();
            try
            { scheduleEvents = this.calendar[DateTime.Today]; }
            catch (Exception) { }

            foreach (ScheduleEvent se in scheduleEvents)
            {
                if (se.Lesson != null)
                {
                    thereIsLesson = true;
                    coursesList += string.Format("{0} {1} - {2}\n", se.Title, se.StartTime.ToString("HH:mm"), se.EndTime.ToString("HH:mm"));
                }
            }

            if (!thereIsLesson)
                return "היום\n\n" + noCourses;


            return "היום\n\n" + coursesList;
        }//end method

        //return string of the next class
        public string NextClass()
        {
            string nextClass = "";
            bool stop = false;
            List<List<ScheduleEvent>> week = this.calendar.GetCurrentWeek();

            foreach (List<ScheduleEvent> day in week)
            {
                foreach (ScheduleEvent se in day)
                {
                    if (se.Lesson != null && se.StartTime >= DateTime.Now)
                    {
                        nextClass = string.Format("{0}\n{1} - {2}\n{3}\n", se.Title, se.StartTime.ToString("dddd dd/M/yyyy HH:mm"),
                            se.EndTime.ToString("HH:mm"), se.Location);

                        stop = true;
                        break;
                    }
                }
                if (stop)
                {
                    stop = false;
                    break;
                }
            }

            if (nextClass == "")
                return "שיעורים\n\n" + "לא צפויים שיעורים בשבוע הקרוב";

            return "שיעורים\n\n" + "\u202Eהשיעור הקרוב: \n" + nextClass;
        }//end method

        //return string of number of classes remaining today, and tomorrow
        public string RemainingClasses()
        {
            List<ScheduleEvent> today = new List<ScheduleEvent>();
            List<ScheduleEvent> tomorrow = new List<ScheduleEvent>();
            int remainingToday = 0;
            int tomorrowClasses = 0;


            try
            {
                today = this.calendar[DateTime.Today];
                tomorrow = this.calendar[DateTime.Today + TimeSpan.FromDays(1)];
            }
            catch (Exception)
            {

            }

            //counting classes remaining today
            foreach (ScheduleEvent se in today)
            {
                if (se.StartTime > DateTime.Now && se.Lesson != null)
                    remainingToday++;
            }

            //counting tomorrow classes
            foreach (ScheduleEvent se in tomorrow)
            {
                if (se.Lesson != null)
                    tomorrowClasses++;
            }

            return "שיעורים\n\n" + string.Format("\u200F{0} שיעורים נשארו היום\n\u200F{1} שיעורים עתידים להתקיים מחר", remainingToday, tomorrowClasses);
        }//end method

        //return string of the next task
        public string NextTask()
        {
            string nextTask = "";
            string hebrewString = "\u202Eמטלה קרובה: \n";
            List<Task> tasks = this.GetTasks();

            foreach (Task task in tasks)
            {
                if (task.Deadline > DateTime.Now)
                {
                    nextTask = string.Format("{0}\n{1}\n{2}{3}", task.Name, task.CourseName, "מועד הגשה: ",
                                 task.Deadline.ToString("dddd dd/M/yyyy HH:mm"));

                    break;
                }
            }

            if (nextTask == "")
                return "מטלות\n\n" + "אין מטלה קרובה להצגה";

            return "מטלות\n\n" + hebrewString + nextTask;
        }//end method

        //return string of number of tasks remaining tomorrow, and in the next week 
        public string RemainingTasks()
        {
            List<Task> tasks = GetTasks();
            DateTime tomorrow = DateTime.Today + TimeSpan.FromDays(1);
            DateTime tomorrowMidnight = tomorrow + TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59) + TimeSpan.FromSeconds(59);
            DateTime lastSunday = Calendar.GetLastSunday();
            DateTime saturdayMidnight = lastSunday + TimeSpan.FromDays(6) + TimeSpan.FromHours(23) + TimeSpan.FromMinutes(59) + TimeSpan.FromSeconds(59);
            int tomorrowTasks = 0;
            int nextWeekTasks = 0;
            string hebrewString = "מטלות למחר";
            string hebrewString2 = "מטלות נותרו לשבוע הקרוב";

            //counting tasks
            foreach (Task task in tasks)
            {
                if (tomorrow <= task.Deadline && task.Deadline <= tomorrowMidnight)
                {
                    tomorrowTasks++;
                }

                if ((lastSunday <= task.Deadline && task.Deadline <= saturdayMidnight) && task.Deadline >= DateTime.Now)
                {
                    nextWeekTasks++;
                }
            }



            return "מטלות\n\n" + string.Format("\u200F{0} {1}\n\u200F{2} {3}", tomorrowTasks, hebrewString, nextWeekTasks, hebrewString2);
        }//end method

        //return string of the next exam
        public string NextExam()
        {
            string nextExam = "";
            string hebrewString = "\u202Eמבחן קרוב: \n";
            bool stop = false;
            List<List<ScheduleEvent>> month = this.calendar.GetDays(DateTime.Today.Date, 31);

            foreach (List<ScheduleEvent> day in month)
            {
                foreach (ScheduleEvent se in day)
                {
                    if (se.IsExam && se.StartTime >= DateTime.Now)
                    {
                        nextExam = string.Format("{0}\n", se);

                        stop = true;
                        break;
                    }
                }
                if (stop)
                {
                    stop = false;
                    break;
                }
            }

            if (nextExam == "")
                return "מבחנים\n\n" + "אין מבחן קרוב להצגה";

            return "מבחנים\n\n" + hebrewString + nextExam;
        }//end method

        //return string of number of exams remaining in the next week
        public string RemainingExams()
        {
            List<List<ScheduleEvent>> week = this.calendar.GetCurrentWeek();
            int nextWeekExams = 0;
            string hebrewString = "מבחנים נותרו בשבוע הקרוב";

            foreach (List<ScheduleEvent> day in week)
            {
                foreach (ScheduleEvent se in day)
                {
                    if (se.IsExam && se.StartTime >= DateTime.Now)
                        nextWeekExams++;
                }
            }

            return "מבחנים\n\n" + string.Format("\u200F{0} {1}", nextWeekExams, hebrewString);
        }//end method


        #endregion

        #region Propertirs
        public Calendar Calendar
        {
            get
            {
                return this.calendar;
            }
            set
            {
                this.calendar = value;
            }
        }
        public List<AcademicYear> AcademicYears
        {
            get
            {
                return this.academicYears;
            }
            set
            {
                this.academicYears = value;
            }
        }
        public Note[] Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }

        #endregion Properties

        #region Indexer
        public AcademicYear this[AcademicYear.AcademicYearName name]
        {
            get
            {
                AcademicYear year = FindAcademicYear(name);
                if (year == null)
                {
                    throw new KeyNotFoundException();
                }
                return year;
            }
            set
            {
                AcademicYear year = FindAcademicYear(name);
                if (year == null)
                {
                    this.academicYears.Add(value);
                }
                this.academicYears[academicYears.IndexOf(year)] = value;
            }
        }
        #endregion Indexer
    }//end class
}//end namespace
