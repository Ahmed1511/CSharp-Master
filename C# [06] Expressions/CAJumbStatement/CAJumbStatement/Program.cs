using System;

namespace CAJumbStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jumb [ break - (continue) - goto - return ]
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i + " ");
            }

            Console.ReadKey();
        }
    }
}
