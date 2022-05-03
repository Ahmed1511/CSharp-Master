using System;
using System.Threading;

namespace CASequentialModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var wallet = new Wallet("issam", 80);

            wallet.RandomTransaction();
            Console.WriteLine("------------------");
            Console.WriteLine($"{wallet}\n");

            wallet.RandomTransaction();
            Console.WriteLine("------------------");
            Console.WriteLine($"{wallet}\n");
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
            BitCoins -= ammount;

        }

        public void Credit(int amount)
        {
            BitCoins += amount;
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
