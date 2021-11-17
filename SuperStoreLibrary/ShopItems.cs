using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperStoreLibrary
{
    public abstract class ShopItem
    {
        public long Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Brand Brand { get; set; }
        private static long code = 0;
        public ShopItem()
        {

        }
        public ShopItem Clone()
        {
            ShopItem item = (ShopItem)this.MemberwiseClone();
            item.Code = code++;
            return item;
        }
    }
    public class ChemicalsItem : ShopItem
    {
        
    }
    public class FoodItem : ShopItem
    {

        public FoodItem() : base()
        {

        }
        public FoodItem(string name, int price) : base()
        {
            Name = name;
            Price = price;
        }
    }
    public class BeverageItem : ShopItem
    {
        public float Volume { get; set; }
    }
}
