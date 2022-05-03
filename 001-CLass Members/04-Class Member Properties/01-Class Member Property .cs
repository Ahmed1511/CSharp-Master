using System;

namespace CAProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Doller doller = new Doller(1.99m);
            doller.Amount = 1.99m;    // set
            Console.WriteLine(doller.Amount); // Get
        }
    }

    public class Doller
    {
        private decimal _amount;
        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value <= 0)
                {
                    _amount = 0;
                }
                else
                {
                    _amount = value;
                }
            }
        }

        public Doller(decimal amount)
        {
            if (amount <= 0)
            {
                amount = 0;
            }
            else
            {
                _amount = amount;
            }
        }

    }
}

// public Field(not recommended)
// private Field(can not be access outside the constractor)
// Public with ReadOnly(cant be sett just get)