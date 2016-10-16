using reactive.pipes;
using System;
using System.Threading.Tasks;

namespace ReactivePipesGettingStarted
{
    public class DelegatingConsumer<T> : IConsume<T>
    {
        private Action<T> _delegate;

        public DelegatingConsumer(Action<T> @delgate) {
            _delegate = @delgate;
        }

        public Task<bool> HandleAsync(T message)
        {
            _delegate(message);
            return Task.FromResult(true);
        }
    }
}
