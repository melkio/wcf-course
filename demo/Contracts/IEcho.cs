using System;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IEcho
    {
        [OperationContract]
        String Echo(String text);
    }
}
