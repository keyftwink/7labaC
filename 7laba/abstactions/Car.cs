using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7laba.abstactions
{
    abstract class Car : Transport
    {

        public string Brand { get; set; }

        public string GetInformation()
        {
            return $"{Brand} грузоподъемностью в {LoadCapacity} кг может проехать {Distance} км со скоростью {Speed}км/ч";
        }
    }
}
