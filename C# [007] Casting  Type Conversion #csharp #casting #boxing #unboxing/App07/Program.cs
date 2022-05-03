using System;

namespace App07
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ImplicitExplicitCasting

            ////Int16 NumSh;      // short
            ////Int32 NumInt;     // int
            ////Int64 NumLng;     // Long


            //int x = 1000;
            //long y = x;  // convert implecitly

            //if (y <= int.MaxValue)
            //{
            //     int z = (int)y;      // convert Explicitly
            //}

            #endregion

            #region BoxingunBoxing
            // boxing form referance type to Value type it implement Inplicitly

            //int x=10;
            //object obj;

            //obj = x; // boxing implicitly

            //int y =(int) obj;  // unBoxing Explicitly

            #endregion

            #region convertingString

            //string numStr = "1234";
            //int Num = int.Parse(numStr);

            //if (int.TryParse(numStr, out int Number))
            //{
            //    Console.WriteLine(Number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Number Fromat Provided.");
            //}

            #endregion

            #region ConvertCLass
            // convert string to any Num type.

            //string NumStr = "9999999";
            //var i = Convert.ToInt32(NumStr);
            //var E = Convert.ToDouble(NumStr);            
            //var B = Convert.ToSByte(NumStr);
            //Console.WriteLine(i);
            #endregion

            #region BitConverterCLass

            //var Number = 255;
            //var bytes = BitConverter.GetBytes(Number);
            //foreach (var b in bytes)
            //{
            //    Console.WriteLine(b);
            //    Console.WriteLine("-------------");
            //    var binary = Convert.ToString(b, 2).PadLeft(8, '0');
            //    Console.WriteLine(binary);
            //}

            #endregion
            #region BitConvertClass

            var name = "Isaam";
            char[] letters = name.ToCharArray();
            foreach (var l in letters)
            {
                int asci = Convert.ToInt32(l);
                Console.WriteLine(asci);

            }

            #endregion






            Console.WriteLine("Hello World!");
        }


    }

    public class ExplicitCasing
    {





    }
}
