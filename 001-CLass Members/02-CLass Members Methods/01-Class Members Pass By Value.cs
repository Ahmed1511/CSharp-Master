using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo de = new Demo();
            int age = 18;
            de.DoSomeThingint(ref age);
            Console.WriteLine(age);


        }
    }

    public class Demo
    {

        // series of statement
        public void DoSomeThingint(ref int age)
        {
            age = age + 10;
        }
    }
}
