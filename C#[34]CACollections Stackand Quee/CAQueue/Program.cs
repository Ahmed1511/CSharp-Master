using System;
using System.Collections.Generic;

namespace CAQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("doc1.docx",2));
            printingJobs.Enqueue(new PrintingJob("doc2.docx", 3));
            printingJobs.Enqueue(new PrintingJob("doc3.docx", 6));
            printingJobs.Enqueue(new PrintingJob("doc4.docx", 2));
            printingJobs.Enqueue(new PrintingJob("doc5.docx", 1));

            Console.WriteLine($"current Before while queue count :{printingJobs.Count}");

            Random rnd = new Random();
            while (printingJobs.Count > 0)
            {
                var job = printingJobs.Dequeue();
                Console.WriteLine($"Printing ...[{job}]");
                System.Threading.Thread.Sleep(rnd.Next(1,5) * 1000);
            }

            Console.WriteLine($"current after queue count :{printingJobs.Count}");
            Console.ReadKey();

        }
    }

    class PrintingJob
    {
        private readonly string _file;
        private readonly int _copy;

        public PrintingJob(string file, int copy)
        {
            _file = file;
            _copy = copy;
        }

        public override string ToString()
        {
            return $"{_file} X : {_copy}";
        }
    }
}
