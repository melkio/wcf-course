using Contracts;
using System;
using System.ServiceModel;

namespace Lesson01.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            var client = ChannelFactory<ICalculator>.CreateChannel(new NetTcpBinding(), 
                new EndpointAddress("net.tcp://localhost:8080/calculator"));
            
            client.Add(10, 20);
            client.AddComplex(new ComplexNumber { Real = 10, Immaginary = 20 }, new ComplexNumber { Real = 50, Immaginary = 100 });

            (client as ICommunicationObject).Close();
        }
    }
}
