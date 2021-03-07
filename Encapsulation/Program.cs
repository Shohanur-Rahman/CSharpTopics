using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Lokman";
            employee.PrintInfo();
            
        }
    }

    class Employee
    {
        private int _id;
        private string _name;
        private int _salary=15000;

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
                    throw new Exception("Student id should be greater then 0");
                }
                this._id = value;
            }

        }

        public int Salary
        {
            get
            {
                return this._salary;
            }
            set
            {
                if (value == 0)
                    this._salary = 15000;
                else
                    this._salary = value;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can not be null or empty");
                }
                this._name = value;
            }
            get
            {
                return (string.IsNullOrEmpty(this._name)) ? "No name" : this._name;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Id {0}, Name {1}, Salary {2}", this._id, this._name, this._salary);
        }
    }
}
