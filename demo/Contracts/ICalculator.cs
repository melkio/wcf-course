using System;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Int32 Add(Int32 a, Int32 b);

        [OperationContract]
        ComplexNumber AddComplex(ComplexNumber a, ComplexNumber b);

    }
}
