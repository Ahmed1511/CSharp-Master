using System;
using System.Linq;

namespace CAarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // single dimantional Array.           

            //string[] frds = new string[3];
            //string[] campFrien = new string[] { "aaa", "bbb", "ccc" };
            //string[] frinds = { "ali", "ahmed", "Lina", "sasa", "papa" };
            //var myFrinds = new string[] { "ali", "samir", "baiomi" };
            //frinds.Print();

            //rectangular Array (multi dimentional)

            //int[,] sudoco =
            //{
            //{2,5,7,9,6,4,1,4,8 },
            //{2,1,7,9,3,4,3,4,8 },
            //{2,5,7,7,6,2,1,4,8 },
            //{2,5,7,9,6,2,2,4,8 },
            //{4,5,7,9,6,4,2,4,8 },
            //{5,5,7,9,6,4,2,4,8 },
            //{9,5,7,8,6,1,2,4,8 },
            //{8,5,7,8,6,1,2,4,8 },
            //{6,5,7,8,6,1,2,4,8 },
            //{1,5,7,8,6,1,2,4,8 },
            //};

            // Jagged Array is multi dimin arry but save sets of null values so its performance is higher

            //var Jagged = new int[][]
            //{
            //    new int[]{1,3,8},
            //    new int[]{7,8,4},
            //    new int[]{ 7}
            //};

            // indices and ranges
            string[] frinds = { "ali", "ahmed", "Lina", "sasa", "papa" };
            // first 2
            var slice = frinds[..2];
            // last 2
            var slice2 = frinds[2..];
            // start from 2 to 3 is exclusive
            var slice3 = frinds[2..3];

            var slice4 = frinds[2..^2];
            //slice.Print();
            //slice2.Print();
            //slice3.Print();
            slice4.Print();

            Console.WriteLine();
        }

    }
    public static class Extintion
    {
        public static void Print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("{}");
                return;
            }
            Console.WriteLine("");

            for (int i = 0; i < source.Length; i++)
            {
                Console.WriteLine($"{source[i]}");
                Console.WriteLine(i < source.Length - 1 ? "," : "");
            }
            Console.WriteLine(" } ");
        }
    }
}
