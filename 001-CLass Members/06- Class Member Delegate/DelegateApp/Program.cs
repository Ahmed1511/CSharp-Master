using System;
using System.Collections.Generic;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new report();
            List<Employee> employees = new List<Employee>
            {
            new Employee{Id=1,Name="Ahmed",Gender="male",TotalSales=2000},
            new Employee{Id=2,Name="Ali",Gender="female",TotalSales=60000},
            new Employee{Id=3,Name="hassan",Gender="male",TotalSales=65000},
            new Employee{Id=4,Name="hossam",Gender="female",TotalSales=40000},
            new Employee{Id=5,Name="sasa",Gender="male",TotalSales=50000}
            };
           // report.GetEmployeesTotalSalesEqualorPross(employees ,"the employees total salaes more than 60000", isGreeterthanOrEqual60000);
            report.GetEmployeesTotalSalesEqualorPross(employees, "the employees total salaes more than 60000", e=> e.TotalSales>=60000);
           // report.GetEmployeesTotalSalesEqualorPross(employees ,"the employees that total salaes between 60000 and 50000 " , isBwtwee6000and5000);
            report.GetEmployeesTotalSalesEqualorPross(employees, "the employees that total salaes between 60000 and 50000 ", e=>e.TotalSales<60000 && e.TotalSales>=50000);


            Console.ReadKey();
        }
           // static bool isGreeterthanOrEqual60000(Employee e) => e.TotalSales >= 60000;
           // static bool isBwtwee6000and5000(Employee e) => e.TotalSales <= 50000 && e.TotalSales > 6000;
        
    }
}
