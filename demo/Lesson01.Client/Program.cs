using Contracts;
using System;
using System.ServiceModel;

namespace Lesson01.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            var client = ChannelFactory<ICalculator>.CreateChannel(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:8080/calculator"));
            var result = client.Add(10, 20);

            (client as ICommunicationObject).Close();
        }
    }
}
