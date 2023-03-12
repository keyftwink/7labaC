using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7laba.abstactions
{
    abstract class Airplane : Transport
    {
        public string Model { get; set; }

        public string GetInformation()
        {
            return $"{Model} грузоподъемностью в {LoadCapacity} кг может пролететь {Distance} км со скоростью {Speed}км/ч";
        }
    }
}
