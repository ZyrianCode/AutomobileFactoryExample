using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.AutomobileParts.AbstractParts;

namespace CreationConfigurators.Zyrian.AdditionalConfigurators
{
    public class WheelsConfigurator
    {
        private IWheel _wheel;

        public WheelsConfigurator SetWheelType(IWheel wheel)
        {
            _wheel = wheel ?? throw new ArgumentNullException(nameof(wheel));
            return this;
        }

        public WheelsConfigurator SetName(string name)
        {
            _wheel.Name = name;
            return this;
        }

        public IWheel Configure() => _wheel;
    }
}
