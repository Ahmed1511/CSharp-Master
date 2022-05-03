using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo de = new Demo();
            int age;
            de.DoSomeThingint(out age);
            Console.WriteLine(age);


        }
    }

    public class Demo
    {

        // series of statement
        public void DoSomeThingint(out int age)
        {
            age = 10;
            age = age + 10;
        }
    }
}
