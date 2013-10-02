
using Services;
using System;
using System.ServiceModel;
namespace Lesson08.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(CalculatorImplWithLog)))
            {
                host.Description.Behaviors.Add(new DependencyInjectionServiceBehavior(new StaticServiceProvider()));
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
