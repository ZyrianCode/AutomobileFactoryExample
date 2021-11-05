using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace Entities.AutomobileParts.AbstractParts
{
    public interface IEngine : IBaseType
    {
        public string Name { get; set; }
        public int CountOfCylinders { get; set; }
        public string Type { get; set; }
    }
}
