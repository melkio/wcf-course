using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Lesson09.Host
{
    class DependencyInjectionInstanceProvider : IInstanceProvider
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Type _serviceType;
        
        public DependencyInjectionInstanceProvider(IServiceProvider serviceProvider, Type serviceType)
        {
            _serviceProvider = serviceProvider;
            _serviceType = serviceType;
        }

        public Object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public Object GetInstance(InstanceContext instanceContext, Message message)
        {
            return _serviceProvider.GetService(_serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, Object instance)
        {
        }
    }
}
