using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Cashier : Employee
    {

    }
}
