using System;

namespace Lesson04.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var client = new ThrowErrorClient())
            {
                try
                {
                    client.Throw();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
