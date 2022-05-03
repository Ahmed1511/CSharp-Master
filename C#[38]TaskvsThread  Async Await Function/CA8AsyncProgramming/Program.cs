using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CA8AsyncProgramming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // --   1  -- 
            //var task = Task.Run(() => ReadContent("https://www.youtube.com/watch?v=kDUDX3VJFEc&list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l"));
            //var awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() => Console.WriteLine(awaiter.GetResult()));
            var content = await ReadContentAsync("https://www.youtube.com/watch?v=kDUDX3VJFEc&list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l");
            Console.WriteLine(content);
            Console.ReadKey();
        }

        static Task<string> ReadContent(string url)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(url);
            return task;
        }

        // to create async function
        // methodnameAsync  + async   +  await before un blocking code
        //  Task<string> mean I promis you to returen string value.
        static async Task<string> ReadContentAsync(string url)
        {
            var client = new HttpClient();
            var task = await client.GetStringAsync(url);
            return task;
        }
    }
}
