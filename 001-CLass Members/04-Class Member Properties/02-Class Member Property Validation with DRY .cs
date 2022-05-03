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
                this._amount = processValue(value);
            }
        }

        public Doller(decimal amount)
        {
            this._amount=processValue(amount);
        }

        private decimal processValue(decimal value) => value <= 0 ? 0 : Math.Round(value);

    }
}

// public Field(not recommended)
// private Field(can not be access outside the constractor)
// Public with ReadOnly(cant be sett just get)