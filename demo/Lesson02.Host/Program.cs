using Services;
using System;
using System.ServiceModel;

namespace Lesson02.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(CalculatorImpl)))
            {
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
