using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace CreationConfigurators.Zyrian.AdditionalConfigurators
{
    public class SpeedRangeConfigurator
    {
        private ISpeedRange _speedRange;

        public SpeedRangeConfigurator SetSpeedRangeType(ISpeedRange speedRangeType)
        {
            _speedRange = speedRangeType ?? throw new ArgumentNullException(nameof(speedRangeType));
            return this;
        }
        public SpeedRangeConfigurator SetSpeedRange(int maxSpeed)
        {
            _speedRange.MaxSpeed = maxSpeed;
            return this;
        }

        public ISpeedRange Configure() => _speedRange;
    }
}
