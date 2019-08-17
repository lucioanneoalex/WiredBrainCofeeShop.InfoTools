using System;

namespace WiredBrainCofee.ShopInfoTool
{
    using WiredBrainCofee.DataAccess.Model;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wired Brain!");

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
