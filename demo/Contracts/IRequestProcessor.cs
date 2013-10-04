using System.Runtime.Serialization;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IRequestProcessor
    {
        [OperationContract]
        Response Execute(Request request);
    }
}
