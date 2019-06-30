
namespace StudentsCoursesManager.Models.Courses
{
    public class ComputerScience : Course
    {
        private const int ComputerScienceCredits = 7;
        public ComputerScience(string name, string lectuer) 
            : base(name, lectuer, ComputerScienceCredits)
        {
        }
    }
}
