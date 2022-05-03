using System;
using System.IO;

namespace CAFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Example10();
            //Example9();
            //Example8();
            // Example7();
            //Example6();
            // Example5();
            //Example4();
            // Example3();
            // Example2();
            //Example1();
        }


        static void Example1()
        {
            string path = @"C:\Users\DELL\sample.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine($"Length : {fs.Length} byte(s)");
                Console.WriteLine($"CanRead : {fs.CanRead}");
                Console.WriteLine($"canWrite : {fs.CanWrite}");
                Console.WriteLine($"CanSeek : {fs.CanSeek}");
                Console.WriteLine($"CanTimeOut : {fs.CanTimeout}");
                Console.WriteLine($"Position : {fs.Position}");
                fs.WriteByte(65);
                Console.WriteLine($"position: {fs.Position}");
                fs.WriteByte(66);

                for (byte i = 65; i < 133; i++)
                {
                    fs.WriteByte(i);
                }
            }
        }
        static void Example2()
        {
            string path = @"C:\Users\DELL\sample.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] data = new byte[fs.Length];
                int NumBytesToRead = (int)fs.Length;
                int NumByteRead = 0;
                while (NumBytesToRead > 0)
                {
                    int n = fs.Read(data, NumByteRead, NumBytesToRead);
                    if (n == 0)
                    {
                        break;
                    }
                    NumBytesToRead -= n;
                    NumByteRead += n;
                }

                foreach (var b in data)
                {
                    Console.WriteLine(b);
                }

                string NewPath = @"C:\Users\DELL\sample1.txt";
                using (var fsw = new FileStream(NewPath, FileMode.Open, FileAccess.ReadWrite))
                {
                    fsw.Write(data, 0, data.Length);
                }
            }

        }
        static void Example3()
        {
            string path = @"C:\Users\DELL\sample2.txt";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(20, SeekOrigin.Begin);
                fs.WriteByte(65);
                fs.Position = 0;
                for (int i = 0; i < fs.Length; i++)
                {
                    Console.WriteLine(fs.ReadByte());
                }
            }
        }
        static void Example4()
        {
            string path = @"C:\Users\DELL\sample3.txt";
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine("this");
                sw.WriteLine("is");
                sw.WriteLine("C#");
            }
        }

        static void Example5()
        {
            string path = @"C:\Users\DELL\sample3.txt";
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() > 0)
                {

                    Console.WriteLine(sr.ReadToEnd());

                }
            }

        }

        static void Example6()
        {
            string path = @"C:\Users\DELL\sample3.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) is not null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        //Facad
        static void Example7()
        {
            string path = @"C:\Users\DELL\sample4.txt";
            string[] lines = new string[] { "c#", "is", "Amazing", "Language" };
            File.WriteAllLines(path, lines);
        }

        static void Example8()
        {
            string path = @"C:\Users\DELL\sample5.txt";
            string text = "c# is amazing Language";
            File.WriteAllText(path, text);
        }

        static void Example9()
        {
            string path = @"C:\Users\DELL\sample5.txt";

            File.ReadAllText(path);
        }

        static void Example10()
        {
            string path = @"C:\Users\DELL\sample5.txt";
            var lines = File.ReadAllLines(path);
            foreach (var Line in lines)
            {
                Console.WriteLine(Line);
            }
        }
    }
}
