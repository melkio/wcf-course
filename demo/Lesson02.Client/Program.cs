using System;

namespace Lesson02.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var client = new CalculatorClient())
                Console.WriteLine(client.Add(10, 20));

            Console.ReadLine();
        }
    }
}
