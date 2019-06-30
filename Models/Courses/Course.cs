using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCoursesManager.Models.Courses
{
    public abstract class  Course
    {
        public int Credits { get; protected set; }

        public string Name { get; protected set; }

        public  string Lectuer { get; protected set; }

        protected Course(string name, string lectuer, int credits)
        {
            this.Name = name;
            this.Lectuer = lectuer;
            this.Credits = credits;
        }

    }
}
