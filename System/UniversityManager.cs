using System.Collections.Generic;
using StudentsCoursesManager.Models.Users;
using StudentsCoursesManager.Models.Courses;
using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager
{
    class UniversityManager
    {
        Dictionary<int, Person> Users;
        public CourseSystem Courses { get; private set; }

        public UniversityManager()
        {
            Users = new Dictionary<int, Person>();
            Courses = new CourseSystem();
        }

        public void AddUser(Person person)
        {
            if (!Users.ContainsKey(person.FacultyNumber))
            {
                Users.Add(person.FacultyNumber, person);
            }
        }
        public void RemoveUser(int id)
        {
            if (Users.ContainsKey(id))
            {
                Users.Remove(id);
            }
        }
        public void AddCourses(Course course,int id)
        {
            if (Users.ContainsKey(id) && Users[id].UserType==UserType.Administrator)
            {
                Courses.AddCourse(course);
            }
        }
        
        public void RemoveCourse(string name, int id)
        {
            if (Users.ContainsKey(id) && Users[id].UserType == UserType.Administrator)
            {
                Courses.RemoveCourse(name);
            }
        }

        public void StudentTakeCourse(string name, int id)
        {
            if(Courses.IsHaveCourse(name) && Users.ContainsKey(id))
            {
                Users[id].AddCourse(Courses.GetCourse(name));

            }
        }
        
        public void StudentRemoveCourse(string name ,int id)
        {
            if (Courses.IsHaveCourse(name) && Users.ContainsKey(id))
            {
                Users[id].RemoveCourse(name);
            }
        }

        public void PrintStudents()
        {
            foreach (var student in Users)
            {
                student.Value.PrintData();
            }
        }

        public void PrintCourses()
        {
            Courses.PrintCourses();
        }
    }
}
