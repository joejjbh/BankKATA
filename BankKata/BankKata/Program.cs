using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
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

            var fileName2 = Path.Combine(directory.FullName, "accountNumbers.txt");
            WriteToFile(fileName2);
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

        public static StreamWriter WriteToFile(string fileName2)
        {
            var accountNumbers = new AccountNumbers();
            var theAccountNumbers = accountNumbers.GetAccountNumbers();
            using (var writer = new StreamWriter(fileName2))
            {
                foreach (int acountNumber in theAccountNumbers)
                {
                        writer.WriteLine(acountNumber);
                }
                return writer;
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
