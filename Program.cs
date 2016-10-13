using reactive.pipes;
using reactive.pipes.Producers;
using System.Reactive.Linq;
using System.Threading;
using System;
namespace ReactivePipesGettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            var block = new ManualResetEvent(false);
            var producer = new ObservingProducer<int>();
            var consumer = new DelegatingConsumer<int>();

            producer.Produces(Observable.Range(1, 10000), onCompleted: () => block.Set());
            producer.Attach(consumer);
            producer.Start();

            block.WaitOne();
            Console.ReadLine();
        }
    }
}
