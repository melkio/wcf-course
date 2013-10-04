using System;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract(CallbackContract = typeof(ICommandExecutedCallback))]
    public interface ICommandExecutor   
    {
        [OperationContract(IsOneWay=true)]
        void Execute(String message);
    }

    [ServiceContract]
    public interface ICommandExecutedCallback
    {
        [OperationContract(IsOneWay=true)]
        void Executed(String message);
    }
}
