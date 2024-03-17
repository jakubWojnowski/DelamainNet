

using Confab.Shared.Abstractions.Messaging;
using Confab.Shared.Infrastructure.Messaging.Dispatcher;
using DelamainNet.Shared.Infrastructure.Messaging.Brokers;
using Microsoft.Extensions.DependencyInjection;

namespace DelamainNet.Shared.Infrastructure.Messaging;

internal static class Extensions
{
    private const string SectionName = "messaging";
    internal static IServiceCollection AddMessaging(this IServiceCollection services)
    {
        services.AddSingleton<IMessageBroker, InMemoryMessageBroker>();
        services.AddSingleton<IMessageChannel, MessageChannel>();
        services.AddSingleton<IAsyncMessageDispatcher, AsyncMessageMessageDispatcher>();
        

        var messagingOptions = services.GetOptions<MessagingOptions>(SectionName);
        services.AddSingleton(messagingOptions);
        if (messagingOptions.UseBackgroundDispatcher)
        {
            services.AddHostedService<BackGroundDispatcher>();
            
        }
    
        return services;
    }
}