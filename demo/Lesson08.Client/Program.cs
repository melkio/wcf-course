using Contracts;
using System;

namespace Lesson08.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            var client = new CalculatorClient();
            client.Add(10, 20);
            client.AddComplex
                (
                    a: new ComplexNumber { Real = 10, Immaginary = 20 },
                    b: new ComplexNumber { Real = 100, Immaginary = 200 }
                );

            Console.ReadLine();
        }
    }
}
