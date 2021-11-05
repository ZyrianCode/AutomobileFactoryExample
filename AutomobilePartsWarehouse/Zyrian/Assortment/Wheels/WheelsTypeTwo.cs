using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.AutomobileParts.AbstractParts;

namespace AutomobilePartsWarehouse.Zyrian.Assortment.Wheels
{
    public class WheelsTypeTwo : IWheel
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Наименование: {Name}";
        }
    }


}
