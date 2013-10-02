using Contracts;
using Services;
using System;

namespace Lesson08.Host
{
    class StaticServiceProvider : IServiceProvider
    {
        public Object GetService(Type serviceType)
        {
            if (serviceType == typeof(CalculatorImplWithLog))
            {
                return new CalculatorImplWithLog
                    (
                        inner: new CalculatorImpl(),
                        log: new ConsoleLogger()
                    );
            }

            throw new NotSupportedException();
        }
    }
}
