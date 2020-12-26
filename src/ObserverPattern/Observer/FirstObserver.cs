using System;

namespace ObserverPattern.Observer
{
    public class FirstObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("FirstObServer Notified!");
        }
    }
}