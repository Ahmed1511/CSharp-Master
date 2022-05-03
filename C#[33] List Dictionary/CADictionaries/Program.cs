using System;
using System.Collections.Generic;

namespace CADictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var articla = "dot net free developer dot net free developer dot net free developer dot net free developer dot net free developer dot net free developer dot net free developer dot net free developer dot net free developer vdot net free developer";

            Dictionary<char, List<string>> LettersDictionary = new Dictionary<char, List<string>>();

            foreach (var word in articla.Split())
            {
                foreach (var ch in word)
                {
                    if (!LettersDictionary.ContainsKey(ch))
                    {
                        LettersDictionary.Add(ch, new List<string> { word });
                    }
                    else
                    {
                        LettersDictionary[ch].Add(word);
                    }
                }
                //foreach (var entry in LettersDictionary)
                //{
                //    Console.WriteLine($"'{entry.Key}':");
                //    foreach (var word in entry.Value)
                //    {
                //        Console.WriteLine($"\t\t \"{word}\" ");
                //    }
                //}
            }
            Console.ReadKey();
        }
    }
}
