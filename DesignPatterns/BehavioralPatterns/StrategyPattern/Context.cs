using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    internal class Context
    {
        private IStrategy Strategy;

        public Context()
        {

        }
        
        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            Strategy.Execute();
        }
    }
}
