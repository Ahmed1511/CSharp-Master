using System;
using System.Threading;
using System.Threading.Tasks;

namespace CA05TaskDelay
{
    class Program
    {
        static void Main(string[] args)
        {
            DelayUsingTask(5000);


            Console.ReadKey();
        }

        static void DelayUsingTask(int ms)
        {
            Task.Delay(ms).GetAwaiter().OnCompleted(() =>
            {

                Console.WriteLine($"completed after Task.Delay  {ms}");

            });
        }

        static void SleapUisngThread(int ms)
        {
            Thread.Sleep(ms);
            Console.WriteLine($"Completed after Thread.Sleap  {ms}");
        }
    }
}
