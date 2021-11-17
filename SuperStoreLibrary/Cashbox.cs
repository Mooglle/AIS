using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperStoreLibrary
{
    public class Cashbox
    {
        public int ID { get; set; }
        public decimal Cash { get; set; }
        public bool IsFree { get; set; }
        public Cashier Cashier { get; set; }
        public static int Count = 0;
        public Cashbox()
        {
            ID = Count;
            Count++;
            Cash = 0;
            IsFree = true;
        }
    }

    public static class ListExtensions
    {
        public static Cashbox GetNext(this IEnumerable<Cashbox> cashboxes, int waitingInterval, int maxWait)
        {
            bool b = true;
            int counter = 0;
            while (b) {
                foreach (var cb in cashboxes)
                {
                    if (cb.IsFree)
                        return cb;
                }
                if(counter++ > maxWait)
                {
                    break;
                }
                Thread.Sleep(waitingInterval);
            }
            return null;
        }
    }
}
