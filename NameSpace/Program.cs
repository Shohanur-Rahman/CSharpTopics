using NameSpace.Classes; // Namespace
using System; // Namespace
using System.Collections.Generic; // Namespace
using System.Linq; // Namespace

namespace NameSpace
{
    /*
     * 
     * A namespace is a set of signs that are used to identify and refer to objects of various kinds. 
     * A namespace ensures that all of a given set of objects have unique names so that they can be easily identified.
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>
            {
                new Employee(){Id=1, Name="Shohanur", Salary=90000},
                new Employee(){Id=3, Name="Mosharaf", Salary=35000},
                new Employee(){Id=4, Name="Lokman", Salary=15000},
                new Employee(){Id=2, Name="Rahman", Salary=50000},
            };

            var secondMaxSalary = employeeList.GroupBy(e => e.Salary).OrderByDescending(s => s.Key).Skip(1).FirstOrDefault();
            
            foreach(var em in secondMaxSalary)
            {
                Console.WriteLine("Max salary {0}", em.Salary);
            }
        }
    }
}
