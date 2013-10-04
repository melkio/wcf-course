using Services;
using System;
using System.ServiceModel;

namespace Lesson09.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(RequestProcessor)))
            {
                host.Description.Behaviors.Add(new DependencyInjectionServiceBehavior(new StaticServiceProvider()));
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
