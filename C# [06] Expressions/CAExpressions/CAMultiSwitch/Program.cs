using System;

namespace CAMultiSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 4;

            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even");
                    break;


            }
            Console.ReadKey();
        }
    }
}
