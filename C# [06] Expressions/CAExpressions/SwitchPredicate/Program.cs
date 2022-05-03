using System;

namespace SwitchPredicate
{
    class Program
    {
        // predicate
        static void Main(string[] args)
        {
            bool IsVip = true;

            switch (IsVip)
            {
                case bool i when i == true:
                    Console.WriteLine("yes");
                    break;

                case bool i:
                    Console.WriteLine("No");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
