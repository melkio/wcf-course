using System;
using System.ServiceModel;

namespace Lesson01.Contracts
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Int32 Add(Int32 a, Int32 b);
    }
}
