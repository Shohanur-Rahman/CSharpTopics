using System;
using System.Collections.Generic;

namespace Delegate
{
    /*
     * A delegte is  type save function pointer
     */

    public delegate void PrintFunctionDelegate(string message);
    public delegate bool IsPromoteable(Employee employee);
    class Program
    {
        static void Main(string[] args)
        {
            PrintFunctionDelegate del = new PrintFunctionDelegate(Print);
            del("I am Shohanur Rahman");

            List<Employee> employees = new List<Employee>
            {
                new Employee(){Id=1, Name="John", Salary=50000, Experience=5},
                new Employee(){Id=2, Name="Doe", Salary=65000, Experience=3},
                new Employee(){Id=3, Name="Jacky", Salary=45000, Experience=2}
            };

            IsPromoteable promote = new IsPromoteable(IsPromote);

            Employee.PromoteEmploye(employees, IsPromote);
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static bool IsPromote(Employee employee)
        {
            if (employee.Experience >= 5)
                return true;
            return false;
        }


    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmploye(List<Employee> listOfEmployee, IsPromoteable IsEligiblePromote)
        {
            foreach (var emp in listOfEmployee)
            {
                if (IsEligiblePromote(emp))
                {
                    Console.WriteLine("Employee {0} promoted", emp.Name);
                }
            }
        }
    }
}
