using System;
using System.Collections.Generic;

namespace SuperStoreLibrary
{
    public class Client
    {
        public int ID { get; set; }
        public bool IsDoneShopping { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ShopCart ShopCart { get; set; }
        public List<StoreCard> StoreCards { get; set; }
        public Client()
        {
            IsDoneShopping = false;
            StoreCards = new List<StoreCard>();
        }
    }
}
