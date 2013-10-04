using Contracts.Behaviors;
using System;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    [MyContractBehavior]
    public interface ICalculator
    {
        [OperationContract]
        [MyOperationBehavior]
        Int32 Add(Int32 a, Int32 b);

        [OperationContract]
        ComplexNumber AddComplex(ComplexNumber a, ComplexNumber b);
    }
}
