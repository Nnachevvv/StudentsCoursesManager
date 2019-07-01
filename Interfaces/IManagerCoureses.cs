using StudentsCoursesManager.Models.Courses;

namespace StudentsCoursesManager.Interfaces
{
   public interface IManagerCoureses
    {
        void AddCourse(Course course);

        void RemoveCourse(string name);


    }
}
