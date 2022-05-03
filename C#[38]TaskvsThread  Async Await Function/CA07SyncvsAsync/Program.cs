using System;
using System.Threading;
using System.Threading.Tasks;

namespace CA07SyncvsAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            showThreadInfo(Thread.CurrentThread, 11);

            CallSynchronous();
            showThreadInfo(Thread.CurrentThread, 14);

            CallAsynchronous();
            showThreadInfo(Thread.CurrentThread, 17);

            Console.ReadKey();
        }

        static void CallSynchronous()
        {
            Thread.Sleep(4000);
            showThreadInfo(Thread.CurrentThread, 24);
            Task.Run(() => Console.WriteLine("++++ Synchronous ++++")).Wait();
        }

        static void CallAsynchronous()
        {
            showThreadInfo(Thread.CurrentThread, 30);
            Task.Delay(4000).GetAwaiter().OnCompleted(() =>
            {

                Console.WriteLine("++++ ASynchronous ++++");
            });
        }

        public static void showThreadInfo(Thread th, int line)
        {
            Console.WriteLine($"Line : {line} , TID : {th.ManagedThreadId} ," +
                $" Pooled :{th.IsThreadPoolThread}," +
                $" BackGround :{th.IsBackground}");
        }
    }
}
