using System;

namespace EventConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("amazon");
            stock.Price = 100;
            stock.OnPriceChange += Stock_OnPriceChange;
           // using Lamda Expression
            //stock.OnPriceChange += (Stock stoke,decimal oldPrice )=> 
            //{
            //    string result = "";
            //    if (stock.Price > oldPrice)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        result = "Up";
            //        Console.WriteLine($"{stock.Name} : {stock.Price} {result}");
            //    }
            //    else if (stock.Price < oldPrice)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        result = "Down";
            //        Console.WriteLine($"{stock.Name} : {stock.Price} {result}");
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"{stock.Name} : {stock.Price}");
            //    }

            //} ;

            Console.WriteLine($"stock before change{stock.Price} ");
            stock.ChangeStockPrice(0.05m);
            stock.ChangeStockPrice(-0.05m);
            
            Console.WriteLine("UnSubscribe");
            stock.OnPriceChange -= Stock_OnPriceChange; // no event fire
            stock.ChangeStockPrice(0.05m);  
            stock.ChangeStockPrice(-0.05m);        

            Console.ReadKey();
        }

        private static void Stock_OnPriceChange(Stock stock, decimal oldPrice)
        {
            string result = "";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "Up";
                Console.WriteLine($"{stock.Name} : {stock.Price} {result}");
            }
            else if(stock.Price <oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "Down";
                Console.WriteLine($"{stock.Name} : {stock.Price} {result}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stock.Name} : {stock.Price}");
            }

        }
    }

    public delegate void ChangePriceHandler(Stock stock, decimal oldPrice);
    public class Stock
    {
        private string name;
        private decimal price;

        public event ChangePriceHandler OnPriceChange;

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }
        public Stock(string stockName)
        {
            this.name = stockName;
        }

        public void ChangeStockPrice(decimal percentage)
        {
            decimal oldPrice = this.price;
            this.price += Math.Round(this.price * percentage, 2);
            if (OnPriceChange !=null) // make sure there is subscriber
            {
                OnPriceChange(this, oldPrice); // fire the event
            }
        }
    }
}
