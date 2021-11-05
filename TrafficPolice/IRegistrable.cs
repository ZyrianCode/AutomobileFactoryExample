using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace TrafficPolice
{
    public interface IRegistrable : IBaseType
    {
        public string Number { get; set; }
    }
}
