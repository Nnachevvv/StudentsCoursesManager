

using System.Collections.Generic;
using StudentsCoursesManager.Enums
using StudentsCoursesManager.Models.Courses;
namespace StudentsCoursesManager.Models.Users
{
    public class Student:Person
    {
        private HashSet<Course> StudentCourses;

        public int FacultyNumber { get; private set; }

        public Student(string name, int age, string city,int facultyNumber) :
            base(name, age, city,UserType.Student)
        {
            this.FacultyNumber = facultyNumber;
            this.StudentCourses = new HashSet<Course>();
        }

        public void AddCourse(Course course)
        {
            StudentCourses.Add(course);       
        }

        public void RemoveCourse(Course course)
        {
            StudentCourses.Remove(course);
        }

        
    }
}
