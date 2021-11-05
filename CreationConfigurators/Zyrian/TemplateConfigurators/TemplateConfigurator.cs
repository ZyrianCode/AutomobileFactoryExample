using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;
using CreationConfigurators.Zyrian.ConfiguratorBase;
using CreationConfigurators.Zyrian.Templates;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesBase;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace CreationConfigurators.Zyrian.TemplateConfigurators
{
    public class TemplateConfigurator : IAutomobileConfigurator
    {
        private ConfigurationTemplate _template;

        public TemplateConfigurator SetConfigurationTemplate(ConfigurationTemplate template)
        {
            _template = template;
            return this;
        }

        public IAutomobileConfigurator AddBrand(string brandName)
        {
            _template.Brand = brandName;
            return this;
        }

        public IAutomobileConfigurator AddModel(string modelName)
        {
            _template.Model = modelName;
            return this;
        }

        public IAutomobileConfigurator SetupSpeedRange(ISpeedRange speedRange)
        {
            _template.SpeedRange = speedRange;
            return this;
        }

        public IAutomobileConfigurator AddEngine(IEngine engine)
        {
            _template.Engine = engine;
            return this;
        }

        public IAutomobileConfigurator AddTransmission(ITransmission transmission)
        {
            _template.Transmission = transmission;
            return this;
        }

        public IAutomobileConfigurator AddWheels(IWheelsBundle wheels)
        {
            _template.WheelsBundle = wheels;
            return this;
        }

        public TemplateConfigurator AddWheel(IWheel wheel)
        {
            _template.Wheel = wheel;
            return this;
        }

        public IBaseType Configure() => _template;
    }
}
