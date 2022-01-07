using MediatR;

namespace Mediator.TwoKindsOfMessages.RequestResponse;

public class SomeRequestHandler : IRequestHandler<SomeRequest, string>
{
    public Task<string> Handle(SomeRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult($"Request has been handled with message: {request.Message}");
    }
}