using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonaci number [0,1,1,2,3,5,8,13,21,34,55]
           
            for (int counter = 0 , prev = 0 , current = 1; counter < 10; counter++)
            {
                Console.Write(prev + " ");
                int newFib = prev + current;
                prev = current;
                current = newFib;
            }
            Console.ReadKey();
        }
    }
}
