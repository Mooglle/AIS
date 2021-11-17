using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary.Generation
{
    public class ClientGenerator
    {
        private int _idTracker = -1;
        private Random _rnd = new Random();
        private List<string> _firstNames = new List<string>() {
        "Ivan", "Michael", "John", "Alexander", "Kirill", "Peter"
        };
        private List<string> _lastNames = new List<string>() {
        "White", "Carpenter", "Belov", "Kuznetcov", "Bourne", "Filatov"
        };
        private List<string> _phoneNumbers = new List<string>() {
        "82-93-94", "+7-923-848-49-20", "+2-828-394-83-83", "82-94-58", "83-58-28", "56-28-00"
        };
        public Client GenerateNextClient()
        {
            _idTracker++;
            return new Client() { ID = _idTracker, FirstName = _firstNames[_rnd.Next(0, _firstNames.Count - 1)],
                LastName = _lastNames[_rnd.Next(0, _lastNames.Count - 1)],
                PhoneNumber = _phoneNumbers[_rnd.Next(0, _phoneNumbers.Count)],
                ShopCart = new ShopCart()
            };
        }
    }
}
