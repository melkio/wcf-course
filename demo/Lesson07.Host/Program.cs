using Contracts;
using Contracts.Behaviors;
using Services;
using System;
using System.ServiceModel;

namespace Lesson07.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            // Abilitare i (my)beahvior attribute su contract/impl
            using (var host = new ServiceHost(typeof(CalculatorImpl), new Uri("net.tcp://localhost:8080")))
            {
                var endpoint = host.AddServiceEndpoint(
                    typeof(ICalculator),
                    new NetTcpBinding(),
                    "calculator");

                endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());

                host.Open();

                Console.ReadLine();
            }
        }
    }
}
