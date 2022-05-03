using System;

namespace CABreak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jumb [ (break) - continue - goto - return ]
            var i = 0;
            while (i < 10)
            {
                if (i > 5)
                    break;
                Console.WriteLine(i);
                ++i;

            }
            Console.ReadKey();
        }
    }
}
