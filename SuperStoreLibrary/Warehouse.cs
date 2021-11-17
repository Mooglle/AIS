using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SuperStoreLibrary
{
    public class Warehouse
    {
        public List<ShopItem> Items { get; set; }
        public Dictionary<string, int> itemsAmount = new Dictionary<string, int>();
        public Catalog Catalog { get; set; }
        public Warehouse()
        {
            Items = new List<ShopItem>();
            Catalog = new Catalog();
            foreach(ShopItem item in Catalog.Items)
            {
                itemsAmount.Add(item.Name, 0);
            }
            Replanish();
        }
        private readonly object locker = new object();
        public ShopItem GetRandomItem()
        {
            ShopItem item;
            lock (locker)
            {
                if (Items.Count == 0)
                    return null;
                Random random = new Random();
                int index = random.Next(Items.Count);
                item = Items[index];
                Items.RemoveAt(index);
            }
            itemsAmount[item.Name]--;
            return item;
        }
        public void ReturnItemBack(ShopItem item)
        {
            Items.Add(item);
            itemsAmount[item.Name]++;
        }
        public void Replanish()
        {
            foreach (ShopItem item in Catalog.Items)
            {
                for(int i = 0; i < 10; i++) { 
                    Items.Add(item.Clone());
                }
                itemsAmount[item.Name] = 10;
            }
        }
    }
}
