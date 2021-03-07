using System;

namespace WhatIsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Son();


            Human human = new Employee();
            human.Id = 5;
            human.InterfaceMethod();
            human.Sound();
        }
    }

    interface Human
    {
        public int Id { get; set; }
        private void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sound()
        {
            Console.WriteLine("Sound Hi");
        }

        public int Add()
        {
            return 5 + 7;
        }

        public void InterfaceMethod();
    }

    interface Father
    {
        public void Son();
        public void InterfaceMethod();
    }

    class Employee : Human, Father
    {
       
        void Human.InterfaceMethod()
        {
            Console.WriteLine("Human");
        }

        public void Son()
        {
            Console.WriteLine("I have a son");
        }

        void Father.InterfaceMethod()
        {
            Console.WriteLine("Father");
        }
    }

}
