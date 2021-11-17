using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary
{
    public class ShopCart
    {
        public List<ShopItem> Items { get; set; }
        public ShopCart()
        {
            Items = new List<ShopItem>();
        }
    }
}
