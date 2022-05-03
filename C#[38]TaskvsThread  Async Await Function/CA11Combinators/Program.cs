using System;
using System.Threading.Tasks;

namespace CA11Combinators
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var has1000SubscribedTask = Task.Run(() => Has1000Subscriber());
            var has4000ViewedHours = Task.Run(() => Has4000ViewedHours());
            Console.WriteLine("Using WhenAny");
            Console.WriteLine("----------------");
            var any = await Task.WhenAny(has1000SubscribedTask, has4000ViewedHours);
            Console.WriteLine(any.Result);

            Console.WriteLine("Using WhenAll");
            Console.WriteLine("----------------");
            var all = await Task.WhenAll(has1000SubscribedTask, has4000ViewedHours);
            foreach (var t in all)
            {
                Console.WriteLine(t);
            }


            Console.ReadKey();
        }

        static Task<string> Has1000Subscriber()
        {
            Task.Delay(3000).Wait();
            return Task.FromResult(" Congratulation you has 1000 subscribed.");
        }

        static Task<string> Has4000ViewedHours()
        {
            Task.Delay(4000).Wait();
            return Task.FromResult(" Congratulation you has 4000 Hours Viewd.");
        }
    }
}
