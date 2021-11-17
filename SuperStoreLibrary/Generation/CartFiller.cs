using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary.Generation
{
    public class CartFiller
    {
        Random rnd = new Random();
        public void FillCart(Client c, Warehouse wH, int maxItems)
        {
            int j;
            for (int i = 0; i < rnd.Next(0, maxItems); i++) {
                if (wH.Items.Count != 0)
                {
                    j = rnd.Next(0, wH.Items.Count);
                    c.ShopCart.Items.Add(wH.Items[j]);
                    wH.Items.RemoveAt(j);
                }
            }
        }
    }
}
