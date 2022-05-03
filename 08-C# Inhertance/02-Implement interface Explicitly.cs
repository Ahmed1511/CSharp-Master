using System;

namespace CAinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMove m = new Vehicle();
            m.Move();
            
        }
    }

    interface IMove
    {
        void Move();
    }

    interface IDisplace
    {
        void Move();
    }

    class Vehicle : IMove, IDisplace
    {
        void IMove.Move()
        {
            Console.WriteLine("IMove Move");
        }

        void IDisplace.Move()
        {
            Console.WriteLine("IDisplace Move");
        }
    }


}
