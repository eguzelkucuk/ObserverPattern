using System;

namespace ObserverPattern.Observer
{
    public class SecondObserver: Observer
    {
        public override void Update()
        {
            Console.WriteLine("SecondObServer Notified!");
        }
    }
}