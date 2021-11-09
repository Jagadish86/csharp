using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Concepts
{
    class Program
    {
        public static string Type = "Arithmetic";
        static void Main(string[] args)
        {
            Type = "hj";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Employee record id " + new EmployeeRecord().Id);
            var numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine(nameof(numbers));  // output: numbers
            Console.WriteLine(nameof(numbers.Count));  // output: Count
            Console.WriteLine(nameof(numbers.Add));  // output: Add

            Person p = new Person("Mandy", "Dejesus");
            Console.WriteLine(p);
            char alphabet = 'A';
            Console.WriteLine(alphabet);
            p.DisplayName();

            var employee = new EmployeeRecord();
            employee.Name = "Jagadish";
            Console.WriteLine(employee.Name);
            employee.RenameEmployee("Jaga");

            var objEmp = new
            {
                Id = 1,
                Name = "Jaga"
            };

            byte test = 15;
            short shrt = 32767;

            // String interpolation
            string firstName = "Jagadish";
            string lastName = "Palanivelu";

            string fullName = $"Employee name is: {{firstName}}, {lastName}";
            Console.WriteLine(fullName);
            DateTime dt = new DateTime(2021, 10, 12,12, 20, 40);
            DateTime dt1 = DateTime.Now;

            Console.WriteLine(objEmp.Equals(employee));

            Coordinates coordinates;
            coordinates.x = 7;
            coordinates.y = 8;

            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine(coordinates.x + ":" + coordinates.y);

            string message = "I am a string";
            StringBuilder bigMessage = new StringBuilder(20);
            bigMessage.Append("Learning the basics of C#");
            //bigMessage.Append("Learnin");
            Console.WriteLine(coordinates.x + ":" + coordinates.y);

            EmployeeService es = new EmployeeService();
            Console.WriteLine(es.CalculateHoursWorked());

            StringDataStore strStore = new StringDataStore();

            //strStore[0] = "One";
            //strStore[1] = "Two";
            //strStore[2] = "Three";
            //strStore[3] = "Four";

            strStore[0] = 899;
            strStore[1] = 900;
            strStore[2] = 901;
            strStore[3] = 902;

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);

        }
    }

    class StringDataStore
    {
        private int[] strArr = new int[10]; // internal data storage

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                strArr[index] = value;
            }
        }
    }

    public partial class EmployeeService
    {

    }

    struct Coordinates
    {
        public int x;
        public int y;
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday=6,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class EmployeeRecord
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; }

        public void RenameEmployee(string updatedName)
        {
            Name = updatedName;
            Console.WriteLine(Name);
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }
}
