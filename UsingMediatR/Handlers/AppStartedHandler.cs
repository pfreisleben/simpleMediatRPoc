using MediatR;
using UsingMediatR.Events;

namespace UsingMediatR.Handlers;

public class AppStartedHandler : INotificationHandler<ApplicationStartedEvent>
{
    public async Task Handle(ApplicationStartedEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Evento recebido com sucesso!");
        Console.WriteLine($"Horário que o aplicativo iniciou: {notification.StartedAt}");
        Console.WriteLine($"Mensagem deixada: {notification.Message}");
        Console.WriteLine($"Quem iniciou a aplicação: {notification.Name}");
        await Task.CompletedTask;
    }
}