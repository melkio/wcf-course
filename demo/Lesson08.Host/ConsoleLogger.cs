using Services;
using System;

namespace Lesson08.Host
{
    class ConsoleLogger : ILog
    {
        public void Trace(String message)
        {
            Console.WriteLine(message);
        }
    }
}
