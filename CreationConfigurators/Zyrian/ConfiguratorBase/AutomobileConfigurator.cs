using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesBase;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace CreationConfigurators.Zyrian.ConfiguratorBase
{
    public class AutomobileConfigurator<TAutomobileType> : IAutomobileConfigurator
    where TAutomobileType : IAutomobile, new()
    {
        private IAutomobile _automobile = new TAutomobileType();

        public void SetConfigurableObjectType(IAutomobile automobile)
        {
            _automobile = automobile;
        }

        public IAutomobileConfigurator AddBrand(string brandName)
        {
            _automobile.Brand = brandName;
            return this;
        }

        public IAutomobileConfigurator AddModel(string modelName)
        {
            _automobile.Model = modelName;
            return this;
        }

        public IAutomobileConfigurator SetupSpeedRange(ISpeedRange speedRange)
        {
            _automobile.SpeedRange = speedRange;
            return this;
        }

        public IAutomobileConfigurator AddEngine(IEngine engine)
        {
            _automobile.Engine = engine;
            return this;
        }

        public IAutomobileConfigurator AddTransmission(ITransmission transmission)
        {
            _automobile.Transmission = transmission;
            return this;
        }

        public IAutomobileConfigurator AddWheels(IWheelsBundle wheels)
        {
            _automobile.Wheels = wheels;
            return this; 
        }

        public IBaseType Configure() => _automobile;
    }
}
