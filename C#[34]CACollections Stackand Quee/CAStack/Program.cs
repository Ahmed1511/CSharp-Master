using System;
using System.Collections.Generic;

namespace CAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Command> Undo = new Stack<Command>();
            Stack<Command> redo = new Stack<Command>();

            string Line;

            while (true)
            {
                Console.Write(" Url ('exit' to quit):");
                Line = Console.ReadLine().ToLower();
                if (Line == "exit")
                {
                    break;
                }
                else if (Line == "back")
                {
                    if (Undo.Count > 0)
                    {
                        var item = Undo.Pop();
                        redo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (Line == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var item = redo.Pop();
                        Undo.Push(item);
                    }
                }
                else
                {
                    // add url to undo list
                    Undo.Push(new Command(Line));
                }
                Console.Clear();
                Print("back", Undo);
                Print("forward", redo);
            }
        }

        static void Print(string name, Stack<Command> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach (var u in commands)
            {
                Console.WriteLine($"\t {u}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }


    }

    class Command
    {
        private readonly DateTime _createdAt;
        private readonly string Url;

        public Command(string url)
        {
            _createdAt = DateTime.Now;
            Url = url;
        }



        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-mm-dd")}] {this.Url}";
        }
    }
}
