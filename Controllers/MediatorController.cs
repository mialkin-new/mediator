using Mediator.TwoKindsOfMessages.Notification;
using Mediator.TwoKindsOfMessages.RequestResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Controllers;

[ApiController]
[Route("[controller]")]
public class MediatorController : ControllerBase
{
    private readonly IMediator _mediator;

    public MediatorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("SendRequest")]
    public Task<string> SendRequest(string message)
    {
        return _mediator.Send(new SomeRequest(message));
    }

    [HttpGet]
    [Route("SendNotification")]
    public Task SendNotification(string message)
    {
        return _mediator.Publish(new SomeEvent(message));
    }
}