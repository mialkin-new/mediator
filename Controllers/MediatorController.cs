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
    public Task<string> SendRequest()
    {
        return _mediator.Send(new PingRequest());
    }

    [HttpGet]
    [Route("SendNotification")]
    public Task SendNotification()
    {
        return _mediator.Publish(new PingNotification());
    }
}