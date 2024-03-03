using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Manager : Worker
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName) {}

        public override bool DoWork()
        {
            // outstanding logic
            return true;
        }
    }
}
