using System;

namespace Lesson07.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            var client = new CalculatorClient();
            client.Add(10, 20);

            Console.ReadLine();
        }
    }
}
