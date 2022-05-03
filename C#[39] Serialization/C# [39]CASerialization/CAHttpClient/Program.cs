using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CAHttpClient
{
    class Program
    {
        private readonly static HttpClient httpclient = new HttpClient();
        static async Task Main(string[] args)
        {
            var todosJsonContent = await httpclient.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            var todoes = JsonSerializer.Deserialize<List<ToDo>>(todosJsonContent);
            foreach (var todo in todoes)
            {
                Console.WriteLine(todo);

            }
        }
    }


    public class ToDo
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"\n {Id} userId : {UserId} totle : {Title} isComplted :{Completed}";

        }
    }
}
