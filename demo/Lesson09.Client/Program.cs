using Contracts;
using System;

namespace Lesson09.Client
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var client = new HierarchyClient())
            {
                var r1 = (AttivaLicenzaResponse)client.Execute(new AttivaLicenzaRequest());
                Console.WriteLine(r1.Message);

                var r2 = (AttivaLicenzaV2Response)client.Execute(new AttivaLicenzaV2Request());
                Console.WriteLine(r2.Message);
                //client.Save(new Person { Name = "Alessandro", Surname = "Melchiori" });
                //client.Save(new Manager { Name = "Alessandro", Surname = "Melchiori", Role = "Trainer" });
            }

            Console.ReadLine();
        }
    }
}
