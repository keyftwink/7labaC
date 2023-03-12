using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7laba.abstactions
{
    abstract class Transport
    {
        abstract public int Speed { get; }
        abstract public int LoadCapacity { get; }
        abstract public int Distance { get; }

        public abstract int GetSpeed();
        public abstract int GetLoadCapacity();
        public abstract int GetDistance();


    }
}
