using MediatR;

namespace Mediator.TwoKindsOfMessages.Notification;

public class SomeEvent : INotification
{
    public SomeEvent(string message)
    {
        Message = message;
    }

    public string Message { get; }
}