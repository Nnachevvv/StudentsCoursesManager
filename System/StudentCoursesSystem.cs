using System;
using StudentsCoursesManager.Models.Users;
using StudentsCoursesManager.Models.Courses;

namespace StudentsCoursesManager
{
    class StudentCoursesSystem
    {
        public UniversityManager University { get; private set; }

        public StudentCoursesSystem()
        {
            University = new UniversityManager();
            StartSystem();
        }

        private void StartSystem()
        {
            PrintCommands();
            string currentLine = Console.ReadLine();
            while (!currentLine.Equals("0"))
            {
                Console.Clear();
                switch(currentLine)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        CreateAdministrator();
                        break;
                    case "3":
                        RemovePerson();
                        break;
                    case "4":
                        AddComputerScienceCourse();
                        break;
                    case "5":
                        AddMathCourse();
                        break;
                    case "6":
                        AddProgrammingCourse();
                        break;
                    case "7":
                        AddSoftwareEngineeringCourse();
                        break;
                    case "8":
                        AddCourseToStudent();
                        break;
                    case "9":
                        RemoveCourse();
                        break;
                    case "10":
                        PrintAllCourses();
                        break;
                    case "11":
                        PrintAllStudents();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                       break;
                }
                PrintCommands();
                currentLine = Console.ReadLine();
                
            }
        }

        private void PrintCommands()
        {
            Console.WriteLine("Enter one  of following commands:\r\n" +
                               "0 - Exit\r\n" +
                               "1 - Create Student\r\n" +
                               "2 - Create Administrator\r\n" +
                               "3 - Remove Person from system\r\n" +
                               "4 - Add ComputerScience course\r\n" +
                               "5 - Add Mathematics course\r\n" +
                               "6 - Add Programming course\r\n" +
                               "7 - Add SoftwareEngineering course\r\n" +
                               "8 - Add course to given student\r\n" +
                               "9 - Remove course from system\r\n" +
                               "10 - Print all courses\r\n" +
                               "11 - Print all users");
        }

        private void CreateStudent()
        {
            Console.WriteLine("Enter Name , Age ,City, Fn");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            Student student = new Student(arr[0], int.Parse(arr[1]), arr[2], int.Parse(arr[3]));
            University.AddUser(student);
        }

        private void CreateAdministrator()
        {
            Console.WriteLine("Enter Name , Age ,City, FacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            Administrator administrator = new Administrator(arr[0], int.Parse(arr[1]), arr[2], int.Parse(arr[3]));
            University.AddUser(administrator);
        }

        private void RemovePerson()
        {
            Console.WriteLine("Enter FacultyNumber");
            int fn = int.Parse(Console.ReadLine());
            University.RemoveUser(fn);
        }
        
        private void AddMathCourse()
        {
            Console.WriteLine("Enter name, lectuer, AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            Mathematics course = new Mathematics(arr[0],arr[1]);
            University.AddCourses(course, int.Parse(arr[2]));

        }

        private void AddProgrammingCourse()
        {
            Console.WriteLine("Enter name, lectuer, AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            Programming course = new Programming(arr[0], arr[1]);
            University.AddCourses(course, int.Parse(arr[2]));

        }

        private void AddComputerScienceCourse()
        {
            Console.WriteLine("Enter courseName, lectuer, AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            ComputerScience course = new ComputerScience(arr[0], arr[1]);
            University.AddCourses(course, int.Parse(arr[2]));

        }

        private void AddSoftwareEngineeringCourse()
        {
            Console.WriteLine("Enter CourseName,lectuer, AdminId");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            SoftwareEngineering course = new SoftwareEngineering(arr[0], arr[1]);
            University.AddCourses(course, int.Parse(arr[2]));
        }
        
        private void RemoveCourse()
        {
            Console.WriteLine("Enter CourseName ,AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            University.RemoveCourse(arr[0], int.Parse(arr[1]));
        }

        private void AddCourseToStudent()
        {
            Console.WriteLine("Enter CouseName ,AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            University.StudentTakeCourse(arr[0], int.Parse(arr[1]));
        }

        private void PrintAllCourses()
        {
            University.PrintCourses();
        }

        private void PrintAllStudents()
        {
            University.PrintStudents();
        }
    }
}
