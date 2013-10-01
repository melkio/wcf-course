using System;
using System.ServiceModel;

namespace Lesson03.Host
{
    class ServiceHostLoggingExtension : IExtension<ServiceHostBase>
    {
        public void Attach(ServiceHostBase owner)
        {
            owner.Opening += HandleOpening;
            owner.Opened += HandleOpened;
            owner.Closing += HandleClosing;
            owner.Closed += HandleClosed;
        }

        public void Detach(ServiceHostBase owner)
        {
            owner.Opening -= HandleOpening;
            owner.Opened -= HandleOpened;
            owner.Closing -= HandleClosing;
            owner.Closed -= HandleClosed;
        }

        private void HandleOpening(Object sender, EventArgs e)
        {
            Console.WriteLine("Opening service host...");
        }

        private void HandleOpened(Object sender, EventArgs e)
        {
            Console.WriteLine("Service host opened...");
        }

        private void HandleClosing(Object sender, EventArgs e)
        {
            Console.WriteLine("Closing service host...");
        }

        private void HandleClosed(Object sender, EventArgs e)
        {
            Console.WriteLine("Service host closed...");
        }
    }
}
