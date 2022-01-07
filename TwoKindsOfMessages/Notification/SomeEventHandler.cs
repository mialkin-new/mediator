using MediatR;

namespace Mediator.TwoKindsOfMessages.Notification;

public class SomeEventHandler : INotificationHandler<SomeEvent>
{
    private readonly ILogger<SomeEventHandler> _logger;

    public SomeEventHandler(ILogger<SomeEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(SomeEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Event handled by {EventHandler} with message: {Message}",
            nameof(SomeEventHandler), notification.Message);
        
        return Task.CompletedTask;
    }
}