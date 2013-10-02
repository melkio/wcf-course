using Contracts;
using Services;
using System;
using System.ServiceModel;

namespace Lesson04.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(ThrowErrorImpl)))
            {
                //host.AddServiceEndpoint(
                //    typeof(IThrowError),
                //    new NetTcpBinding(),
                //    "net.tcp://localhost:8080/throw");
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
