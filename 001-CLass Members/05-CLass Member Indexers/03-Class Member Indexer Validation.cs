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
                {1,5,9,8,2,1,4 },
                {1,5,9,8,2,1,4 },
                {1,5,9,8,2,1,4 },
                {1,5,9,8,2,1,4 },
                {1,5,9,8,2,1,4 },
            };

            Sudoco s = new Sudoco(inputs);
            s[1, 1] = 10;

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
                if (row < 0 || row >_matrix.GetLength(0)-1)
                {
                    return -1;
                }

                if (col < 0 || col > _matrix.GetLength(1)-1)
                {
                    return -1;
                }
                return _matrix[row, col];
            }
            set
            {
                if (value <1 || value > _matrix.GetLength(0))
                {
                    return;
                }
                _matrix[row, col] = value;
            }
        }
        public Sudoco(int[,] matrix)
        {
            _matrix = matrix;
        }


    }
}
