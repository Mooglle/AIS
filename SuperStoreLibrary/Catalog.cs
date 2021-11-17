using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary
{
    public class Catalog
    {
        public List<ShopItem> Items { get; set; }
        public Catalog()
        {
            Items = new List<ShopItem>();
            Items.Add(new BeverageItem()
            {
                Name = "Bon-Aqua 1l",
                Price = 10,
                Volume = 1,
                Brand = Brand.CocaCola,
                Manufacturer = Manufacturer.BeverageFactory
            });
            Items.Add(new BeverageItem()
            {
                Name = "Czech Beer 0.5l",
                Price = 30,
                Volume = 0.5f,
                Brand = Brand.Krusovice,
                Manufacturer = Manufacturer.BeverageFactory
            });
            Items.Add(new FoodItem()
            {
                Name = "Bread",
                Price = 5,
                Brand = Brand.AwesomeBread,
                Manufacturer = Manufacturer.FoodFactory
            });
            Items.Add(new FoodItem()
            {
                Name = "Meat",
                Price = 100,
                Brand = Brand.NiceMeat,
                Manufacturer = Manufacturer.FoodFactory
            });
            Items.Add(new ChemicalsItem()
            {
                Name = "Domestos",
                Price = 50,
                Brand = Brand.Domestos,
                Manufacturer = Manufacturer.ChemicalFactory
            });
            Items.Add(new ChemicalsItem()
            {
                Name = "DrCleaner",
                Price = 70,
                Brand = Brand.Cleanerz,
                Manufacturer = Manufacturer.ChemicalFactory
            });
        }
    }
}
