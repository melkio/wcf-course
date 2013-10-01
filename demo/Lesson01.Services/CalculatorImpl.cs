using Lesson01.Contracts;
using System;

namespace Lesson01.Services
{
    public class CalculatorImpl : ICalculator
    {
        public Int32 Add(Int32 a, Int32 b)
        {
            return a + b;
        }
    }
}
