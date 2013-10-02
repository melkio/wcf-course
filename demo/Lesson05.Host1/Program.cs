using Services;
using System;
using System.ServiceModel;

namespace Lesson05.Host1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("HOST01");
            using (var host = new ServiceHost(typeof(CalculatorImpl)))
            {
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
