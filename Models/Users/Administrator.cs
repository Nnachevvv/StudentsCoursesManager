using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager.Models.Users
{
    public class Administrator : Person
    {
        protected Administrator(string name, int age, string city) : 
            base(name, age, city, UserType.Administrator)
        {
        }
    }
}
