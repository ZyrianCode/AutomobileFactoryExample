using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationConfigurators.Zyrian.ConfiguratorBase;
using CreationConfigurators.Zyrian.Templates;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesBase;

namespace CreationConfigurators.Zyrian.Facades
{
    public class AutomobileConfigurationFacade<TAutomobileType>
    where TAutomobileType : IAutomobile, new()
    {
        private readonly AutomobilePartsConfigurationFacade _automobilePartsConfigurator = new();
        
        public IAutomobile ProduceAutomobile(ConfigurationTemplate componentsForProduce)
        {
            return new AutomobileConfigurator<TAutomobileType>()
                .AddBrand(componentsForProduce.Brand)
                .AddModel(componentsForProduce.Model)
                .AddEngine(
                    _automobilePartsConfigurator
                        .ConfigureEngine(componentsForProduce.Engine)
                )
                .AddWheels(
                    _automobilePartsConfigurator.ConfigureWheelsBundle(
                        componentsForProduce.WheelsBundle,

                        _automobilePartsConfigurator
                            .ConfigureWheel(componentsForProduce.Wheel)
                    ))
                .AddTransmission(
                    _automobilePartsConfigurator
                        .ConfigureTransmission(componentsForProduce.Transmission)
                )
                .SetupSpeedRange(
                    _automobilePartsConfigurator
                    .ConfigureSpeedRange(componentsForProduce.SpeedRange))
                .Configure() as IAutomobile;
        }
    }
}
