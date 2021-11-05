using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.AutomobileParts.AbstractParts;

namespace CreationConfigurators.Zyrian.AdditionalConfigurators
{
    public class WheelBundlesConfigurator
    {
        private IWheelsBundle _wheelsBundle;

        public WheelBundlesConfigurator SetWheelBundleType(IWheelsBundle wheelsBundle)
        {
            _wheelsBundle = wheelsBundle ?? throw new ArgumentNullException(nameof(wheelsBundle));
            return this;
        }

        public WheelBundlesConfigurator SetName(string name)
        {
            _wheelsBundle.Name = name;
            return this;
        }

        public WheelBundlesConfigurator FillBundleWithWheels(IWheel wheel)
        {
            _wheelsBundle.BackwardLeftWheel = wheel;
            _wheelsBundle.BackwardRightWheel = wheel;
            _wheelsBundle.ForwardLeftWheel = wheel;
            _wheelsBundle.ForwardRightWheel = wheel;
            return this;
        }

        public IWheelsBundle Configure() => _wheelsBundle;
    }
}
