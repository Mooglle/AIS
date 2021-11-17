using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary
{
    public abstract class StoreCard
    {
        private string Passcode { get; set; }
        public StoreCard(string passcode)
        {
            Passcode = passcode;
        }
        public virtual bool IsValid(string passcode)
        {
            return Passcode == passcode;
        }
        public abstract decimal Process(List<ShopItem> items);
    }

    public class DiscountCard : StoreCard
    {
        public float discountPercentage = 5;
        DiscountCard(string passcode) : base(passcode) { }
        public override decimal Process(List<ShopItem> items)
        {
            decimal total = 0;
            foreach(ShopItem i in items)
            {
                total += (Discounts.ItemDiscounts.ContainsKey(i.Name)) ? (decimal)((float)i.Price * Discounts.ItemDiscounts[i.Name]) : i.Price;
            }
            return (decimal)((float)total * (100 - discountPercentage));
        }
    }
    public class BonusCard : StoreCard
    {
        public BonusProgram BonusProgram { get; set; }
        public int BonusPoints { get; set; }
        BonusCard(string passcode, BonusProgram program) : base(passcode) {
            BonusProgram = program;
            BonusPoints = 0;
        }
        public override decimal Process(List<ShopItem> items)
        {
            decimal total = 0;
            foreach (ShopItem i in items)
            {
                total += (Discounts.ItemDiscounts.ContainsKey(i.Name)) ? (decimal)((float)i.Price * Discounts.ItemDiscounts[i.Name]) : i.Price;
            }
            BonusPoints += (int) total / 10;
            return total;
        }
    }
}
