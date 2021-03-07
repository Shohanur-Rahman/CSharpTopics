using System;

namespace WhyStruct
{
    /*
     * 
     * A struct is a value type where class is reference type
     * struct stored is stack and class stored in heap
     * Struct can not inherit from another
     */
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Lokman");
            employee.PrintEmployee();

            Employee emp = new Employee();
            emp.Id = 2;
            emp.Name = "Luchu";
            emp.PrintEmployee();

            Employee emp2 = new Employee();
            emp2.PrintEmployee();
        }
    }

    public struct Employee
    {
        private int _id;
        private string _name;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id should be greter then 0");
                }

                this._id = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    this._name = "Not Set";
                else
                    this._name = value;
            }
        }

        public Employee(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Id {0} Name {1}", this._id, this._name);
        }
    }
}
