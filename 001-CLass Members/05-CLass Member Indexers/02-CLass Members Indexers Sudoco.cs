using System;

namespace Sudoco
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] inputs = new int[,]
            {
                {1,5,1,8,2,0,7 },
                {1,2,4,8,2,7,7 },
                {1,5,9,8,2,1,4 },

            };

            Sudoco s = new Sudoco(inputs);

            Console.WriteLine(s[2, 2]);
            Console.WriteLine(s[1, 1]);
        }
    }

    public class Sudoco
    {
        private int[,] _matrix;

        public int this[int row, int col]
        {
            get
            {
                return _matrix[row, col];
            }
            set
            {
                _matrix[row, col] = value;
            }
        }
        public Sudoco(int[,] matrix)
        {
            _matrix = matrix;
        }


    }
}
