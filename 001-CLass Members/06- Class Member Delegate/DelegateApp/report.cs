using System;
using System.Collections.Generic;

namespace DelegateApp
{
    public class report
    {
        public delegate bool Illegable(Employee e);
        public void GetEmployeesTotalSalesEqualorPross(List<Employee> employees , string title, Illegable isIllegable)
        {
                    Console.WriteLine(title);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var e in employees)
            {
                if (isIllegable(e))
                {
                    Console.WriteLine($"the employee {e.Name} , that gender is {e.Gender} , total sales{e.TotalSales}");
                }
            }
        }

        

        //public void GetEmployeesTotalSalesEqualorbetween60000and50000(List<Employee> employees)
        //{
        //    Console.WriteLine("the employees that has totalsales between 60000 and 50000");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales >= 50000 && e.TotalSales <60000)
        //        {
        //            Console.WriteLine($"the employee {e.Name} , that gender is {e.Gender} , total sales{e.TotalSales}");
        //        }
        //    }
        //}
    }
}
