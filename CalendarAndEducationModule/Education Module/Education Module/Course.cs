using Calendar_Module;
using System;
using System.Collections.Generic;
namespace Education_Module
{
    [Serializable]
    public class Course : IComparable<Course>
    {
        private string name;
        private string lecturer;
        private string practices;
        private List<Lesson> lessons;
        private List<Task> tasks;
        private List<Exam> exams;
        private Semester semester;

        //Empty Constructor
        public Course()
        {

        }//end Constructor

        //Constructor
        public Course(string name, string lecturer, string practices, Semester semester)
        {
            //initialize lists
            lessons = new List<Lesson>();
            tasks = new List<Task>();
            exams = new List<Exam>();
            this.name = name;
            this.lecturer = lecturer;
            this.practices = practices;
            this.semester = semester;

        }//end Constructor

        #region Methods
        //Adding methods
        public List<ScheduleEvent> AddNewLesson(Lesson.LessonType type, DateTime startTime,
                                                DateTime endTime, Semester semester, string location)
        {
            List<ScheduleEvent> lessons;

            //change lesson type to hebrew string
            string lessonType = type == Lesson.LessonType.Exercise ? "תרגול" : "הרצאה";

            //create weekly schedule event until the end of the semester
            new ScheduleEvent(startTime, endTime, this.name, location, lessonType,
                              ScheduleEvent.Period.Weekly, semester.EndTime, out lessons);

            //create new lesson instance
            Lesson lesson = new Lesson(startTime.DayOfWeek, startTime.TimeOfDay, endTime.TimeOfDay, this, location, lessons, type);

            //assign the schedule events to lesson list in Lesson class
            lesson.Lessons = lessons;

            foreach (ScheduleEvent s in lessons)
            {
                s.Lesson = lesson;
            }

            AddLesson(lesson);

            return lessons;
        }
        public void AddLesson(Lesson lesson)
        {
            this.lessons.Add(lesson);
        }//end method
        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }//end method
        public void AddExam(Exam exam)
        {
            this.exams.Add(exam);
        }//end method

        //Remove methods
        public void RemoveLesson(Lesson lesson)
        {
            this.lessons.Remove(lesson);
        }//end method
        public void RemoveTask(Task task)
        {
            if (!this.tasks.Contains(task))
            {
                throw new KeyNotFoundException();
            }
            this.tasks.Remove(task);
        }//end method
        public void RemoveExam(Exam exam)
        {
            if (!this.exams.Contains(exam))
            {
                throw new KeyNotFoundException();
            }
            this.exams.Remove(exam);
        }//end method

        //MY ToString
        public override string ToString()
        {
            return this.name;
        }//end method

        //CompareTo method for List<T>.Sort()
        public int CompareTo(Course other)
        {
            if (this.semester.StartTime == other.semester.StartTime)
                return 0;
            else if (this.semester.StartTime > other.semester.StartTime)
                return -1;
            return 1;
        }//end method

        //Override ToString
        public string ToString(string format)
        {
            string name = this.name;
            string lecture = "מרצה: " + this.lecturer;
            string exercise = "מתרגל: " + this.practices;
            string lesson = "";
            if (this.lessons != null)
            {
                foreach (Lesson l in lessons)
                {
                    lesson += "\n" + l.ToString();

                }
            }
            return string.Format("{0}\n{1}\n{2}{3}", name, lecture, exercise, lesson);
        }//end methos



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
        public string Lecturer
        {
            get
            {
                return this.lecturer;
            }
            set
            {
                this.lecturer = value;
            }
        }
        public string Practices
        {
            get
            {
                return this.practices;
            }
            set
            {
                this.practices = value;
            }
        }
        public List<Lesson> Lessons
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
        public List<Task> Tasks
        {
            get
            {
                return this.tasks;
            }
            set
            {
                this.tasks = value;
            }
        }
        public List<Exam> Exams
        {
            get
            {
                return this.exams;
            }
            set
            {
                this.exams = value;
            }
        }
        public Semester Semester
        {
            get
            {
                return this.semester;
            }
            set
            {
                this.semester = value;
            }
        }
        #endregion Properties
    }//end class
}//end namespace