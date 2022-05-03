using System;

namespace CAExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            var s2 = s1?.ToUpper();
            var s3 = s1 is null ? null : s1.ToUpper();

            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
