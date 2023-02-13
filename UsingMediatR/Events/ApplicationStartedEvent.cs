using MediatR;

namespace UsingMediatR.Events;

public class ApplicationStartedEvent : INotification
{
    public ApplicationStartedEvent(DateTime startedAt, string message, string name)
    {
        StartedAt = startedAt;
        Message = message;
        Name = name;
    }

    public DateTime StartedAt { get; init; }
    public string Message { get; init; }
    public string Name { get; init; }
}
