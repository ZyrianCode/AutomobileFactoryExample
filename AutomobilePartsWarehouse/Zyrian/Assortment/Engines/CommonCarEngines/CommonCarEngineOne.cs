using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.AutomobileParts.AbstractParts;

namespace AutomobilePartsWarehouse.Zyrian.Assortment.Engines.CommonCarEngines
{
    public class CommonCarEngineOne : IEngine
    {
        public string Name { get; set; }
        public int CountOfCylinders { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Наименование: {Name}," +
                   $"Количество цилиндров: {CountOfCylinders}," +
                   $"Тип: {Type}";

        }
    }
}
