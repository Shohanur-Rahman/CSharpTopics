using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Father();
            human.Id = 5;
            human.Print();
        }
    }

    abstract class Human
    {
        public int Id { get; set; }
        public abstract void Print();
    }

    abstract class Employee:Human
    {

    }

    class Father : Human
    {
        
        public override void Print()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
