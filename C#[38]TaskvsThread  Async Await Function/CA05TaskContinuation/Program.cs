using System;
using System.Threading.Tasks;

namespace CA05TaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CountPrimNumberinRang(2, 2_000_000));

            Task<int> task = Task.Run(() => CountPrimNumberinRang(2, 2_000_000));
            // Console.WriteLine(task.Result); // result bad because it blocks the thread (so it used in with actions that take no time)

            //Console.WriteLine("Using awaiter , oncomplete");

            //var awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() =>
            //{
            //    Console.WriteLine(awaiter.GetResult());
            //});

            Console.WriteLine("using task continueWith");

            task.ContinueWith((x) => Console.WriteLine(x.Result));
            Console.WriteLine("Mitigator");
            Console.ReadKey();
        }

        static int CountPrimNumberinRang(int LowBund, int UpperBound)
        {
            var count = 0;
            for (int i = LowBund; i < UpperBound; i++)
            {
                var j = LowBund;
                var isPrim = true;
                while (j < (int)Math.Sqrt(i))
                {
                    if (i % j == 0)
                    {
                        isPrim = false;
                    }
                    ++j;
                }

                if (isPrim)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
