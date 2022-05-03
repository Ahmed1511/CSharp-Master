using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            var Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            d1.PrintEven(Numbers);
            
        }
    }

    public class Demo
    {
        public void PrintEven(int[] original)
        {
            foreach (var n in original)
            {
                if (IsEven(n))
                {
                    Console.Write(n + " ");
                }
            }
             // local Method tha used inside this method only
            bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        }

        

        

    }
}
