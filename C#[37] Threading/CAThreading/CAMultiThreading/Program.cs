using System;
using System.Threading;

namespace CAMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine(Thread.CurrentThread.Name);
            //  Console.WriteLine($"BackGround Thread :{Thread.CurrentThread.IsBackground}");

            var wallet = new Wallet("essam", 80);
            Thread t1 = new Thread(wallet.RandomTransaction);
            t1.Name = "T1";
            Console.WriteLine($"BackGround Thread :{t1.IsBackground}");
            Console.WriteLine($"after Decleration {t1.Name} state is :{t1.ThreadState}");

            t1.Start();
            Console.WriteLine($"after starting {t1.Name} state is :{t1.ThreadState}");
            t1.Join();

            Thread t2 = new Thread(new ThreadStart(wallet.RandomTransaction));
            t2.Name = "T2";
            t2.Start();

            Console.WriteLine($"after start {t1.Name} state is :{t1.ThreadState}");
            Console.ReadKey();
        }
    }

    public class Wallet
    {
        public string Name { get; private set; }
        public int BitCoins { get; private set; }
        public Wallet(string name, int bitCoins)
        {
            Name = name;
            BitCoins = bitCoins;
        }

        public void Debit(int ammount)
        {
            Thread.Sleep(1000);
            BitCoins -= ammount;
            Console.WriteLine($"[thread{Thread.CurrentThread.ManagedThreadId}" + $", processor Id :  {Thread.GetCurrentProcessorId()}]-{ammount}");

        }

        public void Credit(int ammount)
        {
            Thread.Sleep(1000);
            BitCoins += ammount;
            Console.WriteLine($"[thread{Thread.CurrentThread.ManagedThreadId}" + $", processor Id :  {Thread.GetCurrentProcessorId()}]+{ammount}");

        }

        public void RandomTransaction()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 };

            foreach (var amount in amounts)
            {
                var absValue = Math.Abs(amount);
                if (amount < 0)
                {
                    Debit(absValue);
                }
                else
                {
                    Credit(absValue);
                    Console.WriteLine($"Thread :{Thread.CurrentThread.ManagedThreadId}" + "," + $"processor ID :{Thread.GetCurrentProcessorId()}{amount}");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} ->{BitCoins} Bitcoins";
        }


    }
}
