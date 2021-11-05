using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationConfigurators.Zyrian.AdditionalConfigurators;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesBase;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace CreationConfigurators.Zyrian.ConfiguratorBase
{
    public interface IAutomobileConfigurator : IConfigurator
    {
        public IAutomobileConfigurator AddBrand(string brandName);
        public IAutomobileConfigurator AddModel(string modelName);
        public IAutomobileConfigurator SetupSpeedRange(ISpeedRange speedRange);
        public IAutomobileConfigurator AddEngine(IEngine engine);
        public IAutomobileConfigurator AddTransmission(ITransmission transmission);
        public IAutomobileConfigurator AddWheels(IWheelsBundle wheels);
    }
}
