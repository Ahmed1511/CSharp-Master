using System;

namespace CA03Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jumb [ break - continue - (goto) - return ]
            var i = 0;
            start:
            if (i < 5)
            {
                Console.Write(i + " ");
                i++;
                goto start;
            }

            Console.ReadKey();
        }
    }
}
