using BaseTypes.MainBaseTypes;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace CreationConfigurators.Zyrian.Templates
{
    public class ConfigurationTemplate : IBaseType
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public IEngine Engine { get; set; }
        public IWheel Wheel { get; set; }
        public IWheelsBundle WheelsBundle { get; set; }
        public ITransmission Transmission { get; set; }
        public ISpeedRange SpeedRange { get; set; }
    }
}
