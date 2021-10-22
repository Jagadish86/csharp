using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var student = new { Id = 667179, Name = "Jagadish Palanivelu", Age = "32" };
            Console.WriteLine($"The Student {student.Name} with id {student.Id} is of age { student.Age }");

            var students = new[] {
                new { Id = 1, FirstName = "James", LastName = "Bond" },
                new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
                new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };

            dynamic stud = new Student();

            stud.DisplayStudentInfo(1);// run-time error, no compile-time error
            //stud.DisplayStudentInfo("1");// run-time error, no compile-time error
            //stud.FakeMethod();// run-time error, no compile-time error

            dynamic @dynamic = "Hi there! I am a string";
            Console.WriteLine(dynamic);
            Console.WriteLine("hold");
            Nullable<int> testInt = null;
            Console.WriteLine(testInt);

            Student std1 = new Student();

            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);

            static void ChangeReferenceType(Student std2)
            {
                std2.StudentName = "Steve";
            }
        }
        public class Student
        {
            public string StudentName { get; set; }
            public void DisplayStudentInfo(int id)
            {
            }

            
        }

    }
}
