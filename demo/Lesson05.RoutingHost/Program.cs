using System;
using System.ServiceModel;
using System.ServiceModel.Routing;

namespace Lesson05.RoutingHost
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(RoutingService)))
            {
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
