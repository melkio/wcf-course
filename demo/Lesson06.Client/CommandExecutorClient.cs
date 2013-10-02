using Contracts;
using System;
using System.ServiceModel;

namespace Lesson06.Client
{
    class CommandExecutorClient 
    {
        public void Execute(String message, ICommandExecutedCallback callback)
        {
            var channel = DuplexChannelFactory<ICommandExecutor>.CreateChannel(callback, "executor");
            channel.Execute(message);
        }
    }
}
