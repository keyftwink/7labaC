using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _7laba.abstactions;


namespace _7laba.brands
{
    internal class ChevroletCamaro : Car
    {
        public override int Speed => 240;

        public override int LoadCapacity => 300;

        public override int Distance => 1000;

        public ChevroletCamaro()
        {
            Brand = "ChevroletCamaro";
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
