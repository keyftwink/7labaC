
using _7laba.abstactions;
using System.Reflection;

namespace _7laba.brands
{
    internal class Moscow : Ship
    {

        public override int Speed => 60;

        public override int LoadCapacity => 11_500_000;

        public override int Distance => 4630;

        public Moscow()
        {
            Name = "Moscow";
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
