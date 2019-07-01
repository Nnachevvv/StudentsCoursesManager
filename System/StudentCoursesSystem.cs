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
            string[] arr = ReadCommandForUser();
            int age = GetValidNumber(arr[1], "Age");
            int FacultyNumber = GetValidNumber(arr[3], "FacultyNumber");
            Administrator student = new Administrator(arr[0], age, arr[2], FacultyNumber);
            University.AddUser(student);
        }

        private void CreateAdministrator()
        {
            string[] arr = ReadCommandForUser();
            int age = GetValidNumber(arr[1], "Age");
            int FacultyNumber = GetValidNumber(arr[3], "FacultyNumber");

            Administrator administrator = new Administrator(arr[0], age, arr[2], FacultyNumber);
            University.AddUser(administrator);
        }

        private void RemovePerson()
        {
            Console.WriteLine("Enter FacultyNumber");
            string line = Console.ReadLine();
            int fn = GetValidNumber(line, "Faculty Number"); ;
            University.RemoveUser(fn);
        }
        
        private void AddMathCourse()
        {
            string[] arr = ReadCommandForCourses();
            Mathematics course = new Mathematics(arr[0],arr[1]);
            int adminFacultyNumber = GetValidNumber(arr[2], "Faculty Number");
            University.AddCourses(course, adminFacultyNumber);

        }

        private void AddProgrammingCourse()
        {
            string[] arr = ReadCommandForCourses();
            Programming course = new Programming(arr[0], arr[1]);

            int adminFacultyNumber = GetValidNumber(arr[2], "Faculty Number");
            University.AddCourses(course, adminFacultyNumber);

        }

      
        private void AddComputerScienceCourse()
        {
            string[] arr = ReadCommandForCourses();
            ComputerScience course = new ComputerScience(arr[0], arr[1]);
            int adminFacultyNumber =  GetValidNumber(arr[2],"Faculty Number");
            University.AddCourses(course, adminFacultyNumber);

        }

        private void AddSoftwareEngineeringCourse()
        {
            string[] arr = ReadCommandForCourses();
            SoftwareEngineering course = new SoftwareEngineering(arr[0], arr[1]);
            int adminFacultyNumber = GetValidNumber(arr[2], "Faculty Number");
            University.AddCourses(course, adminFacultyNumber);
        }
        
        private void RemoveCourse()
        {
            Console.WriteLine("Enter CourseName ,AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            int adminFacultyNumber = GetValidNumber(arr[2], "Faculty Number");
            University.RemoveCourse(arr[0], adminFacultyNumber);
        }

        private void AddCourseToStudent()
        {
            Console.WriteLine("Enter CouseName ,AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            int adminFacultyNumber = GetValidNumber(arr[2], "Faculty Number");
            University.StudentTakeCourse(arr[0], adminFacultyNumber);
        }

        private void PrintAllCourses()
        {
            University.PrintCourses();
        }

        private void PrintAllStudents()
        {
            University.PrintStudents();
        }
        private int GetValidNumber(string numbParse, string messege)
        {
            int number;
            while (!int.TryParse(numbParse, out number))
            {
                Console.WriteLine("Enter valid " + messege + " !");
                numbParse = Console.ReadLine();
            }
            return number;
        }

        private string[] ReadCommandForCourses()
        {
            Console.WriteLine("Enter courseName, lectuer, AdminFacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            return arr;
        }

        private string[] ReadCommandForUser()
        {
            Console.WriteLine("Enter Name , Age ,City, FacultyNumber");
            string line = Console.ReadLine();
            string[] arr = line.Split(null);
            return arr;
        }

    }
}
