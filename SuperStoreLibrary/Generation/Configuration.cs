using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary.Generation
{
    public class Configuration
    {
        public double newClientRate = 0.75;
        public int maxNewClients = 10;
        public int maxNewClientDelay = 100;
        public int maxPickedClients = 10;
        public int maxItemsAmountInCart = 10;
        public int checkoutInterval = 100;
        public int maxClientTimeInShop = 100;
        public int waitingInterval = 10;
        public int maxWait = 100;
        public int nextDayInterval = 1000;
        public Configuration()
        {

        }
    }
}
