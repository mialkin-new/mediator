using MediatR;

namespace Mediator.TwoKindsOfMessages.RequestResponse;

public class PingRequest : IRequest<string> { }