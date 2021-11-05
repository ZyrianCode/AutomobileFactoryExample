using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobilePartsWarehouse.Zyrian.Assortment.Engines.CommonCarEngines;
using AutomobilePartsWarehouse.Zyrian.Assortment.Engines.SportCarEngines;
using AutomobilePartsWarehouse.Zyrian.Assortment.Transmissions;
using AutomobilePartsWarehouse.Zyrian.Assortment.Wheels;
using AutomobilePartsWarehouse.Zyrian.Assortment.WheelsBundles;
using CreationConfigurators.Zyrian.Providers;
using CreationConfigurators.Zyrian.TemplateConfigurators;
using CreationConfigurators.Zyrian.Templates;
using Entities.Automobiles.AutomobileStrategies.ConcreteVariations;

namespace CreationConfigurators.Zyrian.Facades
{
    public class UserFacade : ITemplateProvider
    {
        private ConfigurationTemplate _template = new();

        public UserFacade SetSportCarTemplate()
        {
            _template = new TemplateConfigurator()
                .SetConfigurationTemplate(_template)
                .AddWheel(new WheelsTypeOne())
                .AddBrand("BrandOne")
                .AddModel("SportModelOne")
                .AddEngine(new SportCarEngineOne())
                .AddWheels(new WheelsBundleOne())
                .AddTransmission(new TransmissionOne())
                .SetupSpeedRange(new SuperFastSpeedRange())
                .Configure() as ConfigurationTemplate;

            return this;
        }

        public UserFacade SetCommonAutomobileTemplate()
        {
            _template = new TemplateConfigurator()
                .SetConfigurationTemplate(_template)
                .AddWheel(new WheelsTypeOne())
                .AddBrand("BrandOne")
                .AddModel("CommonModelOne")
                .AddEngine(new CommonCarEngineOne())
                .AddWheels(new WheelsBundleOne())
                .AddTransmission(new TransmissionOne())
                .SetupSpeedRange(new FastSpeedRange())
                .Configure() as ConfigurationTemplate;

            return this;
        }

        public ConfigurationTemplate? ProvideConfiguration() => _template;
    }
}
