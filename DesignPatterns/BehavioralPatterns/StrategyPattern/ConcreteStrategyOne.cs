﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    internal class ConcreteStrategyOne : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Using Strategy One ...");
        }
    }
}
