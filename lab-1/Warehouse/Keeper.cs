﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Keeper : Worker
    {
        public Keeper(string firstName, string lastName) : base(firstName, lastName) {}

        public override bool DoWork()
        {
            // logic
            return true;
        }
    }
}
