using Contracts;
using System;

namespace Services
{
    public class CalculatorImplWithLog : ICalculator
    {
        private readonly ICalculator _inner;
        private readonly ILog _log;

        public CalculatorImplWithLog(ICalculator inner, ILog log)
        {
            _inner = inner;
            _log = log;
        }

        public Int32 Add(Int32 a, Int32 b)
        {
            _log.Trace("Add -> IN");
            var result = _inner.Add(a, b);
            _log.Trace("Add -> OUT");

            return result;
        }

        public ComplexNumber AddComplex(ComplexNumber a, ComplexNumber b)
        {
            _log.Trace("AddComplex -> IN");
            var result = _inner.AddComplex(a, b);
            _log.Trace("AddComplex -> OUT");

            return result;
        }
    }
}
