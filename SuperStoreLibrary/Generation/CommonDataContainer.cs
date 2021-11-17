using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary.Generation
{
    public class CommonDataContainer
    {
        public List<Client> Clients { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Cashbox> Cashboxes { get; set; }
        public CommonDataContainer()
        {
            Clients = new List<Client>();
            Warehouse = new Warehouse();
            Cashboxes = new List<Cashbox>() { new Cashbox(), new Cashbox(), new Cashbox() };
        }
    }
}
