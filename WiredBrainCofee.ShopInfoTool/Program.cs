using System;

namespace WiredBrainCofee.ShopInfoTool
{
    using System.Linq;
    using WiredBrainCofee.DataAccess.Model;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wired Brain! ");

            Console.WriteLine("write help to show a list of commands, or write quit to break");

            Console.WriteLine("write help to show a list of commands from user alex + a.pinto" + " new and old string");

            var coffeeShopDataProvider = new CoffeShopDataProvider();
            while (true)
            {
                var line = Console.ReadLine();

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> available coffeeshop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
                var foundCoffeeShops = coffeeShops
                  .Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                  .ToList();

                if (foundCoffeeShops.Count == 0)
                {
                    Console.WriteLine($"> Command '{line}' not found");
                }
                else if (foundCoffeeShops.Count == 1)
                {
                    var coffeeShop = foundCoffeeShops.Single();
                    Console.WriteLine($"> Location: {coffeeShop.Location}");
                    Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} kg");
                }
                else
                {
                    Console.WriteLine($"> Multiple matching coffee shop commands found:");
                    foreach (var coffeeType in foundCoffeeShops)
                    {
                        Console.WriteLine($"> {coffeeType.Location}");
                    }
                }

            }
        }
    }
}
