using reactive.pipes;
using System;
using System.Threading.Tasks;

namespace ReactivePipesGettingStarted
{
    class DelegatingConsumer<T> : IConsume<T>
    {
        public DelegatingConsumer() { }

        public Task<bool> HandleAsync(T message)
        {
            Console.WriteLine($"{message}");
            return Task.FromResult(true);
        }
    }
}
