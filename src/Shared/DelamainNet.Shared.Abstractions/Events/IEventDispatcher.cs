using System.Threading.Tasks;
using DelamainNet.Shared.Abstractions.Events;

namespace Confab.Shared.Abstractions.Events
{
    public interface IEventDispatcher
    {
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : class, IEvent;
    }
}