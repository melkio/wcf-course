using Contracts;
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
                    client.Add(10, 20);
                    client.AddComplex(new ComplexNumber(), new ComplexNumber());

                    Console.WriteLine("Good!!!!");

                    Thread.Sleep(5000);
                }
            }

            Console.ReadLine();
        }
    }
}
