using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace Entities.AutomobileParts.AbstractParts
{
    /// <summary>
    /// Интерфейс пакета колёс.
    /// </summary>
    /// <remarks> Задаёт контракт пакету колёс. Содержит в себе ровно 4 колеса. </remarks>
    public interface IWheelsBundle : IBaseType
    {
        public string Name { get; set; }

        public IWheel ForwardLeftWheel { get; set; }
        public IWheel ForwardRightWheel { get; set; }
        public IWheel BackwardLeftWheel { get; set; }
        public IWheel BackwardRightWheel { get; set; }
    }
}
