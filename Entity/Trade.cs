﻿ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHome.Entity
{
    public class Trade
    {
        public decimal Volume = 0m;
         
        public decimal Price = 0m;

        public Side Side = Side.None; // Enam

        public DateTime DateTime = DateTime.MinValue;

    }
}
