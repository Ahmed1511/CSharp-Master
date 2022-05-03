using System;

namespace CAinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Honda("Honda", "Accord", 2021);

            Honda v2 = new Honda("Honda", "Civic", 2021);
            v2.Stop();

            ILoader v3 = new Caterpiller("Caterpiller", "XYZ", 2021);
            v3.Load();

            Caterpiller c1 = new Caterpiller("Caterpiller2", "ABX", 2022);
            c1.Move();


        }
    }

    abstract class Vehicle
    {
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }

    interface ILoader
    {
        void Load();
        void UnLoad();
    }

    interface IDrivable
    {
        void Move();
        void Stop();
    }

    class Honda : Vehicle, IDrivable
    {
        public Honda(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }

    class Caterpiller : Vehicle, ILoader, IDrivable
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Load()
        {
            Console.WriteLine("Load");
        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }

        public void UnLoad()
        {
            Console.WriteLine("UnLoad");
        }
    }
}
