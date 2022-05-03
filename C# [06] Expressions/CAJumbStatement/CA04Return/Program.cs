using System;

namespace CA04Return
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jumb [ break - continue - goto - (return) ]
            var input = 0.44m;
            var result = AsPercentage(input);
            Console.WriteLine(result);

            Console.ReadKey(); ;
        }

        static decimal AsPercentage(decimal amount)
        {
            return amount * 100;
        }
    }
}
