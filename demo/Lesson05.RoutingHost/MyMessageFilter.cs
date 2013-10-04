using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Lesson05.RoutingHost
{
    public class MyMessageFilter : MessageFilter
    {
        private readonly String _matchData;

        public MyMessageFilter(String matchData)
        {
            _matchData = matchData;
        }

        public override Boolean Match(Message message)
        {
            return message.Headers.Action.EndsWith(_matchData);
        }

        public override Boolean Match(MessageBuffer buffer)
        {
            throw new NotImplementedException();
        }
    }
}
