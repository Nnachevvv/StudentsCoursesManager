using StudentsCoursesManager.Interfaces;
using StudentsCoursesManager.Models.Courses;
using System.Collections.Generic;
namespace StudentsCoursesManager
{

    class CourseSystem: IManagerCoureses
    {
        private Dictionary<string,Course> CoursesUniversity;

        public CourseSystem()
        {
            this.CoursesUniversity = new Dictionary<string, Course>();
        }

        public void AddCourse(Course course)
        {
            CoursesUniversity.Add(course.Name,course);
        }

        public void RemoveCourse(string name)
        {
            CoursesUniversity.Remove(name);
        }

        public bool IsHaveCourse(string name)
        {
            return CoursesUniversity.ContainsKey(name);
        }

        public Course GetCourse(string name)
        {
            return CoursesUniversity[name];
        }

        public void PrintCourses()
        {
            foreach(var courseName in CoursesUniversity)
            {
                courseName.Value.PrintCourse();
            }
        }

    }
}
