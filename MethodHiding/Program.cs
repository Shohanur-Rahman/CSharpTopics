using System;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee parTimeEmployee = new PartTimeEmployee();
            parTimeEmployee.FirstName = "Shohanur";
            parTimeEmployee.LastName = "Rahman";
            parTimeEmployee.PrintFullName();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Tamim";
            fullTimeEmployee.LastName = "Iqbal";
            fullTimeEmployee.PrintFullName();
        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine("{0} {1} is part time employee", FirstName, LastName);
        }
    }

    class FullTimeEmployee:Employee
    {

    }
}
