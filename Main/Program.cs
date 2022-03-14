using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.Clear();

                if (!int.TryParse(userChoice, out var options) || !DesignPatternType.ContainsKey(options))
                {
                    Console.WriteLine(chooseValidOption);
                }
                else
                {
                    if (options == 0)
                    {
                        ContinueRunning = false;
                        Console.WriteLine("The program will finish !!!");
                    }
                    else
                    {
                        var designPatternType = DesignPatternType[options];
                        Console.WriteLine($" You choose the following design Pattern Type => {designPatternType.Name}");
                        if (designPatternType.DesignPatterns.Any())
                        {
                            DisplayDesignPattern(designPatternType);

                            userChoice = Console.ReadLine();
                            Console.Clear();
                            if (!int.TryParse(userChoice, out options) || !designPatternType.DesignPatterns.ContainsKey(options))
                            {
                                Console.WriteLine(chooseValidOption);
                            }
                            else
                            {
                                Console.WriteLine($"Launch Run of the following design pattern : {designPatternType.DesignPatterns[options].Name}");
                                Console.WriteLine();
                                designPatternType.DesignPatterns[options].Action();
                            }
                        }
                    }
                }

                Console.WriteLine("Press a key to continue");
                Console.ReadLine();
            }

        }

        private static void DisplayDesignPatternTypes()
        {
            Console.WriteLine("Please choose a design pattern type : ");
            foreach (var item in DesignPatternType)
            {
                Console.WriteLine($"{item.Key} => {item.Value.Name}");
            }
        }

        private static void DisplayDesignPattern(DesignPatternType designPatternType)
        {
            Console.WriteLine("Please choose a design pattern to Run : ");
            foreach (var item in designPatternType.DesignPatterns)
            {
                Console.WriteLine($"{item.Key} => {item.Value.Name}");
            }
        }

        private static bool ContinueRunning = true;
        private static readonly string chooseValidOption = "Please choose a valid Option !!!";
        private static readonly Dictionary<int, DesignPatternType> DesignPatternType = new Dictionary<int, DesignPatternType>
        {
            {
                0,
                new DesignPatternType
                {
                    Name = "End Program",
                    DesignPatterns = null,
                }
            },
            {
                1,
                new DesignPatternType
                {
                    Name = "Comportement",
                    DesignPatterns = new Dictionary<int, DesignPattern>
                    {
                        {
                            1,
                           new DesignPattern
                           {
                               Name = "ChainOfResponsability",
                               Action = ChainOfResponsability.ChainOfResponsability.Main,
                           }
                        }
                    },
                }
            },
            {
                2,
                new DesignPatternType
                {
                    Name = "Construction",
                    DesignPatterns = new Dictionary<int, DesignPattern>(),
                }
            },
            {
                3,
                new DesignPatternType
                {
                    Name = "Others",
                    DesignPatterns = new Dictionary<int, DesignPattern>(),
                }
            },
            {
                4,
                new DesignPatternType
                {
                    Name = "Structuration",
                    DesignPatterns = new Dictionary<int, DesignPattern>(),
                }
            },
        };
    }
}
