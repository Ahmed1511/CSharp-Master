using System;

namespace CreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CreateInstance

            //var i = new Int32();
            //i = 5;

            //int i2 =(int) Activator.CreateInstance(typeof(int));

            //DateTime dt =(DateTime) Activator.CreateInstance(typeof(DateTime) , 2021 ,  11 ,1);
            //Console.WriteLine(dt);

            #endregion

            //Console.WriteLine(new Goon());
            Console.WriteLine("Enemy");
            // You Send Text and He Create Object by Reflection.
            var input = "CAReflection." + Console.ReadLine();
            object obj = null;

            try
            {
                var aName = typeof(Program).Assembly.GetName().Name;
                // it return objectHandler
                var enemy = Activator.CreateInstance("CAReflection", input);
                // to return object
                obj = enemy.Unwrap();
            }
            catch
            {

            }
            switch (obj)
            {
                case Goon g:
                    Console.WriteLine(g);
                    break;
                case Agar A:
                    Console.WriteLine(A);
                    break;
                case Pixa P:
                    Console.WriteLine(P);
                    break;
                default:
                    Console.WriteLine("UnKnown Enemy.");
                    break;
            }

            do
            {

            }
            while (true);

            Console.ReadKey();

        }
       
      }
    }

        public class Goon
        {
            public override string ToString()
            {
                return $"{{Speed {20} , HitPower :{13} , Strength :{7}}}";
            }
        }

        public class Pixa
        {
            public override string ToString()
            {
                return $"{{Speed {25} , HitPower :{18} , Strength :{9}}}";
            }
        }

        public class Agar
        {
            public override string ToString()
            {
                return $"{{Speed {24} , HitPower :{23} , Strength :{5}}}";
            }
        }

