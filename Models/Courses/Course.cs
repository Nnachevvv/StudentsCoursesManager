using System;
using StudentsCoursesManager.Enums;
namespace StudentsCoursesManager.Models.Courses
{
    public abstract class  Course
    {
        public int Credits { get; protected set; }

        public string Name { get; protected set; }

        public  string Lectuer { get; protected set; }

        public CoursesType CourseType { get; private set; }
        protected Course(string name, string lectuer, int credits,CoursesType courseType)
        {
            this.Name = name;
            this.Lectuer = lectuer;
            this.Credits = credits;
            this.CourseType = courseType;
        }

        private string GetCourseType()
        {
            switch (CourseType)
            {
                case CoursesType.ComputerScience:
                    return "Computer Science";
                case CoursesType.Mathematics:
                    return "Mathematics";
                case CoursesType.Programming:
                    return "Programming";
                case CoursesType.SoftwareEngineering:
                    return "Software Engineering";
                default:
                    return " ";
            }
        }

        public void PrintCourse()
        {
            Console.WriteLine(GetCourseType() + " " + Name + " " + Lectuer + " " + Credits);
        }

    }
}
