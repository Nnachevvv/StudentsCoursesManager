using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager.Models.Courses
{
    public class SoftwareEngineering : Course
    {
        private const int SoftwareCredits = 7;
        public SoftwareEngineering(string name, string lectuer) 
            : base(name, lectuer, SoftwareCredits,CoursesType.SoftwareEngineering)
        {
        }
    }
}
