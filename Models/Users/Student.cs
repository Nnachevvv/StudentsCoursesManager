using System.Collections.Generic;
using StudentsCoursesManager.Enums;
using StudentsCoursesManager.Models.Courses;
using StudentsCoursesManager.Interfaces;
namespace StudentsCoursesManager.Models.Users
{
    public class Student:Person, IManagerCoureses
    {
        private const int MAX_COUNT_COURSES = 7;

        private Dictionary<string,Course> StudentCourses;

        public int Credits { get; private set; }

        public Student(string name, int age, string city, int facultyNumber) :
            base(name, age, city,UserType.Student,facultyNumber)
        {
            this.StudentCourses = new Dictionary<string, Course>();
        }


        public override void AddCourse(Course course)
        {
            if (StudentCourses.Count<MAX_COUNT_COURSES)
            {
                StudentCourses.Add(course.Name,course);       
            }
        }

        public override void RemoveCourse(string name)
        {
                 StudentCourses.Remove(name);
        }

        
    }
}
