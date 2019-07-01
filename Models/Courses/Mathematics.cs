using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager.Models.Courses
{
    public class Mathematics : Course
    {
        private const int MathematicCredits = 4;
        public Mathematics(string name, string lectuer) : 
            base(name, lectuer, MathematicCredits,CoursesType.Mathematics)
        {

        }
    }
}
