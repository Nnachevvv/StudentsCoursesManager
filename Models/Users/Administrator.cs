using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager.Models.Users
{
    public class Administrator : Person
    {

        public Administrator(string name, int age, string city,int facultyNumber) : 
            base(name, age, city, UserType.Administrator,facultyNumber)
        {

        }
    }
}
