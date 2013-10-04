using System;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    [KnownType(typeof(AttivaLicenzaRequest))]
    [KnownType(typeof(AttivaLicenzaV2Request))]
    public abstract class Request
    {
    }

    [DataContract]
    [KnownType(typeof(AttivaLicenzaResponse))]
    [KnownType(typeof(AttivaLicenzaV2Response))]
    public abstract class Response
    {
    }
}
