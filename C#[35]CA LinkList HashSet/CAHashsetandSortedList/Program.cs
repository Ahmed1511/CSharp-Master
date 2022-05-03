using System;
using System.Collections.Generic;

namespace CAHashsetandSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
              new Customer { Name = "ali", Telephone = "0125610151" },
              new Customer { Name = "ibraheem", Telephone = "0125610152" },
              new Customer { Name = "mahmoud", Telephone = "0125610153" },
              new Customer { Name = "Yaser", Telephone = "0125610154" },
              new Customer { Name = "ahmed", Telephone = "01256101515" },

            };
            Console.WriteLine("HashSet");
            Console.WriteLine("--------------");
            var customerhasSet1 = new HashSet<Customer>(customers);
            customerhasSet1.Add(new Customer { Name = "X", Telephone = "0214587965" });

            var customers2 = new List<Customer>()
            {
                new Customer {Name="YY" , Telephone="561015478"},
                new Customer {Name="ZZ" , Telephone="564789255"},
            };

            var customerHashSet2 = new HashSet<Customer>(customers2);

            customerhasSet1.UnionWith(customerHashSet2);

            foreach (var item in customerhasSet1) Console.WriteLine(item);



            Console.ReadKey();
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 19;
                hash = hash * 397 + Telephone.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            if (customer is null)
            {
                return false;
            }
            return this.Name.Equals(customer.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Name} ({Telephone})";
        }

    }
}
