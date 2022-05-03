using System;
using System.Collections.Generic;

namespace CALinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lesson1 = new YTVideo() { Id = 1, Title = "lesson1", Duration = new TimeSpan(00, 30, 00) };
            var Lesson2 = new YTVideo() { Id = 2, Title = "lesson2", Duration = new TimeSpan(01, 30, 00) };
            var Lesson3 = new YTVideo() { Id = 3, Title = "lesson3", Duration = new TimeSpan(01, 50, 00) };
            var Lesson4 = new YTVideo() { Id = 4, Title = "lesson4", Duration = new TimeSpan(00, 50, 00) };
            var Lesson5 = new YTVideo() { Id = 5, Title = "lesson5", Duration = new TimeSpan(00, 30, 00) };

            //LinkedList<YTVideo> playList = new LinkedList<YTVideo>(new YTVideo[]
            //     {
            //        Lesson1,
            //        Lesson2,
            //        Lesson3,
            //        Lesson4,
            //        Lesson5
            //     });

            LinkedList<YTVideo> playList = new LinkedList<YTVideo>();
            playList.AddFirst(Lesson1);

            playList.AddAfter(playList.First, Lesson2);

            var node3 = new LinkedListNode<YTVideo>(Lesson3);
            playList.AddAfter(playList.First.Next, node3);

            playList.AddBefore(playList.Last, Lesson4);

            playList.AddLast(Lesson5);

            Print("C# form zero to Hero", playList);
            Console.ReadKey();
        }

        static void Print(string title, LinkedList<YTVideo> playList)
        {
            Console.WriteLine($"{title}");
            foreach (var item in playList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

    public class YTVideo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public override string ToString()
        {
            // C# Variables(00:30:00)
            // 

            return $"────{Title} ({Duration}) \n\thttps://www.youtube.com/watch={Id} ";
        }
    }
}
