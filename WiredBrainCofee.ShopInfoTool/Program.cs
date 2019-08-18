using System;

namespace WiredBrainCofee.ShopInfoTool
{
    using WiredBrainCofee.DataAccess.Model;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wired Brain! ");

            Console.WriteLine("write help to show a list of commands, or write quit to break");

            Console.WriteLine("write help to show a list of commands from user alex" + " old string");

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
            }
        }
    }
}
