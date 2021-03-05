using System;

namespace ParametersByRefAndVal
{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            int sum, mul, div, sub;
            p.Arithmetic(5, 7, out sum, out mul, out div, out sub);
            Console.WriteLine("Sum = {0}, Sub = {1}, Mul = {2}, Div ={3}", sum, sub, mul, div);

            int x=5;
            p.TestMe(ref x);
            Console.WriteLine("Result = {0}", x);

        }

        public void Arithmetic(int a, int b, out int sum, out int mul, out int div, out int sub)
        {
            sum = a + b;
            mul = a * b;
            div = a / b;
            sub = a - b;
        }

        public void TestMe(ref int y)
        {
            y = 50;
        }
    }
}
