using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    internal class Client
    {
        public void Main()
        {
            ConcreteObservable ConcreteObservable = new ConcreteObservable();
            ConcreteObserver ConcreteObserverOne = new ConcreteObserver();
            ConcreteObserver ConcreteObserverTwo = new ConcreteObserver();
            ConcreteObserver ConcreteObserverThree = new ConcreteObserver();
            ConcreteObserver ConcreteObserverFour = new ConcreteObserver();
            ConcreteObservable.Add(ConcreteObserverOne);
            ConcreteObservable.Add(ConcreteObserverTwo);
            ConcreteObservable.Add(ConcreteObserverThree);
            ConcreteObservable.Add(ConcreteObserverFour);
            ConcreteObservable.SetState("New State"); 
            ConcreteObservable.SetState("Another State change");
        }
    }
}
