using MediatR;

namespace Mediator.TwoKindsOfMessages.RequestResponse;

public class PingRequestHandler : IRequestHandler<PingRequest, string>
{
    public Task<string> Handle(PingRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult("Request has been handled");
    }
}