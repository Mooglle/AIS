using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperStoreLibrary;
using SuperStoreLibrary.Generation;

namespace AIS.Modules
{
    public class Simulation
    {
        private CommonDataContainer _entities = new CommonDataContainer();
        private ClientGenerator _cG = new ClientGenerator();
        private Random _rng = new Random();
        private bool _isActive = false;
        public Configuration config = new Configuration();
        private Warehouse _wH = new Warehouse();
        private List<Client> _queue = new List<Client>();
        private List<Cashier> _cashiers = new List<Cashier>() { new Cashier() { FirstName = "Sue" }, new Cashier() { FirstName = "Ron" } };
        private List<Cashbox> _cashboxes = new List<Cashbox>();

        public decimal account = 0;
        private Label _label;

        private bool _isLoaded = false;

        private DateTime _date = new DateTime(2021, 11, 1);

        public Simulation(Label l)
        {
            _label = l;
        }
        private void Load()
        {
            //Load Clients
            //Load Warehouse
            //Load Cashboxes
            //Load Employees
            _cashboxes.Add(new Cashbox());
            _cashboxes.Add(new Cashbox());
            _cashboxes[0].Cashier = _cashiers[0];
            _cashboxes[1].Cashier = _cashiers[1];
        }

        public void Start()
        {
            if (!_isLoaded)
            {
                Load();
                _isLoaded = true;
            }
            if (!_isActive)
            {
                _isActive = true;
                Task.Run(() => GenerateClients(config.maxNewClients, config.maxNewClientDelay));
                Task.Run(() => BusinessLoop());
                Task.Run(() => Checkout(_queue, _cashboxes));
            }
        }
        private void BusinessLoop()
        {
            while (_isActive)
            {
                if (_date.DayOfWeek == DayOfWeek.Monday)
                {
                    _wH.Replanish();
                    foreach (Cashbox cb in _cashboxes)
                    {
                        account += cb.Cash;
                        cb.Cash = 0;
                    }
                }
                _label.Invoke(new Action(() => _label.Text = _date.ToString() + ": " + account.ToString()));
                PickClients(config.maxPickedClients);
                _date = _date.AddDays(1);
                Thread.Sleep(config.nextDayInterval);
            }
        }
        public void Stop()
        {
            _isActive = false;
        }
        private void Checkout(List<Client> queue, List<Cashbox> cashboxes)
        {
            while (_isActive)
            {
                if (queue.Count > 1)
                {
                    Client c = queue[0];
                    Cashbox cb = cashboxes.GetNext(config.waitingInterval, config.maxWait);
                    if (cb == null)
                    {
                        foreach (ShopItem i in c.ShopCart.Items)
                        {
                            if(i != null)
                                _wH.ReturnItemBack(i);
                        }
                    }
                    else
                    {
                        decimal total = 0;
                        if (c.StoreCards.Count > 0)
                        {
                            total = c.StoreCards[0].Process(c.ShopCart.Items);
                        }
                        else
                        {
                            foreach (ShopItem i in c.ShopCart.Items)
                            {
                                if (i != null)
                                    total += i.Price;
                            }
                        }
                        cb.Cash += total;
                    }
                    queue.Remove(c);
                    _entities.Clients.Add(c);
                    c.ShopCart.Items.Clear();
                    c.IsDoneShopping = false;
                }
                Thread.Sleep(config.checkoutInterval);
            }
        }
        private void FillCart(Client c, int itemsAmount)
        {
            int amount;
            if (c != null)
            {
                amount = _rng.Next(itemsAmount);
                List<ShopItem> items = new List<ShopItem>();
                for (int i = 0; i < amount; i++)
                {
                    items.Add(_wH.GetRandomItem());
                }
                if(items != null)
                    c.ShopCart.Items.AddRange(items);
                Task.Run(() =>
                {
                    Thread.Sleep(_rng.Next(config.maxClientTimeInShop));
                    c.IsDoneShopping = true;
                    _queue.Add(c);
                });
            }
        }
        private void PickClients(int amount)
        {
            amount = amount < _entities.Clients.Count ? amount : _entities.Clients.Count;
            amount = _rng.Next(amount);
            int index;
            for (int i = 0; i < amount; i++)
            {
                index = _rng.Next(_entities.Clients.Count);
                Client c = _entities.Clients[index];
                _entities.Clients.RemoveAt(index);
                Task.Run(() => FillCart(c, config.maxItemsAmountInCart));
            }
        }
        private void GenerateClients(int amount, int delay)
        {
            while (_isActive)
            {
                for (int i = 0; i < amount; i++)
                {
                    if (Rng(config.newClientRate))
                        _entities.Clients.Add(_cG.GenerateNextClient());
                    Thread.Sleep(_rng.Next(delay));
                }
                if (config.autoDecay)
                {
                    if (config.newClientRate > 0)
                    {
                        config.newClientRate -= 0.15;
                        if (config.newClientRate < 0)
                            config.newClientRate = 0;
                    }
                }
            }
        }
        private bool Rng(double percentage)
        {
            return _rng.NextDouble() < percentage;
        }
    }
}
