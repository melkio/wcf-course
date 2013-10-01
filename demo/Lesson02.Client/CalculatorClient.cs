using Contracts;
using System;
using System.ServiceModel;

namespace Lesson02.Client
{
    class CalculatorClient : ClientBase<ICalculator>, ICalculator
    {
        public Int32 Add(Int32 a, Int32 b)
        {
            return Channel.Add(a, b);
        }
    }
}
