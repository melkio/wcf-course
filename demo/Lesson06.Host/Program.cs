using Services;
using System;
using System.ServiceModel;

namespace Lesson06.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(CommandExecutor)))
            {
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
