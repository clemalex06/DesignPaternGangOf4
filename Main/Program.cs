using System;
using System.Collections.Generic;

namespace Main
{
    public static class Program
    {
        static void Main(string[] args)
        {
            while (ContinueRunning)
            {
                Console.Clear();
                DisplayDesignPatternTypes();
                var userChoice = Console.ReadLine();

                if (!int.TryParse(userChoice, out var options) || !DesignPatternType.ContainsKey(options))
                {
                    Console.WriteLine("Please choose a valid Option !!!");

                }
                else
                {
                    if (options == 0)
                    {
                        ContinueRunning = false;
                    }
                }

                Console.WriteLine("Press a key to continue");
                Console.ReadLine();
            }

        }

        private static void DisplayDesignPatternTypes()
        {
            Console.WriteLine("Please choose you design pattern type : ");
            foreach (var item in DesignPatternType)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static bool ContinueRunning = true;
        private static readonly Dictionary<int, string> DesignPatternType = new Dictionary<int, string>
        {
            { 0, "End Program" },
            { 1, "Comportement" },
            { 2, "Construction" },
            { 3, "Others"},
            { 4, "Structuration"}
        };
    }
}
