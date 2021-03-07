using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee pte = new PartTime();
            pte.FirstName = "Lokman";
            pte.LastName = "Hossain";
            pte.ShowName();
            pte.PrintMessage();
        }
    }


    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void ShowName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void PrintMessage()
        {
            Console.WriteLine("Base Message");
        }
    }

    class PartTime : Employee
    {
        public override void ShowName()
        {
            Console.WriteLine("Part Time: " + FirstName + " " + LastName);
        }
        public new void PrintMessage()
        {
            Console.WriteLine("Part Time Message");
        }

        /// <summary>
        /// Method overloading not woking based only on return type
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class FullTime : Employee
    {
        public override void ShowName()
        {
            Console.WriteLine("Full time: " + FirstName + " " + LastName);
        }
        public new void PrintMessage()
        {
            Console.WriteLine("Full tim Message");
        }
    }
}
