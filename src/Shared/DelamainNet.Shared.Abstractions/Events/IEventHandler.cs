using System.Threading.Tasks;
using DelamainNet.Shared.Abstractions.Events;

namespace Confab.Shared.Abstractions.Events;

    public interface IEventHandler<in TEvent> where TEvent : class, IEvent
    {
        Task HandleAsync(TEvent @event);
    }
