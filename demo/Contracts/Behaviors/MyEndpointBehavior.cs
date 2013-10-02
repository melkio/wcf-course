using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Contracts.Behaviors
{
    public class MyEndpointBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            Console.WriteLine("Inside {0}.{1}, endpoint {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, endpoint.Name);
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            Console.WriteLine("Inside {0}.{1}, endpoint {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, endpoint.Name);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            Console.WriteLine("Inside {0}.{1}, endpoint {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, endpoint.Name);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            Console.WriteLine("Inside {0}.{1}, endpoint {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, endpoint.Name);
        }
    }
}
