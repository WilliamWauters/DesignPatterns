using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    internal class Client
    {
        public void Main()
        {
            var Context = new Context(new ConcreteStrategyOne());
            Context.ExecuteStrategy();
            Context.SetStrategy(new ConcretStrategyTwo());
            Context.ExecuteStrategy();
            Context.SetStrategy(new ConcreteStrategyOne());
            Context.ExecuteStrategy();
            Context.SetStrategy(new ConcretStrategyTwo());
            Context.ExecuteStrategy();
        }
    }
}
