using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    internal class ConcreteObserver : IObserver
    {
        public IObservable Observable { get; set; }

        public void Update()
        {
            Console.WriteLine((Observable as ConcreteObservable)?.GetState());
        }
    }
}
