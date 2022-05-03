using System;
using System.Collections.Generic;

namespace CAList
{
    class Program
    {
        static void Main(string[] args)
        {
            var Egypt = new Country() { IsoCode = "EGY", Name = "Egypt" };
            var Jordan = new Country() { IsoCode = "Jor", Name = "Jordan" };
            var Iraq = new Country() { IsoCode = "IRQ", Name = "Iraq" };

            Country[] Countries = { Egypt, Iraq, Jordan };


            // Constractors
            //  List<Country> countries = new List<Country>();
            //List<Country> countries = new List<Country>(Countries);
            List<Country> countries = new List<Country>(3);

            Print(countries);
            Console.WriteLine("-----------");
            // Properties

            // Methods
            countries.Add(new Country { IsoCode = "PRA", Name = "Prasil" }); // O(1)
            countries.AddRange(countries);                                  // O(1)    

            countries.Insert(2, new Country { IsoCode = "FRA", Name = "France" }); // O(N)

            countries.RemoveAll(x => x.Name.EndsWith("ce"));
            countries.Remove(new Country() { IsoCode = "IRQ", Name = "Iraq" });

            Print(countries);

            Console.ReadKey();
        }

        static void Print(List<Country> countries)
        {
            foreach (var c in countries)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine($"Count :{countries.Count}");
            Console.WriteLine($"Capacity :{countries.Capacity}");
        }
    }

    public class Country
    {
        public string IsoCode { get; set; }
        public string Name { get; set; }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 19;
                hash = hash * 397 + IsoCode.GetHashCode();
                hash = hash * 397 + Name.GetHashCode();
                return hash;
            }

        }
        public override bool Equals(object obj)
        {
            var Country = obj as Country;
            if (Country is null)
            {
                return false;
            }
            return this.Name.Equals(Country.Name, StringComparison.OrdinalIgnoreCase) && this.IsoCode.Equals(Country.IsoCode, StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString()
        {
            return $"Name : {Name} ({IsoCode})";
        }
    }
}
