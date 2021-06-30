using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdevintaApiGateway.Handlers
{
    public class BlackListHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var myHeader = request.Headers.FirstOrDefault(c => c.Key == "MyHeader");

            if (myHeader.Value != null && myHeader.Value.Any())
            {
                return await base.SendAsync(request, cancellationToken);
            }

            var response = new HttpResponseMessage(HttpStatusCode.BadGateway);
            response.ReasonPhrase = "Your header is not valid";
            return await Task.FromResult<HttpResponseMessage>(response);

        }
    }
}
