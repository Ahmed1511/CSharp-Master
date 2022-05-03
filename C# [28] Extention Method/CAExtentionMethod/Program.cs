using System;

namespace CAExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // more redability in method chaning than PizzaExtention.
            Pizza p = new Pizza();
            p.AddDaugh("MAX")
                .AddSauce()
                .AddTopping("Extra Black Olives", 3.00m)
                .AddChees(true);

            Console.WriteLine(p);
        }
    }

    public class Pizza
    {
        public string Content { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return ($" this Pizza Contain {Content} \n total Price : {Price} ");
        }

    }

    public static class PizzaExtentions
    {
        public static Pizza AddDaugh(this Pizza value, string type)
        {
            value.Content += $"\n{type} Dough  X $4.00";
            value.Price += 4;
            return value;
        }

        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"\nAdd Sauce";
            value.Price += 2.5m;
            return value;
        }

        public static Pizza AddChees(this Pizza value, bool Extra)
        {
            value.Content += $"\n{(Extra ? "extra" : "regular")} chees sause X ${(Extra ? "6.00" : "4.00")}";
            value.Price += Extra ? 6m : 4m;
            return value;
        }

        public static Pizza AddTopping(this Pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.Price += price;
            return value;
        }
    }
}
