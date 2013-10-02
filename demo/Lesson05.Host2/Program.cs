using Services;
using System;
using System.ServiceModel;

namespace Lesson05.Host2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("HOST02");
            using (var host = new ServiceHost(typeof(CalculatorImpl)))
            {
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
