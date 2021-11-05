using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace Entities.AutomobileParts.AbstractParts
{
    public interface IWheel : IBaseType
    {
        public string Name { get; set; }
    }
}
