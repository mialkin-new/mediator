using System.Diagnostics;
using MediatR;

namespace Mediator.TwoKindsOfMessages.Notification;

public class PingNotificationHandler : INotificationHandler<PingNotification>
{
    public Task Handle(PingNotification notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Notification handled by HANDLER 1");
        return Task.CompletedTask;
    }
}