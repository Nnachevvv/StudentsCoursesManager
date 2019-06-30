

namespace StudentsCoursesManager.Models.Courses
{
    public class Mathematics : Course
    {
        private const int MathematicCredits = 5;
        public Mathematics(string name, string lectuer) : 
            base(name, lectuer, MathematicCredits)
        {

        }
    }
}
