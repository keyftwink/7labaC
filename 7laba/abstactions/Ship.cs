using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7laba.abstactions
{
    abstract class Ship : Transport
    {
        public string Name { get; set; }

        public string GetInformation()
        {
            return $"{Name} грузоподъемностью в {LoadCapacity} кг может проплыть {Distance} км со скоростью {Speed}км/ч";
        }
    }
}
