using System;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IHierarchyService
    {
        [OperationContract]
        Boolean Save(Person person);
    }
}
