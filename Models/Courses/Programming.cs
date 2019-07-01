using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager.Models.Courses
{
    public class Programming : Course
    {
        private const int ProgammingCreddits = 5;
        public Programming(string name, string lectuer) : 
            base(name, lectuer, ProgammingCreddits,CoursesType.Programming)
        {
        }
    }
}
