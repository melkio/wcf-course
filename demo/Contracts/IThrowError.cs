using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IThrowError
    {
        [OperationContract]
        void Throw();
    }
}
