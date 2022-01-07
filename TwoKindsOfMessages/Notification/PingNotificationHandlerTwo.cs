using System.Diagnostics;
using MediatR;

namespace Mediator.TwoKindsOfMessages.Notification;

public class PingNotificationHandlerTwo : INotificationHandler<PingNotification>
{
    public Task Handle(PingNotification notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Notification handled by HANDLER 2");
        return Task.CompletedTask;
    }
}