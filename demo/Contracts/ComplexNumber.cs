using System;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class ComplexNumber
    {
        [DataMember]
        public Double Real { get; set; }
        [DataMember]
        public Double Immaginary { get; set; }
    }
}
