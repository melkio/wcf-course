using Contracts;
using System;
using System.Linq;

namespace Services
{
    public class RequestProcessor : IRequestProcessor
    {
        private readonly RequestHandler[] _handlers;

        public RequestProcessor(RequestHandler[] handlers)
        {
            _handlers = handlers;
        }

        public Response Execute(Request request)
        {
            var handler = _handlers.Single(h => h.ShouldHandle(request));
            return handler.Handle(request);
        }
    }

    public abstract class RequestHandler
    {
        public abstract Response Handle(Request request);
        public abstract Boolean ShouldHandle(Request request);
    }

    public class AttivaLicenzaHandler : RequestHandler
    {
        public override Response Handle(Request request)
        {
            // ATTIVAZIONE LICENZA V1

            return new AttivaLicenzaResponse { Message = "VERSIONE 1" };
        }

        public override Boolean ShouldHandle(Request request)
        {
            return request is AttivaLicenzaRequest;
        }
    }

    public class AttivaLicenzaV2Handler : RequestHandler
    {
        public override Response Handle(Request request)
        {
            // ATTIVAZIONE LICENZA V2

            return new AttivaLicenzaV2Response { Message = "VERSIONE 2" };
        }

        public override Boolean ShouldHandle(Request request)
        {
            return request is AttivaLicenzaV2Request;
        }
    }

}
