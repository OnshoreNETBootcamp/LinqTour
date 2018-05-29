namespace LinqTour
{
    using System;
    using LinqTour.CustomLinq;
    using System.Collections.Generic;

    class Program
    {
        private static string Menu()
        {
            Console.WriteLine("Please select a method to view! Press E to exit!");
            Console.WriteLine("01.) All");
            Console.WriteLine("02.) Any");
            Console.WriteLine("03.) First");
            Console.WriteLine("04.) FirstOrDefault");
            Console.WriteLine("05.) Last");
            Console.WriteLine("06.) LastOrDefault");
            Console.WriteLine("07.) GroupBy");
            Console.WriteLine("08.) Intersect");
            Console.WriteLine("09.) OrderBy");
            Console.WriteLine("10.) ThenBy");
            Console.WriteLine("11.) Skip");
            Console.WriteLine("12.) SkipWhile");
            Console.WriteLine("13.) Take");
            Console.WriteLine("14.) TakeWhile");
            Console.WriteLine("15.) Min");
            Console.WriteLine("16.) Max");
            Console.WriteLine("17.) Average");
            Console.WriteLine("18.) Sum");
            Console.WriteLine("19.) Count");
            Console.WriteLine("20.) Distinct");

            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            bool menuRunning = true;
            while (menuRunning)
            {
                Console.Clear();
                //Welcome to a programmed tour of Linq.
                List<double> prices = new List<double> { 3.50, 12.28, 112.19, 561.13 };
                List<string> fruit = new List<string> { "Apples", "Bananas", "Peaches", "Pears", "Pineapples" };
                
                string choice = Menu();

                switch (choice)
                {
                    //All
                    case "1":
                        bool eachAtLeastFiveLong = fruit.All(x => x.Length > 5);
                        break;

                    //Any
                    case "2":
                        bool anyStartsWithB = fruit.Any(x => x.StartsWith("B"));
                        break;
                        
                    //First
                    case "3":
                        string firstElement = fruit.First();
                        break;

                    //FirstOrDefault
                    case "4":
                        string firstOrDefaultElement = fruit.FirstOrDefault();
                        break;

                    //Last
                    case "5":
                        string lastElement = fruit.Last();
                        break;

                    //LastOrDefault
                    case "6":
                        string lastOrDefaultElement = fruit.LastOrDefault();
                        break;

                    //GroupBy
                    case "7":
                        //Group the fruit names by their first letter and return the groupings as a list.
                        List<IGrouping<char, string>> firstLetterGroups = fruit.GroupBy(f => f.FirstOrDefault()).ToList();

                        foreach (IGrouping<char, string> group in firstLetterGroups)
                        {
                            string message = $"There are { group.Count() } fruit that start with the letter { group.Key }";
                            string formattedFruit = string.Join(", ", group);
                            Console.WriteLine(message);
                            Console.WriteLine(formattedFruit);
                            Console.WriteLine();
                        }

                        break;

                    //Intersect
                    case "8":
                        List<string> newFruit = new List<string> { "Avocado", "Avocado", "Bananas", "Peaches", "Pears", "Papayas", "Pineapples" };

                        List<string> commonFruit = fruit.Intersect(newFruit).ToList();
                        break;

                    //OrderBy
                    case "9":
                        fruit = fruit.OrderBy(x => x).ToList();
                        break;

                    //ThenBy
                    case "10":
                        fruit = fruit.OrderBy(x => x.Length).ThenBy(x => x.FirstOrDefault()).ToList();
                        break;
                        
                    //Skip
                    case "11":
                        List<string> bottomFruit = fruit.Skip(2).ToList();
                        break;

                    //SkipWhile
                    case "12":
                        List<string> bottomConditionFruit = fruit.SkipWhile(x => x.Length > 5).ToList();
                        break;

                    //Take
                    case "13":
                        List<string> topFruit = fruit.Take(3).ToList();
                        break;

                    //TakeWhile
                    case "14":
                        List<string> topConditioned = fruit.TakeWhile(x => x.Length > 5).ToList();
                        break;

                    //Min
                    case "15":
                        int shortestWordLength = fruit.Min(x => x.Length);
                        break;

                    //Max
                    case "16":
                        int longestWordLength = fruit.Max(x => x.Length);
                        break;

                    //Average
                    case "17":
                        double averagePrice = prices.Average(x => x);
                        break;

                    //Sum
                    case "18":
                        double totalPrice = prices.Sum(x => x);
                        break;

                    //Count
                    case "19":
                        int countUnderFifty = prices.Count(x => x < 50);
                        break;

                    //Distinct
                    case "20":
                        List<string> duplicatedFruit = new List<string> { "Apples", "Apples", "Bananas", "Peaches", "Peaches", "Peaches", "Pears", "Pineapples", "Pineapples" };
                        List<string> uniqueFruit = duplicatedFruit.Distinct().ToList();
                        break;

                    case "e":
                    case "E":
                    case "Exit":
                        menuRunning = false;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
