﻿using Contracts;
using Services;
using System;
using System.ServiceModel;

namespace Lesson04.Host
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var host = new ServiceHost(typeof(ThrowErrorImpl)))
            {
                host.Open();

                Console.ReadLine();
            }
        }
    }
}
