using System;

namespace AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee = new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "First Employee"
            };

            int i;
            var j = 10;

            var emp2 = new {ID = 2, Name = "Anonymous Name" };

            Console.WriteLine(emp2.Name.ToUpper());

            var arr = new[]
            {
                new {ID = 3, Name ="1 name"},
                new {ID = 4, Name ="2 name"},
                new {ID = 5, Name ="3 name"},
            };

            Console.WriteLine(arr[0].Name);  
        
        }
    }

    class Employee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }   
    }
}
