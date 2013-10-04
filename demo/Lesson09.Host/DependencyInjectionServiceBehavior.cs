using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System;

namespace Lesson09.Host
{
    class DependencyInjectionServiceBehavior : IServiceBehavior
    {
        private readonly IServiceProvider _serviceProvider;

        public DependencyInjectionServiceBehavior (IServiceProvider serviceProvider)
	    {
            _serviceProvider = serviceProvider;
	    }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        { 
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            serviceHostBase.ChannelDispatchers
                .OfType<ChannelDispatcher>()
                .SelectMany(d => d.Endpoints)
                .ToList()
                .ForEach(e => e.DispatchRuntime.InstanceProvider = new DependencyInjectionInstanceProvider(_serviceProvider, serviceDescription.ServiceType));
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        { 
        }
    }
}
