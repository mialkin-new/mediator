using MediatR;

namespace Mediator.TwoKindsOfMessages.RequestResponse;

public class SomeRequest : IRequest<string>
{
    public SomeRequest(string message)
    {
        Message = message;
    }
    public string Message { get; }
}