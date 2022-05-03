using System;
using System.Reflection;

namespace CAReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\DELL\Desktop\MOE.dll";
            var assembly = Assembly.LoadFile(path);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type);
            }
            Console.ReadKey();
        }
    }
}
