using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParellelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<Action> measure = (body) =>
            {
                var starttime = DateTime.Now;
                body();
                Console.WriteLine(" {0}, {1}", DateTime.Now - starttime, Thread.CurrentThread.ManagedThreadId);
            };

            Action calcJob = () =>
            {
                for (int i = 0; i < 350000; i++) ;
            };

            Action ioJob = () => { Thread.Sleep(2000); };

            //measure(() =>
            //{
            //    var tasks = Enumerable.Range(1, 10)
            //    .Select(_ => Task.Factory.StartNew(() => measure(calcJob)))
            //    .ToArray();

            //    Task.WaitAll(tasks);
            //});

            //Parallel.For(0, 10, _ => { measure(ioJob); });

            Enumerable.Range(1, 10)
                .AsParallel().ForAll(_ => measure(ioJob)); 

            Console.ReadLine();
        }
    }
}
