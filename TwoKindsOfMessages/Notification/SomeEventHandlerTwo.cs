using MediatR;

namespace Mediator.TwoKindsOfMessages.Notification;

public class SomeEventHandlerTwo : INotificationHandler<SomeEvent>
{
    private readonly ILogger<SomeEventHandlerTwo> _logger;

    public SomeEventHandlerTwo(ILogger<SomeEventHandlerTwo> logger)
    {
        _logger = logger;
    }
    public Task Handle(SomeEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Event handled by {EventHandler} with message: {Message}",
            nameof(SomeEventHandlerTwo), notification.Message);
        
        return Task.CompletedTask;
    }
}