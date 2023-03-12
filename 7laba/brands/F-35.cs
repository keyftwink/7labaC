using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7laba.abstactions;


namespace _7laba.brands
{
    internal class F_35 : Airplane
    {
        public override int Speed => 2000;

        public override int LoadCapacity => 7400;

        public override int Distance => 3000;

        public F_35()
        {
            Model = "F-35";
        }

        public override int GetDistance()
        {
            return Speed;
        }

        public override int GetLoadCapacity()
        {
            return LoadCapacity;
        }

        public override int GetSpeed()
        {
           return Distance;
        }

    }
}
