using System;

namespace FieldsAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee[] emps = new Employee[2];

            Console.WriteLine("Enter TAX Value :");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the First Name : ");
            e1.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            e1.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Wage : ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Total Hours : ");
            e1.TotalHours = Convert.ToDouble(Console.ReadLine());




            Employee e2 = new Employee();

            Console.Write("Enter the First Name : ");
            e2.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            e2.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Wage : ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Total Hours : ");
            e2.TotalHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;
            emps[1] = e2;
            foreach (var emp in emps)
            {
                var Salary = emp.Wage * emp.TotalHours;
                var TaxAmount = Salary * Employee.TAX;
                var NetSalary = Salary - TaxAmount;

                Console.WriteLine($"first name is {emp.FirstName}");
                Console.WriteLine($"last name is {emp.LastName}");
                Console.WriteLine($"wage is {emp.Wage}");
                Console.WriteLine($"Total Hurs is {emp.TotalHours}");
                Console.WriteLine($"Netsalary {NetSalary}");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Salry : {Salary }");
                Console.WriteLine($"Tax Value :({Employee.TAX}%) ({TaxAmount})");
                Console.WriteLine($"NetSalary : {NetSalary}");
                Console.WriteLine("---------------------------------------------");




            }


        }
    }
    public class Employee
    {
        public static double TAX = 0.03;
        public string FirstName;
        public string LastName;
        public double Wage;
        public double TotalHours;
        public double NetSalary;

    }
}
