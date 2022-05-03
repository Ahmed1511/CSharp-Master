using System;

namespace CAEnumerationIterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id = 1, Name = "ahmed", Salary = 2000, Departement = "it" };
            Employee e2 = new Employee { Id = 1, Name = "ahmed", Salary = 2000, Departement = "it" };
            Employee e3 = e1;
            Console.WriteLine(e1 == e2);
            Console.WriteLine(e3 == e1);
            Console.WriteLine(e3.Equals(e1));
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Departement { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;
            var emp = obj as Employee;


            return this.Id == emp.Id &&
                   this.Name == emp.Name &&
                   this.Salary == emp.Salary &&
                   this.Departement == emp.Departement;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Salary.GetHashCode();
            hash = (hash * 7) + Departement.GetHashCode();
            return base.GetHashCode();
        }
        public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
        public static bool operator !=(Employee lhs, Employee rhs) => !lhs.Equals(rhs);


    }
}
