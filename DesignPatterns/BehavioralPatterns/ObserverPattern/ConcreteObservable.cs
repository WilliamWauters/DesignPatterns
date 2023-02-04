using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    internal class ConcreteObservable : IObservable
    {
        private List<IObserver> Observers = new List<IObserver>();
        private string State = "Inital State";

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
            observer.Observable = this;
        }

        public void Notify()
        {
            foreach(IObserver observer in Observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public string GetState() 
        { 
            return State;
        }

        public void SetState(string state)
        {
            State = state;
            this.Notify();
        }
    }
}
