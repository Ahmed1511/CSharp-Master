using System;

namespace CABoolienTypeandOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tootal = 1000;
            //var vipThresholder = 900;
            //var isVip = tootal >= vipThresholder; // comparason operator >,<,<=
            //Console.WriteLine(isVip);
            #region Logical Operators

            // Conditional operator && || ^(Xor)  ===>> make short circuit

            //Console.WriteLine("------ && -----");
            //Console.WriteLine(true  &&  true);
            //Console.WriteLine(true  &&  false);
            //Console.WriteLine(false &&  true);
            //Console.WriteLine(false &&  false);
            //Console.WriteLine("-----||-------");
            //Console.WriteLine(true  || true);
            //Console.WriteLine(true  || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine("-------^---------");
            //Console.WriteLine(true  ^ true);
            //Console.WriteLine(true  ^ false);
            //Console.WriteLine(false ^ true);
            //Console.WriteLine(false ^ false);
            #endregion


            #region LongCuicuit
            // & |   ==>> dont make short circuit

            //Console.WriteLine(true & true);
            //Console.WriteLine(true & false);
            //Console.WriteLine(false & true);
            //Console.WriteLine(false & false);

            //bool value = true | check();   // dont make short circuit
            #endregion

            #region Ternary Operator
            var total = 1000;
            var vipThresholder = 900;
            var isVip = total >= vipThresholder ? true : false;
            var discount = total >= vipThresholder ? 0.05 : 0.0;
            #endregion









            Console.ReadKey();
        }
        static bool check()
        {
            Console.WriteLine("checking");
            return true;
        }
    }
}
