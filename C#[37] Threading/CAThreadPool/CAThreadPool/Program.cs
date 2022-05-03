using System;
using System.Threading;
using System.Threading.Tasks;

namespace CAThreadPool
{
    class Program
    {
        //1
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(Print));
            Console.WriteLine("Hello World!");
        }

        // 2
       


        private static void Print( )
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" is BackGround :{Thread.CurrentThread.IsBackground}");
                Console.WriteLine($"cycle{i + 1}");
            }
        }

        private static void Print(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" is BackGround :{Thread.CurrentThread.IsBackground}");
                Console.WriteLine($"cycle{i + 1}");
            }
        }
    }
}
