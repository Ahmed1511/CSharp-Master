using System;
using System.Diagnostics;
using System.Threading;

namespace CAThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"the Process ID :{Process.GetCurrentProcess().Id}");
            Console.WriteLine($" the Thread ID :{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($" the current processor ID: {Thread.GetCurrentProcessorId()}");

            Console.ReadKey();
        }
    }
}
