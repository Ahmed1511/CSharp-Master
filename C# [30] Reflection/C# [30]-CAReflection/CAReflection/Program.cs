using System;

namespace CAReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            var t1 = DateTime.Now.GetType();     // at runTime
            Console.WriteLine(t1);
            var t2 = typeof(DateTime);    // at complie time
            Console.WriteLine(t2);
            Console.WriteLine($"Full Name : {t1.FullName}");
            Console.WriteLine($"NameSapce : {t1.Namespace}");
            Console.WriteLine($"Name : {t1.Name}");
            Console.WriteLine($"Base Type : {t1.BaseType}");
            Console.WriteLine($"Base Type : {t1.IsPublic}");
            Console.WriteLine($"Base Type : {t1.IsAbstract}");

            var t3 = typeof(int[,]);
            Console.WriteLine($"T3 Type : {t3.Name}");

            var nestedType = typeof(employee).GetNestedTypes();
            for (int i = 0; i < nestedType.Length; i++)
            {
                Console.WriteLine(nestedType[i]);
            }
            Console.WriteLine("-----------");

            var t5 = typeof(int);
            var interfaces = t5.GetInterfaces();
            for (int i = 0; i < interfaces.Length; i++)
            {
                Console.WriteLine(interfaces[i]);
            }
            #endregion


        }

        internal class employee
        {
        }


    }
}
