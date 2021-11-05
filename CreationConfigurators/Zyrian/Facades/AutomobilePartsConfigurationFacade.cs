using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationConfigurators.Zyrian.AdditionalConfigurators;
using CreationConfigurators.Zyrian.Enums;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileStrategies.Abstract;
using InputHelpers.Zyrian.Providers.MessageProviders.Base;
using InputHelpers.Zyrian.Providers.MessageProviders.Options;
using InputHelpers.Zyrian.TerminalMessageWriters;

using engineOptions = CreationConfigurators.Zyrian.Enums.EngineConfigurationOptions;

namespace CreationConfigurators.Zyrian.Facades
{
    public class AutomobilePartsConfigurationFacade
    {
        private readonly MessageWriter _messageWriter = new();
        private readonly MessagesProvider _messagesProvider = new();

        public IEngine ConfigureEngine(IEngine engine)
        {
            _messageWriter.SetListOfMessages(ProvideMessages(ProviderOptions.ConfigureEngine));
            List<string> message = _messageWriter.ShowMessages().ToList();

            return new EngineConfigurator()
                .SetEngineType(engine)
                .SetName(message[(int)engineOptions.Name])
                .SetType(message[(int)engineOptions.Type])
                .SetCountOfCylinders(int.Parse(message[(int)engineOptions.CylindersCount]))
                .Configure();
        }

        public IWheel ConfigureWheel(IWheel wheel)
        {
            _messageWriter.SetListOfMessages(ProvideMessages(ProviderOptions.ConfigureWheels));
            List<string> name = _messageWriter.ShowMessages().ToList();

            return new WheelsConfigurator()
                .SetWheelType(wheel)
                .SetName(name[(int)NameOptions.Name])
                .Configure();
        }

        public IWheelsBundle ConfigureWheelsBundle(IWheelsBundle wheelBundle, IWheel wheel)
        {
            _messageWriter.SetListOfMessages(ProvideMessages(ProviderOptions.ConfigureWheelsBundles));
            List<string> name = _messageWriter.ShowMessages().ToList();

            return new WheelBundlesConfigurator()
                .SetWheelBundleType(wheelBundle)
                .SetName(name[(int)NameOptions.Name])
                .FillBundleWithWheels(wheel)
                .Configure();
        }

        public ITransmission ConfigureTransmission(ITransmission transmission)
        {
            _messageWriter.SetListOfMessages(ProvideMessages(ProviderOptions.ConfigureTransmission));
            List<string> name = _messageWriter.ShowMessages().ToList();

            return new TransmissionConfigurator()
                .SetTransmissionType(transmission)
                .SetName(name[(int)NameOptions.Name])
                .Configure();
        }

        public ISpeedRange ConfigureSpeedRange(ISpeedRange speedRange)
        {
            _messageWriter.SetListOfMessages(ProvideMessages(ProviderOptions.ConfigureSpeedRange));
            List<string> maxSpeed = _messageWriter.ShowMessages().ToList();

            return new SpeedRangeConfigurator()
                .SetSpeedRangeType(speedRange)
                .SetSpeedRange(int.Parse(maxSpeed[(int)SpeedRangeOptions.MaxSpeed] ?? string.Empty))
                .Configure();
        }

        private List<string> ProvideMessages(ProviderOptions providerOptions) => 
            _messagesProvider.ProvideMessages(providerOptions);
    }
}
