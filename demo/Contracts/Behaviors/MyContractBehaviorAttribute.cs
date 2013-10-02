using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Contracts.Behaviors
{
    public class MyContractBehaviorAttribute : Attribute, IContractBehavior
    {
        public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            Console.WriteLine("Inside {0}.{1}, contract {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, contractDescription.ContractType.Name);
        }

        public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            Console.WriteLine("Inside {0}.{1}, contract {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, contractDescription.ContractType.Name);
        }

        public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
        {
            Console.WriteLine("Inside {0}.{1}, contract {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, contractDescription.ContractType.Name);
        }

        public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint)
        {
            Console.WriteLine("Inside {0}.{1}, contract {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, contractDescription.ContractType.Name);
        }
    }
}
