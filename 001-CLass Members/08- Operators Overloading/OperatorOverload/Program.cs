using System;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10);
            Money m2 = new Money(20);

            Console.WriteLine($"money m1 : ${m1.Amount} , money m2 : ${m2.Amount}");
            Money m3 = m1 + m2;
            Console.WriteLine(m3.Amount);

            Money m4 = m2 - m1;
            Console.WriteLine(m4.Amount);


            Console.WriteLine(m1 > m2);

            Console.WriteLine(m1 < m2);

            Console.WriteLine(m1 >= m2);

            Console.WriteLine(m1 <= m2);

            Console.WriteLine((++m4).Amount);

            Console.WriteLine((--m4).Amount);

            Console.ReadKey();
        }
    }

    public class Money
    {
        private decimal amount;

        public decimal Amount { get { return amount; } }
        public Money(decimal value)
        {
            amount = value;
        }

        // +    -  
        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.amount + money2.amount;
            return new Money(value);
        }

        public static Money operator -(Money money1, Money money2)
        {
            var value = money1.amount - money2.amount;
            return new Money(value);
        }

        // >   <
        public static bool operator >(Money money1, Money money2)
        {
            var value = money1.amount > money2.amount;
            return value;
        }

        public static bool operator <(Money money1, Money money2)
        {
            var value = money1.amount < money2.amount;
            return value;
        }

        // >= <=
        public static bool operator >=(Money money1, Money money2)
        {
            var value = money1.amount > money2.amount;
            return value;
        }

        public static bool operator <=(Money money1, Money money2)
        {
            var value = money1.amount < money2.amount;
            return value;
        }

        // == !=
        public static bool operator ==(Money money1, Money money2)
        {
            var value = money1.amount == money2.amount;
            return value;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            var value = money1.amount != money2.amount;
            return value;
        }

        // ++ --
        public static Money operator ++(Money money)
        {
            var value = money.amount;
            return new Money(++value);
        }

        public static Money operator --(Money money)
        {
            var value = money.amount;
            return new Money(--value);
        }

        // for == !=
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
