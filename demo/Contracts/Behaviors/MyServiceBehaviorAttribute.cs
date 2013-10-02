using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Contracts.Behaviors
{
    public class MyServiceBehaviorAttribute : Attribute, IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            Console.WriteLine("Inside {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            Console.WriteLine("Inside {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            Console.WriteLine("Inside {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
    }
}
