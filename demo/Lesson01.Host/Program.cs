using Contracts;
using Services;
using System;
using System.ServiceModel;

namespace Lesson01.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(CalculatorImpl)))
            {
                host.AddServiceEndpoint(
                    typeof(ICalculator),                        // contract
                    new NetTcpBinding(),                        // binding
                    "net.tcp://localhost:8080/calculator");     // address
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
