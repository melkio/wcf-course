using Contracts;
using System;
using System.ServiceModel;

namespace Lesson09.Client
{
    class HierarchyClient : ClientBase<IRequestProcessor>, IRequestProcessor
    {
        public Response Execute(Request request)
        {
            return Channel.Execute(request);
        }
    }
}
