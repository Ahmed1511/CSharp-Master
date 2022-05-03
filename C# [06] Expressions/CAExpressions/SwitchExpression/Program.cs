using System;

namespace SwitchExpression
{
    class Program
    {
        // switch expression.
        static void Main(string[] args)
        {
            var cardNum = 1;
            string cardName = cardNum switch
            {
                1 => "AEC",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                // other wize
                _ => cardNum.ToString()

            };
            Console.WriteLine(cardName);
            Console.ReadKey();
        }
    }
}
