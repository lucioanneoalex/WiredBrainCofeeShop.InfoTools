using System.Collections.Generic;

namespace WiredBrainCofee.DataAccess.Model
{
    public class CoffeShopDataProvider
    {
        public IEnumerable<CoffeShop> LoadCoffeeShops()
        {
            yield return new CoffeShop { Location = "Frankfurt", BeansInStockInKg = 107 };
            yield return new CoffeShop { Location = "Feiburg", BeansInStockInKg = 20 };
            yield return new CoffeShop { Location = "Munich", BeansInStockInKg = 40 };
        }
    }
}
