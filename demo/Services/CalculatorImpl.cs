using Contracts;
using Contracts.Behaviors;
using System;

namespace Services
{
    public class CalculatorImpl : ICalculator
    {
        public Int32 Add(Int32 a, Int32 b)
        {
            return a + b;
        }

        public ComplexNumber AddComplex(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber
                {
                    Real = a.Real + b.Real,
                    Immaginary = a.Immaginary + b.Immaginary
                };
        }
    }
}
