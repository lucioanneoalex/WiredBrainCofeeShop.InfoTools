using System;

namespace WiredBrainCofee.ShopInfoTool
{
    using WiredBrainCofee.DataAccess.Model;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wired Brain!");

            Console.WriteLine("write help to show a list of commands from user 2");

            var coffeeShopDataProvider = new CoffeShopDataProvider();
            while (true)
            {
                var line = Console.ReadLine();

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

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
