using System;

namespace CAWhileDOWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // iteration
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter + " ");
                ++counter;
            }

            Console.WriteLine();
            do
            {
                Console.WriteLine(counter + " ");
                ++counter;
            } while (counter < 10);


            Console.ReadKey();
        }
    }
}
