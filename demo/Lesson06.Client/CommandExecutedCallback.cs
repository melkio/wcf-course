using Contracts;
using System;

namespace Lesson06.Client
{
    class CommandExecutedCallback : ICommandExecutedCallback
    {
        public void Executed(String message)
        {
            Console.WriteLine(message);
        }
    }
}
