using System;

namespace AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator objCalc = new Calculator();

            int result;

            result = objCalc.Add();
            result = objCalc.Add(10);
            result = objCalc.Compute(100,200,Program.Multiply);

        }

        private static int Multiply(int a, int b)
        {
            return a * b;   
        }
    }
}
