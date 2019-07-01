
using System;
using StudentsCoursesManager.Interfaces;
using StudentsCoursesManager.Enums;
using StudentsCoursesManager.Models.Courses;

namespace StudentsCoursesManager.Models.Users
{
    public class Person:IManagerCoureses
    {
        public string Name { get; protected set; }

        public int Age { get; protected set; }

        public string City { get; protected set; }

        public UserType UserType{ get; private set; }

        public int FacultyNumber { get; private set; }

        
        protected Person(string name, int age,string city,UserType type, int facultyNumber)
        {
            this.Age = age;
            this.Name = name;
            this.City = city;
            this.UserType = type;
            this.FacultyNumber = facultyNumber;

        }

        public  virtual void AddCourse(Course course)
        {

        }

        public virtual void RemoveCourse(string name)
        {

        }

        private string GetTypeOfStudent()
        {
            if(UserType==0)
            {
                return "Administrator";
            }
            return "Student";
        }
        public void PrintData()
        {
            Console.WriteLine(GetTypeOfStudent() + " " + Name + " " + Age + " " + City);
        }
    }
}
