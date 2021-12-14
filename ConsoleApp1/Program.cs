using System;
using System.Collections.Generic;
using CustomDictionary;

namespace ConsoleApp1 {
    class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary<string, int> test = new CustomDictionary<string, int>(4);

            Console.WriteLine($"Start capacity: {dict.Capacity}");

            test.Add("Saratov", 1);
            test.Add("Moscow", 2);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            test.Remove("Peter");
            
            Console.WriteLine();
            foreach (var item in test)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            
            test.Add("Saratov", 1);

            test.Remove("Moscow");
            test.Remove("Peter");

            Console.WriteLine();
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value.ToString());
            }
            
            test.Add("Anna", 1);
            test.Add("Maria", 2);
            test.Add("Svetlana", 3);
            test.Add("Gleb", 4);

            Console.WriteLine();
            Console.WriteLine($"Current capacity: {dict.Capacity}");
            
            Console.WriteLine();
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value.ToString());
            }

            Console.WriteLine(test["Anna"]);
            Console.WriteLine(test["Maria"]);
            Console.WriteLine(test["Gleb"]);
            Console.WriteLine(test.ContainsKey("Ivan"));
            Console.WriteLine(test.ContainsKey("Ivan"));

            test["Oleg"] = 10;
            
            Console.WriteLine(test.ContainsKey("Oleg"));

            test.Count = 50;
            Console.WriteLine(test.Count);

            foreach (var item in (List<string>) test.Keys)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");
            
            foreach (var item in (List<int>) test.Values)
            {
                Console.Write($"{item} ");
            }
        }
    }
}