using System;
using System.Threading;

namespace Lesson05.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var client = new CalculatorClient())
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine(client.Add(10, 20));
                    Thread.Sleep(5000);
                }
            }

            Console.ReadLine();
        }
    }
}
