using System;

namespace CASwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountJOD = 100;
            var CurrType = "EUR";
            var outPut = 0d;

            // JoD to USD = 1.41 , EUR = 1.16 , CAD=1.78
            var JODUSD = 1.4d;
            var JODEUR = 1.19d;
            var JODCAD = 1.7d;

            switch (CurrType)
            {
                case "USD":
                    outPut = amountJOD * JODUSD;
                    Console.WriteLine($" {amountJOD}  JOD : ${ outPut} USD");
                    break;

                case "EUR":
                    outPut = amountJOD * JODEUR;
                    Console.WriteLine($" {amountJOD}  JOD : ${ outPut} EUR");
                    break;
                case "CAD":
                    outPut = amountJOD * JODCAD;
                    Console.WriteLine($" {amountJOD}  JOD : ${ outPut} CAD");
                    break;

                default:
                    break;
            }


            Console.ReadKey();
        }
    }


}
