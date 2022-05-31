using System;
using System.Collections.Generic;
using System.Linq;


namespace TownManager.Services.Patterns.Observer
{
    public interface IPublisher
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        void IncreaseWorkers();
        void DecreaseWorkers();
    }
    public class Publisher : IPublisher
    {
        private int Workers { get; set; }
        private List<IObserver> Observers { get; set; }
        public Publisher()
        {
            Observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            if (Workers >= 10 && Observers.Any())
            {
                foreach (var observer in Observers.Take(1))
                {
                    observer.Update();
                    Detach(observer);
                }
                Workers = 0;
            }
        }

        public void IncreaseWorkers()
        {
            Workers += 2;
            Notify();
        }

        public void DecreaseWorkers()
        {
            Workers -= 2;
        }
    }
}
