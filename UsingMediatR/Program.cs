using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UsingMediatR.Events;
using UsingMediatR.Extensions;

IHostBuilder host = Host.CreateDefaultBuilder(args);

host.ConfigureServices((host, services) =>
    services.AddDependencyInjection()
);

using IHost app = host.Build();

var mediator = app.Services.GetRequiredService<IMediator>();

mediator.Publish(new ApplicationStartedEvent(DateTime.Now, "Deu certo!", "Pedro"));


await app.RunAsync();