using Contracts;
using Services;
using System;
using System.ServiceModel;

namespace Lesson03.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(CalculatorImpl)))
            {
                host.AddServiceEndpoint(
                    typeof(ICalculator),
                    new NetTcpBinding(),
                    "net.tcp://localhost:8080/calculator");
                host.Extensions.Add(new ServiceHostLoggingExtension());
                host.Open();

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
