using System;

namespace SwitchCaseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeCost = 0;

            Start:
            Console.WriteLine("1 = small, 2 = Medium and 3 = Large\nEnter your choice");
            int userChoice = Int32.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalCoffeCost += 30;
                    break;
                case 2:
                    totalCoffeCost += 50;
                    break;
                case 3:
                    totalCoffeCost += 70;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    goto Start;
            }
            Console.WriteLine("Your bill amount is {0}", totalCoffeCost);
            Console.WriteLine("Do you want to buy more coffe yes/no");

            string userOptions = Console.ReadLine();

            switch (userOptions)
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    goto Start;
            }

            Console.WriteLine("Your bill amount is {0}", totalCoffeCost);
        }
    }
}
