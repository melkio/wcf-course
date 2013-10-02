using Contracts;
using System.ServiceModel;

namespace Lesson04.Client
{
    class ThrowErrorClient : ClientBase<IThrowError>, IThrowError
    {
        public void Throw()
        {
            Channel.Throw();
        }
    }
}
