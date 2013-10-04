using System;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    [KnownType(typeof(Manager))]
    public class Person
    {
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Surname { get; set; }
    }

    [DataContract]
    public class Manager : Person
    {
        [DataMember]
        public String Role { get; set; }
    }
}
