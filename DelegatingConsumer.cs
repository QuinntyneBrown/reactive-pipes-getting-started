using reactive.pipes;
using System;
using System.Threading.Tasks;

namespace ReactivePipesGettingStarted
{
    class DelegatingConsumer<T> : IConsume<T>
    {
        private Action<T> _action;
        
        public DelegatingConsumer(Action<T> action) {
            _action = action;
        }

        public Task<bool> HandleAsync(T message)
        {
            _action(message);
            return Task.FromResult(true);
        }
    }
}
