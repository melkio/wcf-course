using System;

namespace Contracts
{
    public class AttivaLicenzaRequest : Request
    {
        public Int32 UserId { get; set; }
        public String key { get; set; }
    }

    public class AttivaLicenzaResponse : Response
    {
        public String Message { get; set; }
    }
}
