
using System;
using StudentsCoursesManager.Enums;

namespace StudentsCoursesManager.Models.Users
{
    public class Person
    {
        public string Name { get; protected set; }

        public int Age { get; protected set; }

        public string City { get; protected set; }

        public UserType UserType{ get; private set; }

        protected Person(string name, int age,string city,UserType type)
        {
            this.Age = age;
            this.Name = name;
            this.City = city;
            this.UserType = type;

        }
    }
}
