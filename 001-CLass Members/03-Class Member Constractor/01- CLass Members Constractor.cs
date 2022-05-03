using System;

namespace OopCOnstractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(1999);

            Console.WriteLine(date.GetDate());
        }
    }

    public class Date
    {                                                  // 0, 1,  2,  3,  4,  5,  6,  7,  8,  9,  10, 11, 12
        private static readonly int[] DaystoMonths365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaystoMonths366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;

        public Date(int day, int month, int year)
        {
            var IsLeap = year % 4 == 0 && (year / 100 != 0 || year / 400 == 0);

            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] Days = IsLeap ? DaystoMonths366 : DaystoMonths365;

                if (day >= 1 && day <= Days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }

            }

        }
         // this is constractor overloading using my base class logic
        public Date(int year) : this(01, 01, year)
        {

        }

        public Date(int month, int year) : this(01, month, year)
        {

        }

        public string GetDate()
        {
            return ($"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(2, '0')}");
        }

    }
}
