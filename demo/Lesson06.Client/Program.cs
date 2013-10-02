using Contracts;
using System;
using System.ServiceModel;

namespace Lesson06.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            var client = new CommandExecutorClient();
            client.Execute("Command01", new CommandExecutedCallback());

            Console.ReadLine();
        }
    }
}
