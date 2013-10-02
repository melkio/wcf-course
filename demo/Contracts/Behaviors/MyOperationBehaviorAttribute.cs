using System;
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Contracts.Behaviors
{
    public class MyOperationBehaviorAttribute : Attribute, IOperationBehavior
    {
        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
            Console.WriteLine("Inside {0}.{1}, operation {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, operationDescription.Name);
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
            Console.WriteLine("Inside {0}.{1}, operation {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, operationDescription.Name);
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            Console.WriteLine("Inside {0}.{1}, operation {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, operationDescription.Name);
        }

        public void Validate(OperationDescription operationDescription)
        {
            Console.WriteLine("Inside {0}.{1}, operation {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, operationDescription.Name);
        }
    }
}
