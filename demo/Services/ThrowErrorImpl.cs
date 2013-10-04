using Contracts;
using System;
using System.ServiceModel;

namespace Services
{
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ThrowErrorImpl : IThrowError
    {
        public void Throw()
        {
            throw new NotImplementedException();
        }
    }
}
