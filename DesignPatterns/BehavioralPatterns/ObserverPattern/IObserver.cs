using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    internal interface IObserver
    {
        IObservable Observable { get; set; }
        public void Update();
    }
}
