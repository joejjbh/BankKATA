using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using BankKata.Library;

namespace BankKata
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Data.txt");
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);
        }

        public static CollectionOfDigitsAsLineStrings ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                var collection = new CollectionOfDigitsAsLineStrings();
                var lines = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lines.Count < 4)
                    {
                        lines.Add(line);
                    }
                    if (lines.Count == 4)
                    {
                        collection.AddLines(lines);
                        lines.Clear();
                    }
                }
                return collection;
            }
        }

        //        public static List<List<string>> ReadFile(string fileName)
        //        {
        //            using (var reader = new StreamReader(fileName))
        //            {
        //                var collection = new List<List<string>>();
        //                var lines = new List<string>();
        //                string line;
        //                while ((line = reader.ReadLine()) != null)
        //                {
        //                    if (lines.Count < 4)
        //                    {
        //                        lines.AddLines(line);
        //                    }
        //                    if (lines.Count == 4)
        //                    {
        //                        collection.AddLines(lines);
        //                        lines.Clear();
        //                    }
        //                }
        //                return collection;
        //            }
        //        }
    }
}
