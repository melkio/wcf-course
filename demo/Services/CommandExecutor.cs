using Contracts;
using System;
using System.ServiceModel;
using System.Threading;

namespace Services
{
    public class CommandExecutor : ICommandExecutor
    {
        public void Execute(String message)
        {
            Thread.Sleep(2500);

            var callback = OperationContext.Current
                .GetCallbackChannel<ICommandExecutedCallback>();

            callback.Executed(String.Concat(message, " executed"));
        }
    }
}
