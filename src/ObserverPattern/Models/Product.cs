using System.Collections.Generic;

namespace ObserverPattern.Models
{
    public class Product
    {
        readonly List<Observer.Observer> Observers;

        public Product()
        {
            Observers = new List<Observer.Observer>();
        }

        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        private bool _isPriceDown;

        public bool IsPriceDown
        {
            get => _isPriceDown;
            set
            {
                if (value) Notify();
                _isPriceDown = value;
            }
        }

        public void Notify()
        {
            Observers.ForEach(g => { g.Update(); });
        }

        public void SubscribeAdd(Observer.Observer obServer)
        {
            Observers.Add(obServer);
        }

        public void SubscriveRemove(Observer.Observer obServer)
        {
            Observers.Remove(obServer);
        }
    }
}