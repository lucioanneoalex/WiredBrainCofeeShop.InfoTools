using System.Collections.Generic;

namespace WiredBrainCofee.DataAccess.Model
{
    public class CoffeShopDataProvider
    {
        public IEnumerable<CoffeShop> LoadCoffeeShops()
        {
            yield return new CoffeShop { Location = "Frankfurt", BeansInStocksInKg = 107 };
            yield return new CoffeShop { Location = "Feiburg", BeansInStocksInKg = 20 };
            yield return new CoffeShop { Location = "Munich", BeansInStocksInKg = 40 };
        }
    }
}
