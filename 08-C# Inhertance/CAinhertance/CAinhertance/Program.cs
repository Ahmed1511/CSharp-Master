using System;

namespace CAinhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(1000, "Ahmed", 10, 180);

            Maintanance main = new Maintanance(100, "Ali", 10, 100);

            SalesMan s = new SalesMan(100, "Adel", 100, 10, 10, 0.02m);

            Developer de = new Developer(100,"aslam",10,100,true);
            

            Employee[] emps = { m, main, s, de };
            foreach (var Employee in emps)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(Employee);
            }
            Console.WriteLine(de);
        }
    }
}
