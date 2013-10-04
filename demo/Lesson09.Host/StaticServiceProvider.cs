using Contracts;
using Services;
using System;

namespace Lesson09.Host
{
    class StaticServiceProvider : IServiceProvider
    {
        public Object GetService(Type serviceType)
        {
            if (serviceType == typeof(RequestProcessor))
            {
                return new RequestProcessor
                    (
                        new RequestHandler[]
                        {
                            new AttivaLicenzaHandler(),
                            new AttivaLicenzaV2Handler()
                        }
                    );
            }

            throw new NotSupportedException();
        }
    }
}
