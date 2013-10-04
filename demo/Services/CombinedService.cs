using Contracts;
using Contracts.Behaviors;
using System;
namespace Services
{
    [MyServiceBehavior]
    public class CombinedService : ICalculator, IEcho
    {
        public String Echo(String text)
        {
            return String.Concat("Echoed: ", text);
        }

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
