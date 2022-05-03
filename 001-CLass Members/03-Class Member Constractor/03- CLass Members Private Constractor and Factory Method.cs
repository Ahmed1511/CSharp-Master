using System;

namespace OopCOnstractor
{
    class Program
    {
        static void Main(string[] args)
        {           
            Employee e1 = Employee.Create(100,"salama","ali");
            Console.WriteLine($"this is the employee data {e1.DisplayName()}");
        }
    }   
    
    public class Employee
    {
        private int id;
        private string fName;
        private string lName;

        private Employee()
        {

        }
        private Employee(int id, string fName, string lName)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;            
        }

        public static Employee Create(int id, string fName, string lName)
        {
            return new Employee();
        }

        public string DisplayName()
        {
            return $"id : {id} Name : {fName} {lName}";
        }
    }
}
