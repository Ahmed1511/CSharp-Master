using System;
using System.Collections;

namespace CAenumeratorIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id = 1, Name = "Issam A", Salary = 1000m, Departement = "IT" };
            Employee e2 = new Employee { Id = 1, Name = "Issam A", Salary = 1000m, Departement = "IT" };
            Employee e3 = e1;
            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1.Equals(e2));
            Console.WriteLine(e3 == e1);
            Console.WriteLine("--------------------------");

            var ints = new FiveInt(1, 2, 3, 4, 5);
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Employee
    {
        public int Id;
        public string Name;
        public decimal Salary;
        public string Departement;
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))

                return false;

            var emp = obj as Employee;

            return this.Id == emp.Id
                && this.Name == emp.Name
                && this.Salary == emp.Salary
                && this.Departement == emp.Departement;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Salary.GetHashCode();
            hash = (hash * 7) + Departement.GetHashCode();

            return hash;
        }

    }

    public class FiveInt : IEnumerable
    {
        int[] _values;
        public FiveInt(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator() => new Enumerator(this);

        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveInt _integers;
            public Enumerator(FiveInt initeger)
            {
                _integers = initeger;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException($"Enumeration not started");

                    if (currentIndex == _integers._values.Length)
                        throw new InvalidOperationException($"Enumeration Has Ended");
                    return _integers._values[currentIndex];

                }
            }

            public bool MoveNext()
            {
                if (currentIndex >= _integers._values.Length - 1)
                {
                    return false;
                }
                return ++currentIndex < _integers._values.Length;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }


    }
}
